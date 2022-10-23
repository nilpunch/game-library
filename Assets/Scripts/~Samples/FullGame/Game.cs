namespace GameLibrary.Sample.FullGame
{
    public class Game : ISimulationTick
    {
        private readonly ISimulationTick _gameLoop;

        public Game()
        {
            var model = new Model();
            var simulation = new Simulation<Model, ModelSnapshot>(model);

            var remoteServer = new RemoteServer<Model>();
            
            var remotePlayers = new RemotePlayersPrediction<Model>(remoteServer); // Will repeat last players commands
            var player = new Player<Model>();

            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                new ConstantExecutionTimeStep(new SimulationTickGroup(new ISimulationTick[]
                {
                    new PredictCommands<Model>(remotePlayers, simulation),
                    new PredictCommandsAndSendToServer<Model>(player, simulation, remoteServer),
                    new ApplyCommands<Model>(remoteServer, simulation),
                    simulation,
                }), timeStep: 20),
                
                // Variable execution step for visualisation, so no framerate cap :)
                new VisualisationTick(model)
            });
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameLoop.ExecuteTick(elapsedMilliseconds);
        }
    }
}