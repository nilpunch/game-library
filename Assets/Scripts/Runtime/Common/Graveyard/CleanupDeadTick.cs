namespace GameLibrary
{
    public class CleanupDeadTick : ISimulationTick
    {
        private readonly IDeadStorage _deadStorage;

        public CleanupDeadTick(IDeadStorage deadStorage)
        {
            _deadStorage = deadStorage;
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _deadStorage.CleanupDeadObjects();
        }
    }
}