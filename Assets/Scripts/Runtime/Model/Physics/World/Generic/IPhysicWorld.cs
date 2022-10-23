namespace GameLibrary
{
    public interface IPhysicWorld<TConcrete> : ICollisionsWorld<TConcrete>
    {
        void Add(IPhysicalObject physicalObject, TConcrete concreteObject);
        void Remove(IPhysicalObject physicalObject);
    }
}