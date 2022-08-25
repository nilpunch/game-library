using System;

namespace PhysicsSample
{
    public struct Collision
    {
        public Collision(bool occure, IPhysicalObject collidedObject)
        {
            Occure = occure;
            CollidedObject = collidedObject;
        }

        public bool Occure { get; }
        
        public IPhysicalObject CollidedObject { get; }

        public Collision Merge(Collision other)
        {
            throw new NotImplementedException();
        }
    }
}