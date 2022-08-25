namespace PhysicsSample
{
    public interface IGameLoop : IActualization
    {
        void ExecuteFrame(long elapsedtime);
        
        void Add(IFrameExecution frameExecution);
        void Remove(IFrameExecution frameExecution);
    }
}