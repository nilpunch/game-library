using UnityEngine;

namespace PhysicsSample
{
    public interface ISphereShell
    {
        Vector3 Center { get; }
        float Radius { get; }
    }
}