namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicWorld<IBullet> _bulletsWorld;
        private readonly ICollisionsWorld<ICharacter> _charactersCollisions;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicWorld<IBullet> bulletsWorld, ICollisionsWorld<ICharacter> charactersCollisions)
        {
            _bulletsLoop = bulletsLoop;
            _bulletsWorld = bulletsWorld;
            _charactersCollisions = charactersCollisions;
        }

        public IBullet Create(int damage)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, physicalObject, _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _bulletsWorld.Add(physicalObject, bullet);

            return bullet;
        }
    }
}