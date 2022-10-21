namespace GameLibrary
{
    public interface IVisualisationGroup
    {
        void Add(IVisualisation gameObject);
        void Remove(IVisualisation gameObject);
    }
}