using UnityEngine;

namespace PhysicsSample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IPhysicWorld _physicWorld;
        private readonly IPhysicWorldLinks<IBullet> _links;

        public BulletFactory(IPhysicWorld physicWorld, IPhysicWorldLinks<IBullet> links)
        {
            _physicWorld = physicWorld;
            _links = links;
        }
        
        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject = new PhysicalObject("Bullet",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 1f), new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject);
            
            _physicWorld.Add(physicalObject);
            _links.Link(physicalObject, bullet);
            
            return bullet;
        }
    }
}