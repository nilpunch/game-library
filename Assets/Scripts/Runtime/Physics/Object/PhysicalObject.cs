using System;

namespace GameLibrary
{
    public class PhysicalObject : IPhysicalObject
    {
        public PhysicalObject(ICollidingShell shell)
        {
            Shell = shell;
            IsExist = true;
        }

        public bool IsExist { get; private set; }

        public ICollidingShell Shell { get; }

        public void AddVelocityChange(Vector3 velocity)
        {
            throw new NotImplementedException();
        }

        public void Destroy()
        {
            if (IsExist == false)
                throw new Exception();

            IsExist = false;
        }
    }
}