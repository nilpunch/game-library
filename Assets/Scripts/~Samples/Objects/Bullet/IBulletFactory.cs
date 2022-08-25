namespace PhysicsSample
{
    public interface IBulletFactory
    {
        IBullet Create(int damage, long liveTime);
    }
}