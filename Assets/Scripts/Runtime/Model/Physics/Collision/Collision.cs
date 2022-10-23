using System;

namespace GameLibrary
{
    public struct Collision
    {
        public Contact[] Contacts { get; }

        public Collision Merge(Collision other)
        {
            throw new NotImplementedException();
        }
        
        public Collision Merge(Contact contact)
        {
            throw new NotImplementedException();
        }
    }
}