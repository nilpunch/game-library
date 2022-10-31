
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int4x2 : IEquatable<Int4x2>, IFormattable
    {
        public Int4 c0;
        public Int4 c1;

        /// <summary>Int4x2 zero value.</summary>
        public static readonly Int4x2 zero;

        /// <summary>Constructs a Int4x2 matrix from two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(Int4 c0, Int4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Int4x2 matrix from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(int m00, int m01,
                      int m10, int m11,
                      int m20, int m21,
                      int m30, int m31)
        {
            c0 = new Int4(m00, m10, m20, m30);
            c1 = new Int4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a Int4x2 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Int4x2 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(bool v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v);
            c1 = Math.Select(new Int4(0), new Int4(1), v);
        }

        /// <summary>Constructs a Int4x2 matrix from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(Bool4x2 v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v.c0);
            c1 = Math.Select(new Int4(0), new Int4(1), v.c1);
        }

        /// <summary>Constructs a Int4x2 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(uint v)
        {
            c0 = (Int4)v;
            c1 = (Int4)v;
        }

        /// <summary>Constructs a Int4x2 matrix from a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(UInt4x2 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
        }

        /// <summary>Constructs a Int4x2 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(SoftFloat v)
        {
            c0 = (Int4)(int)v;
            c1 = (Int4)(int)v;
        }

        /// <summary>Constructs a Int4x2 matrix from a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x2(Float4x2 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a Int4x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x2(int v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a single bool value to a Int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(bool v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a Bool4x2 matrix to a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(Bool4x2 v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a single uint value to a Int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(uint v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a UInt4x2 matrix to a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(UInt4x2 v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a single float value to a Int4x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(SoftFloat v) { return new Int4x2(v); }

        /// <summary>Explicitly converts a Float4x2 matrix to a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x2(Float4x2 v) { return new Int4x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator * (int lhs, Int4x2 rhs) { return new Int4x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (int lhs, Int4x2 rhs) { return new Int4x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (int lhs, Int4x2 rhs) { return new Int4x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator / (int lhs, Int4x2 rhs) { return new Int4x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator % (int lhs, Int4x2 rhs) { return new Int4x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ++ (Int4x2 val) { return new Int4x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator -- (Int4x2 val) { return new Int4x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator - (Int4x2 val) { return new Int4x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator + (Int4x2 val) { return new Int4x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator << (Int4x2 x, int n) { return new Int4x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator >> (Int4x2 x, int n) { return new Int4x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (Int4x2 lhs, Int4x2 rhs) { return new Bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (Int4x2 lhs, int rhs) { return new Bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (int lhs, Int4x2 rhs) { return new Bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ~ (Int4x2 val) { return new Int4x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator & (int lhs, Int4x2 rhs) { return new Int4x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator | (int lhs, Int4x2 rhs) { return new Int4x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (Int4x2 lhs, Int4x2 rhs) { return new Int4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int4x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (Int4x2 lhs, int rhs) { return new Int4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 operator ^ (int lhs, Int4x2 rhs) { return new Int4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the Int4 element at a specified index.</summary>
        unsafe public ref Int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Int4x2* array = &this) { return ref ((Int4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int4x2 is equal to a given Int4x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Int4x2 is equal to a given Int4x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int4x2)o); }


        /// <summary>Returns a hash code for the Int4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        /// <summary>Returns a string representation of the Int4x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int4x2 matrix constructed from two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(Int4 c0, Int4 c1) { return new Int4x2(c0, c1); }

        /// <summary>Returns a Int4x2 matrix constructed from from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(int m00, int m01,
                                    int m10, int m11,
                                    int m20, int m21,
                                    int m30, int m31)
        {
            return new Int4x2(m00, m01,
                              m10, m11,
                              m20, m21,
                              m30, m31);
        }

        /// <summary>Returns a Int4x2 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(int v) { return new Int4x2(v); }

        /// <summary>Returns a Int4x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(bool v) { return new Int4x2(v); }

        /// <summary>Return a Int4x2 matrix constructed from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(Bool4x2 v) { return new Int4x2(v); }

        /// <summary>Returns a Int4x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(uint v) { return new Int4x2(v); }

        /// <summary>Return a Int4x2 matrix constructed from a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(UInt4x2 v) { return new Int4x2(v); }

        /// <summary>Returns a Int4x2 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(SoftFloat v) { return new Int4x2(v); }

        /// <summary>Return a Int4x2 matrix constructed from a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Int4x2(Float4x2 v) { return new Int4x2(v); }

        /// <summary>Return the Int2x4 transpose of a Int4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Transpose(Int4x2 v)
        {
            return Int2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a Int4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int4x2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0xFAAF07DDu, 0x625C45BDu, 0xC9F27FCBu, 0x6D2523B1u) +
                        AsUInt(v.c1) * UInt4(0x6E2BF6A9u, 0xCC74B3B7u, 0x83B58237u, 0x833E3E29u)) + 0xA9D919BFu;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Int4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Int4x2 v)
        {
            return (AsUInt(v.c0) * UInt4(0xC3EC1D97u, 0xB8B208C7u, 0x5D3ED947u, 0x4473BBB1u) +
                    AsUInt(v.c1) * UInt4(0xCBA11D5Fu, 0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

    }
}
