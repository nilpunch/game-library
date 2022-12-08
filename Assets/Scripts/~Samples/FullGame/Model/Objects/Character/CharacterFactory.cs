using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly IPhysicWorld<ConcreteBody<IRigidbody<IMatrixCollider>, ICharacter>> _charactersWorld;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(IPhysicWorld<ConcreteBody<IRigidbody<IMatrixCollider>, ICharacter>> charactersWorld, ICharacterViewFactory characterViewFactory)
        {
            _charactersWorld = charactersWorld;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create(int health, IWeapon weapon)
        {
            var rigidbody = new Rigidbody<IMatrixCollider>(new SphereMatrixCollider(new Sphere(), new MatrixMatrixCollisionsLibrary()));

            ICharacter character = new Character(health, rigidbody, _characterViewFactory.Create(), weapon);

            _charactersWorld.Add(new ConcreteBody<IRigidbody<IMatrixCollider>, ICharacter>(rigidbody, character));

            return character;
        }
    }
}
