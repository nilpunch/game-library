using GameLibrary.Math;

namespace GameLibrary
{
    public interface IConvexShell
    {
        Vector3 Center { get; }
        Mesh Mesh { get; }
    }
}