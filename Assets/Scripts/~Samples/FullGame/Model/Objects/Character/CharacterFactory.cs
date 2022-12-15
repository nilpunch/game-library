using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IPhysicWorld<ConcreteBody<IRigidbody, ICharacter>, ISupportMappingCollider> _charactersWorld;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(IPhysicWorld<ConcreteBody<IRigidbody, ICharacter>, ISupportMappingCollider> charactersWorld, ICharacterViewFactory characterViewFactory)
        {
            _charactersWorld = charactersWorld;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            var rigidbody = new Rigidbody();

            ICharacter character = new Character(health, rigidbody, _characterViewFactory.Create(), weapon);

            _charactersWorld.Add(new ConcreteBody<IRigidbody, ICharacter>(rigidbody, character), new SphereCollider(SoftVector3.Zero, SoftFloat.One));

            return character;
        }
    }
}
