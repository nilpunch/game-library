namespace PhysicsSample
{
    public interface IReadOnlyPhysicWorldAssociations<out TAssociation> :
        IReadOnlyAssociations<IPhysicalObject, TAssociation> 
        where TAssociation : IReadOnlyFrameExecution
    {
    }
}