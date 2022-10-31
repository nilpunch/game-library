using System;

namespace GameLibrary.Mathematics
{
    [Serializable]
    public partial struct AABB
    {
        public float3 Center;
        public float3 Extents;

        public float3 Size { get { return Extents * 2; } }
        public float3 Min { get { return Center - Extents; } }
        public float3 Max { get { return Center + Extents; } }

        /// <summary>Returns a string representation of the AABB.</summary>
        public override string ToString()
        {
            return $"AABB(Center:{Center}, Extents:{Extents}";
        }

        public bool Contains(float3 point)
        {
            if (point[0] < Center[0] - Extents[0])
                return false;
            if (point[0] > Center[0] + Extents[0])
                return false;

            if (point[1] < Center[1] - Extents[1])
                return false;
            if (point[1] > Center[1] + Extents[1])
                return false;

            if (point[2] < Center[2] - Extents[2])
                return false;
            if (point[2] > Center[2] + Extents[2])
                return false;

            return true;
        }

        public bool Contains(AABB b)
        {
            return Contains(b.Center + new float3(-b.Extents.x, -b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new float3(-b.Extents.x, -b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new float3(-b.Extents.x,  b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new float3(-b.Extents.x,  b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new float3(b.Extents.x, -b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new float3(b.Extents.x, -b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new float3(b.Extents.x,  b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new float3(b.Extents.x,  b.Extents.y,  b.Extents.z));
        }

        static float3 RotateExtents(float3 extents, float3 m0, float3 m1, float3 m2)
        {
            return Math.abs(m0 * extents.x) + Math.abs(m1 * extents.y) + Math.abs(m2 * extents.z);
        }

        public static AABB Transform(float4x4 transform, AABB localBounds)
        {
            AABB transformed;
            transformed.Extents = RotateExtents(localBounds.Extents, transform.c0.xyz, transform.c1.xyz, transform.c2.xyz);
            transformed.Center = Math.transform(transform, localBounds.Center);
            return transformed;
        }

        public SoftFloat DistanceSq(float3 point)
        {
            return Math.lengthsq(Math.max(Math.abs(point - Center), Extents) - Extents);
        }
    }
}
