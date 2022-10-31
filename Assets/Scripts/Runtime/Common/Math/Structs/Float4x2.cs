
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Float4x2 : IEquatable<Float4x2>, IFormattable
    {
        public Float4 c0;
        public Float4 c1;

        /// <summary>Float4x2 zero value.</summary>
        public static readonly Float4x2 zero;

        /// <summary>Constructs a Float4x2 matrix from two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(Float4 c0, Float4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Float4x2 matrix from 8 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(SoftFloat m00, SoftFloat m01,
                        SoftFloat m10, SoftFloat m11,
                        SoftFloat m20, SoftFloat m21,
                        SoftFloat m30, SoftFloat m31)
        {
            c0 = new Float4(m00, m10, m20, m30);
            c1 = new Float4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a Float4x2 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(SoftFloat v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float4x2 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(bool v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float4x2 matrix from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(Bool4x2 v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c1);
        }

        /// <summary>Constructs a Float4x2 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float4x2 matrix from a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(Int4x2 v)
        {
            c0 = v.c0;
            c1 = v.c1;
        }

        /// <summary>Constructs a Float4x2 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(uint v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float4x2 matrix from a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4x2(UInt4x2 v)
        {
            c0 = v.c0;
            c1 = v.c1;
        }


        /// <summary>Implicitly converts a single float value to a Float4x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x2(SoftFloat v) { return new Float4x2(v); }

        /// <summary>Explicitly converts a single bool value to a Float4x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4x2(bool v) { return new Float4x2(v); }

        /// <summary>Explicitly converts a Bool4x2 matrix to a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4x2(Bool4x2 v) { return new Float4x2(v); }

        /// <summary>Implicitly converts a single int value to a Float4x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x2(int v) { return new Float4x2(v); }

        /// <summary>Implicitly converts a Int4x2 matrix to a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x2(Int4x2 v) { return new Float4x2(v); }

        /// <summary>Implicitly converts a single uint value to a Float4x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x2(uint v) { return new Float4x2(v); }

        /// <summary>Implicitly converts a UInt4x2 matrix to a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4x2(UInt4x2 v) { return new Float4x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator * (Float4x2 lhs, Float4x2 rhs) { return new Float4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator * (Float4x2 lhs, SoftFloat rhs) { return new Float4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator * (SoftFloat lhs, Float4x2 rhs) { return new Float4x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator + (Float4x2 lhs, Float4x2 rhs) { return new Float4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator + (Float4x2 lhs, SoftFloat rhs) { return new Float4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator + (SoftFloat lhs, Float4x2 rhs) { return new Float4x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator - (Float4x2 lhs, Float4x2 rhs) { return new Float4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator - (Float4x2 lhs, SoftFloat rhs) { return new Float4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator - (SoftFloat lhs, Float4x2 rhs) { return new Float4x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator / (Float4x2 lhs, Float4x2 rhs) { return new Float4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator / (Float4x2 lhs, SoftFloat rhs) { return new Float4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator / (SoftFloat lhs, Float4x2 rhs) { return new Float4x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator % (Float4x2 lhs, Float4x2 rhs) { return new Float4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator % (Float4x2 lhs, SoftFloat rhs) { return new Float4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator % (SoftFloat lhs, Float4x2 rhs) { return new Float4x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 operator - (Float4x2 val) { return new Float4x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (Float4x2 lhs, Float4x2 rhs) { return new Bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float4x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (Float4x2 lhs, SoftFloat rhs) { return new Bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (SoftFloat lhs, Float4x2 rhs) { return new Bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the Float4 element at a specified index.</summary>
        unsafe public ref Float4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Float4x2* array = &this) { return ref ((Float4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float4x2 is equal to a given Float4x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Float4x2 is equal to a given Float4x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float4x2)o); }


        /// <summary>Returns a hash code for the Float4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float4x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f,  {6}f, {7}f)", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        /// <summary>Returns a string representation of the Float4x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float4x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f,  {6}f, {7}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float4x2 matrix constructed from two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(Float4 c0, Float4 c1) { return new Float4x2(c0, c1); }

        /// <summary>Returns a Float4x2 matrix constructed from from 8 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(SoftFloat m00, SoftFloat m01,
                                        SoftFloat m10, SoftFloat m11,
                                        SoftFloat m20, SoftFloat m21,
                                        SoftFloat m30, SoftFloat m31)
        {
            return new Float4x2(m00, m01,
                                m10, m11,
                                m20, m21,
                                m30, m31);
        }

        /// <summary>Returns a Float4x2 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(SoftFloat v) { return new Float4x2(v); }

        /// <summary>Returns a Float4x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(bool v) { return new Float4x2(v); }

        /// <summary>Return a Float4x2 matrix constructed from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(Bool4x2 v) { return new Float4x2(v); }

        /// <summary>Returns a Float4x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(int v) { return new Float4x2(v); }

        /// <summary>Return a Float4x2 matrix constructed from a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(Int4x2 v) { return new Float4x2(v); }

        /// <summary>Returns a Float4x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(uint v) { return new Float4x2(v); }

        /// <summary>Return a Float4x2 matrix constructed from a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Float4x2(UInt4x2 v) { return new Float4x2(v); }

        /// <summary>Return the Float2x4 transpose of a Float4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Transpose(Float4x2 v)
        {
            return Float2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a Float4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float4x2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du, 0x614DA60Du) +
                        AsUInt(v.c1) * UInt4(0x5BA2C50Bu, 0x8C455ACBu, 0xCD266C89u, 0xF1852A33u)) + 0x77E35E77u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Float4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Float4x2 v)
        {
            return (AsUInt(v.c0) * UInt4(0x863E3729u, 0xE191B035u, 0x68586FAFu, 0xD4DFF6D3u) +
                    AsUInt(v.c1) * UInt4(0xCB634F4Du, 0x9B13B92Du, 0x4ABF0813u, 0x86068063u)) + 0xD75513F9u;
        }

    }
}
