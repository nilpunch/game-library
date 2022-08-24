namespace PhysicsSample
{
    public interface IPhysicalObjectsInteraction
    {
        void Interact(IPhysicalObject first, IPhysicalObject second, Collision collision);
    }
}