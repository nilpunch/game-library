using GameLibrary.Lifetime;
using GameLibrary.Math;

namespace GameLibrary
{
    public interface IPhysicalObject : IAlive
    {
        ICollidingShell Shell { get; }

        void AddVelocityChange(Vector3 velocity);

        void Destroy();
    }
}