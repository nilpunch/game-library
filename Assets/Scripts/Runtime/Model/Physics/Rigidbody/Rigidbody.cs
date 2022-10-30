using System;
using GameLibrary.Math;

namespace GameLibrary.Physics
{
    public class Rigidbody : IRigidbody
    {
        public Rigidbody(ICollider shell)
        {
            Collider = shell;
            IsAlive = true;
        }

        public bool IsAlive { get; private set; }

        public Vector3 Velocity { get; set; }
        public Vector3 Position { get; set; }
        
        public ICollider Collider { get; }

        public void Destroy()
        {
            if (IsAlive == false)
                throw new Exception();

            IsAlive = false;
        }
    }
}