using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicWorld<IRigidbody, ISupportMappingCollider> _physicWorld;
        private readonly ICollisionsWorld<ICharacter> _charactersCollisions;
        private readonly IBulletViewFactory _bulletViewFactory;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicWorld<IRigidbody, ISupportMappingCollider> physicWorld,
            ICollisionsWorld<ICharacter> charactersCollisions, IBulletViewFactory bulletViewFactory)
        {
            _bulletsLoop = bulletsLoop;
            _physicWorld = physicWorld;
            _charactersCollisions = charactersCollisions;
            _bulletViewFactory = bulletViewFactory;
        }

        public IBullet Create(int damage)
        {
            var rigidbody =
                new Rigidbody();

            var bullet = new Bullet(damage, rigidbody, _bulletViewFactory.Create(), _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _physicWorld.Add(rigidbody, new SphereCollider(SoftVector3.Zero, SoftFloat.One));

            return bullet;
        }
    }
}
