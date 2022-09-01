namespace PhysicsSample
{
    public class Player : IGameObject
    {
        private readonly IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public bool IsActual => true;

        public void ExecuteFrame(long elapsedTime)
        {
            _weapon.ExecuteFrame(elapsedTime);

            _weapon.Shoot();
        }
    }
}