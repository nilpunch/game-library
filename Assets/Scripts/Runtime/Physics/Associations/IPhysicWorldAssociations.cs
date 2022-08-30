namespace PhysicsSample
{
    public interface IPhysicWorldAssociations<TAssociation> : 
        IReadOnlyPhysicWorldAssociations<TAssociation>, 
        IAssociations<IPhysicalObject, TAssociation>,
        IActualization
        where TAssociation : IActuality
    {
    }
}