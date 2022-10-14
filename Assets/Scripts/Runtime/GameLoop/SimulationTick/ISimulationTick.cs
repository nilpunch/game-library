namespace GameLibrary
{
    public interface ISimulationTick
    {
        void ExecuteTick(long elapsedMilliseconds);
    }
}