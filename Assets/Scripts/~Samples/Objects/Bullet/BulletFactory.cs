namespace GameLibrary
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IPhysicWorld _physicWorld;
        private readonly IPhysicWorldObjects<IBullet> _worldObjects;

        public BulletFactory(IPhysicWorld physicWorld, IPhysicWorldObjects<IBullet> worldObjects)
        {
            _physicWorld = physicWorld;
            _worldObjects = worldObjects;
        }

        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject);

            _physicWorld.Add(physicalObject);
            _worldObjects.Link(physicalObject, bullet);

            return bullet;
        }
    }
}