using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public struct Box
    {
        Vector3 Center { get; }
        Quaternion Rotation { get; }
        Vector3 Size { get; }
    }
}