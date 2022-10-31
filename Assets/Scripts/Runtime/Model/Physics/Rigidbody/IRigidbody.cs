using GameLibrary.Lifetime;
using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface IRigidbody : IAlive
    {
        Float3 Velocity { get; set; }

        Float3 Position { get; set; }

        ICollider Collider { get; }



        void Destroy();
    }
}
