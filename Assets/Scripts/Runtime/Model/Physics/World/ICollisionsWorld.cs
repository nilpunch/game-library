using GameLibrary.Math;

namespace GameLibrary
{
    public interface ICollisionsWorld
    {
        CollisionManifold[] CollisionsWith(IRigidbody rigidbody);

        RaycastHit Raycast(Vector3 from, Vector3 direction);
    }
}