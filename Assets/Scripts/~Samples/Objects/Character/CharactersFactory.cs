namespace GameLibrary
{
    public class CharactersFactory : ICharactersFactory
    {
        private readonly IPhysicWorld _physicsWorld;
        private readonly IPhysicWorldObjects<ICharacter> _worldObjects;

        public CharactersFactory(IPhysicWorld physicsWorld, IPhysicWorldObjects<ICharacter> worldObjects)
        {
            _physicsWorld = physicsWorld;
            _worldObjects = worldObjects;
        }

        public ICharacter Create(int health)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(
                    new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()), new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject);

            _physicsWorld.Add(physicalObject);
            _worldObjects.Link(physicalObject, character);

            return character;
        }
    }
}