using System;
using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    [Serializable]
    public struct RigidTransform
    {
        public Quaternion _rot;
        public Float3 _pos;

        /// <summary>A RigidTransform representing the identity transform.</summary>
        public static readonly RigidTransform Identity = new RigidTransform(
            new Quaternion(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One),
            new Float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.Zero));

        /// <summary>Constructs a RigidTransform from a rotation represented by a unit quaternion and a translation represented by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(Quaternion rotation, Float3 translation)
        {
            _rot = rotation;
            _pos = translation;
        }

        /// <summary>Constructs a RigidTransform from a rotation represented by a Float3x3 matrix and a translation represented by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(Float3X3 rotation, Float3 translation)
        {
            _rot = new Quaternion(rotation);
            _pos = translation;
        }

        /// <summary>Constructs a RigidTransform from a Float4x4. Assumes the matrix is orthonormal.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public RigidTransform(Float4X4 transform)
        {
            _rot = new Quaternion(transform);
            _pos = transform.c3.xyz;
        }


        /// <summary>
        /// Returns a RigidTransform representing a rotation around a unit axis by an angle in radians.
        /// The rotation direction is clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform AxisAngle(Float3 axis, SoftFloat angle)
        {
            return new RigidTransform(Quaternion.AxisAngle(axis, angle), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXYZ(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerXYZ(xyz), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXZY(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerXZY(xyz), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYXZ(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerYXZ(xyz), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYZX(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerYZX(xyz), Float3.zero);
        }


        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZXY(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerZXY(xyz), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZYX(Float3 xyz)
        {
            return new RigidTransform(Quaternion.EulerZYX(xyz), Float3.zero);
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the y-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXYZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXYZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the x-axis, then the z-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerXZY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerXZY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the x-axis and finally the z-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYXZ(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYXZ(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the y-axis, then the z-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerYZX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerYZX(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the x-axis and finally the y-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// This is the default order rotation order in Unity.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZXY(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZXY(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing a rotation around the z-axis, then the y-axis and finally the x-axis.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform EulerZYX(SoftFloat x, SoftFloat y, SoftFloat z)
        {
            return EulerZYX(new Float3(x, y, z));
        }

        /// <summary>
        /// Returns a RigidTransform constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="xyz">A Float3 vector containing the rotation angles around the x-, y- and z-axis measures in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Euler(Float3 xyz, Math.RotationOrder order = Math.RotationOrder.ZXY)
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
        /// Returns a RigidTransform constructed by first performing 3 rotations around the principal axes in a given order.
        /// All rotation angles are in radians and clockwise when looking along the rotation axis towards the origin.
        /// When the rotation order is known at compile time, it is recommended for performance reasons to use specific
        /// Euler rotation constructors such as EulerZXY(...).
        /// </summary>
        /// <param name="x">The rotation angle around the x-axis in radians.</param>
        /// <param name="y">The rotation angle around the y-axis in radians.</param>
        /// <param name="z">The rotation angle around the z-axis in radians.</param>
        /// <param name="order">The order in which the rotations are applied.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Euler(SoftFloat x, SoftFloat y, SoftFloat z,
            Math.RotationOrder order = Math.RotationOrder.Default)
        {
            return Euler(new Float3(x, y, z), order);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the x-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the x-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateX(SoftFloat angle)
        {
            return new RigidTransform(Quaternion.RotateX(angle), Float3.zero);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the y-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the y-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateY(SoftFloat angle)
        {
            return new RigidTransform(Quaternion.RotateY(angle), Float3.zero);
        }

        /// <summary>Returns a Float4x4 matrix that rotates around the z-axis by a given number of radians.</summary>
        /// <param name="angle">The clockwise rotation angle when looking along the z-axis towards the origin in radians.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RotateZ(SoftFloat angle)
        {
            return new RigidTransform(Quaternion.RotateZ(angle), Float3.zero);
        }

        /// <summary>Returns a RigidTransform that translates by an amount specified by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Translate(Float3 vector)
        {
            return new RigidTransform(Quaternion.Identity, vector);
        }


        /// <summary>Returns true if the RigidTransform is equal to a given RigidTransform, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(RigidTransform x)
        {
            return _rot.Equals(x._rot) && _pos.Equals(x._pos);
        }

        /// <summary>Returns true if the RigidTransform is equal to a given RigidTransform, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool Equals(object x)
        {
            return Equals((RigidTransform)x);
        }

        /// <summary>Returns a hash code for the RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode()
        {
            return (int)Math.Hash(this);
        }

        /// <summary>Returns a string representation of the RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("RigidTransform(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                _rot.value.x, _rot.value.y, _rot.value.z, _rot.value.w, _pos.x, _pos.y, _pos.z);
        }

        /// <summary>Returns a string representation of the quaternion using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("Float4x4(({0}f, {1}f, {2}f, {3}f),  ({4}f, {5}f, {6}f))",
                _rot.value.x.ToString(format, formatProvider),
                _rot.value.y.ToString(format, formatProvider),
                _rot.value.z.ToString(format, formatProvider),
                _rot.value.w.ToString(format, formatProvider),
                _pos.x.ToString(format, formatProvider),
                _pos.y.ToString(format, formatProvider),
                _pos.z.ToString(format, formatProvider));
        }
    }

    public static partial class Math
    {
        /// <summary>Returns a RigidTransform constructed from a rotation represented by a unit quaternion and a translation represented by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(Quaternion rot, Float3 pos)
        {
            return new RigidTransform(rot, pos);
        }

        /// <summary>Returns a RigidTransform constructed from a rotation represented by a unit quaternion and a translation represented by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(Float3X3 rotation, Float3 translation)
        {
            return new RigidTransform(rotation, translation);
        }

        /// <summary>Returns a RigidTransform constructed from a rotation represented by a Float3x3 matrix and a translation represented by a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform RigidTransform(Float4X4 transform)
        {
            return new RigidTransform(transform);
        }

        /// <summary>Returns the inverse of a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Inverse(RigidTransform t)
        {
            Quaternion invRotation = Inverse(t._rot);
            Float3 invTranslation = Mul(invRotation, -t._pos);
            return new RigidTransform(invRotation, invTranslation);
        }

        /// <summary>Returns the result of transforming the RigidTransform b by the RigidTransform a.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static RigidTransform Mul(RigidTransform a, RigidTransform b)
        {
            return new RigidTransform(Mul(a._rot, b._rot), Mul(a._rot, b._pos) + a._pos);
        }

        /// <summary>Returns the result of transforming a Float4 homogeneous coordinate by a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mul(RigidTransform a, Float4 pos)
        {
            return Float4(Mul(a._rot, pos.xyz) + a._pos * pos.w, pos.w);
        }

        /// <summary>Returns the result of rotating a Float3 vector by a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Rotate(RigidTransform a, Float3 dir)
        {
            return Mul(a._rot, dir);
        }

        /// <summary>Returns the result of transforming a Float3 point by a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Transform(RigidTransform a, Float3 pos)
        {
            return Mul(a._rot, pos) + a._pos;
        }

        /// <summary>Returns a uint hash code of a RigidTransform.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Hash(RigidTransform t)
        {
            return Hash(t._rot) + 0xC5C5394Bu * Hash(t._pos);
        }

        /// <summary>
        /// Returns a UInt4 vector hash code of a RigidTransform.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 HashWide(RigidTransform t)
        {
            return HashWide(t._rot) + 0xC5C5394Bu * HashWide(t._pos).xyzz;
        }
    }
}
