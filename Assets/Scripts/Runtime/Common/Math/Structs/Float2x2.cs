
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public partial struct Float2X2 : IEquatable<Float2X2>, IFormattable
    {
        public Float2 c0;
        public Float2 c1;

        /// <summary>Float2x2 identity transform.</summary>
        public static readonly Float2X2 identity = new Float2X2(SoftFloat.One, SoftFloat.Zero,   SoftFloat.Zero, SoftFloat.One);

        /// <summary>Float2x2 zero value.</summary>
        public static readonly Float2X2 zero;

        /// <summary>Constructs a Float2x2 matrix from two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(Float2 c0, Float2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Float2x2 matrix from 4 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(SoftFloat m00, SoftFloat m01,
                        SoftFloat m10, SoftFloat m11)
        {
            c0 = new Float2(m00, m10);
            c1 = new Float2(m01, m11);
        }

        /// <summary>Constructs a Float2x2 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(SoftFloat v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float2x2 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(bool v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float2x2 matrix from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(Bool2x2 v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c1);
        }

        /// <summary>Constructs a Float2x2 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float2x2 matrix from a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(Int2x2 v)
        {
            c0 = v.c0;
            c1 = v.c1;
        }

        /// <summary>Constructs a Float2x2 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(uint v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Float2x2 matrix from a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2X2(UInt2x2 v)
        {
            c0 = v.c0;
            c1 = v.c1;
        }


        /// <summary>Implicitly converts a single float value to a Float2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2X2(SoftFloat v) { return new Float2X2(v); }

        /// <summary>Explicitly converts a single bool value to a Float2x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2X2(bool v) { return new Float2X2(v); }

        /// <summary>Explicitly converts a Bool2x2 matrix to a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2X2(Bool2x2 v) { return new Float2X2(v); }

        /// <summary>Implicitly converts a single int value to a Float2x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2X2(int v) { return new Float2X2(v); }

        /// <summary>Implicitly converts a Int2x2 matrix to a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2X2(Int2x2 v) { return new Float2X2(v); }

        /// <summary>Implicitly converts a single uint value to a Float2x2 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2X2(uint v) { return new Float2X2(v); }

        /// <summary>Implicitly converts a UInt2x2 matrix to a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2X2(UInt2x2 v) { return new Float2X2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator * (Float2X2 lhs, Float2X2 rhs) { return new Float2X2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator * (Float2X2 lhs, SoftFloat rhs) { return new Float2X2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator * (SoftFloat lhs, Float2X2 rhs) { return new Float2X2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator + (Float2X2 lhs, Float2X2 rhs) { return new Float2X2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator + (Float2X2 lhs, SoftFloat rhs) { return new Float2X2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator + (SoftFloat lhs, Float2X2 rhs) { return new Float2X2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator - (Float2X2 lhs, Float2X2 rhs) { return new Float2X2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator - (Float2X2 lhs, SoftFloat rhs) { return new Float2X2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator - (SoftFloat lhs, Float2X2 rhs) { return new Float2X2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator / (Float2X2 lhs, Float2X2 rhs) { return new Float2X2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator / (Float2X2 lhs, SoftFloat rhs) { return new Float2X2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator / (SoftFloat lhs, Float2X2 rhs) { return new Float2X2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator % (Float2X2 lhs, Float2X2 rhs) { return new Float2X2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator % (Float2X2 lhs, SoftFloat rhs) { return new Float2X2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator % (SoftFloat lhs, Float2X2 rhs) { return new Float2X2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 operator - (Float2X2 val) { return new Float2X2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise equality operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (Float2X2 lhs, Float2X2 rhs) { return new Bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float2x2 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (Float2X2 lhs, SoftFloat rhs) { return new Bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (SoftFloat lhs, Float2X2 rhs) { return new Bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }



        /// <summary>Returns the Float2 element at a specified index.</summary>
        unsafe public ref Float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Float2X2* array = &this) { return ref ((Float2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float2x2 is equal to a given Float2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float2X2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Float2x2 is equal to a given Float2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float2X2)o); }


        /// <summary>Returns a hash code for the Float2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float2x2({0}f, {1}f,  {2}f, {3}f)", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the Float2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float2x2({0}f, {1}f,  {2}f, {3}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float2x2 matrix constructed from two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(Float2 c0, Float2 c1) { return new Float2X2(c0, c1); }

        /// <summary>Returns a Float2x2 matrix constructed from from 4 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(SoftFloat m00, SoftFloat m01,
                                        SoftFloat m10, SoftFloat m11)
        {
            return new Float2X2(m00, m01,
                                m10, m11);
        }

        /// <summary>Returns a Float2x2 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(SoftFloat v) { return new Float2X2(v); }

        /// <summary>Returns a Float2x2 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(bool v) { return new Float2X2(v); }

        /// <summary>Return a Float2x2 matrix constructed from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(Bool2x2 v) { return new Float2X2(v); }

        /// <summary>Returns a Float2x2 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(int v) { return new Float2X2(v); }

        /// <summary>Return a Float2x2 matrix constructed from a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(Int2x2 v) { return new Float2X2(v); }

        /// <summary>Returns a Float2x2 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(uint v) { return new Float2X2(v); }

        /// <summary>Return a Float2x2 matrix constructed from a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Float2x2(UInt2x2 v) { return new Float2X2(v); }

        /// <summary>Return the Float2x2 transpose of a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Transpose(Float2X2 v)
        {
            return Float2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns the Float2x2 full inverse of a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Inverse(Float2X2 m)
        {
            SoftFloat a = m.c0.x;
            SoftFloat b = m.c1.x;
            SoftFloat c = m.c0.y;
            SoftFloat d = m.c1.y;

            SoftFloat det = a * d - b * c;

            return Float2x2(d, -b, -c, a) * (SoftFloat.One / det);
        }

        /// <summary>Returns the determinant of a Float2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Determinant(Float2X2 m)
        {
            SoftFloat a = m.c0.x;
            SoftFloat b = m.c1.x;
            SoftFloat c = m.c0.y;
            SoftFloat d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a Float2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float2X2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt2(0x9C9F0823u, 0x5A9CA13Bu) +
                        AsUInt(v.c1) * UInt2(0xAFCDD5EFu, 0xA88D187Du)) + 0xCF6EBA1Du;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Float2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Float2X2 v)
        {
            return (AsUInt(v.c0) * UInt2(0x9D88E5A1u, 0xEADF0775u) +
                    AsUInt(v.c1) * UInt2(0x747A9D7Bu, 0x4111F799u)) + 0xB5F05AF1u;
        }

    }
}
