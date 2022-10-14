namespace GameLibrary
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IConcretePhysicWorld<IBullet> _bulletsWorld;
        private readonly IConcreteCollisionWorld<ICharacter> _charactersCollisions;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IConcretePhysicWorld<IBullet> bulletsWorld, IConcreteCollisionWorld<ICharacter> charactersCollisions)
        {
            _bulletsLoop = bulletsLoop;
            _bulletsWorld = bulletsWorld;
            _charactersCollisions = charactersCollisions;
        }

        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject, _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _bulletsWorld.Add(physicalObject, bullet);

            return bullet;
        }
    }
}