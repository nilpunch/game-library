namespace PhysicsSample
{
    public interface IObjectsInteraction<in TFirst, in TSecond>
    {
        void Interact(TFirst first, TSecond second, Collision collision);
    }
}