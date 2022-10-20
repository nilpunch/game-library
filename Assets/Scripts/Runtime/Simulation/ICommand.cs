namespace GameLibrary
{
    public interface ICommand<in TModel>
    {
        void Execute(TModel model);
    }
}