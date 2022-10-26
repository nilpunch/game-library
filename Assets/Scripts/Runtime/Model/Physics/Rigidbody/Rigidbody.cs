using System;
using GameLibrary.Math;

namespace GameLibrary
{
    public class Rigidbody : IRigidbody
    {
        public Rigidbody(ICollider shell)
        {
            Collider = shell;
            IsAlive = true;
        }

        public bool IsAlive { get; private set; }

        public ICollider Collider { get; }

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