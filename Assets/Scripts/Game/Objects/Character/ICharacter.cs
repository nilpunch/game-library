namespace PhysicsSample
{
    public interface ICharacter : IFrameExecution
    {
        bool IsAlive { get; }
        void Damage(int damage);
    }
}