namespace PhysicsSample
{
    public interface ICollideObjects<T> : IReadOnlyCollideObjects<T>
    {
        void Add(T associatedObject, IPhysicalObject physicalObject);
        void Remove(T associatedObject);
    }
}