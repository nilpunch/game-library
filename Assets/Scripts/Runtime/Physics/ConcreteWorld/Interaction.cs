namespace GameLibrary
{
    public struct Interaction<TConcrete>
    {
        public TConcrete Object { get; }
        public IPhysicalObject PhysicalObject { get; }
        public IPhysicalObject Other { get; }
        public Collision Collision { get; }
    }
}