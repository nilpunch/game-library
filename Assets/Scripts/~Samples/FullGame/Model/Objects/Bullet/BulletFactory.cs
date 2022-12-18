using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly ICollidersWorld<ISMCollider> _bulletCollidersWorld;
        private readonly IRaycastShooter<ICharacter> _charactersRaycast;
        private readonly IBulletViewFactory _bulletViewFactory;

        public BulletFactory(IGameObjectsGroup bulletsLoop, ICollidersWorld<ISMCollider> bulletCollidersWorld,
            IRaycastShooter<ICharacter> charactersRaycast, IBulletViewFactory bulletViewFactory)
        {
            _bulletsLoop = bulletsLoop;
            _bulletCollidersWorld = bulletCollidersWorld;
            _charactersRaycast = charactersRaycast;
            _bulletViewFactory = bulletViewFactory;
        }

        public IBullet Create(int damage)
        {
            var rigidbody = new Rigidbody();
            var collider = new DynamicCollider(rigidbody, new SphereCollider(SoftVector3.Zero, SoftFloat.One));

            var bullet = new Bullet(damage, rigidbody, _bulletViewFactory.Create(), _charactersRaycast);

            _bulletsLoop.Add(bullet);
            _bulletCollidersWorld.Add(collider);

            return bullet;
        }
    }
}
