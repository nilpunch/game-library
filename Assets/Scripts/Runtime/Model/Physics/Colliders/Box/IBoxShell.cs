using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface IBoxShell
    {
        Vector3 Center { get; }
        Quaternion Rotation { get; }
        Vector3 Size { get; }
    }
}