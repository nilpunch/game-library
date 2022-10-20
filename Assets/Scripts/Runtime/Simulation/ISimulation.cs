namespace GameLibrary
{
    public interface ISimulation<out TModel, TSnapshot> : ISimulationTick where TModel : IModel<TSnapshot>
    {
        void AddCommand(long tickNumber, ICommand<TModel> command);
    }
}