using UnityEngine;

namespace PhysicsSample
{
    public interface IConvexShell
    {
        Vector3 Center { get; }
        Mesh Mesh { get; }
    }
}