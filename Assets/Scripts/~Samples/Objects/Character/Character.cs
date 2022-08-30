using System;

namespace PhysicsSample
{
    public class Character : ICharacter
    {
        private int _health;

        public Character(int health)
        {
            _health = health;
        }

        public bool IsActual => IsAlive;
        
        public bool IsAlive => _health > 0;

        public void ExecuteFrame(long elapsedTime)
        {
            if (!IsActual)
                throw new Exception();
        }

        public void TakeDamage(int damage)
        {
            if (!IsAlive)
                throw new Exception();

            _health -= damage;
        }
    }
}