namespace GameLibrary
{
    public interface IModel<TSnapshot> : ISimulationTick
    {
        TSnapshot MakeSnapshot();
        void RestoreSnapshot(TSnapshot snapshot);
    }
}