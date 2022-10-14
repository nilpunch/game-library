namespace GameLibrary
{
    public interface IReadOnlyPhysicWorldObjects<TLinkedObject>
    {
        bool HasLinkedObject(IPhysicalObject physicalObject);
        TLinkedObject GetLinkedObject(IPhysicalObject physicalObject);
    }
}