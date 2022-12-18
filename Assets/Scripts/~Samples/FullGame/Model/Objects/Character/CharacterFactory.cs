using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IConcreteCollidersWorld<ISMCollider, IRigidbody> _characterCollision;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(IConcreteCollidersWorld<ISMCollider, IRigidbody> characterCollision, ICharacterViewFactory characterViewFactory)
        {
            _characterCollision = characterCollision;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            var rigidbody = new Rigidbody();
            var collider = new DynamicCollider(rigidbody, new SphereCollider(SoftVector3.Zero, SoftFloat.One));

            ICharacter character = new Character(health, rigidbody, _characterViewFactory.Create(), weapon);

            _characterCollision.Add(new ConcreteCollider<ISMCollider, IRigidbody>(collider, rigidbody));

            return character;
        }
    }
}
