using System.Collections.Generic;
using System.Linq;
using GameLibrary.Lifetime;

namespace GameLibrary.Rendering
{
    public class AliveRenderersGroup : IAliveRenderersGroup, IRenderer, IDeadObjectsStorage
    {
        private readonly List<IAliveRenderer> _renderers = new();

        public AliveRenderersGroup()
        {
        }

        public AliveRenderersGroup(IAliveRenderer[] visualisations)
        {
            _renderers = visualisations.ToList();
        }

        public void Render(long elapsedMilliseconds)
        {
            foreach (var renderer in _renderers)
            {
                if (renderer.IsAlive)
                    renderer.Render(elapsedMilliseconds);
            }
        }

        public void Add(IAliveRenderer gameObject)
        {
            _renderers.Add(gameObject);
        }

        public void Remove(IAliveRenderer gameObject)
        {
            _renderers.Remove(gameObject);
        }

        public void CleanupDeadObjects()
        {
            _renderers.RemoveAll(visualisation => !visualisation.IsAlive);
        }
    }
}