using UnityEngine;

namespace PhysicsSample
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IGameLoop _gameLoop;
        private readonly ICollideObjects<ICharacter> _charactersWorld;

        public CharactersFactory(IGameLoop gameLoop, ICollideObjects<ICharacter> charactersWorld)
        {
            _gameLoop = gameLoop;
            _charactersWorld = charactersWorld;
        }
        
        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject = new PhysicalObject("Character",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 10f), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject);
            
            _gameLoop.Add(character);
            _charactersWorld.Add(character, physicalObject);
            
            return character;
        }
    }
}