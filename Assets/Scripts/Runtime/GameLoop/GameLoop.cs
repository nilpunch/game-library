using System.Collections.Generic;

namespace PhysicsSample
{
    public class GameLoop : IGameLoop
    {
        private readonly List<IFrameExecution> _frameExecutions = new();

        public void ExecuteFrame(long elapsedTime)
        {
            foreach (var frameExecution in _frameExecutions)
            {
                frameExecution.ExecuteFrame(elapsedTime);
            }
        }

        public void Add(IFrameExecution frameExecution)
        {
            _frameExecutions.Add(frameExecution);
        }

        public void RemoveAllInactual()
        {
            _frameExecutions.RemoveAll(frameExecution => !frameExecution.CanExecuteFrame);
        }
    }
}