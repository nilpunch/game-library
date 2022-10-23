using System.Collections.Generic;
using System.Linq;

namespace GameLibrary
{
    public class AliveVisualisationGroup : IAliveVisualisationGroup, IVisualisation, IDeadStorage
    {
        private readonly List<IAliveVisualisation> _visualisations = new();

        public AliveVisualisationGroup()
        {
        }

        public AliveVisualisationGroup(IAliveVisualisation[] visualisations)
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

        public void Add(IAliveVisualisation gameObject)
        {
            _visualisations.Add(gameObject);
        }

        public void Remove(IAliveVisualisation gameObject)
        {
            _visualisations.Remove(gameObject);
        }

        public void CleanupDeadObjects()
        {
            _visualisations.RemoveAll(visualisation => !visualisation.IsAlive);
        }
    }
}