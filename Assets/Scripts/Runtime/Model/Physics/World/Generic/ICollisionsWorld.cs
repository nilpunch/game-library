using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld<TConcrete>
    {
        CollisionManifold<TConcrete>[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit<TConcrete> Raycast(Float3 from, Float3 direction);
    }
}
