
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct Int4 : IEquatable<Int4>, IFormattable
    {
        public int x;
        public int y;
        public int z;
        public int w;

        /// <summary>Int4 zero value.</summary>
        public static readonly Int4 zero;

        /// <summary>Constructs a Int4 vector from four int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Int4 vector from two int values and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(int x, int y, Int2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a Int4 vector from an int value, an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(int x, Int2 yz, int w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a Int4 vector from an int value and an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(int x, Int3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>Constructs a Int4 vector from an Int2 vector and two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Int2 xy, int z, int w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Int4 vector from two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Int2 xy, Int2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a Int4 vector from an Int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Int3 xyz, int w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a Int4 vector from an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Int4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        /// <summary>Constructs a Int4 vector from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(int v)
        {
            x = v;
            y = v;
            z = v;
            w = v;
        }

        /// <summary>Constructs a Int4 vector from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(bool v)
        {
            x = v ? 1 : 0;
            y = v ? 1 : 0;
            z = v ? 1 : 0;
            w = v ? 1 : 0;
        }

        /// <summary>Constructs a Int4 vector from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Bool4 v)
        {
            x = v.x ? 1 : 0;
            y = v.y ? 1 : 0;
            z = v.z ? 1 : 0;
            w = v.w ? 1 : 0;
        }

        /// <summary>Constructs a Int4 vector from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(uint v)
        {
            x = (int)v;
            y = (int)v;
            z = (int)v;
            w = (int)v;
        }

        /// <summary>Constructs a Int4 vector from a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(UInt4 v)
        {
            x = (int)v.x;
            y = (int)v.y;
            z = (int)v.z;
            w = (int)v.w;
        }

        /// <summary>Constructs a Int4 vector from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(SoftFloat v)
        {
            x = (int)v;
            y = (int)v;
            z = (int)v;
            w = (int)v;
        }

        /// <summary>Constructs a Int4 vector from a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int4(Float4 v)
        {
            x = (int)v.x;
            y = (int)v.y;
            z = (int)v.z;
            w = (int)v.w;
        }


        /// <summary>Implicitly converts a single int value to a Int4 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int4(int v) { return new Int4(v); }

        /// <summary>Explicitly converts a single bool value to a Int4 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(bool v) { return new Int4(v); }

        /// <summary>Explicitly converts a Bool4 vector to a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(Bool4 v) { return new Int4(v); }

        /// <summary>Explicitly converts a single uint value to a Int4 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(uint v) { return new Int4(v); }

        /// <summary>Explicitly converts a UInt4 vector to a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(UInt4 v) { return new Int4(v); }

        /// <summary>Explicitly converts a single float value to a Int4 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(SoftFloat v) { return new Int4(v); }

        /// <summary>Explicitly converts a Float4 vector to a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int4(Float4 v) { return new Int4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator * (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator * (Int4 lhs, int rhs) { return new Int4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator * (int lhs, Int4 rhs) { return new Int4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator + (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator + (Int4 lhs, int rhs) { return new Int4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator + (int lhs, Int4 rhs) { return new Int4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator - (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator - (Int4 lhs, int rhs) { return new Int4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator - (int lhs, Int4 rhs) { return new Int4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator / (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator / (Int4 lhs, int rhs) { return new Int4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator / (int lhs, Int4 rhs) { return new Int4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator % (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator % (Int4 lhs, int rhs) { return new Int4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator % (int lhs, Int4 rhs) { return new Int4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator ++ (Int4 val) { return new Int4 (++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator -- (Int4 val) { return new Int4 (--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (Int4 lhs, int rhs) { return new Bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (int lhs, Int4 rhs) { return new Bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (Int4 lhs, int rhs) { return new Bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (int lhs, Int4 rhs) { return new Bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (Int4 lhs, int rhs) { return new Bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (int lhs, Int4 rhs) { return new Bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (Int4 lhs, int rhs) { return new Bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (int lhs, Int4 rhs) { return new Bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator - (Int4 val) { return new Int4 (-val.x, -val.y, -val.z, -val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator + (Int4 val) { return new Int4 (+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int4 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator << (Int4 x, int n) { return new Int4 (x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int4 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator >> (Int4 x, int n) { return new Int4 (x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Int4 lhs, int rhs) { return new Bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (int lhs, Int4 rhs) { return new Bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Int4 lhs, Int4 rhs) { return new Bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Int4 lhs, int rhs) { return new Bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (int lhs, Int4 rhs) { return new Bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator ~ (Int4 val) { return new Int4 (~val.x, ~val.y, ~val.z, ~val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator & (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator & (Int4 lhs, int rhs) { return new Int4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator & (int lhs, Int4 rhs) { return new Int4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator | (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator | (Int4 lhs, int rhs) { return new Int4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator | (int lhs, Int4 rhs) { return new Int4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator ^ (Int4 lhs, Int4 rhs) { return new Int4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int4 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator ^ (Int4 lhs, int rhs) { return new Int4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 operator ^ (int lhs, Int4 rhs) { return new Int4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(x, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(y, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int4(w, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int3(w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Int2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Int2(w, w); }
        }



        /// <summary>Returns the int element at a specified index.</summary>
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Int4* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the Int4 is equal to a given Int4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the Int4 is equal to a given Int4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int4)o); }


        /// <summary>Returns a hash code for the Int4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the Int4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public int z;
            public int w;
            public DebuggerProxy(Int4 v)
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
        /// <summary>Returns a Int4 vector constructed from four int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(int x, int y, int z, int w) { return new Int4(x, y, z, w); }

        /// <summary>Returns a Int4 vector constructed from two int values and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(int x, int y, Int2 zw) { return new Int4(x, y, zw); }

        /// <summary>Returns a Int4 vector constructed from an int value, an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(int x, Int2 yz, int w) { return new Int4(x, yz, w); }

        /// <summary>Returns a Int4 vector constructed from an int value and an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(int x, Int3 yzw) { return new Int4(x, yzw); }

        /// <summary>Returns a Int4 vector constructed from an Int2 vector and two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Int2 xy, int z, int w) { return new Int4(xy, z, w); }

        /// <summary>Returns a Int4 vector constructed from two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Int2 xy, Int2 zw) { return new Int4(xy, zw); }

        /// <summary>Returns a Int4 vector constructed from an Int3 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Int3 xyz, int w) { return new Int4(xyz, w); }

        /// <summary>Returns a Int4 vector constructed from an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Int4 xyzw) { return new Int4(xyzw); }

        /// <summary>Returns a Int4 vector constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(int v) { return new Int4(v); }

        /// <summary>Returns a Int4 vector constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(bool v) { return new Int4(v); }

        /// <summary>Return a Int4 vector constructed from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Bool4 v) { return new Int4(v); }

        /// <summary>Returns a Int4 vector constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(uint v) { return new Int4(v); }

        /// <summary>Return a Int4 vector constructed from a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(UInt4 v) { return new Int4(v); }

        /// <summary>Returns a Int4 vector constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(SoftFloat v) { return new Int4(v); }

        /// <summary>Return a Int4 vector constructed from a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Int4(Float4 v) { return new Int4(v); }

        /// <summary>Returns a uint hash code of a Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int4 v)
        {
            return SumComponents(AsUInt(v) * UInt4(0x6E050B01u, 0x750FDBF5u, 0x7F3DD499u, 0x52EAAEBBu)) + 0x4599C793u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Int4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Int4 v)
        {
            return (AsUInt(v) * UInt4(0x83B5E729u, 0xC267163Fu, 0x67BC9149u, 0xAD7C5EC1u)) + 0x822A7D6Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int4 vectors into an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Shuffle(Int4 a, Int4 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int4 vectors into an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Shuffle(Int4 a, Int4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Int2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int4 vectors into an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Shuffle(Int4 a, Int4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Int3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int4 vectors into an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Shuffle(Int4 a, Int4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return Int4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int SelectShuffleComponent(Int4 a, Int4 b, ShuffleComponent component)
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
