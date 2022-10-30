using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public class SphereShell : ISphereShell
    {
        public SphereShell(Vector3 center, Scalar radius)
        {
            Center = center;
            Radius = radius;
        }

        public Vector3 Center { get; }
        public Scalar Radius { get; }
    }
}