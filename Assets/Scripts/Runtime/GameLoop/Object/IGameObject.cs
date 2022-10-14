namespace GameLibrary
{
    /// <summary>
    /// Simulation object with short lifetime.
    /// </summary>
    public interface IGameObject : ISimulationTick, IAlive
    {
    }
}