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
	/// Shader precision type. Used for <see cref="gl.GetShaderPrecisionFormat"/>.
	/// </summary>
	public enum glShaderPrecisionType : uint
	{
		/// <summary>
		/// Precisions of a <c>lowp float</c>.
		/// </summary>
		LOW_FLOAT=0x8DF0,

		/// <summary>
		/// Precisions of a <c>mediump float</c>.
		/// </summary>
		MEDIUM_FLOAT=0x8DF1,

		/// <summary>
		/// Precisions of a <c>highp float</c>.
		/// </summary>
		HIGH_FLOAT=0x8DF2,

		/// <summary>
		/// Precisions of a <c>lowp int</c>.
		/// </summary>
		LOW_INT=0x8DF3,

		/// <summary>
		/// Precisions of a <c>mediump int</c>.
		/// </summary>
		MEDIUM_INT=0x8DF4,

		/// <summary>
		/// Precisions of a <c>highp int</c>.
		/// </summary>
		HIGH_INT=0x8DF5,
	}
}
