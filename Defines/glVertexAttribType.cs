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
	/// Data type for vertex attribs.
	/// </summary>
	public enum glVertexAttribType : uint
	{
		/// <summary>
		/// Unsigned 8-bit integers.
		/// </summary>
		UNSIGNED_BYTE=0x1401,

		/// <summary>
		/// Signed 8-bit integers.
		/// </summary>
		BYTE=0x1400,

		/// <summary>
		/// Unsigned 16-bit integers.
		/// </summary>
		UNSIGNED_SHORT=0x1403,

		/// <summary>
		/// Signed 16-bit integers.
		/// </summary>
		SHORT=0x1402,

		/// <summary>
		/// Unsigned 32-bit integers.
		/// </summary>
		UNSIGNED_INT=0x1405,

		/// <summary>
		/// Signed 32-bit integers.
		/// </summary>
		INT=0x1404,

		/// <summary>
		/// 16-bit floating-point values.
		/// </summary>
		HALF_FLOAT=0x140B,

		/// <summary>
		/// 32-bit floating-point values.
		/// </summary>
		/// 
		FLOAT=0x1406,

		/// <summary>
		/// 64-bit floating-point values.
		/// </summary>
		DOUBLE=0x140A,

		/// <summary>
		/// Corresponds to the GLSL type <c>fixed.</c>
		/// </summary>
		FIXED=0x140C,

		/// <summary>
		/// 3 * 10-bit + 2-bit as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_2_10_10_10_REV=0x8368,

		/// <summary>
		/// 11-bit + 11-bit + 10-bit floats as 32-bit unsigned integer in reversed order.
		/// </summary>
		UNSIGNED_INT_10F_11F_11F_REV=0x8C3B,

		/// <summary>
		/// 3 * 10-bit + 2-bit as 32-bit unsigned integer in reversed order.
		/// </summary>
		INT_2_10_10_10_REV=0x8D9F,
	}
}
