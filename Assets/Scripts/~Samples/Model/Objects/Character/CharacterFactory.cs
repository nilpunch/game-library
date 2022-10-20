namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IPhysicWorld<ICharacter> _charactersWorld;

        public CharacterFactory(IPhysicWorld<ICharacter> charactersWorld)
        {
            _charactersWorld = charactersWorld;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            IPhysicalObject physicalObject =  new PhysicalObject(new SphereCollidingShell(
                new SphereShell(Vector3.Zero, new FloatingPoint()),
                new CollisionsLibrary()));

            ICharacter character = new Character(health, physicalObject, weapon);

            _charactersWorld.Add(physicalObject, character);

            return character;
        }
    }
}