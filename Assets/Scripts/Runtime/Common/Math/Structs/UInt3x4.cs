using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct UInt3x4 : IEquatable<UInt3x4>, IFormattable
    {
        public UInt3 c0;
        public UInt3 c1;
        public UInt3 c2;
        public UInt3 c3;

        /// <summary>UInt3x4 zero value.</summary>
        public static readonly UInt3x4 zero;

        /// <summary>Constructs a UInt3x4 matrix from four UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(UInt3 c0, UInt3 c1, UInt3 c2, UInt3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a UInt3x4 matrix from 12 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(uint m00, uint m01, uint m02, uint m03,
            uint m10, uint m11, uint m12, uint m13,
            uint m20, uint m21, uint m22, uint m23)
        {
            c0 = new UInt3(m00, m10, m20);
            c1 = new UInt3(m01, m11, m21);
            c2 = new UInt3(m02, m12, m22);
            c3 = new UInt3(m03, m13, m23);
        }

        /// <summary>Constructs a UInt3x4 matrix from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }

        /// <summary>Constructs a UInt3x4 matrix from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(bool v)
        {
            c0 = Math.Select(new UInt3(0u), new UInt3(1u), v);
            c1 = Math.Select(new UInt3(0u), new UInt3(1u), v);
            c2 = Math.Select(new UInt3(0u), new UInt3(1u), v);
            c3 = Math.Select(new UInt3(0u), new UInt3(1u), v);
        }

        /// <summary>Constructs a UInt3x4 matrix from a Bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(Bool3x4 v)
        {
            c0 = Math.Select(new UInt3(0u), new UInt3(1u), v.c0);
            c1 = Math.Select(new UInt3(0u), new UInt3(1u), v.c1);
            c2 = Math.Select(new UInt3(0u), new UInt3(1u), v.c2);
            c3 = Math.Select(new UInt3(0u), new UInt3(1u), v.c3);
        }

        /// <summary>Constructs a UInt3x4 matrix from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(int v)
        {
            c0 = (UInt3)v;
            c1 = (UInt3)v;
            c2 = (UInt3)v;
            c3 = (UInt3)v;
        }

        /// <summary>Constructs a UInt3x4 matrix from a Int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(Int3x4 v)
        {
            c0 = (UInt3)v.c0;
            c1 = (UInt3)v.c1;
            c2 = (UInt3)v.c2;
            c3 = (UInt3)v.c3;
        }

        /// <summary>Constructs a UInt3x4 matrix from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(SoftFloat v)
        {
            c0 = new UInt3(v);
            c1 = new UInt3(v);
            c2 = new UInt3(v);
            c3 = new UInt3(v);
        }

        /// <summary>Constructs a UInt3x4 matrix from a Float3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3x4(Float3x4 v)
        {
            c0 = (UInt3)v.c0;
            c1 = (UInt3)v.c1;
            c2 = (UInt3)v.c2;
            c3 = (UInt3)v.c3;
        }


        /// <summary>Implicitly converts a single uint value to a UInt3x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt3x4(uint v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a single bool value to a UInt3x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(bool v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a Bool3x4 matrix to a UInt3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(Bool3x4 v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a single int value to a UInt3x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(int v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a Int3x4 matrix to a UInt3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(Int3x4 v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a single float value to a UInt3x4 matrix by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(SoftFloat v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Explicitly converts a Float3x4 matrix to a UInt3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3x4(Float3x4 v)
        {
            return new UInt3x4(v);
        }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator *(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2, lhs.c3 * rhs.c3);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator *(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs, lhs.c3 * rhs);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator *(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2, lhs * rhs.c3);
        }


        /// <summary>Returns the result of a componentwise addition operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator +(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2, lhs.c3 + rhs.c3);
        }

        /// <summary>Returns the result of a componentwise addition operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator +(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs, lhs.c3 + rhs);
        }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator +(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2, lhs + rhs.c3);
        }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator -(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2, lhs.c3 - rhs.c3);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator -(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs, lhs.c3 - rhs);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator -(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2, lhs - rhs.c3);
        }


        /// <summary>Returns the result of a componentwise division operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator /(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2, lhs.c3 / rhs.c3);
        }

        /// <summary>Returns the result of a componentwise division operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator /(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs, lhs.c3 / rhs);
        }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator /(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2, lhs / rhs.c3);
        }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator %(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2, lhs.c3 % rhs.c3);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator %(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs, lhs.c3 % rhs);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator %(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2, lhs % rhs.c3);
        }


        /// <summary>Returns the result of a componentwise increment operation on a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator ++(UInt3x4 val)
        {
            return new UInt3x4(++val.c0, ++val.c1, ++val.c2, ++val.c3);
        }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator --(UInt3x4 val)
        {
            return new UInt3x4(--val.c0, --val.c1, --val.c2, --val.c3);
        }


        /// <summary>Returns the result of a componentwise less than operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2, lhs.c3 < rhs.c3);
        }

        /// <summary>Returns the result of a componentwise less than operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs, lhs.c3 < rhs);
        }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2, lhs < rhs.c3);
        }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <=(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2, lhs.c3 <= rhs.c3);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <=(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs, lhs.c3 <= rhs);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator <=(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2, lhs <= rhs.c3);
        }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2, lhs.c3 > rhs.c3);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs, lhs.c3 > rhs);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2, lhs > rhs.c3);
        }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >=(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2, lhs.c3 >= rhs.c3);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >=(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs, lhs.c3 >= rhs);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator >=(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2, lhs >= rhs.c3);
        }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator -(UInt3x4 val)
        {
            return new UInt3x4(-val.c0, -val.c1, -val.c2, -val.c3);
        }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator +(UInt3x4 val)
        {
            return new UInt3x4(+val.c0, +val.c1, +val.c2, +val.c3);
        }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt3x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator <<(UInt3x4 x, int n)
        {
            return new UInt3x4(x.c0 << n, x.c1 << n, x.c2 << n, x.c3 << n);
        }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt3x4 matrix by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator >> (UInt3x4 x, int n)
        {
            return new UInt3x4(x.c0 >> n, x.c1 >> n, x.c2 >> n, x.c3 >> n);
        }

        /// <summary>Returns the result of a componentwise equality operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ==(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3);
        }

        /// <summary>Returns the result of a componentwise equality operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ==(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ==(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator !=(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator !=(UInt3x4 lhs, uint rhs)
        {
            return new Bool3x4(lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator !=(uint lhs, UInt3x4 rhs)
        {
            return new Bool3x4(lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator ~(UInt3x4 val)
        {
            return new UInt3x4(~val.c0, ~val.c1, ~val.c2, ~val.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator &(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator &(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator &(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator |(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator |(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator |(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator ^(UInt3x4 lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt3x4 matrix and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator ^(UInt3x4 lhs, uint rhs)
        {
            return new UInt3x4(lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 operator ^(uint lhs, UInt3x4 rhs)
        {
            return new UInt3x4(lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3);
        }


        /// <summary>Returns the UInt3 element at a specified index.</summary>
        unsafe public ref UInt3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (UInt3x4* array = &this)
                {
                    return ref ((UInt3*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the UInt3x4 is equal to a given UInt3x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt3x4 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3);
        }

        /// <summary>Returns true if the UInt3x4 is equal to a given UInt3x4, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((UInt3x4)o);
        }


        /// <summary>Returns a hash code for the UInt3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the UInt3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x,
                c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

        /// <summary>Returns a string representation of the UInt3x4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})",
                c0.x.ToString(format, formatProvider), c1.x.ToString(format, formatProvider),
                c2.x.ToString(format, formatProvider), c3.x.ToString(format, formatProvider),
                c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider),
                c2.y.ToString(format, formatProvider), c3.y.ToString(format, formatProvider),
                c0.z.ToString(format, formatProvider), c1.z.ToString(format, formatProvider),
                c2.z.ToString(format, formatProvider), c3.z.ToString(format, formatProvider));
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a UInt3x4 matrix constructed from four UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(UInt3 c0, UInt3 c1, UInt3 c2, UInt3 c3)
        {
            return new UInt3x4(c0, c1, c2, c3);
        }

        /// <summary>Returns a UInt3x4 matrix constructed from from 12 uint values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(uint m00, uint m01, uint m02, uint m03,
            uint m10, uint m11, uint m12, uint m13,
            uint m20, uint m21, uint m22, uint m23)
        {
            return new UInt3x4(m00, m01, m02, m03,
                m10, m11, m12, m13,
                m20, m21, m22, m23);
        }

        /// <summary>Returns a UInt3x4 matrix constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(uint v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Returns a UInt3x4 matrix constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(bool v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Return a UInt3x4 matrix constructed from a Bool3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(Bool3x4 v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Returns a UInt3x4 matrix constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(int v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Return a UInt3x4 matrix constructed from a Int3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(Int3x4 v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Returns a UInt3x4 matrix constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(SoftFloat v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Return a UInt3x4 matrix constructed from a Float3x4 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3x4 UInt3x4(Float3x4 v)
        {
            return new UInt3x4(v);
        }

        /// <summary>Return the UInt4x3 transpose of a UInt3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4x3 Transpose(UInt3x4 v)
        {
            return UInt4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        /// <summary>Returns a uint hash code of a UInt3x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt3x4 v)
        {
            return SumComponents(v.c0 * UInt3(0xD1224537u, 0xE99ED6F3u, 0x48125549u) +
                                 v.c1 * UInt3(0xEEE2123Bu, 0xE3AD9FE5u, 0xCE1CF8BFu) +
                                 v.c2 * UInt3(0x7BE39F3Bu, 0xFAB9913Fu, 0xB4501269u) +
                                 v.c3 * UInt3(0xE04B89FDu, 0xDB3DE101u, 0x7B6D1B4Bu)) + 0x58399E77u;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a UInt3x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(UInt3x4 v)
        {
            return (v.c0 * UInt3(0x5EAC29C9u, 0xFC6014F9u, 0x6BF6693Fu) +
                    v.c1 * UInt3(0x9D1B1D9Bu, 0xF842F5C1u, 0xA47EC335u) +
                    v.c2 * UInt3(0xA477DF57u, 0xC4B1493Fu, 0xBA0966D3u) +
                    v.c3 * UInt3(0xAFBEE253u, 0x5B419C01u, 0x515D90F5u)) + 0xEC9F68F3u;
        }
    }
}
