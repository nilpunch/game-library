using UnityEngine;

namespace PhysicsSample
{
    public interface IBullet : IFrameExecution
    {
        void Throw(Vector3 velocity);
    }
}