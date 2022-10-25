using System;
using GameLibrary.Math;

namespace GameLibrary
{
    public class PhysicalObject : IPhysicalObject
    {
        public PhysicalObject(ICollidingShell shell)
        {
            Shell = shell;
            IsAlive = true;
        }

        public bool IsAlive { get; private set; }

        public ICollidingShell Shell { get; }

        public void AddVelocityChange(Vector3 velocity)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            if (IsAlive == false)
                throw new Exception();

            IsAlive = false;
        }
    }
}