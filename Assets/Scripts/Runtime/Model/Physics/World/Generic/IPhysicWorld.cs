namespace GameLibrary
{
    public interface IPhysicWorld<TConcrete> : ICollisionsWorld<TConcrete>
    {
        void Add(IRigidbody rigidbody, TConcrete concreteObject);
        void Remove(IRigidbody rigidbody);
    }
}