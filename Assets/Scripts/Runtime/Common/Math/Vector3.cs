namespace GameLibrary.Math
{
    public struct Vector3
    {
        public static Vector3 Forward => new Vector3();
        public static Vector3 Zero => new Vector3();
        
        public Scalar X { get; set; }
        public Scalar Y { get; set; }
        public Scalar Z { get; set; }
    }
}