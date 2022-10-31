using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool3x3 : System.IEquatable<Bool3x3>
    {
        public Bool3 c0;
        public Bool3 c1;
        public Bool3 c2;


        /// <summary>Constructs a Bool3x3 matrix from three Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x3(Bool3 c0, Bool3 c1, Bool3 c2)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
        }

        /// <summary>Constructs a Bool3x3 matrix from 9 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x3(bool m00, bool m01, bool m02,
                       bool m10, bool m11, bool m12,
                       bool m20, bool m21, bool m22)
        {
            c0 = new Bool3(m00, m10, m20);
            c1 = new Bool3(m01, m11, m21);
            c2 = new Bool3(m02, m12, m22);
        }

        /// <summary>Constructs a Bool3x3 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x3(bool v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool3x3 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool3x3(bool v) { return new Bool3x3(v); }


        /// <summary>Returns the result of a componentwise equality operation on two Bool3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (Bool3x3 lhs, Bool3x3 rhs) { return new Bool3x3 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2); }

        /// <summary>Returns the result of a componentwise equality operation on a Bool3x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (Bool3x3 lhs, bool rhs) { return new Bool3x3 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator == (bool lhs, Bool3x3 rhs) { return new Bool3x3 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2); }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (Bool3x3 lhs, Bool3x3 rhs) { return new Bool3x3 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2); }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool3x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (Bool3x3 lhs, bool rhs) { return new Bool3x3 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator != (bool lhs, Bool3x3 rhs) { return new Bool3x3 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2); }


        /// <summary>Returns the result of a componentwise not operation on a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator ! (Bool3x3 val) { return new Bool3x3 (!val.c0, !val.c1, !val.c2); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator & (Bool3x3 lhs, Bool3x3 rhs) { return new Bool3x3 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool3x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator & (Bool3x3 lhs, bool rhs) { return new Bool3x3 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator & (bool lhs, Bool3x3 rhs) { return new Bool3x3 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator | (Bool3x3 lhs, Bool3x3 rhs) { return new Bool3x3 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool3x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator | (Bool3x3 lhs, bool rhs) { return new Bool3x3 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator | (bool lhs, Bool3x3 rhs) { return new Bool3x3 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool3x3 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator ^ (Bool3x3 lhs, Bool3x3 rhs) { return new Bool3x3 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool3x3 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator ^ (Bool3x3 lhs, bool rhs) { return new Bool3x3 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 operator ^ (bool lhs, Bool3x3 rhs) { return new Bool3x3 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2); }



        /// <summary>Returns the Bool3 element at a specified index.</summary>
        unsafe public ref Bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (Bool3x3* array = &this) { return ref ((Bool3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Bool3x3 is equal to a given Bool3x3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool3x3 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2); }

        /// <summary>Returns true if the Bool3x3 is equal to a given Bool3x3, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Bool3x3)o); }


        /// <summary>Returns a hash code for the Bool3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Bool3x3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool3x3({0}, {1}, {2},  {3}, {4}, {5},  {6}, {7}, {8})", c0.x, c1.x, c2.x, c0.y, c1.y, c2.y, c0.z, c1.z, c2.z);
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Bool3x3 matrix constructed from three Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 Bool3x3(Bool3 c0, Bool3 c1, Bool3 c2) { return new Bool3x3(c0, c1, c2); }

        /// <summary>Returns a Bool3x3 matrix constructed from from 9 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 Bool3x3(bool m00, bool m01, bool m02,
                                      bool m10, bool m11, bool m12,
                                      bool m20, bool m21, bool m22)
        {
            return new Bool3x3(m00, m01, m02,
                               m10, m11, m12,
                               m20, m21, m22);
        }

        /// <summary>Returns a Bool3x3 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 Bool3x3(bool v) { return new Bool3x3(v); }

        /// <summary>Return the Bool3x3 transpose of a Bool3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x3 Transpose(Bool3x3 v)
        {
            return Bool3x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z);
        }

        /// <summary>Returns a uint hash code of a Bool3x3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool3x3 v)
        {
            return SumComponents(Select(UInt3(0xE7579997u, 0xEF7D56C7u, 0x66F38F0Bu), UInt3(0x624256A3u, 0x5292ADE1u, 0xD2E590E5u), v.c0) +
                        Select(UInt3(0xF25BE857u, 0x9BC17CE7u, 0xC8B86851u), UInt3(0x64095221u, 0xADF428FFu, 0xA3977109u), v.c1) +
                        Select(UInt3(0x745ED837u, 0x9CDC88F5u, 0xFA62D721u), UInt3(0x7E4DB1CFu, 0x68EEE0F5u, 0xBC3B0A59u), v.c2));
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Bool3x3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Bool3x3 v)
        {
            return (Select(UInt3(0x816EFB5Du, 0xA24E82B7u, 0x45A22087u), UInt3(0xFC104C3Bu, 0x5FFF6B19u, 0x5E6CBF3Bu), v.c0) +
                    Select(UInt3(0xB546F2A5u, 0xBBCF63E7u, 0xC53F4755u), UInt3(0x6985C229u, 0xE133B0B3u, 0xC3E0A3B9u), v.c1) +
                    Select(UInt3(0xFE31134Fu, 0x712A34D7u, 0x9D77A59Bu), UInt3(0x4942CA39u, 0xB40EC62Du, 0x565ED63Fu), v.c2));
        }

    }
}
