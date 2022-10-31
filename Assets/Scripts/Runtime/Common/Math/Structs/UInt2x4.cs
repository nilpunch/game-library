
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt2x4 : IEquatable<UInt2x4>, IFormattable
    {
        public UInt2 c0;
        public UInt2 c1;
        public UInt2 c2;
        public UInt2 c3;

        /// <summary>UInt2x4 zero value.</summary>
        public static readonly UInt2x4 zero;

        /// <summary>Constructs a UInt2x4 matrix from four UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(UInt2 c0, UInt2 c1, UInt2 c2, UInt2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a UInt2x4 matrix from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(uint m00, uint m01, uint m02, uint m03,
                       uint m10, uint m11, uint m12, uint m13)
        {
            c0 = new UInt2(m00, m10);
            c1 = new UInt2(m01, m11);
            c2 = new UInt2(m02, m12);
            c3 = new UInt2(m03, m13);
        }

        /// <summary>Constructs a UInt2x4 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a UInt2x4 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(bool v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c2 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c3 = Math.Select(new UInt2(0u), new UInt2(1u), v);
        }

        /// <summary>Constructs a UInt2x4 matrix from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(Bool2x4 v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v.c0);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v.c1);
            c2 = Math.Select(new UInt2(0u), new UInt2(1u), v.c2);
            c3 = Math.Select(new UInt2(0u), new UInt2(1u), v.c3);
        }

        /// <summary>Constructs a UInt2x4 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(int v)
        {
            c0 = (UInt2)v;
            c1 = (UInt2)v;
            c2 = (UInt2)v;
            c3 = (UInt2)v;
        }

        /// <summary>Constructs a UInt2x4 matrix from a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(Int2x4 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
            c2 = (UInt2)v.c2;
            c3 = (UInt2)v.c3;
        }

        /// <summary>Constructs a UInt2x4 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(SoftFloat v)
        {
            c0 = (UInt2)(int)v;
            c1 = (UInt2)(int)v;
            c2 = (UInt2)(int)v;
            c3 = (UInt2)(int)v;
        }

        /// <summary>Constructs a UInt2x4 matrix from a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x4(Float2x4 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
            c2 = (UInt2)v.c2;
            c3 = (UInt2)v.c3;
        }


        /// <summary>Implicitly converts a single uint value to a UInt2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt2x4(uint v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a single bool value to a UInt2x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(bool v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a Bool2x4 matrix to a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(Bool2x4 v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a single int value to a UInt2x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(int v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a Int2x4 matrix to a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(Int2x4 v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a single float value to a UInt2x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(SoftFloat v) { return new UInt2x4(v); }

        /// <summary>Explicitly converts a Float2x4 matrix to a UInt2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x4(Float2x4 v) { return new UInt2x4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator * (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3); }


        /// <summary>Returns the result of a componentwise division operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3); }

        /// <summary>Returns the result of a componentwise division operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator / (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator % (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ++ (UInt2x4 val) { return new UInt2x4 (++val.c0, ++val.c1, ++val.c2, ++val.c3); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator -- (UInt2x4 val) { return new UInt2x4 (--val.c0, --val.c1, --val.c2, --val.c3); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator < (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator <= (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator > (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator >= (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator - (UInt2x4 val) { return new UInt2x4 (-val.c0, -val.c1, -val.c2, -val.c3); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator + (UInt2x4 val) { return new UInt2x4 (+val.c0, +val.c1, +val.c2, +val.c3); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator << (UInt2x4 x, int n) { return new UInt2x4 (x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt2x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator >> (UInt2x4 x, int n) { return new UInt2x4 (x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator == (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (UInt2x4 lhs, UInt2x4 rhs) { return new Bool2x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (UInt2x4 lhs, uint rhs) { return new Bool2x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator != (uint lhs, UInt2x4 rhs) { return new Bool2x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ~ (UInt2x4 val) { return new UInt2x4 (~val.c0, ~val.c1, ~val.c2, ~val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator & (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator | (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (UInt2x4 lhs, UInt2x4 rhs) { return new UInt2x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt2x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (UInt2x4 lhs, uint rhs) { return new UInt2x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 operator ^ (uint lhs, UInt2x4 rhs) { return new UInt2x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the UInt2 element at a specified index.</summary>
        unsafe public ref UInt2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (UInt2x4* array = &this) { return ref ((UInt2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the UInt2x4 is equal to a given UInt2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt2x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the UInt2x4 is equal to a given UInt2x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt2x4)o); }


        /// <summary>Returns a hash code for the UInt2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y);
        }

        /// <summary>Returns a string representation of the UInt2x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt2x4 matrix constructed from four UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(UInt2 c0, UInt2 c1, UInt2 c2, UInt2 c3) { return new UInt2x4(c0, c1, c2, c3); }

        /// <summary>Returns a UInt2x4 matrix constructed from from 8 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(uint m00, uint m01, uint m02, uint m03,
                                      uint m10, uint m11, uint m12, uint m13)
        {
            return new UInt2x4(m00, m01, m02, m03,
                               m10, m11, m12, m13);
        }

        /// <summary>Returns a UInt2x4 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(uint v) { return new UInt2x4(v); }

        /// <summary>Returns a UInt2x4 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(bool v) { return new UInt2x4(v); }

        /// <summary>Return a UInt2x4 matrix constructed from a Bool2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(Bool2x4 v) { return new UInt2x4(v); }

        /// <summary>Returns a UInt2x4 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(int v) { return new UInt2x4(v); }

        /// <summary>Return a UInt2x4 matrix constructed from a Int2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(Int2x4 v) { return new UInt2x4(v); }

        /// <summary>Returns a UInt2x4 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(SoftFloat v) { return new UInt2x4(v); }

        /// <summary>Return a UInt2x4 matrix constructed from a Float2x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x4 UInt2x4(Float2x4 v) { return new UInt2x4(v); }

        /// <summary>Return the UInt4x2 transpose of a UInt2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x2 Transpose(UInt2x4 v)
        {
            return UInt4x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y,
                v.c3.x, v.c3.y);
        }

        /// <summary>Returns a uint hash code of a UInt2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt2x4 v)
        {
            return SumComponents(v.c0 * UInt2(0x9DF50593u, 0xF18EEB85u) +
                        v.c1 * UInt2(0x9E19BFC3u, 0x8196B06Fu) +
                        v.c2 * UInt2(0xD24EFA19u, 0x7D8048BBu) +
                        v.c3 * UInt2(0x713BD06Fu, 0x753AD6ADu)) + 0xD19764C7u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a UInt2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(UInt2x4 v)
        {
            return (v.c0 * UInt2(0xB5D0BF63u, 0xF9102C5Fu) +
                    v.c1 * UInt2(0x9881FB9Fu, 0x56A1530Du) +
                    v.c2 * UInt2(0x804B722Du, 0x738E50E5u) +
                    v.c3 * UInt2(0x4FC93C25u, 0xCD0445A5u)) + 0xD2B90D9Bu;
        }

    }
}
