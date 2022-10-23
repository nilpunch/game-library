namespace GameLibrary.Rendering
{
    public interface IRenderersGroup
    {
        void Add(IRenderer gameObject);
        void Remove(IRenderer gameObject);
    }
}