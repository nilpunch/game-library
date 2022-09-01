using System;

namespace PhysicsSample
{
    public interface IGameObjectsLoop : IFrameExecution
    {
        void Add(IGameObject gameObject);
        void Remove(IGameObject gameObject);
    }
}