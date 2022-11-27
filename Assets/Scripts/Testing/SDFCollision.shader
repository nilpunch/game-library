Shader "Custom/SDFCollision"
{
    Properties
    {
        //_MainTex ("Texture", 2D) = "white" {}
        _Mouse ("_Mouse", vector) = (0, 0, 0, 0)
    }
    SubShader
    {
        Tags { "RenderType"="Opaque" }
        LOD 100

        Pass
        {
            CGPROGRAM
            #include "SDFCollision.hlsl"
            #pragma vertex Vertex
            #pragma fragment Fragment
            ENDCG
        }
    }
}
