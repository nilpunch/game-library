using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IPhysicWorld<ConcreteBody<IRigidbody, ICharacter>> _charactersWorld;
        private readonly ICollidersWorld<ISMCollider> _characterColliders;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(IPhysicWorld<ConcreteBody<IRigidbody, ICharacter>> charactersWorld, ICollidersWorld<ISMCollider> characterColliders, ICharacterViewFactory characterViewFactory)
        {
            _charactersWorld = charactersWorld;
            _characterColliders = characterColliders;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            var rigidbody = new Rigidbody();

            ICharacter character = new Character(health, rigidbody, _characterViewFactory.Create(), weapon);

            _charactersWorld.Add(new ConcreteBody<IRigidbody, ICharacter>(rigidbody, character));
            _characterColliders.Add(new DynamicCollider(rigidbody, new SphereCollider(SoftVector3.Zero, SoftFloat.One)));

            return character;
        }
    }
}
