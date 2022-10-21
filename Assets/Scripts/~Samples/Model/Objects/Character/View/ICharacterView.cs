namespace GameLibrary.Sample
{
    public interface ICharacterView : IAlive
    {
        void ShowHealth(int amount);
        void Destroy();
    }
}