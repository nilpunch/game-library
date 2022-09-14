namespace GameLibrary
{
    public interface IPhysicWorld : ICollisionsWorld, IFrameExecution
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
    }
}