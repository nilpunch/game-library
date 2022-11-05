﻿// mostly from https://github.com/CodesInChaos/SoftFloat

// Copyright (c) 2011 CodesInChaos
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software
// and associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all copies
// or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
// The MIT License (MIT) - http://www.opensource.org/licenses/mit-license.php
// If you need a different license please contact me

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;


namespace GameLibrary.Mathematics
{
	// Internal representation is identical to IEEE binary32 floating point numbers
	[DebuggerDisplay("{ToStringInv()}")]
	public readonly struct SoftFloat : IEquatable<SoftFloat>, IComparable<SoftFloat>, IComparable, IFormattable
	{
        private const uint SignMask = 0x80000000;
        private const int MantissaBits = 23;
        private const int ExponentBits = 8;
        private const int ExponentBias = 127;

        private const uint RawZero = 0;
        private const uint RawNaN = 0xFFC00000; // Same as float.NaN
        private const uint RawPositiveInfinity = 0x7F800000;
        private const uint RawNegativeInfinity = RawPositiveInfinity ^ SignMask;
        private const uint RawOne = 0x3F800000;
        private const uint RawMinusOne = RawOne ^ SignMask;
        private const uint RawMaxValue = 0x7F7FFFFF;
        private const uint RawMinValue = 0x7F7FFFFF ^ SignMask;
        private const uint RawEpsilon = 0x00000001;
        private const uint RawLog2OfE = 0;

        private static readonly sbyte[] s_msb = new sbyte[256]
        {
            -1, 0, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4,
            5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5,
            6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
            6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6,
            7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
            7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
            7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
            7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7
        };

        private static readonly int[] s_normalizeAmounts = new int[]
        {
            0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 8, 8, 8, 8, 8, 8, 8, 16, 16, 16, 16, 16, 16, 16, 16, 24, 24, 24, 24, 24, 24,
            24
        };

        private static readonly int[] s_debruijn32 = new int[64]
        {
            32, 8, 17, -1, -1, 14, -1, -1, -1, 20, -1, -1, -1, 28, -1, 18,
            -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, -1, 0, 26, 25, 24,
            4, 11, 23, 31, 3, 7, 10, 16, 22, 30, -1, -1, 2, 6, 13, 9,
            -1, 15, -1, 21, -1, 29, 19, -1, -1, -1, -1, -1, 1, 27, 5, 12
        };

        /// <summary>
		/// Raw byte representation of an signed float number.
		/// </summary>
		private readonly uint _rawValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		private SoftFloat(uint raw)
		{
			_rawValue = raw;
		}

        public static SoftFloat Zero => new SoftFloat(RawZero);

        public static SoftFloat PositiveInfinity => new SoftFloat(RawPositiveInfinity);

        public static SoftFloat NegativeInfinity => new SoftFloat(RawNegativeInfinity);

        public static SoftFloat NaN => new SoftFloat(RawNaN);

        public static SoftFloat One => new SoftFloat(RawOne);

        public static SoftFloat MinusOne => new SoftFloat(RawMinusOne);

        public static SoftFloat MaxValue => new SoftFloat(RawMaxValue);

        public static SoftFloat MinValue => new SoftFloat(RawMinValue);

        public static SoftFloat Epsilon => new SoftFloat(RawEpsilon);

        public uint RawValue => _rawValue;

        private uint RawMantissa
		{
			get { return _rawValue & 0x7FFFFF; }
		}

        private int Mantissa
		{
			get
			{
				if (RawExponent != 0)
				{
					uint sign = (uint)((int)_rawValue >> 31);
					return (int)(((RawMantissa | 0x800000) ^ sign) - sign);
				}
				else
				{
					uint sign = (uint)((int)_rawValue >> 31);
					return (int)(((RawMantissa) ^ sign) - sign);
				}
			}
		}

        private sbyte Exponent => (sbyte)(RawExponent - ExponentBias);

        private byte RawExponent => (byte)(_rawValue >> MantissaBits);


        public string ToString(string format, IFormatProvider formatProvider) =>
            ((float)this).ToString(format, formatProvider);


        public string ToString(string format) => ((float)this).ToString(format);

        public string ToString(IFormatProvider provider) => ((float)this).ToString(provider);

        public override string ToString() => ((float)this).ToString();

        public string ToStringInv() => ((float)this).ToString(System.Globalization.CultureInfo.InvariantCulture);

        public bool Equals(SoftFloat other)
        {
            if (RawExponent != 255)
            {
                // 0 == -0
                return (_rawValue == other._rawValue) ||
                       ((_rawValue & 0x7FFFFFFF) == 0) && ((other._rawValue & 0x7FFFFFFF) == 0);
            }

            if (RawMantissa == 0)
            {
                // Infinities
                return _rawValue == other._rawValue;
            }

            // NaNs are equal for `Equals` (as opposed to the == operator)
            return other.RawMantissa != 0;
        }

        public override bool Equals(object obj) => obj != null && GetType() == obj.GetType() && Equals((SoftFloat)obj);

        public int CompareTo(SoftFloat other)
        {
            if (IsNaN(this) && IsNaN(other))
            {
                return 0;
            }

            uint sign1 = (uint)((int)_rawValue >> 31);
            int val1 = (int)(((_rawValue) ^ (sign1 & 0x7FFFFFFF)) - sign1);

            uint sign2 = (uint)((int)other._rawValue >> 31);
            int val2 = (int)(((other._rawValue) ^ (sign2 & 0x7FFFFFFF)) - sign2);
            return val1.CompareTo(val2);
        }

        public int CompareTo(object obj) => obj is SoftFloat f ? CompareTo(f) : throw new ArgumentException("obj");

        public override int GetHashCode()
        {
            if (_rawValue == SignMask)
            {
                // +0 equals -0
                return 0;
            }

            if (!IsNaN(this))
            {
                return (int)_rawValue;
            }

            // All NaNs are equal
            return unchecked((int)RawNaN);
        }

        /// <summary>
		/// Creates an soft float number from its parts: sign, exponent, mantissa.
		/// </summary>
		/// <param name="sign">Sign of the number: false = the number is positive, true = the number is negative.</param>
		/// <param name="exponent">Exponent of the number.</param>
		/// <param name="mantissa">Mantissa (significand) of the number.</param>
		/// <returns></returns>
		public static SoftFloat FromParts(bool sign, uint exponent, uint mantissa)
		{
			return FromRaw((sign ? SignMask : 0) | ((exponent & 0xff) << MantissaBits) |
			               (mantissa & ((1 << MantissaBits) - 1)));
		}

        /// <summary>
        /// Creates an soft float number from its raw byte representation.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SoftFloat FromRaw(uint raw)
        {
            return new SoftFloat(raw);
        }

        /// <summary>
		/// Creates an soft float number from a float value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator SoftFloat(float f)
		{
			uint raw = ReinterpretFloatToInt32(f);
			return new SoftFloat(raw);
		}

        /// <summary>
		/// Converts an soft float number to a float value.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator float(SoftFloat f)
		{
			uint raw = f._rawValue;
			return ReinterpretIntToFloat32(raw);
		}

        /// <summary>
		/// Creates an soft float number from an integer.
		/// </summary>
		public static explicit operator SoftFloat(int value)
		{
			if (value == 0)
			{
				return Zero;
			}

			if (value == int.MinValue)
			{
				// special case
				return FromRaw(0xcf000000);
			}

			bool negative = value < 0;
			int u = Math.Abs(value);

			int shifts;

			int lzcnt = LeadingZeroCount(u);
			if (lzcnt < 8)
			{
				int count = 8 - lzcnt;
				u >>= count;
				shifts = -count;
			}
			else
			{
				int count = lzcnt - 8;
				u <<= count;
				shifts = count;
			}

			uint exponent = (uint)(ExponentBias + MantissaBits - shifts);
			return FromParts(negative, exponent, (uint)u);
		}

        /// <summary>
		/// Converts an soft float number to an integer.
		/// </summary>
		public static explicit operator int(SoftFloat f)
		{
			if (f.Exponent < 0)
			{
				return 0;
			}

			int shift = MantissaBits - f.Exponent;
			var mantissa = (int)(f.RawMantissa | (1 << MantissaBits));
			int value = shift < 0 ? mantissa << -shift : mantissa >> shift;
			return IsPositive(f) ? value : -value;
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SoftFloat operator -(SoftFloat f) => new SoftFloat(f._rawValue ^ 0x80000000);

        public static SoftFloat operator +(SoftFloat f1, SoftFloat f2)
		{
			return f1.RawExponent - f2.RawExponent >= 0 ? InternalAdd(f1, f2) : InternalAdd(f2, f1);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SoftFloat operator -(SoftFloat f1, SoftFloat f2) => f1 + (-f2);

        public static SoftFloat operator *(SoftFloat f1, SoftFloat f2)
		{
			int man1;
			int rawExp1 = f1.RawExponent;
			uint sign1;
			uint sign2;
			if (rawExp1 == 0)
			{
				// SubNorm
				sign1 = (uint)((int)f1._rawValue >> 31);
				int rawMan1 = (int)f1.RawMantissa;
				if (rawMan1 == 0)
                {
                    if (IsFinite(f2))
					{
						// 0 * f2
						return new SoftFloat((f1._rawValue ^ f2._rawValue) & SignMask);
					}

                    // 0 * Infinity
                    // 0 * NaN
                    return NaN;
                }

				int shift = LeadingZeroCount(rawMan1 & 0x00ffffff) - 8;
				rawMan1 <<= shift;
				rawExp1 = 1 - shift;

				//Debug.Assert(rawMan1 >> MantissaBits == 1);
				man1 = (int)((rawMan1 ^ sign1) - sign1);
			}
			else if (rawExp1 != 255)
			{
				// Norm
				sign1 = (uint)((int)f1._rawValue >> 31);
				man1 = (int)(((f1.RawMantissa | 0x800000) ^ sign1) - sign1);
			}
			else
            {
                // Non finite
				if (f1._rawValue == RawPositiveInfinity)
				{
					if (IsZero(f2))
					{
						// Infinity * 0
						return NaN;
					}

					if (IsNaN(f2))
					{
						// Infinity * NaN
						return NaN;
					}

					if ((int)f2._rawValue >= 0)
					{
						// Infinity * f
						return PositiveInfinity;
					}

                    // Infinity * -f
                    return NegativeInfinity;
                }

                if (f1._rawValue == RawNegativeInfinity)
                {
                    if (IsZero(f2) || IsNaN(f2))
                    {
                        // -Infinity * 0
                        // -Infinity * NaN
                        return NaN;
                    }

                    if ((int)f2._rawValue < 0)
                    {
                        // -Infinity * -f
                        return PositiveInfinity;
                    }

                    // -Infinity * f
                    return NegativeInfinity;
                }
                return f1;
            }

			int man2;
			int rawExp2 = f2.RawExponent;
			if (rawExp2 == 0)
			{
				// SubNorm
				sign2 = (uint)((int)f2._rawValue >> 31);
				int rawMan2 = (int)f2.RawMantissa;
				if (rawMan2 == 0)
                {
                    if (IsFinite(f1))
					{
						// f1 * 0
						return new SoftFloat((f1._rawValue ^ f2._rawValue) & SignMask);
					}

                    // Infinity * 0
                    // NaN * 0
                    return NaN;
                }

				int shift = LeadingZeroCount(rawMan2 & 0x00ffffff) - 8;
				rawMan2 <<= shift;
				rawExp2 = 1 - shift;

				//Debug.Assert(rawMan2 >> MantissaBits == 1);
				man2 = (int)((rawMan2 ^ sign2) - sign2);
			}
			else if (rawExp2 != 255)
			{
				// Norm
				sign2 = (uint)((int)f2._rawValue >> 31);
				man2 = (int)(((f2.RawMantissa | 0x800000) ^ sign2) - sign2);
			}
			else
            {
                // Non finite
				if (f2._rawValue == RawPositiveInfinity)
				{
					if (IsZero(f1))
					{
						// 0 * Infinity
						return NaN;
					}

					if ((int)f1._rawValue >= 0)
					{
						// f * Infinity
						return PositiveInfinity;
					}

                    // -f * Infinity
                    return NegativeInfinity;
                }

                if (f2._rawValue == RawNegativeInfinity)
                {
                    if (IsZero(f1))
                    {
                        // 0 * -Infinity
                        return NaN;
                    }

                    if ((int)f1._rawValue < 0)
                    {
                        // -f * -Infinity
                        return PositiveInfinity;
                    }

                    // f * -Infinity
                    return NegativeInfinity;
                }
                return f2;
            }

			long longMan = (long)man1 * (long)man2;
			int man = (int)(longMan >> MantissaBits);
            uint absMan = (uint)Math.Abs(man);
			int rawExp = rawExp1 + rawExp2 - ExponentBias;
			uint sign = (uint)man & 0x80000000;
			if ((absMan & 0x1000000) != 0)
			{
				absMan >>= 1;
				rawExp++;
			}

			if (rawExp >= 255)
			{
				// Overflow
				return new SoftFloat(sign ^ RawPositiveInfinity);
			}

			if (rawExp <= 0)
			{
				// Subnorms/Underflow
				if (rawExp <= -24)
				{
					return new SoftFloat(sign);
				}

				absMan >>= -rawExp + 1;
				rawExp = 0;
			}

			uint raw = sign | (uint)rawExp << MantissaBits | absMan & 0x7FFFFF;
			return new SoftFloat(raw);
		}

        public static SoftFloat operator /(SoftFloat f1, SoftFloat f2)
		{
			if (IsNaN(f1) || IsNaN(f2))
			{
				return NaN;
			}

			int man1;
			int rawExp1 = f1.RawExponent;
			uint sign1;
			uint sign2;
			if (rawExp1 == 0)
			{
				// SubNorm
				sign1 = (uint)((int)f1._rawValue >> 31);
				int rawMan1 = (int)f1.RawMantissa;
				if (rawMan1 == 0)
                {
                    if (IsZero(f2))
					{
						// 0 / 0
						return NaN;
					}

                    // 0 / f
                    return new SoftFloat((f1._rawValue ^ f2._rawValue) & SignMask);
                }

				int shift = LeadingZeroCount(rawMan1 & 0x00ffffff) - 8;
				rawMan1 <<= shift;
				rawExp1 = 1 - shift;

				//Debug.Assert(rawMan1 >> MantissaBits == 1);
				man1 = (int)((rawMan1 ^ sign1) - sign1);
			}
			else if (rawExp1 != 255)
			{
				// Norm
				sign1 = (uint)((int)f1._rawValue >> 31);
				man1 = (int)(((f1.RawMantissa | 0x800000) ^ sign1) - sign1);
			}
			else
            {
                // Non finite
				if (f1._rawValue == RawPositiveInfinity)
				{
					if (IsZero(f2))
					{
						// Infinity / 0
						return PositiveInfinity;
					}

					// +-Infinity / Infinity
					return NaN;
				}

                if (f1._rawValue == RawNegativeInfinity)
                {
                    if (IsZero(f2))
                    {
                        // -Infinity / 0
                        return NegativeInfinity;
                    }

                    // -Infinity / +-Infinity
                    return NaN;
                }
                // NaN
                return f1;
            }

			int man2;
			int rawExp2 = f2.RawExponent;
			if (rawExp2 == 0)
			{
				// SubNorm
				sign2 = (uint)((int)f2._rawValue >> 31);
				int rawMan2 = (int)f2.RawMantissa;
				if (rawMan2 == 0)
				{
					// f / 0
					return new SoftFloat(((f1._rawValue ^ f2._rawValue) & SignMask) | RawPositiveInfinity);
				}

				int shift = LeadingZeroCount(rawMan2 & 0x00ffffff) - 8;
				rawMan2 <<= shift;
				rawExp2 = 1 - shift;

				//Debug.Assert(rawMan2 >> MantissaBits == 1);
				man2 = (int)((rawMan2 ^ sign2) - sign2);
			}
			else if (rawExp2 != 255)
			{
				// Norm
				sign2 = (uint)((int)f2._rawValue >> 31);
				man2 = (int)(((f2.RawMantissa | 0x800000) ^ sign2) - sign2);
			}
			else
            {
                // Non finite
				if (f2._rawValue == RawPositiveInfinity)
				{
					if (IsZero(f1))
					{
						// 0 / Infinity
						return Zero;
					}

					if ((int)f1._rawValue >= 0)
					{
						// f / Infinity
						return PositiveInfinity;
					}

                    // -f / Infinity
                    return NegativeInfinity;
                }

                if (f2._rawValue == RawNegativeInfinity)
                {
                    if (IsZero(f1))
                    {
                        // 0 / -Infinity
                        return new SoftFloat(SignMask);
                    }

                    if ((int)f1._rawValue < 0)
                    {
                        // -f / -Infinity
                        return PositiveInfinity;
                    }

                    // f / -Infinity
                    return NegativeInfinity;
                }
                // NaN
                return f2;
            }

			long longMan = ((long)man1 << MantissaBits) / (long)man2;
			int man = (int)longMan;
			//Debug.Assert(man != 0);
			uint absMan = (uint)Math.Abs(man);
			int rawExp = rawExp1 - rawExp2 + ExponentBias;
			uint sign = (uint)man & 0x80000000;

			if ((absMan & 0x800000) == 0)
			{
				absMan <<= 1;
				--rawExp;
			}

			//Debug.Assert(absMan >> MantissaBits == 1);
			if (rawExp >= 255)
			{
				// Overflow
				return new SoftFloat(sign ^ RawPositiveInfinity);
			}

			if (rawExp <= 0)
			{
				// Subnorms/Underflow
				if (rawExp <= -24)
				{
					return new SoftFloat(sign);
				}

				absMan >>= -rawExp + 1;
				rawExp = 0;
			}

			uint raw = sign | (uint)rawExp << MantissaBits | absMan & 0x7FFFFF;
			return new SoftFloat(raw);
		}

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SoftFloat operator %(SoftFloat f1, SoftFloat f2) => SoftMath.Fmod(f1, f2);

        public static bool operator ==(SoftFloat f1, SoftFloat f2)
        {
            if (f1.RawExponent != 255)
			{
				// 0 == -0
				return (f1._rawValue == f2._rawValue) ||
				       ((f1._rawValue & 0x7FFFFFFF) == 0) && ((f2._rawValue & 0x7FFFFFFF) == 0);
			}

            if (f1.RawMantissa == 0)
            {
                // Infinities
                return f1._rawValue == f2._rawValue;
            }

            //NaNs
            return false;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator !=(SoftFloat f1, SoftFloat f2) => !(f1 == f2);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <(SoftFloat f1, SoftFloat f2) => !IsNaN(f1) && !IsNaN(f2) && f1.CompareTo(f2) < 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >(SoftFloat f1, SoftFloat f2) => !IsNaN(f1) && !IsNaN(f2) && f1.CompareTo(f2) > 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator <=(SoftFloat f1, SoftFloat f2) => !IsNaN(f1) && !IsNaN(f2) && f1.CompareTo(f2) <= 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator >=(SoftFloat f1, SoftFloat f2) => !IsNaN(f1) && !IsNaN(f2) && f1.CompareTo(f2) >= 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInfinity(SoftFloat softFloat) => (softFloat._rawValue & 0x7FFFFFFF) == 0x7F800000;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegativeInfinity(SoftFloat softFloat) => softFloat._rawValue == RawNegativeInfinity;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositiveInfinity(SoftFloat softFloat) => softFloat._rawValue == RawPositiveInfinity;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNaN(SoftFloat softFloat) => (softFloat.RawExponent == 255) && !IsInfinity(softFloat);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsFinite(SoftFloat softFloat) => softFloat.RawExponent != 255;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsZero(SoftFloat softFloat) => (softFloat._rawValue & 0x7FFFFFFF) == 0;

        /// <summary>
        /// Returns true if the soft float number has a positive sign.
        /// </summary>
        /// <param name="softFloat"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsPositive(SoftFloat softFloat) => (softFloat._rawValue & SignMask) == 0;

        /// <summary>
        /// Returns true if the soft float number has a negative sign.
        /// </summary>
        /// <param name="softFloat"></param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNegative(SoftFloat softFloat) => (softFloat._rawValue & SignMask) != 0;

        private static SoftFloat InternalAdd(SoftFloat f1, SoftFloat f2)
        {
            byte rawExp1 = f1.RawExponent;
            byte rawExp2 = f2.RawExponent;
            int deltaExp = rawExp1 - rawExp2;

            if (rawExp1 != 255)
            {
                //Finite
                if (deltaExp > 25)
                {
                    return f1;
                }

                int man1;
                int man2;
                if (rawExp2 != 0)
                {
                    // man1 = f1.Mantissa
                    // http://graphics.stanford.edu/~seander/bithacks.html#ConditionalNegate
                    uint sign1 = (uint)((int)f1._rawValue >> 31);
                    man1 = (int)(((f1.RawMantissa | 0x800000) ^ sign1) - sign1);
                    // man2 = f2.Mantissa
                    uint sign2 = (uint)((int)f2._rawValue >> 31);
                    man2 = (int)(((f2.RawMantissa | 0x800000) ^ sign2) - sign2);
                }
                else
                {
                    // Subnorm
                    // man2 = f2.Mantissa
                    uint sign2 = (uint)((int)f2._rawValue >> 31);
                    man2 = (int)((f2.RawMantissa ^ sign2) - sign2);

                    man1 = f1.Mantissa;

                    rawExp2 = 1;
                    if (rawExp1 == 0)
                    {
                        rawExp1 = 1;
                    }

                    deltaExp = rawExp1 - rawExp2;
                }

                int man = (man1 << 6) + ((man2 << 6) >> deltaExp);
                int absMan = Math.Abs(man);
                if (absMan == 0)
                {
                    return Zero;
                }

                int rawExp = rawExp1 - 6;

                int amount = s_normalizeAmounts[LeadingZeroCount(absMan)];
                rawExp -= amount;
                absMan <<= amount;

                int msbIndex = BitScanReverse8(absMan >> MantissaBits);
                rawExp += msbIndex;
                absMan >>= msbIndex;
                if ((uint)(rawExp - 1) < 254)
                {
                    uint raw = (uint)man & 0x80000000 | (uint)rawExp << MantissaBits | ((uint)absMan & 0x7FFFFF);
                    return new SoftFloat(raw);
                }

                if (rawExp >= 255)
                {
                    //Overflow
                    return man >= 0 ? PositiveInfinity : NegativeInfinity;
                }

                if (rawExp >= -24)
                {
                    uint raw = (uint)man & 0x80000000 | (uint)(absMan >> (-rawExp + 1));
                    return new SoftFloat(raw);
                }

                return Zero;
            }
            // Special

            if (rawExp2 != 255)
            {
                // f1 is NaN, +Inf, -Inf and f2 is finite
                return f1;
            }

            // Both not finite
            return f1._rawValue == f2._rawValue ? f1 : NaN;
        }

        /// <summary>
        /// Returns the leading zero count of the given 32-bit integer.
        /// </summary>
        private static int LeadingZeroCount(int x)
        {
            x |= x >> 1;
            x |= x >> 2;
            x |= x >> 4;
            x |= x >> 8;
            x |= x >> 16;

            return s_debruijn32[(uint)x * 0x8c0b2891u >> 26];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static int BitScanReverse8(int b) => s_msb[b];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe uint ReinterpretFloatToInt32(float f) => *(uint*)&f;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static unsafe float ReinterpretIntToFloat32(uint i) => *(float*)&i;
    }
}
