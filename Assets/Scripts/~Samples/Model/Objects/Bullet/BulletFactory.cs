namespace GameLibrary.Sample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _bulletsLoop;
        private readonly IPhysicWorld _physicWorld;
        private readonly ICollisionsWorld<ICharacter> _charactersCollisions;

        public BulletFactory(IGameObjectsGroup bulletsLoop, IPhysicWorld physicWorld, ICollisionsWorld<ICharacter> charactersCollisions)
        {
            _bulletsLoop = bulletsLoop;
            _physicWorld = physicWorld;
            _charactersCollisions = charactersCollisions;
        }

        public IBullet Create(int damage)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, physicalObject, _charactersCollisions);

            _bulletsLoop.Add(bullet);
            _physicWorld.Add(physicalObject);

            return bullet;
        }
    }
}