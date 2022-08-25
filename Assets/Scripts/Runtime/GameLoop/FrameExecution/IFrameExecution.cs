namespace PhysicsSample
{
    public interface IFrameExecution : IReadOnlyFrameExecution
    {
        void ExecuteFrame(long elapsedTime);
    }
}