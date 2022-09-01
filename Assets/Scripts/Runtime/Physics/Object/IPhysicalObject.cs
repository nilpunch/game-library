using UnityEngine;

namespace PhysicsSample
{
    public interface IPhysicalObject
    {
        string Tag { get; }
        
        ICollidingShell Shell { get; }

        void AddVelocityChange(Vector3 velocity);

        bool IsExist { get; }
        
        void Destroy();
    }
}