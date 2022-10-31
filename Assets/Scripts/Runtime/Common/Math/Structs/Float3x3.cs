
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public partial struct Float3X3 : IEquatable<Float3X3>, IFormattable
    {
        public Float3 c0;
        public Float3 c1;
        public Float3 c2;

        /// <summary>Float3x3 identity transform.</summary>
        public static readonly Float3X3 identity = new Float3X3(
            SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero,
            SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero,
            SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);

        /// <summary>Float3x3 zero value.</summary>
        public static readonly Float3X3 zero;

        /// <summary>Constructs a Float3x3 matrix from three Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(Float3 c0, Float3 c1, Float3 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Float3x3 matrix from 9 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
                        SoftFloat m10, SoftFloat m11, SoftFloat m12,
                        SoftFloat m20, SoftFloat m21, SoftFloat m22)
        {
            c0 = new Float3(m00, m10, m20);
            c1 = new Float3(m01, m11, m21);
            c2 = new Float3(m02, m12, m22);
        }

        /// <summary>Constructs a Float3x3 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float3x3 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(bool v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c2 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float3x3 matrix from a Bool3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(Bool3x3 v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c2);
        }

        /// <summary>Constructs a Float3x3 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float3x3 matrix from a Int3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(Int3x3 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
        }

        /// <summary>Constructs a Float3x3 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(uint v)
        {
            c0 = new Float3(v);
            c1 = new Float3(v);
            c2 = new Float3(v);
        }

        /// <summary>Constructs a Float3x3 matrix from a UInt3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3X3(UInt3x3 v)
        {
            c0 = new Float3(v.c0);
            c1 = new Float3(v.c1);
            c2 = new Float3(v.c2);
        }


        /// <summary>Implicitly converts a single float value to a Float3x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3X3(SoftFloat v) { return new Float3X3(v); }

        /// <summary>Explicitly converts a single bool value to a Float3x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3X3(bool v) { return new Float3X3(v); }

        /// <summary>Explicitly converts a Bool3x3 matrix to a Float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3X3(Bool3x3 v) { return new Float3X3(v); }

        /// <summary>Implicitly converts a single int value to a Float3x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3X3(int v) { return new Float3X3(v); }

        /// <summary>Implicitly converts a Int3x3 matrix to a Float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3X3(Int3x3 v) { return new Float3X3(v); }

        /// <summary>Implicitly converts a single uint value to a Float3x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3X3(uint v) { return new Float3X3(v); }

        /// <summary>Implicitly converts a UInt3x3 matrix to a Float3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3X3(UInt3x3 v) { return new Float3X3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator * (Float3X3 lhs, Float3X3 rhs) { return new Float3X3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator * (Float3X3 lhs, SoftFloat rhs) { return new Float3X3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator * (SoftFloat lhs, Float3X3 rhs) { return new Float3X3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator + (Float3X3 lhs, Float3X3 rhs) { return new Float3X3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator + (Float3X3 lhs, SoftFloat rhs) { return new Float3X3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator + (SoftFloat lhs, Float3X3 rhs) { return new Float3X3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator - (Float3X3 lhs, Float3X3 rhs) { return new Float3X3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator - (Float3X3 lhs, SoftFloat rhs) { return new Float3X3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator - (SoftFloat lhs, Float3X3 rhs) { return new Float3X3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator / (Float3X3 lhs, Float3X3 rhs) { return new Float3X3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator / (Float3X3 lhs, SoftFloat rhs) { return new Float3X3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator / (SoftFloat lhs, Float3X3 rhs) { return new Float3X3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator % (Float3X3 lhs, Float3X3 rhs) { return new Float3X3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator % (Float3X3 lhs, SoftFloat rhs) { return new Float3X3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator % (SoftFloat lhs, Float3X3 rhs) { return new Float3X3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator < (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator < (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator < (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator <= (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator <= (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator <= (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator > (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator > (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator > (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator >= (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator >= (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator >= (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 operator - (Float3X3 val) { return new Float3X3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise equality operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (Float3X3 lhs, Float3X3 rhs) { return new Bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float3x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (Float3X3 lhs, SoftFloat rhs) { return new Bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (SoftFloat lhs, Float3X3 rhs) { return new Bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }



        /// <summary>Returns the Float3 element at a specified index.</summary>
        unsafe public ref Float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (Float3X3* array = &this) { return ref ((Float3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float3x3 is equal to a given Float3x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float3X3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the Float3x3 is equal to a given Float3x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float3X3)o); }


        /// <summary>Returns a hash code for the Float3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float3x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

        /// <summary>Returns a string representation of the Float3x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float3x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f,  {6}f, {7}f, {8}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float3x3 matrix constructed from three Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(Float3 c0, Float3 c1, Float3 c2) { return new Float3X3(c0, c1, c2); }

        /// <summary>Returns a Float3x3 matrix constructed from from 9 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
                                        SoftFloat m10, SoftFloat m11, SoftFloat m12,
                                        SoftFloat m20, SoftFloat m21, SoftFloat m22)
        {
            return new Float3X3(m00, m01, m02,
                                m10, m11, m12,
                                m20, m21, m22);
        }

        /// <summary>Returns a Float3x3 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(SoftFloat v) { return new Float3X3(v); }

        /// <summary>Returns a Float3x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(bool v) { return new Float3X3(v); }

        /// <summary>Return a Float3x3 matrix constructed from a Bool3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(Bool3x3 v) { return new Float3X3(v); }

        /// <summary>Returns a Float3x3 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(int v) { return new Float3X3(v); }

        /// <summary>Return a Float3x3 matrix constructed from a Int3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(Int3x3 v) { return new Float3X3(v); }

        /// <summary>Returns a Float3x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(uint v) { return new Float3X3(v); }

        /// <summary>Return a Float3x3 matrix constructed from a UInt3x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3x3(UInt3x3 v) { return new Float3X3(v); }

        /// <summary>Return the Float3x3 transpose of a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Transpose(Float3X3 v)
        {
            return Float3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        /// <summary>Returns the Float3x3 full inverse of a Float3x3 matrix.</summary>
        public static Float3X3 Inverse(Float3X3 m)
        {
            Float3 c0 = m.c0;
            Float3 c1 = m.c1;
            Float3 c2 = m.c2;

            Float3 t0 = Float3(c1.x, c2.x, c0.x);
            Float3 t1 = Float3(c1.y, c2.y, c0.y);
            Float3 t2 = Float3(c1.z, c2.z, c0.z);

            Float3 m0 = t1 * t2.yzx - t1.yzx * t2;
            Float3 m1 = t0.yzx * t2 - t0 * t2.yzx;
            Float3 m2 = t0 * t1.yzx - t0.yzx * t1;

            SoftFloat rcpDet = SoftFloat.One / SumComponents(t0.zxy * m0);
            return Float3x3(m0, m1, m2) * rcpDet;
        }

        /// <summary>Returns the determinant of a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Determinant(Float3X3 m)
        {
            Float3 c0 = m.c0;
            Float3 c1 = m.c1;
            Float3 c2 = m.c2;

            SoftFloat m00 = c1.y * c2.z - c1.z * c2.y;
            SoftFloat m01 = c0.y * c2.z - c0.z * c2.y;
            SoftFloat m02 = c0.y * c1.z - c0.z * c1.y;

            return c0.x * m00 - c1.x * m01 + c2.x * m02;
        }

        /// <summary>Returns a uint hash code of a Float3x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float3X3 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt3(0x713BD06Fu, 0x753AD6ADu, 0xD19764C7u) +
                        AsUInt(v.c1) * UInt3(0xB5D0BF63u, 0xF9102C5Fu, 0x9881FB9Fu) +
                        AsUInt(v.c2) * UInt3(0x56A1530Du, 0x804B722Du, 0x738E50E5u)) + 0x4FC93C25u;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Float3x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Float3X3 v)
        {
            return (AsUInt(v.c0) * UInt3(0xCD0445A5u, 0xD2B90D9Bu, 0xD35C9B2Du) +
                    AsUInt(v.c1) * UInt3(0xA10D9E27u, 0x568DAAA9u, 0x7530254Fu) +
                    AsUInt(v.c2) * UInt3(0x9F090439u, 0x5E9F85C9u, 0x8C4CA03Fu)) + 0xB8D969EDu;
        }

    }
}
