using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.Raycast;
using SphereCollider = GameLibrary.Physics.Raycast.SphereCollider;

namespace GameLibrary.Sample
{
    public class CharacterFactory : ICharacterFactory
    {
        private readonly int _health;
        private readonly IWeaponFactory _weaponFactory;
        private readonly IConcreteRaycastWorld<ICharacter> _characterRaycasts;
        private readonly ICharacterViewFactory _characterViewFactory;

        public CharacterFactory(int health, IWeaponFactory weaponFactory, IConcreteRaycastWorld<ICharacter> characterRaycasts, ICharacterViewFactory characterViewFactory)
        {
            _health = health;
            _weaponFactory = weaponFactory;
            _characterRaycasts = characterRaycasts;
            _characterViewFactory = characterViewFactory;
        }

        public ICharacter Create()
        {
            var rigidbody = new Rigidbody();
            var collider = new DynamicCollider(rigidbody, new SphereCollider(new Sphere()));

            ICharacter character = new Character(_health, rigidbody, _characterViewFactory.Create(), _weaponFactory.Create());

            _characterRaycasts.Add(collider, character);

            return character;
        }
    }
}
