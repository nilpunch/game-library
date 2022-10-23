namespace GameLibrary.Sample.FullGame
{
    public interface ICharacterView : IAlive
    {
        void ShowHealth(int amount);
        void Destroy();
    }
}