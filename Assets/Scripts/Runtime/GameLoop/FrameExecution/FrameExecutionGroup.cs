namespace GameLibrary
{
    public class FrameExecutionGroup : IFrameExecution
    {
        private readonly IFrameExecution[] _frameExecutions;

        public FrameExecutionGroup(IFrameExecution[] frameExecutions)
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