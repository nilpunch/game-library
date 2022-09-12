using UnityEngine;

namespace PhysicsSample
{
    public class Weapon : IWeapon
    {
        private readonly int _bulletsDamage;
        private readonly long _bulletsLiveTime;
        private readonly IBulletFactory _bulletFactory;

        private readonly IGameObjectsLoop _gameObjectsLoop;
        
        public Weapon(int bulletsDamage, long bulletsLiveTime, IBulletFactory bulletFactory)
        {
            _bulletsDamage = bulletsDamage;
            _bulletsLiveTime = bulletsLiveTime;
            _bulletFactory = bulletFactory;

            _gameObjectsLoop = new GameObjectsGroup();
        }

        public void Shoot()
        {
            var bullet = _bulletFactory.Create(_bulletsDamage, _bulletsLiveTime);
            bullet.Throw(Vector3.forward);
            
            _gameObjectsLoop.Add(bullet);
        }

        public void ExecuteFrame(long elapsedTime)
        {
            _gameObjectsLoop.ExecuteFrame(elapsedTime);
        }
    }
}
