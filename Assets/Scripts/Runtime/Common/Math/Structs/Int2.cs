
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct Int2 : IEquatable<Int2>, IFormattable
    {
        public int x;
        public int y;

        /// <summary>Int2 zero value.</summary>
        public static readonly Int2 zero;

        /// <summary>Constructs a Int2 vector from two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a Int2 vector from an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(Int2 xy)
        {
            x = xy.x;
            y = xy.y;
        }

        /// <summary>Constructs a Int2 vector from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(int v)
        {
            x = v;
            y = v;
        }

        /// <summary>Constructs a Int2 vector from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(bool v)
        {
            x = v ? 1 : 0;
            y = v ? 1 : 0;
        }

        /// <summary>Constructs a Int2 vector from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(Bool2 v)
        {
            x = v.X ? 1 : 0;
            y = v.Y ? 1 : 0;
        }

        /// <summary>Constructs a Int2 vector from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(uint v)
        {
            x = (int)v;
            y = (int)v;
        }

        /// <summary>Constructs a Int2 vector from a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(UInt2 v)
        {
            x = (int)v.x;
            y = (int)v.y;
        }

        /// <summary>Constructs a Int2 vector from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(SoftFloat v)
        {
            x = (int)v;
            y = (int)v;
        }

        /// <summary>Constructs a Int2 vector from a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Int2(Float2 v)
        {
            x = (int)v.x;
            y = (int)v.y;
        }


        /// <summary>Implicitly converts a single int value to a Int2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Int2(int v) { return new Int2(v); }

        /// <summary>Explicitly converts a single bool value to a Int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(bool v) { return new Int2(v); }

        /// <summary>Explicitly converts a Bool2 vector to a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(Bool2 v) { return new Int2(v); }

        /// <summary>Explicitly converts a single uint value to a Int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(uint v) { return new Int2(v); }

        /// <summary>Explicitly converts a UInt2 vector to a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(UInt2 v) { return new Int2(v); }

        /// <summary>Explicitly converts a single float value to a Int2 vector by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(SoftFloat v) { return new Int2(v); }

        /// <summary>Explicitly converts a Float2 vector to a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Int2(Float2 v) { return new Int2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator * (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator * (Int2 lhs, int rhs) { return new Int2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator * (int lhs, Int2 rhs) { return new Int2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator + (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator + (Int2 lhs, int rhs) { return new Int2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator + (int lhs, Int2 rhs) { return new Int2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator - (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator - (Int2 lhs, int rhs) { return new Int2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator - (int lhs, Int2 rhs) { return new Int2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator / (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator / (Int2 lhs, int rhs) { return new Int2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator / (int lhs, Int2 rhs) { return new Int2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator % (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator % (Int2 lhs, int rhs) { return new Int2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator % (int lhs, Int2 rhs) { return new Int2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator ++ (Int2 val) { return new Int2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator -- (Int2 val) { return new Int2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (Int2 lhs, int rhs) { return new Bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator < (int lhs, Int2 rhs) { return new Bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (Int2 lhs, int rhs) { return new Bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <= (int lhs, Int2 rhs) { return new Bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (Int2 lhs, int rhs) { return new Bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator > (int lhs, Int2 rhs) { return new Bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (Int2 lhs, int rhs) { return new Bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >= (int lhs, Int2 rhs) { return new Bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator - (Int2 val) { return new Int2 (-val.x, -val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator + (Int2 val) { return new Int2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on an Int2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator << (Int2 x, int n) { return new Int2 (x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an Int2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator >> (Int2 x, int n) { return new Int2 (x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (Int2 lhs, int rhs) { return new Bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator == (int lhs, Int2 rhs) { return new Bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (Int2 lhs, Int2 rhs) { return new Bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (Int2 lhs, int rhs) { return new Bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator != (int lhs, Int2 rhs) { return new Bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise not operation on an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator ~ (Int2 val) { return new Int2 (~val.x, ~val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator & (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator & (Int2 lhs, int rhs) { return new Int2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator & (int lhs, Int2 rhs) { return new Int2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator | (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator | (Int2 lhs, int rhs) { return new Int2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator | (int lhs, Int2 rhs) { return new Int2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator ^ (Int2 lhs, Int2 rhs) { return new Int2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an Int2 vector and an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator ^ (Int2 lhs, int rhs) { return new Int2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on an int value and an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 operator ^ (int lhs, Int2 rhs) { return new Int2 (lhs ^ rhs.x, lhs ^ rhs.y); }




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



        /// <summary>Returns the int element at a specified index.</summary>
        unsafe public int this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Int2* array = &this) { return ((int*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (int* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the Int2 is equal to a given Int2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Int2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the Int2 is equal to a given Int2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Int2)o); }


        /// <summary>Returns a hash code for the Int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Int2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the Int2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Int2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public DebuggerProxy(Int2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Int2 vector constructed from two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(int x, int y) { return new Int2(x, y); }

        /// <summary>Returns a Int2 vector constructed from an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(Int2 xy) { return new Int2(xy); }

        /// <summary>Returns a Int2 vector constructed from a single int value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(int v) { return new Int2(v); }

        /// <summary>Returns a Int2 vector constructed from a single bool value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(bool v) { return new Int2(v); }

        /// <summary>Return a Int2 vector constructed from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(Bool2 v) { return new Int2(v); }

        /// <summary>Returns a Int2 vector constructed from a single uint value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(uint v) { return new Int2(v); }

        /// <summary>Return a Int2 vector constructed from a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(UInt2 v) { return new Int2(v); }

        /// <summary>Returns a Int2 vector constructed from a single float value by converting it to int and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(SoftFloat v) { return new Int2(v); }

        /// <summary>Return a Int2 vector constructed from a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Int2(Float2 v) { return new Int2(v); }

        /// <summary>Returns a uint hash code of a Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Int2 v)
        {
            return SumComponents(AsUInt(v) * UInt2(0x83B58237u, 0x833E3E29u)) + 0xA9D919BFu;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Int2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Int2 v)
        {
            return (AsUInt(v) * UInt2(0xC3EC1D97u, 0xB8B208C7u)) + 0x5D3ED947u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int2 vectors into an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Shuffle(Int2 a, Int2 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int2 vectors into an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Shuffle(Int2 a, Int2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Int2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int2 vectors into an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Shuffle(Int2 a, Int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Int3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Int2 vectors into an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Shuffle(Int2 a, Int2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return Int4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static int SelectShuffleComponent(Int2 a, Int2 b, ShuffleComponent component)
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
