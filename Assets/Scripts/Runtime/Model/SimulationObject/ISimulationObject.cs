namespace GameLibrary
{
    public interface ISimulationObject
    {
        void Step(long elapsedMilliseconds);
    }
}