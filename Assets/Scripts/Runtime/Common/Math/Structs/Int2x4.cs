
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int2x4 : IEquatable<Int2x4>, IFormattable
    {
        public Int2 c0;
        public Int2 c1;
        public Int2 c2;
        public Int2 c3;

        /// <summary>Int2x4 zero value.</summary>
        public static readonly Int2x4 zero;

        /// <summary>Constructs a Int2x4 matrix from four Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(Int2 c0, Int2 c1, Int2 c2, Int2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Int2x4 matrix from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(int m00, int m01, int m02, int m03,
                      int m10, int m11, int m12, int m13)
        {
            c0 = new Int2(m00, m10);
            c1 = new Int2(m01, m11);
            c2 = new Int2(m02, m12);
            c3 = new Int2(m03, m13);
        }

        /// <summary>Constructs a Int2x4 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a Int2x4 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(bool v)
        {
            c0 = Math.Select(new Int2(0), new Int2(1), v);
            c1 = Math.Select(new Int2(0), new Int2(1), v);
            c2 = Math.Select(new Int2(0), new Int2(1), v);
            c3 = Math.Select(new Int2(0), new Int2(1), v);
        }

        /// <summary>Constructs a Int2x4 matrix from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(Bool2x4 v)
        {
            c0 = Math.Select(new Int2(0), new Int2(1), v.c0);
            c1 = Math.Select(new Int2(0), new Int2(1), v.c1);
            c2 = Math.Select(new Int2(0), new Int2(1), v.c2);
            c3 = Math.Select(new Int2(0), new Int2(1), v.c3);
        }

        /// <summary>Constructs a Int2x4 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(uint v)
        {
            c0 = (Int2)v;
            c1 = (Int2)v;
            c2 = (Int2)v;
            c3 = (Int2)v;
        }

        /// <summary>Constructs a Int2x4 matrix from a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(UInt2x4 v)
        {
            c0 = (Int2)v.c0;
            c1 = (Int2)v.c1;
            c2 = (Int2)v.c2;
            c3 = (Int2)v.c3;
        }

        /// <summary>Constructs a Int2x4 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(SoftFloat v)
        {
            c0 = new Int2(v);
            c1 = new Int2(v);
            c2 = new Int2(v);
            c3 = new Int2(v);
        }

        /// <summary>Constructs a Int2x4 matrix from a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x4(Float2x4 v)
        {
            c0 = (Int2)v.c0;
            c1 = (Int2)v.c1;
            c2 = (Int2)v.c2;
            c3 = (Int2)v.c3;
        }


        /// <summary>Implicitly converts a single int value to a Int2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int2x4(int v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a single bool value to a Int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(bool v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a Bool2x4 matrix to a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Bool2x4 v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a single uint value to a Int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(uint v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a UInt2x4 matrix to a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(UInt2x4 v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a single float value to a Int2x4 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(SoftFloat v) { return new Int2x4(v); }

        /// <summary>Explicitly converts a Float2x4 matrix to a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x4(Float2x4 v) { return new Int2x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator * (int lhs, Int2x4 rhs) { return new Int2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (int lhs, Int2x4 rhs) { return new Int2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (int lhs, Int2x4 rhs) { return new Int2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator / (int lhs, Int2x4 rhs) { return new Int2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator % (int lhs, Int2x4 rhs) { return new Int2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ++ (Int2x4 val) { return new Int2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator -- (Int2x4 val) { return new Int2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator - (Int2x4 val) { return new Int2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator + (Int2x4 val) { return new Int2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator << (Int2x4 x, int n) { return new Int2x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator >> (Int2x4 x, int n) { return new Int2x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (Int2x4 lhs, Int2x4 rhs) { return new Bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (Int2x4 lhs, int rhs) { return new Bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (int lhs, Int2x4 rhs) { return new Bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ~ (Int2x4 val) { return new Int2x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator & (int lhs, Int2x4 rhs) { return new Int2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator | (int lhs, Int2x4 rhs) { return new Int2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (Int2x4 lhs, Int2x4 rhs) { return new Int2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int2x4 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (Int2x4 lhs, int rhs) { return new Int2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 operator ^ (int lhs, Int2x4 rhs) { return new Int2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the Int2 element at a specified index.</summary>
        unsafe public ref Int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Int2x4* array = &this) { return ref ((Int2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int2x4 is equal to a given Int2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Int2x4 is equal to a given Int2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int2x4)o); }


        /// <summary>Returns a hash code for the Int2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the Int2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int2x4 matrix constructed from four Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(Int2 c0, Int2 c1, Int2 c2, Int2 c3) { return new Int2x4(c0, c1, c2, c3); }

        /// <summary>Returns a Int2x4 matrix constructed from from 8 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(int m00, int m01, int m02, int m03,
                                    int m10, int m11, int m12, int m13)
        {
            return new Int2x4(m00, m01, m02, m03,
                              m10, m11, m12, m13);
        }

        /// <summary>Returns a Int2x4 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(int v) { return new Int2x4(v); }

        /// <summary>Returns a Int2x4 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(bool v) { return new Int2x4(v); }

        /// <summary>Return a Int2x4 matrix constructed from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(Bool2x4 v) { return new Int2x4(v); }

        /// <summary>Returns a Int2x4 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(uint v) { return new Int2x4(v); }

        /// <summary>Return a Int2x4 matrix constructed from a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(UInt2x4 v) { return new Int2x4(v); }

        /// <summary>Returns a Int2x4 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(SoftFloat v) { return new Int2x4(v); }

        /// <summary>Return a Int2x4 matrix constructed from a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x4 Int2x4(Float2x4 v) { return new Int2x4(v); }

        /// <summary>Return the Int4x2 transpose of a Int2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x2 Transpose(Int2x4 v)
        {
            return Int4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a Int2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int2x4 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt2(0x7AA07CD3u, 0xAF642BA9u) +
                        AsUInt(v.c1) * UInt2(0xA8F2213Bu, 0x9F3FDC37u) +
                        AsUInt(v.c2) * UInt2(0xAC60D0C3u, 0x9263662Fu) +
                        AsUInt(v.c3) * UInt2(0xE69626FFu, 0xBD010EEBu)) + 0x9CEDE1D1u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Int2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Int2x4 v)
        {
            return (AsUInt(v.c0) * UInt2(0x43BE0B51u, 0xAF836EE1u) +
                    AsUInt(v.c1) * UInt2(0xB130C137u, 0x54834775u) +
                    AsUInt(v.c2) * UInt2(0x7C022221u, 0xA2D00EDFu) +
                    AsUInt(v.c3) * UInt2(0xA8977779u, 0x9F1C739Bu)) + 0x4B1BD187u;
        }

    }
}
