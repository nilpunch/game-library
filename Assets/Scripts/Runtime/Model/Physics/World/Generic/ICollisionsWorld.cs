using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld<TConcrete>
    {
        CollisionManifold<TConcrete>[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit<TConcrete> Raycast(SoftVector3 from, SoftVector3 direction);
    }
}
