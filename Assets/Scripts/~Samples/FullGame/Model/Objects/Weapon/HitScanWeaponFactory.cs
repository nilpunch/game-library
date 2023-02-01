using GameLibrary.Physics.Raycast;

namespace GameLibrary.Sample
{
    public class HitScanWeaponFactory : IWeaponFactory
    {
        private readonly int _damage;
        private readonly IRaycastShooter<ICharacter> _characterRaycasts;

        public HitScanWeaponFactory(int damage, IRaycastShooter<ICharacter> characterRaycasts)
        {
            _damage = damage;
            _characterRaycasts = characterRaycasts;
        }
        
        public IWeapon Create()
        {
            return new HitScanWeapon(_damage, _characterRaycasts);
        }
    }
}