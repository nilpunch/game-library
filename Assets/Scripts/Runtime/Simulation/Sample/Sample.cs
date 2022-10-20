namespace GameLibrary
{
    public class Sample
    {
        public Sample()
        {
            var gameModel = new GameModel();

            var simulation = new Simulation<GameModel, GameSnapshot>(gameModel);
            
            simulation.AddCommand(0, new StartGameCommand());
            simulation.AddCommand(0, new MoveCharacterCommand());
        }
    }
}