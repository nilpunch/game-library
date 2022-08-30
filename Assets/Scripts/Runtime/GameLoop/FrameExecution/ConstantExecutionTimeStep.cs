using System;

namespace PhysicsSample
{
    public class ConstantExecutionTimeStep : IGameObject
    {
        private readonly IGameObject _frameExecution;
        private readonly long _timeStep;

        private long _lastExecutionStepTime;

        public ConstantExecutionTimeStep(IGameObject frameExecution, long timeStep)
        {
            _frameExecution = frameExecution;
            _timeStep = timeStep;
            IsActual = true;
        }
        
        public bool IsActual { get; private set; }
        
        public void ExecuteFrame(long elapsedTime)
        {
            if (!IsActual)
                throw new Exception();
            
            long deltaTime = elapsedTime - _lastExecutionStepTime;
            
            long executionsCount = deltaTime % elapsedTime;

            for (int frame = 0; frame < executionsCount; frame++)
            {
                if (_frameExecution.IsActual)
                {
                    _frameExecution.ExecuteFrame(_lastExecutionStepTime + _timeStep * (frame + 1));
                }
                else
                {
                    IsActual = false;
                    return;
                }
            }

            _lastExecutionStepTime += _timeStep * executionsCount;
        }
    }
}