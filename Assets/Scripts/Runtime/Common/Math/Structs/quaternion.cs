using System;
using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    [Serializable]
    public partial struct quaternion : IEquatable<quaternion>, IFormattable
    {
        public float4 value;

        /// <summary>A quaternion representing the identity transform.</summary>
        public static quaternion identity => new quaternion(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);

        /// <summary>Constructs a quaternion from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public quaternion(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w) { value.x = x; value.y = y; value.z = z; value.w = w; }

        /// <summary>Constructs a quaternion from float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public quaternion(float4 value) { this.value = value; }

        /// <summary>Implicitly converts a float4 vector to a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator quaternion(float4 v) { return new quaternion(v); }

        /// <summary>Constructs a unit quaternion from a float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        public quaternion(float3x3 m)
        {
            float3 u = m.c0;
            float3 v = m.c1;
            float3 w = m.c2;

            uint u_sign = (Math.asuint(u.x) & 0x80000000);
            SoftFloat t = v.y + Math.asfloat(Math.asuint(w.z) ^ u_sign);
            uint4 u_mask = new uint4((int)u_sign >> 31);
            uint4 t_mask = new uint4(Math.asint(t) >> 31);

            SoftFloat tr = SoftFloat.One + Math.abs(u.x);

            uint4 sign_flips = new uint4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (u_mask & new uint4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (t_mask & new uint4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            value = new float4(tr, u.y, w.x, v.z) + Math.asfloat(Math.asuint(new float4(t, v.x, u.z, w.y)) ^ sign_flips);   // +---, +++-, ++-+, +-++

            value = Math.asfloat((Math.asuint(value) & ~u_mask) | (Math.asuint(value.zwxy) & u_mask));
            value = Math.asfloat((Math.asuint(value.wzyx) & ~t_mask) | (Math.asuint(value) & t_mask));
            value = Math.normalize(value);
        }

        /// <summary>Constructs a unit quaternion from an orthonormal float4x4 matrix.</summary>
        public quaternion(float4x4 m)
        {
            float4 u = m.c0;
            float4 v = m.c1;
            float4 w = m.c2;

            uint u_sign = (Math.asuint(u.x) & 0x80000000);
            SoftFloat t = v.y + Math.asfloat(Math.asuint(w.z) ^ u_sign);
            uint4 u_mask = new uint4((int)u_sign >> 31);
            uint4 t_mask = new uint4(Math.asint(t) >> 31);

            SoftFloat tr = SoftFloat.One + Math.abs(u.x);

            uint4 sign_flips = new uint4(0x00000000, 0x80000000, 0x80000000, 0x80000000) ^ (u_mask & new uint4(0x00000000, 0x80000000, 0x00000000, 0x80000000)) ^ (t_mask & new uint4(0x80000000, 0x80000000, 0x80000000, 0x00000000));

            value = new float4(tr, u.y, w.x, v.z) + Math.asfloat(Math.asuint(new float4(t, v.x, u.z, w.y)) ^ sign_flips);   // +---, +++-, ++-+, +-++

            value = Math.asfloat((Math.asuint(value) & ~u_mask) | (Math.asuint(value.zwxy) & u_mask));
            value = Math.asfloat((Math.asuint(value.wzyx) & ~t_mask) | (Math.asuint(value) & t_mask));

            value = Math.normalize(value);
        }

        /// <summary>
        /// Returns a quaternion representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion AxisAngle(float3 axis, SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new quaternion(new float4(axis * sina, cosa));
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerXYZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(-SoftFloat.One, SoftFloat.One, -SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerXZY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(SoftFloat.One, SoftFloat.One, -SoftFloat.One, -SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYXZ(float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z + s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.z * s.x
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(-SoftFloat.One, SoftFloat.One, SoftFloat.One, -SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYZX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z - s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(-SoftFloat.One, -SoftFloat.One, SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZXY(float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y - s.x * s.y * c.z,
                // c.x * c.y * c.z + s.y * s.z * s.x
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One)
                );
        }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZYX(float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            float3 s, c;
            Math.sincos((SoftFloat)0.5f * xyz, out s, out c);
            return new quaternion(
                // s.x * c.y * c.z + s.y * s.z * c.x,
                // s.y * c.x * c.z - s.x * s.z * c.y,
                // s.z * c.x * c.y + s.x * s.y * c.z,
                // c.x * c.y * c.z - s.y * s.x * s.z
                new float4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * new float4(c.xyz, s.x) * new float4(SoftFloat.One, -SoftFloat.One, SoftFloat.One, -SoftFloat.One)
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
        public static quaternion EulerXYZ(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerXYZ(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerXZY(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerXZY(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYXZ(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerYXZ(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerYZX(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerYZX(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZXY(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerZXY(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion EulerZYX(SoftFloat x, SoftFloat y, SoftFloat z) { return EulerZYX(new float3(x, y, z)); }

        /// <summary>
        /// Returns a quaternion constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion Euler(float3 xyz, Math.RotationOrder order = Math.RotationOrder.ZXY)
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
                    return identity;
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
        public static quaternion Euler(SoftFloat x, SoftFloat y, SoftFloat z, Math.RotationOrder order = Math.RotationOrder.Default)
        {
            return Euler(new float3(x, y, z), order);
        }

        /// <summary>Returns a quaternion that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateX(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new quaternion(sina, SoftFloat.Zero, SoftFloat.Zero, cosa);
        }

        /// <summary>Returns a quaternion that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateY(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new quaternion(SoftFloat.Zero, sina, SoftFloat.Zero, cosa);
        }

        /// <summary>Returns a quaternion that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion RotateZ(SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.sincos((SoftFloat)0.5f * angle, out sina, out cosa);
            return new quaternion(SoftFloat.Zero, SoftFloat.Zero, sina, cosa);
        }

        /// <summary>
        /// Returns a quaternion view rotation given a unit length forward vector and a unit length up vector.
        /// The two input vectors are assumed to be unit length and not collinear.
        /// If these assumptions are not met use float3x3.LookRotationSafe instead.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion LookRotation(float3 forward, float3 up)
        {
            float3 t = Math.normalize(Math.cross(up, forward));
            return new quaternion(new float3x3(t, Math.cross(forward, t), forward));
        }

        /// <summary>
        /// Returns a quaternion view rotation given a forward vector and an up vector.
        /// The two input vectors are not assumed to be unit length.
        /// If the magnitude of either of the vectors is so extreme that the calculation cannot be carried out reliably or the vectors are collinear,
        /// the identity will be returned instead.
        /// </summary>
        public static quaternion LookRotationSafe(float3 forward, float3 up)
        {
            SoftFloat forwardLengthSq = Math.dot(forward, forward);
            SoftFloat upLengthSq = Math.dot(up, up);

            forward *= Math.rsqrt(forwardLengthSq);
            up *= Math.rsqrt(upLengthSq);

            float3 t = Math.cross(up, forward);
            SoftFloat tLengthSq = Math.dot(t, t);
            t *= Math.rsqrt(tLengthSq);

            SoftFloat mn = Math.min(Math.min(forwardLengthSq, upLengthSq), tLengthSq);
            SoftFloat mx = Math.max(Math.max(forwardLengthSq, upLengthSq), tLengthSq);

            const uint bigValue = 0x799a130c;
            const uint smallValue = 0x0554ad2e;

            bool accept = mn > SoftFloat.FromRaw(smallValue) && mx < SoftFloat.FromRaw(bigValue) && Math.isfinite(forwardLengthSq) && Math.isfinite(upLengthSq) && Math.isfinite(tLengthSq);
            return new quaternion(Math.select(new float4(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One), new quaternion(new float3x3(t, Math.cross(forward, t),forward)).value, accept));
        }

        /// <summary>Returns true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(quaternion x) { return value.x == x.value.x && value.y == x.value.y && value.z == x.value.z && value.w == x.value.w; }

        /// <summary>Returns whether true if the quaternion is equal to a given quaternion, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object x) { return Equals((quaternion)x); }

        /// <summary>Returns a hash code for the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)Math.hash(this); }

        /// <summary>Returns a string representation of the quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", value.x, value.y, value.z, value.w);
        }

        /// <summary>Returns a string representation of the quaternion using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("quaternion({0}f, {1}f, {2}f, {3}f)", value.x.ToString(format, formatProvider), value.y.ToString(format, formatProvider), value.z.ToString(format, formatProvider), value.w.ToString(format, formatProvider));
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a quaternion constructed from four float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(SoftFloat x, SoftFloat y, SoftFloat z, SoftFloat w) { return new quaternion(x, y, z, w); }

        /// <summary>Returns a quaternion constructed from a float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float4 value) { return new quaternion(value); }

        /// <summary>Returns a unit quaternion constructed from a float3x3 rotation matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float3x3 m) { return new quaternion(m); }

        /// <summary>Returns a unit quaternion constructed from a float4x4 matrix. The matrix must be orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion quaternion(float4x4 m) { return new quaternion(m); }

       /// <summary>Returns the conjugate of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion conjugate(quaternion q)
        {
            return new quaternion(q.value * new float4(-SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One));
        }

       /// <summary>Returns the inverse of a quaternion value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion inverse(quaternion q)
        {
            float4 x = q.value;
            return new quaternion(rcp(dot(x, x)) * x * new float4(-SoftFloat.One, -SoftFloat.One, -SoftFloat.One, SoftFloat.One));
        }

        /// <summary>Returns the dot product of two quaternions.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat dot(quaternion a, quaternion b)
        {
            return dot(a.value, b.value);
        }

        /// <summary>Returns the length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat length(quaternion q)
        {
            return sqrt(dot(q.value, q.value));
        }

        /// <summary>Returns the squared length of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat lengthsq(quaternion q)
        {
            return dot(q.value, q.value);
        }

        /// <summary>Returns a normalized version of a quaternion q by scaling it by 1 / length(q).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalize(quaternion q)
        {
            float4 x = q.value;
            return new quaternion(rsqrt(dot(x, x)) * x);
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the identity when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalizesafe(quaternion q)
        {
            float4 x = q.value;
            SoftFloat len = dot(x, x);
            return new quaternion(select(Mathematics.quaternion.identity.value, x * rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>
        /// Returns a safe normalized version of the q by scaling it by 1 / length(q).
        /// Returns the given default value when 1 / length(q) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion normalizesafe(quaternion q, quaternion defaultvalue)
        {
            float4 x = q.value;
            SoftFloat len = dot(x, x);
            return new quaternion(select(defaultvalue.value, x * rsqrt(len), len > FLT_MIN_NORMAL));
        }

        /// <summary>Returns the natural exponent of a quaternion. Assumes w is zero.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion unitexp(quaternion q)
        {
            SoftFloat v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            SoftFloat v_len = rcp(v_rcp_len);
            SoftFloat sin_v_len, cos_v_len;
            sincos(v_len, out sin_v_len, out cos_v_len);
            return new quaternion(new float4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len));
        }

        /// <summary>Returns the natural exponent of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion exp(quaternion q)
        {
            SoftFloat v_rcp_len = rsqrt(dot(q.value.xyz, q.value.xyz));
            SoftFloat v_len = rcp(v_rcp_len);
            SoftFloat sin_v_len, cos_v_len;
            sincos(v_len, out sin_v_len, out cos_v_len);
            return new quaternion(new float4(q.value.xyz * v_rcp_len * sin_v_len, cos_v_len) * exp(q.value.w));
        }

        /// <summary>Returns the natural logarithm of a unit length quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion unitlog(quaternion q)
        {
            SoftFloat w = clamp(q.value.w, -SoftFloat.One, SoftFloat.One);
            SoftFloat s = acos(w) * rsqrt(SoftFloat.One - w*w);
            return new quaternion(new float4(q.value.xyz * s, SoftFloat.Zero));
        }

        /// <summary>Returns the natural logarithm of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion log(quaternion q)
        {
            SoftFloat v_len_sq = dot(q.value.xyz, q.value.xyz);
            SoftFloat q_len_sq = v_len_sq + q.value.w*q.value.w;

            SoftFloat s = acos(clamp(q.value.w * rsqrt(q_len_sq), -SoftFloat.One, SoftFloat.One)) * rsqrt(v_len_sq);
            return new quaternion(new float4(q.value.xyz * s, (SoftFloat)0.5f * log(q_len_sq)));
        }

        /// <summary>Returns the result of transforming the quaternion b by the quaternion a.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion mul(quaternion a, quaternion b)
        {
            return new quaternion(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * new float4(SoftFloat.One, SoftFloat.One, SoftFloat.One, -SoftFloat.One) - a.value.zxyz * b.value.yzxz);
        }

        /// <summary>Returns the result of transforming a vector by a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 mul(quaternion q, float3 v)
        {
            float3 t = (SoftFloat)2.0f * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of rotating a vector by a unit quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 rotate(quaternion q, float3 v)
        {
            float3 t = (SoftFloat)2.0f * cross(q.value.xyz, v);
            return v + q.value.w * t + cross(q.value.xyz, t);
        }

        /// <summary>Returns the result of a normalized linear interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion nlerp(quaternion q1, quaternion q2, SoftFloat t)
        {
            SoftFloat dt = dot(q1, q2);
            if(dt < SoftFloat.Zero)
            {
                q2.value = -q2.value;
            }

            return normalize(quaternion(lerp(q1.value, q2.value, t)));
        }

        /// <summary>Returns the result of a spherical interpolation between two quaternions q1 and a2 using an interpolation parameter t.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static quaternion slerp(quaternion q1, quaternion q2, SoftFloat t)
        {
            SoftFloat dt = dot(q1, q2);
            if (dt < SoftFloat.Zero)
            {
                dt = -dt;
                q2.value = -q2.value;
            }

            const uint almostOne = 0x3f7fdf3b;
            if (dt < SoftFloat.FromRaw(almostOne))
            {
                SoftFloat angle = acos(dt);
                SoftFloat s = rsqrt(SoftFloat.One - dt * dt);    // 1.0f / sin(angle)
                SoftFloat w1 = sin(angle * (SoftFloat.One - t)) * s;
                SoftFloat w2 = sin(angle * t) * s;
                return new quaternion(q1.value * w1 + q2.value * w2);
            }
            else
            {
                // if the angle is small, use linear interpolation
                return nlerp(q1, q2, t);
            }
        }

        /// <summary>Returns a uint hash code of a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(quaternion q)
        {
            return hash(q.value);
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a quaternion.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(quaternion q)
        {
            return hashwide(q.value);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 forward(quaternion q) { return mul(q, float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One)); }  // for compatibility
    }
}
