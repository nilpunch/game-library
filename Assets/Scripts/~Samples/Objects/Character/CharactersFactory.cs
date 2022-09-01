using UnityEngine;

namespace PhysicsSample
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IPhysicWorld _physicsWorld;
        private readonly IPhysicWorldLinks<ICharacter> _links;

        public CharactersFactory(IPhysicWorld physicsWorld, IPhysicWorldLinks<ICharacter> links)
        {
            _physicsWorld = physicsWorld;
            _links = links;
        }
        
        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject = new PhysicalObject("Character",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 10f), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject);
            
            _physicsWorld.Add(physicalObject);
            _links.Link(physicalObject, character);
            
            return character;
        }
    }
}