namespace GameLibrary
{
    public class Simulation<TModel, TSnapshot> : ISimulation<TModel>, ISimulationTick where TModel : IModel<TSnapshot>
    {
        private readonly TModel _model;

        public Simulation(TModel model)
        {
            _model = model;
        }
        
        public void AddCommand(long tickNumber, ICommand<TModel> command)
        {
            command.Execute(_model);
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            _model.ExecuteTick(elapsedMilliseconds);
        }
    }
}