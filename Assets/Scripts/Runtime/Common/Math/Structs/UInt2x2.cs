
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt2x2 : IEquatable<UInt2x2>, IFormattable
    {
        public UInt2 c0;
        public UInt2 c1;

        /// <summary>UInt2x2 identity transform.</summary>
        public static readonly UInt2x2 identity = new UInt2x2(1u, 0u,   0u, 1u);

        /// <summary>UInt2x2 zero value.</summary>
        public static readonly UInt2x2 zero;

        /// <summary>Constructs a UInt2x2 matrix from two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(UInt2 c0, UInt2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a UInt2x2 matrix from 4 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(uint m00, uint m01,
                       uint m10, uint m11)
        {
            c0 = new UInt2(m00, m10);
            c1 = new UInt2(m01, m11);
        }

        /// <summary>Constructs a UInt2x2 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(uint v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a UInt2x2 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(bool v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v);
        }

        /// <summary>Constructs a UInt2x2 matrix from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(Bool2x2 v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v.c0);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v.c1);
        }

        /// <summary>Constructs a UInt2x2 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(int v)
        {
            c0 = (UInt2)v;
            c1 = (UInt2)v;
        }

        /// <summary>Constructs a UInt2x2 matrix from a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(Int2x2 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
        }

        /// <summary>Constructs a UInt2x2 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(SoftFloat v)
        {
            c0 = (UInt2)(int)v;
            c1 = (UInt2)(int)v;
        }

        /// <summary>Constructs a UInt2x2 matrix from a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x2(Float2X2 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
        }


        /// <summary>Implicitly converts a single uint value to a UInt2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt2x2(uint v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a single bool value to a UInt2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(bool v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a Bool2x2 matrix to a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(Bool2x2 v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a single int value to a UInt2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(int v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a Int2x2 matrix to a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(Int2x2 v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a single float value to a UInt2x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(SoftFloat v) { return new UInt2x2(v); }

        /// <summary>Explicitly converts a Float2x2 matrix to a UInt2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x2(Float2X2 v) { return new UInt2x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator * (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator * (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator * (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator + (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator + (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator + (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator - (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator - (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator - (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator / (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator / (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator / (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator % (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator % (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator % (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator ++ (UInt2x2 val) { return new UInt2x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator -- (UInt2x2 val) { return new UInt2x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator < (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator <= (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator > (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator >= (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator - (UInt2x2 val) { return new UInt2x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator + (UInt2x2 val) { return new UInt2x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator << (UInt2x2 x, int n) { return new UInt2x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt2x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator >> (UInt2x2 x, int n) { return new UInt2x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator == (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (UInt2x2 lhs, UInt2x2 rhs) { return new Bool2x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (UInt2x2 lhs, uint rhs) { return new Bool2x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator != (uint lhs, UInt2x2 rhs) { return new Bool2x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator ~ (UInt2x2 val) { return new UInt2x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator & (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator & (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator & (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator | (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator | (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator | (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator ^ (UInt2x2 lhs, UInt2x2 rhs) { return new UInt2x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt2x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator ^ (UInt2x2 lhs, uint rhs) { return new UInt2x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 operator ^ (uint lhs, UInt2x2 rhs) { return new UInt2x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the UInt2 element at a specified index.</summary>
        unsafe public ref UInt2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (UInt2x2* array = &this) { return ref ((UInt2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the UInt2x2 is equal to a given UInt2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt2x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the UInt2x2 is equal to a given UInt2x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt2x2)o); }


        /// <summary>Returns a hash code for the UInt2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt2x2({0}, {1},  {2}, {3})", c0.x, c1.x, c0.y, c1.y);
        }

        /// <summary>Returns a string representation of the UInt2x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt2x2({0}, {1},  {2}, {3})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt2x2 matrix constructed from two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(UInt2 c0, UInt2 c1) { return new UInt2x2(c0, c1); }

        /// <summary>Returns a UInt2x2 matrix constructed from from 4 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(uint m00, uint m01,
                                      uint m10, uint m11)
        {
            return new UInt2x2(m00, m01,
                               m10, m11);
        }

        /// <summary>Returns a UInt2x2 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(uint v) { return new UInt2x2(v); }

        /// <summary>Returns a UInt2x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(bool v) { return new UInt2x2(v); }

        /// <summary>Return a UInt2x2 matrix constructed from a Bool2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(Bool2x2 v) { return new UInt2x2(v); }

        /// <summary>Returns a UInt2x2 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(int v) { return new UInt2x2(v); }

        /// <summary>Return a UInt2x2 matrix constructed from a Int2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(Int2x2 v) { return new UInt2x2(v); }

        /// <summary>Returns a UInt2x2 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(SoftFloat v) { return new UInt2x2(v); }

        /// <summary>Return a UInt2x2 matrix constructed from a Float2x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 UInt2x2(Float2X2 v) { return new UInt2x2(v); }

        /// <summary>Return the UInt2x2 transpose of a UInt2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x2 Transpose(UInt2x2 v)
        {
            return UInt2x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y);
        }

        /// <summary>Returns a uint hash code of a UInt2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt2x2 v)
        {
            return SumComponents(v.c0 * UInt2(0xB36DE767u, 0x6FCA387Du) +
                        v.c1 * UInt2(0xAF0F3103u, 0xE4A056C7u)) + 0x841D8225u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a UInt2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(UInt2x2 v)
        {
            return (v.c0 * UInt2(0xC9393C7Du, 0xD42EAFA3u) +
                    v.c1 * UInt2(0xD9AFD06Du, 0x97A65421u)) + 0x7809205Fu;
        }

    }
}
