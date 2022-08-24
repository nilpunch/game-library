namespace PhysicsSample
{
    public interface IGameLoop
    {
        void ExecuteFrame(long elapsedtime);
        
        void Add(IFrameExecution frameExecution);
        void Remove(IFrameExecution frameExecution);
    }
}