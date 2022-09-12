namespace PhysicsSample
{
    public class BulletCharacterInteraction : IObjectsInteraction<IBullet, ICharacter>
    {
        public void Interact(IBullet bullet, ICharacter character, Collision collision)
        {
            if (character.IsAlive && bullet.CanDamage)
                bullet.Damage(character);
        }
    }
}