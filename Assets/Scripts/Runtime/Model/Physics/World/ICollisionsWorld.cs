using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface ICollisionsWorld
    {
        CollisionManifold[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit Raycast(Float3 from, Float3 direction);
    }
}
