
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct UInt3 : IEquatable<UInt3>, IFormattable
    {
        public uint x;
        public uint y;
        public uint z;

        /// <summary>UInt3 zero value.</summary>
        public static readonly UInt3 zero;

        /// <summary>Constructs a UInt3 vector from three uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a UInt3 vector from a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(uint x, UInt2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        /// <summary>Constructs a UInt3 vector from a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(UInt2 xy, uint z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a UInt3 vector from a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(UInt3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        /// <summary>Constructs a UInt3 vector from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(uint v)
        {
            x = v;
            y = v;
            z = v;
        }

        /// <summary>Constructs a UInt3 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(bool v)
        {
            x = v ? 1u : 0u;
            y = v ? 1u : 0u;
            z = v ? 1u : 0u;
        }

        /// <summary>Constructs a UInt3 vector from a Bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(Bool3 v)
        {
            x = v.x ? 1u : 0u;
            y = v.y ? 1u : 0u;
            z = v.z ? 1u : 0u;
        }

        /// <summary>Constructs a UInt3 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(int v)
        {
            x = (uint)v;
            y = (uint)v;
            z = (uint)v;
        }

        /// <summary>Constructs a UInt3 vector from a Int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(Int3 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
            z = (uint)v.z;
        }

        /// <summary>Constructs a UInt3 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(SoftFloat v)
        {
            x = (uint)v;
            y = (uint)v;
            z = (uint)v;
        }

        /// <summary>Constructs a UInt3 vector from a Float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt3(Float3 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
            z = (uint)v.z;
        }


        /// <summary>Implicitly converts a single uint value to a UInt3 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt3(uint v) { return new UInt3(v); }

        /// <summary>Explicitly converts a single bool value to a UInt3 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(bool v) { return new UInt3(v); }

        /// <summary>Explicitly converts a Bool3 vector to a UInt3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(Bool3 v) { return new UInt3(v); }

        /// <summary>Explicitly converts a single int value to a UInt3 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(int v) { return new UInt3(v); }

        /// <summary>Explicitly converts a Int3 vector to a UInt3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(Int3 v) { return new UInt3(v); }

        /// <summary>Explicitly converts a single float value to a UInt3 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(SoftFloat v) { return new UInt3(v); }

        /// <summary>Explicitly converts a Float3 vector to a UInt3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt3(Float3 v) { return new UInt3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator * (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator * (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator * (uint lhs, UInt3 rhs) { return new UInt3 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator + (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator + (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator + (uint lhs, UInt3 rhs) { return new UInt3 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator - (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator - (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator - (uint lhs, UInt3 rhs) { return new UInt3 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator / (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator / (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator / (uint lhs, UInt3 rhs) { return new UInt3 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator % (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator % (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator % (uint lhs, UInt3 rhs) { return new UInt3 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator ++ (UInt3 val) { return new UInt3 (++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator -- (UInt3 val) { return new UInt3 (--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator < (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator < (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator < (uint lhs, UInt3 rhs) { return new Bool3 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <= (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <= (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <= (uint lhs, UInt3 rhs) { return new Bool3 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator > (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator > (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator > (uint lhs, UInt3 rhs) { return new Bool3 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >= (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >= (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >= (uint lhs, UInt3 rhs) { return new Bool3 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator - (UInt3 val) { return new UInt3 ((uint)-val.x, (uint)-val.y, (uint)-val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator + (UInt3 val) { return new UInt3 (+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt3 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator << (UInt3 x, int n) { return new UInt3 (x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt3 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator >> (UInt3 x, int n) { return new UInt3 (x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator == (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator == (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator == (uint lhs, UInt3 rhs) { return new Bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator != (UInt3 lhs, UInt3 rhs) { return new Bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator != (UInt3 lhs, uint rhs) { return new Bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator != (uint lhs, UInt3 rhs) { return new Bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator ~ (UInt3 val) { return new UInt3 (~val.x, ~val.y, ~val.z); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator & (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator & (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator & (uint lhs, UInt3 rhs) { return new UInt3 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator | (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator | (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator | (uint lhs, UInt3 rhs) { return new UInt3 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator ^ (UInt3 lhs, UInt3 rhs) { return new UInt3 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt3 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator ^ (UInt3 lhs, uint rhs) { return new UInt3 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 operator ^ (uint lhs, UInt3 rhs) { return new UInt3 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z); }




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



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (UInt3* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the UInt3 is equal to a given UInt3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the UInt3 is equal to a given UInt3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt3)o); }


        /// <summary>Returns a hash code for the UInt3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the UInt3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public uint z;
            public DebuggerProxy(UInt3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt3 vector constructed from three uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(uint x, uint y, uint z) { return new UInt3(x, y, z); }

        /// <summary>Returns a UInt3 vector constructed from a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(uint x, UInt2 yz) { return new UInt3(x, yz); }

        /// <summary>Returns a UInt3 vector constructed from a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(UInt2 xy, uint z) { return new UInt3(xy, z); }

        /// <summary>Returns a UInt3 vector constructed from a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(UInt3 xyz) { return new UInt3(xyz); }

        /// <summary>Returns a UInt3 vector constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(uint v) { return new UInt3(v); }

        /// <summary>Returns a UInt3 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(bool v) { return new UInt3(v); }

        /// <summary>Return a UInt3 vector constructed from a Bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(Bool3 v) { return new UInt3(v); }

        /// <summary>Returns a UInt3 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(int v) { return new UInt3(v); }

        /// <summary>Return a UInt3 vector constructed from a Int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(Int3 v) { return new UInt3(v); }

        /// <summary>Returns a UInt3 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(SoftFloat v) { return new UInt3(v); }

        /// <summary>Return a UInt3 vector constructed from a Float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 UInt3(Float3 v) { return new UInt3(v); }

        /// <summary>Returns a uint hash code of a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt3 v)
        {
            return SumComponents(v * UInt3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u)) + 0x863E3729u;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a UInt3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(UInt3 v)
        {
            return (v * UInt3(0xE191B035u, 0x68586FAFu, 0xD4DFF6D3u)) + 0xCB634F4Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt3 vectors into a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Shuffle(UInt3 a, UInt3 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt3 vectors into a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Shuffle(UInt3 a, UInt3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return UInt2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt3 vectors into a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Shuffle(UInt3 a, UInt3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return UInt3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt3 vectors into a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Shuffle(UInt3 a, UInt3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return UInt4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint SelectShuffleComponent(UInt3 a, UInt3 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                default:
                    throw new ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
