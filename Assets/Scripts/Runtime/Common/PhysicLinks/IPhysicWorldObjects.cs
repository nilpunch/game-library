namespace GameLibrary
{
    public interface IPhysicWorldObjects<TLink> : IReadOnlyPhysicWorldObjects<TLink>
    {
        void Link(IPhysicalObject key, TLink associatedObject);
        void Unlink(IPhysicalObject key);
    }
}