namespace GameLibrary.Sample.FullGame
{
    public interface IBullet : IGameObject
    {
        void Throw(Vector3 velocity);
    }
}