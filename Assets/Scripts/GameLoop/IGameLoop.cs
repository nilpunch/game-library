namespace PhysicsSample
{
    public interface IGameLoop : IFrameExecution
    {
        void Add(IFrameExecution frameExecution);
        void Remove(IFrameExecution frameExecution);
    }
}