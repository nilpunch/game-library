
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int4x3 : IEquatable<Int4x3>, IFormattable
    {
        public Int4 c0;
        public Int4 c1;
        public Int4 c2;

        /// <summary>Int4x3 zero value.</summary>
        public static readonly Int4x3 zero;

        /// <summary>Constructs a Int4x3 matrix from three Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(Int4 c0, Int4 c1, Int4 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Int4x3 matrix from 12 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(int m00, int m01, int m02,
                      int m10, int m11, int m12,
                      int m20, int m21, int m22,
                      int m30, int m31, int m32)
        {
            c0 = new Int4(m00, m10, m20, m30);
            c1 = new Int4(m01, m11, m21, m31);
            c2 = new Int4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a Int4x3 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Int4x3 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(bool v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v);
            c1 = Math.Select(new Int4(0), new Int4(1), v);
            c2 = Math.Select(new Int4(0), new Int4(1), v);
        }

        /// <summary>Constructs a Int4x3 matrix from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(Bool4x3 v)
        {
            c0 = Math.Select(new Int4(0), new Int4(1), v.c0);
            c1 = Math.Select(new Int4(0), new Int4(1), v.c1);
            c2 = Math.Select(new Int4(0), new Int4(1), v.c2);
        }

        /// <summary>Constructs a Int4x3 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(uint v)
        {
            c0 = (Int4)v;
            c1 = (Int4)v;
            c2 = (Int4)v;
        }

        /// <summary>Constructs a Int4x3 matrix from a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(UInt4x3 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
            c2 = (Int4)v.c2;
        }

        /// <summary>Constructs a Int4x3 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(SoftFloat v)
        {
            c0 = (Int4)v;
            c1 = (Int4)v;
            c2 = (Int4)v;
        }

        /// <summary>Constructs a Int4x3 matrix from a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4x3(Float4x3 v)
        {
            c0 = (Int4)v.c0;
            c1 = (Int4)v.c1;
            c2 = (Int4)v.c2;
        }


        /// <summary>Implicitly converts a single int value to a Int4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4x3(int v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a single bool value to a Int4x3 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(bool v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a Bool4x3 matrix to a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(Bool4x3 v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a single uint value to a Int4x3 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(uint v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a UInt4x3 matrix to a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(UInt4x3 v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a single float value to a Int4x3 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(SoftFloat v) { return new Int4x3(v); }

        /// <summary>Explicitly converts a Float4x3 matrix to a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4x3(Float4x3 v) { return new Int4x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator * (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator * (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator * (int lhs, Int4x3 rhs) { return new Int4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator + (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator + (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator + (int lhs, Int4x3 rhs) { return new Int4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator - (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator - (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator - (int lhs, Int4x3 rhs) { return new Int4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator / (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator / (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator / (int lhs, Int4x3 rhs) { return new Int4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator % (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator % (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator % (int lhs, Int4x3 rhs) { return new Int4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator ++ (Int4x3 val) { return new Int4x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator -- (Int4x3 val) { return new Int4x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator - (Int4x3 val) { return new Int4x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator + (Int4x3 val) { return new Int4x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int4x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator << (Int4x3 x, int n) { return new Int4x3 (x.c0 << n, x.c1 << n, x.c2 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int4x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator >> (Int4x3 x, int n) { return new Int4x3 (x.c0 >> n, x.c1 >> n, x.c2 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Int4x3 lhs, Int4x3 rhs) { return new Bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Int4x3 lhs, int rhs) { return new Bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (int lhs, Int4x3 rhs) { return new Bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator ~ (Int4x3 val) { return new Int4x3 (~val.c0, ~val.c1, ~val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator & (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator & (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator & (int lhs, Int4x3 rhs) { return new Int4x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator | (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator | (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator | (int lhs, Int4x3 rhs) { return new Int4x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator ^ (Int4x3 lhs, Int4x3 rhs) { return new Int4x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int4x3 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator ^ (Int4x3 lhs, int rhs) { return new Int4x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 operator ^ (int lhs, Int4x3 rhs) { return new Int4x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the Int4 element at a specified index.</summary>
        unsafe public ref Int4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (Int4x3* array = &this) { return ref ((Int4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int4x3 is equal to a given Int4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the Int4x3 is equal to a given Int4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int4x3)o); }


        /// <summary>Returns a hash code for the Int4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        /// <summary>Returns a string representation of the Int4x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int4x3 matrix constructed from three Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(Int4 c0, Int4 c1, Int4 c2) { return new Int4x3(c0, c1, c2); }

        /// <summary>Returns a Int4x3 matrix constructed from from 12 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(int m00, int m01, int m02,
                                    int m10, int m11, int m12,
                                    int m20, int m21, int m22,
                                    int m30, int m31, int m32)
        {
            return new Int4x3(m00, m01, m02,
                              m10, m11, m12,
                              m20, m21, m22,
                              m30, m31, m32);
        }

        /// <summary>Returns a Int4x3 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(int v) { return new Int4x3(v); }

        /// <summary>Returns a Int4x3 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(bool v) { return new Int4x3(v); }

        /// <summary>Return a Int4x3 matrix constructed from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(Bool4x3 v) { return new Int4x3(v); }

        /// <summary>Returns a Int4x3 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(uint v) { return new Int4x3(v); }

        /// <summary>Return a Int4x3 matrix constructed from a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(UInt4x3 v) { return new Int4x3(v); }

        /// <summary>Returns a Int4x3 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(SoftFloat v) { return new Int4x3(v); }

        /// <summary>Return a Int4x3 matrix constructed from a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4x3 Int4x3(Float4x3 v) { return new Int4x3(v); }

        /// <summary>Return the Int3x4 transpose of a Int4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3x4 Transpose(Int4x3 v)
        {
            return Int3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a Int4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int4x3 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt4(0x69B60C81u, 0xE0EB6C25u, 0xF648BEABu, 0x6BDB2B07u) +
                        AsUInt(v.c1) * UInt4(0xEF63C699u, 0x9001903Fu, 0xA895B9CDu, 0x9D23B201u) +
                        AsUInt(v.c2) * UInt4(0x4B01D3E1u, 0x7461CA0Du, 0x79725379u, 0xD6258E5Bu)) + 0xEE390C97u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Int4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Int4x3 v)
        {
            return (AsUInt(v.c0) * UInt4(0x9C8A2F05u, 0x4DDC6509u, 0x7CF083CBu, 0x5C4D6CEDu) +
                    AsUInt(v.c1) * UInt4(0xF9137117u, 0xE857DCE1u, 0xF62213C5u, 0x9CDAA959u) +
                    AsUInt(v.c2) * UInt4(0xAA269ABFu, 0xD54BA36Fu, 0xFD0847B9u, 0x8189A683u)) + 0xB139D651u;
        }

    }
}
