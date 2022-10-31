using System;
using GameLibrary.Mathematics;

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

        public Float3 Velocity { get; set; }
        public Float3 Position { get; set; }

        public ICollider Collider { get; }

        public void Destroy()
        {
            if (IsAlive == false)
                throw new Exception();

            IsAlive = false;
        }
    }
}
