namespace GameLibrary
{
    public interface IPhysicWorld : ICollisionsWorld
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
    }
}