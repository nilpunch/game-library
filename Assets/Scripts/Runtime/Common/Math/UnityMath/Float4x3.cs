
using System;
using System.Runtime.CompilerServices;
using GameLibrary.Math;

#pragma warning disable 0660, 0661

namespace GameLibrary.UnityMath
{
    [Serializable]
    public struct Float4x3 : IEquatable<Float4x3>, IFormattable
    {
        public Float4 c0;
        public Float4 c1;
        public Float4 c2;

        /// <summary>Float4x3 zero value.</summary>
        public static readonly Float4x3 zero;

        /// <summary>Constructs a Float4x3 matrix from three Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(Float4 c0, Float4 c1, Float4 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Float4x3 matrix from 12 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
                        SoftFloat m10, SoftFloat m11, SoftFloat m12,
                        SoftFloat m20, SoftFloat m21, SoftFloat m22,
                        SoftFloat m30, SoftFloat m31, SoftFloat m32)
        {
            c0 = new Float4(m00, m10, m20, m30);
            c1 = new Float4(m01, m11, m21, m31);
            c2 = new Float4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a Float4x3 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float4x3 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(bool v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c2 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float4x3 matrix from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(Bool4x3 v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c2);
        }

        /// <summary>Constructs a Float4x3 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float4x3 matrix from a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(Int4x3 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
        }

        /// <summary>Constructs a Float4x3 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float4x3 matrix from a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x3(UInt4x3 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
        }


        /// <summary>Implicitly converts a single float value to a Float4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x3(SoftFloat v) { return new Float4x3(v); }

        /// <summary>Explicitly converts a single bool value to a Float4x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4x3(bool v) { return new Float4x3(v); }

        /// <summary>Explicitly converts a Bool4x3 matrix to a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4x3(Bool4x3 v) { return new Float4x3(v); }

        /// <summary>Implicitly converts a single int value to a Float4x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x3(int v) { return new Float4x3(v); }

        /// <summary>Implicitly converts a Int4x3 matrix to a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x3(Int4x3 v) { return new Float4x3(v); }

        /// <summary>Implicitly converts a single uint value to a Float4x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x3(uint v) { return new Float4x3(v); }

        /// <summary>Implicitly converts a UInt4x3 matrix to a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x3(UInt4x3 v) { return new Float4x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator * (Float4x3 lhs, Float4x3 rhs) { return new Float4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator * (Float4x3 lhs, SoftFloat rhs) { return new Float4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator * (SoftFloat lhs, Float4x3 rhs) { return new Float4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator + (Float4x3 lhs, Float4x3 rhs) { return new Float4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator + (Float4x3 lhs, SoftFloat rhs) { return new Float4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator + (SoftFloat lhs, Float4x3 rhs) { return new Float4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator - (Float4x3 lhs, Float4x3 rhs) { return new Float4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator - (Float4x3 lhs, SoftFloat rhs) { return new Float4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator - (SoftFloat lhs, Float4x3 rhs) { return new Float4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator / (Float4x3 lhs, Float4x3 rhs) { return new Float4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator / (Float4x3 lhs, SoftFloat rhs) { return new Float4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator / (SoftFloat lhs, Float4x3 rhs) { return new Float4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator % (Float4x3 lhs, Float4x3 rhs) { return new Float4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator % (Float4x3 lhs, SoftFloat rhs) { return new Float4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator % (SoftFloat lhs, Float4x3 rhs) { return new Float4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 operator - (Float4x3 val) { return new Float4x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise equality operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Float4x3 lhs, Float4x3 rhs) { return new Bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float4x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Float4x3 lhs, SoftFloat rhs) { return new Bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (SoftFloat lhs, Float4x3 rhs) { return new Bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }



        /// <summary>Returns the Float4 element at a specified index.</summary>
        unsafe public ref Float4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (Float4x3* array = &this) { return ref ((Float4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float4x3 is equal to a given Float4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the Float4x3 is equal to a given Float4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float4x3)o); }


        /// <summary>Returns a hash code for the Float4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float4x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f,  {9}f, {10}f, {11}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        /// <summary>Returns a string representation of the Float4x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float4x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f,  {9}f, {10}f, {11}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float4x3 matrix constructed from three Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(Float4 c0, Float4 c1, Float4 c2) { return new Float4x3(c0, c1, c2); }

        /// <summary>Returns a Float4x3 matrix constructed from from 12 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
                                        SoftFloat m10, SoftFloat m11, SoftFloat m12,
                                        SoftFloat m20, SoftFloat m21, SoftFloat m22,
                                        SoftFloat m30, SoftFloat m31, SoftFloat m32)
        {
            return new Float4x3(m00, m01, m02,
                                m10, m11, m12,
                                m20, m21, m22,
                                m30, m31, m32);
        }

        /// <summary>Returns a Float4x3 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(SoftFloat v) { return new Float4x3(v); }

        /// <summary>Returns a Float4x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(bool v) { return new Float4x3(v); }

        /// <summary>Return a Float4x3 matrix constructed from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(Bool4x3 v) { return new Float4x3(v); }

        /// <summary>Returns a Float4x3 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(int v) { return new Float4x3(v); }

        /// <summary>Return a Float4x3 matrix constructed from a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(Int4x3 v) { return new Float4x3(v); }

        /// <summary>Returns a Float4x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(uint v) { return new Float4x3(v); }

        /// <summary>Return a Float4x3 matrix constructed from a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x3 Float4x3(UInt4x3 v) { return new Float4x3(v); }

        /// <summary>Return the Float3x4 transpose of a Float4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Transpose(Float4x3 v)
        {
            return Float3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a Float4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float4x3 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0xC53F4755u, 0x6985C229u, 0xE133B0B3u, 0xC3E0A3B9u) +
                        AsUInt(v.c1) * UInt4(0xFE31134Fu, 0x712A34D7u, 0x9D77A59Bu, 0x4942CA39u) +
                        AsUInt(v.c2) * UInt4(0xB40EC62Du, 0x565ED63Fu, 0x93C30C2Bu, 0xDCAF0351u)) + 0x6E050B01u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Float4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Float4x3 v)
        {
            return (AsUInt(v.c0) * UInt4(0x750FDBF5u, 0x7F3DD499u, 0x52EAAEBBu, 0x4599C793u) +
                    AsUInt(v.c1) * UInt4(0x83B5E729u, 0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u) +
                    AsUInt(v.c2) * UInt4(0x822A7D6Du, 0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu)) + 0xE16BC89Du;
        }

    }
}
