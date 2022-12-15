using GameLibrary.Mathematics;
using GameLibrary.Physics;
using GameLibrary.Physics.SupportMapping;

namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicWorld<IRigidbody> _bulletPhysicWorld;
        private readonly ICollidersWorld<ISMCollider> _bulletCollidersWorld;
        private readonly IRaycastWorld<ICharacter> _charactersRaycast;
        private readonly IBulletViewFactory _bulletViewFactory;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicWorld<IRigidbody> bulletPhysicWorld, ICollidersWorld<ISMCollider> bulletCollidersWorld,
            IRaycastWorld<ICharacter> charactersRaycast, IBulletViewFactory bulletViewFactory)
        {
            _bulletsLoop = bulletsLoop;
            _bulletPhysicWorld = bulletPhysicWorld;
            _bulletCollidersWorld = bulletCollidersWorld;
            _charactersRaycast = charactersRaycast;
            _bulletViewFactory = bulletViewFactory;
        }

        public IBullet Create(int damage)
        {
            var rigidbody =
                new Rigidbody();

            var bullet = new Bullet(damage, rigidbody, _bulletViewFactory.Create(), _charactersRaycast);

            _bulletsLoop.Add(bullet);
            _bulletPhysicWorld.Add(rigidbody);
            _bulletCollidersWorld.Add(new DynamicCollider(rigidbody, new SphereCollider(SoftVector3.Zero, SoftFloat.One)));

            return bullet;
        }
    }
}
