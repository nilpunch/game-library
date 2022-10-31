
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Float2x4 : IEquatable<Float2x4>, IFormattable
    {
        public Float2 c0;
        public Float2 c1;
        public Float2 c2;
        public Float2 c3;

        /// <summary>Float2x4 zero value.</summary>
        public static readonly Float2x4 zero;

        /// <summary>Constructs a Float2x4 matrix from four Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(Float2 c0, Float2 c1, Float2 c2, Float2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Float2x4 matrix from 8 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13)
        {
            c0 = new Float2(m00, m10);
            c1 = new Float2(m01, m11);
            c2 = new Float2(m02, m12);
            c3 = new Float2(m03, m13);
        }

        /// <summary>Constructs a Float2x4 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float2x4 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(bool v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c2 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c3 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float2x4 matrix from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(Bool2x4 v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c2);
            c3 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c3);
        }

        /// <summary>Constructs a Float2x4 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float2x4 matrix from a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(Int2x4 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
            c3 = v.c3;
        }

        /// <summary>Constructs a Float2x4 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float2x4 matrix from a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x4(UInt2x4 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
            c3 = v.c3;
        }


        /// <summary>Implicitly converts a single float value to a Float2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x4(SoftFloat v) { return new Float2x4(v); }

        /// <summary>Explicitly converts a single bool value to a Float2x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2x4(bool v) { return new Float2x4(v); }

        /// <summary>Explicitly converts a Bool2x4 matrix to a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2x4(Bool2x4 v) { return new Float2x4(v); }

        /// <summary>Implicitly converts a single int value to a Float2x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x4(int v) { return new Float2x4(v); }

        /// <summary>Implicitly converts a Int2x4 matrix to a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x4(Int2x4 v) { return new Float2x4(v); }

        /// <summary>Implicitly converts a single uint value to a Float2x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x4(uint v) { return new Float2x4(v); }

        /// <summary>Implicitly converts a UInt2x4 matrix to a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x4(UInt2x4 v) { return new Float2x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator * (Float2x4 lhs, Float2x4 rhs) { return new Float2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator * (Float2x4 lhs, SoftFloat rhs) { return new Float2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator * (SoftFloat lhs, Float2x4 rhs) { return new Float2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator + (Float2x4 lhs, Float2x4 rhs) { return new Float2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator + (Float2x4 lhs, SoftFloat rhs) { return new Float2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator + (SoftFloat lhs, Float2x4 rhs) { return new Float2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator - (Float2x4 lhs, Float2x4 rhs) { return new Float2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator - (Float2x4 lhs, SoftFloat rhs) { return new Float2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator - (SoftFloat lhs, Float2x4 rhs) { return new Float2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator / (Float2x4 lhs, Float2x4 rhs) { return new Float2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator / (Float2x4 lhs, SoftFloat rhs) { return new Float2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator / (SoftFloat lhs, Float2x4 rhs) { return new Float2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator % (Float2x4 lhs, Float2x4 rhs) { return new Float2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator % (Float2x4 lhs, SoftFloat rhs) { return new Float2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator % (SoftFloat lhs, Float2x4 rhs) { return new Float2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 operator - (Float2x4 val) { return new Float2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (Float2x4 lhs, Float2x4 rhs) { return new Bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float2x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (Float2x4 lhs, SoftFloat rhs) { return new Bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (SoftFloat lhs, Float2x4 rhs) { return new Bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the Float2 element at a specified index.</summary>
        unsafe public ref Float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Float2x4* array = &this) { return ref ((Float2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float2x4 is equal to a given Float2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Float2x4 is equal to a given Float2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float2x4)o); }


        /// <summary>Returns a hash code for the Float2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the Float2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float2x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float2x4 matrix constructed from four Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(Float2 c0, Float2 c1, Float2 c2, Float2 c3) { return new Float2x4(c0, c1, c2, c3); }

        /// <summary>Returns a Float2x4 matrix constructed from from 8 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13)
        {
            return new Float2x4(m00, m01, m02, m03,
                                m10, m11, m12, m13);
        }

        /// <summary>Returns a Float2x4 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(SoftFloat v) { return new Float2x4(v); }

        /// <summary>Returns a Float2x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(bool v) { return new Float2x4(v); }

        /// <summary>Return a Float2x4 matrix constructed from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(Bool2x4 v) { return new Float2x4(v); }

        /// <summary>Returns a Float2x4 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(int v) { return new Float2x4(v); }

        /// <summary>Return a Float2x4 matrix constructed from a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(Int2x4 v) { return new Float2x4(v); }

        /// <summary>Returns a Float2x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(uint v) { return new Float2x4(v); }

        /// <summary>Return a Float2x4 matrix constructed from a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x4 Float2x4(UInt2x4 v) { return new Float2x4(v); }

        /// <summary>Return the Float4x2 transpose of a Float2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4x2 Transpose(Float2x4 v)
        {
            return Float4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a Float2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float2x4 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt2(0xD35C9B2Du, 0xA10D9E27u) +
                        AsUInt(v.c1) * UInt2(0x568DAAA9u, 0x7530254Fu) +
                        AsUInt(v.c2) * UInt2(0x9F090439u, 0x5E9F85C9u) +
                        AsUInt(v.c3) * UInt2(0x8C4CA03Fu, 0xB8D969EDu)) + 0xAC5DB57Bu;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Float2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Float2x4 v)
        {
            return (AsUInt(v.c0) * UInt2(0xA91A02EDu, 0xB3C49313u) +
                    AsUInt(v.c1) * UInt2(0xF43A9ABBu, 0x84E7E01Bu) +
                    AsUInt(v.c2) * UInt2(0x8E055BE5u, 0x6E624EB7u) +
                    AsUInt(v.c3) * UInt2(0x7383ED49u, 0xDD49C23Bu)) + 0xEBD0D005u;
        }

    }
}
