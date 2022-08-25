namespace PhysicsSample
{
    public interface IPhysicWorldObjects<TAssociation> : IReadOnlyPhysicWorldObjects<TAssociation>, IActualization where TAssociation : IReadOnlyFrameExecution
    {
        void Add(TAssociation associatedObject, IPhysicalObject physicalObject);
        void Remove(TAssociation associatedObject);
    }
}