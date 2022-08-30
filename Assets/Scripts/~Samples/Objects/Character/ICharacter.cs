namespace PhysicsSample
{
    public interface ICharacter : IGameObject
    {
        bool IsAlive { get; }
        void TakeDamage(int damage);
    }
}