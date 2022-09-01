namespace PhysicsSample
{
    public interface IReadOnlyPhysicWorldLinks<out TLink>
    {
        bool HasLink(IPhysicalObject key);
        TLink Get(IPhysicalObject key);
    }
}