namespace GameLibrary
{
    public interface ISimulationModel<TSnapshot> : ISimulationTick
    {
        TSnapshot MakeSnapshot();
        void RestoreSnapshot(TSnapshot snapshot);
    }
}