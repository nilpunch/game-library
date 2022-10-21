using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class VisualisationGroup : IVisualisation, IVisualisationGroup
    {
        private readonly List<IVisualisation> _visualisations = new();

        public VisualisationGroup()
        {
        }

        public VisualisationGroup(IVisualisation[] visualisations)
        {
            _visualisations = visualisations.ToList();
        }

        public void Render(long elapsedMilliseconds)
        {
            foreach (var visualisation in _visualisations)
            {
                visualisation.Render(elapsedMilliseconds);
            }
        }

        public void Add(IVisualisation gameObject)
        {
            _visualisations.Add(gameObject);
        }

        public void Remove(IVisualisation gameObject)
        {
            _visualisations.Remove(gameObject);
        }
    }
}