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
	/// Specifies the order of the vertices of a polygon to define the <see cref="glFace.FRONT">FRONT</see>.
	/// </summary>
	/// <remarks>
	/// glVertexOrder is used as <c>dir</c> argument in <see cref="gl.FrontFace"/>,
	/// and is returned by <see cref="O:OpenGL.Core.gl.GetIntegerv">gl.GetIntegerv</see> for <see cref="glGetIntegerParameter.FRONT_FACE"/> and
	/// <see cref="gl.GetProgramiv"/> for <see cref="glProgramParameter.TESS_GEN_VERTEX_ORDER"/>.
	/// </remarks>
	public enum glFrontFaceDirection : uint
	{
		/// <summary>
		/// Clockwise.
		/// </summary>
		CW=0x0900,

		/// <summary>
		/// Counter-clockwise.
		/// </summary>
		CCW=0x0901,
	}
}
