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
	/// Enum returned by <see cref="gl.GetProgramiv"/> and set by <see cref="gl.ProgramParameteri"/>
	/// with <see cref="glProgramParameter.TESS_GEN_MODE"/>.
	/// </summary>
	public enum glTessGenMode : uint
	{
		/// <summary>
		/// Tesselation evaluation shader primitive mode is <c>triangles</c>.
		/// </summary>
		TRIANGLES = 0x0004,

		/// <summary>
		/// Tesselation evaluation shader primitive mode is <c>isolines</c>.
		/// </summary>
		ISOLINES = 0x8E7A,

		/// <summary>
		/// Tesselation evaluation shader primitive mode is <c>quads</c>.
		/// </summary>
		QUADS = 0x0007,
	}
}
