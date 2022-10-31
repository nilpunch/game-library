using System;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Float2x3 : IEquatable<Float2x3>, IFormattable
    {
        public Float2 c0;
        public Float2 c1;
        public Float2 c2;

        /// <summary>Float2x3 zero value.</summary>
        public static readonly Float2x3 zero;

        /// <summary>Constructs a Float2x3 matrix from three Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(Float2 c0, Float2 c1, Float2 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Float2x3 matrix from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
            SoftFloat m10, SoftFloat m11, SoftFloat m12)
        {
            c0 = new Float2(m00, m10);
            c1 = new Float2(m01, m11);
            c2 = new Float2(m02, m12);
        }

        /// <summary>Constructs a Float2x3 matrix from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(SoftFloat v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float2x3 matrix from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(bool v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
            c2 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v);
        }

        /// <summary>Constructs a Float2x3 matrix from a Bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(Bool2x3 v)
        {
            c0 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c0);
            c1 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c1);
            c2 = Math.Select(new Float2(SoftFloat.Zero), new Float2(SoftFloat.One), v.c2);
        }

        /// <summary>Constructs a Float2x3 matrix from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(int v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float2x3 matrix from a Int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(Int2x3 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
        }

        /// <summary>Constructs a Float2x3 matrix from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(uint v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }

        /// <summary>Constructs a Float2x3 matrix from a UInt2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Float2x3(UInt2x3 v)
        {
            c0 = v.c0;
            c1 = v.c1;
            c2 = v.c2;
        }


        /// <summary>Implicitly converts a single float value to a Float2x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x3(SoftFloat v)
        {
            return new Float2x3(v);
        }

        /// <summary>Explicitly converts a single bool value to a Float2x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2x3(bool v)
        {
            return new Float2x3(v);
        }

        /// <summary>Explicitly converts a Bool2x3 matrix to a Float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator Float2x3(Bool2x3 v)
        {
            return new Float2x3(v);
        }

        /// <summary>Implicitly converts a single int value to a Float2x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x3(int v)
        {
            return new Float2x3(v);
        }

        /// <summary>Implicitly converts a Int2x3 matrix to a Float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x3(Int2x3 v)
        {
            return new Float2x3(v);
        }

        /// <summary>Implicitly converts a single uint value to a Float2x3 matrix by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x3(uint v)
        {
            return new Float2x3(v);
        }

        /// <summary>Implicitly converts a UInt2x3 matrix to a Float2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Float2x3(UInt2x3 v)
        {
            return new Float2x3(v);
        }


        /// <summary>Returns the result of a componentwise multiplication operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator *(Float2x3 lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs.c0 * rhs.c0, lhs.c1 * rhs.c1, lhs.c2 * rhs.c2);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator *(Float2x3 lhs, SoftFloat rhs)
        {
            return new Float2x3(lhs.c0 * rhs, lhs.c1 * rhs, lhs.c2 * rhs);
        }

        /// <summary>Returns the result of a componentwise multiplication operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator *(SoftFloat lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs * rhs.c0, lhs * rhs.c1, lhs * rhs.c2);
        }


        /// <summary>Returns the result of a componentwise addition operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator +(Float2x3 lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs.c0 + rhs.c0, lhs.c1 + rhs.c1, lhs.c2 + rhs.c2);
        }

        /// <summary>Returns the result of a componentwise addition operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator +(Float2x3 lhs, SoftFloat rhs)
        {
            return new Float2x3(lhs.c0 + rhs, lhs.c1 + rhs, lhs.c2 + rhs);
        }

        /// <summary>Returns the result of a componentwise addition operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator +(SoftFloat lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs + rhs.c0, lhs + rhs.c1, lhs + rhs.c2);
        }


        /// <summary>Returns the result of a componentwise subtraction operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator -(Float2x3 lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs.c0 - rhs.c0, lhs.c1 - rhs.c1, lhs.c2 - rhs.c2);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator -(Float2x3 lhs, SoftFloat rhs)
        {
            return new Float2x3(lhs.c0 - rhs, lhs.c1 - rhs, lhs.c2 - rhs);
        }

        /// <summary>Returns the result of a componentwise subtraction operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator -(SoftFloat lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs - rhs.c0, lhs - rhs.c1, lhs - rhs.c2);
        }


        /// <summary>Returns the result of a componentwise division operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator /(Float2x3 lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs.c0 / rhs.c0, lhs.c1 / rhs.c1, lhs.c2 / rhs.c2);
        }

        /// <summary>Returns the result of a componentwise division operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator /(Float2x3 lhs, SoftFloat rhs)
        {
            return new Float2x3(lhs.c0 / rhs, lhs.c1 / rhs, lhs.c2 / rhs);
        }

        /// <summary>Returns the result of a componentwise division operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator /(SoftFloat lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs / rhs.c0, lhs / rhs.c1, lhs / rhs.c2);
        }


        /// <summary>Returns the result of a componentwise modulus operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator %(Float2x3 lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs.c0 % rhs.c0, lhs.c1 % rhs.c1, lhs.c2 % rhs.c2);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator %(Float2x3 lhs, SoftFloat rhs)
        {
            return new Float2x3(lhs.c0 % rhs, lhs.c1 % rhs, lhs.c2 % rhs);
        }

        /// <summary>Returns the result of a componentwise modulus operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator %(SoftFloat lhs, Float2x3 rhs)
        {
            return new Float2x3(lhs % rhs.c0, lhs % rhs.c1, lhs % rhs.c2);
        }


        /// <summary>Returns the result of a componentwise less than operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 < rhs.c0, lhs.c1 < rhs.c1, lhs.c2 < rhs.c2);
        }

        /// <summary>Returns the result of a componentwise less than operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 < rhs, lhs.c1 < rhs, lhs.c2 < rhs);
        }

        /// <summary>Returns the result of a componentwise less than operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs < rhs.c0, lhs < rhs.c1, lhs < rhs.c2);
        }


        /// <summary>Returns the result of a componentwise less or equal operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <=(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 <= rhs.c0, lhs.c1 <= rhs.c1, lhs.c2 <= rhs.c2);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <=(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 <= rhs, lhs.c1 <= rhs, lhs.c2 <= rhs);
        }

        /// <summary>Returns the result of a componentwise less or equal operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator <=(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs <= rhs.c0, lhs <= rhs.c1, lhs <= rhs.c2);
        }


        /// <summary>Returns the result of a componentwise greater than operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 > rhs.c0, lhs.c1 > rhs.c1, lhs.c2 > rhs.c2);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 > rhs, lhs.c1 > rhs, lhs.c2 > rhs);
        }

        /// <summary>Returns the result of a componentwise greater than operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs > rhs.c0, lhs > rhs.c1, lhs > rhs.c2);
        }


        /// <summary>Returns the result of a componentwise greater or equal operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >=(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 >= rhs.c0, lhs.c1 >= rhs.c1, lhs.c2 >= rhs.c2);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >=(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 >= rhs, lhs.c1 >= rhs, lhs.c2 >= rhs);
        }

        /// <summary>Returns the result of a componentwise greater or equal operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator >=(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs >= rhs.c0, lhs >= rhs.c1, lhs >= rhs.c2);
        }


        /// <summary>Returns the result of a componentwise unary minus operation on a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 operator -(Float2x3 val)
        {
            return new Float2x3(-val.c0, -val.c1, -val.c2);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Float2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(Float2x3 lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Float2x3 matrix and a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(Float2x3 lhs, SoftFloat rhs)
        {
            return new Bool2x3(lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a float value and a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(SoftFloat lhs, Float2x3 rhs)
        {
            return new Bool2x3(lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2);
        }


        /// <summary>Returns the Float2 element at a specified index.</summary>
        unsafe public ref Float2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif
                fixed (Float2x3* array = &this)
                {
                    return ref ((Float2*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the Float2x3 is equal to a given Float2x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Float2x3 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2);
        }

        /// <summary>Returns true if the Float2x3 is equal to a given Float2x3, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Float2x3)o);
        }


        /// <summary>Returns a hash code for the Float2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Float2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y);
        }

        /// <summary>Returns a string representation of the Float2x3 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float2x3({0}f, {1}f, {2}f,  {3}f, {4}f, {5}f)", c0.x.ToString(format, formatProvider),
                c1.x.ToString(format, formatProvider), c2.x.ToString(format, formatProvider),
                c0.y.ToString(format, formatProvider), c1.y.ToString(format, formatProvider),
                c2.y.ToString(format, formatProvider));
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Float2x3 matrix constructed from three Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(Float2 c0, Float2 c1, Float2 c2)
        {
            return new Float2x3(c0, c1, c2);
        }

        /// <summary>Returns a Float2x3 matrix constructed from from 6 float values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(SoftFloat m00, SoftFloat m01, SoftFloat m02,
            SoftFloat m10, SoftFloat m11, SoftFloat m12)
        {
            return new Float2x3(m00, m01, m02,
                m10, m11, m12);
        }

        /// <summary>Returns a Float2x3 matrix constructed from a single float value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(SoftFloat v)
        {
            return new Float2x3(v);
        }

        /// <summary>Returns a Float2x3 matrix constructed from a single bool value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(bool v)
        {
            return new Float2x3(v);
        }

        /// <summary>Return a Float2x3 matrix constructed from a Bool2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(Bool2x3 v)
        {
            return new Float2x3(v);
        }

        /// <summary>Returns a Float2x3 matrix constructed from a single int value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(int v)
        {
            return new Float2x3(v);
        }

        /// <summary>Return a Float2x3 matrix constructed from a Int2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(Int2x3 v)
        {
            return new Float2x3(v);
        }

        /// <summary>Returns a Float2x3 matrix constructed from a single uint value by converting it to float and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(uint v)
        {
            return new Float2x3(v);
        }

        /// <summary>Return a Float2x3 matrix constructed from a UInt2x3 matrix by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2x3 Float2x3(UInt2x3 v)
        {
            return new Float2x3(v);
        }

        /// <summary>Return the Float3x2 transpose of a Float2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3x2 Transpose(Float2x3 v)
        {
            return Float3x2(
                v.c0.x, v.c0.y,
                v.c1.x, v.c1.y,
                v.c2.x, v.c2.y);
        }

        /// <summary>Returns a uint hash code of a Float2x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Float2x3 v)
        {
            return SumComponents(AsUInt(v.c0) * UInt2(0xE857DCE1u, 0xF62213C5u) +
                                 AsUInt(v.c1) * UInt2(0x9CDAA959u, 0xAA269ABFu) +
                                 AsUInt(v.c2) * UInt2(0xD54BA36Fu, 0xFD0847B9u)) + 0x8189A683u;
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Float2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Float2x3 v)
        {
            return (AsUInt(v.c0) * UInt2(0xB139D651u, 0xE7579997u) +
                    AsUInt(v.c1) * UInt2(0xEF7D56C7u, 0x66F38F0Bu) +
                    AsUInt(v.c2) * UInt2(0x624256A3u, 0x5292ADE1u)) + 0xD2E590E5u;
        }
    }
}
