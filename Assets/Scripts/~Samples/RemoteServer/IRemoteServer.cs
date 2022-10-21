namespace GameLibrary.Sample
{
    public interface IRemoteServer<TModel>
    {
        public void SendCommand(long timeMilliseconds, ICommand<TModel> command);
    }
}