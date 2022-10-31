
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt4x2 : IEquatable<UInt4x2>, IFormattable
    {
        public UInt4 c0;
        public UInt4 c1;

        /// <summary>UInt4x2 zero value.</summary>
        public static readonly UInt4x2 zero;

        /// <summary>Constructs a UInt4x2 matrix from two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(UInt4 c0, UInt4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a UInt4x2 matrix from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(uint m00, uint m01,
                       uint m10, uint m11,
                       uint m20, uint m21,
                       uint m30, uint m31)
        {
            c0 = new UInt4(m00, m10, m20, m30);
            c1 = new UInt4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a UInt4x2 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(uint v)
        {
            c0 = v;
            c1 = v;
        }

        /// <summary>Constructs a UInt4x2 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(bool v)
        {
            c0 = Math.Select(new UInt4(0u), new UInt4(1u), v);
            c1 = Math.Select(new UInt4(0u), new UInt4(1u), v);
        }

        /// <summary>Constructs a UInt4x2 matrix from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(Bool4x2 v)
        {
            c0 = Math.Select(new UInt4(0u), new UInt4(1u), v.c0);
            c1 = Math.Select(new UInt4(0u), new UInt4(1u), v.c1);
        }

        /// <summary>Constructs a UInt4x2 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(int v)
        {
            c0 = (UInt4)v;
            c1 = (UInt4)v;
        }

        /// <summary>Constructs a UInt4x2 matrix from a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(Int4x2 v)
        {
            c0 = (UInt4)v.c0;
            c1 = (UInt4)v.c1;
        }

        /// <summary>Constructs a UInt4x2 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(SoftFloat v)
        {
            c0 = new UInt4(v);
            c1 = new UInt4(v);
        }

        /// <summary>Constructs a UInt4x2 matrix from a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x2(Float4x2 v)
        {
            c0 = (UInt4)v.c0;
            c1 = (UInt4)v.c1;
        }


        /// <summary>Implicitly converts a single uint value to a UInt4x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x2(uint v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a single bool value to a UInt4x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(bool v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a Bool4x2 matrix to a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(Bool4x2 v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a single int value to a UInt4x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(int v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a Int4x2 matrix to a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(Int4x2 v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a single float value to a UInt4x2 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(SoftFloat v) { return new UInt4x2(v); }

        /// <summary>Explicitly converts a Float4x2 matrix to a UInt4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x2(Float4x2 v) { return new UInt4x2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 * rhs, lhs.c1 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator * (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs * rhs.c0, lhs * rhs.c1); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 + rhs, lhs.c1 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs + rhs.c0, lhs + rhs.c1); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 - rhs, lhs.c1 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs - rhs.c0, lhs - rhs.c1); }


        /// <summary>Returns the result of a componentwise division operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1); }

        /// <summary>Returns the result of a componentwise division operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 / rhs, lhs.c1 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator / (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs / rhs.c0, lhs / rhs.c1); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 % rhs, lhs.c1 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator % (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs % rhs.c0, lhs % rhs.c1); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ++ (UInt4x2 val) { return new UInt4x2 (++val.c0, ++val.c1); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator -- (UInt4x2 val) { return new UInt4x2 (--val.c0, --val.c1); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 < rhs, lhs.c1 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator < (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs < rhs.c0, lhs < rhs.c1); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 <= rhs, lhs.c1 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator <= (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs <= rhs.c0, lhs <= rhs.c1); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 > rhs, lhs.c1 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator > (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs > rhs.c0, lhs > rhs.c1); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 >= rhs, lhs.c1 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator >= (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs >= rhs.c0, lhs >= rhs.c1); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator - (UInt4x2 val) { return new UInt4x2 (-val.c0, -val.c1); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator + (UInt4x2 val) { return new UInt4x2 (+val.c0, +val.c1); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator << (UInt4x2 x, int n) { return new UInt4x2 (x.c0 << n, x.c1 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt4x2 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator >> (UInt4x2 x, int n) { return new UInt4x2 (x.c0 >> n, x.c1 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 == rhs, lhs.c1 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator == (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs == rhs.c0, lhs == rhs.c1); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (UInt4x2 lhs, UInt4x2 rhs) { return new Bool4x2 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (UInt4x2 lhs, uint rhs) { return new Bool4x2 (lhs.c0 != rhs, lhs.c1 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator != (uint lhs, UInt4x2 rhs) { return new Bool4x2 (lhs != rhs.c0, lhs != rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ~ (UInt4x2 val) { return new UInt4x2 (~val.c0, ~val.c1); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 & rhs, lhs.c1 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator & (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs & rhs.c0, lhs & rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 | rhs, lhs.c1 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator | (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs | rhs.c0, lhs | rhs.c1); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (UInt4x2 lhs, UInt4x2 rhs) { return new UInt4x2 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt4x2 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (UInt4x2 lhs, uint rhs) { return new UInt4x2 (lhs.c0 ^ rhs, lhs.c1 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 operator ^ (uint lhs, UInt4x2 rhs) { return new UInt4x2 (lhs ^ rhs.c0, lhs ^ rhs.c1); }



        /// <summary>Returns the UInt4 element at a specified index.</summary>
        unsafe public ref UInt4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (UInt4x2* array = &this) { return ref ((UInt4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the UInt4x2 is equal to a given UInt4x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt4x2 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1); }

        /// <summary>Returns true if the UInt4x2 is equal to a given UInt4x2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt4x2)o); }


        /// <summary>Returns a hash code for the UInt4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z, c1.z, c0.w, c1.w);
        }

        /// <summary>Returns a string representation of the UInt4x2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt4x2 matrix constructed from two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(UInt4 c0, UInt4 c1) { return new UInt4x2(c0, c1); }

        /// <summary>Returns a UInt4x2 matrix constructed from from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(uint m00, uint m01,
                                      uint m10, uint m11,
                                      uint m20, uint m21,
                                      uint m30, uint m31)
        {
            return new UInt4x2(m00, m01,
                               m10, m11,
                               m20, m21,
                               m30, m31);
        }

        /// <summary>Returns a UInt4x2 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(uint v) { return new UInt4x2(v); }

        /// <summary>Returns a UInt4x2 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(bool v) { return new UInt4x2(v); }

        /// <summary>Return a UInt4x2 matrix constructed from a Bool4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(Bool4x2 v) { return new UInt4x2(v); }

        /// <summary>Returns a UInt4x2 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(int v) { return new UInt4x2(v); }

        /// <summary>Return a UInt4x2 matrix constructed from a Int4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(Int4x2 v) { return new UInt4x2(v); }

        /// <summary>Returns a UInt4x2 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(SoftFloat v) { return new UInt4x2(v); }

        /// <summary>Return a UInt4x2 matrix constructed from a Float4x2 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 UInt4x2(Float4x2 v) { return new UInt4x2(v); }

        /// <summary>Return the UInt2x4 transpose of a UInt4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 Transpose(UInt4x2 v)
        {
            return UInt2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a UInt4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt4x2 v)
        {
            return SumComponents(v.c0 * UInt4(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u, 0x94DDD769u) +
                        v.c1 * UInt4(0xA1E92D39u, 0x4583C801u, 0x9536A0F5u, 0xAF816615u)) + 0x9AF8D62Du;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a UInt4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(UInt4x2 v)
        {
            return (v.c0 * UInt4(0xE3600729u, 0x5F17300Du, 0x670D6809u, 0x7AF32C49u) +
                    v.c1 * UInt4(0xAE131389u, 0x5D1B165Bu, 0x87096CD7u, 0x4C7F6DD1u)) + 0x4822A3E9u;
        }

    }
}
