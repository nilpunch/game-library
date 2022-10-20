namespace GameLibrary
{
    public class StartGameCommand : ICommand<IGameStage>
    {
        public void Execute(IGameStage model)
        {
            model.StartGame();
        }
    }
}