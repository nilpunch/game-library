using System;
using System.Runtime.CompilerServices;

namespace GameLibrary.Math
{
    public readonly struct SoftVector3
    {
        public readonly SoftFloat X;
        public readonly SoftFloat Y;
        public readonly SoftFloat Z;

        /// <summary>
        /// Constructs a vector from three SoftFloat values.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public SoftVector3(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        /// <summary>
        /// Returns the result of a componentwise addition.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator +(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        /// <summary>
        /// Returns the result of a componentwise addition.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator +(SoftVector3 a, SoftFloat b)
        {
            return new SoftVector3(a.X + b, a.Y + b, a.Z + b);
        }
        
        /// <summary>
        /// Returns the result of a componentwise addition.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator +(SoftFloat a, SoftVector3 b)
        {
            return b + a;
        }
        
        /// <summary>
        /// Returns the result of a componentwise subtraction.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator -(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }
        
        /// <summary>
        /// Returns the result of a componentwise subtraction.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator -(SoftVector3 a, SoftFloat b)
        {
            return new SoftVector3(a.X - b, a.Y - b, a.Z - b);
        }
        
        /// <summary>
        /// Returns the result of a componentwise addition.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator -(SoftFloat a, SoftVector3 b)
        {
            return b - a;
        }
        
        /// <summary>
        /// Returns the result of a componentwise multiplication.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator *(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }
        
        /// <summary>
        /// Returns the result of a componentwise multiplication.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator *(SoftVector3 a, SoftFloat b)
        {
            return new SoftVector3(a.X * b, a.Y * b, a.Z * b);
        }
        
        /// <summary>
        /// Returns the result of a componentwise multiplication.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator *(SoftFloat a, SoftVector3 b)
        {
            return b * a;
        }

        /// <summary>
        /// Returns the result of a componentwise division.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 operator /(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(a.X / b.X, a.Y / b.Y, a.Z / b.Z);
        }
        
        /// <summary>
        /// Returns the dot product of two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(SoftVector3 a, SoftVector3 b)
        {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }
        
        /// <summary>
        /// Returns the cross product of two vectors.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 Cross(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
        }

        /// <summary>
        /// Returns the componentwise maximum.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 Max(SoftVector3 a, SoftVector3 b)
        {
            return new SoftVector3(SoftMath.Max(a.X, b.X), SoftMath.Max(a.Y, b.Y), SoftMath.Max(a.Z, b.Z));
        }

        /// <summary>
        /// Returns the length of a vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(SoftVector3 a)
        {
            return SoftMath.Sqrt(Dot(a, a));
        }

        /// <summary>
        /// Returns the squared length of a vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(SoftVector3 a)
        {
            return Dot(a, a);
        }

        /// <summary>
        /// Returns the componentwise absolute value of a vector.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftVector3 Abs(SoftVector3 a)
        {
            return new SoftVector3(SoftMath.Abs(a.X), SoftMath.Abs(a.Y), SoftMath.Abs(a.Z));
        }
    }
}