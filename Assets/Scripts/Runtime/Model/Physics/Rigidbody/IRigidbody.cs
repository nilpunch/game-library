using GameLibrary.Lifetime;
using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public interface IRigidbody : IAlive
    {
        Vector3 Velocity { get; set; }
        
        Vector3 Position { get; set; }

        ICollider Collider { get; }

        
        
        void Destroy();
    }
}