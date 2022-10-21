namespace GameLibrary.Sample
{
    public class PredictRemotePlayersInput<TModel> : ICommandsSource<TModel>
    {
        public bool HasCommands { get; }
        
        public ICommand<TModel> ReadCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}