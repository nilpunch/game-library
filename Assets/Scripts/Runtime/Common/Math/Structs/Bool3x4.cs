using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [System.Serializable]
    public struct Bool3x4 : System.IEquatable<Bool3x4>
    {
        public Bool3 c0;
        public Bool3 c1;
        public Bool3 c2;
        public Bool3 c3;


        /// <summary>Constructs a Bool3x4 matrix from four Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x4(Bool3 c0, Bool3 c1, Bool3 c2, Bool3 c3)
        {
            this.c0 = c0;
            this.c1 = c1;
            this.c2 = c2;
            this.c3 = c3;
        }

        /// <summary>Constructs a Bool3x4 matrix from 12 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x4(bool m00, bool m01, bool m02, bool m03,
                       bool m10, bool m11, bool m12, bool m13,
                       bool m20, bool m21, bool m22, bool m23)
        {
            c0 = new Bool3(m00, m10, m20);
            c1 = new Bool3(m01, m11, m21);
            c2 = new Bool3(m02, m12, m22);
            c3 = new Bool3(m03, m13, m23);
        }

        /// <summary>Constructs a Bool3x4 matrix from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3x4(bool v)
        {
            c0 = v;
            c1 = v;
            c2 = v;
            c3 = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool3x4 matrix by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool3x4(bool v) { return new Bool3x4(v); }


        /// <summary>Returns the result of a componentwise equality operation on two Bool3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (Bool3x4 lhs, Bool3x4 rhs) { return new Bool3x4 (lhs.c0 == rhs.c0, lhs.c1 == rhs.c1, lhs.c2 == rhs.c2, lhs.c3 == rhs.c3); }

        /// <summary>Returns the result of a componentwise equality operation on a Bool3x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (Bool3x4 lhs, bool rhs) { return new Bool3x4 (lhs.c0 == rhs, lhs.c1 == rhs, lhs.c2 == rhs, lhs.c3 == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator == (bool lhs, Bool3x4 rhs) { return new Bool3x4 (lhs == rhs.c0, lhs == rhs.c1, lhs == rhs.c2, lhs == rhs.c3); }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (Bool3x4 lhs, Bool3x4 rhs) { return new Bool3x4 (lhs.c0 != rhs.c0, lhs.c1 != rhs.c1, lhs.c2 != rhs.c2, lhs.c3 != rhs.c3); }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool3x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (Bool3x4 lhs, bool rhs) { return new Bool3x4 (lhs.c0 != rhs, lhs.c1 != rhs, lhs.c2 != rhs, lhs.c3 != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator != (bool lhs, Bool3x4 rhs) { return new Bool3x4 (lhs != rhs.c0, lhs != rhs.c1, lhs != rhs.c2, lhs != rhs.c3); }


        /// <summary>Returns the result of a componentwise not operation on a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ! (Bool3x4 val) { return new Bool3x4 (!val.c0, !val.c1, !val.c2, !val.c3); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator & (Bool3x4 lhs, Bool3x4 rhs) { return new Bool3x4 (lhs.c0 & rhs.c0, lhs.c1 & rhs.c1, lhs.c2 & rhs.c2, lhs.c3 & rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool3x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator & (Bool3x4 lhs, bool rhs) { return new Bool3x4 (lhs.c0 & rhs, lhs.c1 & rhs, lhs.c2 & rhs, lhs.c3 & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator & (bool lhs, Bool3x4 rhs) { return new Bool3x4 (lhs & rhs.c0, lhs & rhs.c1, lhs & rhs.c2, lhs & rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator | (Bool3x4 lhs, Bool3x4 rhs) { return new Bool3x4 (lhs.c0 | rhs.c0, lhs.c1 | rhs.c1, lhs.c2 | rhs.c2, lhs.c3 | rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool3x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator | (Bool3x4 lhs, bool rhs) { return new Bool3x4 (lhs.c0 | rhs, lhs.c1 | rhs, lhs.c2 | rhs, lhs.c3 | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator | (bool lhs, Bool3x4 rhs) { return new Bool3x4 (lhs | rhs.c0, lhs | rhs.c1, lhs | rhs.c2, lhs | rhs.c3); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool3x4 matrices.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ^ (Bool3x4 lhs, Bool3x4 rhs) { return new Bool3x4 (lhs.c0 ^ rhs.c0, lhs.c1 ^ rhs.c1, lhs.c2 ^ rhs.c2, lhs.c3 ^ rhs.c3); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool3x4 matrix and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ^ (Bool3x4 lhs, bool rhs) { return new Bool3x4 (lhs.c0 ^ rhs, lhs.c1 ^ rhs, lhs.c2 ^ rhs, lhs.c3 ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 operator ^ (bool lhs, Bool3x4 rhs) { return new Bool3x4 (lhs ^ rhs.c0, lhs ^ rhs.c1, lhs ^ rhs.c2, lhs ^ rhs.c3); }



        /// <summary>Returns the Bool3 element at a specified index.</summary>
        unsafe public ref Bool3 this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (Bool3x4* array = &this) { return ref ((Bool3*)array)[index]; }
            }
        }

        /// <summary>Returns true if the Bool3x4 is equal to a given Bool3x4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool3x4 rhs) { return c0.Equals(rhs.c0) && c1.Equals(rhs.c1) && c2.Equals(rhs.c2) && c3.Equals(rhs.c3); }

        /// <summary>Returns true if the Bool3x4 is equal to a given Bool3x4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Bool3x4)o); }


        /// <summary>Returns a hash code for the Bool3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Bool3x4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool3x4({0}, {1}, {2}, {3},  {4}, {5}, {6}, {7},  {8}, {9}, {10}, {11})", c0.x, c1.x, c2.x, c3.x, c0.y, c1.y, c2.y, c3.y, c0.z, c1.z, c2.z, c3.z);
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Bool3x4 matrix constructed from four Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 Bool3x4(Bool3 c0, Bool3 c1, Bool3 c2, Bool3 c3) { return new Bool3x4(c0, c1, c2, c3); }

        /// <summary>Returns a Bool3x4 matrix constructed from from 12 bool values given in row-major order.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 Bool3x4(bool m00, bool m01, bool m02, bool m03,
                                      bool m10, bool m11, bool m12, bool m13,
                                      bool m20, bool m21, bool m22, bool m23)
        {
            return new Bool3x4(m00, m01, m02, m03,
                               m10, m11, m12, m13,
                               m20, m21, m22, m23);
        }

        /// <summary>Returns a Bool3x4 matrix constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3x4 Bool3x4(bool v) { return new Bool3x4(v); }

        /// <summary>Return the Bool4x3 transpose of a Bool3x4 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4x3 Transpose(Bool3x4 v)
        {
            return Bool4x3(
                v.c0.x, v.c0.y, v.c0.z,
                v.c1.x, v.c1.y, v.c1.z,
                v.c2.x, v.c2.y, v.c2.z,
                v.c3.x, v.c3.y, v.c3.z);
        }

        /// <summary>Returns a uint hash code of a Bool3x4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool3x4 v)
        {
            return SumComponents(Select(UInt3(0x83B58237u, 0x833E3E29u, 0xA9D919BFu), UInt3(0xC3EC1D97u, 0xB8B208C7u, 0x5D3ED947u), v.c0) +
                        Select(UInt3(0x4473BBB1u, 0xCBA11D5Fu, 0x685835CFu), UInt3(0xC3D32AE1u, 0xB966942Fu, 0xFE9856B3u), v.c1) +
                        Select(UInt3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u), UInt3(0x94DDD769u, 0xA1E92D39u, 0x4583C801u), v.c2) +
                        Select(UInt3(0x9536A0F5u, 0xAF816615u, 0x9AF8D62Du), UInt3(0xE3600729u, 0x5F17300Du, 0x670D6809u), v.c3));
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Bool3x4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Bool3x4 v)
        {
            return (Select(UInt3(0x7AF32C49u, 0xAE131389u, 0x5D1B165Bu), UInt3(0x87096CD7u, 0x4C7F6DD1u, 0x4822A3E9u), v.c0) +
                    Select(UInt3(0xAAC3C25Du, 0xD21D0945u, 0x88FCAB2Du), UInt3(0x614DA60Du, 0x5BA2C50Bu, 0x8C455ACBu), v.c1) +
                    Select(UInt3(0xCD266C89u, 0xF1852A33u, 0x77E35E77u), UInt3(0x863E3729u, 0xE191B035u, 0x68586FAFu), v.c2) +
                    Select(UInt3(0xD4DFF6D3u, 0xCB634F4Du, 0x9B13B92Du), UInt3(0x4ABF0813u, 0x86068063u, 0xD75513F9u), v.c3));
        }

    }
}
