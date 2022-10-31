
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct UInt2 : IEquatable<UInt2>, IFormattable
    {
        public uint x;
        public uint y;

        /// <summary>UInt2 zero value.</summary>
        public static readonly UInt2 zero;

        /// <summary>Constructs a UInt2 vector from two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a UInt2 vector from a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(UInt2 xy)
        {
            x = xy.x;
            y = xy.y;
        }

        /// <summary>Constructs a UInt2 vector from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(uint v)
        {
            x = v;
            y = v;
        }

        /// <summary>Constructs a UInt2 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(bool v)
        {
            x = v ? 1u : 0u;
            y = v ? 1u : 0u;
        }

        /// <summary>Constructs a UInt2 vector from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(Bool2 v)
        {
            x = v.X ? 1u : 0u;
            y = v.Y ? 1u : 0u;
        }

        /// <summary>Constructs a UInt2 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(int v)
        {
            x = (uint)v;
            y = (uint)v;
        }

        /// <summary>Constructs a UInt2 vector from a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(Int2 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
        }

        /// <summary>Constructs a UInt2 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(SoftFloat v)
        {
            x = (uint)v;
            y = (uint)v;
        }

        /// <summary>Constructs a UInt2 vector from a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public UInt2(Float2 v)
        {
            x = (uint)v.x;
            y = (uint)v.y;
        }


        /// <summary>Implicitly converts a single uint value to a UInt2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator UInt2(uint v) { return new UInt2(v); }

        /// <summary>Explicitly converts a single bool value to a UInt2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(bool v) { return new UInt2(v); }

        /// <summary>Explicitly converts a Bool2 vector to a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(Bool2 v) { return new UInt2(v); }

        /// <summary>Explicitly converts a single int value to a UInt2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(int v) { return new UInt2(v); }

        /// <summary>Explicitly converts a Int2 vector to a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(Int2 v) { return new UInt2(v); }

        /// <summary>Explicitly converts a single float value to a UInt2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(SoftFloat v) { return new UInt2(v); }

        /// <summary>Explicitly converts a Float2 vector to a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator UInt2(Float2 v) { return new UInt2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator * (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator * (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator * (uint lhs, UInt2 rhs) { return new UInt2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator + (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator + (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator + (uint lhs, UInt2 rhs) { return new UInt2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator - (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator - (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator - (uint lhs, UInt2 rhs) { return new UInt2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator / (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator / (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator / (uint lhs, UInt2 rhs) { return new UInt2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator % (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator % (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator % (uint lhs, UInt2 rhs) { return new UInt2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator ++ (UInt2 val) { return new UInt2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator -- (UInt2 val) { return new UInt2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (uint lhs, UInt2 rhs) { return new Bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (uint lhs, UInt2 rhs) { return new Bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (uint lhs, UInt2 rhs) { return new Bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (uint lhs, UInt2 rhs) { return new Bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator - (UInt2 val) { return new UInt2 ((uint)-val.x, (uint)-val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator + (UInt2 val) { return new UInt2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on a UInt2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator << (UInt2 x, int n) { return new UInt2 (x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a UInt2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator >> (UInt2 x, int n) { return new UInt2 (x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (uint lhs, UInt2 rhs) { return new Bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (UInt2 lhs, UInt2 rhs) { return new Bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (UInt2 lhs, uint rhs) { return new Bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (uint lhs, UInt2 rhs) { return new Bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator ~ (UInt2 val) { return new UInt2 (~val.x, ~val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator & (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator & (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator & (uint lhs, UInt2 rhs) { return new UInt2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator | (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator | (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator | (uint lhs, UInt2 rhs) { return new UInt2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator ^ (UInt2 lhs, UInt2 rhs) { return new UInt2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a UInt2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator ^ (UInt2 lhs, uint rhs) { return new UInt2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 operator ^ (uint lhs, UInt2 rhs) { return new UInt2 (lhs ^ rhs.x, lhs ^ rhs.y); }




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



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (UInt2* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the UInt2 is equal to a given UInt2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(UInt2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the UInt2 is equal to a given UInt2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((UInt2)o); }


        /// <summary>Returns a hash code for the UInt2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the UInt2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("UInt2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the UInt2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("UInt2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public DebuggerProxy(UInt2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a UInt2 vector constructed from two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(uint x, uint y) { return new UInt2(x, y); }

        /// <summary>Returns a UInt2 vector constructed from a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(UInt2 xy) { return new UInt2(xy); }

        /// <summary>Returns a UInt2 vector constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(uint v) { return new UInt2(v); }

        /// <summary>Returns a UInt2 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(bool v) { return new UInt2(v); }

        /// <summary>Return a UInt2 vector constructed from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(Bool2 v) { return new UInt2(v); }

        /// <summary>Returns a UInt2 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(int v) { return new UInt2(v); }

        /// <summary>Return a UInt2 vector constructed from a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(Int2 v) { return new UInt2(v); }

        /// <summary>Returns a UInt2 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(SoftFloat v) { return new UInt2(v); }

        /// <summary>Return a UInt2 vector constructed from a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 UInt2(Float2 v) { return new UInt2(v); }

        /// <summary>Returns a uint hash code of a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(UInt2 v)
        {
            return SumComponents(v * UInt2(0x4473BBB1u, 0xCBA11D5Fu)) + 0x685835CFu;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a UInt2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(UInt2 v)
        {
            return (v * UInt2(0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt2 vectors into a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Shuffle(UInt2 a, UInt2 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt2 vectors into a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Shuffle(UInt2 a, UInt2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return UInt2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt2 vectors into a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Shuffle(UInt2 a, UInt2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return UInt3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two UInt2 vectors into a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Shuffle(UInt2 a, UInt2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return UInt4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint SelectShuffleComponent(UInt2 a, UInt2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
