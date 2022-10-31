
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int4x4 : IEquatable<Int4x4>, IFormattable
    {
        public Int4 c0;
        public Int4 c1;
        public Int4 c2;
        public Int4 c3;

        /// <summary>Int4x4 identity transform.</summary>
        public static readonly Int4x4 identity = new Int4x4(1, 0, 0, 0,   0, 1, 0, 0,   0, 0, 1, 0,   0, 0, 0, 1);

        /// <summary>Int4x4 zero value.</summary>
        public static readonly Int4x4 zero;

        /// <summary>Constructs a Int4x4 matrix from four Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(Int4 c0, Int4 c1, Int4 c2, Int4 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Int4x4 matrix from 16 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13,
                      int m20, int m21, int m22, int m23,
                      int m30, int m31, int m32, int m33)
        {
            c0 = new Int4(m00, m10, m20, m30);
            c1 = new Int4(m01, m11, m21, m31);
            c2 = new Int4(m02, m12, m22, m32);
            c3 = new Int4(m03, m13, m23, m33);
        }

        /// <summary>Constructs a Int4x4 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Int4x4 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(bool v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v);
            c1 = Math.Select(new Int4(0), new Int4(1), v);
            c2 = Math.Select(new Int4(0), new Int4(1), v);
            c3 = Math.Select(new Int4(0), new Int4(1), v);
        }

        /// <summary>Constructs a Int4x4 matrix from a Bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(Bool4x4 v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v.c0);
            c1 = Math.Select(new Int4(0), new Int4(1), v.c1);
            c2 = Math.Select(new Int4(0), new Int4(1), v.c2);
            c3 = Math.Select(new Int4(0), new Int4(1), v.c3);
        }

        /// <summary>Constructs a Int4x4 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(uint v)
        {
            c0 = (Int4)v;
            c1 = (Int4)v;
            c2 = (Int4)v;
            c3 = (Int4)v;
        }

        /// <summary>Constructs a Int4x4 matrix from a UInt4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(UInt4x4 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
            c2 = (Int4)v.c2;
            c3 = (Int4)v.c3;
        }

        /// <summary>Constructs a Int4x4 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(SoftFloat v)
        {
            c0 = (Int4)(int)v;
            c1 = (Int4)(int)v;
            c2 = (Int4)(int)v;
            c3 = (Int4)(int)v;
        }

        /// <summary>Constructs a Int4x4 matrix from a Float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x4(Float4X4 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
            c2 = (Int4)v.c2;
            c3 = (Int4)v.c3;
        }


        /// <summary>Implicitly converts a single int value to a Int4x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x4(int v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a single bool value to a Int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(bool v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a Bool4x4 matrix to a Int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Bool4x4 v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a single uint value to a Int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(uint v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a UInt4x4 matrix to a Int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(UInt4x4 v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a single float value to a Int4x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(SoftFloat v) { return new Int4x4(v); }

        /// <summary>Explicitly converts a Float4x4 matrix to a Int4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x4(Float4X4 v) { return new Int4x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator * (int lhs, Int4x4 rhs) { return new Int4x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (int lhs, Int4x4 rhs) { return new Int4x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (int lhs, Int4x4 rhs) { return new Int4x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator / (int lhs, Int4x4 rhs) { return new Int4x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator % (int lhs, Int4x4 rhs) { return new Int4x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ++ (Int4x4 val) { return new Int4x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator -- (Int4x4 val) { return new Int4x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator < (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator <= (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator > (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator >= (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator - (Int4x4 val) { return new Int4x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator + (Int4x4 val) { return new Int4x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int4x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator << (Int4x4 x, int n) { return new Int4x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int4x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator >> (Int4x4 x, int n) { return new Int4x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator == (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (Int4x4 lhs, Int4x4 rhs) { return new Bool4x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (Int4x4 lhs, int rhs) { return new Bool4x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x4 operator != (int lhs, Int4x4 rhs) { return new Bool4x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ~ (Int4x4 val) { return new Int4x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator & (int lhs, Int4x4 rhs) { return new Int4x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator | (int lhs, Int4x4 rhs) { return new Int4x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int4x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (Int4x4 lhs, Int4x4 rhs) { return new Int4x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int4x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (Int4x4 lhs, int rhs) { return new Int4x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 operator ^ (int lhs, Int4x4 rhs) { return new Int4x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the Int4 element at a specified index.</summary>
        unsafe public ref Int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Int4x4* array = &this) { return ref ((Int4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int4x4 is equal to a given Int4x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int4x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Int4x4 is equal to a given Int4x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int4x4)o); }


        /// <summary>Returns a hash code for the Int4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int4x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z, c0.w, c1.w, c2.w, c3.w);
        }

        /// <summary>Returns a string representation of the Int4x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int4x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11},  {12}, {13}, {14}, {15})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider), c3.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int4x4 matrix constructed from four Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(Int4 c0, Int4 c1, Int4 c2, Int4 c3) { return new Int4x4(c0, c1, c2, c3); }

        /// <summary>Returns a Int4x4 matrix constructed from from 16 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13,
                                    int m20, int m21, int m22, int m23,
                                    int m30, int m31, int m32, int m33)
        {
            return new Int4x4(m00, m01, m02, m03,
                              m10, m11, m12, m13,
                              m20, m21, m22, m23,
                              m30, m31, m32, m33);
        }

        /// <summary>Returns a Int4x4 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(int v) { return new Int4x4(v); }

        /// <summary>Returns a Int4x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(bool v) { return new Int4x4(v); }

        /// <summary>Return a Int4x4 matrix constructed from a Bool4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(Bool4x4 v) { return new Int4x4(v); }

        /// <summary>Returns a Int4x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(uint v) { return new Int4x4(v); }

        /// <summary>Return a Int4x4 matrix constructed from a UInt4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(UInt4x4 v) { return new Int4x4(v); }

        /// <summary>Returns a Int4x4 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(SoftFloat v) { return new Int4x4(v); }

        /// <summary>Return a Int4x4 matrix constructed from a Float4x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Int4x4(Float4X4 v) { return new Int4x4(v); }

        /// <summary>Return the Int4x4 transpose of a Int4x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x4 Transpose(Int4x4 v)
        {
            return Int4x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w,
                v.c3.x, v.c3.y, v.c3.z, v.c3.w);
        }

        /// <summary>Returns the determinant of a Int4x4 matrix.</summary>
        public static int Determinant(Int4x4 m)
        {
            Int4 c0 = m.c0;
            Int4 c1 = m.c1;
            Int4 c2 = m.c2;
            Int4 c3 = m.c3;

            int m00 = c1.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c1.z * c3.w - c1.w * c3.z) + c3.y * (c1.z * c2.w - c1.w * c2.z);
            int m01 = c0.y * (c2.z * c3.w - c2.w * c3.z) - c2.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c2.w - c0.w * c2.z);
            int m02 = c0.y * (c1.z * c3.w - c1.w * c3.z) - c1.y * (c0.z * c3.w - c0.w * c3.z) + c3.y * (c0.z * c1.w - c0.w * c1.z);
            int m03 = c0.y * (c1.z * c2.w - c1.w * c2.z) - c1.y * (c0.z * c2.w - c0.w * c2.z) + c2.y * (c0.z * c1.w - c0.w * c1.z);

            return c0.x * m00 - c1.x * m01 + c2.x * m02 - c3.x * m03;
        }

        /// <summary>Returns a uint hash code of a Int4x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int4x4 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0x5D1B165Bu, 0x87096CD7u, 0x4C7F6DD1u, 0x4822A3E9u) +
                        AsUInt(v.c1) * UInt4(0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du, 0x614DA60Du) +
                        AsUInt(v.c2) * UInt4(0x5BA2C50Bu, 0x8C455ACBu, 0xCD266C89u, 0xF1852A33u) +
                        AsUInt(v.c3) * UInt4(0x77E35E77u, 0x863E3729u, 0xE191B035u, 0x68586FAFu)) + 0xD4DFF6D3u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Int4x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Int4x4 v)
        {
            return (AsUInt(v.c0) * UInt4(0xCB634F4Du, 0x9B13B92Du, 0x4ABF0813u, 0x86068063u) +
                    AsUInt(v.c1) * UInt4(0xD75513F9u, 0x5AB3E8CDu, 0x676E8407u, 0xB36DE767u) +
                    AsUInt(v.c2) * UInt4(0x6FCA387Du, 0xAF0F3103u, 0xE4A056C7u, 0x841D8225u) +
                    AsUInt(v.c3) * UInt4(0xC9393C7Du, 0xD42EAFA3u, 0xD9AFD06Du, 0x97A65421u)) + 0x7809205Fu;
        }

    }
}
