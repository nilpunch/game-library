using GameLibrary.Lifetime;
using GameLibrary.Rendering;

namespace GameLibrary.Sample
{
    public class Game : ISimulationTick
    {
        private readonly ISimulationTick _gameLoop;

        public Game()
        {
            var graphicLibrary = new FakeGraphicLibrary();

            var viewLibrary = new ViewLibrary(graphicLibrary);
            
            var model = new Model(viewLibrary);
            
            var simulation = new DeterministicSimulation<Model, ModelSnapshot>(model);

            _gameLoop = new SimulationTickGroup(new ISimulationTick[]
            {
                simulation,
                new CleanupDeadTick(graphicLibrary),
                new RenderTick(graphicLibrary),
            });
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _gameLoop.ExecuteTick(elapsedMilliseconds);
        }
    }
}