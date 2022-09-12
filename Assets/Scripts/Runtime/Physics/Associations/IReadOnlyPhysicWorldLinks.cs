namespace PhysicsSample
{
    public interface IPhysicWorldLinks<TLink>
    {
        bool HasLink(IPhysicalObject key);
        TLink Get(IPhysicalObject key);
        void Link(IPhysicalObject key, TLink associatedObject);
        void Unlink(IPhysicalObject key);

        void UnlinkAllInactual();
    }
}