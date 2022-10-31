
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int3x2 : IEquatable<Int3x2>, IFormattable
    {
        public Int3 c0;
        public Int3 c1;

        /// <summary>Int3x2 zero value.</summary>
        public static readonly Int3x2 zero;

        /// <summary>Constructs a Int3x2 matrix from two Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(Int3 c0, Int3 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Int3x2 matrix from 6 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21)
        {
            c0 = new Int3(m00, m10, m20);
            c1 = new Int3(m01, m11, m21);
        }

        /// <summary>Constructs a Int3x2 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Int3x2 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(bool v)
        {
            c0 = Math.Select(new Int3(0), new Int3(1), v);
            c1 = Math.Select(new Int3(0), new Int3(1), v);
        }

        /// <summary>Constructs a Int3x2 matrix from a Bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(Bool3x2 v)
        {
            c0 = Math.Select(new Int3(0), new Int3(1), v.c0);
            c1 = Math.Select(new Int3(0), new Int3(1), v.c1);
        }

        /// <summary>Constructs a Int3x2 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(uint v)
        {
            c0 = (Int3)v;
            c1 = (Int3)v;
        }

        /// <summary>Constructs a Int3x2 matrix from a UInt3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(UInt3x2 v)
        {
            c0 = (Int3)v.c0;
            c1 = (Int3)v.c1;
        }

        /// <summary>Constructs a Int3x2 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(SoftFloat v)
        {
            c0 = (Int3)(Float3)v;
            c1 = (Int3)(Float3)v;
        }

        /// <summary>Constructs a Int3x2 matrix from a Float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int3x2(Float3x2 v)
        {
            c0 = (Int3)v.c0;
            c1 = (Int3)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a Int3x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int3x2(int v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a single bool value to a Int3x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(bool v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a Bool3x2 matrix to a Int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(Bool3x2 v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a single uint value to a Int3x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(uint v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a UInt3x2 matrix to a Int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(UInt3x2 v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a single float value to a Int3x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(SoftFloat v) { return new Int3x2(v); }

        /// <summary>Explicitly converts a Float3x2 matrix to a Int3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int3x2(Float3x2 v) { return new Int3x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator * (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator * (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator * (int lhs, Int3x2 rhs) { return new Int3x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator + (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator + (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator + (int lhs, Int3x2 rhs) { return new Int3x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator - (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator - (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator - (int lhs, Int3x2 rhs) { return new Int3x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator / (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator / (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator / (int lhs, Int3x2 rhs) { return new Int3x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator % (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator % (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator % (int lhs, Int3x2 rhs) { return new Int3x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator ++ (Int3x2 val) { return new Int3x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator -- (Int3x2 val) { return new Int3x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator < (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator <= (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator > (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator >= (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator - (Int3x2 val) { return new Int3x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator + (Int3x2 val) { return new Int3x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int3x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator << (Int3x2 x, int n) { return new Int3x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int3x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator >> (Int3x2 x, int n) { return new Int3x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator == (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (Int3x2 lhs, Int3x2 rhs) { return new Bool3x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (Int3x2 lhs, int rhs) { return new Bool3x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 operator != (int lhs, Int3x2 rhs) { return new Bool3x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator ~ (Int3x2 val) { return new Int3x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator & (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator & (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator & (int lhs, Int3x2 rhs) { return new Int3x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator | (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator | (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator | (int lhs, Int3x2 rhs) { return new Int3x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int3x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator ^ (Int3x2 lhs, Int3x2 rhs) { return new Int3x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int3x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator ^ (Int3x2 lhs, int rhs) { return new Int3x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 operator ^ (int lhs, Int3x2 rhs) { return new Int3x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the Int3 element at a specified index.</summary>
        unsafe public ref Int3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Int3x2* array = &this) { return ref ((Int3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int3x2 is equal to a given Int3x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int3x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Int3x2 is equal to a given Int3x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int3x2)o); }


        /// <summary>Returns a hash code for the Int3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int3x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z);
        }

        /// <summary>Returns a string representation of the Int3x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int3x2({0}, {1},  {2}, {3},  {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int3x2 matrix constructed from two Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(Int3 c0, Int3 c1) { return new Int3x2(c0, c1); }

        /// <summary>Returns a Int3x2 matrix constructed from from 6 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(int m00, int m01,
                                    int m10, int m11,
                                    int m20, int m21)
        {
            return new Int3x2(m00, m01,
                              m10, m11,
                              m20, m21);
        }

        /// <summary>Returns a Int3x2 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(int v) { return new Int3x2(v); }

        /// <summary>Returns a Int3x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(bool v) { return new Int3x2(v); }

        /// <summary>Return a Int3x2 matrix constructed from a Bool3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(Bool3x2 v) { return new Int3x2(v); }

        /// <summary>Returns a Int3x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(uint v) { return new Int3x2(v); }

        /// <summary>Return a Int3x2 matrix constructed from a UInt3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(UInt3x2 v) { return new Int3x2(v); }

        /// <summary>Returns a Int3x2 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(SoftFloat v) { return new Int3x2(v); }

        /// <summary>Return a Int3x2 matrix constructed from a Float3x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x2 Int3x2(Float3x2 v) { return new Int3x2(v); }

        /// <summary>Return the Int2x3 transpose of a Int3x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x3 Transpose(Int3x2 v)
        {
            return Int2x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z);
        }

        /// <summary>Returns a uint hash code of a Int3x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int3x2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt3(0xDB3DE101u, 0x7B6D1B4Bu, 0x58399E77u) +
                        AsUInt(v.c1) * UInt3(0x5EAC29C9u, 0xFC6014F9u, 0x6BF6693Fu)) + 0x9D1B1D9Bu;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Int3x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Int3x2 v)
        {
            return (AsUInt(v.c0) * UInt3(0xF842F5C1u, 0xA47EC335u, 0xA477DF57u) +
                    AsUInt(v.c1) * UInt3(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u)) + 0x5B419C01u;
        }

    }
}
