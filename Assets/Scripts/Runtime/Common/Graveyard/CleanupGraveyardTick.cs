namespace GameLibrary
{
    public class CleanupGraveyardTick : ISimulationTick
    {
        private readonly IDeadStorage _deadStorage;

        public CleanupGraveyardTick(IDeadStorage deadStorage)
        {
            _deadStorage = deadStorage;
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _deadStorage.CleanupDeadObjects();
        }
    }
}