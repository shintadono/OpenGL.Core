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
	/// Enum for texture swizzle value.
	/// </summary>
	public enum glTextureSwizzleValue : uint
	{
		/// <summary>
		/// Color always zero.
		/// </summary>
		ZERO=0,

		/// <summary>
		/// Color always one.
		/// </summary>
		ONE=1,

		/// <summary>
		/// Color from red channel.
		/// </summary>
		RED=0x1903,

		/// <summary>
		/// Color from green channel.
		/// </summary>
		GREEN=0x1904,

		/// <summary>
		/// Color from blue channel.
		/// </summary>
		BLUE=0x1905,

		/// <summary>
		/// Color from alpha channel.
		/// </summary>
		ALPHA=0x1906,
	}
}
