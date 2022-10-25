namespace GameLibrary.Sample
{
    public class ApplyCommands<TModel> : ISimulationObject
    {
        private readonly ICommandsSource<TModel> _commandsSource;
        private readonly ISimulation<TModel> _simulation;

        public ApplyCommands(ICommandsSource<TModel> commandsSource, ISimulation<TModel> simulation)
        {
            _commandsSource = commandsSource;
            _simulation = simulation;
        }
        
        public void Step(long elapsedMilliseconds)
        {
            while (_commandsSource.HasCommands)
            {
                var command = _commandsSource.ReadCommand();
                _simulation.AddCommand(elapsedMilliseconds, command);
            }
        }
    }
}