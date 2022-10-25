namespace GameLibrary
{
    public interface ISimulationModel<TSnapshot> : ISimulationObject
    {
        TSnapshot TakeSnapshot();
        void ApplySnapshot(TSnapshot snapshot);
    }
}