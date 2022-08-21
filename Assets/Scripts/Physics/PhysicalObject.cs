using System;
using UnityEngine;

namespace PhysicsSample
{
    public class PhysicalObject : IPhysicalObject
    {
        public PhysicalObject(Guid id, string tag, ICollidingShell shell)
        {
            Id = id;
            Tag = tag;
            Shell = shell;
        }
        
        public Guid Id { get; }
        
        public string Tag { get; }
        
        public ICollidingShell Shell { get; }
        
        public Vector3 Velocity { get; private set; }
        
        public Vector3 Position { get; }
        
        public void AddVelocity(Vector3 velocity)
        {
            Velocity += velocity;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IPhysicalObject);
        }

        public bool Equals(IPhysicalObject other)
        {
            return Id.Equals(other.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}