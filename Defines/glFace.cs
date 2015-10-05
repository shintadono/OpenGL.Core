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
	/// Specifies the face of a polygon an operation is operating on.
	/// </summary>
	/// <remarks>
	/// glFace is used by the methods <see cref="gl.CullFace"/>, <see cref="gl.PolygonMode"/>,
	/// <see cref="gl.StencilOpSeparate"/>, <see cref="gl.StencilFuncSeparate"/> and
	/// <see cref="gl.StencilMaskSeparate"/>.
	/// </remarks>
	public enum glFace : uint
	{
		/// <summary>
		/// Handle front face.
		/// </summary>
		FRONT = 0x0404,

		/// <summary>
		/// Handle back face.
		/// </summary>
		BACK = 0x0405,

		/// <summary>
		/// Handle front and back face.
		/// </summary>
		FRONT_AND_BACK = 0x0408,
	}
}
