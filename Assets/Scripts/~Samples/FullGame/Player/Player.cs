namespace GameLibrary.Sample.FullGame
{
    public class Player<TModel> : ICommandsSource<TModel>
    {
        public bool HasCommands { get; }
        
        public ICommand<TModel> ReadCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}