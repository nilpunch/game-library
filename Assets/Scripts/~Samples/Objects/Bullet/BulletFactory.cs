using UnityEngine;

namespace PhysicsSample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IGameLoop _gameLoop;
        private readonly IPhysicWorldAssociations<IBullet> _bulletsWorld;

        public BulletFactory(IGameLoop gameLoop, IPhysicWorldAssociations<IBullet> bulletsWorld)
        {
            _gameLoop = gameLoop;
            _bulletsWorld = bulletsWorld;
        }
        
        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject = new PhysicalObject("Bullet",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 1f), new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject);
            
            _gameLoop.Add(bullet);
            _bulletsWorld.Add(physicalObject, bullet);
            
            return bullet;
        }
    }
}