using GameLibrary.Math;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IPhysicWorld<ICharacter> _charactersWorld;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(IPhysicWorld<ICharacter> charactersWorld, ICharacterViewFactory characterViewFactory)
        {
            _charactersWorld = charactersWorld;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            IRigidbody rigidbody =  new Rigidbody(new SphereCollider(
                new SphereShell(Vector3.Zero, new FloatingPoint()),
                new CollisionsLibrary()));

            ICharacter character = new Character(health, rigidbody, _characterViewFactory.Create(), weapon);

            _charactersWorld.Add(rigidbody, character);

            return character;
        }
    }
}