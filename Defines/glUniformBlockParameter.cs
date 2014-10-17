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
	/// Enum for uniform block parameters. Used by <see cref="gl.GetActiveUniformBlockiv"/>.
	/// </summary>
	public enum glUniformBlockParameter : uint
	{
		/// <summary>
		/// Current uniform block buffer binding.
		/// </summary>
		UNIFORM_BLOCK_BINDING=0x8A3F,

		/// <summary>
		/// Size of the active uniform block buffer.
		/// </summary>
		UNIFORM_BLOCK_DATA_SIZE=0x8A40,

		/// <summary>
		/// Uniform block name length.
		/// </summary>
		UNIFORM_BLOCK_NAME_LENGTH=0x8A41,

		/// <summary>
		/// Number of active uniforms in uniform block.
		/// </summary>
		UNIFORM_BLOCK_ACTIVE_UNIFORMS=0x8A42,

		/// <summary>
		/// Indices of the active uniforms in uniform block.
		/// </summary>
		UNIFORM_BLOCK_ACTIVE_UNIFORM_INDICES=0x8A43,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the vertex shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_VERTEX_SHADER=0x8A44,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the geometry shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_GEOMETRY_SHADER=0x8A45,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the fragment shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_FRAGMENT_SHADER=0x8A46,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the tesselation control shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_TESS_CONTROL_SHADER=0x84F0,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the tesselation evaluation shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_TESS_EVALUATION_SHADER=0x84F1,

		/// <summary>
		/// Indicates if the active uniform block buffer is referenced by the compute shader.
		/// </summary>
		UNIFORM_BLOCK_REFERENCED_BY_COMPUTE_SHADER=0x90EC,
	}
}
