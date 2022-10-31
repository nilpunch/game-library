using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public struct Float2 : IEquatable<Float2>, IFormattable
    {
        public SoftFloat x;
        public SoftFloat y;

        /// <summary>Float2 zero value.</summary>
        public static readonly Float2 zero;

        /// <summary>Constructs a Float2 vector from two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(SoftFloat x, SoftFloat y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a Float2 vector from a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(Float2 xy)
        {
            x = xy.x;
            y = xy.y;
        }

        /// <summary>Constructs a Float2 vector from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(SoftFloat v)
        {
            x = v;
            y = v;
        }

        /// <summary>Constructs a Float2 vector from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(bool v)
        {
            x = v ? SoftFloat.One : SoftFloat.Zero;
            y = v ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float2 vector from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(Bool2 v)
        {
            x = v.X ? SoftFloat.One : SoftFloat.Zero;
            y = v.Y ? SoftFloat.One : SoftFloat.Zero;
        }

        /// <summary>Constructs a Float2 vector from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(int v)
        {
            x = (SoftFloat)v;
            y = (SoftFloat)v;
        }

        /// <summary>Constructs a Float2 vector from a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(Int2 v)
        {
            x = (SoftFloat)v.x;
            y = (SoftFloat)v.y;
        }

        /// <summary>Constructs a Float2 vector from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(uint v)
        {
            x = (SoftFloat)(int)v;
            y = (SoftFloat)(int)v;
        }

        /// <summary>Constructs a Float2 vector from a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2(UInt2 v)
        {
            x = (SoftFloat)(int)v.x;
            y = (SoftFloat)(int)v.y;
        }


        /// <summary>Implicitly converts a single float value to a Float2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2(SoftFloat v)
        {
            return new Float2(v);
        }

        /// <summary>Explicitly converts a single bool value to a Float2 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2(bool v)
        {
            return new Float2(v);
        }

        /// <summary>Explicitly converts a Bool2 vector to a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2(Bool2 v)
        {
            return new Float2(v);
        }

        /// <summary>Implicitly converts a single int value to a Float2 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2(int v)
        {
            return new Float2(v);
        }

        /// <summary>Implicitly converts a Int2 vector to a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2(Int2 v)
        {
            return new Float2(v);
        }

        /// <summary>Implicitly converts a single uint value to a Float2 vector by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2(uint v)
        {
            return new Float2(v);
        }

        /// <summary>Implicitly converts a UInt2 vector to a Float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2(UInt2 v)
        {
            return new Float2(v);
        }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator *(Float2 lhs, Float2 rhs)
        {
            return new Float2(lhs.x * rhs.x, lhs.y * rhs.y);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator *(Float2 lhs, SoftFloat rhs)
        {
            return new Float2(lhs.x * rhs, lhs.y * rhs);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator *(SoftFloat lhs, Float2 rhs)
        {
            return new Float2(lhs * rhs.x, lhs * rhs.y);
        }


        /// <summary>Returns the result of a componentwise addition operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator +(Float2 lhs, Float2 rhs)
        {
            return new Float2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        /// <summary>Returns the result of a componentwise addition operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator +(Float2 lhs, SoftFloat rhs)
        {
            return new Float2(lhs.x + rhs, lhs.y + rhs);
        }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator +(SoftFloat lhs, Float2 rhs)
        {
            return new Float2(lhs + rhs.x, lhs + rhs.y);
        }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator -(Float2 lhs, Float2 rhs)
        {
            return new Float2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator -(Float2 lhs, SoftFloat rhs)
        {
            return new Float2(lhs.x - rhs, lhs.y - rhs);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator -(SoftFloat lhs, Float2 rhs)
        {
            return new Float2(lhs - rhs.x, lhs - rhs.y);
        }


        /// <summary>Returns the result of a componentwise division operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator /(Float2 lhs, Float2 rhs)
        {
            return new Float2(lhs.x / rhs.x, lhs.y / rhs.y);
        }

        /// <summary>Returns the result of a componentwise division operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator /(Float2 lhs, SoftFloat rhs)
        {
            return new Float2(lhs.x / rhs, lhs.y / rhs);
        }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator /(SoftFloat lhs, Float2 rhs)
        {
            return new Float2(lhs / rhs.x, lhs / rhs.y);
        }


        /// <summary>Returns the result of a componentwise modulus operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator %(Float2 lhs, Float2 rhs)
        {
            return new Float2(lhs.x % rhs.x, lhs.y % rhs.y);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator %(Float2 lhs, SoftFloat rhs)
        {
            return new Float2(lhs.x % rhs, lhs.y % rhs);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator %(SoftFloat lhs, Float2 rhs)
        {
            return new Float2(lhs % rhs.x, lhs % rhs.y);
        }


        /// <summary>Returns the result of a componentwise less than operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        }

        /// <summary>Returns the result of a componentwise less than operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x < rhs, lhs.y < rhs);
        }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs < rhs.x, lhs < rhs.y);
        }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <=(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <=(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x <= rhs, lhs.y <= rhs);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator <=(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs <= rhs.x, lhs <= rhs.y);
        }


        /// <summary>Returns the result of a componentwise greater than operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x > rhs, lhs.y > rhs);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs > rhs.x, lhs > rhs.y);
        }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >=(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >=(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x >= rhs, lhs.y >= rhs);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator >=(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs >= rhs.x, lhs >= rhs.y);
        }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 operator -(Float2 val)
        {
            return new Float2(-val.x, -val.y);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x == rhs, lhs.y == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs == rhs.x, lhs == rhs.y);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Float2 lhs, Float2 rhs)
        {
            return new Bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Float2 vector and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Float2 lhs, SoftFloat rhs)
        {
            return new Bool2(lhs.x != rhs, lhs.y != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(SoftFloat lhs, Float2 rhs)
        {
            return new Bool2(lhs != rhs.x, lhs != rhs.y);
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


        /// <summary>Returns the float element at a specified index.</summary>
        unsafe public SoftFloat this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (Float2* array = &this)
                {
                    return ((SoftFloat*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif
                fixed (SoftFloat* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the Float2 is equal to a given Float2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float2 rhs)
        {
            return x == rhs.x && y == rhs.y;
        }

        /// <summary>Returns true if the Float2 is equal to a given Float2, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Float2)o);
        }


        /// <summary>Returns a hash code for the Float2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Float2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float2({0}f, {1}f)", x, y);
        }

        /// <summary>Returns a string representation of the Float2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float2({0}f, {1}f)", x.ToString(format, formatProvider),
                y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public SoftFloat x;
            public SoftFloat y;

            public DebuggerProxy(Float2 v)
            {
                x = v.x;
                y = v.y;
            }
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Float2 vector constructed from two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(SoftFloat x, SoftFloat y)
        {
            return new Float2(x, y);
        }

        /// <summary>Returns a Float2 vector constructed from a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(Float2 xy)
        {
            return new Float2(xy);
        }

        /// <summary>Returns a Float2 vector constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(SoftFloat v)
        {
            return new Float2(v);
        }

        /// <summary>Returns a Float2 vector constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(bool v)
        {
            return new Float2(v);
        }

        /// <summary>Return a Float2 vector constructed from a Bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(Bool2 v)
        {
            return new Float2(v);
        }

        /// <summary>Returns a Float2 vector constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(int v)
        {
            return new Float2(v);
        }

        /// <summary>Return a Float2 vector constructed from a Int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(Int2 v)
        {
            return new Float2(v);
        }

        /// <summary>Returns a Float2 vector constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(uint v)
        {
            return new Float2(v);
        }

        /// <summary>Return a Float2 vector constructed from a UInt2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Float2(UInt2 v)
        {
            return new Float2(v);
        }

        /// <summary>Returns a uint hash code of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float2 v)
        {
            return SumComponents(AsUInt(v) * UInt2(0xFA3A3285u, 0xAD55999Du)) + 0xDCDD5341u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Float2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Float2 v)
        {
            return (AsUInt(v) * UInt2(0x94DDD769u, 0xA1E92D39u)) + 0x4583C801u;
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float2 vectors into a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Shuffle(Float2 a, Float2 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float2 vectors into a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Shuffle(Float2 a, Float2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Float2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float2 vectors into a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Shuffle(Float2 a, Float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Float3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Float2 vectors into a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Shuffle(Float2 a, Float2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z,
            ShuffleComponent w)
        {
            return Float4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static SoftFloat SelectShuffleComponent(Float2 a, Float2 b, ShuffleComponent component)
        {
            switch (component)
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
