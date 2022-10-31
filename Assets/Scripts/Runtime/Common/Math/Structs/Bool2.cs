using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [System.Serializable]
    public struct Bool2 : System.IEquatable<Bool2>
    {
        [MarshalAs(UnmanagedType.U1)]
        public bool X;
        [MarshalAs(UnmanagedType.U1)]
        public bool Y;


        /// <summary>Constructs a Bool2 vector from two bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(bool x, bool y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>Constructs a Bool2 vector from a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(Bool2 xy)
        {
            X = xy.X;
            Y = xy.Y;
        }

        /// <summary>Constructs a Bool2 vector from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(bool v)
        {
            X = v;
            Y = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool2(bool v)
        {
            return new Bool2(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.X == rhs.X, lhs.Y == rhs.Y);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.X == rhs, lhs.Y == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs == rhs.X, lhs == rhs.Y);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.X != rhs.X, lhs.Y != rhs.Y);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.X != rhs, lhs.Y != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs != rhs.X, lhs != rhs.Y);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !(Bool2 val)
        {
            return new Bool2(!val.X, !val.Y);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.X & rhs.X, lhs.Y & rhs.Y);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.X & rhs, lhs.Y & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs & rhs.X, lhs & rhs.Y);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.X | rhs.X, lhs.Y | rhs.Y);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.X | rhs, lhs.Y | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs | rhs.X, lhs | rhs.Y);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.X ^ rhs.X, lhs.Y ^ rhs.Y);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.X ^ rhs, lhs.Y ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs ^ rhs.X, lhs ^ rhs.Y);
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, X, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, X, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, X, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, X, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, Y, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, Y, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, Y, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(X, Y, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, X, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, X, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, X, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, X, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, Y, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, Y, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, Y, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(Y, Y, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(X, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(X, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(X, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(X, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(Y, X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(Y, X, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(Y, Y, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(Y, Y, Y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(X, X); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(X, Y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(Y, X); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Y = value.X;
                X = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(Y, Y); }
        }


        /// <summary>Returns the bool element at a specified index.</summary>
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (Bool2* array = &this)
                {
                    return ((bool*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (bool* array = &X)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the Bool2 is equal to a given Bool2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool2 rhs)
        {
            return X == rhs.X && Y == rhs.Y;
        }

        /// <summary>Returns true if the Bool2 is equal to a given Bool2, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool2)o);
        }


        /// <summary>Returns a hash code for the Bool2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool2({0}, {1})", X, Y);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;

            public DebuggerProxy(Bool2 v)
            {
                x = v.X;
                y = v.Y;
            }
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool2 vector constructed from two bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Bool2(bool x, bool y)
        {
            return new Bool2(x, y);
        }

        /// <summary>Returns a Bool2 vector constructed from a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Bool2(Bool2 xy)
        {
            return new Bool2(xy);
        }

        /// <summary>Returns a Bool2 vector constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Bool2(bool v)
        {
            return new Bool2(v);
        }

        /// <summary>Returns a uint hash code of a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool2 v)
        {
            return SumComponents(Select(UInt2(0x90A285BBu, 0x5D19E1D5u), UInt2(0xFAAF07DDu, 0x625C45BDu), v));
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Bool2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 HashWide(Bool2 v)
        {
            return (Select(UInt2(0xC9F27FCBu, 0x6D2523B1u), UInt2(0x6E2BF6A9u, 0xCC74B3B7u), v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Shuffle(Bool2 a, Bool2 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Bool2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Bool3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z,
            ShuffleComponent w)
        {
            return Bool4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool SelectShuffleComponent(Bool2 a, Bool2 b, ShuffleComponent component)
        {
            switch (component)
            {
                case ShuffleComponent.LeftX:
                    return a.X;
                case ShuffleComponent.LeftY:
                    return a.Y;
                case ShuffleComponent.RightX:
                    return b.X;
                case ShuffleComponent.RightY:
                    return b.Y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }
    }
}
