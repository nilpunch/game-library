namespace PhysicsSample
{
    public class GameLoop : IFrameExecution
    {
        private readonly IFrameExecution[] _frameExecutions;

        public GameLoop(IFrameExecution[] frameExecutions)
        {
            _frameExecutions = frameExecutions;
        }
        
        public void ExecuteFrame(long elapsedTime)
        {
            foreach (var frameExecution in _frameExecutions)
            {
                frameExecution.ExecuteFrame(elapsedTime);
            }
        }
    }
}