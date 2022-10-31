using System.Runtime.CompilerServices;

namespace GameLibrary.Mathematics
{
    public static partial class Math
    {
        /// <summary>Extrinsic rotation order. Specifies in which order rotations around the principal axes (x, y and z) are to be applied.</summary>
        public enum RotationOrder : byte
        {
            /// <summary>Extrinsic rotation around the x axis, then around the y axis and finally around the z axis.</summary>
            XYZ,
            /// <summary>Extrinsic rotation around the x axis, then around the z axis and finally around the y axis.</summary>
            XZY,
            /// <summary>Extrinsic rotation around the y axis, then around the x axis and finally around the z axis.</summary>
            YXZ,
            /// <summary>Extrinsic rotation around the y axis, then around the z axis and finally around the x axis.</summary>
            YZX,
            /// <summary>Extrinsic rotation around the z axis, then around the x axis and finally around the y axis.</summary>
            ZXY,
            /// <summary>Extrinsic rotation around the z axis, then around the y axis and finally around the x axis.</summary>
            ZYX,
            /// <summary>Unity default rotation order. Extrinsic Rotation around the z axis, then around the x axis and finally around the y axis.</summary>
            Default = ZXY
        };

        /// <summary>Specifies a shuffle component.</summary>
        public enum ShuffleComponent : byte
        {
            /// <summary>Specified the x component of the left vector.</summary>
            LeftX,
            /// <summary>Specified the y component of the left vector.</summary>
            LeftY,
            /// <summary>Specified the z component of the left vector.</summary>
            LeftZ,
            /// <summary>Specified the w component of the left vector.</summary>
            LeftW,

            /// <summary>Specified the x component of the right vector.</summary>
            RightX,
            /// <summary>Specified the y component of the right vector.</summary>
            RightY,
            /// <summary>Specified the z component of the right vector.</summary>
            RightZ,
            /// <summary>Specified the w component of the right vector.</summary>
            RightW
        };

        /// <summary>The smallest positive normal number representable in a float.</summary>
        public static SoftFloat FLTMINNormal => SoftFloat.FromRaw(0x00800000);

        /// <summary>The mathematical constant e also known as Euler's number. Approximately 2.72.</summary>
        public static SoftFloat E => SoftFloat.FromRaw(0x402df854);

        /// <summary>The base 2 logarithm of e. Approximately 1.44.</summary>
        public static SoftFloat LOG2E => SoftFloat.FromRaw(0x3fb8aa3b);

        /// <summary>The base 10 logarithm of e. Approximately 0.43.</summary>
        public static SoftFloat LOG10E => SoftFloat.FromRaw(0x3ede5bd9);

        /// <summary>The natural logarithm of 2. Approximately 0.69.</summary>
        public static SoftFloat LN2 => SoftFloat.FromRaw(0x3f317218);

        /// <summary>The natural logarithm of 10. Approximately 2.30.</summary>
        public static SoftFloat LN10 => SoftFloat.FromRaw(0x40135d8e);

        /// <summary>The mathematical constant pi. Approximately 3.14.</summary>
        public static SoftFloat PI => SoftFloat.FromRaw(0x40490fdb);

        /// <summary>pi / 2. Approximately 1.57.</summary>
        public static SoftFloat PIHalf => SoftFloat.FromRaw(0x3fc90fdb);

        /// <summary>pi / 4. Approximately 0.79.</summary>
        public static SoftFloat PIOver4 => SoftFloat.FromRaw(0x3f490fdb);

        /// <summary>pi * 2. Approximately 6.28.</summary>
        public static SoftFloat TwoPI => SoftFloat.FromRaw(0x40c90fdb);

        /// <summary>The square root 2. Approximately 1.41.</summary>
        public static SoftFloat Sqrt2 => SoftFloat.FromRaw(0x3fb504f3);

        /// <summary>
        /// The difference between 1.0f and the next representable f32/single precision number.
        ///
        /// Beware:
        /// This value is different from System.Single.Epsilon, which is the smallest, positive, denormalized f32/single.
        /// </summary>
        public static SoftFloat Epsilon => SoftFloat.FromRaw(0x34000000);

        /// <summary>
        /// Single precision constant for positive infinity.
        /// </summary>
        public static SoftFloat Infinity => SoftFloat.PositiveInfinity;

        /// <summary>
        /// Single precision constant for Not a Number.
        ///
        /// NAN is considered unordered, which means all comparisons involving it are false except for not equal (operator !=).
        /// As a consequence, NAN == NAN is false but NAN != NAN is true.
        ///
        /// Additionally, there are multiple bit representations for Not a Number, so if you must test if your value
        /// is NAN, use isnan().
        /// </summary>
        public static SoftFloat NAN => SoftFloat.NaN;

        /// <summary>Returns the bit pattern of a uint as an int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asint(uint x) { return (int)x; }

        /// <summary>Returns the bit pattern of a UInt2 as an Int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Asint(UInt2 x) { return Int2((int)x.x, (int)x.y); }

        /// <summary>Returns the bit pattern of a UInt3 as an Int3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Asint(UInt3 x) { return Int3((int)x.x, (int)x.y, (int)x.z); }

        /// <summary>Returns the bit pattern of a UInt4 as an Int4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Asint(UInt4 x) { return Int4((int)x.x, (int)x.y, (int)x.z, (int)x.w); }


        /// <summary>Returns the bit pattern of a float as an int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Asint(SoftFloat x) {
            return (int)x.RawValue;
        }

        /// <summary>Returns the bit pattern of a Float2 as an Int2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Asint(Float2 x) { return Int2(Asint(x.x), Asint(x.y)); }

        /// <summary>Returns the bit pattern of a Float3 as an Int3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Asint(Float3 x) { return Int3(Asint(x.x), Asint(x.y), Asint(x.z)); }

        /// <summary>Returns the bit pattern of a Float4 as an Int4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Asint(Float4 x) { return Int4(Asint(x.x), Asint(x.y), Asint(x.z), Asint(x.w)); }


        /// <summary>Returns the bit pattern of an int as a uint.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Asuint(int x) { return (uint)x; }

        /// <summary>Returns the bit pattern of an Int2 as a UInt2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Asuint(Int2 x) { return UInt2((uint)x.x, (uint)x.y); }

        /// <summary>Returns the bit pattern of an Int3 as a UInt3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Asuint(Int3 x) { return UInt3((uint)x.x, (uint)x.y, (uint)x.z); }

        /// <summary>Returns the bit pattern of an Int4 as a UInt4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Asuint(Int4 x) { return UInt4((uint)x.x, (uint)x.y, (uint)x.z, (uint)x.w); }


        /// <summary>Returns the bit pattern of a float as a uint.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Asuint(SoftFloat x) { return (uint)Asint(x); }

        /// <summary>Returns the bit pattern of a Float2 as a UInt2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Asuint(Float2 x) { return UInt2(Asuint(x.x), Asuint(x.y)); }

        /// <summary>Returns the bit pattern of a Float3 as a UInt3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Asuint(Float3 x) { return UInt3(Asuint(x.x), Asuint(x.y), Asuint(x.z)); }

        /// <summary>Returns the bit pattern of a Float4 as a UInt4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Asuint(Float4 x) { return UInt4(Asuint(x.x), Asuint(x.y), Asuint(x.z), Asuint(x.w)); }


        /// <summary>Returns the bit pattern of a ulong as a long.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Aslong(ulong x) { return (long)x; }


        /// <summary>Returns the bit pattern of a long as a ulong.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Asulong(long x) { return (ulong)x; }


        /// <summary>Returns the bit pattern of an int as a float.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Asfloat(int x)
        {
            return SoftFloat.FromRaw((uint)x);
        }

        /// <summary>Returns the bit pattern of an Int2 as a Float2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Asfloat(Int2 x) { return Float2(Asfloat(x.x), Asfloat(x.y)); }

        /// <summary>Returns the bit pattern of an Int3 as a Float3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Asfloat(Int3 x) { return Float3(Asfloat(x.x), Asfloat(x.y), Asfloat(x.z)); }

        /// <summary>Returns the bit pattern of an Int4 as a Float4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Asfloat(Int4 x) { return Float4(Asfloat(x.x), Asfloat(x.y), Asfloat(x.z), Asfloat(x.w)); }


        /// <summary>Returns the bit pattern of a uint as a float.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Asfloat(uint x) { return Asfloat((int)x); }

        /// <summary>Returns the bit pattern of a UInt2 as a Float2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Asfloat(UInt2 x) { return Float2(Asfloat(x.x), Asfloat(x.y)); }

        /// <summary>Returns the bit pattern of a UInt3 as a Float3.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Asfloat(UInt3 x) { return Float3(Asfloat(x.x), Asfloat(x.y), Asfloat(x.z)); }

        /// <summary>Returns the bit pattern of a UInt4 as a Float4.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Asfloat(UInt4 x) { return Float4(Asfloat(x.x), Asfloat(x.y), Asfloat(x.z), Asfloat(x.w)); }

        /// <summary>
        /// Returns a bitmask representation of a bool4. Storing one 1 bit per component
        /// in LSB order, from lower to higher bits (so 4 bits in total).
        /// The component x is stored at bit 0,
        /// The component y is stored at bit 1,
        /// The component z is stored at bit 2,
        /// The component w is stored at bit 3
        /// The bool4(x = true, y = true, z = false, w = true) would produce the value 1011 = 0xB
        /// </summary>
        /// <param name="value">The input bool4 to calculate the bitmask for</param>
        /// <returns>A bitmask representation of the bool4, in LSB order</returns>
        public static int Bitmask(bool4 value)
        {
            int mask = 0;
            if (value.x) mask |= 0x01;
            if (value.y) mask |= 0x02;
            if (value.z) mask |= 0x04;
            if (value.w) mask |= 0x08;
            return mask;
        }


        /// <summary>Returns true if the input float is a finite floating point value, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Isfinite(SoftFloat x) { return x.IsFinite(); }

        /// <summary>Returns a bool2 indicating for each component of a Float2 whether it is a finite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Isfinite(Float2 x) { return new bool2(Isfinite(x.x), Isfinite(x.y)); }

        /// <summary>Returns a bool3 indicating for each component of a Float3 whether it is a finite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Isfinite(Float3 x) { return new bool3(Isfinite(x.x), Isfinite(x.y), Isfinite(x.z)); }

        /// <summary>Returns a bool4 indicating for each component of a Float4 whether it is a finite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Isfinite(Float4 x) { return new bool4(Isfinite(x.x), Isfinite(x.y), Isfinite(x.z), Isfinite(x.w)); }


        /// <summary>Returns true if the input float is an infinite floating point value, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Isinf(SoftFloat x) { return !x.IsFinite(); }

        /// <summary>Returns a bool2 indicating for each component of a Float2 whether it is an infinite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Isinf(Float2 x) { return new bool2(Isinf(x.x), Isinf(x.y)); }

        /// <summary>Returns a bool3 indicating for each component of a Float3 whether it is an infinite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Isinf(Float3 x) { return new bool3(Isinf(x.x), Isinf(x.y), Isinf(x.z)); }

        /// <summary>Returns a bool4 indicating for each component of a Float4 whether it is an infinite floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Isinf(Float4 x) { return new bool4(Isinf(x.x), Isinf(x.y), Isinf(x.z), Isinf(x.w)); }


        /// <summary>Returns true if the input float is a NaN (not a number) floating point value, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Isnan(SoftFloat x) { return (Asuint(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a bool2 indicating for each component of a Float2 whether it is a NaN (not a number) floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Isnan(Float2 x) { return (Asuint(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a bool3 indicating for each component of a Float3 whether it is a NaN (not a number) floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Isnan(Float3 x) { return (Asuint(x) & 0x7FFFFFFF) > 0x7F800000; }

        /// <summary>Returns a bool4 indicating for each component of a Float4 whether it is a NaN (not a number) floating point value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Isnan(Float4 x) { return (Asuint(x) & 0x7FFFFFFF) > 0x7F800000; }


        /// <summary>
        /// Checks if the input is a power of two.
        /// </summary>
        /// <remarks>If x is less than or equal to zero, then this function returns false.</remarks>
        /// <param name="x">Integer input.</param>
        /// <returns>bool where true indicates that input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Ispow2(int x)
        {
            return x > 0 && ((x & (x - 1)) == 0);
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="Int2"/> input</param>
        /// <returns><see cref="bool2"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Ispow2(Int2 x)
        {
            return new bool2(Ispow2(x.x), Ispow2(x.y));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="Int3"/> input</param>
        /// <returns><see cref="bool3"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Ispow2(Int3 x)
        {
            return new bool3(Ispow2(x.x), Ispow2(x.y), Ispow2(x.z));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="Int4"/> input</param>
        /// <returns><see cref="bool4"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ispow2(Int4 x)
        {
            return new bool4(Ispow2(x.x), Ispow2(x.y), Ispow2(x.z), Ispow2(x.w));
        }

        /// <summary>
        /// Checks if the input is a power of two.
        /// </summary>
        /// <remarks>If x is less than or equal to zero, then this function returns false.</remarks>
        /// <param name="x">Unsigned integer input.</param>
        /// <returns>bool where true indicates that input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Ispow2(uint x)
        {
            return x > 0 && ((x & (x - 1)) == 0);
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="UInt2"/> input</param>
        /// <returns><see cref="bool2"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 Ispow2(UInt2 x)
        {
            return new bool2(Ispow2(x.x), Ispow2(x.y));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="UInt3"/> input</param>
        /// <returns><see cref="bool3"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 Ispow2(UInt3 x)
        {
            return new bool3(Ispow2(x.x), Ispow2(x.y), Ispow2(x.z));
        }

        /// <summary>
        /// Checks if each component of the input is a power of two.
        /// </summary>
        /// <remarks>If a component of x is less than or equal to zero, then this function returns false in that component.</remarks>
        /// <param name="x"><see cref="UInt4"/> input</param>
        /// <returns><see cref="bool4"/> where true in a component indicates the same component in the input was a power of two.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 Ispow2(UInt4 x)
        {
            return new bool4(Ispow2(x.x), Ispow2(x.y), Ispow2(x.z), Ispow2(x.w));
        }

        /// <summary>Returns the minimum of two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MIN(int x, int y) { return x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 MIN(Int2 x, Int2 y) { return new Int2(MIN(x.x, y.x), MIN(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 MIN(Int3 x, Int3 y) { return new Int3(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 MIN(Int4 x, Int4 y) { return new Int4(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z), MIN(x.w, y.w)); }


        /// <summary>Returns the minimum of two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint MIN(uint x, uint y) { return x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 MIN(UInt2 x, UInt2 y) { return new UInt2(MIN(x.x, y.x), MIN(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 MIN(UInt3 x, UInt3 y) { return new UInt3(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 MIN(UInt4 x, UInt4 y) { return new UInt4(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z), MIN(x.w, y.w)); }


        /// <summary>Returns the minimum of two long values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MIN(long x, long y) { return x < y ? x : y; }


        /// <summary>Returns the minimum of two ulong values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong MIN(ulong x, ulong y) { return x < y ? x : y; }


        /// <summary>Returns the minimum of two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat MIN(SoftFloat x, SoftFloat y) { return y.IsNaN() || x < y ? x : y; }

        /// <summary>Returns the componentwise minimum of two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 MIN(Float2 x, Float2 y) { return new Float2(MIN(x.x, y.x), MIN(x.y, y.y)); }

        /// <summary>Returns the componentwise minimum of two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 MIN(Float3 x, Float3 y) { return new Float3(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z)); }

        /// <summary>Returns the componentwise minimum of two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 MIN(Float4 x, Float4 y) { return new Float4(MIN(x.x, y.x), MIN(x.y, y.y), MIN(x.z, y.z), MIN(x.w, y.w)); }


        /// <summary>Returns the maximum of two int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int MAX(int x, int y) { return x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 MAX(Int2 x, Int2 y) { return new Int2(MAX(x.x, y.x), MAX(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 MAX(Int3 x, Int3 y) { return new Int3(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 MAX(Int4 x, Int4 y) { return new Int4(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z), MAX(x.w, y.w)); }


        /// <summary>Returns the maximum of two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint MAX(uint x, uint y) { return x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 MAX(UInt2 x, UInt2 y) { return new UInt2(MAX(x.x, y.x), MAX(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 MAX(UInt3 x, UInt3 y) { return new UInt3(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 MAX(UInt4 x, UInt4 y) { return new UInt4(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z), MAX(x.w, y.w)); }


        /// <summary>Returns the maximum of two long values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long MAX(long x, long y) { return x > y ? x : y; }


        /// <summary>Returns the maximum of two ulong values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong MAX(ulong x, ulong y) { return x > y ? x : y; }


        /// <summary>Returns the maximum of two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat MAX(SoftFloat x, SoftFloat y) { return y.IsNaN() || x > y ? x : y; }

        /// <summary>Returns the componentwise maximum of two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 MAX(Float2 x, Float2 y) { return new Float2(MAX(x.x, y.x), MAX(x.y, y.y)); }

        /// <summary>Returns the componentwise maximum of two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 MAX(Float3 x, Float3 y) { return new Float3(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z)); }

        /// <summary>Returns the componentwise maximum of two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 MAX(Float4 x, Float4 y) { return new Float4(MAX(x.x, y.x), MAX(x.y, y.y), MAX(x.z, y.z), MAX(x.w, y.w)); }



        /// <summary>Returns the result of linearly interpolating from x to y using the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Lerp(SoftFloat x, SoftFloat y, SoftFloat s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Lerp(Float2 x, Float2 y, SoftFloat s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Lerp(Float3 x, Float3 y, SoftFloat s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Lerp(Float4 x, Float4 y, SoftFloat s) { return x + s * (y - x); }


        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Lerp(Float2 x, Float2 y, Float2 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Lerp(Float3 x, Float3 y, Float3 s) { return x + s * (y - x); }

        /// <summary>Returns the result of a componentwise linear interpolating from x to y using the corresponding components of the interpolation parameter s.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Lerp(Float4 x, Float4 y, Float4 s) { return x + s * (y - x); }


        /// <summary>Returns the result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Unlerp(SoftFloat a, SoftFloat b, SoftFloat x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Unlerp(Float2 a, Float2 b, Float2 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Unlerp(Float3 a, Float3 b, Float3 x) { return (x - a) / (b - a); }

        /// <summary>Returns the componentwise result of normalizing a floating point value x to a range [a, b]. The opposite of lerp. Equivalent to (x - a) / (b - a).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Unlerp(Float4 a, Float4 b, Float4 x) { return (x - a) / (b - a); }


        /// <summary>Returns the result of a non-clamping linear remapping of a value x from [a, b] to [c, d].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Remap(SoftFloat a, SoftFloat b, SoftFloat c, SoftFloat d, SoftFloat x) { return Lerp(c, d, Unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from [a, b] to [c, d].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Remap(Float2 a, Float2 b, Float2 c, Float2 d, Float2 x) { return Lerp(c, d, Unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from [a, b] to [c, d].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Remap(Float3 a, Float3 b, Float3 c, Float3 d, Float3 x) { return Lerp(c, d, Unlerp(a, b, x)); }

        /// <summary>Returns the componentwise result of a non-clamping linear remapping of a value x from [a, b] to [c, d].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Remap(Float4 a, Float4 b, Float4 c, Float4 d, Float4 x) { return Lerp(c, d, Unlerp(a, b, x)); }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Mad(int a, int b, int c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Mad(Int2 a, Int2 b, Int2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Mad(Int3 a, Int3 b, Int3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Mad(Int4 a, Int4 b, Int4 c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Mad(uint a, uint b, uint c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Mad(UInt2 a, UInt2 b, UInt2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Mad(UInt3 a, UInt3 b, UInt3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Mad(UInt4 a, UInt4 b, UInt4 c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 long values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Mad(long a, long b, long c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 ulong values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Mad(ulong a, ulong b, ulong c) { return a * b + c; }


        /// <summary>Returns the result of a multiply-add operation (a * b + c) on 3 float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Mad(float a, float b, float c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Mad(Float2 a, Float2 b, Float2 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Mad(Float3 a, Float3 b, Float3 c) { return a * b + c; }

        /// <summary>Returns the result of a componentwise multiply-add operation (a * b + c) on 3 Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Mad(Float4 a, Float4 b, Float4 c) { return a * b + c; }


        /// <summary>Returns the result of clamping the value x into the interval [a, b], where x, a and b are int values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Clamp(int x, int a, int b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the Int2 x into the interval [a, b], where a and b are Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Clamp(Int2 x, Int2 a, Int2 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the Int3 x into the interval [a, b], where x, a and b are Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Clamp(Int3 x, Int3 a, Int3 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Clamp(Int4 x, Int4 a, Int4 b) { return MAX(a, MIN(b, x)); }


        /// <summary>Returns the result of clamping the value x into the interval [a, b], where x, a and b are uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Clamp(uint x, uint a, uint b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Clamp(UInt2 x, UInt2 a, UInt2 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Clamp(UInt3 x, UInt3 a, UInt3 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Clamp(UInt4 x, UInt4 a, UInt4 b) { return MAX(a, MIN(b, x)); }


        /// <summary>Returns the result of clamping the value x into the interval [a, b], where x, a and b are long values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Clamp(long x, long a, long b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of clamping the value x into the interval [a, b], where x, a and b are ulong values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Clamp(ulong x, ulong a, ulong b) { return MAX(a, MIN(b, x)); }


        /// <summary>Returns the result of clamping the value x into the interval [a, b], where x, a and b are float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Clamp(SoftFloat x, SoftFloat a, SoftFloat b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Clamp(Float2 x, Float2 a, Float2 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Clamp(Float3 x, Float3 a, Float3 b) { return MAX(a, MIN(b, x)); }

        /// <summary>Returns the result of a componentwise clamping of the value x into the interval [a, b], where x, a and b are Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Clamp(Float4 x, Float4 a, Float4 b) { return MAX(a, MIN(b, x)); }


        /// <summary>Returns the result of clamping the float value x into the interval [0, 1].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Saturate(SoftFloat x) { return Clamp(x, SoftFloat.Zero, SoftFloat.One); }

        /// <summary>Returns the result of a componentwise clamping of the Float2 vector x into the interval [0, 1].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Saturate(Float2 x) { return Clamp(x, new Float2(SoftFloat.Zero), new Float2(SoftFloat.One)); }

        /// <summary>Returns the result of a componentwise clamping of the Float3 vector x into the interval [0, 1].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Saturate(Float3 x) { return Clamp(x, new Float3(SoftFloat.Zero), new Float3(SoftFloat.One)); }

        /// <summary>Returns the result of a componentwise clamping of the Float4 vector x into the interval [0, 1].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Saturate(Float4 x) { return Clamp(x, new Float4(SoftFloat.Zero), new Float4(SoftFloat.One)); }


        /// <summary>Returns the absolute value of a int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Abs(int x) { return MAX(-x, x); }

        /// <summary>Returns the componentwise absolute value of a Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Abs(Int2 x) { return MAX(-x, x); }

        /// <summary>Returns the componentwise absolute value of a Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Abs(Int3 x) { return MAX(-x, x); }

        /// <summary>Returns the componentwise absolute value of a Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Abs(Int4 x) { return MAX(-x, x); }

        /// <summary>Returns the absolute value of a long value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Abs(long x) { return MAX(-x, x); }


        /// <summary>Returns the absolute value of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Abs(SoftFloat x) { return SoftFloat.Abs(x); }

        /// <summary>Returns the componentwise absolute value of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Abs(Float2 x) { return new Float2(Abs(x.x), Abs(x.y)); }

        /// <summary>Returns the componentwise absolute value of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Abs(Float3 x) { return new Float3(Abs(x.x), Abs(x.y), Abs(x.z)); }

        /// <summary>Returns the componentwise absolute value of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Abs(Float4 x) { return new Float4(Abs(x.x), Abs(x.y), Abs(x.z), Abs(x.w)); }


        /// <summary>Returns the dot product of two int values. Equivalent to multiplication.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(int x, int y) { return x * y; }

        /// <summary>Returns the dot product of two Int2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(Int2 x, Int2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two Int3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(Int3 x, Int3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two Int4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Dot(Int4 x, Int4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the dot product of two uint values. Equivalent to multiplication.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(uint x, uint y) { return x * y; }

        /// <summary>Returns the dot product of two UInt2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(UInt2 x, UInt2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two UInt3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(UInt3 x, UInt3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two UInt4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Dot(UInt4 x, UInt4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the dot product of two float values. Equivalent to multiplication.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(SoftFloat x, SoftFloat y) { return x * y; }

        /// <summary>Returns the dot product of two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(Float2 x, Float2 y) { return x.x * y.x + x.y * y.y; }

        /// <summary>Returns the dot product of two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(Float3 x, Float3 y) { return x.x * y.x + x.y * y.y + x.z * y.z; }

        /// <summary>Returns the dot product of two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Dot(Float4 x, Float4 y) { return x.x * y.x + x.y * y.y + x.z * y.z + x.w * y.w; }


        /// <summary>Returns the tangent of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Tan(SoftFloat x) { return SoftFloatMath.Tan(x); }

        /// <summary>Returns the componentwise tangent of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Tan(Float2 x) { return new Float2(Tan(x.x), Tan(x.y)); }

        /// <summary>Returns the componentwise tangent of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Tan(Float3 x) { return new Float3(Tan(x.x), Tan(x.y), Tan(x.z)); }

        /// <summary>Returns the componentwise tangent of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Tan(Float4 x) { return new Float4(Tan(x.x), Tan(x.y), Tan(x.z), Tan(x.w)); }


        /// <summary>Returns the arctangent of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Atan(SoftFloat x) { return SoftFloatMath.Atan(x); }

        /// <summary>Returns the componentwise arctangent of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Atan(Float2 x) { return new Float2(Atan(x.x), Atan(x.y)); }

        /// <summary>Returns the componentwise arctangent of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Atan(Float3 x) { return new Float3(Atan(x.x), Atan(x.y), Atan(x.z)); }

        /// <summary>Returns the componentwise arctangent of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Atan(Float4 x) { return new Float4(Atan(x.x), Atan(x.y), Atan(x.z), Atan(x.w)); }


        /// <summary>Returns the 2-argument arctangent of a pair of float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Atan2(SoftFloat y, SoftFloat x) { return SoftFloatMath.Atan2(y, x); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of floats2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Atan2(Float2 y, Float2 x) { return new Float2(Atan2(y.x, x.x), Atan2(y.y, x.y)); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of floats3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Atan2(Float3 y, Float3 x) { return new Float3(Atan2(y.x, x.x), Atan2(y.y, x.y), Atan2(y.z, x.z)); }

        /// <summary>Returns the componentwise 2-argument arctangent of a pair of floats4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Atan2(Float4 y, Float4 x) { return new Float4(Atan2(y.x, x.x), Atan2(y.y, x.y), Atan2(y.z, x.z), Atan2(y.w, x.w)); }


        /// <summary>Returns the cosine of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cos(SoftFloat x) { return SoftFloatMath.Cos(x); }

        /// <summary>Returns the componentwise cosine of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Cos(Float2 x) { return new Float2(Cos(x.x), Cos(x.y)); }

        /// <summary>Returns the componentwise cosine of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Cos(Float3 x) { return new Float3(Cos(x.x), Cos(x.y), Cos(x.z)); }

        /// <summary>Returns the componentwise cosine of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Cos(Float4 x) { return new Float4(Cos(x.x), Cos(x.y), Cos(x.z), Cos(x.w)); }


        /// <summary>Returns the arccosine of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Acos(SoftFloat x) { return SoftFloatMath.Acos(x); }

        /// <summary>Returns the componentwise arccosine of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Acos(Float2 x) { return new Float2(Acos(x.x), Acos(x.y)); }

        /// <summary>Returns the componentwise arccosine of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Acos(Float3 x) { return new Float3(Acos(x.x), Acos(x.y), Acos(x.z)); }

        /// <summary>Returns the componentwise arccosine of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Acos(Float4 x) { return new Float4(Acos(x.x), Acos(x.y), Acos(x.z), Acos(x.w)); }


        /// <summary>Returns the sine of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Sin(SoftFloat x) { return SoftFloatMath.Sin(x); }

        /// <summary>Returns the componentwise sine of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Sin(Float2 x) { return new Float2(Sin(x.x), Sin(x.y)); }

        /// <summary>Returns the componentwise sine of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Sin(Float3 x) { return new Float3(Sin(x.x), Sin(x.y), Sin(x.z)); }

        /// <summary>Returns the componentwise sine of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Sin(Float4 x) { return new Float4(Sin(x.x), Sin(x.y), Sin(x.z), Sin(x.w)); }


        /// <summary>Returns the arcsine of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Asin(SoftFloat x) { return SoftFloatMath.Asin(x); }

        /// <summary>Returns the componentwise arcsine of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Asin(Float2 x) { return new Float2(Asin(x.x), Asin(x.y)); }

        /// <summary>Returns the componentwise arcsine of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Asin(Float3 x) { return new Float3(Asin(x.x), Asin(x.y), Asin(x.z)); }

        /// <summary>Returns the componentwise arcsine of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Asin(Float4 x) { return new Float4(Asin(x.x), Asin(x.y), Asin(x.z), Asin(x.w)); }


        /// <summary>Returns the result of rounding a float value up to the nearest integral value less or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Floor(SoftFloat x) { return SoftFloatMath.Floor(x); }

        /// <summary>Returns the result of rounding each component of a Float2 vector value down to the nearest value less or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Floor(Float2 x) { return new Float2(Floor(x.x), Floor(x.y)); }

        /// <summary>Returns the result of rounding each component of a Float3 vector value down to the nearest value less or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Floor(Float3 x) { return new Float3(Floor(x.x), Floor(x.y), Floor(x.z)); }

        /// <summary>Returns the result of rounding each component of a Float4 vector value down to the nearest value less or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Floor(Float4 x) { return new Float4(Floor(x.x), Floor(x.y), Floor(x.z), Floor(x.w)); }


        /// <summary>Returns the result of rounding a float value up to the nearest integral value greater or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Ceil(SoftFloat x) { return SoftFloatMath.Ceil(x); }

        /// <summary>Returns the result of rounding each component of a Float2 vector value up to the nearest value greater or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Ceil(Float2 x) { return new Float2(Ceil(x.x), Ceil(x.y)); }

        /// <summary>Returns the result of rounding each component of a Float3 vector value up to the nearest value greater or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Ceil(Float3 x) { return new Float3(Ceil(x.x), Ceil(x.y), Ceil(x.z)); }

        /// <summary>Returns the result of rounding each component of a Float4 vector value up to the nearest value greater or equal to the original value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Ceil(Float4 x) { return new Float4(Ceil(x.x), Ceil(x.y), Ceil(x.z), Ceil(x.w)); }


        /// <summary>Returns the result of rounding a float value to the nearest integral value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Round(SoftFloat x) { return SoftFloatMath.Round(x); }

        /// <summary>Returns the result of rounding each component of a Float2 vector value to the nearest integral value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Round(Float2 x) { return new Float2(Round(x.x), Round(x.y)); }

        /// <summary>Returns the result of rounding each component of a Float3 vector value to the nearest integral value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Round(Float3 x) { return new Float3(Round(x.x), Round(x.y), Round(x.z)); }

        /// <summary>Returns the result of rounding each component of a Float4 vector value to the nearest integral value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Round(Float4 x) { return new Float4(Round(x.x), Round(x.y), Round(x.z), Round(x.w)); }


        /// <summary>Returns the result of truncating a float value to an integral float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Trunc(SoftFloat x) { return SoftFloatMath.Trunc(x); }

        /// <summary>Returns the result of a componentwise truncation of a Float2 value to an integral Float2 value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Trunc(Float2 x) { return new Float2(Trunc(x.x), Trunc(x.y)); }

        /// <summary>Returns the result of a componentwise truncation of a Float3 value to an integral Float3 value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Trunc(Float3 x) { return new Float3(Trunc(x.x), Trunc(x.y), Trunc(x.z)); }

        /// <summary>Returns the result of a componentwise truncation of a Float4 value to an integral Float4 value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Trunc(Float4 x) { return new Float4(Trunc(x.x), Trunc(x.y), Trunc(x.z), Trunc(x.w)); }


        /// <summary>Returns the fractional part of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Frac(SoftFloat x) { return x - Floor(x); }

        /// <summary>Returns the componentwise fractional parts of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Frac(Float2 x) { return x - Floor(x); }

        /// <summary>Returns the componentwise fractional parts of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Frac(Float3 x) { return x - Floor(x); }

        /// <summary>Returns the componentwise fractional parts of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Frac(Float4 x) { return x - Floor(x); }


        /// <summary>Returns the reciprocal a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Rcp(SoftFloat x) { return SoftFloat.One / x; }

        /// <summary>Returns the componentwise reciprocal a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Rcp(Float2 x) { return SoftFloat.One / x; }

        /// <summary>Returns the componentwise reciprocal a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Rcp(Float3 x) { return SoftFloat.One / x; }

        /// <summary>Returns the componentwise reciprocal a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Rcp(Float4 x) { return SoftFloat.One / x; }


        /// <summary>Returns the sign of a float value. -1.0f if it is less than zero, 0.0f if it is zero and 1.0f if it greater than zero.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Sign(SoftFloat x) { return x > SoftFloat.Zero ? SoftFloat.One : x < SoftFloat.Zero ? -SoftFloat.One : SoftFloat.Zero; }

        /// <summary>Returns the componentwise sign of a Float2 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Sign(Float2 x) { return new Float2(Sign(x.x), Sign(x.y)); }

        /// <summary>Returns the componentwise sign of a Float3 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Sign(Float3 x) { return new Float3(Sign(x.x), Sign(x.y), Sign(x.z)); }

        /// <summary>Returns the componentwise sign of a Float4 value. 1.0f for positive components, 0.0f for zero components and -1.0f for negative components.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Sign(Float4 x) { return new Float4(Sign(x.x), Sign(x.y), Sign(x.z), Sign(x.w)); }


        /// <summary>Returns x raised to the power y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Pow(SoftFloat x, SoftFloat y) { return SoftFloatMath.Pow(x, y); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Pow(Float2 x, Float2 y) { return new Float2(Pow(x.x, y.x), Pow(x.y, y.y)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Pow(Float3 x, Float3 y) { return new Float3(Pow(x.x, y.x), Pow(x.y, y.y), Pow(x.z, y.z)); }

        /// <summary>Returns the componentwise result of raising x to the power y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Pow(Float4 x, Float4 y) { return new Float4(Pow(x.x, y.x), Pow(x.y, y.y), Pow(x.z, y.z), Pow(x.w, y.w)); }


        /// <summary>Returns the base-e exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Exp(SoftFloat x) { return SoftFloatMath.Exp(x); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Exp(Float2 x) { return new Float2(Exp(x.x), Exp(x.y)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Exp(Float3 x) { return new Float3(Exp(x.x), Exp(x.y), Exp(x.z)); }

        /// <summary>Returns the componentwise base-e exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Exp(Float4 x) { return new Float4(Exp(x.x), Exp(x.y), Exp(x.z), Exp(x.w)); }


        /// <summary>Returns the base-2 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Exp2(SoftFloat x) { return SoftFloatMath.Exp(x) * SoftFloat.FromRaw(0x3f317218); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Exp2(Float2 x) { return new Float2(Exp2(x.x), Exp2(x.y)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Exp2(Float3 x) { return new Float3(Exp2(x.x), Exp2(x.y), Exp2(x.z)); }

        /// <summary>Returns the componentwise base-2 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Exp2(Float4 x) { return new Float4(Exp2(x.x), Exp2(x.y), Exp2(x.z), Exp2(x.w)); }


        /// <summary>Returns the base-10 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Exp10(SoftFloat x) { return SoftFloatMath.Exp(x) * SoftFloat.FromRaw(0x40135d8e); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Exp10(Float2 x) { return new Float2(Exp10(x.x), Exp10(x.y)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Exp10(Float3 x) { return new Float3(Exp10(x.x), Exp10(x.y), Exp10(x.z)); }

        /// <summary>Returns the componentwise base-10 exponential of x.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Exp10(Float4 x) { return new Float4(Exp10(x.x), Exp10(x.y), Exp10(x.z), Exp10(x.w)); }


        /// <summary>Returns the natural logarithm of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LOG(SoftFloat x) { return SoftFloatMath.Log(x); }

        /// <summary>Returns the componentwise natural logarithm of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 LOG(Float2 x) { return new Float2(LOG(x.x), LOG(x.y)); }

        /// <summary>Returns the componentwise natural logarithm of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 LOG(Float3 x) { return new Float3(LOG(x.x), LOG(x.y), LOG(x.z)); }

        /// <summary>Returns the componentwise natural logarithm of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 LOG(Float4 x) { return new Float4(LOG(x.x), LOG(x.y), LOG(x.z), LOG(x.w)); }


        /// <summary>Returns the base-2 logarithm of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LOG2(SoftFloat x) { return SoftFloatMath.Log2(x); }

        /// <summary>Returns the componentwise base-2 logarithm of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 LOG2(Float2 x) { return new Float2(LOG2(x.x), LOG2(x.y)); }

        /// <summary>Returns the componentwise base-2 logarithm of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 LOG2(Float3 x) { return new Float3(LOG2(x.x), LOG2(x.y), LOG2(x.z)); }

        /// <summary>Returns the componentwise base-2 logarithm of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 LOG2(Float4 x) { return new Float4(LOG2(x.x), LOG2(x.y), LOG2(x.z), LOG2(x.w)); }


        /// <summary>Returns the base-10 logarithm of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LOG10(SoftFloat x) { return SoftFloatMath.Log(x) * LOG10E; }

        /// <summary>Returns the componentwise base-10 logarithm of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 LOG10(Float2 x) { return new Float2(LOG10(x.x), LOG10(x.y)); }

        /// <summary>Returns the componentwise base-10 logarithm of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 LOG10(Float3 x) { return new Float3(LOG10(x.x), LOG10(x.y), LOG10(x.z)); }

        /// <summary>Returns the componentwise base-10 logarithm of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 LOG10(Float4 x) { return new Float4(LOG10(x.x), LOG10(x.y), LOG10(x.z), LOG10(x.w)); }


        /// <summary>Returns the floating point remainder of x/y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Fmod(SoftFloat x, SoftFloat y) { return x % y; }

        /// <summary>Returns the componentwise floating point remainder of x/y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Fmod(Float2 x, Float2 y) { return new Float2(x.x % y.x, x.y % y.y); }

        /// <summary>Returns the componentwise floating point remainder of x/y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Fmod(Float3 x, Float3 y) { return new Float3(x.x % y.x, x.y % y.y, x.z % y.z); }

        /// <summary>Returns the componentwise floating point remainder of x/y.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Fmod(Float4 x, Float4 y) { return new Float4(x.x % y.x, x.y % y.y, x.z % y.z, x.w % y.w); }


        /// <summary>Splits a float value into an integral part i and a fractional part that gets returned. Both parts take the sign of the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Modf(SoftFloat x, out SoftFloat i) { i = Trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a Float2 vector into an integral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Modf(Float2 x, out Float2 i) { i = Trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a Float3 vector into an integral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Modf(Float3 x, out Float3 i) { i = Trunc(x); return x - i; }

        /// <summary>
        /// Performs a componentwise split of a Float4 vector into an integral part i and a fractional part that gets returned.
        /// Both parts take the sign of the corresponding input component.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Modf(Float4 x, out Float4 i) { i = Trunc(x); return x - i; }


        /// <summary>Returns the square root of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Sqrt(SoftFloat x) { return SoftFloatMath.Sqrt(x); }

        /// <summary>Returns the componentwise square root of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Sqrt(Float2 x) { return new Float2(Sqrt(x.x), Sqrt(x.y)); }

        /// <summary>Returns the componentwise square root of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Sqrt(Float3 x) { return new Float3(Sqrt(x.x), Sqrt(x.y), Sqrt(x.z)); }

        /// <summary>Returns the componentwise square root of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Sqrt(Float4 x) { return new Float4(Sqrt(x.x), Sqrt(x.y), Sqrt(x.z), Sqrt(x.w)); }


        /// <summary>Returns the reciprocal square root of a float value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Rsqrt(SoftFloat x) { return SoftFloat.One / Sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Rsqrt(Float2 x) { return SoftFloat.One / Sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Rsqrt(Float3 x) { return SoftFloat.One / Sqrt(x); }

        /// <summary>Returns the componentwise reciprocal square root of a Float4 vector</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Rsqrt(Float4 x) { return SoftFloat.One / Sqrt(x); }


        /// <summary>Returns a normalized version of the Float2 vector x by scaling it by 1 / length(x).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Normalize(Float2 x) { return Rsqrt(Dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the Float3 vector x by scaling it by 1 / length(x).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Normalize(Float3 x) { return Rsqrt(Dot(x, x)) * x; }

        /// <summary>Returns a normalized version of the Float4 vector x by scaling it by 1 / length(x).</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Normalize(Float4 x) { return Rsqrt(Dot(x, x)) * x; }


        /// <summary>
        /// Returns a safe normalized version of the Float2 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public Float2 Normalizesafe(Float2 x, Float2 defaultvalue = new Float2())
        {
            SoftFloat len = Dot(x, x);
            return Select(defaultvalue, x * Rsqrt(len), len > FLTMINNormal);
        }

        /// <summary>
        /// Returns a safe normalized version of the Float3 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public Float3 Normalizesafe(Float3 x, Float3 defaultvalue = new Float3())
        {
            SoftFloat len = Dot(x, x);
            return Select(defaultvalue, x * Rsqrt(len), len > FLTMINNormal);
        }

        /// <summary>
        /// Returns a safe normalized version of the Float4 vector x by scaling it by 1 / length(x).
        /// Returns the given default value when 1 / length(x) does not produce a finite number.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static public Float4 Normalizesafe(Float4 x, Float4 defaultvalue = new Float4())
        {
            SoftFloat len = Dot(x, x);
            return Select(defaultvalue, x * Rsqrt(len), len > FLTMINNormal);
        }


        /// <summary>Returns the length of a float value. Equivalent to the absolute value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(SoftFloat x) { return Abs(x); }

        /// <summary>Returns the length of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(Float2 x) { return Sqrt(Dot(x, x)); }

        /// <summary>Returns the length of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(Float3 x) { return Sqrt(Dot(x, x)); }

        /// <summary>Returns the length of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Length(Float4 x) { return Sqrt(Dot(x, x)); }


        /// <summary>Returns the squared length of a float value. Equivalent to squaring the value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(SoftFloat x) { return x*x; }

        /// <summary>Returns the squared length of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(Float2 x) { return Dot(x, x); }

        /// <summary>Returns the squared length of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(Float3 x) { return Dot(x, x); }

        /// <summary>Returns the squared length of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat LengthSqr(Float4 x) { return Dot(x, x); }


        /// <summary>Returns the distance between two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distance(SoftFloat x, SoftFloat y) { return Abs(y - x); }

        /// <summary>Returns the distance between two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distance(Float2 x, Float2 y) { return Length(y - x); }

        /// <summary>Returns the distance between two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distance(Float3 x, Float3 y) { return Length(y - x); }

        /// <summary>Returns the distance between two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distance(Float4 x, Float4 y) { return Length(y - x); }


        /// <summary>Returns the distance between two float values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distancesq(SoftFloat x, SoftFloat y) { SoftFloat ymx = y - x; return ymx * ymx; }

        /// <summary>Returns the distance between two Float2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distancesq(Float2 x, Float2 y) { return LengthSqr(y - x); }

        /// <summary>Returns the distance between two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distancesq(Float3 x, Float3 y) { return LengthSqr(y - x); }

        /// <summary>Returns the distance between two Float4 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Distancesq(Float4 x, Float4 y) { return LengthSqr(y - x); }


        /// <summary>Returns the cross product of two Float3 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Cross(Float3 x, Float3 y) { return (x * y.yzx - x.yzx * y).yzx; }


        /// <summary>Returns a smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Smoothstep(SoftFloat a, SoftFloat b, SoftFloat x)
        {
            var t = Saturate((x - a) / (b - a));
            return t * t * ((SoftFloat)3.0f - ((SoftFloat)2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Smoothstep(Float2 a, Float2 b, Float2 x)
        {
            var t = Saturate((x - a) / (b - a));
            return t * t * ((SoftFloat)3.0f - ((SoftFloat)2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Smoothstep(Float3 a, Float3 b, Float3 x)
        {
            var t = Saturate((x - a) / (b - a));
            return t * t * ((SoftFloat)3.0f - ((SoftFloat)2.0f * t));
        }

        /// <summary>Returns a componentwise smooth Hermite interpolation between 0.0f and 1.0f when x is in [a, b].</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Smoothstep(Float4 a, Float4 b, Float4 x)
        {
            var t = Saturate((x - a) / (b - a));
            return t * t * ((SoftFloat)3.0f - ((SoftFloat)2.0f * t));
        }


        /// <summary>Returns true if any component of the input bool2 vector is true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(bool2 x) { return x.x || x.y; }

        /// <summary>Returns true if any component of the input bool3 vector is true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(bool3 x) { return x.x || x.y || x.z; }

        /// <summary>Returns true if any components of the input bool4 vector is true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(bool4 x) { return x.x || x.y || x.z || x.w; }


        /// <summary>Returns true if any component of the input Int2 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Int2 x) { return x.x != 0 || x.y != 0; }

        /// <summary>Returns true if any component of the input Int3 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Int3 x) { return x.x != 0 || x.y != 0 || x.z != 0; }

        /// <summary>Returns true if any components of the input Int4 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Int4 x) { return x.x != 0 || x.y != 0 || x.z != 0 || x.w != 0; }


        /// <summary>Returns true if any component of the input UInt2 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(UInt2 x) { return x.x != 0 || x.y != 0; }

        /// <summary>Returns true if any component of the input UInt3 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(UInt3 x) { return x.x != 0 || x.y != 0 || x.z != 0; }

        /// <summary>Returns true if any components of the input UInt4 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(UInt4 x) { return x.x != 0 || x.y != 0 || x.z != 0 || x.w != 0; }


        /// <summary>Returns true if any component of the input Float2 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Float2 x) { return !x.x.IsZero() || !x.y.IsZero(); }

        /// <summary>Returns true if any component of the input Float3 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Float3 x) { return !x.x.IsZero() || !x.y.IsZero() || !x.z.IsZero(); }

        /// <summary>Returns true if any component of the input Float4 vector is non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Any(Float4 x) { return !x.x.IsZero() || !x.y.IsZero() || !x.z.IsZero() || !x.w.IsZero(); }


        /// <summary>Returns true if all components of the input bool2 vector are true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(bool2 x) { return x.x && x.y; }

        /// <summary>Returns true if all components of the input bool3 vector are true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(bool3 x) { return x.x && x.y && x.z; }

        /// <summary>Returns true if all components of the input bool4 vector are true, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(bool4 x) { return x.x && x.y && x.z && x.w; }


        /// <summary>Returns true if all components of the input Int2 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Int2 x) { return x.x != 0 && x.y != 0; }

        /// <summary>Returns true if all components of the input Int3 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Int3 x) { return x.x != 0 && x.y != 0 && x.z != 0; }

        /// <summary>Returns true if all components of the input Int4 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Int4 x) { return x.x != 0 && x.y != 0 && x.z != 0 && x.w != 0; }


        /// <summary>Returns true if all components of the input UInt2 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(UInt2 x) { return x.x != 0 && x.y != 0; }

        /// <summary>Returns true if all components of the input UInt3 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(UInt3 x) { return x.x != 0 && x.y != 0 && x.z != 0; }

        /// <summary>Returns true if all components of the input UInt4 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(UInt4 x) { return x.x != 0 && x.y != 0 && x.z != 0 && x.w != 0; }


        /// <summary>Returns true if all components of the input Float2 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Float2 x) { return !x.x.IsZero() && !x.y.IsZero(); }

        /// <summary>Returns true if all components of the input Float3 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Float3 x) { return !x.x.IsZero() && !x.y.IsZero() && !x.z.IsZero(); }

        /// <summary>Returns true if all components of the input Float4 vector are non-zero, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool All(Float4 x) { return !x.x.IsZero() && !x.y.IsZero() && !x.z.IsZero() && !x.w.IsZero(); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Select(int a, int b, bool c)    { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Select(Int2 a, Int2 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Select(Int3 a, Int3 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Select(Int4 a, Int4 b, bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two Int2 vectors a and b based on a bool2 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Select(Int2 a, Int2 b, bool2 c) { return new Int2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two Int3 vectors a and b based on a bool3 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Select(Int3 a, Int3 b, bool3 c) { return new Int3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two Int4 vectors a and b based on a bool4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Select(Int4 a, Int4 b, bool4 c) { return new Int4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Select(uint a, uint b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Select(UInt2 a, UInt2 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Select(UInt3 a, UInt3 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Select(UInt4 a, UInt4 b, bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two UInt2 vectors a and b based on a bool2 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Select(UInt2 a, UInt2 b, bool2 c) { return new UInt2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two UInt3 vectors a and b based on a bool3 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Select(UInt3 a, UInt3 b, bool3 c) { return new UInt3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two UInt4 vectors a and b based on a bool4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Select(UInt4 a, UInt4 b, bool4 c) { return new UInt4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Select(long a, long b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Select(ulong a, ulong b, bool c) { return c ? b : a; }


        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Select(SoftFloat a, SoftFloat b, bool c)    { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Select(Float2 a, Float2 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Select(Float3 a, Float3 b, bool c) { return c ? b : a; }

        /// <summary>Returns b if c is true, a otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Select(Float4 a, Float4 b, bool c) { return c ? b : a; }


        /// <summary>
        /// Returns a componentwise selection between two Float2 vectors a and b based on a bool2 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Select(Float2 a, Float2 b, bool2 c) { return new Float2(c.x ? b.x : a.x, c.y ? b.y : a.y); }

        /// <summary>
        /// Returns a componentwise selection between two Float3 vectors a and b based on a bool3 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Select(Float3 a, Float3 b, bool3 c) { return new Float3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }

        /// <summary>
        /// Returns a componentwise selection between two Float4 vectors a and b based on a bool4 selection mask c.
        /// Per component, the component from b is selected when c is true, otherwise the component from a is selected.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Select(Float4 a, Float4 b, bool4 c) { return new Float4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }


        /// <summary>Computes a step function. Returns 1.0f when x >= y, 0.0f otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Step(SoftFloat y, SoftFloat x) { return Select(SoftFloat.Zero, SoftFloat.One, x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Step(Float2 y, Float2 x) { return Select(Float2(SoftFloat.Zero), Float2(SoftFloat.One), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Step(Float3 y, Float3 x) { return Select(Float3(SoftFloat.Zero), Float3(SoftFloat.One), x >= y); }

        /// <summary>Returns the result of a componentwise step function where each component is 1.0f when x >= y and 0.0f otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Step(Float4 y, Float4 x) { return Select(Float4(SoftFloat.Zero), Float4(SoftFloat.One), x >= y); }


        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Reflect(Float2 i, Float2 n) { return i - (SoftFloat)2.0f * n * Dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Reflect(Float3 i, Float3 n) { return i - (SoftFloat)2.0f * n * Dot(i, n); }

        /// <summary>Given an incident vector i and a normal vector n, returns the reflection vector r = i - 2.0f * dot(i, n) * n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Reflect(Float4 i, Float4 n) { return i - (SoftFloat)2.0f * n * Dot(i, n); }


        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Refract(Float2 i, Float2 n, SoftFloat eta)
        {
            SoftFloat ni = Dot(n, i);
            SoftFloat k = SoftFloat.One - eta * eta * (SoftFloat.One - ni * ni);
            return Select(SoftFloat.Zero, eta * i - (eta * ni + Sqrt(k)) * n, k >= SoftFloat.Zero);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Refract(Float3 i, Float3 n, SoftFloat eta)
        {
            SoftFloat ni = Dot(n, i);
            SoftFloat k = SoftFloat.One - eta * eta * (SoftFloat.One - ni * ni);
            return Select(SoftFloat.Zero, eta * i - (eta * ni + Sqrt(k)) * n, k >= SoftFloat.Zero);
        }

        /// <summary>Returns the refraction vector given the incident vector i, the normal vector n and the refraction index eta.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Refract(Float4 i, Float4 n, SoftFloat eta)
        {
            SoftFloat ni = Dot(n, i);
            SoftFloat k = SoftFloat.One - eta * eta * (SoftFloat.One - ni * ni);
            return Select(SoftFloat.Zero, eta * i - (eta * ni + Sqrt(k)) * n, k >= SoftFloat.Zero);
        }


        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(Unity.Mathematics.Float2,Unity.Mathematics.Float2,Unity.Mathematics.Float2)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Project(Float2 a, Float2 b)
        {
            return (Dot(a, b) / Dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(Unity.Mathematics.Float3,Unity.Mathematics.Float3,Unity.Mathematics.Float3)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Project(Float3 a, Float3 b)
        {
            return (Dot(a, b) / Dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b.
        /// </summary>
        /// <remarks>
        /// Some finite vectors a and b could generate a non-finite result. This is most likely when a's components
        /// are very large (close to Single.MaxValue) or when b's components are very small (close to FLT_MIN_NORMAL).
        /// In these cases, you can call <see cref="projectsafe(Unity.Mathematics.Float4,Unity.Mathematics.Float4,Unity.Mathematics.Float4)"/>
        /// which will use a given default value if the result is not finite.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <returns>Vector projection of a onto b.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Project(Float4 a, Float4 b)
        {
            return (Dot(a, b) / Dot(b, b)) * b;
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(Unity.Mathematics.Float2,Unity.Mathematics.Float2)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Projectsafe(Float2 a, Float2 b, Float2 defaultValue = new Float2())
        {
            var proj = Project(a, b);

            return Select(defaultValue, proj, All(Isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(Unity.Mathematics.Float3,Unity.Mathematics.Float3)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Projectsafe(Float3 a, Float3 b, Float3 defaultValue = new Float3())
        {
            var proj = Project(a, b);

            return Select(defaultValue, proj, All(Isfinite(proj)));
        }

        /// <summary>
        /// Compute vector projection of a onto b. If result is not finite, then return the default value instead.
        /// </summary>
        /// <remarks>
        /// This function performs extra checks to see if the result of projecting a onto b is finite. If you know that
        /// your inputs will generate a finite result or you don't care if the result is finite, then you can call
        /// <see cref="project(Unity.Mathematics.Float4,Unity.Mathematics.Float4)"/> instead which is faster than this
        /// function.
        /// </remarks>
        /// <param name="a">Vector to project.</param>
        /// <param name="b">Non-zero vector to project onto.</param>
        /// <param name="defaultValue">Default value to return if projection is not finite.</param>
        /// <returns>Vector projection of a onto b or the default value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Projectsafe(Float4 a, Float4 b, Float4 defaultValue = new Float4())
        {
            var proj = Project(a, b);

            return Select(defaultValue, proj, All(Isfinite(proj)));
        }


        /// <summary>Conditionally flips a vector n to face in the direction of i. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Faceforward(Float2 n, Float2 i, Float2 ng) { return Select(n, -n, Dot(ng, i) >= SoftFloat.Zero); }

        /// <summary>Conditionally flips a vector n to face in the direction of i. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Faceforward(Float3 n, Float3 i, Float3 ng) { return Select(n, -n, Dot(ng, i) >= SoftFloat.Zero); }

        /// <summary>Conditionally flips a vector n to face in the direction of i. Returns n if dot(i, ng) &lt; 0, -n otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Faceforward(Float4 n, Float4 i, Float4 ng) { return Select(n, -n, Dot(ng, i) >= SoftFloat.Zero); }


        /// <summary>Returns the sine and cosine of the input float value x through the out parameters s and c.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Sincos(SoftFloat x, out SoftFloat s, out SoftFloat c) { s = Sin(x); c = Cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input Float2 vector x through the out parameters s and c.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Sincos(Float2 x, out Float2 s, out Float2 c) { s = Sin(x); c = Cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input Float3 vector x through the out parameters s and c.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Sincos(Float3 x, out Float3 s, out Float3 c) { s = Sin(x); c = Cos(x); }

        /// <summary>Returns the componentwise sine and cosine of the input Float4 vector x through the out parameters s and c.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Sincos(Float4 x, out Float4 s, out Float4 c) { s = Sin(x); c = Cos(x); }


        /// <summary>Returns number of 1-bits in the binary representation of an int value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">int value in which to count bits set to 1.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Countbits(int x) { return Countbits((uint)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an Int2 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Int2 value in which to count bits for each component.</param>
        /// <returns>Int2 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Countbits(Int2 x) { return Countbits((UInt2)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an Int3 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Int3 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Countbits(Int3 x) { return Countbits((UInt3)x); }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of an Int4 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Int4 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Countbits(Int4 x) { return Countbits((UInt4)x); }


        /// <summary>Returns number of 1-bits in the binary representation of a uint value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Countbits(uint x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return (int)((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a UInt2 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Int2 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Countbits(UInt2 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return Int2((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a UInt3 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Int3 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Countbits(UInt3 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return Int3((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns component-wise number of 1-bits in the binary representation of a UInt4 vector. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Int4 containing number of bits set to 1 within each component of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Countbits(UInt4 x)
        {
            x = x - ((x >> 1) & 0x55555555);
            x = (x & 0x33333333) + ((x >> 2) & 0x33333333);
            return Int4((((x + (x >> 4)) & 0x0F0F0F0F) * 0x01010101) >> 24);
        }

        /// <summary>Returns number of 1-bits in the binary representation of a ulong value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Countbits(ulong x)
        {
            x = x - ((x >> 1) & 0x5555555555555555);
            x = (x & 0x3333333333333333) + ((x >> 2) & 0x3333333333333333);
            return (int)((((x + (x >> 4)) & 0x0F0F0F0F0F0F0F0F) * 0x0101010101010101) >> 56);
        }

        /// <summary>Returns number of 1-bits in the binary representation of a long value. Also known as the Hamming weight, popcnt on x86, and vcnt on ARM.</summary>
        /// <param name="x">Number in which to count bits.</param>
        /// <returns>Number of bits set to 1 within x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Countbits(long x) { return Countbits((ulong)x); }


        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an int vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Lzcnt(int x) { return Lzcnt((uint)x); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Lzcnt(Int2 x) { return Int2(Lzcnt(x.x), Lzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Lzcnt(Int3 x) { return Int3(Lzcnt(x.x), Lzcnt(x.y), Lzcnt(x.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Lzcnt(Int4 x) { return Int4(Lzcnt(x.x), Lzcnt(x.y), Lzcnt(x.z), Lzcnt(x.w)); }


        private static readonly int[] s_debruijn32 = new int[32]
        {
            0, 31, 9, 30, 3, 8, 13, 29, 2, 5, 7, 21, 12, 24, 28, 19,
            1, 10, 4, 14, 6, 22, 25, 20, 11, 15, 23, 26, 16, 27, 17, 18
        };

        /// <summary>Returns number of leading zeros in the binary representations of a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Lzcnt(uint x)
        {
            if (x == 0)
            {
                return 32;
            }

            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x++;

            return s_debruijn32[x * 0x076be629 >> 27];
        }


        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Lzcnt(UInt2 x) { return Int2(Lzcnt(x.x), Lzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Lzcnt(UInt3 x) { return Int3(Lzcnt(x.x), Lzcnt(x.y), Lzcnt(x.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Lzcnt(UInt4 x) { return Int4(Lzcnt(x.x), Lzcnt(x.y), Lzcnt(x.z), Lzcnt(x.w)); }


        /// <summary>Returns number of leading zeros in the binary representations of a long value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Lzcnt(long x) { return Lzcnt((ulong)x); }

        private static readonly int[] s_debruijn64 = new int[64] {
            63,  0, 58,  1, 59, 47, 53,  2,
            60, 39, 48, 27, 54, 33, 42,  3,
            61, 51, 37, 40, 49, 18, 28, 20,
            55, 30, 34, 11, 43, 14, 22,  4,
            62, 57, 46, 52, 38, 26, 32, 41,
            50, 36, 17, 19, 29, 10, 13, 21,
            56, 45, 25, 31, 35, 16,  9, 12,
            44, 24, 15,  8, 23,  7,  6,  5
        };

        /// <summary>Returns number of leading zeros in the binary representations of a ulong value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Lzcnt(ulong x)
        {
            if (x == 0)
            {
                return 64;
            }

            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            return s_debruijn64[(x - (x >> 1)) * 0x07EDD5E59A4E28C2u >> 58];
        }


        /// <summary>Returns number of trailing zeros in the binary representations of an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Tzcnt(int x) { return Tzcnt((uint)x); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Tzcnt(Int2 x) { return Int2(Tzcnt(x.x), Tzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Tzcnt(Int3 v) { return Int3(Tzcnt(v.x), Tzcnt(v.y), Tzcnt(v.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Tzcnt(Int4 v) { return Int4(Tzcnt(v.x), Tzcnt(v.y), Tzcnt(v.z), Tzcnt(v.w)); }



        private static readonly int[] s_debruijnCtz32 = new int[32]
        {
            31, 0, 27, 1, 28, 13, 23, 2, 29, 21, 19, 14, 24, 16, 3, 7,
            30, 26, 12, 22, 20, 18, 15, 6, 25, 11, 17, 5, 10, 4, 9, 8
        };

        /// <summary>Returns number of trailing zeros in the binary representations of a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Tzcnt(uint x)
        {
            return (x == 0 ? 1 : 0) + s_debruijnCtz32[((uint)((int)x & -(int)x) * 0x0EF96A62u) >> 27];
        }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Tzcnt(UInt2 x) { return Int2(Tzcnt(x.x), Tzcnt(x.y)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Tzcnt(UInt3 x) { return Int3(Tzcnt(x.x), Tzcnt(x.y), Tzcnt(x.z)); }

        /// <summary>Returns the componentwise number of leading zeros in the binary representations of an UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Tzcnt(UInt4 x) { return Int4(Tzcnt(x.x), Tzcnt(x.y), Tzcnt(x.z), Tzcnt(x.w)); }


        /// <summary>Returns number of trailing zeros in the binary representations of a long value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Tzcnt(long x) { return Tzcnt((ulong)x); }


        private static readonly int[] s_debruijnCtz64 = new int[64]
        {
            63, 0, 1, 52, 2, 6, 53, 26, 3, 37, 40, 7, 33, 54, 47, 27,
            61, 4, 38, 45, 43, 41, 21, 8, 23, 34, 58, 55, 48, 17, 28, 10,
            62, 51, 5, 25, 36, 39, 32, 46, 60, 44, 42, 20, 22, 57, 16, 9,
            50, 24, 35, 31, 59, 19, 56, 15, 49, 30, 18, 14, 29, 13, 12, 11
        };

        /// <summary>Returns number of trailing zeros in the binary representations of a ulong value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Tzcnt(ulong x)
        {
            return (x == 0 ? 1 : 0) + s_debruijnCtz64[((ulong)((long)x & -(long)x) * 0x045FBAC7992A70DAul) >> 58];
        }


        /// <summary>Returns the result of performing a reversal of the bit pattern of an int value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Reversebits(int x) { return (int)Reversebits((uint)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Reversebits(Int2 x) { return (Int2)Reversebits((UInt2)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Reversebits(Int3 x) { return (Int3)Reversebits((UInt3)x); }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Reversebits(Int4 x) { return (Int4)Reversebits((UInt4)x); }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Reversebits(uint x) {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Reversebits(UInt2 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Reversebits(UInt3 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }

        /// <summary>Returns the result of performing a componentwise reversal of the bit pattern of an UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Reversebits(UInt4 x)
        {
            x = ((x >> 1) & 0x55555555) | ((x & 0x55555555) << 1);
            x = ((x >> 2) & 0x33333333) | ((x & 0x33333333) << 2);
            x = ((x >> 4) & 0x0F0F0F0F) | ((x & 0x0F0F0F0F) << 4);
            x = ((x >> 8) & 0x00FF00FF) | ((x & 0x00FF00FF) << 8);
            return (x >> 16) | (x << 16);
        }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a long value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Reversebits(long x) { return (long)Reversebits((ulong)x); }


        /// <summary>Returns the result of performing a reversal of the bit pattern of a ulong value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Reversebits(ulong x)
        {
            x = ((x >> 1) & 0x5555555555555555ul) | ((x & 0x5555555555555555ul) << 1);
            x = ((x >> 2) & 0x3333333333333333ul) | ((x & 0x3333333333333333ul) << 2);
            x = ((x >> 4) & 0x0F0F0F0F0F0F0F0Ful) | ((x & 0x0F0F0F0F0F0F0F0Ful) << 4);
            x = ((x >> 8) & 0x00FF00FF00FF00FFul) | ((x & 0x00FF00FF00FF00FFul) << 8);
            x = ((x >> 16) & 0x0000FFFF0000FFFFul) | ((x & 0x0000FFFF0000FFFFul) << 16);
            return (x >> 32) | (x << 32);
        }


        /// <summary>Returns the result of rotating the bits of an int left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Rol(int x, int n) { return (int)Rol((uint)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int2 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Rol(Int2 x, int n) { return (Int2)Rol((UInt2)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int3 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Rol(Int3 x, int n) { return (Int3)Rol((UInt3)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int4 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Rol(Int4 x, int n) { return (Int4)Rol((UInt4)x, n); }


        /// <summary>Returns the result of rotating the bits of a uint left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Rol(uint x, int n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt2 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Rol(UInt2 x, int n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt3 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Rol(UInt3 x, int n) { return (x << n) | (x >> (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt4 left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Rol(UInt4 x, int n) { return (x << n) | (x >> (32 - n)); }


        /// <summary>Returns the result of rotating the bits of a long left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Rol(long x, int n) { return (long)Rol((ulong)x, n); }


        /// <summary>Returns the result of rotating the bits of a ulong left by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Rol(ulong x, int n) { return (x << n) | (x >> (64 - n)); }


        /// <summary>Returns the result of rotating the bits of an int right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ror(int x, int n) { return (int)Ror((uint)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int2 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Ror(Int2 x, int n) { return (Int2)Ror((UInt2)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int3 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Ror(Int3 x, int n) { return (Int3)Ror((UInt3)x, n); }

        /// <summary>Returns the componentwise result of rotating the bits of an Int4 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Ror(Int4 x, int n) { return (Int4)Ror((UInt4)x, n); }


        /// <summary>Returns the result of rotating the bits of a uint right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Ror(uint x, int n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt2 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Ror(UInt2 x, int n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt3 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Ror(UInt3 x, int n) { return (x >> n) | (x << (32 - n)); }

        /// <summary>Returns the componentwise result of rotating the bits of a UInt4 right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Ror(UInt4 x, int n) { return (x >> n) | (x << (32 - n)); }


        /// <summary>Returns the result of rotating the bits of a long right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Ror(long x, int n) { return (long)Ror((ulong)x, n); }


        /// <summary>Returns the result of rotating the bits of a ulong right by bits n.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Ror(ulong x, int n) { return (x >> n) | (x << (64 - n)); }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceilpow2(int x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Ceilpow2(Int2 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Ceilpow2(Int3 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Ceilpow2(Int4 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Ceilpow2(uint x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt2 Ceilpow2(UInt2 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt3 Ceilpow2(UInt3 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }

        /// <summary>Returns the result of a componentwise calculation of the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt4 Ceilpow2(UInt4 x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long Ceilpow2(long x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            return x + 1;
        }


        /// <summary>Returns the smallest power of two greater than or equal to the input.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong Ceilpow2(ulong x)
        {
            x -= 1;
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;
            x |= x >> 32;
            return x + 1;
        }

        /// <summary>
        /// Computes the ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// x must be greater than 0, otherwise the result is undefined.
        /// </remarks>
        /// <param name="x">Integer to be used as input.</param>
        /// <returns>Ceiling of the base-2 logarithm of x, as an integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceillog2(int x)
        {
            return 32 - Lzcnt((uint)x - 1);
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="Int2"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Ceillog2(Int2 x)
        {
            return new Int2(Ceillog2(x.x), Ceillog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="Int3"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Ceillog2(Int3 x)
        {
            return new Int3(Ceillog2(x.x), Ceillog2(x.y), Ceillog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="Int4"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Ceillog2(Int4 x)
        {
            return new Int4(Ceillog2(x.x), Ceillog2(x.y), Ceillog2(x.z), Ceillog2(x.w));
        }

        /// <summary>
        /// Computes the ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// x must be greater than 0, otherwise the result is undefined.
        /// </remarks>
        /// <param name="x">Unsigned integer to be used as input.</param>
        /// <returns>Ceiling of the base-2 logarithm of x, as an integer.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Ceillog2(uint x)
        {
            return 32 - Lzcnt(x - 1);
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="UInt2"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Ceillog2(UInt2 x)
        {
            return new Int2(Ceillog2(x.x), Ceillog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="UInt3"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Ceillog2(UInt3 x)
        {
            return new Int3(Ceillog2(x.x), Ceillog2(x.y), Ceillog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise ceiling of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>
        /// Components of x must be greater than 0, otherwise the result for that component is undefined.
        /// </remarks>
        /// <param name="x"><see cref="UInt4"/> to be used as input.</param>
        /// <returns>Componentwise ceiling of the base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Ceillog2(UInt4 x)
        {
            return new Int4(Ceillog2(x.x), Ceillog2(x.y), Ceillog2(x.z), Ceillog2(x.w));
        }

        /// <summary>
        /// Computes the floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>x must be greater than zero, otherwise the result is undefined.</remarks>
        /// <param name="x">Integer to be used as input.</param>
        /// <returns>Floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floorlog2(int x)
        {
            return 31 - Lzcnt((uint)x);
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="Int2"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Floorlog2(Int2 x)
        {
            return new Int2(Floorlog2(x.x), Floorlog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="Int3"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Floorlog2(Int3 x)
        {
            return new Int3(Floorlog2(x.x), Floorlog2(x.y), Floorlog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="Int4"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Floorlog2(Int4 x)
        {
            return new Int4(Floorlog2(x.x), Floorlog2(x.y), Floorlog2(x.z), Floorlog2(x.w));
        }

        /// <summary>
        /// Computes the floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>x must be greater than zero, otherwise the result is undefined.</remarks>
        /// <param name="x">Unsigned integer to be used as input.</param>
        /// <returns>Floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Floorlog2(uint x)
        {
            return 31 - Lzcnt(x);
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="UInt2"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int2 Floorlog2(UInt2 x)
        {
            return new Int2(Floorlog2(x.x), Floorlog2(x.y));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="UInt3"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int3 Floorlog2(UInt3 x)
        {
            return new Int3(Floorlog2(x.x), Floorlog2(x.y), Floorlog2(x.z));
        }

        /// <summary>
        /// Computes the componentwise floor of the base-2 logarithm of x.
        /// </summary>
        /// <remarks>Components of x must be greater than zero, otherwise the result of the component is undefined.</remarks>
        /// <param name="x"><see cref="UInt4"/> to be used as input.</param>
        /// <returns>Componentwise floor of base-2 logarithm of x.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int4 Floorlog2(UInt4 x)
        {
            return new Int4(Floorlog2(x.x), Floorlog2(x.y), Floorlog2(x.z), Floorlog2(x.w));
        }

        private const uint Deg2Rad = 0x3c8efa35;
        private const uint Rad2Deg = 0x42652ee1;

        /// <summary>Returns the result of converting a float value from degrees to radians.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Radians(SoftFloat x) { return x * SoftFloat.FromRaw(Deg2Rad); }

        /// <summary>Returns the result of a componentwise conversion of a Float2 vector from degrees to radians.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Radians(Float2 x) { return x * SoftFloat.FromRaw(Deg2Rad); }

        /// <summary>Returns the result of a componentwise conversion of a Float3 vector from degrees to radians.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Radians(Float3 x) { return x * SoftFloat.FromRaw(Deg2Rad); }

        /// <summary>Returns the result of a componentwise conversion of a Float4 vector from degrees to radians.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Radians(Float4 x) { return x * SoftFloat.FromRaw(Deg2Rad); }


        /// <summary>Returns the result of converting a double value from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Degrees(SoftFloat x) { return x * SoftFloat.FromRaw(Rad2Deg); }

        /// <summary>Returns the result of a componentwise conversion of a double2 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float2 Degrees(Float2 x) { return x * SoftFloat.FromRaw(Rad2Deg); }

        /// <summary>Returns the result of a componentwise conversion of a double3 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Degrees(Float3 x) { return x * SoftFloat.FromRaw(Rad2Deg); }

        /// <summary>Returns the result of a componentwise conversion of a double4 vector from radians to degrees.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float4 Degrees(Float4 x) { return x * SoftFloat.FromRaw(Rad2Deg); }


        /// <summary>Returns the minimum component of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmin(Int2 x) { return MIN(x.x, x.y); }

        /// <summary>Returns the minimum component of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmin(Int3 x) { return MIN(MIN(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmin(Int4 x) { return MIN(MIN(x.x, x.y), MIN(x.z, x.w)); }


        /// <summary>Returns the minimum component of a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmin(UInt2 x) { return MIN(x.x, x.y); }

        /// <summary>Returns the minimum component of a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmin(UInt3 x) { return MIN(MIN(x.x, x.y), x.z); }

        /// <summary>Returns the minimum component of a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmin(UInt4 x) { return MIN(MIN(x.x, x.y), MIN(x.z, x.w)); }


        /// <summary>Returns the minimum component of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmin(Float2 x) { return MIN(x.x, x.y); }

        /// <summary>Returns the minimum component of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmin(Float3 x) { return MIN(MIN(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmin(Float4 x) { return MIN(MIN(x.x, x.y), MIN(x.z, x.w)); }


        /// <summary>Returns the maximum component of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmax(Int2 x) { return MAX(x.x, x.y); }

        /// <summary>Returns the maximum component of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmax(Int3 x) { return MAX(MAX(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Cmax(Int4 x) { return MAX(MAX(x.x, x.y), MAX(x.z, x.w)); }


        /// <summary>Returns the maximum component of a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmax(UInt2 x) { return MAX(x.x, x.y); }

        /// <summary>Returns the maximum component of a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmax(UInt3 x) { return MAX(MAX(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Cmax(UInt4 x) { return MAX(MAX(x.x, x.y), MAX(x.z, x.w)); }


        /// <summary>Returns the maximum component of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmax(Float2 x) { return MAX(x.x, x.y); }

        /// <summary>Returns the maximum component of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmax(Float3 x) { return MAX(MAX(x.x, x.y), x.z); }

        /// <summary>Returns the maximum component of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Cmax(Float4 x) { return MAX(MAX(x.x, x.y), MAX(x.z, x.w)); }


        /// <summary>Returns the horizontal sum of components of an Int2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Csum(Int2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of an Int3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Csum(Int3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of an Int4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Csum(Int4 x) { return x.x + x.y + x.z + x.w; }


        /// <summary>Returns the horizontal sum of components of a UInt2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Csum(UInt2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of a UInt3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Csum(UInt3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of a UInt4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint Csum(UInt4 x) { return x.x + x.y + x.z + x.w; }


        /// <summary>Returns the horizontal sum of components of a Float2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Csum(Float2 x) { return x.x + x.y; }

        /// <summary>Returns the horizontal sum of components of a Float3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Csum(Float3 x) { return x.x + x.y + x.z; }

        /// <summary>Returns the horizontal sum of components of a Float4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat Csum(Float4 x) { return (x.x + x.y) + (x.z + x.w); }


        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform intersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that intersected.
        /// </remarks>
        /// <param name="output">Pointer to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index into output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int Compress(int* output, int index, Int4 val, bool4 mask)
        {
            if (mask.x)
                output[index++] = val.x;
            if (mask.y)
                output[index++] = val.y;
            if (mask.z)
                output[index++] = val.z;
            if (mask.w)
                output[index++] = val.w;

            return index;
        }

        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform intersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that intersected.
        /// </remarks>
        /// <param name="output">Pointer to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index into output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int Compress(uint* output, int index, UInt4 val, bool4 mask)
        {
            return Compress((int*)output, index, *(Int4*)&val, mask);
        }

        /// <summary>
        /// Packs components with an enabled mask to the left.
        /// </summary>
        /// <remarks>
        /// This function is also known as left packing. The effect of this function is to filter out components that
        /// are not enabled and leave an output buffer tightly packed with only the enabled components. A common use
        /// case is if you perform intersection tests on arrays of data in structure of arrays (SoA) form and need to
        /// produce an output array of the things that intersected.
        /// </remarks>
        /// <param name="output">Pointer to packed output array where enabled components should be stored to.</param>
        /// <param name="index">Index into output array where first enabled component should be stored to.</param>
        /// <param name="val">The value to to compress.</param>
        /// <param name="mask">Mask indicating which components are enabled.</param>
        /// <returns>Index to element after the last one stored.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe int Compress(float* output, int index, Float4 val, bool4 mask)
        {
            return Compress((int*)output, index, *(Int4*)&val, mask);
        }


        /// <summary>Returns a uint hash from a block of memory using the xxhash32 algorithm. Can only be used in an unsafe context.</summary>
        /// <param name="pBuffer">A pointer to the beginning of the data.</param>
        /// <param name="numBytes">Number of bytes to hash.</param>
        /// <param name="seed">Starting seed value.</param>
        public static unsafe uint Hash(void* pBuffer, int numBytes, uint seed = 0)
        {
            unchecked
            {
                const uint prime1 = 2654435761;
                const uint prime2 = 2246822519;
                const uint prime3 = 3266489917;
                const uint prime4 = 668265263;
                const uint prime5 = 374761393;

                UInt4* p = (UInt4*)pBuffer;
                uint hash = seed + prime5;
                if (numBytes >= 16)
                {
                    UInt4 state = new UInt4(prime1 + prime2, prime2, 0, (uint)-prime1) + seed;

                    int count = numBytes >> 4;
                    for (int i = 0; i < count; ++i)
                    {
                        state += *p++ * prime2;
                        state = (state << 13) | (state >> 19);
                        state *= prime1;
                    }

                    hash = Rol(state.x, 1) + Rol(state.y, 7) + Rol(state.z, 12) + Rol(state.w, 18);
                }

                hash += (uint)numBytes;

                uint* puint = (uint*)p;
                for (int i = 0; i < ((numBytes >> 2) & 3); ++i)
                {
                    hash += *puint++ * prime3;
                    hash = Rol(hash, 17) * prime4;
                }

                byte* pbyte = (byte*)puint;
                for (int i = 0; i < ((numBytes) & 3); ++i)
                {
                    hash += (*pbyte++) * prime5;
                    hash = Rol(hash, 11) * prime1;
                }

                hash ^= hash >> 15;
                hash *= prime2;
                hash ^= hash >> 13;
                hash *= prime3;
                hash ^= hash >> 16;

                return hash;
            }
        }

        /// <summary>
        /// Unity's up axis (0, 1, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-up.html](https://docs.unity3d.com/ScriptReference/Vector3-up.html)</remarks>
        /// <returns>The up axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Up() { return new Float3(SoftFloat.Zero, SoftFloat.One, SoftFloat.Zero); }  // for compatibility

        /// <summary>
        /// Unity's down axis (0, -1, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-down.html](https://docs.unity3d.com/ScriptReference/Vector3-down.html)</remarks>
        /// <returns>The down axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Down() { return new Float3(SoftFloat.Zero, -SoftFloat.One, SoftFloat.Zero); }

        /// <summary>
        /// Unity's forward axis (0, 0, 1).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-forward.html](https://docs.unity3d.com/ScriptReference/Vector3-forward.html)</remarks>
        /// <returns>The forward axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Forward() { return new Float3(SoftFloat.Zero, SoftFloat.Zero, SoftFloat.One); }

        /// <summary>
        /// Unity's back axis (0, 0, -1).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-back.html](https://docs.unity3d.com/ScriptReference/Vector3-back.html)</remarks>
        /// <returns>The back axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Back() { return new Float3(SoftFloat.Zero, SoftFloat.Zero, -SoftFloat.One); }

        /// <summary>
        /// Unity's left axis (-1, 0, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-left.html](https://docs.unity3d.com/ScriptReference/Vector3-left.html)</remarks>
        /// <returns>The left axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Left() { return new Float3(-SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero); }

        /// <summary>
        /// Unity's right axis (1, 0, 0).
        /// </summary>
        /// <remarks>Matches [https://docs.unity3d.com/ScriptReference/Vector3-right.html](https://docs.unity3d.com/ScriptReference/Vector3-right.html)</remarks>
        /// <returns>The right axis.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Float3 Right() { return new Float3(SoftFloat.One, SoftFloat.Zero, SoftFloat.Zero); }


        // Internal

        // SSE shuffles
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Float4 Unpacklo(Float4 a, Float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.RightX, ShuffleComponent.LeftY, ShuffleComponent.RightY);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Float4 Unpackhi(Float4 a, Float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftZ, ShuffleComponent.RightZ, ShuffleComponent.LeftW, ShuffleComponent.RightW);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Float4 Movelh(Float4 a, Float4 b)
        {
            return shuffle(a, b, ShuffleComponent.LeftX, ShuffleComponent.LeftY, ShuffleComponent.RightX, ShuffleComponent.RightY);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static Float4 Movehl(Float4 a, Float4 b)
        {
            return shuffle(b, a, ShuffleComponent.LeftZ, ShuffleComponent.LeftW, ShuffleComponent.RightZ, ShuffleComponent.RightW);
        }
    }
}
