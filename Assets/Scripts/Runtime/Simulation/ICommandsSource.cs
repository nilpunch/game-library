namespace GameLibrary
{
    public interface ICommandsSource<TModel>
    {
        bool HasCommands { get; }
        ICommand<TModel> ReadCommand();
    }
}