using GameLibrary.Lifetime;
using GameLibrary.Mathematics;

namespace GameLibrary.Physics
{
    public interface IRigidbody : IAlive
    {
        SoftVector3 Velocity { get; set; }

        SoftVector3 Position { get; set; }

        ICollider Collider { get; }



        void Destroy();
    }
}
