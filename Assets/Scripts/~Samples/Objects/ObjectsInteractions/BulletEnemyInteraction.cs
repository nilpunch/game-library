namespace PhysicsSample
{
    public class BulletEnemyInteraction : IObjectsInteraction<IBullet, ICharacter>
    {
        public void Interact(IBullet bullet, ICharacter character, Collision collision)
        {
            if (character.IsAlive && bullet.CanDamage)
                bullet.Damage(character);
        }
    }
}