using GameLibrary.Lifetime;
using GameLibrary.Math;

namespace GameLibrary
{
    public interface IRigidbody : IAlive
    {
        ICollider Collider { get; }

        void AddVelocityChange(Vector3 velocity);

        void Destroy();
    }
}