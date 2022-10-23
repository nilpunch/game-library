using System;

namespace GameLibrary.Sample
{
    public class Character : ICharacter
    {
        private readonly IPhysicalObject _physicalObject;
        private readonly ICharacterView _characterView;
        private readonly IWeapon _weapon;

        private int _health;

        public Character(int health, IPhysicalObject physicalObject, ICharacterView characterView, IWeapon weapon)
        {
            _health = health;
            _physicalObject = physicalObject;
            _characterView = characterView;
            _weapon = weapon;
        }

        public bool IsAlive => _health > 0;

        public void ExecuteTick(long elapsedMilliseconds)
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
                _physicalObject.Destroy();
                _characterView.Destroy();
            }
        }
    }
}