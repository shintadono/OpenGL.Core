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
	/// Bitmask for <see cref="gl.UseProgramStages"/>.
	/// </summary>
	[Flags]
	public enum glProgramStageMask : uint
	{
		/// <summary>
		/// Use nothing.
		/// </summary>
		None = 0x00000000,

		/// <summary>
		/// Use vertex shader stage.
		/// </summary>
		VERTEX_SHADER_BIT = 0x00000001,

		/// <summary>
		/// Use fragment shader stage.
		/// </summary>
		FRAGMENT_SHADER_BIT = 0x00000002,

		/// <summary>
		/// Use geometry shader stage.
		/// </summary>
		GEOMETRY_SHADER_BIT = 0x00000004,

		/// <summary>
		/// Use tesselation control shader stage.
		/// </summary>
		TESS_CONTROL_SHADER_BIT = 0x00000008,

		/// <summary>
		/// Use tesselation evaluation shader stage.
		/// </summary>
		TESS_EVALUATION_SHADER_BIT = 0x00000010,

		/// <summary>
		/// Use compute shader stage.
		/// </summary>
		COMPUTE_SHADER_BIT = 0x00000020,

		/// <summary>
		/// Use all shader stages.
		/// </summary>
		ALL_SHADER_BITS = 0xFFFFFFFF,
	}
}
