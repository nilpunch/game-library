namespace GameLibrary
{
    public class VisualisationTick : ISimulationTick
    {
        private readonly IVisualisation _visualisation;

        public VisualisationTick(IVisualisation visualisation)
        {
            _visualisation = visualisation;
        }
        
        public void ExecuteTick(long elapsedMilliseconds)
        {
            _visualisation.Render(elapsedMilliseconds);
        }
    }
}