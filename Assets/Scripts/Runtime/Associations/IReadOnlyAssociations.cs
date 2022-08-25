namespace PhysicsSample
{
    public interface IReadOnlyAssociations<in TKey, out TAssociation>
    {
        bool HasAssociatedObject(TKey key);
        TAssociation GetAssociatedObject(TKey key);
    }
}