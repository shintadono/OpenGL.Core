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

namespace OpenGL.Core
{
	/// <summary>
	/// Pixel data type.
	/// </summary>
	public enum glPixelDataType : uint
	{
		/// <summary>
		/// -
		/// </summary>
		NONE=0,

		/// <summary>
		/// 8-bit unsigned integer.
		/// </summary>
		UNSIGNED_BYTE=0x1401,

		/// <summary>
		/// 8-bit signed integer.
		/// </summary>
		BYTE=0x1400,

		/// <summary>
		/// 16-bit unsigned integer.
		/// </summary>
		UNSIGNED_SHORT=0x1403,

		/// <summary>
		/// 16-bit signed integer.
		/// </summary>
		SHORT=0x1402,

		/// <summary>
		/// 32-bit unsigned integer.
		/// </summary>
		UNSIGNED_INT=0x1405,

		/// <summary>
		/// 32-bit signed integer.
		/// </summary>
		INT=0x1404,

		/// <summary>
		/// 16-bit signed float.
		/// </summary>
		HALF_FLOAT=0x140B,

		/// <summary>
		/// 32-bit signed float.
		/// </summary>
		FLOAT=0x1406,

		/// <summary>
		/// 3-bit + 3-bit + 2-bit as 8-bit unsigned integer.
		/// </summary>
		UNSIGNED_BYTE_3_3_2=0x8032,

		/// <summary>
		/// 3-bit + 3-bit + 2-bit as 8-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_BYTE_2_3_3_REV=0x8362,

		/// <summary>
		/// 5-bit + 6-bit + 5-bit as 16-bit unsigned integer.
		/// </summary>
		UNSIGNED_SHORT_5_6_5=0x8363,

		/// <summary>
		/// 5-bit + 6-bit + 5-bit as 16-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_SHORT_5_6_5_REV=0x8364,

		/// <summary>
		/// 4 * 4-bit as 16-bit unsigned integer.
		/// </summary>
		UNSIGNED_SHORT_4_4_4_4=0x8033,

		/// <summary>
		/// 4 * 4-bit as 16-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_SHORT_4_4_4_4_REV=0x8365,

		/// <summary>
		/// 3 * 5-bit + 1-bit as 16-bit unsigned integer.
		/// </summary>
		UNSIGNED_SHORT_5_5_5_1=0x8034,

		/// <summary>
		/// 3 * 5-bit + 1-bit as 16-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_SHORT_1_5_5_5_REV=0x8366,

		/// <summary>
		/// 4 * 8-bit as 32-bit unsigned integer.
		/// </summary>
		UNSIGNED_INT_8_8_8_8=0x8035,

		/// <summary>
		/// 4 * 8-bit as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_8_8_8_8_REV=0x8367,

		/// <summary>
		/// 3 * 10-bit + 2-bit as 32-bit unsigned integer.
		/// </summary>
		UNSIGNED_INT_10_10_10_2=0x8036,

		/// <summary>
		/// 3 * 10-bit + 2-bit as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_2_10_10_10_REV=0x8368,

		/// <summary>
		/// 24-bit + 8-bit as 32-bit unsigned integer. (Combined depth and stencil value)
		/// </summary>
		UNSIGNED_INT_24_8=0x84FA,

		/// <summary>
		/// 11-bit + 11-bit + 10-bit floats as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_10F_11F_11F_REV=0x8C3B,

		/// <summary>
		/// 3 * 9-bit + 5-bit as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_5_9_9_9_REV=0x8C3E,

		/// <summary>
		/// 32-bit float + 24-bit + 8-bit as 64-bit. (Combined depth (32F) and stencil (8) value)
		/// </summary>
		FLOAT_32_UNSIGNED_INT_24_8_REV=0x8DAD,
	}
}
