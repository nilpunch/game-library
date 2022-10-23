namespace GameLibrary
{
    public class SphereShell : ISphereShell
    {
        public SphereShell(Vector3 center, FloatingPoint radius)
        {
            Center = center;
            Radius = radius;
        }

        public Vector3 Center { get; }
        public FloatingPoint Radius { get; }
    }
}