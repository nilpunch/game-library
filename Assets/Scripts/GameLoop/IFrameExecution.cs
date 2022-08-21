namespace PhysicsSample
{
    public interface IFrameExecution
    {
        bool CanExecuteFrame { get; }
        
        void ExecuteFrame(long time);
    }
}