namespace GameLibrary
{
    public class ConstantExecutionTimeStep : ISimulationObject
    {
        private readonly ISimulationObject _simulationObject;
        private readonly long _timeStep;

        private long _lastExecutionStepTime;

        public ConstantExecutionTimeStep(ISimulationObject simulationObject, long timeStep)
        {
            _simulationObject = simulationObject;
            _timeStep = timeStep;
        }

        public void Step(long elapsedMilliseconds)
        {
            long deltaTime = elapsedMilliseconds - _lastExecutionStepTime;

            long executionsCount = deltaTime % elapsedMilliseconds;

            for (int frame = 0; frame < executionsCount; frame++)
            {
                _simulationObject.Step(_lastExecutionStepTime + _timeStep * (frame + 1));
            }

            _lastExecutionStepTime += _timeStep * executionsCount;
        }
    }
}