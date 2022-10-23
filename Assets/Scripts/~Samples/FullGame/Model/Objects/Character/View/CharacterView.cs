namespace GameLibrary.Sample.FullGame
{
    public class CharacterView : ICharacterView, IAliveVisualisation
    {
        public bool IsAlive { get; }

        public void ShowHealth(int amount)
        {
            throw new System.NotImplementedException();
        }

        public void Destroy()
        {
            throw new System.NotImplementedException();
        }

        public void Render(long elapsedMilliseconds)
        {
            throw new System.NotImplementedException();
        }
    }
}