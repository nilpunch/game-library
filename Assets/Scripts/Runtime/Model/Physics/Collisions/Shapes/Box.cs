using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public struct Box
    {
        float3 Center { get; }
        quaternion Rotation { get; }
        float3 Size { get; }
    }
}