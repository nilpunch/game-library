using GameLibrary.Mathematics;
using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class HitScanWeapon : IWeapon
    {
        private readonly int _shootDamage;
        private readonly IRaycastShooter<ICharacter> _raycastWorld;

        public HitScanWeapon(int shootDamage, IRaycastShooter<ICharacter> raycastWorld)
        {
            _shootDamage = shootDamage;
            _raycastWorld = raycastWorld;
        }

        public void Shoot()
        {
            var hit = _raycastWorld.Raycast(SoftVector3.Zero, SoftVector3.Forward);

            if (!hit.Occure)
                return;

            ICharacter character = hit.HitResult;

            if (character.IsAlive)
                character.TakeDamage(_shootDamage);
        }
    }
}
