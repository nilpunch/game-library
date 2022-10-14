namespace GameLibrary
{
    public interface IPhysicWorld : ICollisionsWorld, ISimulationTick
    {
        void Add(IPhysicalObject physicalObject);
        void Remove(IPhysicalObject physicalObject);
    }
}