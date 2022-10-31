using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool2x2 : System.IEquatable<Bool2x2>
    {
        public Bool2 c0;
        public Bool2 c1;


        /// <summary>Constructs a Bool2x2 matrix from two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x2(Bool2 c0, Bool2 c1)
        {
            this.c0 = c0;
            this.c1 = c1;
        }

        /// <summary>Constructs a Bool2x2 matrix from 4 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x2(bool m00, bool m01,
            bool m10, bool m11)
        {
            c0 = new Bool2(m00, m10);
            c1 = new Bool2(m01, m11);
        }

        /// <summary>Constructs a Bool2x2 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x2(bool v)
        {
            c0 = v;
            c1 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool2x2 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool2x2(bool v)
        {
            return new Bool2x2(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ==(Bool2x2 lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool2x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ==(Bool2x2 lhs, bool rhs)
        {
            return new Bool2x2(lhs.c0 == rhs, lhs.c1 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ==(bool lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs == rhs.c0, lhs == rhs.c1);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator !=(Bool2x2 lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool2x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator !=(Bool2x2 lhs, bool rhs)
        {
            return new Bool2x2(lhs.c0 != rhs, lhs.c1 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator !=(bool lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs != rhs.c0, lhs != rhs.c1);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator !(Bool2x2 val)
        {
            return new Bool2x2(!val.c0, !val.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator &(Bool2x2 lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs.c0 & rhs.c0, lhs.c1 & rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool2x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator &(Bool2x2 lhs, bool rhs)
        {
            return new Bool2x2(lhs.c0 & rhs, lhs.c1 & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator &(bool lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs & rhs.c0, lhs & rhs.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator |(Bool2x2 lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs.c0 | rhs.c0, lhs.c1 | rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool2x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator |(Bool2x2 lhs, bool rhs)
        {
            return new Bool2x2(lhs.c0 | rhs, lhs.c1 | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator |(bool lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs | rhs.c0, lhs | rhs.c1);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool2x2 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ^(Bool2x2 lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool2x2 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ^(Bool2x2 lhs, bool rhs)
        {
            return new Bool2x2(lhs.c0 ^ rhs, lhs.c1 ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 operator ^(bool lhs, Bool2x2 rhs)
        {
            return new Bool2x2(lhs ^ rhs.c0, lhs ^ rhs.c1);
        }


        /// <summary>Returns the Bool2 element at a specified index.</summary>
        unsafe public ref Bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (Bool2x2* array = &this)
                {
                    return ref ((Bool2*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the Bool2x2 is equal to a given Bool2x2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool2x2 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1);
        }

        /// <summary>Returns true if the Bool2x2 is equal to a given Bool2x2, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool2x2)o);
        }


        /// <summary>Returns a hash code for the Bool2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool2x2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool2x2({0}, {1},  {2}, {3})", c0.X, c1.X, c0.Y, c1.Y);
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool2x2 matrix constructed from two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 Bool2x2(Bool2 c0, Bool2 c1)
        {
            return new Bool2x2(c0, c1);
        }

        /// <summary>Returns a Bool2x2 matrix constructed from from 4 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 Bool2x2(bool m00, bool m01,
            bool m10, bool m11)
        {
            return new Bool2x2(m00, m01,
                m10, m11);
        }

        /// <summary>Returns a Bool2x2 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 Bool2x2(bool v)
        {
            return new Bool2x2(v);
        }

        /// <summary>Return the Bool2x2 transpose of a Bool2x2 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x2 Transpose(Bool2x2 v)
        {
            return Bool2x2(
                v.c0.X, v.c0.Y,
                v.c1.X, v.c1.Y);
        }

        /// <summary>Returns a uint hash code of a Bool2x2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool2x2 v)
        {
            return SumComponents(Select(UInt2(0x7AF32C49u, 0xAE131389u), UInt2(0x5D1B165Bu, 0x87096CD7u), v.c0) +
                                 Select(UInt2(0x4C7F6DD1u, 0x4822A3E9u), UInt2(0xAAC3C25Du, 0xD21D0945u), v.c1));
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Bool2x2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Bool2x2 v)
        {
            return (Select(UInt2(0x88FCAB2Du, 0x614DA60Du), UInt2(0x5BA2C50Bu, 0x8C455ACBu), v.c0) +
                    Select(UInt2(0xCD266C89u, 0xF1852A33u), UInt2(0x77E35E77u, 0x863E3729u), v.c1));
        }
    }
}
