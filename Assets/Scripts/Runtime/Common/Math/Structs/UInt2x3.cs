
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt2x3 : IEquatable<UInt2x3>, IFormattable
    {
        public UInt2 c0;
        public UInt2 c1;
        public UInt2 c2;

        /// <summary>UInt2x3 zero value.</summary>
        public static readonly UInt2x3 zero;

        /// <summary>Constructs a UInt2x3 matrix from three UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(UInt2 c0, UInt2 c1, UInt2 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a UInt2x3 matrix from 6 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12)
        {
            c0 = new UInt2(m00, m10);
            c1 = new UInt2(m01, m11);
            c2 = new UInt2(m02, m12);
        }

        /// <summary>Constructs a UInt2x3 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a UInt2x3 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(bool v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v);
            c2 = Math.Select(new UInt2(0u), new UInt2(1u), v);
        }

        /// <summary>Constructs a UInt2x3 matrix from a Bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(Bool2x3 v)
        {
            c0 = Math.Select(new UInt2(0u), new UInt2(1u), v.c0);
            c1 = Math.Select(new UInt2(0u), new UInt2(1u), v.c1);
            c2 = Math.Select(new UInt2(0u), new UInt2(1u), v.c2);
        }

        /// <summary>Constructs a UInt2x3 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(int v)
        {
            c0 = (UInt2)v;
            c1 = (UInt2)v;
            c2 = (UInt2)v;
        }

        /// <summary>Constructs a UInt2x3 matrix from a Int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(Int2x3 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
            c2 = (UInt2)v.c2;
        }

        /// <summary>Constructs a UInt2x3 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(SoftFloat v)
        {
            c0 = new UInt2(v);
            c1 = new UInt2(v);
            c2 = new UInt2(v);
        }

        /// <summary>Constructs a UInt2x3 matrix from a Float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2x3(Float2x3 v)
        {
            c0 = (UInt2)v.c0;
            c1 = (UInt2)v.c1;
            c2 = (UInt2)v.c2;
        }


        /// <summary>Implicitly converts a single uint value to a UInt2x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt2x3(uint v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a single bool value to a UInt2x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(bool v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a Bool2x3 matrix to a UInt2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(Bool2x3 v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a single int value to a UInt2x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(int v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a Int2x3 matrix to a UInt2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(Int2x3 v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a single float value to a UInt2x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(SoftFloat v) { return new UInt2x3(v); }

        /// <summary>Explicitly converts a Float2x3 matrix to a UInt2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2x3(Float2x3 v) { return new UInt2x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator * (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator * (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator * (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator + (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator + (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator + (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator - (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator - (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator - (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator / (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator / (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator / (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator % (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator % (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator % (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator ++ (UInt2x3 val) { return new UInt2x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator -- (UInt2x3 val) { return new UInt2x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator < (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator < (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator < (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <= (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <= (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <= (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator > (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator > (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator > (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >= (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >= (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >= (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator - (UInt2x3 val) { return new UInt2x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator + (UInt2x3 val) { return new UInt2x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt2x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator << (UInt2x3 x, int n) { return new UInt2x3 (x.c0 << n, x.c1 << n, x.c2 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt2x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator >> (UInt2x3 x, int n) { return new UInt2x3 (x.c0 >> n, x.c1 >> n, x.c2 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator == (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator == (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator == (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator != (UInt2x3 lhs, UInt2x3 rhs) { return new Bool2x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator != (UInt2x3 lhs, uint rhs) { return new Bool2x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator != (uint lhs, UInt2x3 rhs) { return new Bool2x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator ~ (UInt2x3 val) { return new UInt2x3 (~val.c0, ~val.c1, ~val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator & (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator & (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator & (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator | (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator | (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator | (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator ^ (UInt2x3 lhs, UInt2x3 rhs) { return new UInt2x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt2x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator ^ (UInt2x3 lhs, uint rhs) { return new UInt2x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 operator ^ (uint lhs, UInt2x3 rhs) { return new UInt2x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the UInt2 element at a specified index.</summary>
        unsafe public ref UInt2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (UInt2x3* array = &this) { return ref ((UInt2*)array)[index]; }
            }
        }

        /// <summary>Returns true if the UInt2x3 is equal to a given UInt2x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt2x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the UInt2x3 is equal to a given UInt2x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt2x3)o); }


        /// <summary>Returns a hash code for the UInt2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        /// <summary>Returns a string representation of the UInt2x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt2x3 matrix constructed from three UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(UInt2 c0, UInt2 c1, UInt2 c2) { return new UInt2x3(c0, c1, c2); }

        /// <summary>Returns a UInt2x3 matrix constructed from from 6 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12)
        {
            return new UInt2x3(m00, m01, m02,
                               m10, m11, m12);
        }

        /// <summary>Returns a UInt2x3 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(uint v) { return new UInt2x3(v); }

        /// <summary>Returns a UInt2x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(bool v) { return new UInt2x3(v); }

        /// <summary>Return a UInt2x3 matrix constructed from a Bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(Bool2x3 v) { return new UInt2x3(v); }

        /// <summary>Returns a UInt2x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(int v) { return new UInt2x3(v); }

        /// <summary>Return a UInt2x3 matrix constructed from a Int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(Int2x3 v) { return new UInt2x3(v); }

        /// <summary>Returns a UInt2x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(SoftFloat v) { return new UInt2x3(v); }

        /// <summary>Return a UInt2x3 matrix constructed from a Float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2x3 UInt2x3(Float2x3 v) { return new UInt2x3(v); }

        /// <summary>Return the UInt3x2 transpose of a UInt2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x2 Transpose(UInt2x3 v)
        {
            return UInt3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        /// <summary>Returns a uint hash code of a UInt2x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt2x3 v)
        {
            return SumComponents(v.c0 * UInt2(0xEF63C699u, 0x9001903Fu) +
                        v.c1 * UInt2(0xA895B9CDu, 0x9D23B201u) +
                        v.c2 * UInt2(0x4B01D3E1u, 0x7461CA0Du)) + 0x79725379u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a UInt2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(UInt2x3 v)
        {
            return (v.c0 * UInt2(0xD6258E5Bu, 0xEE390C97u) +
                    v.c1 * UInt2(0x9C8A2F05u, 0x4DDC6509u) +
                    v.c2 * UInt2(0x7CF083CBu, 0x5C4D6CEDu)) + 0xF9137117u;
        }

    }
}
