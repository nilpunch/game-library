using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    public partial struct Float2X2
    {
        /// <summary>Returns a Float2x2 matrix representing a counter-clockwise rotation of angle degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Rotate(SoftFloat angle)
        {
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float2X2(c, -s,
                s, c);
        }

        /// <summary>Returns a Float2x2 matrix representing a uniform scaling of both axes by s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Scale(SoftFloat s)
        {
            return new Float2X2(s, SoftFloat.Zero,
                SoftFloat.Zero, s);
        }

        /// <summary>Returns a Float2x2 matrix representing a non-uniform axis scaling by x and y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Scale(SoftFloat x, SoftFloat y)
        {
            return new Float2X2(x, SoftFloat.Zero,
                SoftFloat.Zero, y);
        }

        /// <summary>Returns a Float2x2 matrix representing a non-uniform axis scaling by the components of the Float2 vector v.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2X2 Scale(Float2 v)
        {
            return Scale(v.x, v.y);
        }
    }

    public partial struct Float3X3
    {
        /// <summary>
        /// Constructs a Float3x3 from the upper left 3x3 of a Float4x4.
        /// </summary>
        /// <param name="f4X4"><see cref="Float4X4"/> to extract a Float3x3 from.</param>
        public Float3X3(Float4X4 f4X4)
        {
            c0 = f4X4.c0.xyz;
            c1 = f4X4.c1.xyz;
            c2 = f4X4.c2.xyz;
        }

        /// <summary>Constructs a Float3x3 matrix from a unit quaternion.</summary>
        public Float3X3(Quaternion q)
        {
            Float4 v = q.value;
            Float4 v2 = v + v;

            UInt3 npn = new UInt3(0x80000000, 0x00000000, 0x80000000);
            UInt3 nnp = new UInt3(0x80000000, 0x80000000, 0x00000000);
            UInt3 pnn = new UInt3(0x00000000, 0x80000000, 0x80000000);
            c0 = v2.y * Math.AsFloat(Math.AsUInt(v.yxw) ^ npn) - v2.z * Math.AsFloat(Math.AsUInt(v.zwx) ^ pnn) +
                 new Float3(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero);
            c1 = v2.z * Math.AsFloat(Math.AsUInt(v.wzy) ^ nnp) - v2.x * Math.AsFloat(Math.AsUInt(v.yxw) ^ npn) +
                 new Float3(SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero);
            c2 = v2.x * Math.AsFloat(Math.AsUInt(v.zwx) ^ pnn) - v2.y * Math.AsFloat(Math.AsUInt(v.wzy) ^ nnp) +
                 new Float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>
        /// Returns a Float3x3 matrix representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 AxisAngle(Float3 axis, SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.SinCos(angle, out sina, out cosa);

            Float3 u = axis;
            Float3 uYZX = u.yzx;
            Float3 uZXY = u.zxy;
            Float3 uInvCosa = u - u * cosa; // u * (1.0f - cosa);
            Float4 t = new Float4(u * sina, cosa);

            UInt3 ppn = new UInt3(0x00000000, 0x00000000, 0x80000000);
            UInt3 npp = new UInt3(0x80000000, 0x00000000, 0x00000000);
            UInt3 pnp = new UInt3(0x00000000, 0x80000000, 0x00000000);

            return new Float3X3(
                u.x * uInvCosa + Math.AsFloat(Math.AsUInt(t.wzy) ^ ppn),
                u.y * uInvCosa + Math.AsFloat(Math.AsUInt(t.zwx) ^ npp),
                u.z * uInvCosa + Math.AsFloat(Math.AsUInt(t.yxw) ^ pnp)
            );
            /*
            return new Float3x3(
                cosa + u.x * u.x * (1.0f - cosa),       u.y * u.x * (1.0f - cosa) - u.z * sina, u.z * u.x * (1.0f - cosa) + u.y * sina,
                u.x * u.y * (1.0f - cosa) + u.z * sina, cosa + u.y * u.y * (1.0f - cosa),       u.y * u.z * (1.0f - cosa) - u.x * sina,
                u.x * u.z * (1.0f - cosa) - u.y * sina, u.y * u.z * (1.0f - cosa) + u.x * sina, cosa + u.z * u.z * (1.0f - cosa)
                );
                */
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerXYZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z, c.z * s.x * s.y - c.x * s.z, c.x * c.z * s.y + s.x * s.z,
                c.y * s.z, c.x * c.z + s.x * s.y * s.z, c.x * s.y * s.z - c.z * s.x,
                -s.y, c.y * s.x, c.x * c.y
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerXZY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z, s.x * s.y - c.x * c.y * s.z, c.x * s.y + c.y * s.x * s.z,
                s.z, c.x * c.z, -c.z * s.x,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z, c.x * c.y - s.x * s.y * s.z
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerYXZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z - s.x * s.y * s.z, -c.x * s.z, c.z * s.y + c.y * s.x * s.z,
                c.z * s.x * s.y + c.y * s.z, c.x * c.z, s.y * s.z - c.y * c.z * s.x,
                -c.x * s.y, s.x, c.x * c.y
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerYZX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z, -s.z, c.z * s.y,
                s.x * s.y + c.x * c.y * s.z, c.x * c.z, c.x * s.y * s.z - c.y * s.x,
                c.y * s.x * s.z - c.x * s.y, c.z * s.x, c.x * c.y + s.x * s.y * s.z
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerZXY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z + s.x * s.y * s.z, c.z * s.x * s.y - c.y * s.z, c.x * s.y,
                c.x * s.z, c.x * c.z, -s.x,
                c.y * s.x * s.z - c.z * s.y, c.y * c.z * s.x + s.y * s.z, c.x * c.y
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerZYX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float3X3(
                c.y * c.z, -c.y * s.z, s.y,
                c.z * s.x * s.y + c.x * s.z, c.x * c.z - s.x * s.y * s.z, -c.y * s.x,
                s.x * s.z - c.x * c.z * s.y, c.z * s.x + c.x * s.y * s.z, c.x * c.y
            );
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerXYZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXYZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerXZY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXZY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerYXZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYXZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerYZX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYZX(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerZXY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZXY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 EulerZYX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZYX(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float3x3 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Euler(Float3 xyz, Math.RotationOrder order = Math.RotationOrder.Default)
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
        /// Returns a Float3x3 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Euler(SoftFloat x, SoftFloat y, SoftFloat z,
            Math.RotationOrder order = Math.RotationOrder.Default)
        {
            return Euler(new Float3(x, y, z), order);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 RotateX(SoftFloat angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float3X3(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, c, -s,
                SoftFloat.Zero, s, c);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 RotateY(SoftFloat angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float3X3(c, SoftFloat.Zero, s,
                SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero,
                -s, SoftFloat.Zero, c);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 RotateZ(SoftFloat angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float3X3(c, -s, SoftFloat.Zero,
                s, c, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        //<summary>Returns a Float3x3 matrix representing a uniform scaling of all axes by s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Scale(SoftFloat s)
        {
            return new Float3X3(s, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, s, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, s);
        }

        /// <summary>Returns a Float3x3 matrix representing a non-uniform axis scaling by x, y and z.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Scale(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return new Float3X3(x, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, y, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, z);
        }

        /// <summary>Returns a Float3x3 matrix representing a non-uniform axis scaling by the components of the Float3 vector v.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Scale(Float3 v)
        {
            return Scale(v.x, v.y, v.z);
        }

        /// <summary>
        /// Returns a Float3x3 view rotation matrix given a unit length forward vector and a unit length up vector.
        /// The two input vectors are assumed to be unit length and not collinear.
        /// If these assumptions are not met use Float3x3.LookRotationSafe instead.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 LookRotation(Float3 forward, Float3 up)
        {
            Float3 t = Math.Normalize(Math.Cross(up, forward));
            return new Float3X3(t, Math.Cross(forward, t), forward);
        }

        /// <summary>
        /// Returns a Float3x3 view rotation matrix given a forward vector and an up vector.
        /// The two input vectors are not assumed to be unit length.
        /// If the magnitude of either of the vectors is so extreme that the calculation cannot be carried out reliably or the vectors are collinear,
        /// the identity will be returned instead.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 LookRotationSafe(Float3 forward, Float3 up)
        {
            SoftFloat forwardLengthSq = Math.Dot(forward, forward);
            SoftFloat upLengthSq = Math.Dot(up, up);

            forward *= Math.Rsqrt(forwardLengthSq);
            up *= Math.Rsqrt(upLengthSq);

            Float3 t = Math.Cross(up, forward);
            SoftFloat tLengthSq = Math.Dot(t, t);
            t *= Math.Rsqrt(tLengthSq);

            SoftFloat mn = Math.Min(Math.Min(forwardLengthSq, upLengthSq), tLengthSq);
            SoftFloat mx = Math.Max(Math.Max(forwardLengthSq, upLengthSq), tLengthSq);

            const uint bigValue = 0x799a130c;
            const uint smallValue = 0x0554ad2e;

            bool accept = mn > SoftFloat.FromRaw(smallValue) && mx < SoftFloat.FromRaw(bigValue) &&
                          Math.IsFinite(forwardLengthSq) && Math.IsFinite(upLengthSq) && Math.IsFinite(tLengthSq);
            return new Float3X3(
                Math.Select(new Float3(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero), t, accept),
                Math.Select(new Float3(SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero), Math.Cross(forward, t), accept),
                Math.Select(new Float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One), forward, accept));
        }

        public static explicit operator Float3X3(Float4X4 f4X4) => new Float3X3(f4X4);
    }

    public partial struct Float4X4
    {
        /// <summary>Constructs a Float4x4 from a Float3x3 rotation matrix and a Float3 translation vector.</summary>
        public Float4X4(Float3X3 rotation, Float3 translation)
        {
            c0 = new Float4(rotation.c0, SoftFloat.Zero);
            c1 = new Float4(rotation.c1, SoftFloat.Zero);
            c2 = new Float4(rotation.c2, SoftFloat.Zero);
            c3 = new Float4(translation, SoftFloat.One);
        }

        /// <summary>Constructs a Float4x4 from a quaternion and a Float3 translation vector.</summary>
        public Float4X4(Quaternion rotation, Float3 translation)
        {
            Float3X3 rot = new Float3X3(rotation);
            c0 = new Float4(rot.c0, SoftFloat.Zero);
            c1 = new Float4(rot.c1, SoftFloat.Zero);
            c2 = new Float4(rot.c2, SoftFloat.Zero);
            c3 = new Float4(translation, SoftFloat.One);
        }

        /// <summary>Constructs a Float4x4 from a RigidTransform.</summary>
        public Float4X4(RigidTransform transform)
        {
            Float3X3 rot = new Float3X3(transform._rot);
            c0 = new Float4(rot.c0, SoftFloat.Zero);
            c1 = new Float4(rot.c1, SoftFloat.Zero);
            c2 = new Float4(rot.c2, SoftFloat.Zero);
            c3 = new Float4(transform._pos, SoftFloat.One);
        }

        /// <summary>
        /// Returns a Float4x4 matrix representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 AxisAngle(Float3 axis, SoftFloat angle)
        {
            SoftFloat sina, cosa;
            Math.SinCos(angle, out sina, out cosa);

            Float4 u = new Float4(axis, SoftFloat.Zero);
            Float4 uYZX = u.yzxx;
            Float4 uZXY = u.zxyx;
            Float4 uInvCosa = u - u * cosa; // u * (1.0f - cosa);
            Float4 t = new Float4(u.xyz * sina, cosa);

            UInt4 ppnp = new UInt4(0x00000000, 0x00000000, 0x80000000, 0x00000000);
            UInt4 nppp = new UInt4(0x80000000, 0x00000000, 0x00000000, 0x00000000);
            UInt4 pnpp = new UInt4(0x00000000, 0x80000000, 0x00000000, 0x00000000);
            UInt4 mask = new UInt4(0xFFFFFFFF, 0xFFFFFFFF, 0xFFFFFFFF, 0x00000000);

            return new Float4X4(
                u.x * uInvCosa + Math.AsFloat((Math.AsUInt(t.wzyx) ^ ppnp) & mask),
                u.y * uInvCosa + Math.AsFloat((Math.AsUInt(t.zwxx) ^ nppp) & mask),
                u.z * uInvCosa + Math.AsFloat((Math.AsUInt(t.yxwx) ^ pnpp) & mask),
                new Float4(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One)
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerXYZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z, c.z * s.x * s.y - c.x * s.z, c.x * c.z * s.y + s.x * s.z, SoftFloat.Zero,
                c.y * s.z, c.x * c.z + s.x * s.y * s.z, c.x * s.y * s.z - c.z * s.x, SoftFloat.Zero,
                -s.y, c.y * s.x, c.x * c.y, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerXZY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x))); }
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z, s.x * s.y - c.x * c.y * s.z, c.x * s.y + c.y * s.x * s.z, SoftFloat.Zero,
                s.z, c.x * c.z, -c.z * s.x, SoftFloat.Zero,
                -c.z * s.y, c.y * s.x + c.x * s.y * s.z, c.x * c.y - s.x * s.y * s.z, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerYXZ(Float3 xyz)
        {
            // return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z - s.x * s.y * s.z, -c.x * s.z, c.z * s.y + c.y * s.x * s.z, SoftFloat.Zero,
                c.z * s.x * s.y + c.y * s.z, c.x * c.z, s.y * s.z - c.y * c.z * s.x, SoftFloat.Zero,
                -c.x * s.y, s.x, c.x * c.y, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerYZX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z, -s.z, c.z * s.y, SoftFloat.Zero,
                s.x * s.y + c.x * c.y * s.z, c.x * c.z, c.x * s.y * s.z - c.y * s.x, SoftFloat.Zero,
                c.y * s.x * s.z - c.x * s.y, c.z * s.x, c.x * c.y + s.x * s.y * s.z, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerZXY(Float3 xyz)
        {
            // return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z + s.x * s.y * s.z, c.z * s.x * s.y - c.y * s.z, c.x * s.y, SoftFloat.Zero,
                c.x * s.z, c.x * c.z, -s.x, SoftFloat.Zero,
                c.y * s.x * s.z - c.z * s.y, c.y * c.z * s.x + s.y * s.z, c.x * c.y, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerZYX(Float3 xyz)
        {
            // return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
            Float3 s, c;
            Math.SinCos(xyz, out s, out c);
            return new Float4X4(
                c.y * c.z, -c.y * s.z, s.y, SoftFloat.Zero,
                c.z * s.x * s.y + c.x * s.z, c.x * c.z - s.x * s.y * s.z, -c.y * s.x, SoftFloat.Zero,
                s.x * s.z - c.x * c.z * s.y, c.z * s.x + c.x * s.y * s.z, c.x * c.y, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerXYZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXYZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerXZY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXZY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerYXZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYXZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerYZX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYZX(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerZXY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZXY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a Float4x4 rotation matrix constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 EulerZYX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZYX(new Float3(x, y, z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Euler(Float3 xyz, Math.RotationOrder order = Math.RotationOrder.Default)
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
        /// Returns a Float4x4 rotation matrix constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Euler(SoftFloat x, SoftFloat y, SoftFloat z,
            Math.RotationOrder order = Math.RotationOrder.Default)
        {
            return Euler(new Float3(x, y, z), order);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 RotateX(SoftFloat angle)
        {
            // {{1, 0, 0}, {0, c_0, -s_0}, {0, s_0, c_0}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float4X4(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, c, -s, SoftFloat.Zero,
                SoftFloat.Zero, s, c, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 RotateY(SoftFloat angle)
        {
            // {{c_1, 0, s_1}, {0, 1, 0}, {-s_1, 0, c_1}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float4X4(c, SoftFloat.Zero, s, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero,
                -s, SoftFloat.Zero, c, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 RotateZ(SoftFloat angle)
        {
            // {{c_2, -s_2, 0}, {s_2, c_2, 0}, {0, 0, 1}}
            SoftFloat s, c;
            Math.SinCos(angle, out s, out c);
            return new Float4X4(c, -s, SoftFloat.Zero, SoftFloat.Zero,
                s, c, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>Returns a Float4x4 scale matrix given 3 axis scales.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Scale(SoftFloat s)
        {
            return new Float4X4(s, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, s, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, s, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>Returns a Float4x4 scale matrix given a Float3 vector containing the 3 axis scales.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Scale(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return new Float4X4(x, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, y, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, z, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One);
        }

        /// <summary>Returns a Float4x4 scale matrix given a Float3 vector containing the 3 axis scales.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Scale(Float3 scales)
        {
            return Scale(scales.x, scales.y, scales.z);
        }

        /// <summary>Returns a Float4x4 translation matrix given a Float3 translation vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Translate(Float3 vector)
        {
            return new Float4X4(new Float4(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero),
                new Float4(SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero),
                new Float4(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero),
                new Float4(vector.x, vector.y, vector.z, SoftFloat.One));
        }

        /// <summary>
        /// Returns a Float4x4 view matrix given an eye position, a target point and a unit length up vector.
        /// The up vector is assumed to be unit length, the eye and target points are assumed to be distinct and
        /// the vector between them is assumes to be collinear with the up vector.
        /// If these assumptions are not met use Float4x4.LookRotationSafe instead.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 LookAt(Float3 eye, Float3 target, Float3 up)
        {
            Float3X3 rot = Float3X3.LookRotation(Math.Normalize(target - eye), up);

            Float4X4 matrix;
            matrix.c0 = new Float4(rot.c0, SoftFloat.Zero);
            matrix.c1 = new Float4(rot.c1, SoftFloat.Zero);
            matrix.c2 = new Float4(rot.c2, SoftFloat.Zero);
            matrix.c3 = new Float4(eye, SoftFloat.One);
            return matrix;
        }

        /// <summary>
        /// Returns a Float4x4 centered orthographic projection matrix.
        /// </summary>
        /// <param name="width">The width of the view volume.</param>
        /// <param name="height">The height of the view volume.</param>
        /// <param name="near">The distance to the near plane.</param>
        /// <param name="far">The distance to the far plane.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Ortho(SoftFloat width, SoftFloat height, SoftFloat near, SoftFloat far)
        {
            SoftFloat rcpdx = SoftFloat.One / width;
            SoftFloat rcpdy = SoftFloat.One / height;
            SoftFloat rcpdz = SoftFloat.One / (far - near);

            return new Float4X4(
                (SoftFloat)2.0f * rcpdx, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, (SoftFloat)2.0f * rcpdy, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, (SoftFloat)(-2.0f) * rcpdz, -(far + near) * rcpdz,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 off-center orthographic projection matrix.
        /// </summary>
        /// <param name="left">The minimum x-coordinate of the view volume.</param>
        /// <param name="right">The maximum x-coordinate of the view volume.</param>
        /// <param name="bottom">The minimum y-coordinate of the view volume.</param>
        /// <param name="top">The minimum y-coordinate of the view volume.</param>
        /// <param name="near">The distance to the near plane.</param>
        /// <param name="far">The distance to the far plane.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 OrthoOffCenter(SoftFloat left, SoftFloat right, SoftFloat bottom, SoftFloat top,
            SoftFloat near, SoftFloat far)
        {
            SoftFloat rcpdx = SoftFloat.One / (right - left);
            SoftFloat rcpdy = SoftFloat.One / (top - bottom);
            SoftFloat rcpdz = SoftFloat.One / (far - near);

            return new Float4X4(
                (SoftFloat)2.0f * rcpdx, SoftFloat.Zero, SoftFloat.Zero, -(right + left) * rcpdx,
                SoftFloat.Zero, (SoftFloat)2.0f * rcpdy, SoftFloat.Zero, -(top + bottom) * rcpdy,
                SoftFloat.Zero, SoftFloat.Zero, (SoftFloat)(-2.0f) * rcpdz, -(far + near) * rcpdz,
                SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One
            );
        }

        /// <summary>
        /// Returns a Float4x4 perspective projection matrix based on field of view.
        /// </summary>
        /// <param name="verticalFov">Vertical Field of view in radians.</param>
        /// <param name="aspect">X:Y aspect ratio.</param>
        /// <param name="near">Distance to near plane. Must be greater than zero.</param>
        /// <param name="far">Distance to far plane. Must be greater than zero.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 PerspectiveFov(SoftFloat verticalFov, SoftFloat aspect, SoftFloat near, SoftFloat far)
        {
            SoftFloat cotangent = SoftFloat.One / Math.Tan(verticalFov * (SoftFloat)0.5f);
            SoftFloat rcpdz = SoftFloat.One / (near - far);

            return new Float4X4(
                cotangent / aspect, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, cotangent, SoftFloat.Zero, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, (far + near) * rcpdz, (SoftFloat)2.0f * near * far * rcpdz,
                SoftFloat.Zero, SoftFloat.Zero, -SoftFloat.One, SoftFloat.Zero
            );
        }

        /// <summary>
        /// Returns a Float4x4 off-center perspective projection matrix.
        /// </summary>
        /// <param name="left">The x-coordinate of the left side of the clipping frustum at the near plane.</param>
        /// <param name="right">The x-coordinate of the right side of the clipping frustum at the near plane.</param>
        /// <param name="bottom">The y-coordinate of the bottom side of the clipping frustum at the near plane.</param>
        /// <param name="top">The y-coordinate of the top side of the clipping frustum at the near plane.</param>
        /// <param name="near">Distance to the near plane. Must be greater than zero.</param>
        /// <param name="far">Distance to the far plane. Must be greater than zero.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 PerspectiveOffCenter(SoftFloat left, SoftFloat right, SoftFloat bottom, SoftFloat top,
            SoftFloat near, SoftFloat far)
        {
            SoftFloat rcpdz = SoftFloat.One / (near - far);
            SoftFloat rcpWidth = SoftFloat.One / (right - left);
            SoftFloat rcpHeight = SoftFloat.One / (top - bottom);

            return new Float4X4(
                (SoftFloat)2.0f * near * rcpWidth, SoftFloat.Zero, (left + right) * rcpWidth, SoftFloat.Zero,
                SoftFloat.Zero, (SoftFloat)2.0f * near * rcpHeight, (bottom + top) * rcpHeight, SoftFloat.Zero,
                SoftFloat.Zero, SoftFloat.Zero, (far + near) * rcpdz, (SoftFloat)2.0f * near * far * rcpdz,
                SoftFloat.Zero, SoftFloat.Zero, -SoftFloat.One, SoftFloat.Zero
            );
        }

        /// <summary>
        /// Returns a Float4x4 matrix representing a combined scale-, rotation- and translation transform.
        /// Equivalent to mul(translationTransform, mul(rotationTransform, scaleTransform)).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 TRS(Float3 translation, Quaternion rotation, Float3 scale)
        {
            Float3X3 r = new Float3X3(rotation);
            return new Float4X4(new Float4(r.c0 * scale.x, SoftFloat.Zero),
                new Float4(r.c1 * scale.y, SoftFloat.Zero),
                new Float4(r.c2 * scale.z, SoftFloat.Zero),
                new Float4(translation, SoftFloat.One));
        }
    }

    partial class Math
    {
        /// <summary>
        /// Extracts a Float3x3 from the upper left 3x3 of a Float4x4.
        /// </summary>
        /// <param name="f4X4"><see cref="Float4x4"/> to extract a Float3x3 from.</param>
        /// <returns>Upper left 3x3 matrix as Float3x3.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3X3(Float4X4 f4X4)
        {
            return new Float3X3(f4X4);
        }

        /// <summary>Returns a Float3x3 matrix constructed from a quaternion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Float3X3(Quaternion rotation)
        {
            return new Float3X3(rotation);
        }

        /// <summary>Returns a Float4x4 constructed from a Float3x3 rotation matrix and a Float3 translation vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4X4(Float3X3 rotation, Float3 translation)
        {
            return new Float4X4(rotation, translation);
        }

        /// <summary>Returns a Float4x4 constructed from a quaternion and a Float3 translation vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4X4(Quaternion rotation, Float3 translation)
        {
            return new Float4X4(rotation, translation);
        }

        /// <summary>Returns a Float4x4 constructed from a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4X4 Float4X4(RigidTransform transform)
        {
            return new Float4X4(transform);
        }

        /// <summary>Returns an orthonormalized version of a Float3x3 matrix.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3X3 Orthonormalize(Float3X3 i)
        {
            Float3X3 o;

            Float3 u = i.c0;
            Float3 v = i.c1 - i.c0 * Dot(i.c1, i.c0);

            SoftFloat lenU = Length(u);
            SoftFloat lenV = Length(v);

            const uint smallValue = 0x0da24260;
            SoftFloat epsilon = SoftFloat.FromRaw(smallValue);

            bool c = lenU > epsilon && lenV > epsilon;

            o.c0 = Select(new Float3(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero), u / lenU, c);
            o.c1 = Select(new Float3(SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero), v / lenV, c);
            o.c2 = Cross(o.c0, o.c1);

            return o;
        }
    }
}
