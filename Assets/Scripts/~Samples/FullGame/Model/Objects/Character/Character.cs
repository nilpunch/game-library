using System;
using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class Character : ICharacter
    {
        private readonly IRigidbody _rigidbody;
        private readonly ICharacterView _characterView;
        private readonly IWeapon _weapon;

        private int _health;

        public Character(int health, IRigidbody rigidbody, ICharacterView characterView, IWeapon weapon)
        {
            _health = health;
            _rigidbody = rigidbody;
            _characterView = characterView;
            _weapon = weapon;
        }

        public bool IsAlive => _health > 0;

        public void Step(long elapsedMilliseconds)
        {
            if (!IsAlive)
                throw new Exception();
            
            _weapon.Shoot();
        }

        public void TakeDamage(int damage)
        {
            if (!IsAlive)
                throw new Exception();

            _health -= damage;
            
            _characterView.ShowHealth(_health);

            if (!IsAlive)
            {
                _rigidbody.Destroy();
                _characterView.Destroy();
            }
        }
    }
}