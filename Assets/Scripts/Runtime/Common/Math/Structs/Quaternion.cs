using System;
using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct Quaternion : IEquatable<Quaternion>, IFormattable
    {
        public Float4 _value;

        /// <summary>A quaternion representing the identity transform.</summary>
        public static Quaternion Identity => new Quaternion(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);

        /// <summary>Constructs a quaternion from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w) { _value.x = x; _value.y = y; _value.z = z; _value.w = w; }

        /// <summary>Constructs a quaternion from Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Quaternion(Float4 value) { this._value = value; }

        /// <summary>Implicitly converts a Float4 vector to a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator Quaternion(Float4 v) { return new Quaternion(v); }

        /// <summary>Constructs a unit quaternion from a Float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        public Quaternion(Float3X3 m)
        {
            Float3 u = m.c0;
            Float3 v = m.c1;
            Float3 w = m.c2;

            uint uSign = (Math.Asuint(u.x) & 0x80000000);
            SoftFloat t = v.y + Math.Asfloat(Math.Asuint(w.z) ^ uSign);
            UInt4 uMask = new UInt4((int)uSign >> 31);
            UInt4 tMask = new UInt4(Math.Asint(t) >> 31);

            SoftFloat tr = SoftFloat.One + Math.Abs(u.x);

            UInt4 signFlips = new UInt4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (uMask & new UInt4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (tMask & new UInt4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            _value = new Float4(tr, u.y, w.x, v.z) + Math.Asfloat(Math.Asuint(new Float4(t, v.x, u.z, w.y)) ^ signFlips);   // +---, +++-, ++-+, +-++

            _value = Math.Asfloat((Math.Asuint(_value) & ~uMask) | (Math.Asuint(_value.zwxy) & uMask));
            _value = Math.Asfloat((Math.Asuint(_value.wzyx) & ~tMask) | (Math.Asuint(_value) & tMask));
            _value = Math.Normalize(_value);
        }

        /// <summary>Constructs a unit quaternion from an orthonormal Float4x4 matrix.</summary>
        public Quaternion(Float4X4 m)
        {
            Float4 u = m.c0;
            Float4 v = m.c1;
            Float4 w = m.c2;

            uint uSign = (Math.Asuint(u.x) & 0x80000000);
            SoftFloat t = v.y + Math.Asfloat(Math.Asuint(w.z) ^ uSign);
            UInt4 uMask = new UInt4((int)uSign >> 31);
            UInt4 tMask = new UInt4(Math.Asint(t) >> 31);

            SoftFloat tr = SoftFloat.One + Math.Abs(u.x);

            UInt4 signFlips = new UInt4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (uMask & new UInt4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (tMask & new UInt4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            _value = new Float4(tr, u.y, w.x, v.z) + Math.Asfloat(Math.Asuint(new Float4(t, v.x, u.z, w.y)) ^ signFlips);   // +---, +++-, ++-+, +-++

            _value = Math.Asfloat((Math.Asuint(_value) & ~uMask) | (Math.Asuint(_value.zwxy) & uMask));
            _value = Math.Asfloat((Math.Asuint(_value.wzyx) & ~tMask) | (Math.Asuint(_value) & tMask));

            _value = Math.Normalize(_value);
        }

        /// <summary>
        /// Returns a quaternion representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion AxisAngle(Float3 axis, SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.Sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new Quaternion(new Float4(axis * sina, cosa));
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXYZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(-SoftFloat.One, SoftFloat.One, -SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXZY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(SoftFloat.One, SoftFloat.One, -SoftFloat.One, -SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYXZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(-SoftFloat.One, SoftFloat.One, SoftFloat.One, -SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYZX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(-SoftFloat.One, -SoftFloat.One, SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZXY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZYX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            Float3 s, c;
            Math.Sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new Quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.x * s.z
                new Float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new Float4(c.xyz, s.x) * new Float4(SoftFloat.One, -SoftFloat.One, SoftFloat.One, -SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXYZ(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerXYZ(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerXZY(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerXZY(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYXZ(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerYXZ(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerYZX(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerYZX(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZXY(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerZXY(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion EulerZYX(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerZYX(new Float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(Float3 xyz, Math.RotationOrder order = Math.RotationOrder.ZXY)
        {
            switch (order)
            {
                case Math.RotationOrder.XYZ:
                    return EulerXYZ(xyz);
                case Math.RotationOrder.XZY:
                    return EulerXZY(xyz);
                case Math.RotationOrder.YXZ:
                    return EulerYXZ(xyz);
                case Math.RotationOrder.YZX:
                    return EulerYZX(xyz);
                case Math.RotationOrder.ZXY:
                    return EulerZXY(xyz);
                case Math.RotationOrder.ZYX:
                    return EulerZYX(xyz);
                default:
                    return Identity;
            }
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Euler(SoftFloat x, SoftFloat y, SoftFloat z, Math.RotationOrder order = Math.RotationOrder.Default)
        {
            return Euler(new Float3(x, y, z), order);
        }

        /// <summary>Returns a quaternion that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateX(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.Sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new Quaternion(sina, SoftFloat.Zero, SoftFloat.Zero, cosa);
        }

        /// <summary>Returns a quaternion that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateY(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.Sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new Quaternion(SoftFloat.Zero, sina, SoftFloat.Zero, cosa);
        }

        /// <summary>Returns a quaternion that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion RotateZ(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.Sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new Quaternion(SoftFloat.Zero, SoftFloat.Zero, sina, cosa);
        }

        /// <summary>
        /// Returns a quaternion view rotation given a unit length forward vector and a unit length up vector.
        /// The two input vectors are assumed to be unit length and not collinear.
        /// If these assumptions are not met use Float3x3.LookRotationSafe instead.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion LookRotation(Float3 forward, Float3 up)
        {
            Float3 t = Math.Normalize(Math.Cross(up, forward));
            return new Quaternion(new Float3X3(t, Math.Cross(forward, t), forward));
        }

        /// <summary>
        /// Returns a quaternion view rotation given a forward vector and an up vector.
        /// The two input vectors are not assumed to be unit length.
        /// If the magnitude of either of the vectors is so extreme that the calculation cannot be carried out reliably or the vectors are collinear,
        /// the identity will be returned instead.
        /// </summary>
        public static Quaternion LookRotationSafe(Float3 forward, Float3 up)
        {
            SoftFloat forwardLengthSq = Math.Dot(forward, forward);
            SoftFloat upLengthSq = Math.Dot(up, up);

            forward *= Math.Rsqrt(forwardLengthSq);
            up *= Math.Rsqrt(upLengthSq);

            Float3 t = Math.Cross(up, forward);
            SoftFloat tLengthSq = Math.Dot(t, t);
            t *= Math.Rsqrt(tLengthSq);

            SoftFloat mn = Math.MIN(Math.MIN(forwardLengthSq, upLengthSq), tLengthSq);
            SoftFloat mx = Math.MAX(Math.MAX(forwardLengthSq, upLengthSq), tLengthSq);

            const uint bigValue = 0x799a130c;
            const uint smallValue = 0x0554ad2e;

            bool accept = mn > SoftFloat.FromRaw(smallValue) && mx < SoftFloat.FromRaw(bigValue) && Math.Isfinite(forwardLengthSq) && Math.Isfinite(upLengthSq) && Math.Isfinite(tLengthSq);
            return new Quaternion(Math.Select(new Float4(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One), new Quaternion(new Float3X3(t, Math.Cross(forward, t),forward))._value, accept));
        }

        /// <summary>Returns true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(Quaternion x) { return _value.x == x._value.x && _value.y == x._value.y && _value.z == x._value.z && _value.w == x._value.w; }

        /// <summary>Returns whether true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object x) { return Equals((Quaternion)x); }

        /// <summary>Returns a hash code for the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.Hash(this); }

        /// <summary>Returns a string representation of the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", _value.x, _value.y, _value.z, _value.w);
        }

        /// <summary>Returns a string representation of the quaternion using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", _value.x.ToString(format, formatProvider), _value.y.ToString(format, formatProvider), _value.z.ToString(format, formatProvider), _value.w.ToString(format, formatProvider));
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a quaternion constructed from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w) { return new Quaternion(x, y, z, w); }

        /// <summary>Returns a quaternion constructed from a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(Float4 value) { return new Quaternion(value); }

        /// <summary>Returns a unit quaternion constructed from a Float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(Float3X3 m) { return new Quaternion(m); }

        /// <summary>Returns a unit quaternion constructed from a Float4x4 matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Quaternion(Float4X4 m) { return new Quaternion(m); }

       /// <summary>Returns the conjugate of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Conjugate(Quaternion q)
        {
            return new Quaternion(q._value * new Float4(-SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One));
        }

       /// <summary>Returns the inverse of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Inverse(Quaternion q)
        {
            Float4 x = q._value;
            return new Quaternion(Rcp(Dot(x, x)) * x * new Float4(-SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One));
        }

        /// <summary>Returns the dot product of two quaternions.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(Quaternion a, Quaternion b)
        {
            return Dot(a._value, b._value);
        }

        /// <summary>Returns the length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(Quaternion q)
        {
            return Sqrt(Dot(q._value, q._value));
        }

        /// <summary>Returns the squared length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(Quaternion q)
        {
            return Dot(q._value, q._value);
        }

        /// <summary>Returns a normalized version of a quaternion q by scaling it by 1 / length(q).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Normalize(Quaternion q)
        {
            Float4 x = q._value;
            return new Quaternion(Rsqrt(Dot(x, x)) * x);
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the identity when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Normalizesafe(Quaternion q)
        {
            Float4 x = q._value;
            SoftFloat len = Dot(x, x);
            return new Quaternion(Select(Mathematics.Quaternion.Identity._value, x * Rsqrt(len), len > FLTMINNormal));
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the given default value when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Normalizesafe(Quaternion q, Quaternion defaultvalue)
        {
            Float4 x = q._value;
            SoftFloat len = Dot(x, x);
            return new Quaternion(Select(defaultvalue._value, x * Rsqrt(len), len > FLTMINNormal));
        }

        /// <summary>Returns the natural exponent of a quaternion. Assumes w is zero.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Unitexp(Quaternion q)
        {
            SoftFloat vRcpLen = Rsqrt(Dot(q._value.xyz, q._value.xyz));
            SoftFloat vLen = Rcp(vRcpLen);
            SoftFloat sinVLen, cosVLen;
            Sincos(vLen, out sinVLen, out cosVLen);
            return new Quaternion(new Float4(q._value.xyz * vRcpLen * sinVLen, cosVLen));
        }

        /// <summary>Returns the natural exponent of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Exp(Quaternion q)
        {
            SoftFloat vRcpLen = Rsqrt(Dot(q._value.xyz, q._value.xyz));
            SoftFloat vLen = Rcp(vRcpLen);
            SoftFloat sinVLen, cosVLen;
            Sincos(vLen, out sinVLen, out cosVLen);
            return new Quaternion(new Float4(q._value.xyz * vRcpLen * sinVLen, cosVLen) * Exp(q._value.w));
        }

        /// <summary>Returns the natural logarithm of a unit length quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Unitlog(Quaternion q)
        {
            SoftFloat w = Clamp(q._value.w, -SoftFloat.One, SoftFloat.One);
            SoftFloat s = Acos(w) * Rsqrt(SoftFloat.One - w*w);
            return new Quaternion(new Float4(q._value.xyz * s, SoftFloat.Zero));
        }

        /// <summary>Returns the natural logarithm of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion LOG(Quaternion q)
        {
            SoftFloat vLenSq = Dot(q._value.xyz, q._value.xyz);
            SoftFloat qLenSq = vLenSq + q._value.w*q._value.w;

            SoftFloat s = Acos(Clamp(q._value.w * Rsqrt(qLenSq), -SoftFloat.One, SoftFloat.One)) * Rsqrt(vLenSq);
            return new Quaternion(new Float4(q._value.xyz * s, (SoftFloat)0.5f * LOG(qLenSq)));
        }

        /// <summary>Returns the result of transforming the quaternion b by the quaternion a.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Mul(Quaternion a, Quaternion b)
        {
            return new Quaternion(a._value.wwww * b._value + (a._value.xyzx * b._value.wwwx + a._value.yzxy * b._value.zxyy) * new Float4(SoftFloat.One, SoftFloat.One, SoftFloat.One, -SoftFloat.One) - a._value.zxyz * b._value.yzxz);
        }

        /// <summary>Returns the result of transforming a vector by a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mul(Quaternion q, Float3 v)
        {
            Float3 t = (SoftFloat)2.0f * Cross(q._value.xyz, v);
            return v + q._value.w * t + Cross(q._value.xyz, t);
        }

        /// <summary>Returns the result of rotating a vector by a unit quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Rotate(Quaternion q, Float3 v)
        {
            Float3 t = (SoftFloat)2.0f * Cross(q._value.xyz, v);
            return v + q._value.w * t + Cross(q._value.xyz, t);
        }

        /// <summary>Returns the result of a normalized linear interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Nlerp(Quaternion q1, Quaternion q2, SoftFloat t)
        {
            SoftFloat dt = Dot(q1, q2);
            if(dt < SoftFloat.Zero)
            {
                q2._value = -q2._value;
            }

            return Normalize(Quaternion(Lerp(q1._value, q2._value, t)));
        }

        /// <summary>Returns the result of a spherical interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Quaternion Slerp(Quaternion q1, Quaternion q2, SoftFloat t)
        {
            SoftFloat dt = Dot(q1, q2);
            if (dt < SoftFloat.Zero)
            {
                dt = -dt;
                q2._value = -q2._value;
            }

            const uint almostOne = 0x3f7fdf3b;
            if (dt < SoftFloat.FromRaw(almostOne))
            {
                SoftFloat angle = Acos(dt);
                SoftFloat s = Rsqrt(SoftFloat.One - dt * dt);    // 1.0f / sin(angle)
                SoftFloat w1 = Sin(angle * (SoftFloat.One - t)) * s;
                SoftFloat w2 = Sin(angle * t) * s;
                return new Quaternion(q1._value * w1 + q2._value * w2);
            }
            else
            {
                // if the angle is small, use linear interpolation
                return Nlerp(q1, q2, t);
            }
        }

        /// <summary>Returns a uint hash code of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(Quaternion q)
        {
            return hash(q._value);
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a quaternion.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Hashwide(Quaternion q)
        {
            return hashwide(q._value);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Forward(Quaternion q) { return Mul(q, Float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One)); }  // for compatibility
    }
}
