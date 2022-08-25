using UnityEngine;

namespace PhysicsSample
{
    public class SphereShell : ISphereShell
    {
        public SphereShell(Vector3 center, float radius)
        {
            Center = center;
            Radius = radius;
        }

        public Vector3 Center { get; }
        public float Radius { get; }
    }
}