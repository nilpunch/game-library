namespace GameLibrary
{
    public class CleanupGraveyardTick : ISimulationTick
    {
        private readonly IGraveyard _graveyard;

        public CleanupGraveyardTick(IGraveyard graveyard)
        {
            _graveyard = graveyard;
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _graveyard.ForgetDeadObjects();
        }
    }
}