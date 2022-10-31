using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public struct AABB
    {
        public Float3 Center { get; }
        public Float3 Extents { get; }

        public AABB(Float3 center, Float3 extents)
        {
            Center = center;
            Extents = extents;
        }

        public Float3 Size { get { return Extents * 2; } }
        public Float3 Min { get { return Center - Extents; } }
        public Float3 Max { get { return Center + Extents; } }

        /// <summary>Returns a string representation of the AABB.</summary>
        public override string ToString()
        {
            return $"AABB(Center:{Center}, Extents:{Extents}";
        }

        public bool Contains(Float3 point)
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
            return Contains(b.Center + new Float3(-b.Extents.x, -b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new Float3(-b.Extents.x, -b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new Float3(-b.Extents.x,  b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new Float3(-b.Extents.x,  b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new Float3(b.Extents.x, -b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new Float3(b.Extents.x, -b.Extents.y,  b.Extents.z))
                && Contains(b.Center + new Float3(b.Extents.x,  b.Extents.y, -b.Extents.z))
                && Contains(b.Center + new Float3(b.Extents.x,  b.Extents.y,  b.Extents.z));
        }

        public SoftFloat DistanceSqr(Float3 point)
        {
            return Math.LengthSqr(Math.Max(Math.Abs(point - Center), Extents) - Extents);
        }

        public static AABB Transform(Float4X4 transform, AABB localBounds)
        {
            Float3 center = Math.transform(transform, localBounds.Center);
            Float3 extents = RotateExtents(localBounds.Extents, transform.c0.xyz, transform.c1.xyz, transform.c2.xyz);
            return new AABB(center, extents);
        }

        private static Float3 RotateExtents(Float3 extents, Float3 m0, Float3 m1, Float3 m2)
        {
            return Math.Abs(m0 * extents.x) + Math.Abs(m1 * extents.y) + Math.Abs(m2 * extents.z);
        }
    }
}
