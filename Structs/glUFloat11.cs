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
	/// Represents a 11-bit unsigned floating-point number.
	/// </summary>
	public struct glUFloat11
	{
		/// <summary>
		/// Memory representation of the 11-bit unsigned floating-point number.
		/// </summary>
		public ushort Value;

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		public glUFloat11(glUFloat11 value) { Value=value.Value; }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of <see cref="glUFloat10"/>.</param>
		public glUFloat11(glUFloat10 value)
		{
			int exp=value.Value&glUFloat10.ExponentMask;
			int man=value.Value&glUFloat10.MantissaMask;

			if(exp==glUFloat10.ExponentMask)
			{
				if(man==0) Value=Infinity;
				else Value=NaN;
				return;
			}

			Value=(ushort)((value.Value<<1)&FillMask);
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">An instance of <see cref="glFloat16"/>.</param>
		public glUFloat11(glFloat16 value)
		{
			int sig=value.Value&glFloat16.SignMask;
			int exp=value.Value&glFloat16.ExponentMask;
			int man=value.Value&glFloat16.MantissaMask;

			if(exp==glFloat16.ExponentMask)
			{
				if(man!=0) Value=NaN;
				else if(sig==0) Value=Infinity;
				else Value=0;
				return;
			}

			Value=(ushort)((value.Value>>4)+(value.Value&8));
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>float</b> value.</param>
		public glUFloat11(float value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			// Get bits as uint
			SingleUInt32Union union=new SingleUInt32Union();
			union.single=value;
			uint ivalue=union.uint32;

			Value=0;

			// Zero?
			if((ivalue&0x7FFFFFFF)==0) return;

			uint maskedExpo=ivalue&0x7F800000;

			// Denormalized number? (this would underflow anyway)
			if(maskedExpo==0) return;

			uint maskedMant=ivalue&0x007FFFFF;

			// Infinity or NaN? (all exponent bits set)
			if(maskedExpo==0x7F800000)
			{
				// NaN?
				if(maskedMant!=0) Value=NaN;
				else if((ivalue&0x80000000)==0) Value=Infinity; // Negative infinity => 0
				return;
			}

			// Negative?
			if((ivalue&0x80000000)!=0) return;

			// Normalized number
			int iExponent=((int)maskedExpo>>23)-127+15; // Convert exponent from float range to 16-bit float range

			// Overflow? (exponent out of range)
			if(iExponent>=0x1F)
			{
				Value=Infinity;
				return;
			}

			// Underflow? (exponent out of range)
			if(iExponent<=0)
			{
				// No mantissa bits left
				if((18-iExponent)>24) return;

				// Make denormalized number
				maskedMant|=0x00800000; // Add the leading one digit

				ushort denormMantissa=(ushort)(maskedMant>>(18-iExponent));

				// Check for rounding
				if(((maskedMant>>(17-iExponent))&1)!=0) denormMantissa++;

				Value|=denormMantissa;
				return;
			}

			Value|=(ushort)(iExponent<<6);
			Value|=(ushort)(maskedMant>>17);

			// Check for rounding
			if((maskedMant&0x00010000)!=0) Value++;
#else
			if(float.IsNaN(value))
			{
				Value=NaN;
				return;
			}

			if(float.IsInfinity(value))
			{
				Value=Infinity;
				return;
			}

			if(value<MinValue) value=MinValue;
			else if(value>MaxValue) value=MaxValue;

			int exp=(int)(Math.Log(value, 2)+15);

			if(exp<=0) Value=(ushort)(value*(1<<20)+0.5f);
			else if(exp>21) Value=(ushort)((exp<<6)+(int)(value/(1<<(exp-21))-63.5f));
			else Value=(ushort)((exp<<6)+(int)(value*(1<<(21-exp))-63.5f));
#endif
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>double</b> value.</param>
		public glUFloat11(double value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			// Get bits as uint
			uint ivalue=(uint)(BitConverter.DoubleToInt64Bits(value)>>32);

			Value=0;

			// Zero?
			if((ivalue&0x7FFFFFFF)==0) return;

			uint maskedExpo=ivalue&0x7FF00000;

			// Denormalized number? (this would underflow anyway)
			if(maskedExpo==0) return;

			uint maskedMant=ivalue&0x000FFFFF;

			// Infinity or NaN? (all exponent bits set)
			if(maskedExpo==0x7FF00000)
			{
				// NaN?
				if(maskedMant!=0) Value=NaN;
				else if((ivalue&0x80000000)==0) Value=Infinity; // Negative infinity => 0
				return;
			}

			// Negative?
			if((ivalue&0x80000000)!=0) return;

			// Normalized number
			int iExponent=((int)maskedExpo>>20)-1023+15; // Convert exponent from double range to 16-bit float range

			// Overflow? (exponent out of range)
			if(iExponent>=0x1F)
			{
				Value=Infinity;
				return;
			}

			// Underflow? (exponent out of range)
			if(iExponent<=0)
			{
				// No mantissa bits left
				if((15-iExponent)>21) return;

				// Make denormalized number
				maskedMant|=0x00100000; // Add the leading one digit

				ushort denormMantissa=(ushort)(maskedMant>>(15-iExponent));

				// Check for rounding
				if(((maskedMant>>(14-iExponent))&1)!=0) denormMantissa++;

				Value|=denormMantissa;
				return;
			}

			Value|=(ushort)(iExponent<<6);
			Value|=(ushort)(maskedMant>>14);

			// Check for rounding
			if((maskedMant&0x00002000)!=0) Value++;
#else
			if(double.IsNaN(value))
			{
				Value=NaN;
				return;
			}

			if(double.IsInfinity(value))
			{
				Value=Infinity;
				return;
			}

			if(value<MinValue) value=MinValue;
			else if(value>MaxValue) value=MaxValue;

			int exp=(int)(Math.Log(value, 2)+15);

			if(exp<=0) Value=(ushort)(value*(1<<20)+0.5);
			else if(exp>21) Value=(ushort)((exp<<6)+(int)(value/(1<<(exp-21))-63.5));
			else Value=(ushort)((exp<<6)+(int)(value*(1<<(21-exp))-63.5));
#endif
		}

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>byte</b> value.</param>
		public glUFloat11(byte value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>sbyte</b> value.</param>
		public glUFloat11(sbyte value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>short</b> value.</param>
		public glUFloat11(short value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>ushort</b> value.</param>
		public glUFloat11(ushort value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>int</b> value.</param>
		public glUFloat11(int value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>uint</b> value.</param>
		public glUFloat11(uint value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>long</b> value.</param>
		public glUFloat11(long value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>ulong</b> value.</param>
		public glUFloat11(ulong value) : this((float)value) { }

		/// <summary>
		/// Constructs an instance of this class with the value of the argument.
		/// </summary>
		/// <param name="value">A <b>decimal</b> value.</param>
		public glUFloat11(decimal value) : this((double)value) { }

		/// <summary>
		/// Represents the smallest possible value this class can hold. This field is constant.
		/// </summary>
		public const float MinValue=0;

		/// <summary>
		/// Represents the largest possible value this class can hold. This field is constant.
		/// </summary>
		public const float MaxValue=65024;

		/// <summary>
		/// Represents the smallest positive value that is greater than zero. This field is constant. (2^-20)
		/// </summary>
		public const float Epsilon=0.00000095367431640625f;

		/// <summary>
		/// Represents a value that is not a number (<b>NaN</b>). This field is constant.
		/// (Exponent and mantissa all bits set to 1)
		/// </summary>
		public const ushort NaN=FillMask;

		/// <summary>
		/// Represents infinity. This field is constant.
		/// (Exponent all bits set to 1 and mantissa all bits set to 0)
		/// </summary>
		public const ushort Infinity=ExponentMask;

		/// <summary>
		/// Represents the smallest positive value that is greater than zero as the memory representation. This field is constant.
		/// (Exponent all bits set to 0 and mantissa only the least significant bit set to 1)
		/// </summary>
		public const ushort EpsilonUShort=1;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the value. This field is constant.
		/// </summary>
		public const ushort FillMask=0x07FF;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the exponent of the value. This field is constant.
		/// </summary>
		public const ushort ExponentMask=0x07C0;

		/// <summary>
		/// Mask that specifies the bit for the memory representation used to store the mantissa of the value. This field is constant.
		/// </summary>
		public const ushort MantissaMask=0x003F;

		/// <summary>
		/// Returns a value that indicates whether the specified value is not a number (<see cref="NaN"/>).
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="NaN"/>; otherwise, <b>false</b>.</returns>
		public static bool IsNaN(glUFloat11 value)
		{
			if((value.Value&ExponentMask)!=ExponentMask) return false;
			return (value.Value&MantissaMask)!=0;
		}

		/// <summary>
		/// Returns a value indicating whether the specified number evaluates to (positive) infinity.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns><b>true</b> if <paramref name="value"/> evaluates to <see cref="Infinity"/>; otherwise, <b>false</b>.</returns>
		public static bool IsInfinity(glUFloat11 value)
		{
			if((value.Value&ExponentMask)!=ExponentMask) return false;
			return (value.Value&MantissaMask)==0;
		}

		/// <summary>
		/// Implicitly converts the value of this instance to <b>float</b>.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns>The value of this instance as <b>float</b>.</returns>
		public static implicit operator float(glUFloat11 value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			SingleUInt32Union union=new SingleUInt32Union();
			ushort v=value.Value;

			// Zero?
			if((v&FillMask)==0) return 0;

			// Not zero
			uint exponent=(uint)v&ExponentMask;
			uint mantissa=(uint)v&MantissaMask;

			// Infinity or NaN (all the exponent bits are set)
			if(exponent==ExponentMask)
			{
				if(mantissa!=0) return float.NaN;
				return float.PositiveInfinity;
			}

			// Denormalized number
			if(exponent==0)
			{
				// Find the exponent by loop-shifting until the leading one flows out mantissa
				exponent=(exponent>>6)+127-15+1;
				do
				{
					exponent--;
					mantissa<<=1;
				} while((mantissa&0x0040)==0);

				exponent<<=23;
				mantissa=(mantissa&MantissaMask)<<17;

				union.uint32=exponent|mantissa;
				return union.single;
			}

			// Normalized number
			exponent=(exponent>>6)+127-15;
			exponent<<=23;
			mantissa=(mantissa&MantissaMask)<<17;

			union.uint32=exponent|mantissa;
			return union.single;
#else
			int exp=value.Value&ExponentMask;
			int man=value.Value&MantissaMask;

			if(exp==ExponentMask)
			{
				if(man==0) return float.PositiveInfinity;
				return float.NaN;
			}

			if(exp==0) return man*Epsilon;

			man|=64;
			exp--;
			return (man*Epsilon)*(1<<(exp>>6));
#endif
		}

		/// <summary>
		/// Implicitly converts the value of this instance to <b>double</b>.
		/// </summary>
		/// <param name="value">An instance of this class.</param>
		/// <returns>The value of this instance as <b>double</b>.</returns>
		public static implicit operator double(glUFloat11 value)
		{
#if !SLOW_BUT_PLATTFORM_INDEPENDENT_FLOAT_CONVERSION
			ushort v=value.Value;

			// Zero?
			if((v&FillMask)==0) return 0;

			// Not zero
			uint exponent=(uint)v&ExponentMask;
			uint mantissa=(uint)v&MantissaMask;

			// Infinity or NaN (all the exponent bits are set)
			if(exponent==ExponentMask)
			{
				if(mantissa!=0) return double.NaN;
				return float.PositiveInfinity;
			}

			// Denormalized number
			if(exponent==0)
			{
				// Find the exponent by loop-shifting until the leading one flows out mantissa
				exponent=(exponent>>6)+1023-15+1;
				do
				{
					exponent--;
					mantissa<<=1;
				} while((mantissa&0x0040)==0);

				exponent<<=20;
				mantissa=(mantissa&MantissaMask)<<14;

				return BitConverter.Int64BitsToDouble((long)(exponent|mantissa)<<32);
			}

			// Normalized number
			exponent=(exponent>>6)+1023-15;
			exponent<<=20;
			mantissa=(mantissa&MantissaMask)<<14;

			return BitConverter.Int64BitsToDouble((long)(exponent|mantissa)<<32);
#else
			int exp=value.Value&ExponentMask;
			int man=value.Value&MantissaMask;

			if(exp==ExponentMask)
			{
				if(man==0) return float.PositiveInfinity;
				return float.NaN;
			}

			if(exp==0) return man*Epsilon;

			man|=64;
			exp--;
			return (man*Epsilon)*(1<<(exp>>6));
#endif
		}

		// TODO: Add compare operators
	}
}
