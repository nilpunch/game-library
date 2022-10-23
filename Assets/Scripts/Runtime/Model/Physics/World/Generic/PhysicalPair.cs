namespace GameLibrary
{
    public readonly struct PhysicalPair<TConcrete>
    {
        public PhysicalPair(IPhysicalObject physicalObject, TConcrete concrete)
        {
            PhysicalObject = physicalObject;
            Concrete = concrete;
        }

        public TConcrete Concrete { get; }
        public IPhysicalObject PhysicalObject { get; }
    }
}