namespace GameLibrary
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicSubWorld<IBullet> _bulletsSubWorld;
        private readonly ICollisionsWorld<ICharacter> _charactersCollisions;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicSubWorld<IBullet> bulletsSubWorld, ICollisionsWorld<ICharacter> charactersCollisions)
        {
            _bulletsLoop = bulletsLoop;
            _bulletsSubWorld = bulletsSubWorld;
            _charactersCollisions = charactersCollisions;
        }

        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject, _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _bulletsSubWorld.Add(physicalObject, bullet);

            return bullet;
        }
    }
}