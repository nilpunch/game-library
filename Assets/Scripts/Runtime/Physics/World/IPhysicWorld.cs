namespace PhysicsSample
{
    public interface IPhysicWorld : ICollisions, IGameObject
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
        
        void AddInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction);
        void RemoveInteraction(IPhysicalObjectsInteraction physicalObjectsInteraction);
    }
}