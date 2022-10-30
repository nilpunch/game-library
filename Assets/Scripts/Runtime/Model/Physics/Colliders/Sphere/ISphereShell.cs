using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface ISphereShell
    {
        Vector3 Center { get; }
        Scalar Radius { get; }
    }
}