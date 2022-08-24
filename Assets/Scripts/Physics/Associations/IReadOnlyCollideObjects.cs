namespace PhysicsSample
{
    public interface IReadOnlyCollideObjects<T>
    {
        bool HasAssociatedObject(IPhysicalObject physicalObject);
        T GetAssociatedObject(IPhysicalObject physicalObject);
    }
}