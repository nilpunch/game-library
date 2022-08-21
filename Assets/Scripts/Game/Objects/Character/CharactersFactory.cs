using System;
using UnityEngine;

namespace PhysicsSample
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IGameLoop _gameLoop;
        private readonly IPhysicWorld _physicWorld;
        private readonly IPhysicWorldAssociations<ICharacter> _charactersWorld;

        public CharactersFactory(IGameLoop gameLoop, IPhysicWorld physicWorld, IPhysicWorldAssociations<ICharacter> charactersWorld)
        {
            _gameLoop = gameLoop;
            _physicWorld = physicWorld;
            _charactersWorld = charactersWorld;
        }
        
        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject = new PhysicalObject(Guid.NewGuid(), "Character",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 10f), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject, _charactersWorld);
            
            _gameLoop.Add(character);
            _physicWorld.Add(physicalObject);
            _charactersWorld.Add(physicalObject, character);
            
            return character;
        }
    }
}