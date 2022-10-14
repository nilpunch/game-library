namespace GameLibrary
{
    public class SimulationTickGroup : ISimulationTick
    {
        private readonly ISimulationTick[] _frameExecutions;

        public SimulationTickGroup(ISimulationTick[] frameExecutions)
        {
            _frameExecutions = frameExecutions;
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            foreach (var frameExecution in _frameExecutions)
            {
                frameExecution.ExecuteTick(elapsedMilliseconds);
            }
        }
    }
}