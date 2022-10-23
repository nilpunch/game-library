using System;

namespace GameLibrary.Sample.FullGame
{
    public class Character : ICharacter
    {
        private readonly IPhysicalObject _physicalObject;
        private readonly ICharacterView _view;
        private readonly IWeapon _weapon;

        private int _health;

        public Character(int health, IPhysicalObject physicalObject, ICharacterView view, IWeapon weapon)
        {
            _health = health;
            _physicalObject = physicalObject;
            _view = view;
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
            
            _view.ShowHealth(_health);

            if (!IsAlive)
            {
                _physicalObject.Destroy();
                _view.Destroy();
            }
        }
    }
}