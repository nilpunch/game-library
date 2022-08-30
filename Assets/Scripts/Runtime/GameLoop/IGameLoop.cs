using System;

namespace PhysicsSample
{
    public interface IGameLoop : IFrameExecution, IActualization
    {
        void Add(IGameObject gameObject);
    }
}