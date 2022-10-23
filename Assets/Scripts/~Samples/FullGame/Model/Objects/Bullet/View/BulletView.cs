namespace GameLibrary.Sample.FullGame
{
    public class BulletView : IBulletView, IAliveVisualisation
    {
        public bool IsAlive { get; }

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