using System;

namespace PhysicsSample
{
    public class ConstantExecutionTimeStep : IFrameExecution
    {
        private readonly IFrameExecution _frameExecution;
        private readonly long _timeStep;

        private long _lastExecutionStepTime;

        public ConstantExecutionTimeStep(IFrameExecution frameExecution, long timeStep)
        {
            _frameExecution = frameExecution;
            _timeStep = timeStep;
        }
        
        public void ExecuteFrame(long elapsedTime)
        {
            long deltaTime = elapsedTime - _lastExecutionStepTime;
            
            long executionsCount = deltaTime % elapsedTime;

            for (int frame = 0; frame < executionsCount; frame++)
            {
                _frameExecution.ExecuteFrame(_lastExecutionStepTime + _timeStep * (frame + 1));
            }

            _lastExecutionStepTime += _timeStep * executionsCount;
        }
    }
}