namespace PhysicsSample
{
    public interface IPhysicWorldLinks<TAssociation> : IFrameExecution,
        IReadOnlyPhysicWorldLinks<TAssociation>
        where TAssociation : IActuality
    {
        void Link(IPhysicalObject key, TAssociation associatedObject);
        void Unlink(IPhysicalObject key);
    }
}