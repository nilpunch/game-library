using System;
using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public struct Collision
    {
        public ContactPoint[] Contacts { get; }

        public Vector3 PenetrationNormal { get; }
        
        public float PenetrationDepth { get; }

        public Collision Merge(Collision other)
        {
            throw new NotImplementedException();
        }
        
        public Collision Merge(ContactPoint contactPoint)
        {
            throw new NotImplementedException();
        }
    }
}