namespace GameLibrary
{
    public struct Interaction<TConcrete>
    {
        public PhysicalPair<TConcrete> First { get; }
        public IPhysicalObject Second { get; }
        public Collision Collision { get; }
    }
}