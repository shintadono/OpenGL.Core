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
	/// Shader type.
	/// </summary>
	public enum glShaderType : uint
	{
		/// <summary>
		/// Fragment shader.
		/// </summary>
		FRAGMENT_SHADER = 0x8B30,

		/// <summary>
		/// Vertex shader.
		/// </summary>
		VERTEX_SHADER = 0x8B31,

		/// <summary>
		/// Geometry shader.
		/// </summary>
		GEOMETRY_SHADER = 0x8DD9,

		/// <summary>
		/// Tesselation evaluation shader.
		/// </summary>
		TESS_EVALUATION_SHADER = 0x8E87,

		/// <summary>
		/// Tesselation control shader.
		/// </summary>
		TESS_CONTROL_SHADER = 0x8E88,

		/// <summary>
		/// Compute shader.
		/// </summary>
		COMPUTE_SHADER = 0x91B9,
	}
}
