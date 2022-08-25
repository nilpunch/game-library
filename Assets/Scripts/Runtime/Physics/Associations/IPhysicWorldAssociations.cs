namespace PhysicsSample
{
    public interface IPhysicWorldAssociations<TAssociation> : 
        IReadOnlyPhysicWorldAssociations<TAssociation>, 
        IAssociations<IPhysicalObject, TAssociation> 
        where TAssociation : IReadOnlyFrameExecution
    {
    }
}