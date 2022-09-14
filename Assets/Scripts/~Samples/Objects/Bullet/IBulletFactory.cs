namespace GameLibrary
{
    public interface IBulletFactory
    {
        IBullet Create(int damage, long liveTime);
    }
}