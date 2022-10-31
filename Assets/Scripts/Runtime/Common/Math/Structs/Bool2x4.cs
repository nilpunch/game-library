using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool2x4 : System.IEquatable<Bool2x4>
    {
        public Bool2 c0;
        public Bool2 c1;
        public Bool2 c2;
        public Bool2 c3;


        /// <summary>Constructs a Bool2x4 matrix from four Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x4(Bool2 c0, Bool2 c1, Bool2 c2, Bool2 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Bool2x4 matrix from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x4(bool m00, bool m01, bool m02, bool m03,
            bool m10, bool m11, bool m12, bool m13)
        {
            c0 = new Bool2(m00, m10);
            c1 = new Bool2(m01, m11);
            c2 = new Bool2(m02, m12);
            c3 = new Bool2(m03, m13);
        }

        /// <summary>Constructs a Bool2x4 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x4(bool v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool2x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool2x4(bool v)
        {
            return new Bool2x4(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ==(Bool2x4 lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ==(Bool2x4 lhs, bool rhs)
        {
            return new Bool2x4(lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ==(bool lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator !=(Bool2x4 lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator !=(Bool2x4 lhs, bool rhs)
        {
            return new Bool2x4(lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator !=(bool lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator !(Bool2x4 val)
        {
            return new Bool2x4(!val.c0, !val.c1, !val.c2, !val.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator &(Bool2x4 lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator &(Bool2x4 lhs, bool rhs)
        {
            return new Bool2x4(lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator &(bool lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator |(Bool2x4 lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator |(Bool2x4 lhs, bool rhs)
        {
            return new Bool2x4(lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator |(bool lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool2x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ^(Bool2x4 lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool2x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ^(Bool2x4 lhs, bool rhs)
        {
            return new Bool2x4(lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 operator ^(bool lhs, Bool2x4 rhs)
        {
            return new Bool2x4(lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3);
        }


        /// <summary>Returns the Bool2 element at a specified index.</summary>
        unsafe public ref Bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (Bool2x4* array = &this)
                {
                    return ref ((Bool2*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the Bool2x4 is equal to a given Bool2x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool2x4 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3);
        }

        /// <summary>Returns true if the Bool2x4 is equal to a given Bool2x4, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool2x4)o);
        }


        /// <summary>Returns a hash code for the Bool2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool2x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool2x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7})", c0.X, c1.X, c2.X, c3.X, c0.Y, c1.Y,
                c2.Y, c3.Y);
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool2x4 matrix constructed from four Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 Bool2x4(Bool2 c0, Bool2 c1, Bool2 c2, Bool2 c3)
        {
            return new Bool2x4(c0, c1, c2, c3);
        }

        /// <summary>Returns a Bool2x4 matrix constructed from from 8 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 Bool2x4(bool m00, bool m01, bool m02, bool m03,
            bool m10, bool m11, bool m12, bool m13)
        {
            return new Bool2x4(m00, m01, m02, m03,
                m10, m11, m12, m13);
        }

        /// <summary>Returns a Bool2x4 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x4 Bool2x4(bool v)
        {
            return new Bool2x4(v);
        }

        /// <summary>Return the Bool4x2 transpose of a Bool2x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x2 Transpose(Bool2x4 v)
        {
            return Bool4x2(
                v.c0.X, v.c0.Y,
                v.c1.X, v.c1.Y,
                v.c2.X, v.c2.Y,
                v.c3.X, v.c3.Y);
        }

        /// <summary>Returns a uint hash code of a Bool2x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool2x4 v)
        {
            return SumComponents(Select(UInt2(0x45A22087u, 0xFC104C3Bu), UInt2(0x5FFF6B19u, 0x5E6CBF3Bu), v.c0) +
                                 Select(UInt2(0xB546F2A5u, 0xBBCF63E7u), UInt2(0xC53F4755u, 0x6985C229u), v.c1) +
                                 Select(UInt2(0xE133B0B3u, 0xC3E0A3B9u), UInt2(0xFE31134Fu, 0x712A34D7u), v.c2) +
                                 Select(UInt2(0x9D77A59Bu, 0x4942CA39u), UInt2(0xB40EC62Du, 0x565ED63Fu), v.c3));
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Bool2x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Bool2x4 v)
        {
            return (Select(UInt2(0x93C30C2Bu, 0xDCAF0351u), UInt2(0x6E050B01u, 0x750FDBF5u), v.c0) +
                    Select(UInt2(0x7F3DD499u, 0x52EAAEBBu), UInt2(0x4599C793u, 0x83B5E729u), v.c1) +
                    Select(UInt2(0xC267163Fu, 0x67BC9149u), UInt2(0xAD7C5EC1u, 0x822A7D6Du), v.c2) +
                    Select(UInt2(0xB492BF15u, 0xD37220E3u), UInt2(0x7AA2C2BDu, 0xE16BC89Du), v.c3));
        }
    }
}
