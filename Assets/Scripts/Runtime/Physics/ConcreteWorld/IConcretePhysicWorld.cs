namespace GameLibrary
{
    public interface IConcretePhysicWorld<TConcrete> : IConcreteCollisionWorld<TConcrete>
    {
        void Add(IPhysicalObject physicalObject, TConcrete concreteObject);
        void Remove(IPhysicalObject physicalObject);

        void CleanAllDead();
    }
}