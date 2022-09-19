namespace GameLibrary
{
    public interface IReadOnlyPhysicWorldObjects<TLink>
    {
        bool HasLink(IPhysicalObject key);
        TLink Get(IPhysicalObject key);
    }
}