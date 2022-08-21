namespace PhysicsSample
{
    public interface ICollisions
    {
        Collision CalculateCollision(IPhysicalObject physicalObject, string againstTagged);
    }
}