namespace GameLibrary
{
    public interface ICommandsSource<in TModel>
    {
        bool HasCommands { get; }
        ICommand<TModel> ReadCommand();
    }
}