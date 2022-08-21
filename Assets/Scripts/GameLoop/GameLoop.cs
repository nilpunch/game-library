using System.Collections.Generic;

namespace PhysicsSample
{
    public class GameLoop : IGameLoop
    {
        private readonly List<IFrameExecution> _frameExecutions = new();
        
        public bool CanExecuteFrame => true;
        
        public void ExecuteFrame(long time)
        {
            _frameExecutions.RemoveAll(execution => !execution.CanExecuteFrame);

            foreach (var frameExecution in _frameExecutions)
            {
                frameExecution.ExecuteFrame(time);
            }
        }

        public void Add(IFrameExecution frameExecution)
        {
            _frameExecutions.Add(frameExecution);
        }

        public void Remove(IFrameExecution frameExecution)
        {
            _frameExecutions.Remove(frameExecution);
        }
    }
}