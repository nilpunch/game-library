namespace GameLibrary.Physics
{
    public struct CollisionManifold<TConcrete>
    {
        public PhysicalPair<TConcrete> First { get; }
        public IRigidbody Second { get; }
        public Collision Collision { get; }
    }
}