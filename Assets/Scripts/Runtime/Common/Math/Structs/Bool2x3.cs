using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool2x3 : System.IEquatable<Bool2x3>
    {
        public Bool2 c0;
        public Bool2 c1;
        public Bool2 c2;


        /// <summary>Constructs a Bool2x3 matrix from three Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x3(Bool2 c0, Bool2 c1, Bool2 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Bool2x3 matrix from 6 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x3(bool m00, bool m01, bool m02,
            bool m10, bool m11, bool m12)
        {
            c0 = new Bool2(m00, m10);
            c1 = new Bool2(m01, m11);
            c2 = new Bool2(m02, m12);
        }

        /// <summary>Constructs a Bool2x3 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2x3(bool v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool2x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool2x3(bool v)
        {
            return new Bool2x3(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(Bool2x3 lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(Bool2x3 lhs, bool rhs)
        {
            return new Bool2x3(lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ==(bool lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(Bool2x3 lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(Bool2x3 lhs, bool rhs)
        {
            return new Bool2x3(lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !=(bool lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator !(Bool2x3 val)
        {
            return new Bool2x3(!val.c0, !val.c1, !val.c2);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator &(Bool2x3 lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator &(Bool2x3 lhs, bool rhs)
        {
            return new Bool2x3(lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator &(bool lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator |(Bool2x3 lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator |(Bool2x3 lhs, bool rhs)
        {
            return new Bool2x3(lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator |(bool lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool2x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ^(Bool2x3 lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool2x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ^(Bool2x3 lhs, bool rhs)
        {
            return new Bool2x3(lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 operator ^(bool lhs, Bool2x3 rhs)
        {
            return new Bool2x3(lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2);
        }


        /// <summary>Returns the Bool2 element at a specified index.</summary>
        unsafe public ref Bool2 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (Bool2x3* array = &this)
                {
                    return ref ((Bool2*)array)[index];
                }
            }
        }

        /// <summary>Returns true if the Bool2x3 is equal to a given Bool2x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool2x3 rhs)
        {
            return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2);
        }

        /// <summary>Returns true if the Bool2x3 is equal to a given Bool2x3, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool2x3)o);
        }


        /// <summary>Returns a hash code for the Bool2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool2x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool2x3({0}, {1}, {2},  {3}, {4}, {5})", c0.X, c1.X, c2.X, c0.Y, c1.Y, c2.Y);
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool2x3 matrix constructed from three Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 Bool2x3(Bool2 c0, Bool2 c1, Bool2 c2)
        {
            return new Bool2x3(c0, c1, c2);
        }

        /// <summary>Returns a Bool2x3 matrix constructed from from 6 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 Bool2x3(bool m00, bool m01, bool m02,
            bool m10, bool m11, bool m12)
        {
            return new Bool2x3(m00, m01, m02,
                m10, m11, m12);
        }

        /// <summary>Returns a Bool2x3 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2x3 Bool2x3(bool v)
        {
            return new Bool2x3(v);
        }

        /// <summary>Return the Bool3x2 transpose of a Bool2x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x2 Transpose(Bool2x3 v)
        {
            return Bool3x2(
                v.c0.X, v.c0.Y,
                v.c1.X, v.c1.Y,
                v.c2.X, v.c2.Y);
        }

        /// <summary>Returns a uint hash code of a Bool2x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool2x3 v)
        {
            return SumComponents(Select(UInt2(0x7BE39F3Bu, 0xFAB9913Fu), UInt2(0xB4501269u, 0xE04B89FDu), v.c0) +
                                 Select(UInt2(0xDB3DE101u, 0x7B6D1B4Bu), UInt2(0x58399E77u, 0x5EAC29C9u), v.c1) +
                                 Select(UInt2(0xFC6014F9u, 0x6BF6693Fu), UInt2(0x9D1B1D9Bu, 0xF842F5C1u), v.c2));
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Bool2x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Bool2x3 v)
        {
            return (Select(UInt2(0xA47EC335u, 0xA477DF57u), UInt2(0xC4B1493Fu, 0xBA0966D3u), v.c0) +
                    Select(UInt2(0xAFBEE253u, 0x5B419C01u), UInt2(0x515D90F5u, 0xEC9F68F3u), v.c1) +
                    Select(UInt2(0xF9EA92D5u, 0xC2FAFCB9u), UInt2(0x616E9CA1u, 0xC5C5394Bu), v.c2));
        }
    }
}
