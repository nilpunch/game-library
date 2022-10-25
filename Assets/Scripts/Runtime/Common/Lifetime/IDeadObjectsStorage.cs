namespace GameLibrary.Lifetime
{
    public interface IDeadObjectsStorage
    {
        void CleanupDeadObjects();
    }
}