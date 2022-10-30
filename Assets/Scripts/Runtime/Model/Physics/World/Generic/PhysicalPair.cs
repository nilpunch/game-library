namespace GameLibrary.Physics
{
    public readonly struct PhysicalPair<TConcrete>
    {
        public PhysicalPair(IRigidbody rigidbody, TConcrete concrete)
        {
            Rigidbody = rigidbody;
            Concrete = concrete;
        }

        public TConcrete Concrete { get; }
        public IRigidbody Rigidbody { get; }
    }
}