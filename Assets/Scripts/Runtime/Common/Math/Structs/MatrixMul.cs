using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    partial class Math
    {
        /// <summary>Returns the float value result of a matrix multiplication between a float value and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Mul(SoftFloat a, SoftFloat b)
        {
            return a * b;
        }

        /// <summary>Returns the float value result of a matrix multiplication between a Float2 row vector and a Float2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Mul(Float2 a, Float2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>Returns the Float2 row vector result of a matrix multiplication between a Float2 row vector and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float2 a, Float2X2 b)
        {
            return Float2(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y);
        }

        /// <summary>Returns the Float3 row vector result of a matrix multiplication between a Float2 row vector and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float2 a, Float2x3 b)
        {
            return Float3(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y);
        }

        /// <summary>Returns the Float4 row vector result of a matrix multiplication between a Float2 row vector and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float2 a, Float2x4 b)
        {
            return Float4(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y,
                a.x * b.c3.x + a.y * b.c3.y);
        }

        /// <summary>Returns the float value result of a matrix multiplication between a Float3 row vector and a Float3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Mul(Float3 a, Float3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        /// <summary>Returns the Float2 row vector result of a matrix multiplication between a Float3 row vector and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float3 a, Float3x2 b)
        {
            return Float2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z);
        }

        /// <summary>Returns the Float3 row vector result of a matrix multiplication between a Float3 row vector and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float3 a, Float3X3 b)
        {
            return Float3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z);
        }

        /// <summary>Returns the Float4 row vector result of a matrix multiplication between a Float3 row vector and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float3 a, Float3x4 b)
        {
            return Float4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z);
        }

        /// <summary>Returns the float value result of a matrix multiplication between a Float4 row vector and a Float4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Mul(Float4 a, Float4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        /// <summary>Returns the Float2 row vector result of a matrix multiplication between a Float4 row vector and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float4 a, Float4x2 b)
        {
            return Float2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w);
        }

        /// <summary>Returns the Float3 row vector result of a matrix multiplication between a Float4 row vector and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float4 a, Float4x3 b)
        {
            return Float3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w);
        }

        /// <summary>Returns the Float4 row vector result of a matrix multiplication between a Float4 row vector and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float4 a, Float4X4 b)
        {
            return Float4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z + a.w * b.c3.w);
        }

        /// <summary>Returns the Float2 column vector result of a matrix multiplication between a Float2x2 matrix and a Float2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float2X2 a, Float2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Float2x2 matrix result of a matrix multiplication between a Float2x2 matrix and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Mul(Float2X2 a, Float2X2 b)
        {
            return Float2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Float2x3 matrix result of a matrix multiplication between a Float2x2 matrix and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Mul(Float2X2 a, Float2x3 b)
        {
            return Float2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Float2x4 matrix result of a matrix multiplication between a Float2x2 matrix and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Mul(Float2X2 a, Float2x4 b)
        {
            return Float2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Float2 column vector result of a matrix multiplication between a Float2x3 matrix and a Float3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float2x3 a, Float3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Float2x2 matrix result of a matrix multiplication between a Float2x3 matrix and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Mul(Float2x3 a, Float3x2 b)
        {
            return Float2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Float2x3 matrix result of a matrix multiplication between a Float2x3 matrix and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Mul(Float2x3 a, Float3X3 b)
        {
            return Float2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Float2x4 matrix result of a matrix multiplication between a Float2x3 matrix and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Mul(Float2x3 a, Float3x4 b)
        {
            return Float2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Float2 column vector result of a matrix multiplication between a Float2x4 matrix and a Float4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mul(Float2x4 a, Float4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Float2x2 matrix result of a matrix multiplication between a Float2x4 matrix and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Mul(Float2x4 a, Float4x2 b)
        {
            return Float2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Float2x3 matrix result of a matrix multiplication between a Float2x4 matrix and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Mul(Float2x4 a, Float4x3 b)
        {
            return Float2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Float2x4 matrix result of a matrix multiplication between a Float2x4 matrix and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Mul(Float2x4 a, Float4X4 b)
        {
            return Float2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the Float3 column vector result of a matrix multiplication between a Float3x2 matrix and a Float2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float3x2 a, Float2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Float3x2 matrix result of a matrix multiplication between a Float3x2 matrix and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Mul(Float3x2 a, Float2X2 b)
        {
            return Float3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Float3x3 matrix result of a matrix multiplication between a Float3x2 matrix and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Mul(Float3x2 a, Float2x3 b)
        {
            return Float3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Float3x4 matrix result of a matrix multiplication between a Float3x2 matrix and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Mul(Float3x2 a, Float2x4 b)
        {
            return Float3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Float3 column vector result of a matrix multiplication between a Float3x3 matrix and a Float3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float3X3 a, Float3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Float3x2 matrix result of a matrix multiplication between a Float3x3 matrix and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Mul(Float3X3 a, Float3x2 b)
        {
            return Float3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Float3x3 matrix result of a matrix multiplication between a Float3x3 matrix and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Mul(Float3X3 a, Float3X3 b)
        {
            return Float3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Float3x4 matrix result of a matrix multiplication between a Float3x3 matrix and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Mul(Float3X3 a, Float3x4 b)
        {
            return Float3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Float3 column vector result of a matrix multiplication between a Float3x4 matrix and a Float4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Float3x4 a, Float4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Float3x2 matrix result of a matrix multiplication between a Float3x4 matrix and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Mul(Float3x4 a, Float4x2 b)
        {
            return Float3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Float3x3 matrix result of a matrix multiplication between a Float3x4 matrix and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Mul(Float3x4 a, Float4x3 b)
        {
            return Float3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Float3x4 matrix result of a matrix multiplication between a Float3x4 matrix and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Mul(Float3x4 a, Float4X4 b)
        {
            return Float3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the Float4 column vector result of a matrix multiplication between a Float4x2 matrix and a Float2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float4x2 a, Float2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Float4x2 matrix result of a matrix multiplication between a Float4x2 matrix and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Mul(Float4x2 a, Float2X2 b)
        {
            return Float4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Float4x3 matrix result of a matrix multiplication between a Float4x2 matrix and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Mul(Float4x2 a, Float2x3 b)
        {
            return Float4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Float4x4 matrix result of a matrix multiplication between a Float4x2 matrix and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Mul(Float4x2 a, Float2x4 b)
        {
            return Float4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Float4 column vector result of a matrix multiplication between a Float4x3 matrix and a Float3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float4x3 a, Float3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Float4x2 matrix result of a matrix multiplication between a Float4x3 matrix and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Mul(Float4x3 a, Float3x2 b)
        {
            return Float4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Float4x3 matrix result of a matrix multiplication between a Float4x3 matrix and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Mul(Float4x3 a, Float3X3 b)
        {
            return Float4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Float4x4 matrix result of a matrix multiplication between a Float4x3 matrix and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Mul(Float4x3 a, Float3x4 b)
        {
            return Float4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Float4 column vector result of a matrix multiplication between a Float4x4 matrix and a Float4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(Float4X4 a, Float4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Float4x2 matrix result of a matrix multiplication between a Float4x4 matrix and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Mul(Float4X4 a, Float4x2 b)
        {
            return Float4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Float4x3 matrix result of a matrix multiplication between a Float4x4 matrix and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Mul(Float4X4 a, Float4x3 b)
        {
            return Float4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Float4x4 matrix result of a matrix multiplication between a Float4x4 matrix and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Mul(Float4X4 a, Float4X4 b)
        {
            return Float4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the int value result of a matrix multiplication between an int value and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mul(int a, int b)
        {
            return a * b;
        }

        /// <summary>Returns the int value result of a matrix multiplication between an Int2 row vector and an Int2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mul(Int2 a, Int2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>Returns the Int2 row vector result of a matrix multiplication between an Int2 row vector and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int2 a, Int2x2 b)
        {
            return Int2(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y);
        }

        /// <summary>Returns the Int3 row vector result of a matrix multiplication between an Int2 row vector and an Int2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int2 a, Int2x3 b)
        {
            return Int3(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y);
        }

        /// <summary>Returns the Int4 row vector result of a matrix multiplication between an Int2 row vector and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int2 a, Int2x4 b)
        {
            return Int4(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y,
                a.x * b.c3.x + a.y * b.c3.y);
        }

        /// <summary>Returns the int value result of a matrix multiplication between an Int3 row vector and an Int3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mul(Int3 a, Int3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        /// <summary>Returns the Int2 row vector result of a matrix multiplication between an Int3 row vector and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int3 a, Int3x2 b)
        {
            return Int2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z);
        }

        /// <summary>Returns the Int3 row vector result of a matrix multiplication between an Int3 row vector and an Int3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int3 a, Int3x3 b)
        {
            return Int3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z);
        }

        /// <summary>Returns the Int4 row vector result of a matrix multiplication between an Int3 row vector and an Int3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int3 a, Int3x4 b)
        {
            return Int4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z);
        }

        /// <summary>Returns the int value result of a matrix multiplication between an Int4 row vector and an Int4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mul(Int4 a, Int4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        /// <summary>Returns the Int2 row vector result of a matrix multiplication between an Int4 row vector and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int4 a, Int4x2 b)
        {
            return Int2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w);
        }

        /// <summary>Returns the Int3 row vector result of a matrix multiplication between an Int4 row vector and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int4 a, Int4x3 b)
        {
            return Int3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w);
        }

        /// <summary>Returns the Int4 row vector result of a matrix multiplication between an Int4 row vector and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int4 a, Int4x4 b)
        {
            return Int4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z + a.w * b.c3.w);
        }

        /// <summary>Returns the Int2 column vector result of a matrix multiplication between an Int2x2 matrix and an Int2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int2x2 a, Int2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Int2x2 matrix result of a matrix multiplication between an Int2x2 matrix and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Mul(Int2x2 a, Int2x2 b)
        {
            return Int2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Int2x3 matrix result of a matrix multiplication between an Int2x2 matrix and an Int2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x3 Mul(Int2x2 a, Int2x3 b)
        {
            return Int2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Int2x4 matrix result of a matrix multiplication between an Int2x2 matrix and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Mul(Int2x2 a, Int2x4 b)
        {
            return Int2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Int2 column vector result of a matrix multiplication between an Int2x3 matrix and an Int3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int2x3 a, Int3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Int2x2 matrix result of a matrix multiplication between an Int2x3 matrix and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Mul(Int2x3 a, Int3x2 b)
        {
            return Int2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Int2x3 matrix result of a matrix multiplication between an Int2x3 matrix and an Int3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x3 Mul(Int2x3 a, Int3x3 b)
        {
            return Int2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Int2x4 matrix result of a matrix multiplication between an Int2x3 matrix and an Int3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Mul(Int2x3 a, Int3x4 b)
        {
            return Int2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Int2 column vector result of a matrix multiplication between an Int2x4 matrix and an Int4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mul(Int2x4 a, Int4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Int2x2 matrix result of a matrix multiplication between an Int2x4 matrix and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Mul(Int2x4 a, Int4x2 b)
        {
            return Int2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Int2x3 matrix result of a matrix multiplication between an Int2x4 matrix and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x3 Mul(Int2x4 a, Int4x3 b)
        {
            return Int2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Int2x4 matrix result of a matrix multiplication between an Int2x4 matrix and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Mul(Int2x4 a, Int4x4 b)
        {
            return Int2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the Int3 column vector result of a matrix multiplication between an Int3x2 matrix and an Int2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int3x2 a, Int2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Int3x2 matrix result of a matrix multiplication between an Int3x2 matrix and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Mul(Int3x2 a, Int2x2 b)
        {
            return Int3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Int3x3 matrix result of a matrix multiplication between an Int3x2 matrix and an Int2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x3 Mul(Int3x2 a, Int2x3 b)
        {
            return Int3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Int3x4 matrix result of a matrix multiplication between an Int3x2 matrix and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x4 Mul(Int3x2 a, Int2x4 b)
        {
            return Int3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Int3 column vector result of a matrix multiplication between an Int3x3 matrix and an Int3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int3x3 a, Int3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Int3x2 matrix result of a matrix multiplication between an Int3x3 matrix and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Mul(Int3x3 a, Int3x2 b)
        {
            return Int3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Int3x3 matrix result of a matrix multiplication between an Int3x3 matrix and an Int3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x3 Mul(Int3x3 a, Int3x3 b)
        {
            return Int3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Int3x4 matrix result of a matrix multiplication between an Int3x3 matrix and an Int3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x4 Mul(Int3x3 a, Int3x4 b)
        {
            return Int3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Int3 column vector result of a matrix multiplication between an Int3x4 matrix and an Int4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mul(Int3x4 a, Int4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Int3x2 matrix result of a matrix multiplication between an Int3x4 matrix and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Mul(Int3x4 a, Int4x2 b)
        {
            return Int3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Int3x3 matrix result of a matrix multiplication between an Int3x4 matrix and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x3 Mul(Int3x4 a, Int4x3 b)
        {
            return Int3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Int3x4 matrix result of a matrix multiplication between an Int3x4 matrix and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x4 Mul(Int3x4 a, Int4x4 b)
        {
            return Int3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the Int4 column vector result of a matrix multiplication between an Int4x2 matrix and an Int2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int4x2 a, Int2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the Int4x2 matrix result of a matrix multiplication between an Int4x2 matrix and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Mul(Int4x2 a, Int2x2 b)
        {
            return Int4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the Int4x3 matrix result of a matrix multiplication between an Int4x2 matrix and an Int2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Mul(Int4x2 a, Int2x3 b)
        {
            return Int4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the Int4x4 matrix result of a matrix multiplication between an Int4x2 matrix and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Mul(Int4x2 a, Int2x4 b)
        {
            return Int4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the Int4 column vector result of a matrix multiplication between an Int4x3 matrix and an Int3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int4x3 a, Int3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the Int4x2 matrix result of a matrix multiplication between an Int4x3 matrix and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Mul(Int4x3 a, Int3x2 b)
        {
            return Int4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the Int4x3 matrix result of a matrix multiplication between an Int4x3 matrix and an Int3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Mul(Int4x3 a, Int3x3 b)
        {
            return Int4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the Int4x4 matrix result of a matrix multiplication between an Int4x3 matrix and an Int3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Mul(Int4x3 a, Int3x4 b)
        {
            return Int4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the Int4 column vector result of a matrix multiplication between an Int4x4 matrix and an Int4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mul(Int4x4 a, Int4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the Int4x2 matrix result of a matrix multiplication between an Int4x4 matrix and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Mul(Int4x4 a, Int4x2 b)
        {
            return Int4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the Int4x3 matrix result of a matrix multiplication between an Int4x4 matrix and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Mul(Int4x4 a, Int4x3 b)
        {
            return Int4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the Int4x4 matrix result of a matrix multiplication between an Int4x4 matrix and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Mul(Int4x4 a, Int4x4 b)
        {
            return Int4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the uint value result of a matrix multiplication between a uint value and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Mul(uint a, uint b)
        {
            return a * b;
        }

        /// <summary>Returns the uint value result of a matrix multiplication between a UInt2 row vector and a UInt2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Mul(UInt2 a, UInt2 b)
        {
            return a.x * b.x + a.y * b.y;
        }

        /// <summary>Returns the UInt2 row vector result of a matrix multiplication between a UInt2 row vector and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt2 a, UInt2x2 b)
        {
            return UInt2(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y);
        }

        /// <summary>Returns the UInt3 row vector result of a matrix multiplication between a UInt2 row vector and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt2 a, UInt2x3 b)
        {
            return UInt3(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y);
        }

        /// <summary>Returns the UInt4 row vector result of a matrix multiplication between a UInt2 row vector and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt2 a, UInt2x4 b)
        {
            return UInt4(
                a.x * b.c0.x + a.y * b.c0.y,
                a.x * b.c1.x + a.y * b.c1.y,
                a.x * b.c2.x + a.y * b.c2.y,
                a.x * b.c3.x + a.y * b.c3.y);
        }

        /// <summary>Returns the uint value result of a matrix multiplication between a UInt3 row vector and a UInt3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Mul(UInt3 a, UInt3 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

        /// <summary>Returns the UInt2 row vector result of a matrix multiplication between a UInt3 row vector and a UInt3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt3 a, UInt3x2 b)
        {
            return UInt2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z);
        }

        /// <summary>Returns the UInt3 row vector result of a matrix multiplication between a UInt3 row vector and a UInt3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt3 a, UInt3x3 b)
        {
            return UInt3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z);
        }

        /// <summary>Returns the UInt4 row vector result of a matrix multiplication between a UInt3 row vector and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt3 a, UInt3x4 b)
        {
            return UInt4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z);
        }

        /// <summary>Returns the uint value result of a matrix multiplication between a UInt4 row vector and a UInt4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Mul(UInt4 a, UInt4 b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z + a.w * b.w;
        }

        /// <summary>Returns the UInt2 row vector result of a matrix multiplication between a UInt4 row vector and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt4 a, UInt4x2 b)
        {
            return UInt2(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w);
        }

        /// <summary>Returns the UInt3 row vector result of a matrix multiplication between a UInt4 row vector and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt4 a, UInt4x3 b)
        {
            return UInt3(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w);
        }

        /// <summary>Returns the UInt4 row vector result of a matrix multiplication between a UInt4 row vector and a UInt4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt4 a, UInt4x4 b)
        {
            return UInt4(
                a.x * b.c0.x + a.y * b.c0.y + a.z * b.c0.z + a.w * b.c0.w,
                a.x * b.c1.x + a.y * b.c1.y + a.z * b.c1.z + a.w * b.c1.w,
                a.x * b.c2.x + a.y * b.c2.y + a.z * b.c2.z + a.w * b.c2.w,
                a.x * b.c3.x + a.y * b.c3.y + a.z * b.c3.z + a.w * b.c3.w);
        }

        /// <summary>Returns the UInt2 column vector result of a matrix multiplication between a UInt2x2 matrix and a UInt2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt2x2 a, UInt2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the UInt2x2 matrix result of a matrix multiplication between a UInt2x2 matrix and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 Mul(UInt2x2 a, UInt2x2 b)
        {
            return UInt2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the UInt2x3 matrix result of a matrix multiplication between a UInt2x2 matrix and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 Mul(UInt2x2 a, UInt2x3 b)
        {
            return UInt2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the UInt2x4 matrix result of a matrix multiplication between a UInt2x2 matrix and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 Mul(UInt2x2 a, UInt2x4 b)
        {
            return UInt2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the UInt2 column vector result of a matrix multiplication between a UInt2x3 matrix and a UInt3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt2x3 a, UInt3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the UInt2x2 matrix result of a matrix multiplication between a UInt2x3 matrix and a UInt3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 Mul(UInt2x3 a, UInt3x2 b)
        {
            return UInt2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the UInt2x3 matrix result of a matrix multiplication between a UInt2x3 matrix and a UInt3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 Mul(UInt2x3 a, UInt3x3 b)
        {
            return UInt2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the UInt2x4 matrix result of a matrix multiplication between a UInt2x3 matrix and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 Mul(UInt2x3 a, UInt3x4 b)
        {
            return UInt2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the UInt2 column vector result of a matrix multiplication between a UInt2x4 matrix and a UInt4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mul(UInt2x4 a, UInt4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the UInt2x2 matrix result of a matrix multiplication between a UInt2x4 matrix and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 Mul(UInt2x4 a, UInt4x2 b)
        {
            return UInt2x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the UInt2x3 matrix result of a matrix multiplication between a UInt2x4 matrix and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 Mul(UInt2x4 a, UInt4x3 b)
        {
            return UInt2x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the UInt2x4 matrix result of a matrix multiplication between a UInt2x4 matrix and a UInt4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 Mul(UInt2x4 a, UInt4x4 b)
        {
            return UInt2x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the UInt3 column vector result of a matrix multiplication between a UInt3x2 matrix and a UInt2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt3x2 a, UInt2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the UInt3x2 matrix result of a matrix multiplication between a UInt3x2 matrix and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x2 Mul(UInt3x2 a, UInt2x2 b)
        {
            return UInt3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the UInt3x3 matrix result of a matrix multiplication between a UInt3x2 matrix and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x3 Mul(UInt3x2 a, UInt2x3 b)
        {
            return UInt3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the UInt3x4 matrix result of a matrix multiplication between a UInt3x2 matrix and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 Mul(UInt3x2 a, UInt2x4 b)
        {
            return UInt3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the UInt3 column vector result of a matrix multiplication between a UInt3x3 matrix and a UInt3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt3x3 a, UInt3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the UInt3x2 matrix result of a matrix multiplication between a UInt3x3 matrix and a UInt3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x2 Mul(UInt3x3 a, UInt3x2 b)
        {
            return UInt3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the UInt3x3 matrix result of a matrix multiplication between a UInt3x3 matrix and a UInt3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x3 Mul(UInt3x3 a, UInt3x3 b)
        {
            return UInt3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the UInt3x4 matrix result of a matrix multiplication between a UInt3x3 matrix and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 Mul(UInt3x3 a, UInt3x4 b)
        {
            return UInt3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the UInt3 column vector result of a matrix multiplication between a UInt3x4 matrix and a UInt4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mul(UInt3x4 a, UInt4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the UInt3x2 matrix result of a matrix multiplication between a UInt3x4 matrix and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x2 Mul(UInt3x4 a, UInt4x2 b)
        {
            return UInt3x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the UInt3x3 matrix result of a matrix multiplication between a UInt3x4 matrix and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x3 Mul(UInt3x4 a, UInt4x3 b)
        {
            return UInt3x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the UInt3x4 matrix result of a matrix multiplication between a UInt3x4 matrix and a UInt4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 Mul(UInt3x4 a, UInt4x4 b)
        {
            return UInt3x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }

        /// <summary>Returns the UInt4 column vector result of a matrix multiplication between a UInt4x2 matrix and a UInt2 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt4x2 a, UInt2 b)
        {
            return a.c0 * b.x + a.c1 * b.y;
        }

        /// <summary>Returns the UInt4x2 matrix result of a matrix multiplication between a UInt4x2 matrix and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 Mul(UInt4x2 a, UInt2x2 b)
        {
            return UInt4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y);
        }

        /// <summary>Returns the UInt4x3 matrix result of a matrix multiplication between a UInt4x2 matrix and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 Mul(UInt4x2 a, UInt2x3 b)
        {
            return UInt4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y);
        }

        /// <summary>Returns the UInt4x4 matrix result of a matrix multiplication between a UInt4x2 matrix and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x4 Mul(UInt4x2 a, UInt2x4 b)
        {
            return UInt4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y,
                a.c0 * b.c1.x + a.c1 * b.c1.y,
                a.c0 * b.c2.x + a.c1 * b.c2.y,
                a.c0 * b.c3.x + a.c1 * b.c3.y);
        }

        /// <summary>Returns the UInt4 column vector result of a matrix multiplication between a UInt4x3 matrix and a UInt3 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt4x3 a, UInt3 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z;
        }

        /// <summary>Returns the UInt4x2 matrix result of a matrix multiplication between a UInt4x3 matrix and a UInt3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 Mul(UInt4x3 a, UInt3x2 b)
        {
            return UInt4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z);
        }

        /// <summary>Returns the UInt4x3 matrix result of a matrix multiplication between a UInt4x3 matrix and a UInt3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 Mul(UInt4x3 a, UInt3x3 b)
        {
            return UInt4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z);
        }

        /// <summary>Returns the UInt4x4 matrix result of a matrix multiplication between a UInt4x3 matrix and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x4 Mul(UInt4x3 a, UInt3x4 b)
        {
            return UInt4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z);
        }

        /// <summary>Returns the UInt4 column vector result of a matrix multiplication between a UInt4x4 matrix and a UInt4 column vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mul(UInt4x4 a, UInt4 b)
        {
            return a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3 * b.w;
        }

        /// <summary>Returns the UInt4x2 matrix result of a matrix multiplication between a UInt4x4 matrix and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 Mul(UInt4x4 a, UInt4x2 b)
        {
            return UInt4x2(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w);
        }

        /// <summary>Returns the UInt4x3 matrix result of a matrix multiplication between a UInt4x4 matrix and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 Mul(UInt4x4 a, UInt4x3 b)
        {
            return UInt4x3(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w);
        }

        /// <summary>Returns the UInt4x4 matrix result of a matrix multiplication between a UInt4x4 matrix and a UInt4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x4 Mul(UInt4x4 a, UInt4x4 b)
        {
            return UInt4x4(
                a.c0 * b.c0.x + a.c1 * b.c0.y + a.c2 * b.c0.z + a.c3 * b.c0.w,
                a.c0 * b.c1.x + a.c1 * b.c1.y + a.c2 * b.c1.z + a.c3 * b.c1.w,
                a.c0 * b.c2.x + a.c1 * b.c2.y + a.c2 * b.c2.z + a.c3 * b.c2.w,
                a.c0 * b.c3.x + a.c1 * b.c3.y + a.c2 * b.c3.z + a.c3 * b.c3.w);
        }
    }
}
