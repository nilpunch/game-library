namespace GameLibrary.Sample.FullGame
{
    public interface IRemoteServer<TModel>
    {
        public void SendCommand(long timeMilliseconds, ICommand<TModel> command);
    }
}