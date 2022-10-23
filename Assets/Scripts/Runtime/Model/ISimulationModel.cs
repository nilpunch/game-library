namespace GameLibrary
{
    public interface ISimulationModel<TSnapshot> : ISimulationTick
    {
        TSnapshot TakeSnapshot();
        void ApplySnapshot(TSnapshot snapshot);
    }
}