namespace GameLibrary.Sample
{
    public class Player : IGameObject
    {
        private readonly IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public bool IsAlive => true;

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _weapon.Shoot();
        }
    }
}