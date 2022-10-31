using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public struct Box
    {
        Float3 Center { get; }
        Quaternion Rotation { get; }
        Float3 Size { get; }
    }
}
