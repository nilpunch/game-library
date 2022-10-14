namespace GameLibrary
{
    public struct ConcreteInteraction<TConcrete>
    {
        public TConcrete FirstObject { get; }
        public IPhysicalObject First { get; }
        public IPhysicalObject Second { get; }
        public Collision Collision { get; }
    }
}