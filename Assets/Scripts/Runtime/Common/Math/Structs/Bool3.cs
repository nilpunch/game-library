using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace GameLibrary.Mathematics
{
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [System.Serializable]
    public struct Bool3 : System.IEquatable<Bool3>
    {
        [MarshalAs(UnmanagedType.U1)] public bool x;
        [MarshalAs(UnmanagedType.U1)] public bool y;
        [MarshalAs(UnmanagedType.U1)] public bool z;


        /// <summary>Constructs a Bool3 vector from three bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a Bool3 vector from a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(bool x, Bool2 yz)
        {
            this.x = x;
            y = yz.X;
            z = yz.Y;
        }

        /// <summary>Constructs a Bool3 vector from a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(Bool2 xy, bool z)
        {
            x = xy.X;
            y = xy.Y;
            this.z = z;
        }

        /// <summary>Constructs a Bool3 vector from a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(Bool3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        /// <summary>Constructs a Bool3 vector from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Bool3(bool v)
        {
            x = v;
            y = v;
            z = v;
        }


        /// <summary>Implicitly converts a single bool value to a Bool3 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Bool3(bool v)
        {
            return new Bool3(v);
        }


        /// <summary>Returns the result of a componentwise equality operation on two Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Bool3 lhs, Bool3 rhs)
        {
            return new Bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        }

        /// <summary>Returns the result of a componentwise equality operation on a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(Bool3 lhs, bool rhs)
        {
            return new Bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        }

        /// <summary>Returns the result of a componentwise equality operation on a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ==(bool lhs, Bool3 rhs)
        {
            return new Bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        }


        /// <summary>Returns the result of a componentwise not equal operation on two Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Bool3 lhs, Bool3 rhs)
        {
            return new Bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(Bool3 lhs, bool rhs)
        {
            return new Bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        }

        /// <summary>Returns the result of a componentwise not equal operation on a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !=(bool lhs, Bool3 rhs)
        {
            return new Bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        }


        /// <summary>Returns the result of a componentwise not operation on a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator !(Bool3 val)
        {
            return new Bool3(!val.x, !val.y, !val.z);
        }


        /// <summary>Returns the result of a componentwise bitwise and operation on two Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator &(Bool3 lhs, Bool3 rhs)
        {
            return new Bool3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator &(Bool3 lhs, bool rhs)
        {
            return new Bool3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise and operation on a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator &(bool lhs, Bool3 rhs)
        {
            return new Bool3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        }


        /// <summary>Returns the result of a componentwise bitwise or operation on two Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator |(Bool3 lhs, Bool3 rhs)
        {
            return new Bool3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator |(Bool3 lhs, bool rhs)
        {
            return new Bool3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise or operation on a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator |(bool lhs, Bool3 rhs)
        {
            return new Bool3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two Bool3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ^(Bool3 lhs, Bool3 rhs)
        {
            return new Bool3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a Bool3 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ^(Bool3 lhs, bool rhs)
        {
            return new Bool3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a bool value and a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 operator ^(bool lhs, Bool3 rhs)
        {
            return new Bool3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
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
        public Bool4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool4(x, x, x, z); }
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
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
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
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(x, z, z); }
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
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
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
        public Bool3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
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
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, x, z); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
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
                x = value.X;
                y = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                x = value.X;
                z = value.Y;
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
                y = value.X;
                x = value.Y;
            }
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
            set
            {
                y = value.X;
                z = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.X;
                x = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                z = value.X;
                y = value.Y;
            }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Bool2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new Bool2(z, z); }
        }


        /// <summary>Returns the bool element at a specified index.</summary>
        unsafe public bool this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (Bool3* array = &this)
                {
                    return ((bool*)array)[index];
                }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (bool* array = &x)
                {
                    array[index] = value;
                }
            }
        }

        /// <summary>Returns true if the Bool3 is equal to a given Bool3, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Bool3 rhs)
        {
            return x == rhs.x && y == rhs.y && z == rhs.z;
        }

        /// <summary>Returns true if the Bool3 is equal to a given Bool3, false otherwise.</summary>
        public override bool Equals(object o)
        {
            return Equals((Bool3)o);
        }


        /// <summary>Returns a hash code for the Bool3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }


        /// <summary>Returns a string representation of the Bool3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("Bool3({0}, {1}, {2})", x, y, z);
        }

        internal sealed class DebuggerProxy
        {
            public bool x;
            public bool y;
            public bool z;

            public DebuggerProxy(Bool3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a Bool3 vector constructed from three bool values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Bool3(bool x, bool y, bool z)
        {
            return new Bool3(x, y, z);
        }

        /// <summary>Returns a Bool3 vector constructed from a bool value and a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Bool3(bool x, Bool2 yz)
        {
            return new Bool3(x, yz);
        }

        /// <summary>Returns a Bool3 vector constructed from a Bool2 vector and a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Bool3(Bool2 xy, bool z)
        {
            return new Bool3(xy, z);
        }

        /// <summary>Returns a Bool3 vector constructed from a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Bool3(Bool3 xyz)
        {
            return new Bool3(xyz);
        }

        /// <summary>Returns a Bool3 vector constructed from a single bool value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Bool3(bool v)
        {
            return new Bool3(v);
        }

        /// <summary>Returns a uint hash code of a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Bool3 v)
        {
            return SumComponents(Select(UInt3(0xA1E92D39u, 0x4583C801u, 0x9536A0F5u),
                UInt3(0xAF816615u, 0x9AF8D62Du, 0xE3600729u), v));
        }

        /// <summary>
        /// Returns a UInt3 vector hash code of a Bool3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 HashWide(Bool3 v)
        {
            return (Select(UInt3(0x5F17300Du, 0x670D6809u, 0x7AF32C49u), UInt3(0xAE131389u, 0x5D1B165Bu, 0x87096CD7u),
                v));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool3 vectors into a bool value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Shuffle(Bool3 a, Bool3 b, ShuffleComponent x)
        {
            return SelectShuffleComponent(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool3 vectors into a Bool2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool2 Shuffle(Bool3 a, Bool3 b, ShuffleComponent x, ShuffleComponent y)
        {
            return Bool2(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool3 vectors into a Bool3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool3 Shuffle(Bool3 a, Bool3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return Bool3(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two Bool3 vectors into a Bool4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Bool4 Shuffle(Bool3 a, Bool3 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z,
            ShuffleComponent w)
        {
            return Bool4(
                SelectShuffleComponent(a, b, x),
                SelectShuffleComponent(a, b, y),
                SelectShuffleComponent(a, b, z),
                SelectShuffleComponent(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static bool SelectShuffleComponent(Bool3 a, Bool3 b, ShuffleComponent component)
        {
            switch (component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.LeftZ:
                    return a.z;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                case ShuffleComponent.RightZ:
                    return b.z;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }
    }
}
