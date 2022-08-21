namespace PhysicsSample
{
    public class Player : IFrameExecution
    {
        private readonly IWeapon _weapon;

        public Player(IWeapon weapon)
        {
            _weapon = weapon;
        }
        
        public bool CanExecuteFrame => true;
        
        public void ExecuteFrame(long time)
        {
            _weapon.Shoot();
        }
    }
}