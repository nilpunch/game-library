
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Int2x2 : IEquatable<Int2x2>, IFormattable
    {
        public Int2 c0;
        public Int2 c1;

        /// <summary>Int2x2 identity transform.</summary>
        public static readonly Int2x2 identity = new Int2x2(1, 0,   0, 1);

        /// <summary>Int2x2 zero value.</summary>
        public static readonly Int2x2 zero;

        /// <summary>Constructs a Int2x2 matrix from two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(Int2 c0, Int2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Int2x2 matrix from 4 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(int m00, int m01,
                      int m10, int m11)
        {
            c0 = new Int2(m00, m10);
            c1 = new Int2(m01, m11);
        }

        /// <summary>Constructs a Int2x2 matrix from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(int v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a Int2x2 matrix from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(bool v)
        {
            c0 = Math.Select(new Int2(0), new Int2(1), v);
            c1 = Math.Select(new Int2(0), new Int2(1), v);
        }

        /// <summary>Constructs a Int2x2 matrix from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(Bool2x2 v)
        {
            c0 = Math.Select(new Int2(0), new Int2(1), v.c0);
            c1 = Math.Select(new Int2(0), new Int2(1), v.c1);
        }

        /// <summary>Constructs a Int2x2 matrix from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(uint v)
        {
            c0 = (Int2)v;
            c1 = (Int2)v;
        }

        /// <summary>Constructs a Int2x2 matrix from a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(UInt2x2 v)
        {
            c0 = (Int2)v.c0;
            c1 = (Int2)v.c1;
        }

        /// <summary>Constructs a Int2x2 matrix from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(SoftFloat v)
        {
            c0 = (Int2)(int)v;
            c1 = (Int2)(int)v;
        }

        /// <summary>Constructs a Int2x2 matrix from a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2x2(Float2X2 v)
        {
            c0 = (Int2)v.c0;
            c1 = (Int2)v.c1;
        }


        /// <summary>Implicitly converts a single int value to a Int2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int2x2(int v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a single bool value to a Int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(bool v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a Bool2x2 matrix to a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(Bool2x2 v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a single uint value to a Int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(uint v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a UInt2x2 matrix to a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(UInt2x2 v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a single float value to a Int2x2 matrix by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(SoftFloat v) { return new Int2x2(v); }

        /// <summary>Explicitly converts a Float2x2 matrix to a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2x2(Float2X2 v) { return new Int2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator * (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator * (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator * (int lhs, Int2x2 rhs) { return new Int2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator + (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator + (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator + (int lhs, Int2x2 rhs) { return new Int2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator - (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator - (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator - (int lhs, Int2x2 rhs) { return new Int2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator / (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator / (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator / (int lhs, Int2x2 rhs) { return new Int2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator % (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator % (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator % (int lhs, Int2x2 rhs) { return new Int2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator ++ (Int2x2 val) { return new Int2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator -- (Int2x2 val) { return new Int2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator - (Int2x2 val) { return new Int2x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator + (Int2x2 val) { return new Int2x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator << (Int2x2 x, int n) { return new Int2x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator >> (Int2x2 x, int n) { return new Int2x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (Int2x2 lhs, Int2x2 rhs) { return new Bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (Int2x2 lhs, int rhs) { return new Bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (int lhs, Int2x2 rhs) { return new Bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator ~ (Int2x2 val) { return new Int2x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator & (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator & (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator & (int lhs, Int2x2 rhs) { return new Int2x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator | (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator | (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator | (int lhs, Int2x2 rhs) { return new Int2x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator ^ (Int2x2 lhs, Int2x2 rhs) { return new Int2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int2x2 matrix and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator ^ (Int2x2 lhs, int rhs) { return new Int2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 operator ^ (int lhs, Int2x2 rhs) { return new Int2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the Int2 element at a specified index.</summary>
        unsafe public ref Int2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Int2x2* array = &this) { return ref ((Int2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Int2x2 is equal to a given Int2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the Int2x2 is equal to a given Int2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int2x2)o); }


        /// <summary>Returns a hash code for the Int2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the Int2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int2x2 matrix constructed from two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(Int2 c0, Int2 c1) { return new Int2x2(c0, c1); }

        /// <summary>Returns a Int2x2 matrix constructed from from 4 int values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(int m00, int m01,
                                    int m10, int m11)
        {
            return new Int2x2(m00, m01,
                              m10, m11);
        }

        /// <summary>Returns a Int2x2 matrix constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(int v) { return new Int2x2(v); }

        /// <summary>Returns a Int2x2 matrix constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(bool v) { return new Int2x2(v); }

        /// <summary>Return a Int2x2 matrix constructed from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(Bool2x2 v) { return new Int2x2(v); }

        /// <summary>Returns a Int2x2 matrix constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(uint v) { return new Int2x2(v); }

        /// <summary>Return a Int2x2 matrix constructed from a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(UInt2x2 v) { return new Int2x2(v); }

        /// <summary>Returns a Int2x2 matrix constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(SoftFloat v) { return new Int2x2(v); }

        /// <summary>Return a Int2x2 matrix constructed from a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Int2x2(Float2X2 v) { return new Int2x2(v); }


        /// <summary>Return the Int2x2 transpose of a Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2x2 Transpose(Int2x2 v)
        {
            return Int2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns the determinant of a Int2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Determinant(Int2x2 m)
        {
            int a = m.c0.x;
            int b = m.c1.x;
            int c = m.c0.y;
            int d = m.c1.y;

            return a * d - b * c;
        }

        /// <summary>Returns a uint hash code of a Int2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int2x2 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt2(0xE191B035u, 0x68586FAFu) +
                        AsUInt(v.c1) * UInt2(0xD4DFF6D3u, 0xCB634F4Du)) + 0x9B13B92Du;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Int2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Int2x2 v)
        {
            return (AsUInt(v.c0) * UInt2(0x4ABF0813u, 0x86068063u) +
                    AsUInt(v.c1) * UInt2(0xD75513F9u, 0x5AB3E8CDu)) + 0x676E8407u;
        }

    }
}
