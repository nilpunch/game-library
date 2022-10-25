using GameLibrary.Rendering;
using GameLibrary.GameLoop;

namespace GameLibrary.Sample
{
    public class Game : IGameLoop
    {
        private readonly IGameLoop _gameLoop;

        public Game()
        {
            var graphicLibrary = new FakeGraphicLibrary();

            var viewLibrary = new ViewLibrary(graphicLibrary);
            
            var model = new Model(viewLibrary);
            
            var simulation = new DeterministicSimulation<Model, ModelSnapshot>(model);

            _gameLoop = new GameLoopsGroup(new IGameLoop[]
            {
                simulation,
                new RenderingLoop(graphicLibrary),
            });
        }
        
        public void Update(long elapsedMilliseconds)
        {
            _gameLoop.Update(elapsedMilliseconds);
        }
    }
}