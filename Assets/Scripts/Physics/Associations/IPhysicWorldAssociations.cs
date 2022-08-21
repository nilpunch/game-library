namespace PhysicsSample
{
    public interface IPhysicWorldAssociations<T> : IReadOnlyPhysicWorldAssociations<T>
    {
        void Add(IPhysicalObject physicalObject, T associatedObject);
        void Remove(IPhysicalObject physicalObject);
    }
}