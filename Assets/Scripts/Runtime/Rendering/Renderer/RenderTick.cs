namespace GameLibrary.Rendering
{
    /// <summary>
    /// Adapter to <see cref="ISimulationTick"/>
    /// </summary>
    public class RenderTick : ISimulationTick
    {
        private readonly IRenderer _renderer;

        public RenderTick(IRenderer renderer)
        {
            _renderer = renderer;
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _renderer.Render(elapsedMilliseconds);
        }
    }
}