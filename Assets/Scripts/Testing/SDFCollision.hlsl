// sampler2D _MainTex;
// float4 _MainTex_ST;

float2 _Mouse;

struct VertexInput
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};

struct VertexOutput
{
    float2 uv : TEXCOORD0;
    float4 vertex : SV_POSITION;
    float2 worldUv : WORLD_UV;
};

#define USE_GRADIENT_DESCENT 0
#define USE_FRANK_WOLFE 1
#define USE_GOLDEN_SECTION_SEARCH 0

//---------------------------------------------------------------------
// Distance routines (courtesy Inigo Quilez https://iquilezles.org)

float lsign(float2 p1, float2 p2, float2 p3)
{
    return (p1.x - p3.x) * (p2.y - p3.y) - (p2.x - p3.x) * (p1.y - p3.y);
}

float3 lclosest(float2 p, float2 a, float2 b)
{
    float2 pc = lerp(a, b, clamp(dot(p - a, b - a) / dot(b - a, b - a), 0., 1.));
    return float3(pc, length(p - pc));
}

float3 lselect(float3 pc1, float3 pc2)
{
    return pc1.z < pc2.z ? pc1 : pc2;
}

float sdTri(float2 p, float scale)
{
    float2 a = float2(-3., -1.75) * scale;
    float2 b = float2(0., 3.5) * scale;
    float2 c = float2(3., -1.75) * scale;

    float e = max(max(lsign(p, a, b), lsign(p, b, c)), lsign(p, c, a));

    return e;
}

float2 sdTriGrad(float2 x, float scale)
{
    float2 dfdx;
    float eps = 0.001;

    dfdx.x = sdTri(x + float2(eps, 0.0), scale) - sdTri(x + float2(-eps, 0.0), scale);
    dfdx.y = sdTri(x + float2(0.0, eps), scale) - sdTri(x + float2(0.0, -eps), scale);
    dfdx /= 2.0 * eps;

    return dfdx;
}

float sdBox(in float2 p, in float2 b)
{
    float2 d = abs(p) - b;
    return length(max(d, float2(0, 0))) + min(max(d.x, d.y), 0.0);
}

float2 sdBoxGrad(float2 x, float2 b)
{
    float2 dfdx;
    float eps = 0.001;

    dfdx.x = sdBox(x + float2(eps, 0.0), b) - sdBox(x + float2(-eps, 0.0), b);
    dfdx.y = sdBox(x + float2(0.0, eps), b) - sdBox(x + float2(0.0, -eps), b);
    dfdx /= 2.0 * eps;

    return dfdx;
}

float sdCircle(float2 p, float radius)
{
    return length(p) - radius;
}

float2 sdCircleGrad(float2 x, float radius)
{
    float2 dfdx;
    float eps = 0.001;

    dfdx.x = sdCircle(x + float2(eps, 0.0), radius) - sdCircle(x + float2(-eps, 0.0), radius);
    dfdx.y = sdCircle(x + float2(0.0, eps), radius) - sdCircle(x + float2(0.0, -eps), radius);
    dfdx /= 2.0 * eps;

    return normalize(x);
}

float sdLine(in float2 p, in float2 a, in float2 b)
{
    float2 pa = p - a, ba = b - a;
    float h = clamp(dot(pa, ba) / dot(ba, ba), 0.0, 1.0);
    return length(pa - ba * h);
}

float sdHorseshoe(in float2 p, in float2 c, in float r, in float2 w)
{
    p.x = abs(p.x);
    float l = length(p);
    float2 p2 = mul(float2x2(-c.x, c.y, c.y, c.x), p);
    p2 = (float2((p2.y > 0.0) ? p2.x : l * sign(-c.x),
                 (p2.x > 0.0) ? p2.y : l)).xy;
    p2 = float2(p2.x, abs(p2.y - r)) - w;
    return length(max(p2, 0.0)) + min(0.0, max(p2.x, p2.y));
}

float sdUnevenCapsule(float2 p, float r1, float r2, float h)
{
    p.x = abs(p.x);
    float b = (r1 - r2) / h;
    float a = sqrt(1.0 - b * b);
    float k = dot(p, float2(-b, a));
    if (k < 0.0) return length(p) - r1;
    if (k > a * h) return length(p - float2(0.0, h)) - r2;
    return dot(p, float2(a, b)) - r1;
}

float sdScene(float2 x)
{
    float angle = 3.14159265359 / 4.0;
    float2 c = float2(sin(angle), cos(angle));
    float2x2 rotation = float2x2(-c.x, c.y, c.y, c.x);
    
    float circle = sdCircle(x + float2(2, 0), 0.5); //sdBox(x + float2(2, 2), float2(0.5, 0.5));
    float box = sdBox(x + float2(-2, 0), 0.5);
    float boxRotated = sdBox(mul(rotation, x + float2(-2, 2)), 0.5);
    float tri = sdTri(x + float2(2, 2), -0.2);

    float horseshoe = sdBox(x + float2(-2, 0), float2(0.5, 0.5));
    // sdHorseshoe(x + float2(2, -2), float2(sin(angle), cos(angle)), 0.6, float2(0.6, 0.25));

    
    
    float2 difference = sdTri(x, -0.2) * sdTriGrad(x, -0.2);

    float d = box;
    //d = min(d, horseshoe);
    d = min(d, box);
    d = min(d, boxRotated);
    d = min(d, circle);
    d = min(d, tri);

    //float d = sdUnevenCapsule(x+float2(0.0, 0.5), 0.1, 0.5, 1.0);

    return d;
}

float2 sdSceneGrad(float2 x)
{
    float2 dfdx;
    float eps = 0.001;

    dfdx.x = sdScene(x + float2(eps, 0.0)) - sdScene(x + float2(-eps, 0.0));
    dfdx.y = sdScene(x + float2(0.0, eps)) - sdScene(x + float2(0.0, -eps));
    dfdx /= 2.0 * eps;

    return dfdx;
}

//----------------------------------------------------
// Drawing routines

float isocontour(float s, float width, float freq)
{
    return smoothstep(1.0 - width, 1.0, abs(sin(s * freq)));
}

float zerocontour(float d, float width)
{
    return 1.0 - smoothstep(0.0, width, abs(d));
}

float3 gradient(float d, float3 a, float3 b, float scale)
{
    if (d < 0.0)
        return lerp(float3(1.0, 1.0, 0.3), float3(1.0, 0.2, 0.0), -1.5 * d / scale);
    else
        return lerp(float3(0.0, 0.1, 0.80), float3(0.3, 0.6, 1.0), min(1.0, 0.5 * d / scale));
}

void blend(inout float3 dest, float4 src)
{
    dest = dest * (1.0 - src.w) + src.xyz;
}


float4 circle(float2 x, float2 c, float radius)
{
    float d = length(x - c);
    float3 col = float3(0, 0, 0);

    if (d < radius)
        col = float3(1, 1, 1);

    float alpha = zerocontour(d - radius, 0.01);
    col *= 1.0 - alpha;

    return float4(col, alpha);
}

fixed4 CollisionAgainstLine(VertexOutput i)
{
    float3 col = 0; //tex2D(_MainTex, i.uv);

    float zoom = 2.0; // 2.0;
    float sensitivity = 0.4; // 2.0;
    float2 p = (i.uv - 0.5) * 2.0 * zoom;
    float2 mouse = float2(i.worldUv.x, i.worldUv.y) * sensitivity;

    float sdf = sdScene(p);

    // line
    float2 a = float2(-0.0, 1.0) + mouse;
    float2 b = float2(1.0, -0.0) + mouse;

    float dline = sdLine(p, a, b);

    // barycentric coordinates
    float u = 0.5;
    float v = 1.0 - u;

    // initial guess
    float2 x = u * a + v * b;

    col = float3(1, 1, 1);

    col = gradient(sdf, float3(0.0, 0.0, 1.0), float3(1.0, 0.0, 1.0), 0.5) * 0.8;

    # if USE_GOLDEN_SECTION_SEARCH

    float gr = (sqrt(5.0) + 1.0) / 2.0;

    u = 0.0;
    v = 1.0;

    float c = v - (v - u) / gr;
    float d = u + (v - u) / gr;

    #endif

    for (int i = 0; i < 32; ++i)
    {
        #if USE_GRADIENT_DESCENT

        // projected gradient descent
	    float2 dfdx = sdSceneGrad(x);               
        float dfdu = dot(dfdx, a - b);
       
    	const float alpha = 0.05;

		u -= alpha*dfdu;

        // projection
	    u = max(u, 0.0);
        u = min(u, 1.0);
        v = 1.0-u;

		x = u*a + v*b;
        #endif

        #if USE_FRANK_WOLFE

        // Franke-Wolfe
        float2 dfdx = sdSceneGrad(x);
        float da = dot(a, dfdx);
        float db = dot(b, dfdx);

        float2 s;
        if (da < db)
            s = a;
        else
            s = b;

        float gamma = 0.3 * 2.0 / (float(i) + 2.0);

        x = (1.0 - gamma) * x + gamma * s;
        #endif


        #if USE_GOLDEN_SECTION_SEARCH

        // Golden Section Search
        float mid = (v + u) / 2.0;

        x = mid * a + (1.0 - mid) * b;

        if (sdScene(a * c + b * (1.0 - c)) < sdScene(a * d + b * (1.0 - d)))
            v = d;
        else
            u = c;

        c = v - (v - u) / gr;
        d = u + (v - u) / gr;

        #endif

        // visualize iterates
        col += float3(circle(p, x, 0.1).xyz) * float3(0.0, 0.2, 0.0);
    }

    col *= 1.0 - isocontour(sdf, 0.01, 40.0) * 0.2;
    col *= 1.0 - zerocontour(sdf, 0.01);

    col *= float3(1, 1, 1) - zerocontour(dline, 0.01);
    blend(col, circle(p, a, 0.05));
    blend(col, circle(p, b, 0.05));


    // mouse cursor
    //col += circle(p, mouse, 0.1)*float3(0.4, 0.0, 0.0);    

    // closest point on line
    blend(col, circle(p, x, 0.05));

    // closest point on the sdf
    float2 cp = x - sdSceneGrad(x) * sdScene(x);
    blend(col, circle(p, cp, 0.05));

    // Output to screen
    return float4(col, 1.0);
}

fixed4 SDFVisualization(VertexOutput i)
{
    float zoom = 8.0; // 2.0;
    float sensitivity = 0.2 * zoom; // 2.0;
    float2 mouse = float2(i.worldUv.x, i.worldUv.y) * sensitivity;
    float2 p = (i.uv - 0.5) * 2.0 * zoom - mouse;


    float sdf = sdScene(p);

    // barycentric coordinates
    float u = 0.5;
    float v = 1.0 - u;

    float4 col = float4(gradient(sdf, float3(0.0, 0.0, 1.0), float3(1.0, 0.0, 1.0), 0.5) * 0.8, 0.75);

    col *= 1.0 - isocontour(sdf, 0.01, 40.0) * 0.2;
    col *= 1.0 - zerocontour(sdf, 0.01);

    float box = sdCircle(p, 0.5);
    float angle = 0.3;
    float horseshoe = sdBox(p + _Mouse, float2(0.5, 0.5));
    //col += float4(gradient(max(box, horseshoe), float3(0.0, 1.0, 0.0), float3(1.0, 1.0, 0.0), 0.5) * 0.8, 0.25);

    // col += circle(p, float2(0.5, 0.5), 0.05);

    return float4(col);
}

VertexOutput Vertex(VertexInput v)
{
    VertexOutput o;
    o.vertex = UnityObjectToClipPos(v.vertex);
    o.uv = v.uv; // TRANSFORM_TEX(v.uv, _MainTex);
    o.worldUv = mul(unity_ObjectToWorld, float4(1, 1, 1, 1)).xz;
    return o;
}

fixed4 Fragment(VertexOutput i) : SV_Target
{
    return SDFVisualization(i);
}
