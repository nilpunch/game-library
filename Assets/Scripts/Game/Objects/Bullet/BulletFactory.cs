using System;
using UnityEngine;

namespace PhysicsSample
{
    public class BulletFactory : IBulletFactory
    {
        private readonly IPhysicWorld _physicWorld;
        private readonly IGameLoop _gameLoop;
        private readonly IPhysicWorldAssociations<IBullet> _bulletsWorld;
        private readonly IReadOnlyPhysicWorldAssociations<ICharacter> _charactersWorld;

        public BulletFactory(IGameLoop gameLoop, IPhysicWorld physicWorld, IPhysicWorldAssociations<IBullet> bulletsWorld, IReadOnlyPhysicWorldAssociations<ICharacter> charactersWorld)
        {
            _physicWorld = physicWorld;
            _gameLoop = gameLoop;
            _bulletsWorld = bulletsWorld;
            _charactersWorld = charactersWorld;
        }
        
        public IBullet Create(int damage, long liveTime)
        {
            IPhysicalObject physicalObject = new PhysicalObject(Guid.NewGuid(), "Bullet",
                new SphereCollidingShell(new SphereShell(Vector3.zero, 1f), new CollisionsLibrary()));

            IBullet bullet = new Bullet(damage, liveTime, physicalObject, _physicWorld, _bulletsWorld, _charactersWorld);
            
            _gameLoop.Add(bullet);
            _physicWorld.Add(physicalObject);
            _bulletsWorld.Add(physicalObject, bullet);
            
            return bullet;
        }
    }
}