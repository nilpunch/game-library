
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public partial struct Float4X4 : IEquatable<Float4X4>, IFormattable
    {
        public Float4 c0;
        public Float4 c1;
        public Float4 c2;
        public Float4 c3;

        /// <summary>Float4x4 identity transform.</summary>
        public static readonly Float4X4 identity = new Float4X4(
            SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
            SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero,
            SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero,
            SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
        );

        /// <summary>Float4x4 zero value.</summary>
        public static readonly Float4X4 zero;

        /// <summary>Constructs a Float4x4 matrix from four Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(Float4 c0, Float4 c1, Float4 c2, Float4 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Float4x4 matrix from 16 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13,
                        SoftFloat m20, SoftFloat m21, SoftFloat m22, SoftFloat m23,
                        SoftFloat m30, SoftFloat m31, SoftFloat m32, SoftFloat m33)
        {
            c0 = new Float4(m00, m10, m20, m30);
            c1 = new Float4(m01, m11, m21, m31);
            c2 = new Float4(m02, m12, m22, m32);
            c3 = new Float4(m03, m13, m23, m33);
        }

        /// <summary>Constructs a Float4x4 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float4x4 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(bool v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c2 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
            c3 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float4x4 matrix from a Bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(Bool4x4 v)
        {
            c0 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c2);
            c3 = Math.Select(new Float4(SoftFloat.Zero), new Float4(SoftFloat.One), v.c3);
        }

        /// <summary>Constructs a Float4x4 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float4x4 matrix from a Int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(Int4x4 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
            c3 = v.c3;
        }

        /// <summary>Constructs a Float4x4 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float4x4 matrix from a UInt4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4X4(UInt4x4 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
            c3 = v.c3;
        }


        /// <summary>Implicitly converts a single float value to a Float4x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4X4(SoftFloat v) { return new Float4X4(v); }

        /// <summary>Explicitly converts a single bool value to a Float4x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4X4(bool v) { return new Float4X4(v); }

        /// <summary>Explicitly converts a Bool4x4 matrix to a Float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4X4(Bool4x4 v) { return new Float4X4(v); }

        /// <summary>Implicitly converts a single int value to a Float4x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4X4(int v) { return new Float4X4(v); }

        /// <summary>Implicitly converts a Int4x4 matrix to a Float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4X4(Int4x4 v) { return new Float4X4(v); }

        /// <summary>Implicitly converts a single uint value to a Float4x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4X4(uint v) { return new Float4X4(v); }

        /// <summary>Implicitly converts a UInt4x4 matrix to a Float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4X4(UInt4x4 v) { return new Float4X4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator * (Float4X4 lhs, Float4X4 rhs) { return new Float4X4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator * (Float4X4 lhs, SoftFloat rhs) { return new Float4X4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator * (SoftFloat lhs, Float4X4 rhs) { return new Float4X4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator + (Float4X4 lhs, Float4X4 rhs) { return new Float4X4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator + (Float4X4 lhs, SoftFloat rhs) { return new Float4X4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator + (SoftFloat lhs, Float4X4 rhs) { return new Float4X4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator - (Float4X4 lhs, Float4X4 rhs) { return new Float4X4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator - (Float4X4 lhs, SoftFloat rhs) { return new Float4X4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator - (SoftFloat lhs, Float4X4 rhs) { return new Float4X4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator / (Float4X4 lhs, Float4X4 rhs) { return new Float4X4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator / (Float4X4 lhs, SoftFloat rhs) { return new Float4X4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator / (SoftFloat lhs, Float4X4 rhs) { return new Float4X4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator % (Float4X4 lhs, Float4X4 rhs) { return new Float4X4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator % (Float4X4 lhs, SoftFloat rhs) { return new Float4X4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator % (SoftFloat lhs, Float4X4 rhs) { return new Float4X4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 operator - (Float4X4 val) { return new Float4X4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (Float4X4 lhs, Float4X4 rhs) { return new Bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float4x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (Float4X4 lhs, SoftFloat rhs) { return new Bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (SoftFloat lhs, Float4X4 rhs) { return new Bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the Float4 element at a specified index.</summary>
        unsafe public ref Float4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Float4X4* array = &this) { return ref ((Float4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float4x4 is equal to a given Float4x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float4X4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Float4x4 is equal to a given Float4x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float4X4)o); }


        /// <summary>Returns a hash code for the Float4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float4x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f,  {12}f, {13}f, {14}f, {15}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        /// <summary>Returns a string representation of the Float4x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float4x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f,  {12}f, {13}f, {14}f, {15}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float4x4 matrix constructed from four Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(Float4 c0, Float4 c1, Float4 c2, Float4 c3) { return new Float4X4(c0, c1, c2, c3); }

        /// <summary>Returns a Float4x4 matrix constructed from from 16 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13,
                                        SoftFloat m20, SoftFloat m21, SoftFloat m22, SoftFloat m23,
                                        SoftFloat m30, SoftFloat m31, SoftFloat m32, SoftFloat m33)
        {
            return new Float4X4(m00, m01, m02, m03,
                                m10, m11, m12, m13,
                                m20, m21, m22, m23,
                                m30, m31, m32, m33);
        }

        /// <summary>Returns a Float4x4 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(SoftFloat v) { return new Float4X4(v); }

        /// <summary>Returns a Float4x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(bool v) { return new Float4X4(v); }

        /// <summary>Return a Float4x4 matrix constructed from a Bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(Bool4x4 v) { return new Float4X4(v); }

        /// <summary>Returns a Float4x4 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(int v) { return new Float4X4(v); }

        /// <summary>Return a Float4x4 matrix constructed from a Int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(Int4x4 v) { return new Float4X4(v); }

        /// <summary>Returns a Float4x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(uint v) { return new Float4X4(v); }

        /// <summary>Return a Float4x4 matrix constructed from a UInt4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4x4(UInt4x4 v) { return new Float4X4(v); }

        /// <summary>Return the result of rotating a Float3 vector by a Float4x4 matrix</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Rotate(Float4X4 a, Float3 b)
        {
            return (a.c0 * b.x + a.c1 * b.y + a.c2 * b.z).xyz;
        }

        /// <summary>Return the result of transforming a Float3 point by a Float4x4 matrix</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Transform(Float4X4 a, Float3 b)
        {
            return (a.c0 * b.x + a.c1 * b.y + a.c2 * b.z + a.c3).xyz;
        }

        /// <summary>Return the Float4x4 transpose of a Float4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Transpose(Float4X4 v)
        {
            return Float4x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w,
                v.c3.x, v.c3.y, v.c3.z, v.c3.w);
        }

        /// <summary>Returns the Float4x4 full inverse of a Float4x4 matrix.</summary>
        public static Float4X4 Inverse(Float4X4 m)
        {
            Float4 c0 = m.c0;
            Float4 c1 = m.c1;
            Float4 c2 = m.c2;
            Float4 c3 = m.c3;

            Float4 r0y_r1y_r0x_r1x = Movelh(c1, c0);
            Float4 r0z_r1z_r0w_r1w = Movelh(c2, c3);
            Float4 r2y_r3y_r2x_r3x = Movehl(c0, c1);
            Float4 r2z_r3z_r2w_r3w = Movehl(c3, c2);

            Float4 r1y_r2y_r1x_r2x = Shuffle(c1, c0, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            Float4 r1z_r2z_r1w_r2w = Shuffle(c2, c3, ShuffleComponent.LeftY, ShuffleComponent.LeftZ, ShuffleComponent.RightY, ShuffleComponent.RightZ);
            Float4 r3y_r0y_r3x_r0x = Shuffle(c1, c0, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);
            Float4 r3z_r0z_r3w_r0w = Shuffle(c2, c3, ShuffleComponent.LeftW, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightX);

            Float4 r0_wzyx = Shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            Float4 r1_wzyx = Shuffle(r0z_r1z_r0w_r1w, r0y_r1y_r0x_r1x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            Float4 r2_wzyx = Shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);
            Float4 r3_wzyx = Shuffle(r2z_r3z_r2w_r3w, r2y_r3y_r2x_r3x, ShuffleComponent.LeftW, ShuffleComponent.LeftY, ShuffleComponent.RightY, ShuffleComponent.RightW);
            Float4 r0_xyzw = Shuffle(r0y_r1y_r0x_r1x, r0z_r1z_r0w_r1w, ShuffleComponent.LeftZ, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.RightZ);

            // Calculate remaining inner term pairs. inner terms have zw=-xy, so we only have to calculate xy and can pack two pairs per vector.
            Float4 inner12_23 = r1y_r2y_r1x_r2x * r2z_r3z_r2w_r3w - r1z_r2z_r1w_r2w * r2y_r3y_r2x_r3x;
            Float4 inner02_13 = r0y_r1y_r0x_r1x * r2z_r3z_r2w_r3w - r0z_r1z_r0w_r1w * r2y_r3y_r2x_r3x;
            Float4 inner30_01 = r3z_r0z_r3w_r0w * r0y_r1y_r0x_r1x - r3y_r0y_r3x_r0x * r0z_r1z_r0w_r1w;

            // Expand inner terms back to 4 components. zw signs still need to be flipped
            Float4 inner12 = Shuffle(inner12_23, inner12_23, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            Float4 inner23 = Shuffle(inner12_23, inner12_23, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            Float4 inner02 = Shuffle(inner02_13, inner02_13, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            Float4 inner13 = Shuffle(inner02_13, inner02_13, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            // Calculate minors
            Float4 minors0 = r3_wzyx * inner12 - r2_wzyx * inner13 + r1_wzyx * inner23;

            Float4 denom = r0_xyzw * minors0;

            // Horizontal sum of denominator. Free sign flip of z and w compensates for missing flip in inner terms.
            denom = denom + Shuffle(denom, denom, ShuffleComponent.LeftY, ShuffleComponent.LeftX, ShuffleComponent.RightW, ShuffleComponent.RightZ);   // x+y        x+y            z+w            z+w
            denom = denom - Shuffle(denom, denom, ShuffleComponent.LeftZ, ShuffleComponent.LeftZ, ShuffleComponent.RightX, ShuffleComponent.RightX);   // x+y-z-w  x+y-z-w        z+w-x-y        z+w-x-y

            Float4 rcp_denom_ppnn = Float4(SoftFloat.One) / denom;
            Float4X4 res;
            res.c0 = minors0 * rcp_denom_ppnn;

            Float4 inner30 = Shuffle(inner30_01, inner30_01, ShuffleComponent.LeftX, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.RightX);
            Float4 inner01 = Shuffle(inner30_01, inner30_01, ShuffleComponent.LeftY, ShuffleComponent.LeftW, ShuffleComponent.RightW, ShuffleComponent.RightY);

            Float4 minors1 = r2_wzyx * inner30 - r0_wzyx * inner23 - r3_wzyx * inner02;
            res.c1 = minors1 * rcp_denom_ppnn;

            Float4 minors2 = r0_wzyx * inner13 - r1_wzyx * inner30 - r3_wzyx * inner01;
            res.c2 = minors2 * rcp_denom_ppnn;

            Float4 minors3 = r1_wzyx * inner02 - r0_wzyx * inner12 + r2_wzyx * inner01;
            res.c3 = minors3 * rcp_denom_ppnn;
            return res;
        }

        // Fast matrix inverse for rigid transforms (Orthonormal basis and translation)
        public static Float4X4 FastInverse(Float4X4 m)
        {
            Float4 c0 = m.c0;
            Float4 c1 = m.c1;
            Float4 c2 = m.c2;
            Float4 pos = m.c3;

            Float4 zero = Float4(0);

            Float4 t0 = Unpacklo(c0, c2);
            Float4 t1 = Unpacklo(c1, zero);
            Float4 t2 = Unpackhi(c0, c2);
            Float4 t3 = Unpackhi(c1, zero);

            Float4 r0 = Unpacklo(t0, t1);
            Float4 r1 = Unpackhi(t0, t1);
            Float4 r2 = Unpacklo(t2, t3);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);
            pos.w = SoftFloat.One;

            return Float4x4(r0, r1, r2, pos);
        }

        /// <summary>Returns the determinant of a Float4x4 matrix.</summary>
        public static SoftFloat Determinant(Float4X4 m)
        {
            Float4 c0 = m.c0;
            Float4 c1 = m.c1;
            Float4 c2 = m.c2;
            Float4 c3 = m.c3;

            SoftFloat m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            SoftFloat m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            SoftFloat m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            SoftFloat m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }

        /// <summary>Returns a uint hash code of a Float4x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float4X4 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u, 0x5B419C01u) +
                        AsUInt(v.c1) * UInt4(0x515D90F5u, 0xEC9F68F3u, 0xF9EA92D5u, 0xC2FAFCB9u) +
                        AsUInt(v.c2) * UInt4(0x616E9CA1u, 0xC5C5394Bu, 0xCAE78587u, 0x7A1541C9u) +
                        AsUInt(v.c3) * UInt4(0xF83BD927u, 0x6A243BCBu, 0x509B84C9u, 0x91D13847u)) + 0x52F7230Fu;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Float4x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Float4X4 v)
        {
            return (AsUInt(v.c0) * UInt4(0xCF286E83u, 0xE121E6ADu, 0xC9CA1249u, 0x69B60C81u) +
                    AsUInt(v.c1) * UInt4(0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u, 0xEF63C699u) +
                    AsUInt(v.c2) * UInt4(0x9001903Fu, 0xA895B9CDu, 0x9D23B201u, 0x4B01D3E1u) +
                    AsUInt(v.c3) * UInt4(0x7461CA0Du, 0x79725379u, 0xD6258E5Bu, 0xEE390C97u)) + 0x9C8A2F05u;
        }

    }
}
