using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool4x2 : System.IEquatable<Bool4x2>
    {
        public Bool4 c0;
        public Bool4 c1;


        /// <summary>Constructs a Bool4x2 matrix from two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x2(Bool4 c0, Bool4 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Bool4x2 matrix from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x2(bool m00, bool m01,
            bool m10, bool m11,
            bool m20, bool m21,
            bool m30, bool m31)
        {
            c0 = new Bool4(m00, m10, m20, m30);
            c1 = new Bool4(m01, m11, m21, m31);
        }

        /// <summary>Constructs a Bool4x2 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x2(bool v)
        {
            c0 = v;
            c1 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool4x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool4x2(bool v)
        {
            return new Bool4x2(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ==(Bool4x2 lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool4x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ==(Bool4x2 lhs, bool rhs)
        {
            return new Bool4x2(lhs.c0 == rhs, lhs.c1 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ==(bool lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs == rhs.c0, lhs == rhs.c1);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator !=(Bool4x2 lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool4x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator !=(Bool4x2 lhs, bool rhs)
        {
            return new Bool4x2(lhs.c0 != rhs, lhs.c1 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator !=(bool lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs != rhs.c0, lhs != rhs.c1);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator !(Bool4x2 val)
        {
            return new Bool4x2(!val.c0, !val.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator &(Bool4x2 lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs.c0 & rhs.c0, lhs.c1 & rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool4x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator &(Bool4x2 lhs, bool rhs)
        {
            return new Bool4x2(lhs.c0 & rhs, lhs.c1 & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator &(bool lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs & rhs.c0, lhs & rhs.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator |(Bool4x2 lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs.c0 | rhs.c0, lhs.c1 | rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool4x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator |(Bool4x2 lhs, bool rhs)
        {
            return new Bool4x2(lhs.c0 | rhs, lhs.c1 | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator |(bool lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs | rhs.c0, lhs | rhs.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool4x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ^(Bool4x2 lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool4x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ^(Bool4x2 lhs, bool rhs)
        {
            return new Bool4x2(lhs.c0 ^ rhs, lhs.c1 ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 operator ^(bool lhs, Bool4x2 rhs)
        {
            return new Bool4x2(lhs ^ rhs.c0, lhs ^ rhs.c1);
        }


        /// <summary>Returns the Bool4 element at a specified index.</summary>
        unsafe public ref Bool4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (Bool4x2* array = &this)
                {
                    return ref ((Bool4*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the Bool4x2 is equal to a given Bool4x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool4x2 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1);
        }

        /// <summary>Returns true if the Bool4x2 is equal to a given Bool4x2, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool4x2)o);
        }


        /// <summary>Returns a hash code for the Bool4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool4x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool4x2({0}, {1},  {2}, {3},  {4}, {5},  {6}, {7})", c0.x, c1.x, c0.y, c1.y, c0.z,
                c1.z, c0.w, c1.w);
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool4x2 matrix constructed from two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 Bool4x2(Bool4 c0, Bool4 c1)
        {
            return new Bool4x2(c0, c1);
        }

        /// <summary>Returns a Bool4x2 matrix constructed from from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 Bool4x2(bool m00, bool m01,
            bool m10, bool m11,
            bool m20, bool m21,
            bool m30, bool m31)
        {
            return new Bool4x2(m00, m01,
                m10, m11,
                m20, m21,
                m30, m31);
        }

        /// <summary>Returns a Bool4x2 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 Bool4x2(bool v)
        {
            return new Bool4x2(v);
        }

        /// <summary>Return the Bool2x4 transpose of a Bool4x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 Transpose(Bool4x2 v)
        {
            return Bool2x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w);
        }

        /// <summary>Returns a uint hash code of a Bool4x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool4x2 v)
        {
            return SumComponents(Select(UInt4(0xD19764C7u, 0xB5D0BF63u, 0xF9102C5Fu, 0x9881FB9Fu),
                                     UInt4(0x56A1530Du, 0x804B722Du, 0x738E50E5u, 0x4FC93C25u), v.c0) +
                                 Select(UInt4(0xCD0445A5u, 0xD2B90D9Bu, 0xD35C9B2Du, 0xA10D9E27u),
                                     UInt4(0x568DAAA9u, 0x7530254Fu, 0x9F090439u, 0x5E9F85C9u), v.c1));
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Bool4x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Bool4x2 v)
        {
            return (Select(UInt4(0x8C4CA03Fu, 0xB8D969EDu, 0xAC5DB57Bu, 0xA91A02EDu),
                        UInt4(0xB3C49313u, 0xF43A9ABBu, 0x84E7E01Bu, 0x8E055BE5u), v.c0) +
                    Select(UInt4(0x6E624EB7u, 0x7383ED49u, 0xDD49C23Bu, 0xEBD0D005u),
                        UInt4(0x91475DF7u, 0x55E84827u, 0x90A285BBu, 0x5D19E1D5u), v.c1));
        }
    }
}
