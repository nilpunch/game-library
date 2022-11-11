using System.Runtime.CompilerServices;

namespace GameLibrary.Math
{
    public readonly struct SoftQuaternion
    {
        public readonly SoftFloat X;
        public readonly SoftFloat Y;
        public readonly SoftFloat Z;
        public readonly SoftFloat W;

        /// <summary>
        /// Constructs a quaternion from four SoftFloat values.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SoftQuaternion(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }
    }
}