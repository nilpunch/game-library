namespace PhysicsSample
{
    public interface IAssociations<in TKey, TAssociation> : IReadOnlyAssociations<TKey, TAssociation>
    {
        void Add(TKey key, TAssociation associatedObject);
        void Remove(TKey key);
    }
}