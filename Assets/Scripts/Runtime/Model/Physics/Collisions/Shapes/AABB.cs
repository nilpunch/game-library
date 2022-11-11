using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public readonly struct AABB
    {
        public SoftVector3 Center { get; }
        public SoftVector3 Extents { get; }

        public AABB(SoftVector3 center, SoftVector3 extents)
        {
            Center = center;
            Extents = extents;
        }

        public SoftVector3 Size { get { return Extents * (SoftFloat)2; } }
        public SoftVector3 Min { get { return Center - Extents; } }
        public SoftVector3 Max { get { return Center + Extents; } }

        /// <summary>Returns a string representation of the AABB.</summary>
        public override string ToString()
        {
            return $"AABB(Center:{Center}, Extents:{Extents}";
        }

        public bool Contains(SoftVector3 point)
        {
            if (point.X < Center.X - Extents.X)
                return false;
            if (point.X > Center.X + Extents.X)
                return false;

            if (point.Y < Center.Y - Extents.Y)
                return false;
            if (point.Y > Center.Y + Extents.Y)
                return false;

            if (point.Z < Center.Z - Extents.Z)
                return false;
            if (point.Z > Center.Z + Extents.Z)
                return false;

            return true;
        }

        public bool Contains(AABB b)
        {
            return Contains(b.Center + new SoftVector3(-b.Extents.X, -b.Extents.Y, -b.Extents.Z))
                && Contains(b.Center + new SoftVector3(-b.Extents.X, -b.Extents.Y,  b.Extents.Z))
                && Contains(b.Center + new SoftVector3(-b.Extents.X,  b.Extents.Y, -b.Extents.Z))
                && Contains(b.Center + new SoftVector3(-b.Extents.X,  b.Extents.Y,  b.Extents.Z))
                && Contains(b.Center + new SoftVector3(b.Extents.X, -b.Extents.Y, -b.Extents.Z))
                && Contains(b.Center + new SoftVector3(b.Extents.X, -b.Extents.Y,  b.Extents.Z))
                && Contains(b.Center + new SoftVector3(b.Extents.X,  b.Extents.Y, -b.Extents.Z))
                && Contains(b.Center + new SoftVector3(b.Extents.X,  b.Extents.Y,  b.Extents.Z));
        }

        public SoftFloat DistanceSqr(SoftVector3 point)
        {
            return SoftVector3.LengthSqr(SoftVector3.Max(SoftVector3.Abs(point - Center), Extents) - Extents);
        }

        // public static AABB Transform(Float4X4 transform, AABB localBounds)
        // {
        //     Float3 center = UnityMath.Transform(transform, localBounds.Center);
        //     Float3 extents = RotateExtents(localBounds.Extents, transform.c0.Xyz, transform.c1.Xyz, transform.c2.Xyz);
        //     return new AABB(center, extents);
        // }

        private static SoftVector3 RotateExtents(SoftVector3 extents, SoftVector3 m0, SoftVector3 m1, SoftVector3 m2)
        {
            return SoftVector3.Abs(m0 * extents.X) + SoftVector3.Abs(m1 * extents.Y) + SoftVector3.Abs(m2 * extents.Z);
        }
    }
}
