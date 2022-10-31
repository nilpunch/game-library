using GameLibrary.Lifetime;
using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface IRigidbody : IAlive
    {
        float3 Velocity { get; set; }
        
        float3 Position { get; set; }

        ICollider Collider { get; }

        
        
        void Destroy();
    }
}