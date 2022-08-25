namespace PhysicsSample
{
    public interface IReadOnlyPhysicWorldObjects<out TAssociation>
    {
        bool HasAssociatedObject(IPhysicalObject physicalObject);
        TAssociation GetAssociatedObject(IPhysicalObject physicalObject);
    }
}