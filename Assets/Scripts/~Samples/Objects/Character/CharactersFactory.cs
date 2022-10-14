namespace GameLibrary
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IPhysicSubWorld<ICharacter> _charactersSubWorld;

        public CharactersFactory(IPhysicSubWorld<ICharacter> charactersSubWorld)
        {
            _charactersSubWorld = charactersSubWorld;
        }

        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(
                    new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject);

            _charactersSubWorld.Add(physicalObject, character);

            return character;
        }
    }
}