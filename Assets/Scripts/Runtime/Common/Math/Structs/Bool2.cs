using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [System.Serializable]
    public partial struct Bool2 : System.IEquatable<Bool2>
    {
        [MarshalAs(UnmanagedType.U1)] public bool x;
        [MarshalAs(UnmanagedType.U1)] public bool y;


        /// <summary>Constructs a Bool2 vector from two bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a Bool2 vector from a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(Bool2 xy)
        {
            x = xy.x;
            y = xy.y;
        }

        /// <summary>Constructs a Bool2 vector from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool2(bool v)
        {
            x = v;
            y = v;
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
            return new Bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.x == rhs, lhs.y == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ==(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs == rhs.x, lhs == rhs.y);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.x != rhs, lhs.y != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !=(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs != rhs.x, lhs != rhs.y);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator !(Bool2 val)
        {
            return new Bool2(!val.x, !val.y);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.x & rhs.x, lhs.y & rhs.y);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.x & rhs, lhs.y & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator &(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs & rhs.x, lhs & rhs.y);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.x | rhs.x, lhs.y | rhs.y);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.x | rhs, lhs.y | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator |(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs | rhs.x, lhs | rhs.y);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(Bool2 lhs, Bool2 rhs)
        {
            return new Bool2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(Bool2 lhs, bool rhs)
        {
            return new Bool2(lhs.x ^ rhs, lhs.y ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 operator ^(bool lhs, Bool2 rhs)
        {
            return new Bool2(lhs ^ rhs.x, lhs ^ rhs.y);
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                x = value.x;
                y = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                y = value.x;
                x = value.y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, y); }
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
                fixed (bool* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the Bool2 is equal to a given Bool2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool2 rhs)
        {
            return x == rhs.x && y == rhs.y;
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
            return (int)Math.hash(this);
        }


        /// <summary>Returns a string representation of the Bool2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool2({0}, {1})", x, y);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;

            public DebuggerProxy(Bool2 v)
            {
                x = v.x;
                y = v.y;
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
        public static uint hash(Bool2 v)
        {
            return SumComponents(Select(UInt2(0x90A285BBu, 0x5D19E1D5u), UInt2(0xFAAF07DDu, 0x625C45BDu), v));
        }

        /// <summary>
        /// Returns a UInt2 vector hash code of a Bool2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 hashwide(Bool2 v)
        {
            return (Select(UInt2(0xC9F27FCBu, 0x6D2523B1u), UInt2(0x6E2BF6A9u, 0xCC74B3B7u), v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool shuffle(Bool2 a, Bool2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Bool2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Bool3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool2 vectors into a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 shuffle(Bool2 a, Bool2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z,
            ShuffleComponent w)
        {
            return Bool4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool select_shuffle_component(Bool2 a, Bool2 b, ShuffleComponent component)
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
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }
    }
}
