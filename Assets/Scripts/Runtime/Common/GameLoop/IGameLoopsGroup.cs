namespace GameLibrary.GameLoop
{
    public interface IGameLoopsGroup
    {
        void Add(IGameLoop gameLoop);
        void Remove(IGameLoop gameLoop);
    }
}