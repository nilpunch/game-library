using System;

namespace PhysicsSample
{
    public class Character : ICharacter
    {
        private readonly IPhysicWorldAssociations<ICharacter> _charactersPhysicWorldAssociations;
        
        private int _health;

        public Character(int health, IPhysicalObject physicalObject)
        {
            _health = health;
        }

        public bool CanExecuteFrame { get; private set; }
        
        public bool IsAlive => _health > 0;

        public void ExecuteFrame(long elapsedTime)
        {
            if (!CanExecuteFrame)
                throw new Exception();
        }

        public void TakeDamage(int damage)
        {
            if (!IsAlive)
                throw new Exception();

            _health -= damage;
            CanExecuteFrame = false;
        }
    }
}