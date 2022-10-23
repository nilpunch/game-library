using System;

namespace GameLibrary
{
    public class ConstantExecutionTimeStep : ISimulationTick
    {
        private readonly ISimulationTick _simulationTick;
        private readonly long _timeStep;

        private long _lastExecutionStepTime;

        public ConstantExecutionTimeStep(ISimulationTick simulationTick, long timeStep)
        {
            _simulationTick = simulationTick;
            _timeStep = timeStep;
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            long deltaTime = elapsedMilliseconds - _lastExecutionStepTime;

            long executionsCount = deltaTime % elapsedMilliseconds;

            for (int frame = 0; frame < executionsCount; frame++)
            {
                _simulationTick.ExecuteTick(_lastExecutionStepTime + _timeStep * (frame + 1));
            }

            _lastExecutionStepTime += _timeStep * executionsCount;
        }
    }
}