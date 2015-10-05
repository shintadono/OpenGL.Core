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
	/// Enum for program pipeline parameters. Used by <see cref="gl.GetProgramPipelineiv"/>.
	/// </summary>
	public enum glProgramPipelineParameter : uint
	{
		/// <summary>
		/// Name of the program object currently bound to the fragement shader.
		/// </summary>
		FRAGMENT_SHADER = 0x8B30,

		/// <summary>
		/// Name of the program object currently bound to the vertex shader.
		/// </summary>
		VERTEX_SHADER = 0x8B31,

		/// <summary>
		/// Name of the program object currently bound to the geometry shader.
		/// </summary>
		GEOMETRY_SHADER = 0x8DD9,

		/// <summary>
		/// Name of the program object currently bound to the tesselation evaluation shader.
		/// </summary>
		TESS_EVALUATION_SHADER = 0x8E87,

		/// <summary>
		/// Name of the program object currently bound to the tesselation control shader.
		/// </summary>
		TESS_CONTROL_SHADER = 0x8E88,

		/// <summary>
		/// Name of the program object currently bound to the compute shader.
		/// </summary>
		COMPUTE_SHADER = 0x91B9,

		/// <summary>
		/// The name of the active program object (used for uniform updates) of pipeline is returned.
		/// </summary>
		ACTIVE_PROGRAM = 0x8259,

		/// <summary>
		/// The validation status of pipeline, as determined by <see cref="gl.ValidateProgramPipeline"/> is returned.
		/// </summary>
		VALIDATE_STATUS = 0x8B83,

		/// <summary>
		/// Length of the info log for pipeline, including a null terminator, is returned. If there is no info log, zero is returned.
		/// </summary>
		INFO_LOG_LENGTH = 0x8B84,
	}
}
