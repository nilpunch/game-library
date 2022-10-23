namespace GameLibrary
{
    public struct Interaction
    {
        public IPhysicalObject First { get; }
        public IPhysicalObject Second { get; }
        public Collision Collision { get; }
    }
}