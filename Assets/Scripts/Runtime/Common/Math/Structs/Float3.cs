using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct Float3 : IEquatable<Float3>, IFormattable
    {
        public SoftFloat x;
        public SoftFloat y;
        public SoftFloat z;

        /// <summary>Float3 zero value.</summary>
        public static readonly Float3 zero;

        /// <summary>Constructs a Float3 vector from three SoftFloat values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a Float3 vector from a SoftFloat value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(SoftFloat x, Float2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        /// <summary>Constructs a Float3 vector from a Float2 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(Float2 xy, SoftFloat z)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a Float3 vector from a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(Float3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        /// <summary>Constructs a Float3 vector from a single SoftFloat value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(SoftFloat v)
        {
            x = v;
            y = v;
            z = v;
        }

        /// <summary>Constructs a Float3 vector from a single bool value by converting it to SoftFloat and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(bool v)
        {
            x = v ? SoftFloat.One : SoftFloat.Zero;
            y = v ? SoftFloat.One : SoftFloat.Zero;
            z = v ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float3 vector from a Bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(Bool3 v)
        {
            x = v.x ? SoftFloat.One : SoftFloat.Zero;
            y = v.y ? SoftFloat.One : SoftFloat.Zero;
            z = v.z ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float3 vector from a single int value by converting it to SoftFloat and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(int v)
        {
            x = (SoftFloat)v;
            y = (SoftFloat)v;
            z = (SoftFloat)v;
        }

        /// <summary>Constructs a Float3 vector from a Int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(Int3 v)
        {
            x = (SoftFloat)v.x;
            y = (SoftFloat)v.y;
            z = (SoftFloat)v.z;
        }

        /// <summary>Constructs a Float3 vector from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(uint v)
        {
            x = (SoftFloat)(int)v;
            y = (SoftFloat)(int)v;
            z = (SoftFloat)(int)v;
        }

        /// <summary>Constructs a Float3 vector from a UInt3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float3(UInt3 v)
        {
            x = (SoftFloat)(int)v.x;
            y = (SoftFloat)(int)v.y;
            z = (SoftFloat)(int)v.z;
        }

        /// <summary>Implicitly converts a single SoftFloat value to a Float3 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3(SoftFloat v)
        {
            return new Float3(v);
        }

        /// <summary>Explicitly converts a single bool value to a Float3 vector by converting it to SoftFloat and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3(bool v)
        {
            return new Float3(v);
        }

        /// <summary>Explicitly converts a Bool3 vector to a Float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float3(Bool3 v)
        {
            return new Float3(v);
        }

        /// <summary>Implicitly converts a single int value to a Float3 vector by converting it to SoftFloat and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3(int v)
        {
            return new Float3(v);
        }

        /// <summary>Implicitly converts a Int3 vector to a Float3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float3(Int3 v)
        {
            return new Float3(v);
        }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator *(Float3 lhs, Float3 rhs)
        {
            return new Float3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator *(Float3 lhs, SoftFloat rhs)
        {
            return new Float3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator *(SoftFloat lhs, Float3 rhs)
        {
            return new Float3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }


        /// <summary>Returns the result of a componentwise addition operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator +(Float3 lhs, Float3 rhs)
        {
            return new Float3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        /// <summary>Returns the result of a componentwise addition operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator +(Float3 lhs, SoftFloat rhs)
        {
            return new Float3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        }

        /// <summary>Returns the result of a componentwise addition operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator +(SoftFloat lhs, Float3 rhs)
        {
            return new Float3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator -(Float3 lhs, Float3 rhs)
        {
            return new Float3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator -(Float3 lhs, SoftFloat rhs)
        {
            return new Float3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator -(SoftFloat lhs, Float3 rhs)
        {
            return new Float3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        }


        /// <summary>Returns the result of a componentwise division operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator /(Float3 lhs, Float3 rhs)
        {
            return new Float3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        }

        /// <summary>Returns the result of a componentwise division operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator /(Float3 lhs, SoftFloat rhs)
        {
            return new Float3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        /// <summary>Returns the result of a componentwise division operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator /(SoftFloat lhs, Float3 rhs)
        {
            return new Float3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        }


        /// <summary>Returns the result of a componentwise modulus operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator %(Float3 lhs, Float3 rhs)
        {
            return new Float3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator %(Float3 lhs, SoftFloat rhs)
        {
            return new Float3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator %(SoftFloat lhs, Float3 rhs)
        {
            return new Float3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);
        }


        /// <summary>Returns the result of a componentwise less than operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        }

        /// <summary>Returns the result of a componentwise less than operation on a Float3 vector and a SoftFloat value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        }

        /// <summary>Returns the result of a componentwise less than operation on a SoftFloat value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <=(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <=(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator <=(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        }


        /// <summary>Returns the result of a componentwise greater than operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >=(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >=(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator >=(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 operator -(Float3 val)
        {
            return new Float3(-val.x, -val.y, -val.z);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Float3 lhs, Float3 rhs)
        {
            return new Bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Float3 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Float3 lhs, SoftFloat rhs)
        {
            return new Bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(SoftFloat lhs, Float3 rhs)
        {
            return new Bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        }


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
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
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
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(x, z, z); }
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
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
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
        public Float3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
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
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
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
            set
            {
                x = value.x;
                y = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                x = value.x;
                z = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                y = value.x;
                x = value.y;
            }
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
            set
            {
                y = value.x;
                z = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.x;
                x = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.x;
                y = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Float2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Float2(z, z); }
        }


        /// <summary>Returns the float element at a specified index.</summary>
        unsafe public SoftFloat this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (Float3* array = &this)
                {
                    return ((SoftFloat*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (SoftFloat* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the Float3 is equal to a given Float3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float3 rhs)
        {
            return x == rhs.x && y == rhs.y && z == rhs.z;
        }

        /// <summary>Returns true if the Float3 is equal to a given Float3, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Float3)o);
        }


        /// <summary>Returns a hash code for the Float3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Float3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float3({0}f, {1}f, {2}f)", x, y, z);
        }

        /// <summary>Returns a string representation of the Float3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float3({0}f, {1}f, {2}f)", x.ToString(format, formatProvider),
                y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public SoftFloat x;
            public SoftFloat y;
            public SoftFloat z;

            public DebuggerProxy(Float3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Float3 vector constructed from three float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return new Float3(x, y, z);
        }

        /// <summary>Returns a Float3 vector constructed from a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(SoftFloat x, Float2 yz)
        {
            return new Float3(x, yz);
        }

        /// <summary>Returns a Float3 vector constructed from a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(Float2 xy, SoftFloat z)
        {
            return new Float3(xy, z);
        }

        /// <summary>Returns a Float3 vector constructed from a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(Float3 xyz)
        {
            return new Float3(xyz);
        }

        /// <summary>Returns a Float3 vector constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(SoftFloat v)
        {
            return new Float3(v);
        }

        /// <summary>Returns a Float3 vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(bool v)
        {
            return new Float3(v);
        }

        /// <summary>Return a Float3 vector constructed from a Bool3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(Bool3 v)
        {
            return new Float3(v);
        }

        /// <summary>Returns a Float3 vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(int v)
        {
            return new Float3(v);
        }

        /// <summary>Return a Float3 vector constructed from a Int3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(Int3 v)
        {
            return new Float3(v);
        }

        /// <summary>Returns a Float3 vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(uint v)
        {
            return new Float3(v);
        }

        /// <summary>Return a Float3 vector constructed from a UInt3 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Float3(UInt3 v)
        {
            return new Float3(v);
        }

        /// <summary>Returns a uint hash code of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float3 v)
        {
            return SumComponents(AsUInt(v) * UInt3(0x9B13B92Du, 0x4ABF0813u, 0x86068063u)) + 0xD75513F9u;
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Float3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Float3 v)
        {
            return (AsUInt(v) * UInt3(0x5AB3E8CDu, 0x676E8407u, 0xB36DE767u)) + 0x6FCA387Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float3 vectors into a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Shuffle(Float3 a, Float3 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float3 vectors into a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Shuffle(Float3 a, Float3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Float2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float3 vectors into a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Shuffle(Float3 a, Float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Float3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float3 vectors into a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Shuffle(Float3 a, Float3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z,
            ShuffleComponent w)
        {
            return Float4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static SoftFloat SelectShuffleComponent(Float3 a, Float3 b, ShuffleComponent component)
        {
            switch (component)
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
