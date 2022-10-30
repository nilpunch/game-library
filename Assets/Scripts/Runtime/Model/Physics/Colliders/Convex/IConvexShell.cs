using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface IConvexShell
    {
        Vector3 Center { get; }
        Mesh Mesh { get; }
    }
}