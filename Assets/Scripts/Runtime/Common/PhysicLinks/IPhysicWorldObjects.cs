namespace GameLibrary
{
    public interface IPhysicWorldObjects<TLinkedObject> : IReadOnlyPhysicWorldObjects<TLinkedObject>
    {
        void Link(IPhysicalObject physicalObject, TLinkedObject linkedObject);
        void Unlink(IPhysicalObject physicalObject);
    }
}