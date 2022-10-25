using GameLibrary.GameLoop;

namespace GameLibrary.Rendering
{
    public class RenderingLoop : IGameLoop
    {
        private readonly IRenderer _renderer;

        public RenderingLoop(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public void Update(long elapsedMilliseconds)
        {
            _renderer.Render(elapsedMilliseconds);
        }
    }
}