namespace GameLibrary
{
    public class ProjectileWeapon : IWeapon
    {
        private readonly int _bulletsDamage;
        private readonly long _bulletsLiveTime;
        private readonly IBulletFactory _bulletFactory;

        public ProjectileWeapon(int bulletsDamage, long bulletsLiveTime, IBulletFactory bulletFactory)
        {
            _bulletsDamage = bulletsDamage;
            _bulletsLiveTime = bulletsLiveTime;
            _bulletFactory = bulletFactory;
        }

        public void Shoot()
        {
            var bullet = _bulletFactory.Create(_bulletsDamage, _bulletsLiveTime);
            bullet.Throw(Vector3.Forward);
        }
    }
}