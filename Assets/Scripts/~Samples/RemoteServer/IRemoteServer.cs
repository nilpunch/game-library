namespace GameLibrary.Sample
{
    public interface IRemoteServer<TModel>
    {
        public void SendCommand(ICommand<TModel> command);
    }
}