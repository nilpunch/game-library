
using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt4x3 : IEquatable<UInt4x3>, IFormattable
    {
        public UInt4 c0;
        public UInt4 c1;
        public UInt4 c2;

        /// <summary>UInt4x3 zero value.</summary>
        public static readonly UInt4x3 zero;

        /// <summary>Constructs a UInt4x3 matrix from three UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(UInt4 c0, UInt4 c1, UInt4 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a UInt4x3 matrix from 12 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(uint m00, uint m01, uint m02,
                       uint m10, uint m11, uint m12,
                       uint m20, uint m21, uint m22,
                       uint m30, uint m31, uint m32)
        {
            c0 = new UInt4(m00, m10, m20, m30);
            c1 = new UInt4(m01, m11, m21, m31);
            c2 = new UInt4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a UInt4x3 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a UInt4x3 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(bool v)
        {
            c0 = Math.Select(new UInt4(0u), new UInt4(1u), v);
            c1 = Math.Select(new UInt4(0u), new UInt4(1u), v);
            c2 = Math.Select(new UInt4(0u), new UInt4(1u), v);
        }

        /// <summary>Constructs a UInt4x3 matrix from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(Bool4x3 v)
        {
            c0 = Math.Select(new UInt4(0u), new UInt4(1u), v.c0);
            c1 = Math.Select(new UInt4(0u), new UInt4(1u), v.c1);
            c2 = Math.Select(new UInt4(0u), new UInt4(1u), v.c2);
        }

        /// <summary>Constructs a UInt4x3 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(int v)
        {
            c0 = (UInt4)v;
            c1 = (UInt4)v;
            c2 = (UInt4)v;
        }

        /// <summary>Constructs a UInt4x3 matrix from a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(Int4x3 v)
        {
            c0 = (UInt4)v.c0;
            c1 = (UInt4)v.c1;
            c2 = (UInt4)v.c2;
        }

        /// <summary>Constructs a UInt4x3 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(SoftFloat v)
        {
            c0 = (UInt4)v;
            c1 = (UInt4)v;
            c2 = (UInt4)v;
        }

        /// <summary>Constructs a UInt4x3 matrix from a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4x3(Float4x3 v)
        {
            c0 = (UInt4)v.c0;
            c1 = (UInt4)v.c1;
            c2 = (UInt4)v.c2;
        }


        /// <summary>Implicitly converts a single uint value to a UInt4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4x3(uint v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a single bool value to a UInt4x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(bool v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a Bool4x3 matrix to a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(Bool4x3 v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a single int value to a UInt4x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(int v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a Int4x3 matrix to a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(Int4x3 v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a single float value to a UInt4x3 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(SoftFloat v) { return new UInt4x3(v); }

        /// <summary>Explicitly converts a Float4x3 matrix to a UInt4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4x3(Float4x3 v) { return new UInt4x3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator * (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator * (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator * (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator + (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator + (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator + (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator - (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator - (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator - (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2); }


        /// <summary>Returns the result of a componentwise division operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator / (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2); }

        /// <summary>Returns the result of a componentwise division operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator / (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator / (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator % (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator % (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator % (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator ++ (UInt4x3 val) { return new UInt4x3 (++val.c0, ++val.c1, ++val.c2); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator -- (UInt4x3 val) { return new UInt4x3 (--val.c0, --val.c1, --val.c2); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator < (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator <= (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator > (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator >= (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator - (UInt4x3 val) { return new UInt4x3 (-val.c0, -val.c1, -val.c2); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator + (UInt4x3 val) { return new UInt4x3 (+val.c0, +val.c1, +val.c2); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt4x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator << (UInt4x3 x, int n) { return new UInt4x3 (x.c0 << n, x.c1 << n, x.c2 << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt4x3 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator >> (UInt4x3 x, int n) { return new UInt4x3 (x.c0 >> n, x.c1 >> n, x.c2 >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (UInt4x3 lhs, UInt4x3 rhs) { return new Bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (UInt4x3 lhs, uint rhs) { return new Bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (uint lhs, UInt4x3 rhs) { return new Bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator ~ (UInt4x3 val) { return new UInt4x3 (~val.c0, ~val.c1, ~val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator & (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator & (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator & (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator | (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator | (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator | (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator ^ (UInt4x3 lhs, UInt4x3 rhs) { return new UInt4x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt4x3 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator ^ (UInt4x3 lhs, uint rhs) { return new UInt4x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 operator ^ (uint lhs, UInt4x3 rhs) { return new UInt4x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the UInt4 element at a specified index.</summary>
        unsafe public ref UInt4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (UInt4x3* array = &this) { return ref ((UInt4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the UInt4x3 is equal to a given UInt4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the UInt4x3 is equal to a given UInt4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt4x3)o); }


        /// <summary>Returns a hash code for the UInt4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

        /// <summary>Returns a string representation of the UInt4x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider), c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider), c2.y.ToString(format, formatProvider), c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider), c2.z.ToString(format, formatProvider), c0.w.ToString(format, formatProvider), c1.w.ToString(format, formatProvider), c2.w.ToString(format, formatProvider));
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt4x3 matrix constructed from three UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(UInt4 c0, UInt4 c1, UInt4 c2) { return new UInt4x3(c0, c1, c2); }

        /// <summary>Returns a UInt4x3 matrix constructed from from 12 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(uint m00, uint m01, uint m02,
                                      uint m10, uint m11, uint m12,
                                      uint m20, uint m21, uint m22,
                                      uint m30, uint m31, uint m32)
        {
            return new UInt4x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22,
                               m30, m31, m32);
        }

        /// <summary>Returns a UInt4x3 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(uint v) { return new UInt4x3(v); }

        /// <summary>Returns a UInt4x3 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(bool v) { return new UInt4x3(v); }

        /// <summary>Return a UInt4x3 matrix constructed from a Bool4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(Bool4x3 v) { return new UInt4x3(v); }

        /// <summary>Returns a UInt4x3 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(int v) { return new UInt4x3(v); }

        /// <summary>Return a UInt4x3 matrix constructed from a Int4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(Int4x3 v) { return new UInt4x3(v); }

        /// <summary>Returns a UInt4x3 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(SoftFloat v) { return new UInt4x3(v); }

        /// <summary>Return a UInt4x3 matrix constructed from a Float4x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 UInt4x3(Float4x3 v) { return new UInt4x3(v); }

        /// <summary>Return the UInt3x4 transpose of a UInt4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 Transpose(UInt4x3 v)
        {
            return UInt3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a UInt4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt4x3 v)
        {
            return SumComponents(v.c0 * UInt4(0xE7579997u, 0xEF7D56C7u, 0x66F38F0Bu, 0x624256A3u) +
                        v.c1 * UInt4(0x5292ADE1u, 0xD2E590E5u, 0xF25BE857u, 0x9BC17CE7u) +
                        v.c2 * UInt4(0xC8B86851u, 0x64095221u, 0xADF428FFu, 0xA3977109u)) + 0x745ED837u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a UInt4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(UInt4x3 v)
        {
            return (v.c0 * UInt4(0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu, 0x68EEE0F5u) +
                    v.c1 * UInt4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u) +
                    v.c2 * UInt4(0xFC104C3Bu, 0x5FFF6B19u, 0x5E6CBF3Bu, 0xB546F2A5u)) + 0xBBCF63E7u;
        }

    }
}
