using System;

namespace GameLibrary
{
    public interface IGameObjectsLoop : IFrameExecution
    {
        void Add(IGameObject gameObject);
        void Remove(IGameObject gameObject);
    }
}