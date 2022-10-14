namespace GameLibrary
{
    public interface IPhysicSubWorld<TConcrete> : ICollisionsWorld<TConcrete>
    {
        void Add(IPhysicalObject physicalObject, TConcrete concreteObject);
        void Remove(IPhysicalObject physicalObject);

        void CleanAllDead();
    }
}