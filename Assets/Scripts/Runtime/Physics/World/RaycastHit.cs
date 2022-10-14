namespace GameLibrary
{
    public struct RaycastHit
    {
        public bool Occure { get; }
        
        public Contact Contact { get; }
        
        public IPhysicalObject PhysicalObject { get; }
    }
}