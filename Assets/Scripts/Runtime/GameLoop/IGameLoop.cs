namespace PhysicsSample
{
    public interface IGameLoop : IActualization
    {
        void ExecuteFrame(long elapsedTime);
        
        void Add(IFrameExecution frameExecution);
    }
}