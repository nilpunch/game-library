using UnityEngine;

namespace PhysicsSample
{
    public interface IBoxShell
    {
        Vector3 Center { get; }
        Quaternion Rotation { get; }
        Vector3 Size { get; }
    }
}