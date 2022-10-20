namespace GameLibrary.Sample
{
    public class Game : ISimulationTick
    {
        private readonly ISimulationTick _gameLoop;

        public Game()
        {
            var model = new Model();
            var simulation = new Simulation<Model, ModelSnapshot>(model);
            
            var player = new Player<Model>();
            var server = new Server<Model>();
            
            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                new ConstantExecutionTimeStep(new SimulationTickGroup(new ISimulationTick[]
                {
                    new ExecuteCommands<Model>(player, simulation), // TODO: Send commands to server
                    new ExecuteCommands<Model>(server, simulation),
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