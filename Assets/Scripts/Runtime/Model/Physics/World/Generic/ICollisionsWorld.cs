using GameLibrary.Math;

namespace GameLibrary
{
    public interface ICollisionsWorld<TConcrete>
    {
        CollisionManifold<TConcrete>[] CollisionsWith(IRigidbody rigidbody);
        
        RaycastHit<TConcrete> Raycast(Vector3 from, Vector3 direction);
    }
}