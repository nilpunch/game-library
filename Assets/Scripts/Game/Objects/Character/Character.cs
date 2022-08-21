using System;

namespace PhysicsSample
{
    public class Character : ICharacter
    {
        private readonly IPhysicalObject _physicalObject;
        private readonly IPhysicWorldAssociations<ICharacter> _charactersAssociations;
        
        private int _health;

        public Character(int health, IPhysicalObject physicalObject, IPhysicWorldAssociations<ICharacter> charactersAssociations)
        {
            _health = health;
            _physicalObject = physicalObject;
            _charactersAssociations = charactersAssociations;
        }

        public bool CanExecuteFrame { get; private set; }
        
        public bool IsAlive => _health > 0;

        public void ExecuteFrame(long time)
        {
            if (!CanExecuteFrame)
                throw new Exception();
            
            if (!IsAlive)
            {
                CanExecuteFrame = false;
                _charactersAssociations.Remove(_physicalObject);
            }
        }

        public void Damage(int damage)
        {
            if (!IsAlive)
                throw new Exception();

            _health -= damage;
        }
    }
}