namespace GameLibrary
{
    public class SimulationObjectGroup : ISimulationObject
    {
        private readonly ISimulationObject[] _simulationObjects;

        public SimulationObjectGroup(ISimulationObject[] simulationObjects)
        {
            _simulationObjects = simulationObjects;
        }

        public void Step(long elapsedMilliseconds)
        {
            foreach (var simulationObject in _simulationObjects)
            {
                simulationObject.Step(elapsedMilliseconds);
            }
        }
    }
}