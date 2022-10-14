namespace GameLibrary
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameObjectsGroup _gameObjectsGroup;
        private readonly IPhysicWorld _physicWorld;
        private readonly IPhysicWorldObjects<IBullet> _worldObjects;

        public BulletFactory(IGameObjectsGroup gameObjectsGroup, IPhysicWorld physicWorld, IPhysicWorldObjects<IBullet> worldObjects)
        {
            _gameObjectsGroup = gameObjectsGroup;
            _physicWorld = physicWorld;
            _worldObjects = worldObjects;
        }

        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject =
                new PhysicalObject(new SphereCollidingShell(new SphereShell(Vector3.Zero, new FloatingPoint()),
                    new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject);

            _gameObjectsGroup.Add(bullet);
            _physicWorld.Add(physicalObject);
            _worldObjects.Link(physicalObject, bullet);

            return bullet;
        }
    }
}