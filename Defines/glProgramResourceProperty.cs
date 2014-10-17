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
	/// Enum for program resource properties. Used by <see cref="gl.GetProgramResourceiv"/>.
	/// </summary>
	public enum glProgramResourceProperty : uint
	{
		/// <summary>
		/// Returns array of active variable indices associated with an atomic counter buffer,
		/// active uniform block, shader storage block, or transform feedback buffer.
		/// </summary>
		ACTIVE_VARIABLES=0x9305,

		/// <summary>
		/// Returns the number of active array elements of an active variable.
		/// </summary>
		ARRAY_SIZE=0x92FB,

		/// <summary>
		/// Returns the stride between array elements in an active variable.
		/// </summary>
		ARRAY_STRIDE=0x92FE,

		/// <summary>
		/// Returns the index of the active atomic counter buffer containing an active variable.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_INDEX=0x9301,

		/// <summary>
		/// Returns the index of the active interface block containing an active variable.
		/// </summary>
		BLOCK_INDEX=0x92FD,

		/// <summary>
		/// Returns the index of the buffer binding point associated with the active uniform block, atomic counter buffer,
		/// shader storage block, or transform feedback buffer.
		/// </summary>
		BUFFER_BINDING=0x9302,

		/// <summary>
		/// Returns the implementation-dependent minimum total buffer object size.
		/// </summary>
		BUFFER_DATA_SIZE=0x9303,

		/// <summary>
		/// Returns the list of subroutines compatible with a subroutine uniform as array of
		/// <see cref="NUM_COMPATIBLE_SUBROUTINES"/> <b>int</b>s.
		/// </summary>
		COMPATIBLE_SUBROUTINES=0x8E4B,

		/// <summary>
		/// Returns the assigned location for an active uniform, input, output, or subroutine uniform variable.
		/// </summary>
		LOCATION=0x930E,

		/// <summary>
		/// Returns the first component of the location assigned to an active input or output variable.
		/// </summary>
		LOCATION_COMPONENT=0x934A,

		/// <summary>
		/// Returns the fragment color index of an active fragment shader output variable.
		/// </summary>
		LOCATION_INDEX=0x930F,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the input or output is a per-patch attribute.
		/// </summary>
		IS_PER_PATCH=0x92E7,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if an active variable is a row-major matrix.
		/// </summary>
		IS_ROW_MAJOR=0x9300,

		/// <summary>
		/// Returns the stride between columns of a column-major matrix or rows of a row-major matrix.
		/// </summary>
		MATRIX_STRIDE=0x92FF,

		/// <summary>
		/// Returns the length of the name string associated with an active variable, interface block, or subroutine.
		/// </summary>
		NAME_LENGTH=0x92F9,

		/// <summary>
		/// Returns the number of active variables associated with an active uniform block, atomic counter buffer,
		/// shader storage block, or transform feedback buffer.
		/// </summary>
		NUM_ACTIVE_VARIABLES=0x9304,

		/// <summary>
		/// Returns the number of subroutines compatible with a subroutine uniform.
		/// </summary>
		NUM_COMPATIBLE_SUBROUTINES=0x8E4A,

		/// <summary>
		/// Returns the offset of an active variable.
		/// </summary>
		OFFSET=0x92FC,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the vertex shader.
		/// </summary>
		REFERENCED_BY_VERTEX_SHADER=0x9306,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the tessellation control shader.
		/// </summary>
		REFERENCED_BY_TESS_CONTROL_SHADER=0x9307,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the tessellation evaluation shader.
		/// </summary>
		REFERENCED_BY_TESS_EVALUATION_SHADER=0x9308,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the geometry shader.
		/// </summary>
		REFERENCED_BY_GEOMETRY_SHADER=0x9309,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the fragment shader.
		/// </summary>
		REFERENCED_BY_FRAGMENT_SHADER=0x930A,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the active resource is referenced by the compute shader.
		/// </summary>
		REFERENCED_BY_COMPUTE_SHADER=0x930B,

		/// <summary>
		/// Returns the number of active array elements of the top-level shader storage block member containing
		/// to the active variable.
		/// </summary>
		TOP_LEVEL_ARRAY_SIZE=0x930C,

		/// <summary>
		/// Returns the stride between array elements of the top-level shader storage block member containing
		/// the active variable.
		/// </summary>
		TOP_LEVEL_ARRAY_STRIDE=0x930D,

		/// <summary>
		/// Returns the index of the active transform feedback buffer associated with an active variable.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_INDEX=0x934B,

		/// <summary>
		/// Returns the stride, in basic machine units, between consecutive vertices written to the
		/// transform feedback buffer.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_STRIDE=0x934C,

		/// <summary>
		/// Returns the type of an active variable as <see cref="glGLSLType"/>.
		/// </summary>
		TYPE=0x92FA,
	}
}
