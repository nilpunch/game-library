using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld
    {
        CollisionManifold[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit Raycast(float3 from, float3 direction);
    }
}