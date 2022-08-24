using UnityEngine;

namespace PhysicsSample
{
    public interface IBullet : IFrameExecution
    {
        bool CanDamage { get; }

        void Damage(ICharacter character);
        void Throw(Vector3 velocity);
    }
}