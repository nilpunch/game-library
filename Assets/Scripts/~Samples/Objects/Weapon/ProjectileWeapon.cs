namespace GameLibrary
{
    public class ProjectileWeapon : IWeapon
    {
        private readonly int _bulletsDamage;
        private readonly IBulletFactory _bulletFactory;

        public ProjectileWeapon(int bulletsDamage, IBulletFactory bulletFactory)
        {
            _bulletsDamage = bulletsDamage;
            _bulletFactory = bulletFactory;
        }

        public void Shoot()
        {
            var bullet = _bulletFactory.Create(_bulletsDamage);
            bullet.Throw(Vector3.Forward);
        }
    }
}