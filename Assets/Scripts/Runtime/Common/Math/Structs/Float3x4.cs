
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Float3x4 : IEquatable<Float3x4>, IFormattable
    {
        public Float3 c0;
        public Float3 c1;
        public Float3 c2;
        public Float3 c3;

        /// <summary>Float3x4 zero value.</summary>
        public static readonly Float3x4 zero;

        /// <summary>Constructs a Float3x4 matrix from four Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(Float3 c0, Float3 c1, Float3 c2, Float3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Float3x4 matrix from 12 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13,
                        SoftFloat m20, SoftFloat m21, SoftFloat m22, SoftFloat m23)
        {
            c0 = new Float3(m00, m10, m20);
            c1 = new Float3(m01, m11, m21);
            c2 = new Float3(m02, m12, m22);
            c3 = new Float3(m03, m13, m23);
        }

        /// <summary>Constructs a Float3x4 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float3x4 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(bool v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c2 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
            c3 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float3x4 matrix from a Bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(Bool3x4 v)
        {
            c0 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c2);
            c3 = Math.Select(new Float3(SoftFloat.Zero), new Float3(SoftFloat.One), v.c3);
        }

        /// <summary>Constructs a Float3x4 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Float3x4 matrix from a Int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(Int3x4 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
            c3 = v.c3;
        }

        /// <summary>Constructs a Float3x4 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(uint v)
        {
            c0 = (int)v;
            c1 = (int)v;
            c2 = (int)v;
            c3 = (int)v;
        }

        /// <summary>Constructs a Float3x4 matrix from a UInt3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3x4(UInt3x4 v)
        {
            c0 = (Int3)v.c0;
            c1 = (Int3)v.c1;
            c2 = (Int3)v.c2;
            c3 = (Int3)v.c3;
        }



        /// <summary>Implicitly converts a single float value to a Float3x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3x4(SoftFloat v) { return new Float3x4(v); }

        /// <summary>Explicitly converts a single bool value to a Float3x4 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3x4(bool v) { return new Float3x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator * (Float3x4 lhs, Float3x4 rhs) { return new Float3x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator * (Float3x4 lhs, SoftFloat rhs) { return new Float3x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator * (SoftFloat lhs, Float3x4 rhs) { return new Float3x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator + (Float3x4 lhs, Float3x4 rhs) { return new Float3x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator + (Float3x4 lhs, SoftFloat rhs) { return new Float3x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator + (SoftFloat lhs, Float3x4 rhs) { return new Float3x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator - (Float3x4 lhs, Float3x4 rhs) { return new Float3x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator - (Float3x4 lhs, SoftFloat rhs) { return new Float3x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator - (SoftFloat lhs, Float3x4 rhs) { return new Float3x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator / (Float3x4 lhs, Float3x4 rhs) { return new Float3x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator / (Float3x4 lhs, SoftFloat rhs) { return new Float3x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator / (SoftFloat lhs, Float3x4 rhs) { return new Float3x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator % (Float3x4 lhs, Float3x4 rhs) { return new Float3x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator % (Float3x4 lhs, SoftFloat rhs) { return new Float3x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator % (SoftFloat lhs, Float3x4 rhs) { return new Float3x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator < (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator < (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator < (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <= (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <= (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <= (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator > (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator > (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator > (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >= (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >= (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >= (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 operator - (Float3x4 val) { return new Float3x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise equality operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (Float3x4 lhs, Float3x4 rhs) { return new Bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float3x4 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (Float3x4 lhs, SoftFloat rhs) { return new Bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (SoftFloat lhs, Float3x4 rhs) { return new Bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }



        /// <summary>Returns the Float3 element at a specified index.</summary>
        unsafe public ref Float3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Float3x4* array = &this) { return ref ((Float3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Float3x4 is equal to a given Float3x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Float3x4 is equal to a given Float3x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float3x4)o); }


        /// <summary>Returns a hash code for the Float3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float3x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f)", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        /// <summary>Returns a string representation of the Float3x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float3x4({0}f, {1}f, {2}f, {3}f,  {4}f, {5}f, {6}f, {7}f,  {8}f, {9}f, {10}f, {11}f)", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Float3x4 matrix constructed from four Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(Float3 c0, Float3 c1, Float3 c2, Float3 c3) { return new Float3x4(c0, c1, c2, c3); }

        /// <summary>Returns a Float3x4 matrix constructed from from 12 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(SoftFloat m00, SoftFloat m01, SoftFloat m02, SoftFloat m03,
                                        SoftFloat m10, SoftFloat m11, SoftFloat m12, SoftFloat m13,
                                        SoftFloat m20, SoftFloat m21, SoftFloat m22, SoftFloat m23)
        {
            return new Float3x4(m00, m01, m02, m03,
                                m10, m11, m12, m13,
                                m20, m21, m22, m23);
        }

        /// <summary>Returns a Float3x4 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(SoftFloat v) { return new Float3x4(v); }

        /// <summary>Returns a Float3x4 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(bool v) { return new Float3x4(v); }

        /// <summary>Return a Float3x4 matrix constructed from a Bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(Bool3x4 v) { return new Float3x4(v); }

        /// <summary>Returns a Float3x4 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(int v) { return new Float3x4(v); }

        /// <summary>Return a Float3x4 matrix constructed from a Int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(Int3x4 v) { return new Float3x4(v); }

        /// <summary>Returns a Float3x4 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x4 Float3x4(uint v) { return new Float3x4(v); }


        ///// <summary>Return the Float4x3 transpose of a Float3x4 matrix.</summary>
        //[MethodImpl(MethodImplOptions.AggressiveInlining)]
        //public static sFloat4x3 transpose(sFloat3x4 v)
        //{
        //    return sFloat4x3(
        //        v.c0.x, v.c0.y, v.c0.z,
        //        v.c1.x, v.c1.y, v.c1.z,
        //        v.c2.x, v.c2.y, v.c2.z,
        //        v.c3.x, v.c3.y, v.c3.z);
        //}

        // Fast matrix inverse for rigid transforms (Orthonormal basis and translation)
        public static Float3x4 FastInverse(Float3x4 m)
        {
            Float3 c0 = m.c0;
            Float3 c1 = m.c1;
            Float3 c2 = m.c2;
            Float3 pos = m.c3;

            Float3 r0 = new Float3(c0.x, c1.x, c2.x);
            Float3 r1 = new Float3(c0.y, c1.y, c2.y);
            Float3 r2 = new Float3(c0.z, c1.z, c2.z);

            pos = -(r0 * pos.x + r1 * pos.y + r2 * pos.z);

            return Float3x4(r0, r1, r2, pos);
        }

        /// <summary>Returns a uint hash code of a Float3x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float3x4 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt3(0xF9EA92D5u, 0xC2FAFCB9u, 0x616E9CA1u) +
                        AsUInt(v.c1) * UInt3(0xC5C5394Bu, 0xCAE78587u, 0x7A1541C9u) +
                        AsUInt(v.c2) * UInt3(0xF83BD927u, 0x6A243BCBu, 0x509B84C9u) +
                        AsUInt(v.c3) * UInt3(0x91D13847u, 0x52F7230Fu, 0xCF286E83u)) + 0xE121E6ADu;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Float3x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Float3x4 v)
        {
            return (AsUInt(v.c0) * UInt3(0xC9CA1249u, 0x69B60C81u, 0xE0EB6C25u) +
                    AsUInt(v.c1) * UInt3(0xF648BEABu, 0x6BDB2B07u, 0xEF63C699u) +
                    AsUInt(v.c2) * UInt3(0x9001903Fu, 0xA895B9CDu, 0x9D23B201u) +
                    AsUInt(v.c3) * UInt3(0x4B01D3E1u, 0x7461CA0Du, 0x79725379u)) + 0xD6258E5Bu;
        }

    }
}
