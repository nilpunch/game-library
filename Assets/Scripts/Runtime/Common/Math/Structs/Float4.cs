
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct Float4 : IEquatable<Float4>, IFormattable
    {
        public SoftFloat x;
        public SoftFloat y;
        public SoftFloat z;
        public SoftFloat w;

        /// <summary>Float4 zero value.</summary>
        public static readonly Float4 zero;

        /// <summary>Constructs a Float4 vector from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Float4 vector from two float values and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(SoftFloat x, SoftFloat y, Float2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a Float4 vector from a float value, a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(SoftFloat x, Float2 yz, SoftFloat w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a Float4 vector from a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(SoftFloat x, Float3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>Constructs a Float4 vector from a Float2 vector and two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Float2 xy, SoftFloat z, SoftFloat w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Float4 vector from two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Float2 xy, Float2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }

        /// <summary>Constructs a Float4 vector from a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Float3 xyz, SoftFloat w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a Float4 vector from a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Float4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        /// <summary>Constructs a Float4 vector from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(SoftFloat v)
        {
            x = v;
            y = v;
            z = v;
            w = v;
        }

        /// <summary>Constructs a Float4 vector from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(bool v)
        {
            x = v ? SoftFloat.One : SoftFloat.Zero;
            y = v ? SoftFloat.One : SoftFloat.Zero;
            z = v ? SoftFloat.One : SoftFloat.Zero;
            w = v ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float4 vector from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Bool4 v)
        {
            x = v.x ? SoftFloat.One : SoftFloat.Zero;
            y = v.y ? SoftFloat.One : SoftFloat.Zero;
            z = v.z ? SoftFloat.One : SoftFloat.Zero;
            w = v.w ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float4 vector from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(int v)
        {
            x = (SoftFloat)v;
            y = (SoftFloat)v;
            z = (SoftFloat)v;
            w = (SoftFloat)v;
        }

        /// <summary>Constructs a Float4 vector from a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(Int4 v)
        {
            x = (SoftFloat)v.x;
            y = (SoftFloat)v.y;
            z = (SoftFloat)v.z;
            w = (SoftFloat)v.w;
        }

        /// <summary>Constructs a Float4 vector from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(uint v)
        {
            x = (SoftFloat)(int)v;
            y = (SoftFloat)(int)v;
            z = (SoftFloat)(int)v;
            w = (SoftFloat)(int)v;
        }

        /// <summary>Constructs a Float4 vector from a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float4(UInt4 v)
        {
            x = (SoftFloat)(int)v.x;
            y = (SoftFloat)(int)v.y;
            z = (SoftFloat)(int)v.z;
            w = (SoftFloat)(int)v.w;
        }


        /// <summary>Implicitly converts a single float value to a Float4 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4(SoftFloat v) { return new Float4(v); }

        /// <summary>Explicitly converts a single bool value to a Float4 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4(bool v) { return new Float4(v); }

        /// <summary>Explicitly converts a Bool4 vector to a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float4(Bool4 v) { return new Float4(v); }

        /// <summary>Implicitly converts a single int value to a Float4 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4(int v) { return new Float4(v); }

        /// <summary>Implicitly converts a Int4 vector to a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4(Int4 v) { return new Float4(v); }

        /// <summary>Implicitly converts a single uint value to a Float4 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4(uint v) { return new Float4(v); }

        /// <summary>Implicitly converts a UInt4 vector to a Float4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float4(UInt4 v) { return new Float4(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator * (Float4 lhs, Float4 rhs) { return new Float4 (lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator * (Float4 lhs, SoftFloat rhs) { return new Float4 (lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator * (SoftFloat lhs, Float4 rhs) { return new Float4 (lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator + (Float4 lhs, Float4 rhs) { return new Float4 (lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator + (Float4 lhs, SoftFloat rhs) { return new Float4 (lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator + (SoftFloat lhs, Float4 rhs) { return new Float4 (lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator - (Float4 lhs, Float4 rhs) { return new Float4 (lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator - (Float4 lhs, SoftFloat rhs) { return new Float4 (lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator - (SoftFloat lhs, Float4 rhs) { return new Float4 (lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator / (Float4 lhs, Float4 rhs) { return new Float4 (lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator / (Float4 lhs, SoftFloat rhs) { return new Float4 (lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator / (SoftFloat lhs, Float4 rhs) { return new Float4 (lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator % (Float4 lhs, Float4 rhs) { return new Float4 (lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator % (Float4 lhs, SoftFloat rhs) { return new Float4 (lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator % (SoftFloat lhs, Float4 rhs) { return new Float4 (lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise less than operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator < (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator <= (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator > (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator >= (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 operator - (Float4 val) { return new Float4 (-val.x, -val.y, -val.z, -val.w); }


        /// <summary>Returns the result of a componentwise equality operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Float4 lhs, Float4 rhs) { return new Bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a Float4 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Float4 lhs, SoftFloat rhs) { return new Bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (SoftFloat lhs, Float4 rhs) { return new Bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(x, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(y, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float4(w, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(w, w); }
        }



        /// <summary>Returns the float element at a specified index.</summary>
        unsafe public SoftFloat this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (Float4* array = &this) { return ((SoftFloat*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif
                fixed (SoftFloat* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the Float4 is equal to a given Float4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the Float4 is equal to a given Float4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Float4)o); }


        /// <summary>Returns a hash code for the Float4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Float4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float4({0}f, {1}f, {2}f, {3}f)", x, y, z, w);
        }

        /// <summary>Returns a string representation of the Float4 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float4({0}f, {1}f, {2}f, {3}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public SoftFloat x;
            public SoftFloat y;
            public SoftFloat z;
            public SoftFloat w;
            public DebuggerProxy(Float4 v)
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
        /// <summary>Returns a Float4 vector constructed from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w) { return new Float4(x, y, z, w); }

        /// <summary>Returns a Float4 vector constructed from two float values and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(SoftFloat x, SoftFloat y, Float2 zw) { return new Float4(x, y, zw); }

        /// <summary>Returns a Float4 vector constructed from a float value, a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(SoftFloat x, Float2 yz, SoftFloat w) { return new Float4(x, yz, w); }

        /// <summary>Returns a Float4 vector constructed from a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(SoftFloat x, Float3 yzw) { return new Float4(x, yzw); }

        /// <summary>Returns a Float4 vector constructed from a Float2 vector and two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Float2 xy, SoftFloat z, SoftFloat w) { return new Float4(xy, z, w); }

        /// <summary>Returns a Float4 vector constructed from two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Float2 xy, Float2 zw) { return new Float4(xy, zw); }

        /// <summary>Returns a Float4 vector constructed from a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Float3 xyz, SoftFloat w) { return new Float4(xyz, w); }

        /// <summary>Returns a Float4 vector constructed from a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Float4 xyzw) { return new Float4(xyzw); }

        /// <summary>Returns a Float4 vector constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(SoftFloat v) { return new Float4(v); }

        /// <summary>Returns a Float4 vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(bool v) { return new Float4(v); }

        /// <summary>Return a Float4 vector constructed from a Bool4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Bool4 v) { return new Float4(v); }

        /// <summary>Returns a Float4 vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(int v) { return new Float4(v); }

        /// <summary>Return a Float4 vector constructed from a Int4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(Int4 v) { return new Float4(v); }

        /// <summary>Returns a Float4 vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(uint v) { return new Float4(v); }

        /// <summary>Return a Float4 vector constructed from a UInt4 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Float4(UInt4 v) { return new Float4(v); }

        /// <summary>Returns a uint hash code of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float4 v)
        {
            return SumComponents(AsUInt(v) * UInt4(0xE69626FFu, 0xBD010EEBu, 0x9CEDE1D1u, 0x43BE0B51u)) + 0xAF836EE1u;
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Float4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Float4 v)
        {
            return (AsUInt(v) * UInt4(0xB130C137u, 0x54834775u, 0x7C022221u, 0xA2D00EDFu)) + 0xA8977779u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float4 vectors into a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Shuffle(Float4 a, Float4 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float4 vectors into a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Shuffle(Float4 a, Float4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Float2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float4 vectors into a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Shuffle(Float4 a, Float4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Float3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float4 vectors into a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Shuffle(Float4 a, Float4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return Float4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static SoftFloat SelectShuffleComponent(Float4 a, Float4 b, ShuffleComponent component)
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
                    //throw new System.ArgumentException("Invalid shuffle component: " + component);
                    throw new ArgumentException("Invalid shuffle component");
            }
        }

    }
}
