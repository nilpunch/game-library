namespace PhysicsSample
{
    public interface ICharacter : IFrameExecution
    {
        bool IsAlive { get; }
        void TakeDamage(int damage);
    }
}