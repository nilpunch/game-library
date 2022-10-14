namespace GameLibrary
{
    public struct ConcreteRaycastHit<TConcrete>
    {
        public bool Occure { get; }
        
        public Contact Contact { get; }
        
        public TConcrete Object { get; }
        
        public IPhysicalObject PhysicalObject { get; }
    }
}