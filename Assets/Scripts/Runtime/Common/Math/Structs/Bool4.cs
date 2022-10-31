using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [System.Serializable]
    public struct Bool4 : System.IEquatable<Bool4>
    {
        [MarshalAs(UnmanagedType.U1)]
        public bool x;
        [MarshalAs(UnmanagedType.U1)]
        public bool y;
        [MarshalAs(UnmanagedType.U1)]
        public bool z;
        [MarshalAs(UnmanagedType.U1)]
        public bool w;


        /// <summary>Constructs a Bool4 vector from four bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Bool4 vector from two bool values and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(bool x, bool y, Bool2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.X;
            w = zw.Y;
        }

        /// <summary>Constructs a Bool4 vector from a bool value, a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(bool x, Bool2 yz, bool w)
        {
            this.x = x;
            y = yz.X;
            z = yz.Y;
            this.w = w;
        }

        /// <summary>Constructs a Bool4 vector from a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(bool x, Bool3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }

        /// <summary>Constructs a Bool4 vector from a Bool2 vector and two bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(Bool2 xy, bool z, bool w)
        {
            x = xy.X;
            y = xy.Y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a Bool4 vector from two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(Bool2 xy, Bool2 zw)
        {
            x = xy.X;
            y = xy.Y;
            z = zw.X;
            w = zw.Y;
        }

        /// <summary>Constructs a Bool4 vector from a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(Bool3 xyz, bool w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a Bool4 vector from a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(Bool4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        /// <summary>Constructs a Bool4 vector from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool4(bool v)
        {
            x = v;
            y = v;
            z = v;
            w = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool4 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool4(bool v) { return new Bool4(v); }


        /// <summary>Returns the result of a componentwise equality operation on two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Bool4 lhs, Bool4 rhs) { return new Bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a Bool4 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (Bool4 lhs, bool rhs) { return new Bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator == (bool lhs, Bool4 rhs) { return new Bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Bool4 lhs, Bool4 rhs) { return new Bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool4 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (Bool4 lhs, bool rhs) { return new Bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator != (bool lhs, Bool4 rhs) { return new Bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }


        /// <summary>Returns the result of a componentwise not operation on a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator ! (Bool4 val) { return new Bool4 (!val.x, !val.y, !val.z, !val.w); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator & (Bool4 lhs, Bool4 rhs) { return new Bool4 (lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool4 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator & (Bool4 lhs, bool rhs) { return new Bool4 (lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator & (bool lhs, Bool4 rhs) { return new Bool4 (lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator | (Bool4 lhs, Bool4 rhs) { return new Bool4 (lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool4 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator | (Bool4 lhs, bool rhs) { return new Bool4 (lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator | (bool lhs, Bool4 rhs) { return new Bool4 (lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator ^ (Bool4 lhs, Bool4 rhs) { return new Bool4 (lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool4 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator ^ (Bool4 lhs, bool rhs) { return new Bool4 (lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 operator ^ (bool lhs, Bool4 rhs) { return new Bool4 (lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w); }




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
        public Bool4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, x, w); }
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
        public Bool4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, w, w); }
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
        public Bool4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, x, w); }
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
        public Bool4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, w, w, w); }
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
        public Bool4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, x, w); }
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
        public Bool4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, x, w, w); }
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
        public Bool4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, x, w); }
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
        public Bool4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(y, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(z, w, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, x, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(w, w, w, w); }
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
        public Bool3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, x, w); }
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
        public Bool3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, w, w); }
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
        public Bool3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
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
        public Bool3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, y, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, z, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, z, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, w, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, x, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, y, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, z, w); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, w, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, w, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, w, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(w, w, w); }
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
            set { x = value.X; y = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.X; z = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.X; w = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.X; x = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.X; z = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.X; w = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.X; x = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.X; y = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.X; w = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.X; x = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.X; y = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.X; z = value.Y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(w, w); }
        }



        /// <summary>Returns the bool element at a specified index.</summary>
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (Bool4* array = &this) { return ((bool*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (bool* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the Bool4 is equal to a given Bool4, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the Bool4 is equal to a given Bool4, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((Bool4)o); }


        /// <summary>Returns a hash code for the Bool4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }


        /// <summary>Returns a string representation of the Bool4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;
            public bool z;
            public bool w;
            public DebuggerProxy(Bool4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

    }

    public static partial class Math
    {
        /// <summary>Returns a Bool4 vector constructed from four bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(bool x, bool y, bool z, bool w) { return new Bool4(x, y, z, w); }

        /// <summary>Returns a Bool4 vector constructed from two bool values and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(bool x, bool y, Bool2 zw) { return new Bool4(x, y, zw); }

        /// <summary>Returns a Bool4 vector constructed from a bool value, a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(bool x, Bool2 yz, bool w) { return new Bool4(x, yz, w); }

        /// <summary>Returns a Bool4 vector constructed from a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(bool x, Bool3 yzw) { return new Bool4(x, yzw); }

        /// <summary>Returns a Bool4 vector constructed from a Bool2 vector and two bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(Bool2 xy, bool z, bool w) { return new Bool4(xy, z, w); }

        /// <summary>Returns a Bool4 vector constructed from two Bool2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(Bool2 xy, Bool2 zw) { return new Bool4(xy, zw); }

        /// <summary>Returns a Bool4 vector constructed from a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(Bool3 xyz, bool w) { return new Bool4(xyz, w); }

        /// <summary>Returns a Bool4 vector constructed from a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(Bool4 xyzw) { return new Bool4(xyzw); }

        /// <summary>Returns a Bool4 vector constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Bool4(bool v) { return new Bool4(v); }

        /// <summary>Returns a uint hash code of a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool4 v)
        {
            return SumComponents(Select(UInt4(0x5FFF6B19u, 0x5E6CBF3Bu, 0xB546F2A5u, 0xBBCF63E7u), UInt4(0xC53F4755u, 0x6985C229u, 0xE133B0B3u, 0xC3E0A3B9u), v));
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a Bool4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(Bool4 v)
        {
            return (Select(UInt4(0xFE31134Fu, 0x712A34D7u, 0x9D77A59Bu, 0x4942CA39u), UInt4(0xB40EC62Du, 0x565ED63Fu, 0x93C30C2Bu, 0xDCAF0351u), v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool4 vectors into a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Shuffle(Bool4 a, Bool4 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool4 vectors into a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Shuffle(Bool4 a, Bool4 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Bool2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool4 vectors into a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Shuffle(Bool4 a, Bool4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Bool3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool4 vectors into a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Shuffle(Bool4 a, Bool4 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return Bool4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool SelectShuffleComponent(Bool4 a, Bool4 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.LeftW:
                    return a.w;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                case ShuffleComponent.RightW:
                    return b.w;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
