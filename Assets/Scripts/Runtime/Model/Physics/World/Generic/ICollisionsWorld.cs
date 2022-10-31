using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld<TConcrete>
    {
        CollisionManifold<TConcrete>[] CollisionsWith(IRigidbody rigidbody);
        
        RaycastHit<TConcrete> Raycast(float3 from, float3 direction);
    }
}