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
	/// Enum for program interfaces.
	/// </summary>
	public enum glProgramInterface : uint
	{
		/// <summary>
		/// Atomic counter buffer interface.
		/// </summary>
		ATOMIC_COUNTER_BUFFER=0x92C0,

		/// <summary>
		/// Buffer variables interface.
		/// </summary>
		BUFFER_VARIABLE=0x92E5,

		/// <summary>
		/// Compute shader subroutine interface.
		/// </summary>
		COMPUTE_SUBROUTINE=0x92ED,

		/// <summary>
		/// Compute shader subroutine uniform interface.
		/// </summary>
		COMPUTE_SUBROUTINE_UNIFORM=0x92F3,

		/// <summary>
		/// Fragment shader subroutine interface.
		/// </summary>
		FRAGMENT_SUBROUTINE=0x92EC,

		/// <summary>
		/// Fragment shader subroutine uniform interface.
		/// </summary>
		FRAGMENT_SUBROUTINE_UNIFORM=0x92F2,

		/// <summary>
		/// Geometry shader subroutine interface.
		/// </summary>
		GEOMETRY_SUBROUTINE=0x92EB,

		/// <summary>
		/// Geometry shader subroutine uniform interface.
		/// </summary>
		GEOMETRY_SUBROUTINE_UNIFORM=0x92F1,

		/// <summary>
		/// Program input interface.
		/// </summary>
		PROGRAM_INPUT=0x92E3,

		/// <summary>
		/// Program output interface.
		/// </summary>
		PROGRAM_OUTPUT=0x92E4,

		/// <summary>
		/// Shader storage block interface.
		/// </summary>
		SHADER_STORAGE_BLOCK=0x92E6,

		/// <summary>
		/// Tesselation control shader subroutine interface.
		/// </summary>
		TESS_CONTROL_SUBROUTINE=0x92E9,

		/// <summary>
		/// Tesselation evaluation shader subroutine interface.
		/// </summary>
		TESS_EVALUATION_SUBROUTINE=0x92EA,

		/// <summary>
		/// Tesselation control shader subroutine uniform interface.
		/// </summary>
		TESS_CONTROL_SUBROUTINE_UNIFORM=0x92EF,

		/// <summary>
		/// Tesselation evaluation shader subroutine uniform interface.
		/// </summary>
		TESS_EVALUATION_SUBROUTINE_UNIFORM=0x92F0,

		/// <summary>
		/// Transform feedback buffer interface.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER=0x8C8E,

		/// <summary>
		/// Transform feedback varying interface.
		/// </summary>
		TRANSFORM_FEEDBACK_VARYING=0x92F4,

		/// <summary>
		/// Uniform interface.
		/// </summary>
		UNIFORM=0x92E1,

		/// <summary>
		/// Uniform block interface.
		/// </summary>
		UNIFORM_BLOCK=0x92E2,

		/// <summary>
		/// Vertex shader subroutine interface.
		/// </summary>
		VERTEX_SUBROUTINE=0x92E8,

		/// <summary>
		/// Vertex shader subroutine uniform interface.
		/// </summary>
		VERTEX_SUBROUTINE_UNIFORM=0x92EE,
	}
}
