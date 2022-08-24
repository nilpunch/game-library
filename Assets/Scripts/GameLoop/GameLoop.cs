using System.Collections.Generic;

namespace PhysicsSample
{
    public class GameLoop : IGameLoop, IActualization
    {
        private readonly List<IFrameExecution> _frameExecutions = new();

        public void ExecuteFrame(long time)
        {
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

        public void RemoveAllInactual()
        {
            _frameExecutions.RemoveAll(frameExecution => !frameExecution.CanExecuteFrame);
        }
    }
}