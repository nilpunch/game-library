using System;

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct AABB
    {
        public Float3 _center;
        public Float3 _extents;

        public Float3 Size { get { return _extents * 2; } }
        public Float3 Min { get { return _center - _extents; } }
        public Float3 Max { get { return _center + _extents; } }

        /// <summary>Returns a string representation of the AABB.</summary>
        public override string ToString()
        {
            return $"AABB(Center:{_center}, Extents:{_extents}";
        }

        public bool Contains(Float3 point)
        {
            if (point[0] < _center[0] - _extents[0])
                return false;
            if (point[0] > _center[0] + _extents[0])
                return false;

            if (point[1] < _center[1] - _extents[1])
                return false;
            if (point[1] > _center[1] + _extents[1])
                return false;

            if (point[2] < _center[2] - _extents[2])
                return false;
            if (point[2] > _center[2] + _extents[2])
                return false;

            return true;
        }

        public bool Contains(AABB b)
        {
            return Contains(b._center + new Float3(-b._extents.x, -b._extents.y, -b._extents.z))
                && Contains(b._center + new Float3(-b._extents.x, -b._extents.y,  b._extents.z))
                && Contains(b._center + new Float3(-b._extents.x,  b._extents.y, -b._extents.z))
                && Contains(b._center + new Float3(-b._extents.x,  b._extents.y,  b._extents.z))
                && Contains(b._center + new Float3(b._extents.x, -b._extents.y, -b._extents.z))
                && Contains(b._center + new Float3(b._extents.x, -b._extents.y,  b._extents.z))
                && Contains(b._center + new Float3(b._extents.x,  b._extents.y, -b._extents.z))
                && Contains(b._center + new Float3(b._extents.x,  b._extents.y,  b._extents.z));
        }

        public SoftFloat DistanceSqr(Float3 point)
        {
            return Math.LengthSqr(Math.Max(Math.Abs(point - _center), _extents) - _extents);
        }

        public static AABB Transform(Float4X4 transform, AABB localBounds)
        {
            AABB transformed;
            transformed._extents = RotateExtents(localBounds._extents, transform.c0.xyz, transform.c1.xyz, transform.c2.xyz);
            transformed._center = Math.transform(transform, localBounds._center);
            return transformed;
        }

        private static Float3 RotateExtents(Float3 extents, Float3 m0, Float3 m1, Float3 m2)
        {
            return Math.Abs(m0 * extents.x) + Math.Abs(m1 * extents.y) + Math.Abs(m2 * extents.z);
        }
    }
}
