using GameLibrary.Math;

namespace GameLibrary.Sample
{
    public interface IBullet : IGameObject
    {
        void Throw(Vector3 velocity);
    }
}