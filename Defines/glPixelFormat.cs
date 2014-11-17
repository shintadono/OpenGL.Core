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
	/// Pixel format.
	/// </summary>
	public enum glPixelFormat : uint
	{
		/// <summary>
		/// -
		/// </summary>
		NONE=0,

		/// <summary>
		/// Stencil value.
		/// </summary>
		STENCIL_INDEX=0x1901,

		/// <summary>
		/// Depth value.
		/// </summary>
		DEPTH_COMPONENT=0x1902,

		/// <summary>
		/// Stencil and depth value combined.
		/// </summary>
		DEPTH_STENCIL=0x84F9,

		/// <summary>
		/// Red color value.
		/// </summary>
		RED=0x1903,

		/// <summary>
		/// Green color value.
		/// </summary>
		GREEN=0x1904,

		/// <summary>
		/// Blue color value.
		/// </summary>
		BLUE=0x1905,

		/// <summary>
		/// Red and green color value.
		/// </summary>
		RG=0x8227,

		/// <summary>
		/// Red, green and blue color value.
		/// </summary>
		RGB=0x1907,

		/// <summary>
		/// RGBA color value.
		/// </summary>
		RGBA=0x1908,

		/// <summary>
		/// Red, green and blue color value in reversed order.
		/// </summary>
		BGR=0x80E0,

		/// <summary>
		/// RGBA color value in reversed order.
		/// </summary>
		BGRA=0x80E1,

		/// <summary>
		/// Red color value as integer.
		/// </summary>
		RED_INTEGER=0x8D94,

		/// <summary>
		/// Green color value as integer.
		/// </summary>
		GREEN_INTEGER=0x8D95,

		/// <summary>
		/// Blue  color value as integer.
		/// </summary>
		BLUE_INTEGER=0x8D96,

		/// <summary>
		/// Red and green color value as integer.
		/// </summary>
		RG_INTEGER=0x8228,

		/// <summary>
		/// Red, green and blue color value as integer.
		/// </summary>
		RGB_INTEGER=0x8D98,

		/// <summary>
		/// RGBA color value as integer.
		/// </summary>
		RGBA_INTEGER=0x8D99,

		/// <summary>
		/// Red, green and blue color value as integer in reversed order.
		/// </summary>
		BGR_INTEGER=0x8D9A,

		/// <summary>
		/// RGBA color value as integer in reversed order.
		/// </summary>
		BGRA_INTEGER=0x8D9B,
	}
}
