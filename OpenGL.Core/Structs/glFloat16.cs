#region Copyright and License
// Copyright (c) 2013-2014 The Khronos Group Inc.
// Copyright (c) of C# port 2014 by Shinta <shintadono@googlemail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and/or associated documentation files (the
// "Materials"), to deal in the Materials without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Materials, and to
// permit persons to whom the Materials are furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Materials.
//
// THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
// CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
#endregion

using System;

namespace OpenGL.Core
{
	/// <summary>
	/// Represents a 16-bit floating-point number.
	/// </summary>
	public struct glFloat16
	{
		/// <summary>
		/// Memory representation of the 16-bit floating-point number.
		/// </summary>
		public ushort Value;

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		public glFloat16(glFloat16 value) { Value=value.Value; }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of <see cref="glUFloat10"/>.</param>
		public glFloat16(glUFloat10 value)
		{
			int exp=value.Value&glUFloat10.ExponentMask;
			int man=value.Value&glUFloat10.MantissaMask;

			if(exp==glUFloat10.ExponentMask)
			{
				if(man==0) Value=PositiveInfinity;
				else Value=NaN;
				return;
			}

			Value=(ushort)((value.Value<<5)&FillMask);
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of <see cref="glUFloat11"/>.</param>
		public glFloat16(glUFloat11 value)
		{
			int exp=value.Value&glUFloat11.ExponentMask;
			int man=value.Value&glUFloat11.MantissaMask;

			if(exp==glUFloat11.ExponentMask)
			{
				if(man==0) Value=PositiveInfinity;
				else Value=NaN;
				return;
			}

			Value=(ushort)((value.Value<<4)&FillMask);
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>float</b> value.</param>
		public glFloat16(float value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			// Get bits as uint
			SingleUInt32Union union=new SingleUInt32Union();
			union.single=value;
			uint ivalue=union.uint32;

			// Signed zero?
			if((ivalue&0x7FFFFFFF)==0)
			{
				Value=(ushort)(ivalue>>16); // Set signed zero
				return;
			}

			uint maskedSign=ivalue&0x80000000;
			uint maskedExpo=ivalue&0x7F800000;

			// Denormalized number? (this would underflow anyway)
			if(maskedExpo==0)
			{
				Value=(ushort)(maskedSign>>16); // Set signed zero
				return;
			}

			uint maskedMant=ivalue&0x007FFFFF;

			// Infinity or NaN? (all exponent bits set)
			if(maskedExpo==0x7F800000)
			{
				// NaN?
				if(maskedMant!=0) Value=NaN;
				else Value=(ushort)((maskedSign>>16)|ExponentMask); // Set signed infinity
				return;
			}

			// Normalized number
			Value=(ushort)(maskedSign>>16);
			int iExponent=((int)maskedExpo>>23)-127+15; // Convert exponent from float range to 16-bit float range

			// Overflow? (exponent out of range)
			if(iExponent>=0x1F)
			{
				Value|=ExponentMask; // Set signed infinity
				return;
			}

			// Underflow? (exponent out of range)
			if(iExponent<=0)
			{
				// No mantissa bits left
				if((14-iExponent)>24) return;

				// Make denormalized number
				maskedMant|=0x00800000; // Add the leading one digit

				ushort denormMantissa=(ushort)(maskedMant>>(14-iExponent));

				// Check for rounding
				if(((maskedMant>>(13-iExponent))&1)!=0) denormMantissa++;

				Value|=denormMantissa;
				return;
			}

			Value|=(ushort)(iExponent<<10);
			Value|=(ushort)(maskedMant>>13);

			// Check for rounding
			if((maskedMant&0x00001000)!=0) Value++;
#else
			if(float.IsNaN(value))
			{
				Value=NaN;
				return;
			}

			if(float.IsPositiveInfinity(value))
			{
				Value=PositiveInfinity;
				return;
			}

			if(float.IsNegativeInfinity(value))
			{
				Value=NegativeInfinity;
				return;
			}

			if(value<MinValue) value=MinValue;
			else if(value>MaxValue) value=MaxValue;

			Value=0;
			if(value<0)
			{
				value=Math.Abs(value);
				Value=SignMask;
			}

			int exp=(int)(Math.Log(value, 2)+15);

			if(exp<=0) Value|=(ushort)(value*(1<<24)+0.5f);
			else if(exp>25) Value|=(ushort)((exp<<10)+(int)(value/(1<<(exp-25))-1023.5f));
			else Value|=(ushort)((exp<<10)+(int)(value*(1<<(25-exp))-1023.5f));
#endif
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>double</b> value.</param>
		public glFloat16(double value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			// Get bits as uint
			uint ivalue=(uint)(BitConverter.DoubleToInt64Bits(value)>>32);

			// Signed zero?
			if((ivalue&0x7FFFFFFF)==0)
			{
				Value=(ushort)(ivalue>>16); // Set signed zero
				return;
			}

			uint maskedSign=ivalue&0x80000000;
			uint maskedExpo=ivalue&0x7FF00000;

			// Denormalized number? (this would underflow anyway)
			if(maskedExpo==0)
			{
				Value=(ushort)(maskedSign>>16); // Set signed zero
				return;
			}

			uint maskedMant=ivalue&0x000FFFFF;

			// Infinity or NaN? (all exponent bits set)
			if(maskedExpo==0x7FF00000)
			{
				// NaN?
				if(maskedMant!=0) Value=NaN;
				else Value=(ushort)((maskedSign>>16)|ExponentMask); // Set signed infinity
				return;
			}

			// Normalized number
			Value=(ushort)(maskedSign>>16);
			int iExponent=((int)maskedExpo>>20)-1023+15; // Convert exponent from double range to 16-bit float range

			// Overflow? (exponent out of range)
			if(iExponent>=0x1F)
			{
				Value|=ExponentMask; // Set signed infinity
				return;
			}

			// Underflow? (exponent out of range)
			if(iExponent<=0)
			{
				// No mantissa bits left
				if((11-iExponent)>21) return;

				// Make denormalized number
				maskedMant|=0x00100000; // Add the leading one digit

				ushort denormMantissa=(ushort)(maskedMant>>(11-iExponent));

				// Check for rounding
				if(((maskedMant>>(10-iExponent))&1)!=0) denormMantissa++;

				Value|=denormMantissa;
				return;
			}

			Value|=(ushort)(iExponent<<10);
			Value|=(ushort)(maskedMant>>10);

			// Check for rounding
			if((maskedMant&0x00000200)!=0) Value++;
#else
			if(double.IsNaN(value))
			{
				Value=NaN;
				return;
			}

			if(double.IsPositiveInfinity(value))
			{
				Value=PositiveInfinity;
				return;
			}

			if(double.IsNegativeInfinity(value))
			{
				Value=NegativeInfinity;
				return;
			}

			if(value<MinValue) value=MinValue;
			else if(value>MaxValue) value=MaxValue;

			Value=0;
			if(value<0)
			{
				value=Math.Abs(value);
				Value=SignMask;
			}

			int exp=(int)(Math.Log(value, 2)+15);

			if(exp<=0) Value|=(ushort)(value*(1<<24)+0.5);
			else if(exp>25) Value|=(ushort)((exp<<10)+(int)(value/(1<<(exp-25))-1023.5));
			else Value|=(ushort)((exp<<10)+(int)(value*(1<<(25-exp))-1023.5));
#endif
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>byte</b> value.</param>
		public glFloat16(byte value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>sbyte</b> value.</param>
		public glFloat16(sbyte value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>short</b> value.</param>
		public glFloat16(short value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>ushort</b> value.</param>
		public glFloat16(ushort value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>int</b> value.</param>
		public glFloat16(int value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>uint</b> value.</param>
		public glFloat16(uint value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>long</b> value.</param>
		public glFloat16(long value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>ulong</b> value.</param>
		public glFloat16(ulong value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>decimal</b> value.</param>
		public glFloat16(decimal value) : this((double)value) { }

		/// <summary>
		/// Represents the smallest possible value this class can hold. This field is constant.
		/// </summary>
		public const float MinValue=-65504;

		/// <summary>
		/// Represents the largest possible value this class can hold. This field is constant.
		/// </summary>
		public const float MaxValue=65504;

		/// <summary>
		/// Represents the smallest positive value that is greater than zero. This field is constant. (2^-24)
		/// </summary>
		public const float Epsilon=0.000000059604644775390625f;

		/// <summary>
		/// Represents a value that is not a number (<b>NaN</b>). This field is constant.
		/// (Exponent, mantissa and sign all bits set to 1)
		/// </summary>
		public const ushort NaN=FillMask;

		/// <summary>
		/// Represents positive infinity. This field is constant.
		/// (Exponent all bits set to 1, mantissa all bits set to 0 and sign set to 0)
		/// </summary>
		public const ushort PositiveInfinity=ExponentMask;

		/// <summary>
		/// Represents negative infinity. This field is constant.
		/// (Exponent all bits set to 1, mantissa all bits set to 0 and sign set to 1)
		/// </summary>
		public const ushort NegativeInfinity=ExponentMask|SignMask;

		/// <summary>
		/// Represents the smallest positive value that is greater than zero as the memory representation. This field is constant.
		/// (Exponent all bits set to 0 and mantissa only the least significant bit set to 1)
		/// </summary>
		public const ushort EpsilonUShort=1;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the value. This field is constant.
		/// </summary>
		public const ushort FillMask=0xFFFF;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the exponent of the value. This field is constant.
		/// </summary>
		public const ushort ExponentMask=0x7C00;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the mantissa of the value. This field is constant.
		/// </summary>
		public const ushort MantissaMask=0x03FF;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the sign of the value. This field is constant.
		/// </summary>
		public const ushort SignMask=0x8000;

		/// <summary>
		/// Returns a value that indicates whether the specified value is not a number (<see cref="NaN"/>).
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="NaN"/>; otherwise, <b>false</b>.</returns>
		public static bool IsNaN(glFloat16 value)
		{
			if((value.Value&ExponentMask)!=ExponentMask) return false;
			return (value.Value&MantissaMask)!=0;
		}

		/// <summary>
		/// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="PositiveInfinity"/> or <see cref="NegativeInfinity"/>; otherwise, <b>false</b>.</returns>
		public static bool IsInfinity(glFloat16 value)
		{
			return (value.Value&(ExponentMask|MantissaMask))==ExponentMask;
		}

		/// <summary>
		/// Returns a value indicating whether the specified number evaluates to negative infinity.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="NegativeInfinity"/>; otherwise, <b>false</b>.</returns>
		public static bool IsNegativeInfinity(glFloat16 value)
		{
			return value.Value==NegativeInfinity;
		}

		/// <summary>
		/// Returns a value indicating whether the specified number evaluates to positive infinity.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="PositiveInfinity"/>; otherwise, <b>false</b>.</returns>
		public static bool IsPositiveInfinity(glFloat16 value)
		{
			return value.Value==PositiveInfinity;
		}

		/// <summary>
		/// Implicitly converts the value of this instance to <b>float</b>.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns>The value of this instance as <b>float</b>.</returns>
		public static implicit operator float(glFloat16 value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			SingleUInt32Union union=new SingleUInt32Union();
			ushort v=value.Value;

			// Signed zero?
			if((v&0x7FFF)==0)
			{
				union.uint32=(uint)v<<16; // Return signed zero
				return union.single;
			}

			// Not zero
			uint sign=(uint)v&SignMask;
			uint exponent=(uint)v&ExponentMask;
			uint mantissa=(uint)v&MantissaMask;

			// Infinity or NaN (all the exponent bits are set)
			if(exponent==ExponentMask)
			{
				if(mantissa!=0) return float.NaN;
				if(sign==0) return float.PositiveInfinity;
				return float.NegativeInfinity;
			}

			// Denormalized number
			if(exponent==0)
			{
				// Find the exponent by loop-shifting until the leading one flows out mantissa
				exponent=(exponent>>10)+127-15+1;
				do
				{
					exponent--;
					mantissa<<=1;
				} while((mantissa&0x0400)==0);

				sign<<=16;
				exponent<<=23;
				mantissa=(mantissa&MantissaMask)<<13;

				union.uint32=sign|exponent|mantissa;
				return union.single;
			}

			// Normalized number
			sign<<=16;
			exponent=(exponent>>10)+127-15;
			exponent<<=23;
			mantissa=(mantissa&MantissaMask)<<13;

			union.uint32=sign|exponent|mantissa;
			return union.single;
#else
			int exp=value.Value&ExponentMask;
			int man=value.Value&MantissaMask;

			if(exp==ExponentMask)
			{
				if(man==0)
				{
					if((value.Value&SignMask)==0) return float.PositiveInfinity;
					return float.NegativeInfinity;
				}
				return float.NaN;
			}

			if(exp==0)
			{
				if((value.Value&SignMask)==0) return man*Epsilon;
				return -man*Epsilon;
			}

			man|=1024;
			exp--;

			if((value.Value&SignMask)==0) return (man*Epsilon)*(1<<(exp>>10));
			return -(man*Epsilon)*(1<<(exp>>10));
#endif
		}

		/// <summary>
		/// Implicitly converts the value of this instance to <b>double</b>.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns>The value of this instance as <b>double</b>.</returns>
		public static implicit operator double(glFloat16 value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			ushort v=value.Value;

			// Signed zero?
			if((v&0x7FFF)==0) return BitConverter.Int64BitsToDouble((long)v<<48); // Return signed zero

			// Not zero
			uint sign=(uint)v&SignMask;
			uint exponent=(uint)v&ExponentMask;
			uint mantissa=(uint)v&MantissaMask;

			// Infinity or NaN (all the exponent bits are set)
			if(exponent==ExponentMask)
			{
				if(mantissa!=0) return double.NaN;
				if(sign==0) return double.PositiveInfinity;
				return double.NegativeInfinity;
			}

			// Denormalized number
			if(exponent==0)
			{
				// Find the exponent by loop-shifting until the leading one flows out mantissa
				exponent=(exponent>>10)+1023-15+1;
				do
				{
					exponent--;
					mantissa<<=1;
				} while((mantissa&0x0400)==0);

				sign<<=16;
				exponent<<=20;
				mantissa=(mantissa&MantissaMask)<<10;

				return BitConverter.Int64BitsToDouble((long)(sign|exponent|mantissa)<<32);
			}

			// Normalized number
			sign<<=16;
			exponent=(exponent>>10)+1023-15;
			exponent<<=20;
			mantissa=(mantissa&MantissaMask)<<10;

			return BitConverter.Int64BitsToDouble((long)(sign|exponent|mantissa)<<32);
#else
			int exp=value.Value&ExponentMask;
			int man=value.Value&MantissaMask;

			if(exp==ExponentMask)
			{
				if(man==0)
				{
					if((value.Value&SignMask)==0) return float.PositiveInfinity;
					return float.NegativeInfinity;
				}
				return float.NaN;
			}

			if(exp==0)
			{
				if((value.Value&SignMask)==0) return man*Epsilon;
				return -man*Epsilon;
			}

			man|=1024;
			exp--;

			if((value.Value&SignMask)==0) return (man*Epsilon)*(1<<(exp>>10));
			return -(man*Epsilon)*(1<<(exp>>10));
#endif
		}
	
		// TODO: Add compare operators
	}
}
