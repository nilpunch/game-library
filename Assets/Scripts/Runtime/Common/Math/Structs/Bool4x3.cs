using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool4x3 : System.IEquatable<Bool4x3>
    {
        public Bool4 c0;
        public Bool4 c1;
        public Bool4 c2;


        /// <summary>Constructs a Bool4x3 matrix from three Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x3(Bool4 c0, Bool4 c1, Bool4 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Bool4x3 matrix from 12 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12,
                       bool m20, bool m21, bool m22,
                       bool m30, bool m31, bool m32)
        {
            c0 = new Bool4(m00, m10, m20, m30);
            c1 = new Bool4(m01, m11, m21, m31);
            c2 = new Bool4(m02, m12, m22, m32);
        }

        /// <summary>Constructs a Bool4x3 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4x3(bool v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool4x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool4x3(bool v) { return new Bool4x3(v); }


        /// <summary>Returns the result of a componentwise equality operation on two Bool4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Bool4x3 lhs, Bool4x3 rhs) { return new Bool4x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a Bool4x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (Bool4x3 lhs, bool rhs) { return new Bool4x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator == (bool lhs, Bool4x3 rhs) { return new Bool4x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Bool4x3 lhs, Bool4x3 rhs) { return new Bool4x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool4x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (Bool4x3 lhs, bool rhs) { return new Bool4x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator != (bool lhs, Bool4x3 rhs) { return new Bool4x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise not operation on a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator ! (Bool4x3 val) { return new Bool4x3 (!val.c0, !val.c1, !val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator & (Bool4x3 lhs, Bool4x3 rhs) { return new Bool4x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool4x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator & (Bool4x3 lhs, bool rhs) { return new Bool4x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator & (bool lhs, Bool4x3 rhs) { return new Bool4x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator | (Bool4x3 lhs, Bool4x3 rhs) { return new Bool4x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool4x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator | (Bool4x3 lhs, bool rhs) { return new Bool4x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator | (bool lhs, Bool4x3 rhs) { return new Bool4x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool4x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator ^ (Bool4x3 lhs, Bool4x3 rhs) { return new Bool4x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool4x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator ^ (Bool4x3 lhs, bool rhs) { return new Bool4x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 operator ^ (bool lhs, Bool4x3 rhs) { return new Bool4x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the Bool4 element at a specified index.</summary>
        unsafe public ref Bool4 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (Bool4x3* array = &this) { return ref ((Bool4*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Bool4x3 is equal to a given Bool4x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool4x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the Bool4x3 is equal to a given Bool4x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Bool4x3)o); }


        /// <summary>Returns a hash code for the Bool4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.hash(this); }


        /// <summary>Returns a string representation of the Bool4x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool4x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8},  {9}, {10}, {11})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z, c0.w, c1.w, c2.w);
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Bool4x3 matrix constructed from three Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 Bool4x3(Bool4 c0, Bool4 c1, Bool4 c2) { return new Bool4x3(c0, c1, c2); }

        /// <summary>Returns a Bool4x3 matrix constructed from from 12 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 Bool4x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12,
                                      bool m20, bool m21, bool m22,
                                      bool m30, bool m31, bool m32)
        {
            return new Bool4x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22,
                               m30, m31, m32);
        }

        /// <summary>Returns a Bool4x3 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 Bool4x3(bool v) { return new Bool4x3(v); }

        /// <summary>Return the Bool3x4 transpose of a Bool4x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 transpose(Bool4x3 v)
        {
            return Bool3x4(
                v.c0.x, v.c0.y, v.c0.z, v.c0.w,
                v.c1.x, v.c1.y, v.c1.z, v.c1.w,
                v.c2.x, v.c2.y, v.c2.z, v.c2.w);
        }

        /// <summary>Returns a uint hash code of a Bool4x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(Bool4x3 v)
        {
            return SumComponents(Select(UInt4(0xEADF0775u, 0x747A9D7Bu, 0x4111F799u, 0xB5F05AF1u), UInt4(0xFD80290Bu, 0x8B65ADB7u, 0xDFF4F563u, 0x7069770Du), v.c0) +
                        Select(UInt4(0xD1224537u, 0xE99ED6F3u, 0x48125549u, 0xEEE2123Bu), UInt4(0xE3AD9FE5u, 0xCE1CF8BFu, 0x7BE39F3Bu, 0xFAB9913Fu), v.c1) +
                        Select(UInt4(0xB4501269u, 0xE04B89FDu, 0xDB3DE101u, 0x7B6D1B4Bu), UInt4(0x58399E77u, 0x5EAC29C9u, 0xFC6014F9u, 0x6BF6693Fu), v.c2));
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Bool4x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 hashwide(Bool4x3 v)
        {
            return (Select(UInt4(0x9D1B1D9Bu, 0xF842F5C1u, 0xA47EC335u, 0xA477DF57u), UInt4(0xC4B1493Fu, 0xBA0966D3u, 0xAFBEE253u, 0x5B419C01u), v.c0) +
                    Select(UInt4(0x515D90F5u, 0xEC9F68F3u, 0xF9EA92D5u, 0xC2FAFCB9u), UInt4(0x616E9CA1u, 0xC5C5394Bu, 0xCAE78587u, 0x7A1541C9u), v.c1) +
                    Select(UInt4(0xF83BD927u, 0x6A243BCBu, 0x509B84C9u, 0x91D13847u), UInt4(0x52F7230Fu, 0xCF286E83u, 0xE121E6ADu, 0xC9CA1249u), v.c2));
        }

    }
}
