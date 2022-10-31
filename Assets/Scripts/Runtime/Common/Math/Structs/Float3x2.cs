
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Float3x2 : IEquatable<Float3x2>, IFormattable
    {
        public Float3 c0;
        public Float3 c1;

        /// <summary>Float3x2 zero value.</summary>
        public static readonly Float3x2 zero;

        /// <summary>Constructs a Float3x2 matrix from two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(Float3 c0, Float3 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Float3x2 matrix from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(SoftFloat m00, SoftFloat m01,
                        SoftFloat m10, SoftFloat m11,
                        SoftFloat m20, SoftFloat m21)
        {
            c0 = new Float3(m00, m10, m20);
            c1 = new Float3(m01, m11, m21);
        }

        /// <summary>Constructs a Float3x2 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(SoftFloat v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float3x2 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(bool v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float3x2 matrix from a Bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(Bool3x2 v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c1);
        }

        /// <summary>Constructs a Float3x2 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float3x2 matrix from a Int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(Int3x2 v)
        {
            c0 = v.c0;
            c1 = v.c1;
        }

        /// <summary>Constructs a Float3x2 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(uint v)
        {
            c0 = (SoftFloat)(int)v;
            c1 = (SoftFloat)(int)v;
        }

        /// <summary>Constructs a Float3x2 matrix from a UInt3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x2(UInt3x2 v)
        {
            c0 = new Float3(v.c0);
            c1 = new Float3(v.c1);
        }


        /// <summary>Implicitly converts a single float value to a Float3x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x2(SoftFloat v) { return new Float3x2(v); }

        /// <summary>Explicitly converts a single bool value to a Float3x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3x2(bool v) { return new Float3x2(v); }

        /// <summary>Explicitly converts a Bool3x2 matrix to a Float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3x2(Bool3x2 v) { return new Float3x2(v); }

        /// <summary>Implicitly converts a single int value to a Float3x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x2(int v) { return new Float3x2(v); }

        /// <summary>Implicitly converts a Int3x2 matrix to a Float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x2(Int3x2 v) { return new Float3x2(v); }

        /// <summary>Implicitly converts a single uint value to a Float3x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x2(uint v) { return new Float3x2(v); }

        /// <summary>Implicitly converts a UInt3x2 matrix to a Float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x2(UInt3x2 v) { return new Float3x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator * (Float3x2 lhs, Float3x2 rhs) { return new Float3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator * (Float3x2 lhs, SoftFloat rhs) { return new Float3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator * (SoftFloat lhs, Float3x2 rhs) { return new Float3x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator + (Float3x2 lhs, Float3x2 rhs) { return new Float3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator + (Float3x2 lhs, SoftFloat rhs) { return new Float3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator + (SoftFloat lhs, Float3x2 rhs) { return new Float3x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator - (Float3x2 lhs, Float3x2 rhs) { return new Float3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator - (Float3x2 lhs, SoftFloat rhs) { return new Float3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator - (SoftFloat lhs, Float3x2 rhs) { return new Float3x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator / (Float3x2 lhs, Float3x2 rhs) { return new Float3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator / (Float3x2 lhs, SoftFloat rhs) { return new Float3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator / (SoftFloat lhs, Float3x2 rhs) { return new Float3x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator % (Float3x2 lhs, Float3x2 rhs) { return new Float3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator % (Float3x2 lhs, SoftFloat rhs) { return new Float3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator % (SoftFloat lhs, Float3x2 rhs) { return new Float3x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 operator - (Float3x2 val) { return new Float3x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (Float3x2 lhs, Float3x2 rhs) { return new Bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float3x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (Float3x2 lhs, SoftFloat rhs) { return new Bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (SoftFloat lhs, Float3x2 rhs) { return new Bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the Float3 element at a specified index.</summary>
        unsafe public ref Float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Float3x2* array = &this) { return ref ((Float3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float3x2 is equal to a given Float3x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Float3x2 is equal to a given Float3x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float3x2)o); }


        /// <summary>Returns a hash code for the Float3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        /// <summary>Returns a string representation of the Float3x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float3x2({0}f, {1}f,  {2}f, {3}f,  {4}f, {5}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float3x2 matrix constructed from two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(Float3 c0, Float3 c1) { return new Float3x2(c0, c1); }

        /// <summary>Returns a Float3x2 matrix constructed from from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(SoftFloat m00, SoftFloat m01,
                                        SoftFloat m10, SoftFloat m11,
                                        SoftFloat m20, SoftFloat m21)
        {
            return new Float3x2(m00, m01,
                                m10, m11,
                                m20, m21);
        }

        /// <summary>Returns a Float3x2 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(SoftFloat v) { return new Float3x2(v); }

        /// <summary>Returns a Float3x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(bool v) { return new Float3x2(v); }

        /// <summary>Return a Float3x2 matrix constructed from a Bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(Bool3x2 v) { return new Float3x2(v); }

        /// <summary>Returns a Float3x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(int v) { return new Float3x2(v); }

        /// <summary>Return a Float3x2 matrix constructed from a Int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(Int3x2 v) { return new Float3x2(v); }

        /// <summary>Returns a Float3x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(uint v) { return new Float3x2(v); }

        /// <summary>Return a Float3x2 matrix constructed from a UInt3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Float3x2(UInt3x2 v) { return new Float3x2(v); }

        /// <summary>Return the Float2x3 transpose of a Float3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Transpose(Float3x2 v)
        {
            return Float2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a Float3x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float3x2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt3(0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u) +
                        AsUInt(v.c1) * UInt3(0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u)) + 0xEF63C699u;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Float3x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Float3x2 v)
        {
            return (AsUInt(v.c0) * UInt3(0x9001903Fu, 0xA895B9CDu, 0x9D23B201u) +
                    AsUInt(v.c1) * UInt3(0x4B01D3E1u, 0x7461CA0Du, 0x79725379u)) + 0xD6258E5Bu;
        }

    }
}
