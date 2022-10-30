namespace GameLibrary
{
    public interface IGameObjectsGroup
    {
        void Add(IGameObject gameObject);
        void Remove(IGameObject gameObject);
    }
}