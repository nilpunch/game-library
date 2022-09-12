namespace PhysicsSample
{
    public interface IPhysicWorld : ICollisions, IFrameExecution
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
    }
}