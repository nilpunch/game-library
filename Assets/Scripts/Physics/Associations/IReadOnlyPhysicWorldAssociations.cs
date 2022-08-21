namespace PhysicsSample
{
    public interface IReadOnlyPhysicWorldAssociations<T>
    {
        bool HasAssociatedObject(IPhysicalObject physicalObject);
        T GetAssociatedObject(IPhysicalObject physicalObject);
    }
}