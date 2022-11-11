using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld
    {
        CollisionManifold[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit Raycast(SoftVector3 from, SoftVector3 direction);
    }
}
