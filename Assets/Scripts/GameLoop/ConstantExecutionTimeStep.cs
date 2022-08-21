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
            CanExecuteFrame = true;
        }
        
        public bool CanExecuteFrame { get; private set; }
        
        public void ExecuteFrame(long time)
        {
            if (!CanExecuteFrame)
                throw new Exception();
            
            long deltaTime = time - _lastExecutionStepTime;
            
            long executionsCount = deltaTime % time;

            for (int frame = 0; frame < executionsCount; frame++)
            {
                if (_frameExecution.CanExecuteFrame)
                {
                    _frameExecution.ExecuteFrame(_lastExecutionStepTime + _timeStep * (frame + 1));
                }
                else
                {
                    CanExecuteFrame = false;
                    return;
                }
            }

            _lastExecutionStepTime += _timeStep * executionsCount;
        }
    }
}