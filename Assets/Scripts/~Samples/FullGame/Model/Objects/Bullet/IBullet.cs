using GameLibrary.Mathematics;

namespace GameLibrary.Sample
{
    public interface IBullet
    {
        void Throw(SoftVector3 velocity);
    }
}
