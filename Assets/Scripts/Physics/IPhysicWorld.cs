namespace PhysicsSample
{
    public interface IPhysicWorld : ICollisions, IFrameExecution
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
        
        void AddInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction);
        void RemoveInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction);
    }
}