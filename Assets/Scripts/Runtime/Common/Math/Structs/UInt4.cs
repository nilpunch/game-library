
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct UInt4 : IEquatable<UInt4>, IFormattable
    {
        public uint x;
        public uint y;
        public uint z;
        public uint w;

        /// <summary>UInt4 zero value.</summary>
        public static readonly UInt4 zero;

        /// <summary>Constructs a UInt4 vector from four uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a UInt4 vector from two uint values and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(uint x, uint y, UInt2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a UInt4 vector from a uint value, a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(uint x, UInt2 yz, uint w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a UInt4 vector from a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(uint x, UInt3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>Constructs a UInt4 vector from a UInt2 vector and two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(UInt2 xy, uint z, uint w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a UInt4 vector from two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(UInt2 xy, UInt2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a UInt4 vector from a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(UInt3 xyz, uint w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a UInt4 vector from a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(UInt4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        /// <summary>Constructs a UInt4 vector from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(uint v)
        {
            x = v;
            y = v;
            z = v;
            w = v;
        }

        /// <summary>Constructs a UInt4 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(bool v)
        {
            x = v ? 1u : 0u;
            y = v ? 1u : 0u;
            z = v ? 1u : 0u;
            w = v ? 1u : 0u;
        }

        /// <summary>Constructs a UInt4 vector from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(Bool4 v)
        {
            x = v.x ? 1u : 0u;
            y = v.y ? 1u : 0u;
            z = v.z ? 1u : 0u;
            w = v.w ? 1u : 0u;
        }

        /// <summary>Constructs a UInt4 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(int v)
        {
            x = (uint)v;
            y = (uint)v;
            z = (uint)v;
            w = (uint)v;
        }

        /// <summary>Constructs a UInt4 vector from a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(Int4 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
            z = (uint)v.z;
            w = (uint)v.w;
        }

        /// <summary>Constructs a UInt4 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(SoftFloat v)
        {
            x = (uint)v;
            y = (uint)v;
            z = (uint)v;
            w = (uint)v;
        }

        /// <summary>Constructs a UInt4 vector from a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt4(Float4 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
            z = (uint)v.z;
            w = (uint)v.w;
        }


        /// <summary>Implicitly converts a single uint value to a UInt4 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt4(uint v) { return new UInt4(v); }

        /// <summary>Explicitly converts a single bool value to a UInt4 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(bool v) { return new UInt4(v); }

        /// <summary>Explicitly converts a Bool4 vector to a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(Bool4 v) { return new UInt4(v); }

        /// <summary>Explicitly converts a single int value to a UInt4 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(int v) { return new UInt4(v); }

        /// <summary>Explicitly converts a Int4 vector to a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(Int4 v) { return new UInt4(v); }

        /// <summary>Explicitly converts a single float value to a UInt4 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(SoftFloat v) { return new UInt4(v); }

        /// <summary>Explicitly converts a Float4 vector to a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt4(Float4 v) { return new UInt4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator * (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator * (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator * (uint lhs, UInt4 rhs) { return new UInt4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator + (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator + (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator + (uint lhs, UInt4 rhs) { return new UInt4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator - (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator - (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator - (uint lhs, UInt4 rhs) { return new UInt4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator / (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator / (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator / (uint lhs, UInt4 rhs) { return new UInt4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator % (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator % (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator % (uint lhs, UInt4 rhs) { return new UInt4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator ++ (UInt4 val) { return new UInt4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator -- (UInt4 val) { return new UInt4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (uint lhs, UInt4 rhs) { return new Bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (uint lhs, UInt4 rhs) { return new Bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (uint lhs, UInt4 rhs) { return new Bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (uint lhs, UInt4 rhs) { return new Bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator - (UInt4 val) { return new UInt4 ((uint)-val.x, (uint)-val.y, (uint)-val.z, (uint)-val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator + (UInt4 val) { return new UInt4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt4 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator << (UInt4 x, int n) { return new UInt4 (x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt4 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator >> (UInt4 x, int n) { return new UInt4 (x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (uint lhs, UInt4 rhs) { return new Bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (UInt4 lhs, UInt4 rhs) { return new Bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (UInt4 lhs, uint rhs) { return new Bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (uint lhs, UInt4 rhs) { return new Bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator ~ (UInt4 val) { return new UInt4 (~val.x, ~val.y, ~val.z, ~val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator & (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator & (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator & (uint lhs, UInt4 rhs) { return new UInt4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator | (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator | (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator | (uint lhs, UInt4 rhs) { return new UInt4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator ^ (UInt4 lhs, UInt4 rhs) { return new UInt4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt4 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator ^ (UInt4 lhs, uint rhs) { return new UInt4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 operator ^ (uint lhs, UInt4 rhs) { return new UInt4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(x, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(y, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt4(w, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt3(w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public UInt2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new UInt2(w, w); }
        }



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (UInt4* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the UInt4 is equal to a given UInt4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the UInt4 is equal to a given UInt4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt4)o); }


        /// <summary>Returns a hash code for the UInt4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the UInt4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;
            public uint w;
            public DebuggerProxy(UInt4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt4 vector constructed from four uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(uint x, uint y, uint z, uint w) { return new UInt4(x, y, z, w); }

        /// <summary>Returns a UInt4 vector constructed from two uint values and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(uint x, uint y, UInt2 zw) { return new UInt4(x, y, zw); }

        /// <summary>Returns a UInt4 vector constructed from a uint value, a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(uint x, UInt2 yz, uint w) { return new UInt4(x, yz, w); }

        /// <summary>Returns a UInt4 vector constructed from a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(uint x, UInt3 yzw) { return new UInt4(x, yzw); }

        /// <summary>Returns a UInt4 vector constructed from a UInt2 vector and two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(UInt2 xy, uint z, uint w) { return new UInt4(xy, z, w); }

        /// <summary>Returns a UInt4 vector constructed from two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(UInt2 xy, UInt2 zw) { return new UInt4(xy, zw); }

        /// <summary>Returns a UInt4 vector constructed from a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(UInt3 xyz, uint w) { return new UInt4(xyz, w); }

        /// <summary>Returns a UInt4 vector constructed from a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(UInt4 xyzw) { return new UInt4(xyzw); }

        /// <summary>Returns a UInt4 vector constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(uint v) { return new UInt4(v); }

        /// <summary>Returns a UInt4 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(bool v) { return new UInt4(v); }

        /// <summary>Return a UInt4 vector constructed from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(Bool4 v) { return new UInt4(v); }

        /// <summary>Returns a UInt4 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(int v) { return new UInt4(v); }

        /// <summary>Return a UInt4 vector constructed from a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(Int4 v) { return new UInt4(v); }

        /// <summary>Returns a UInt4 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(SoftFloat v) { return new UInt4(v); }

        /// <summary>Return a UInt4 vector constructed from a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 UInt4(Float4 v) { return new UInt4(v); }

        /// <summary>Returns a uint hash code of a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt4 v)
        {
            return SumComponents(v * UInt4(0xB492BF15u, 0xD37220E3u, 0x7AA2C2BDu, 0xE16BC89Du)) + 0x7AA07CD3u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a UInt4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(UInt4 v)
        {
            return (v * UInt4(0xAF642BA9u, 0xA8F2213Bu, 0x9F3FDC37u, 0xAC60D0C3u)) + 0x9263662Fu;
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt4 vectors into a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Shuffle(UInt4 a, UInt4 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt4 vectors into a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Shuffle(UInt4 a, UInt4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return UInt2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt4 vectors into a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Shuffle(UInt4 a, UInt4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return UInt3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt4 vectors into a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Shuffle(UInt4 a, UInt4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return UInt4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint SelectShuffleComponent(UInt4 a, UInt4 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.LeftW:
                    return a.w;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                case ShuffleComponent.RightW:
                    return b.w;
                default:
                    throw new ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
