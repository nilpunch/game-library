using System;
using UnityEngine;

namespace PhysicsSample
{
    public class PhysicalObject : IPhysicalObject
    {
        public PhysicalObject(string tag, ICollidingShell shell)
        {
            Tag = tag;
            Shell = shell;
            IsExist = true;
        }

        public bool IsExist { get; private set; }
        
        public string Tag { get; }

        public ICollidingShell Shell { get; }
        
        public void AddVelocityChange(Vector3 velocity)
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            if (IsExist == false)
                throw new Exception();
            
            IsExist = false;
        }
    }
}