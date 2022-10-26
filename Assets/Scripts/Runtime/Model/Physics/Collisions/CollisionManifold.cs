namespace GameLibrary
{
    public struct CollisionManifold
    {
        public IRigidbody First { get; }
        public IRigidbody Second { get; }
        
        public Collision Collision { get; }
    }
}