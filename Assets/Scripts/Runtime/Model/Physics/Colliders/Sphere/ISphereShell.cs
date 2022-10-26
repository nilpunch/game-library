using GameLibrary.Math;

namespace GameLibrary
{
    public interface ISphereShell
    {
        Vector3 Center { get; }
        FloatingPoint Radius { get; }
    }
}