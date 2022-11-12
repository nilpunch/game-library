using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicWorld _physicWorld;
        private readonly ICollisionsWorld<ICharacter> _charactersCollisions;
        private readonly IBulletViewFactory _bulletViewFactory;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicWorld physicWorld,
            ICollisionsWorld<ICharacter> charactersCollisions, IBulletViewFactory bulletViewFactory)
        {
            _bulletsLoop = bulletsLoop;
            _physicWorld = physicWorld;
            _charactersCollisions = charactersCollisions;
            _bulletViewFactory = bulletViewFactory;
        }

        public IBullet Create(int damage)
        {
            IRigidbody rigidbody =
                new Rigidbody(new SphereCollider(new Sphere(), new CollisionsLibrary()));

            var bullet = new Bullet(damage, rigidbody, _bulletViewFactory.Create(), _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _physicWorld.Add(rigidbody);

            return bullet;
        }
    }
}