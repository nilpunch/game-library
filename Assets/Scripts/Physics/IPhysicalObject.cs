using System;
using UnityEngine;

namespace PhysicsSample
{
    public interface IPhysicalObject : IEquatable<IPhysicalObject>
    {
        Guid Id { get; }
        string Tag { get; }
        
        ICollidingShell Shell { get; }
        
        Vector3 Velocity { get; }
        Vector3 Position { get; }

        void AddVelocity(Vector3 velocity);
    }
}