namespace GameLibrary
{
    public class Simulation<TModel, TSnapshot> : ISimulation<TModel, TSnapshot> where TModel : IModel<TSnapshot>
    {
        private readonly TModel _model;

        public Simulation(TModel model)
        {
            _model = model;
        }
        
        public void AddCommand(long tickNumber, ICommand<TModel> command)
        {
            throw new System.NotImplementedException();
        }

        public void ExecuteTick(long elapsedMilliseconds)
        {
            throw new System.NotImplementedException();
        }
    }
}