using UnityEngine;

namespace PhysicsSample
{
    public class PhysicalObject : IPhysicalObject
    {
        public PhysicalObject(string tag, ICollidingShell shell)
        {
            Tag = tag;
            Shell = shell;
        }
        
        public string Tag { get; }
        
        public ICollidingShell Shell { get; }
        
        public Vector3 Velocity { get; private set; }
        
        public Vector3 Position { get; private set; }
        
        public void ApplyPhysics(Vector3 newVelocity, Vector3 newPosition)
        {
            Velocity = newVelocity;
            Position = newPosition;
        }

        public void AddVelocityChange(Vector3 velocity)
        {
            throw new System.NotImplementedException();
        }
    }
}