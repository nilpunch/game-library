using System;
using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public readonly struct Collision
    {
        public bool Occure { get; }

        public ContactPoint[] Contacts { get; }

        public SoftVector3 PenetrationNormal { get; }

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
