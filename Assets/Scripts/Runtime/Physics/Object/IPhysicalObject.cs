using UnityEngine;

namespace PhysicsSample
{
    public interface IPhysicalObject
    {
        string Tag { get; }
        
        ICollidingShell Shell { get; }
        
        Vector3 Velocity { get; }
        Vector3 Position { get; }

        void ApplyPhysics(Vector3 newVelocity, Vector3 newPosition);
        void AddVelocityChange(Vector3 velocity);
    }
}