using System;

namespace GameLibrary
{
    public interface IGameObjectsGroup : ISimulationTick
    {
        void Add(IGameObject gameObject);
        void Remove(IGameObject gameObject);
    }
}