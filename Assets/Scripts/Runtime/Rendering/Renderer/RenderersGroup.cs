using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.Rendering
{
    public class RenderersGroup : IRenderer, IRenderersGroup
    {
        private readonly List<IRenderer> _visualisations = new();

        public RenderersGroup()
        {
        }

        public RenderersGroup(IRenderer[] visualisations)
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

        public void Add(IRenderer gameObject)
        {
            _visualisations.Add(gameObject);
        }

        public void Remove(IRenderer gameObject)
        {
            _visualisations.Remove(gameObject);
        }
    }
}