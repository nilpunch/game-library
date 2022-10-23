namespace GameLibrary.Sample
{
    public class RemoteServer<TModel> : IRemoteServer<TModel>, ICommandsSource<TModel>
    {
        public bool HasCommands { get; }
        
        public ICommand<TModel> ReadCommand()
        {
            throw new System.NotImplementedException();
        }

        public void SendCommand(long timeMilliseconds, ICommand<TModel> command)
        {
            throw new System.NotImplementedException();
        }
    }
}