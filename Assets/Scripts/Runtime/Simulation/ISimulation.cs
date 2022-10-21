namespace GameLibrary
{
    public interface ISimulation<out TModel>
    {
        void AddCommand(long tickNumber, ICommand<TModel> command, bool isPrediction = false);
    }
}