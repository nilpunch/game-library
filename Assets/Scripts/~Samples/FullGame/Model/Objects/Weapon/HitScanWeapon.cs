using GameLibrary.Mathematics;
using GameLibrary.Physics;

namespace GameLibrary.Sample
{
    public class HitScanWeapon : IWeapon
    {
        private readonly int _shootDamage;
        private readonly ICollisionsWorld<ICharacter> _collisionsWorld;

        public HitScanWeapon(int shootDamage, ICollisionsWorld<ICharacter> collisionsWorld)
        {
            _shootDamage = shootDamage;
            _collisionsWorld = collisionsWorld;
        }

        public void Shoot()
        {
            var hit = _collisionsWorld.Raycast(Float3.zero, new Float3((SoftFloat)0, (SoftFloat)0, (SoftFloat)1));
            if (!hit.Occure)
                return;

            var character = hit.Object;

            if (character.IsAlive)
                character.TakeDamage(_shootDamage);
        }
    }
}
