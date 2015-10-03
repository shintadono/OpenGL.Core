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
	/// Enum for program parameter. Used by <see cref="gl.GetProgramiv"/> and <see cref="gl.ProgramParameteri"/>.
	/// </summary>
	public enum glProgramParameter : uint
	{
		/// <summary>
		/// Returns the number of active atomic counter buffers used by the program.
		/// </summary>
		ACTIVE_ATOMIC_COUNTER_BUFFERS=0x92D9,

		/// <summary>
		/// Returns the length of the longest active attribute name, including a null terminator.
		/// </summary>
		ACTIVE_ATTRIBUTE_MAX_LENGTH=0x8B8A,

		/// <summary>
		/// Returns the number of active attributes in the program.
		/// </summary>
		ACTIVE_ATTRIBUTES=0x8B89,

		/// <summary>
		/// Returns the length of the longest active uniform block name, including a null terminator.
		/// </summary>
		ACTIVE_UNIFORM_BLOCK_MAX_NAME_LENGTH=0x8A35,

		/// <summary>
		/// Returns the number of uniform blocks for the program containing active uniforms.
		/// </summary>
		ACTIVE_UNIFORM_BLOCKS=0x8A36,

		/// <summary>
		/// Returns the length of the longest active uniform name, including a null terminator.
		/// </summary>
		ACTIVE_UNIFORM_MAX_LENGTH=0x8B87,

		/// <summary>
		/// Returns the number of active uniforms.
		/// </summary>
		ACTIVE_UNIFORMS=0x8B86,

		/// <summary>
		/// Returns the number of attached objects.
		/// </summary>
		ATTACHED_SHADERS=0x8B85,

		/// <summary>
		/// Returns an array of three <b>int</b>s containing the local work group size of the compute program,
		/// as specified by its input layout qualifier(s).
		/// </summary>
		COMPUTE_WORK_GROUP_SIZE=0x8267,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the program has been flagged for deletion.
		/// </summary>
		DELETE_STATUS=0x8B80,

		/// <summary>
		/// Returns the geometry shader input type as <see cref="glGeometryInputType"/>.
		/// </summary>
		GEOMETRY_INPUT_TYPE=0x8917,

		/// <summary>
		/// Returns the geometry shader output type as <see cref="glGeometryOutputType"/>.
		/// </summary>
		GEOMETRY_OUTPUT_TYPE=0x8918,

		/// <summary>
		/// Returns the number of geometry shader invocations per primitive.
		/// </summary>
		GEOMETRY_SHADER_INVOCATIONS=0x887F,

		/// <summary>
		/// Returns the maximum number of vertices the geometry shader will output.
		/// </summary>
		GEOMETRY_VERTICES_OUT=0x8916,

		/// <summary>
		/// Returns the length of the info log, including a null terminator.
		/// </summary>
		INFO_LOG_LENGTH=0x8B84,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the program was last compiled successfully.
		/// </summary>
		LINK_STATUS=0x8B82,

		/// <summary>
		/// Returns the length of the binary program.
		/// </summary>
		PROGRAM_BINARY_LENGTH=0x8741,

		/// <summary>
		/// <see cref="gl.GetProgramiv"/> returns <see cref="gl.TRUE"/> if the binary retrieval hint is enabled for program.
		/// Use <see cref="gl.ProgramParameteri"/> to indicate whether a program binary is likely to be retrieved later.
		/// </summary>
		PROGRAM_BINARY_RETRIEVABLE_HINT=0x8257,

		/// <summary>
		/// <see cref="gl.GetProgramiv"/> returns <see cref="gl.TRUE"/> if the program has been flagged for use as
		/// a separable program object that canbe bound to individual shader stages with <see cref="gl.UseProgramStages"/>.
		/// Use <see cref="gl.ProgramParameteri"/> to indicate whether program can be bound for individual pipeline stages
		/// using <see cref="gl.UseProgramStages"/> after it is next linked.
		/// </summary>
		PROGRAM_SEPARABLE=0x8258,

		/// <summary>
		/// Returns the number of vertices in the tessellation control shader output patch.
		/// </summary>
		TESS_CONTROL_OUTPUT_VERTICES=0x8E75,

		/// <summary>
		/// Returns the tesselation evaluation shader primitive mode as <see cref="glTessGenMode"/>.
		/// </summary>
		TESS_GEN_MODE=0x8E76,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if point mode is enabled in a tessellation evaluation shader.
		/// </summary>
		TESS_GEN_POINT_MODE=0x8E79,

		/// <summary>
		/// Returns the tesselation evaluation shader input spacing as <see cref="glTessGenSpacing"/>.
		/// </summary>
		TESS_GEN_SPACING=0x8E77,

		/// <summary>
		/// Returns the tesselation evaluation shader vertex order as <see cref="glFrontFaceDirection"/>.
		/// </summary>
		TESS_GEN_VERTEX_ORDER=0x8E78,

		/// <summary>
		/// Returns the buffer mode used when transform feedback is active as <see cref="glTransformFeedbackBufferMode"/>.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_MODE=0x8C7F,

		/// <summary>
		/// Returns the length of the longest output variable name specified to be used for transform feedback,
		/// including a null terminator.
		/// </summary>
		TRANSFORM_FEEDBACK_VARYING_MAX_LENGTH=0x8C76,

		/// <summary>
		/// Returns the number of output variables to capture in transform feedback mode for the program.
		/// </summary>
		TRANSFORM_FEEDBACK_VARYINGS=0x8C83,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if the last call to <see cref="gl.ValidateProgram"/> with program was successful.
		/// </summary>
		VALIDATE_STATUS=0x8B83,
	}
}
