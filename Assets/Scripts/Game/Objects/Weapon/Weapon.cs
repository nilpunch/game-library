using UnityEngine;

namespace PhysicsSample
{
    public class Weapon : IWeapon
    {
        private readonly int _bulletsDamage;
        private readonly long _bulletsLiveTime;
        private readonly IBulletFactory _bulletFactory;

        public Weapon(int bulletsDamage, long bulletsLiveTime, IBulletFactory bulletFactory)
        {
            _bulletsDamage = bulletsDamage;
            _bulletsLiveTime = bulletsLiveTime;
            _bulletFactory = bulletFactory;
        }

        public void Shoot()
        {
            _bulletFactory.Create(_bulletsDamage, _bulletsLiveTime).Throw(Vector3.forward);
        }
    }
}
