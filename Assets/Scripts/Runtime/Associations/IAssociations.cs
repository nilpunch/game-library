namespace PhysicsSample
{
    public interface IAssociations<in TKey, TAssociation> : IReadOnlyAssociations<TKey, TAssociation>, IActualization
    {
        void Add(TKey key, TAssociation associatedObject);
    }
}