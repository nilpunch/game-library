using UnityEngine;

namespace PhysicsSample
{
    public interface IBullet : IGameObject
    {
        bool CanDamage { get; }

        void Damage(ICharacter character);
        void Throw(Vector3 velocity);
    }
}