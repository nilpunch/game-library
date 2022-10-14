namespace GameLibrary
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IConcretePhysicWorld<ICharacter> _charactersWorld;

        public CharactersFactory(IConcretePhysicWorld<ICharacter> charactersWorld)
        {
            _charactersWorld = charactersWorld;
        }

        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(
                    new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject);

            _charactersWorld.Add(physicalObject, character);

            return character;
        }
    }
}