namespace PhysicsSample
{
    public interface IReadOnlyAssociations<in TKey, out TAssociation>
    {
        bool HasAssociation(TKey key);
        TAssociation GetAssociation(TKey key);
    }
}