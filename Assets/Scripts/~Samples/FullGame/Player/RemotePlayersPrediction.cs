namespace GameLibrary.Sample.FullGame
{
    public class RemotePlayersPrediction<TModel> : ICommandsSource<TModel>
    {
        private readonly RemoteServer<TModel> _remoteServer;

        public RemotePlayersPrediction(RemoteServer<TModel> remoteServer)
        {
            _remoteServer = remoteServer;
        }
        
        public bool HasCommands { get; }
        
        public ICommand<TModel> ReadCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}