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
using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL.Core
{
	using Delegates;

	namespace Delegates
	{
		/// <summary>
		/// Releases resources consumed by the shader compiler.
		/// </summary>
		public delegate void glReleaseShaderCompiler();

		/// <summary>
		/// Loads pre-compiled shader binaries.
		/// </summary>
		/// <param name="count">Number of shader objects.</param>
		/// <param name="shaders">Array of <paramref name="count"/> shader objects.</param>
		/// <param name="binaryFormat">The format of the binary.</param>
		/// <param name="binary">The data block containing the pre-compiled shader(s).</param>
		/// <param name="length">The size of <paramref name="binary"/> in bytes.</param>
		public delegate void glShaderBinary(int count, uint[] shaders, int binaryFormat, byte[] binary, int length);

		/// <summary>
		/// Returns the range and precision for numeric formats supported by the shader compiler.
		/// </summary>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="precisiontype">A <see cref="glShaderPrecisionType"/> specifying the precision type.</param>
		/// <param name="range">Returns the requested range.</param>
		/// <param name="precision">Returns the requested precision.</param>
		public delegate void glGetShaderPrecisionFormat(glShaderType shadertype, glShaderPrecisionType precisiontype, int[] range, out int precision);

		/// <summary>
		/// Sets the depth range.
		/// </summary>
		/// <param name="zNear">The near value.</param>
		/// <param name="zFar">The far value.</param>
		public delegate void glDepthRangef(float zNear, float zFar);

		/// <summary>
		/// Sets the depth value for clear operations on depth buffers.
		/// </summary>
		/// <param name="depth">Depth value.</param>
		public delegate void glClearDepthf(float depth);

		/// <summary>
		/// Returns the compiled binary of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="binary"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="binary"/>.</param>
		/// <param name="binaryFormat">Returns the format of the binary.</param>
		/// <param name="binary">Returns the binary of the program.</param>
		public delegate void glGetProgramBinary(uint program, int bufSize, out int length, out int binaryFormat, byte[] binary);

		/// <summary>
		/// Loads pre-compiled program binary.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="binaryFormat">The format of the binary.</param>
		/// <param name="binary">The data block containing the pre-compiled program.</param>
		/// <param name="length">The size of <paramref name="binary"/> in bytes.</param>
		public delegate void glProgramBinary(uint program, int binaryFormat, byte[] binary, int length);

		/// <summary>
		/// Sets parameters of program objects.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="pname">A <see cref="glProgramParameter"/> specifying the parameter.</param>
		/// <param name="value">The value to set.</param>
		public delegate void glProgramParameteri(uint program, glProgramParameter pname, int value);

		/// <summary>
		/// Binds stages of a program object to a program pipeline.
		/// </summary>
		/// <param name="pipeline">The name of the program pipeline.</param>
		/// <param name="stages">A mask of <see cref="glProgramStageMask"/>s specifying the program stages to be bound.</param>
		/// <param name="program">The name of the program.</param>
		public delegate void glUseProgramStages(uint pipeline, glProgramStageMask stages, uint program);

		/// <summary>
		/// Sets the active program object for a program pipline object.
		/// </summary>
		/// <param name="pipeline">The name of the program pipeline.</param>
		/// <param name="program">The name of the program.</param>
		public delegate void glActiveShaderProgram(uint pipeline, uint program);

		/// <summary>
		/// Creates a program from an array of source code strings.
		/// </summary>
		/// <param name="type">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="count">The number of source code strings in <paramref name="strings"/>.</param>
		/// <param name="strings">The source code strings.</param>
		/// <returns>The name of the program.</returns>
		public delegate uint glCreateShaderProgramv(glShaderType type, int count, string[] strings);

		/// <summary>
		/// Binds a program pipeline to the current context.
		/// </summary>
		/// <param name="pipeline">The name of the pipeline.</param>
		public delegate void glBindProgramPipeline(uint pipeline);

		/// <summary>
		/// Releases <paramref name="count"/> many pipeline names.
		/// </summary>
		/// <param name="count">Number of pipeline names to be released.</param>
		/// <param name="pipelines">Array of pipeline names to be released.</param>
		public delegate void glDeleteProgramPipelines(int count, params uint[] pipelines);
		
		internal delegate void glGenProgramPipeline(int one, out uint pipeline);
		internal delegate void glGenProgramPipelines(int count, uint[] pipelines);

		/// <summary>
		/// Determines if a name is a pipeline name.
		/// </summary>
		/// <param name="pipeline">The maybe pipeline name.</param>
		/// <returns><b>true</b> if <paramref name="pipeline"/> is a pipeline name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsProgramPipeline(uint pipeline);

		/// <summary>
		/// Returns the value of a program pipeline parameter.
		/// </summary>
		/// <param name="pipeline">The name pf the pipeline.</param>
		/// <param name="pname">A <see cref="glProgramPipelineParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetProgramPipelinei(uint pipeline, glProgramPipelineParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a program pipeline parameter.
		/// </summary>
		/// <param name="pipeline">The name pf the pipeline.</param>
		/// <param name="pname">A <see cref="glProgramPipelineParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetProgramPipelineiv(uint pipeline, glProgramPipelineParameter pname, int[] @params);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glProgramUniform1i(uint program, int location, int v0);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform1iv(uint program, int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glProgramUniform1f(uint program, int location, float v0);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform1fv(uint program, int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glProgramUniform1d(uint program, int location, double v0);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform1dv(uint program, int location, int count, params double[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glProgramUniform1ui(uint program, int location, uint v0);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform1uiv(uint program, int location, int count, params uint[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glProgramUniform2i(uint program, int location, int v0, int v1);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform2iv(uint program, int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glProgramUniform2f(uint program, int location, float v0, float v1);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform2fv(uint program, int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glProgramUniform2d(uint program, int location, double v0, double v1);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform2dv(uint program, int location, int count, params double[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glProgramUniform2ui(uint program, int location, uint v0, uint v1);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform2uiv(uint program, int location, int count, params uint[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		public delegate void glProgramUniform3i(uint program, int location, int v0, int v1, int v2);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform3iv(uint program, int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		public delegate void glProgramUniform3f(uint program, int location, float v0, float v1, float v2);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform3fv(uint program, int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		public delegate void glProgramUniform3d(uint program, int location, double v0, double v1, double v2);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform3dv(uint program, int location, int count, params double[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		public delegate void glProgramUniform3ui(uint program, int location, uint v0, uint v1, uint v2);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform3uiv(uint program, int location, int count, params uint[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glProgramUniform4i(uint program, int location, int v0, int v1, int v2, int v3);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform4iv(uint program, int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glProgramUniform4f(uint program, int location, float v0, float v1, float v2, float v3);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform4fv(uint program, int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glProgramUniform4d(uint program, int location, double v0, double v1, double v2, double v3);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform4dv(uint program, int location, int count, params double[] value);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glProgramUniform4ui(uint program, int location, uint v0, uint v1, uint v2, uint v3);

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glProgramUniform4uiv(uint program, int location, int count, params uint[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2x3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3x2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2x4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4x2fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3x4fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4x3fv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2x3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3x2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix2x4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4x2dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix3x4dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glProgramUniformMatrix4x3dv(uint program, int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Validates a program pipeline against current GL state.
		/// </summary>
		/// <param name="pipeline">The name of the pipeline.</param>
		public delegate void glValidateProgramPipeline(uint pipeline);

		internal delegate void glGetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, StringBuilder infoLog);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttribL1d(uint index, double x);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttribL2d(uint index, double x, double y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttribL3d(uint index, double x, double y, double z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttribL4d(uint index, double x, double y, double z, double w);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttribL1dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribL2dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribL3dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribL4dv(uint index, double[] v);

		internal delegate void glVertexAttribLPointer_32(uint index, int size, glVertexAttribType type, int stride, int pointer);
		internal delegate void glVertexAttribLPointer_64(uint index, int size, glVertexAttribType type, int stride, long pointer);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribLd(uint index, glVertexAttribParameter pname, out double param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribLdv(uint index, glVertexAttribParameter pname, double[] @params);

		/// <summary>
		/// Sets multiple viewports at once.
		/// </summary>
		/// <param name="first">Number of the first viewport.</param>
		/// <param name="count">Number of viewport to set.</param>
		/// <param name="v">The parameter of the viewports.</param>
		public delegate void glViewportArrayv(uint first, int count, params float[] v);

		/// <summary>
		/// Sets the parameter of an indexed viewport.
		/// </summary>
		/// <param name="index">The index of the viewport.</param>
		/// <param name="x">The start position in x-direction.</param>
		/// <param name="y">The start position in y-direction.</param>
		/// <param name="width">The width of the viewport.</param>
		/// <param name="height">The height of the viewport.</param>
		public delegate void glViewportIndexedf(uint index, float x, float y, float width, float height);

		/// <summary>
		/// Sets the parameter of an indexed viewport.
		/// </summary>
		/// <param name="index">The index of the viewport.</param>
		/// <param name="v">Array with the parameters.</param>
		public delegate void glViewportIndexedfv(uint index, float[] v);

		/// <summary>
		/// Sets the scissor rectangle for multiple viewports at once.
		/// </summary>
		/// <param name="first">Number of the first viewport.</param>
		/// <param name="count">Number of scissor rectangles to set.</param>
		/// <param name="v">The parameter of the scissor rectangles.</param>
		public delegate void glScissorArrayv(uint first, int count, params int[] v);

		/// <summary>
		/// Sets the scissor rectangle for an indexed viewport.
		/// </summary>
		/// <param name="index">The index of the viewport.</param>
		/// <param name="left">Left start position of rectangle.</param>
		/// <param name="bottom">Bottom start position of rectangle.</param>
		/// <param name="width">Width of rectangle.</param>
		/// <param name="height">Height of rectangle.</param>
		public delegate void glScissorIndexed(uint index, int left, int bottom, int width, int height);

		/// <summary>
		/// Sets the scissor rectangle for an indexed viewport.
		/// </summary>
		/// <param name="index">The index of the viewport.</param>
		/// <param name="v">Array with the parameters.</param>
		public delegate void glScissorIndexedv(uint index, int[] v);

		/// <summary>
		/// Sets the depth range for multiple viewports at once.
		/// </summary>
		/// <param name="first">Number of the first viewport.</param>
		/// <param name="count">Number of depth ranges to set.</param>
		/// <param name="v">The parameter of the depth ranges.</param>
		public delegate void glDepthRangeArrayv(uint first, int count, params double[] v);

		/// <summary>
		/// Sets the depth range for an indexed viewport.
		/// </summary>
		/// <param name="index">The index of the viewport.</param>
		/// <param name="zNear">The near value.</param>
		/// <param name="zFar">The far value.</param>
		public delegate void glDepthRangeIndexed(uint index, double zNear, double zFar);

		/// <summary>
		/// Returns the value of a indexed parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatIndexedParameter"/> specifying the parameter.</param>
		/// <param name="index">The index.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetFloati_(glGetFloatIndexedParameter pname, uint index, out float param);

		/// <summary>
		/// Returns the value(s) of a indexed parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatIndexedParameter"/> specifying the parameter.</param>
		/// <param name="index">The index.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetFloati_v(glGetFloatIndexedParameter pname, uint index, float[] @params);

		/// <summary>
		/// Returns the value of a indexed parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatIndexedParameter"/> specifying the parameter.</param>
		/// <param name="index">The index.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetDoublei_(glGetFloatIndexedParameter pname, uint index, out double param);

		/// <summary>
		/// Returns the value(s) of a indexed parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatIndexedParameter"/> specifying the parameter.</param>
		/// <param name="index">The index.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetDoublei_v(glGetFloatIndexedParameter pname, uint index, double[] @params);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 4.1 is available.
		/// </summary>
		public static bool VERSION_4_1;

		#region Delegates
		/// <summary>
		/// Releases resources consumed by the shader compiler.
		/// </summary>
		public static glReleaseShaderCompiler ReleaseShaderCompiler;

		/// <summary>
		/// Loads pre-compiled shader binaries.
		/// </summary>
		public static glShaderBinary ShaderBinary;

		/// <summary>
		/// Returns the range and precision for numeric formats supported by the shader compiler.
		/// </summary>
		public static glGetShaderPrecisionFormat GetShaderPrecisionFormat;

		/// <summary>
		/// Sets the depth range.
		/// </summary>
		public static glDepthRangef DepthRangef;

		/// <summary>
		/// Sets the depth value for clear operations on depth buffers.
		/// </summary>
		public static glClearDepthf ClearDepthf;

		/// <summary>
		/// Returns the compiled binary of a program.
		/// </summary>
		public static glGetProgramBinary GetProgramBinary;

		/// <summary>
		/// Loads pre-compiled program binary.
		/// </summary>
		public static glProgramBinary ProgramBinary;

		/// <summary>
		/// Sets parameters of program objects.
		/// </summary>
		public static glProgramParameteri ProgramParameteri;

		/// <summary>
		/// Binds stages of a program object to a program pipeline.
		/// </summary>
		public static glUseProgramStages UseProgramStages;

		/// <summary>
		/// Sets the active program object for a program pipline object.
		/// </summary>
		public static glActiveShaderProgram ActiveShaderProgram;

		/// <summary>
		/// Creates a program from an array of source code strings.
		/// </summary>
		public static glCreateShaderProgramv CreateShaderProgramv;

		/// <summary>
		/// Binds a program pipeline to the current context.
		/// </summary>
		public static glBindProgramPipeline BindProgramPipeline;

		/// <summary>
		/// Releases multiple pipeline names at once.
		/// </summary>
		public static glDeleteProgramPipelines DeleteProgramPipelines;

		private static glGenProgramPipeline _GenProgramPipeline;
		private static glGenProgramPipelines _GenProgramPipelines;

		/// <summary>
		/// Determines if a name is a pipeline name.
		/// </summary>
		public static glIsProgramPipeline IsProgramPipeline;

		/// <summary>
		/// Returns the value of a program pipeline parameter.
		/// </summary>
		public static glGetProgramPipelinei GetProgramPipelinei;

		/// <summary>
		/// Returns the value(s) of a program pipeline parameter.
		/// </summary>
		public static glGetProgramPipelineiv GetProgramPipelineiv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1i ProgramUniform1i;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1iv ProgramUniform1iv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1f ProgramUniform1f;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1fv ProgramUniform1fv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1d ProgramUniform1d;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1dv ProgramUniform1dv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1ui ProgramUniform1ui;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform1uiv ProgramUniform1uiv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2i ProgramUniform2i;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2iv ProgramUniform2iv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2f ProgramUniform2f;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2fv ProgramUniform2fv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2d ProgramUniform2d;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2dv ProgramUniform2dv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2ui ProgramUniform2ui;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform2uiv ProgramUniform2uiv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3i ProgramUniform3i;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3iv ProgramUniform3iv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3f ProgramUniform3f;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3fv ProgramUniform3fv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3d ProgramUniform3d;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3dv ProgramUniform3dv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3ui ProgramUniform3ui;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform3uiv ProgramUniform3uiv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4i ProgramUniform4i;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4iv ProgramUniform4iv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4f ProgramUniform4f;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4fv ProgramUniform4fv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4d ProgramUniform4d;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4dv ProgramUniform4dv;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4ui ProgramUniform4ui;

		/// <summary>
		/// Sets a uniform value of a program.
		/// </summary>
		public static glProgramUniform4uiv ProgramUniform4uiv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2fv ProgramUniformMatrix2fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3fv ProgramUniformMatrix3fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4fv ProgramUniformMatrix4fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2dv ProgramUniformMatrix2dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3dv ProgramUniformMatrix3dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4dv ProgramUniformMatrix4dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2x3fv ProgramUniformMatrix2x3fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3x2fv ProgramUniformMatrix3x2fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2x4fv ProgramUniformMatrix2x4fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4x2fv ProgramUniformMatrix4x2fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3x4fv ProgramUniformMatrix3x4fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4x3fv ProgramUniformMatrix4x3fv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2x3dv ProgramUniformMatrix2x3dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3x2dv ProgramUniformMatrix3x2dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix2x4dv ProgramUniformMatrix2x4dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4x2dv ProgramUniformMatrix4x2dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix3x4dv ProgramUniformMatrix3x4dv;

		/// <summary>
		/// Sets a uniform matrix value of a program.
		/// </summary>
		public static glProgramUniformMatrix4x3dv ProgramUniformMatrix4x3dv;

		/// <summary>
		/// Validates a program pipeline against current GL state.
		/// </summary>
		public static glValidateProgramPipeline ValidateProgramPipeline;

		private static glGetProgramPipelineInfoLog _GetProgramPipelineInfoLog;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribL1d VertexAttribL1d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL2d VertexAttribL2d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL3d VertexAttribL3d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL4d VertexAttribL4d;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribL1dv VertexAttribL1dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL2dv VertexAttribL2dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL3dv VertexAttribL3dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribL4dv VertexAttribL4dv;

		private static glVertexAttribLPointer_32 VertexAttribLPointer_32;
		private static glVertexAttribLPointer_64 VertexAttribLPointer_64;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribLd GetVertexAttribLd;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribLdv GetVertexAttribLdv;

		/// <summary>
		/// Sets multiple viewports at once.
		/// </summary>
		public static glViewportArrayv ViewportArrayv;

		/// <summary>
		/// Sets the parameter of an indexed viewport.
		/// </summary>
		public static glViewportIndexedf ViewportIndexedf;

		/// <summary>
		/// Sets the parameter of an indexed viewport.
		/// </summary>
		public static glViewportIndexedfv ViewportIndexedfv;

		/// <summary>
		/// Sets the scissor rectangle for multiple viewports at once.
		/// </summary>
		public static glScissorArrayv ScissorArrayv;

		/// <summary>
		/// Sets the scissor rectangle for an indexed viewport.
		/// </summary>
		public static glScissorIndexed ScissorIndexed;

		/// <summary>
		/// Sets the scissor rectangle for an indexed viewport.
		/// </summary>
		public static glScissorIndexedv ScissorIndexedv;

		/// <summary>
		/// Sets the depth range for an indexed viewport.
		/// </summary>
		public static glDepthRangeArrayv DepthRangeArrayv;

		/// <summary>
		/// Sets the depth range for an indexed viewport.
		/// </summary>
		public static glDepthRangeIndexed DepthRangeIndexed;

		/// <summary>
		/// Returns the value of a indexed parameter.
		/// </summary>
		public static glGetFloati_ GetFloati_;

		/// <summary>
		/// Returns the value(s) of a indexed parameter.
		/// </summary>
		public static glGetFloati_v GetFloati_v;

		/// <summary>
		/// Returns the value of a indexed parameter.
		/// </summary>
		public static glGetDoublei_ GetDoublei_;

		/// <summary>
		/// Returns the value(s) of a indexed parameter.
		/// </summary>
		public static glGetDoublei_v GetDoublei_v;
		#endregion

		#region Overloads
		#region GenProgramPipeline(s)
		/// <summary>
		/// Generates one program pipeline name and returns it.
		/// </summary>
		/// <returns>The new program pipeline name.</returns>
		public static uint GenProgramPipeline()
		{
			uint ret;
			_GenProgramPipeline(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one program pipeline name and returns it.
		/// </summary>
		/// <param name="pipeline">The new program pipeline name.</param>
		public static void GenProgramPipeline(out uint pipeline)
		{
			_GenProgramPipeline(1, out pipeline);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many program pipeline names and returns them as array.
		/// </summary>
		/// <param name="count">The number of program pipeline names to be generated.</param>
		/// <returns>The new program pipeline names as array.</returns>
		public static uint[] GenProgramPipelines(int count)
		{
			uint[] ret=new uint[count];
			_GenProgramPipelines(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many program pipeline names.
		/// </summary>
		/// <param name="count">The number of program pipeline names to be generated.</param>
		/// <param name="pipelines">The array that will receive the new program pipeline names.</param>
		public static void GenProgramPipelines(int count, uint[] pipelines)
		{
			_GenProgramPipelines(count, pipelines);
		}
		#endregion

		#region GetProgramPipelineInfoLog
		/// <summary>
		/// Returns the log of program pipelines.
		/// </summary>
		/// <param name="pipeline">The name of the program pipeline.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="infoLog"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="infoLog"/>.</param>
		/// <param name="infoLog">Returns the name of the shader subroutine uniform.</param>
		public static void GetProgramPipelineInfoLog(uint pipeline, int bufSize, out int length, out string infoLog)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetProgramPipelineInfoLog(pipeline, bufSize+1, out length, tmp);
			infoLog=tmp.ToString();
		}
		#endregion

		#region VertexAttribLPointer
		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribLPointer(uint index, int size, glVertexAttribType type, int stride, int pointer)
		{
			if(IntPtr.Size==4) VertexAttribLPointer_32(index, size, type, stride, pointer);
			else VertexAttribLPointer_64(index, size, type, stride, pointer);
		}

		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribLPointer(uint index, int size, glVertexAttribType type, int stride, long pointer)
		{
			if(IntPtr.Size==4)
			{
				if(((long)pointer>>32)!=0) throw new ArgumentOutOfRangeException("indirect", PlatformErrorString);

				VertexAttribLPointer_32(index, size, type, stride, (int)pointer);
			}
			else VertexAttribLPointer_64(index, size, type, stride, pointer);
		}
		#endregion
		#endregion

		private static void Load_VERSION_4_1()
		{
			ReleaseShaderCompiler=GetAddress<glReleaseShaderCompiler>("glReleaseShaderCompiler");
			ShaderBinary=GetAddress<glShaderBinary>("glShaderBinary");
			GetShaderPrecisionFormat=GetAddress<glGetShaderPrecisionFormat>("glGetShaderPrecisionFormat");
			DepthRangef=GetAddress<glDepthRangef>("glDepthRangef");
			ClearDepthf=GetAddress<glClearDepthf>("glClearDepthf");
			GetProgramBinary=GetAddress<glGetProgramBinary>("glGetProgramBinary");
			ProgramBinary=GetAddress<glProgramBinary>("glProgramBinary");
			ProgramParameteri=GetAddress<glProgramParameteri>("glProgramParameteri");
			UseProgramStages=GetAddress<glUseProgramStages>("glUseProgramStages");
			ActiveShaderProgram=GetAddress<glActiveShaderProgram>("glActiveShaderProgram");
			CreateShaderProgramv=GetAddress<glCreateShaderProgramv>("glCreateShaderProgramv");
			BindProgramPipeline=GetAddress<glBindProgramPipeline>("glBindProgramPipeline");
			DeleteProgramPipelines=GetAddress<glDeleteProgramPipelines>("glDeleteProgramPipelines");
			_GenProgramPipeline=GetAddress<glGenProgramPipeline>("glGenProgramPipelines");
			_GenProgramPipelines=GetAddress<glGenProgramPipelines>("glGenProgramPipelines");
			IsProgramPipeline=GetAddress<glIsProgramPipeline>("glIsProgramPipeline");
			GetProgramPipelinei=GetAddress<glGetProgramPipelinei>("glGetProgramPipelineiv");
			GetProgramPipelineiv=GetAddress<glGetProgramPipelineiv>("glGetProgramPipelineiv");
			ProgramUniform1i=GetAddress<glProgramUniform1i>("glProgramUniform1i");
			ProgramUniform1iv=GetAddress<glProgramUniform1iv>("glProgramUniform1iv");
			ProgramUniform1f=GetAddress<glProgramUniform1f>("glProgramUniform1f");
			ProgramUniform1fv=GetAddress<glProgramUniform1fv>("glProgramUniform1fv");
			ProgramUniform1d=GetAddress<glProgramUniform1d>("glProgramUniform1d");
			ProgramUniform1dv=GetAddress<glProgramUniform1dv>("glProgramUniform1dv");
			ProgramUniform1ui=GetAddress<glProgramUniform1ui>("glProgramUniform1ui");
			ProgramUniform1uiv=GetAddress<glProgramUniform1uiv>("glProgramUniform1uiv");
			ProgramUniform2i=GetAddress<glProgramUniform2i>("glProgramUniform2i");
			ProgramUniform2iv=GetAddress<glProgramUniform2iv>("glProgramUniform2iv");
			ProgramUniform2f=GetAddress<glProgramUniform2f>("glProgramUniform2f");
			ProgramUniform2fv=GetAddress<glProgramUniform2fv>("glProgramUniform2fv");
			ProgramUniform2d=GetAddress<glProgramUniform2d>("glProgramUniform2d");
			ProgramUniform2dv=GetAddress<glProgramUniform2dv>("glProgramUniform2dv");
			ProgramUniform2ui=GetAddress<glProgramUniform2ui>("glProgramUniform2ui");
			ProgramUniform2uiv=GetAddress<glProgramUniform2uiv>("glProgramUniform2uiv");
			ProgramUniform3i=GetAddress<glProgramUniform3i>("glProgramUniform3i");
			ProgramUniform3iv=GetAddress<glProgramUniform3iv>("glProgramUniform3iv");
			ProgramUniform3f=GetAddress<glProgramUniform3f>("glProgramUniform3f");
			ProgramUniform3fv=GetAddress<glProgramUniform3fv>("glProgramUniform3fv");
			ProgramUniform3d=GetAddress<glProgramUniform3d>("glProgramUniform3d");
			ProgramUniform3dv=GetAddress<glProgramUniform3dv>("glProgramUniform3dv");
			ProgramUniform3ui=GetAddress<glProgramUniform3ui>("glProgramUniform3ui");
			ProgramUniform3uiv=GetAddress<glProgramUniform3uiv>("glProgramUniform3uiv");
			ProgramUniform4i=GetAddress<glProgramUniform4i>("glProgramUniform4i");
			ProgramUniform4iv=GetAddress<glProgramUniform4iv>("glProgramUniform4iv");
			ProgramUniform4f=GetAddress<glProgramUniform4f>("glProgramUniform4f");
			ProgramUniform4fv=GetAddress<glProgramUniform4fv>("glProgramUniform4fv");
			ProgramUniform4d=GetAddress<glProgramUniform4d>("glProgramUniform4d");
			ProgramUniform4dv=GetAddress<glProgramUniform4dv>("glProgramUniform4dv");
			ProgramUniform4ui=GetAddress<glProgramUniform4ui>("glProgramUniform4ui");
			ProgramUniform4uiv=GetAddress<glProgramUniform4uiv>("glProgramUniform4uiv");
			ProgramUniformMatrix2fv=GetAddress<glProgramUniformMatrix2fv>("glProgramUniformMatrix2fv");
			ProgramUniformMatrix3fv=GetAddress<glProgramUniformMatrix3fv>("glProgramUniformMatrix3fv");
			ProgramUniformMatrix4fv=GetAddress<glProgramUniformMatrix4fv>("glProgramUniformMatrix4fv");
			ProgramUniformMatrix2dv=GetAddress<glProgramUniformMatrix2dv>("glProgramUniformMatrix2dv");
			ProgramUniformMatrix3dv=GetAddress<glProgramUniformMatrix3dv>("glProgramUniformMatrix3dv");
			ProgramUniformMatrix4dv=GetAddress<glProgramUniformMatrix4dv>("glProgramUniformMatrix4dv");
			ProgramUniformMatrix2x3fv=GetAddress<glProgramUniformMatrix2x3fv>("glProgramUniformMatrix2x3fv");
			ProgramUniformMatrix3x2fv=GetAddress<glProgramUniformMatrix3x2fv>("glProgramUniformMatrix3x2fv");
			ProgramUniformMatrix2x4fv=GetAddress<glProgramUniformMatrix2x4fv>("glProgramUniformMatrix2x4fv");
			ProgramUniformMatrix4x2fv=GetAddress<glProgramUniformMatrix4x2fv>("glProgramUniformMatrix4x2fv");
			ProgramUniformMatrix3x4fv=GetAddress<glProgramUniformMatrix3x4fv>("glProgramUniformMatrix3x4fv");
			ProgramUniformMatrix4x3fv=GetAddress<glProgramUniformMatrix4x3fv>("glProgramUniformMatrix4x3fv");
			ProgramUniformMatrix2x3dv=GetAddress<glProgramUniformMatrix2x3dv>("glProgramUniformMatrix2x3dv");
			ProgramUniformMatrix3x2dv=GetAddress<glProgramUniformMatrix3x2dv>("glProgramUniformMatrix3x2dv");
			ProgramUniformMatrix2x4dv=GetAddress<glProgramUniformMatrix2x4dv>("glProgramUniformMatrix2x4dv");
			ProgramUniformMatrix4x2dv=GetAddress<glProgramUniformMatrix4x2dv>("glProgramUniformMatrix4x2dv");
			ProgramUniformMatrix3x4dv=GetAddress<glProgramUniformMatrix3x4dv>("glProgramUniformMatrix3x4dv");
			ProgramUniformMatrix4x3dv=GetAddress<glProgramUniformMatrix4x3dv>("glProgramUniformMatrix4x3dv");
			ValidateProgramPipeline=GetAddress<glValidateProgramPipeline>("glValidateProgramPipeline");
			_GetProgramPipelineInfoLog=GetAddress<glGetProgramPipelineInfoLog>("glGetProgramPipelineInfoLog");
			VertexAttribL1d=GetAddress<glVertexAttribL1d>("glVertexAttribL1d");
			VertexAttribL2d=GetAddress<glVertexAttribL2d>("glVertexAttribL2d");
			VertexAttribL3d=GetAddress<glVertexAttribL3d>("glVertexAttribL3d");
			VertexAttribL4d=GetAddress<glVertexAttribL4d>("glVertexAttribL4d");
			VertexAttribL1dv=GetAddress<glVertexAttribL1dv>("glVertexAttribL1dv");
			VertexAttribL2dv=GetAddress<glVertexAttribL2dv>("glVertexAttribL2dv");
			VertexAttribL3dv=GetAddress<glVertexAttribL3dv>("glVertexAttribL3dv");
			VertexAttribL4dv=GetAddress<glVertexAttribL4dv>("glVertexAttribL4dv");
			GetVertexAttribLd=GetAddress<glGetVertexAttribLd>("glGetVertexAttribLdv");
			GetVertexAttribLdv=GetAddress<glGetVertexAttribLdv>("glGetVertexAttribLdv");
			ViewportArrayv=GetAddress<glViewportArrayv>("glViewportArrayv");
			ViewportIndexedf=GetAddress<glViewportIndexedf>("glViewportIndexedf");
			ViewportIndexedfv=GetAddress<glViewportIndexedfv>("glViewportIndexedfv");
			ScissorArrayv=GetAddress<glScissorArrayv>("glScissorArrayv");
			ScissorIndexed=GetAddress<glScissorIndexed>("glScissorIndexed");
			ScissorIndexedv=GetAddress<glScissorIndexedv>("glScissorIndexedv");
			DepthRangeArrayv=GetAddress<glDepthRangeArrayv>("glDepthRangeArrayv");
			DepthRangeIndexed=GetAddress<glDepthRangeIndexed>("glDepthRangeIndexed");
			GetFloati_=GetAddress<glGetFloati_>("glGetFloati_v");
			GetFloati_v=GetAddress<glGetFloati_v>("glGetFloati_v");
			GetDoublei_=GetAddress<glGetDoublei_>("glGetDoublei_v");
			GetDoublei_v=GetAddress<glGetDoublei_v>("glGetDoublei_v");

			if(IntPtr.Size==4) VertexAttribLPointer_32=GetAddress<glVertexAttribLPointer_32>("glVertexAttribLPointer");
			else VertexAttribLPointer_64=GetAddress<glVertexAttribLPointer_64>("glVertexAttribLPointer");
			bool platformDependend=VertexAttribLPointer_32!=null||VertexAttribLPointer_64!=null;

			VERSION_4_1=VERSION_4_0&&ReleaseShaderCompiler!=null&&ShaderBinary!=null&&GetShaderPrecisionFormat!=null&&
				DepthRangef!=null&&ClearDepthf!=null&&GetProgramBinary!=null&&ProgramBinary!=null&&ProgramParameteri!=null&&
				UseProgramStages!=null&&ActiveShaderProgram!=null&&CreateShaderProgramv!=null&&BindProgramPipeline!=null&&
				DeleteProgramPipelines!=null&&_GenProgramPipelines!=null&&IsProgramPipeline!=null&&GetProgramPipelineiv!=null&&
				ProgramUniform1iv!=null&&ProgramUniform1fv!=null&&ProgramUniform1dv!=null&&ProgramUniform1uiv!=null&&
				ProgramUniform2iv!=null&&ProgramUniform2fv!=null&&ProgramUniform2dv!=null&&ProgramUniform2uiv!=null&&
				ProgramUniform3iv!=null&&ProgramUniform3fv!=null&&ProgramUniform3dv!=null&&ProgramUniform3uiv!=null&&
				ProgramUniform4iv!=null&&ProgramUniform4fv!=null&&ProgramUniform4dv!=null&&ProgramUniform4uiv!=null&&
				ProgramUniformMatrix4fv!=null&&ProgramUniformMatrix3fv!=null&&ProgramUniformMatrix4fv!=null&&
				ProgramUniformMatrix2dv!=null&&ProgramUniformMatrix3dv!=null&&ProgramUniformMatrix4dv!=null&&
				ProgramUniformMatrix2x3fv!=null&&ProgramUniformMatrix3x2fv!=null&&ProgramUniformMatrix2x4fv!=null&&
				ProgramUniformMatrix4x2fv!=null&&ProgramUniformMatrix3x4fv!=null&&ProgramUniformMatrix4x3fv!=null&&
				ProgramUniformMatrix2x3dv!=null&&ProgramUniformMatrix3x2dv!=null&&ProgramUniformMatrix2x4dv!=null&&
				ProgramUniformMatrix4x2dv!=null&&ProgramUniformMatrix3x4dv!=null&&ProgramUniformMatrix4x3dv!=null&&
				ValidateProgramPipeline!=null&&_GetProgramPipelineInfoLog!=null&&VertexAttribL4d!=null&&
				VertexAttribL4dv!=null&&GetVertexAttribLdv!=null&&ViewportArrayv!=null&&ViewportIndexedf!=null&&
				ViewportIndexedfv!=null&&ScissorArrayv!=null&&ScissorIndexed!=null&&ScissorIndexedv!=null&&
				DepthRangeArrayv!=null&&DepthRangeIndexed!=null&&GetFloati_v!=null&&GetDoublei_v!=null&&platformDependend;
		}
	}
}
