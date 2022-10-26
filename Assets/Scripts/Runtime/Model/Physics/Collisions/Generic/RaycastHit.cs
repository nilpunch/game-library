namespace GameLibrary
{
    public struct RaycastHit<TConcrete>
    {
        public bool Occure { get; }
        
        public ContactPoint ContactPoint { get; }
        
        public TConcrete Object { get; }
        
        public IRigidbody Rigidbody { get; }
    }
}