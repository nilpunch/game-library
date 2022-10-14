namespace GameLibrary
{
    public class HitScanWeapon : IWeapon
    {
        private readonly int _shootDamage;
        private readonly ICollisionsWorld _collisionsWorld;
        private readonly IReadOnlyPhysicWorldObjects<ICharacter> _charactersToHit;

        public HitScanWeapon(int shootDamage, ICollisionsWorld collisionsWorld,
            IReadOnlyPhysicWorldObjects<ICharacter> charactersToHit)
        {
            _shootDamage = shootDamage;
            _collisionsWorld = collisionsWorld;
            _charactersToHit = charactersToHit;
        }

        public void Shoot()
        {
            var hit = _collisionsWorld.Raycast(Vector3.Zero, Vector3.Forward);

            if (!hit.Occure || !_charactersToHit.HasLink(hit.PhysicalObject))
                return;

            var character = _charactersToHit.Get(hit.PhysicalObject);
            
            if (character.IsAlive)
                character.TakeDamage(_shootDamage);
        }
    }
}