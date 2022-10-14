namespace GameLibrary
{
    public interface IBullet : IGameObject
    {
        void Throw(Vector3 velocity);
    }
}