namespace GameLibrary.Sample
{
    public class ProjectileWeaponFactory : IWeaponFactory
    {
        private readonly int _damage;
        private readonly IBulletFactory _bulletFactory;

        public ProjectileWeaponFactory(int damage, IBulletFactory bulletFactory)
        {
            _damage = damage;
            _bulletFactory = bulletFactory;
        }
        
        public IWeapon Create()
        {
            return new ProjectileWeapon(_damage, _bulletFactory);
        }
    }
}
