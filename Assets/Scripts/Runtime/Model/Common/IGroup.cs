namespace GameLibrary
{
    public interface IGroup<in TObject>
    {
        void Add(TObject instance);
        void Remove(TObject instance);
    }
}
