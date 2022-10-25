namespace GameLibrary.Lifetime
{
    public class CleanupDeadObjects : ISimulationObject
    {
        private readonly IDeadObjectsStorage _deadObjectsStorage;

        public CleanupDeadObjects(IDeadObjectsStorage deadObjectsStorage)
        {
            _deadObjectsStorage = deadObjectsStorage;
        }

        public void Step(long elapsedMilliseconds)
        {
            _deadObjectsStorage.CleanupDeadObjects();
        }
    }
}