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
	/// Specifies the behaviour to be controlled by <see cref="gl.Hint"/>.
	/// <seealso cref="glHintMode"/>
	/// </summary>
	public enum glHintTarget : uint
	{
		/// <summary>
		/// Line sampling quality.
		/// </summary>
		LINE_SMOOTH_HINT=0x0C52,

		/// <summary>
		/// Polygon sampling quality.
		/// </summary>
		POLYGON_SMOOTH_HINT=0x0C53,

		/// <summary>
		/// Quality and performance of texture image compression.
		/// </summary>
		TEXTURE_COMPRESSION_HINT=0x84EF,

		/// <summary>
		/// Derivative accuracy for fragment processing built-in functions <c>dFdx</c>, <c>dFdy</c> and <c>fwidth</c>.
		/// </summary>
		FRAGMENT_SHADER_DERIVATIVE_HINT=0x8B8B,
	}
}
