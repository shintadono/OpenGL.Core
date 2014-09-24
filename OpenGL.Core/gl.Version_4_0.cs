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

using System.Runtime.InteropServices;
using System.Text;

namespace OpenGL.Core
{
	using Delegates;

	namespace Delegates
	{
		/// <summary>
		/// Sets the minimum rate at which sample shaing takes place.
		/// </summary>
		/// <param name="value">The rate at which samples are shaded within each covered pixel.</param>
		public delegate void glMinSampleShading(float value);

		/// <summary>
		/// Sets the equation for blending of color and alpha values.
		/// </summary>
		/// <param name="buf">The index of the draw buffer.</param>
		/// <param name="mode">A <see cref="glBlendEquationMode"/> specifying the blend equation.</param>
		public delegate void glBlendEquationi(uint buf, glBlendEquationMode mode);

		/// <summary>
		/// Sets the blend equation separately for color and alpha.
		/// </summary>
		/// <param name="buf">The index of the draw buffer.</param>
		/// <param name="modeRGB">A <see cref="glBlendEquationMode"/> specifying the color blend equation.</param>
		/// <param name="modeAlpha">A <see cref="glBlendEquationMode"/> specifying the alpha blend equation.</param>
		public delegate void glBlendEquationSeparatei(uint buf, glBlendEquationMode modeRGB, glBlendEquationMode modeAlpha);

		/// <summary>
		/// Sets the blend function factors.
		/// </summary>
		/// <param name="buf">The index of the draw buffer.</param>
		/// <param name="sfactor">Factor to the source value.</param>
		/// <param name="dfactor">Factor to the destination value.</param>
		public delegate void glBlendFunci(uint buf, glBlendFuncFactor sfactor, glBlendFuncFactor dfactor);

		/// <summary>
		/// Sets the blend function factors separately for color and alpha.
		/// </summary>
		/// <param name="buf">The index of the draw buffer.</param>
		/// <param name="srcRGB">Factor to the source color value.</param>
		/// <param name="dstRGB">Factor to the destination color value.</param>
		/// <param name="srcAlpha">Factor to the source alpha value.</param>
		/// <param name="dstAlpha">Factor to the destination alpha value.</param>
		public delegate void glBlendFuncSeparatei(uint buf, glBlendFuncFactor srcRGB, glBlendFuncFactor dstRGB, glBlendFuncFactor srcAlpha, glBlendFuncFactor dstAlpha);

		/// <summary>
		/// Renders primitives from array, taking parameters from memory.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="indirect">The structure containing the draw parameters. (<b>ref</b> for <c>const glDrawArraysIndirectCommand*</c>)</param>
		public delegate void glDrawArraysIndirect(glDrawMode mode, ref glDrawArraysIndirectCommand indirect);

		/// <summary>
		/// Renders primitives from array via indices, taking parameters from memory.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indirect">The structure containing the draw parameters. (<b>ref</b> for <c>const glDrawElementsIndirectCommand*</c>)</param>
		public delegate void glDrawElementsIndirect(glDrawMode mode, glDrawElementsType type, ref glDrawElementsIndirectCommand indirect);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glUniform1d(int location, double x);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="x">First value of a tuple to set.</param>
		/// <param name="y">Second value of a tuple to set.</param>
		public delegate void glUniform2d(int location, double x, double y);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="x">First value of a tuple to set.</param>
		/// <param name="y">Second value of a tuple to set.</param>
		/// <param name="z">Third value of a tuple to set.</param>
		public delegate void glUniform3d(int location, double x, double y, double z);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="x">First value of a tuple to set.</param>
		/// <param name="y">Second value of a tuple to set.</param>
		/// <param name="z">Third value of a tuple to set.</param>
		/// <param name="w">Fourth value of a tuple to set.</param>
		public delegate void glUniform4d(int location, double x, double y, double z, double w);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform1dv(int location, int count, double[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform2dv(int location, int count, double[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform3dv(int location, int count, double[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform4dv(int location, int count, double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2x3dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2x4dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3x2dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3x4dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4x2dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4x3dv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params double[] value);

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="param">The value of the uniform variable.</param>
		public delegate void glGetUniformd(uint program, int location, out double param);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetUniformdv(uint program, int location, double[] @params);

		/// <summary>
		/// Returns the location of a shader subroutine.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="name">The name of the subroutine.</param>
		/// <returns>The location of a subroutine uniform.</returns>
		public delegate int glGetSubroutineUniformLocation(uint program, glShaderType shadertype, string name);

		/// <summary>
		/// Returns the index of a shader subroutine.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="name">The name of the subroutine.</param>
		/// <returns>The index of a subroutine.</returns>
		public delegate uint glGetSubroutineIndex(uint program, glShaderType shadertype, string name);

		/// <summary>
		/// Returns the value of a parameter of an active shader subroutine uniform.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="index">The location of the active shader subroutine uniform.</param>
		/// <param name="pname">A <see cref="glSubroutineUniformParameter"/> specifying the parameter.</param>
		/// <param name="value">The requested value.</param>
		public delegate void glGetActiveSubroutineUniformi(uint program, glShaderType shadertype, uint index, glSubroutineUniformParameter pname, out int value);

		/// <summary>
		/// Returns the value(s) of a parameter of an active shader subroutine uniform.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="index">The location of the active shader subroutine uniform.</param>
		/// <param name="pname">A <see cref="glSubroutineUniformParameter"/> specifying the parameter.</param>
		/// <param name="values">The requested value(s).</param>
		public delegate void glGetActiveSubroutineUniformiv(uint program, glShaderType shadertype, uint index, glSubroutineUniformParameter pname, int[] values);

		internal delegate void glGetActiveSubroutineUniformName(uint program, glShaderType shadertype, uint index, int bufsize, out int length, StringBuilder name);
		internal delegate void glGetActiveSubroutineName(uint program, glShaderType shadertype, uint index, int bufsize, out int length, StringBuilder name);

		/// <summary>
		/// Loads indices into the active subroutine's uniforms.
		/// </summary>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="count">The number of indices to load.</param>
		/// <param name="indices">The array of indices.</param>
		public delegate void glUniformSubroutinesuiv(glShaderType shadertype, int count, params uint[] indices);

		/// <summary>
		/// Returns the value of a subroutine uniform of a given shader stage of the current program.
		/// </summary>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="location">The location of the subroutine uniform.</param>
		/// <param name="value">The requested value.</param>
		public delegate void glGetUniformSubroutineui(glShaderType shadertype, int location, out uint value);

		/// <summary>
		/// Returns the value(s) of a subroutine uniform of a given shader stage of the current program.
		/// </summary>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="location">The location of the subroutine uniform.</param>
		/// <param name="values">The requested value(s).</param>
		public delegate void glGetUniformSubroutineuiv(glShaderType shadertype, int location, uint[] values);

		/// <summary>
		/// Returns the value of parameter of a program shader stage.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the shader stage.</param>
		/// <param name="pname">A <see cref="glProgramStageParameter"/> specifying the parameter.</param>
		/// <param name="value">The requested value.</param>
		public delegate void glGetProgramStagei(uint program, glShaderType shadertype, glProgramStageParameter pname, out int value);

		/// <summary>
		/// Returns the value(s) of parameter of a program shader stage.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the shader stage.</param>
		/// <param name="pname">A <see cref="glProgramStageParameter"/> specifying the parameter.</param>
		/// <param name="values">The requested value(s).</param>
		public delegate void glGetProgramStageiv(uint program, glShaderType shadertype, glProgramStageParameter pname, int[] values);

		/// <summary>
		/// Sets patch parameters.
		/// </summary>
		/// <param name="pname">A <see cref="glPatchParameter"/> specifying the parameter.</param>
		/// <param name="value">The value to set.</param>
		public delegate void glPatchParameteri(glPatchParameter pname, int value);

		/// <summary>
		/// Sets patch parameters.
		/// </summary>
		/// <param name="pname">A <see cref="glPatchParameter"/> specifying the parameter.</param>
		/// <param name="values">The values to set.</param>
		public delegate void glPatchParameterfv(glPatchParameter pname, float[] values);

		/// <summary>
		/// Binds a transform feedback object.
		/// </summary>
		/// <param name="target">Must be <see cref="glTransformFeedbackTarget.TRANSFORM_FEEDBACK"/>.</param>
		/// <param name="id">The name of the transform feedback object.</param>
		public delegate void glBindTransformFeedback(glTransformFeedbackTarget target, uint id);

		/// <summary>
		/// Releases <paramref name="count"/> many transform feedback object names.
		/// </summary>
		/// <param name="count">Number of transform feedback object names to be released.</param>
		/// <param name="ids">Array of transform feedback object names to be released.</param>
		public delegate void glDeleteTransformFeedbacks(int count, params uint[] ids);

		internal delegate void glGenTransformFeedback(int one, out uint id);
		internal delegate void glGenTransformFeedbacks(int count, uint[] ids);

		/// <summary>
		/// Determines if a name is a transform feedback object name.
		/// </summary>
		/// <param name="id">The maybe transform feedback object name.</param>
		/// <returns><b>true</b> if <paramref name="id"/> is a transform feedback object name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsTransformFeedback(uint id);

		/// <summary>
		/// Pauses transform feedback operations.
		/// </summary>
		public delegate void glPauseTransformFeedback();

		/// <summary>
		/// Resumes transform feedback operations.
		/// </summary>
		public delegate void glResumeTransformFeedback();

		/// <summary>
		/// Renders primitives using the count derived from transform feedback objects.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitives to render.</param>
		/// <param name="id">The name of the transform feedback object.</param>
		public delegate void glDrawTransformFeedback(glDrawMode mode, uint id);

		/// <summary>
		/// Renders primitives using the count derived from a specific stream of transform feedback objects.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitives to render.</param>
		/// <param name="id">The name of the transform feedback object.</param>
		/// <param name="stream">The index of the stream.</param>
		public delegate void glDrawTransformFeedbackStream(glDrawMode mode, uint id, uint stream);

		/// <summary>
		/// Delimits the boundary of a query object on an indexed target.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="index">The index of the indexed target.</param>
		/// <param name="id">The query-ID to be used.</param>
		public delegate void glBeginQueryIndexed(glQueryTarget target, uint index, uint id);

		/// <summary>
		/// Delimits the boundary of a query object on an indexed target.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="index">The index of the indexed target.</param>
		public delegate void glEndQueryIndexed(glQueryTarget target, uint index);

		/// <summary>
		/// Returns the parameters of a query type on an indexed target.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="index">The index of the indexed target.</param>
		/// <param name="pname">A <see cref="glQueryParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetQueryIndexedi(glQueryTarget target, uint index, glQueryParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of a query type on an indexed target.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="index">The index of the indexed target.</param>
		/// <param name="pname">A <see cref="glQueryParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetQueryIndexediv(glQueryTarget target, uint index, glQueryParameter pname, int[] @params);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 4.0 is available.
		/// </summary>
		public static bool VERSION_4_0;

		#region Delegates
		/// <summary>
		/// Sets the minimum rate at which sample shaing takes place.
		/// </summary>
		public static glMinSampleShading MinSampleShading;

		/// <summary>
		/// Sets the equation for blending of color and alpha values.
		/// </summary>
		public static glBlendEquationi BlendEquationi;

		/// <summary>
		/// Sets the blend equation separately for color and alpha.
		/// </summary>
		public static glBlendEquationSeparatei BlendEquationSeparatei;

		/// <summary>
		/// Sets the blend function factors.
		/// </summary>
		public static glBlendFunci BlendFunci;

		/// <summary>
		/// Sets the blend function factors separately for color and alpha.
		/// </summary>
		public static glBlendFuncSeparatei BlendFuncSeparatei;

		/// <summary>
		/// Renders primitives from array, taking parameters from memory.
		/// </summary>
		public static glDrawArraysIndirect DrawArraysIndirect;

		/// <summary>
		/// Renders primitives from array via indices, taking parameters from memory.
		/// </summary>
		public static glDrawElementsIndirect DrawElementsIndirect;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1d Uniform1d;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2d Uniform2d;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3d Uniform3d;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4d Uniform4d;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1dv Uniform1dv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2dv Uniform2dv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3dv Uniform3dv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4dv Uniform4dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2dv UniformMatrix2dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3dv UniformMatrix3dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4dv UniformMatrix4dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2x3dv UniformMatrix2x3dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2x4dv UniformMatrix2x4dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3x2dv UniformMatrix3x2dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3x4dv UniformMatrix3x4dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4x2dv UniformMatrix4x2dv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4x3dv UniformMatrix4x3dv;

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		public static glGetUniformd GetUniformd;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetUniformdv GetUniformdv;

		/// <summary>
		/// Returns the location of a shader subroutine.
		/// </summary>
		public static glGetSubroutineUniformLocation GetSubroutineUniformLocation;

		/// <summary>
		/// Returns the index of a shader subroutine.
		/// </summary>
		public static glGetSubroutineIndex GetSubroutineIndex;

		/// <summary>
		/// Returns the value of a parameter of an active shader subroutine uniform.
		/// </summary>
		public static glGetActiveSubroutineUniformi GetActiveSubroutineUniformi;

		/// <summary>
		/// Returns the value(s) of a parameter of an active shader subroutine uniform.
		/// </summary>
		public static glGetActiveSubroutineUniformiv GetActiveSubroutineUniformiv;

		private static glGetActiveSubroutineUniformName _GetActiveSubroutineUniformName;
		private static glGetActiveSubroutineName _GetActiveSubroutineName;

		/// <summary>
		/// Loads indices into the active subroutine's uniforms.
		/// </summary>
		public static glUniformSubroutinesuiv UniformSubroutinesuiv;

		/// <summary>
		/// Returns the value of a subroutine uniform of a given shader stage of the current program.
		/// </summary>
		public static glGetUniformSubroutineui GetUniformSubroutineui;

		/// <summary>
		/// Returns the value(s) of a subroutine uniform of a given shader stage of the current program.
		/// </summary>
		public static glGetUniformSubroutineuiv GetUniformSubroutineuiv;

		/// <summary>
		/// Returns the value of parameter of a program shader stage.
		/// </summary>
		public static glGetProgramStagei GetProgramStagei;

		/// <summary>
		/// Returns the value(s) of parameter of a program shader stage.
		/// </summary>
		public static glGetProgramStageiv GetProgramStageiv;

		/// <summary>
		/// Sets patch parameters.
		/// </summary>
		public static glPatchParameteri PatchParameteri;

		/// <summary>
		/// Sets patch parameters.
		/// </summary>
		public static glPatchParameterfv PatchParameterfv;

		/// <summary>
		/// Binds a transform feedback object.
		/// </summary>
		public static glBindTransformFeedback BindTransformFeedback;

		/// <summary>
		/// Releases multiple transform feedback object names at once.
		/// </summary>
		public static glDeleteTransformFeedbacks DeleteTransformFeedbacks;

		private static glGenTransformFeedback _GenTransformFeedback;
		private static glGenTransformFeedbacks _GenTransformFeedbacks;

		/// <summary>
		/// Determines if a name is a transform feedback object name.
		/// </summary>
		public static glIsTransformFeedback IsTransformFeedback;

		/// <summary>
		/// Pauses transform feedback operations.
		/// </summary>
		public static glPauseTransformFeedback PauseTransformFeedback;

		/// <summary>
		/// Resumes transform feedback operations.
		/// </summary>
		public static glResumeTransformFeedback ResumeTransformFeedback;

		/// <summary>
		/// Renders primitives using the count derived from transform feedback objects.
		/// </summary>
		public static glDrawTransformFeedback DrawTransformFeedback;

		/// <summary>
		/// Renders primitives using the count derived from a specific stream of transform feedback objects.
		/// </summary>
		public static glDrawTransformFeedbackStream DrawTransformFeedbackStream;

		/// <summary>
		/// Delimits the boundary of a query object on an indexed target.
		/// </summary>
		public static glBeginQueryIndexed BeginQueryIndexed;

		/// <summary>
		/// Delimits the boundary of a query object on an indexed target.
		/// </summary>
		public static glEndQueryIndexed EndQueryIndexed;

		/// <summary>
		/// Returns the parameters of a query type on an indexed target.
		/// </summary>
		public static glGetQueryIndexedi GetQueryIndexedi;

		/// <summary>
		/// Returns the parameters of a query type on an indexed target.
		/// </summary>
		public static glGetQueryIndexediv GetQueryIndexediv;
		#endregion

		#region Overloads
		#region GetActiveSubroutineUniformName
		/// <summary>
		/// Returns the name of an active shader subroutine uniform.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="index">The index of the shader subroutine uniform.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="name"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="name"/>.</param>
		/// <param name="name">Returns the name of the shader subroutine uniform.</param>
		public static void GetActiveSubroutineUniformName(uint program, glShaderType shadertype, uint index, int bufSize, out int length, out string name)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetActiveSubroutineUniformName(program, shadertype, index, bufSize+1, out length, tmp);
			name=tmp.ToString();
		}
		#endregion

		#region GetActiveSubroutineName
		/// <summary>
		/// Returns the name of an active shader subroutine.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shadertype">A <see cref="glShaderType"/> specifying the type of the shader.</param>
		/// <param name="index">The index of the shader subroutine.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="name"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="name"/>.</param>
		/// <param name="name">Returns the name of the shader subroutine.</param>
		public static void GetActiveSubroutineName(uint program, glShaderType shadertype, uint index, int bufSize, out int length, out string name)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetActiveSubroutineName(program, shadertype, index, bufSize+1, out length, tmp);
			name=tmp.ToString();
		}
		#endregion

		#region GenTransformFeedback(s)
		/// <summary>
		/// Generates one transform feedback object name and returns it.
		/// </summary>
		/// <returns>The new transform feedback object name.</returns>
		public static uint GenTransformFeedback()
		{
			uint ret;
			_GenTransformFeedback(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one transform feedback object name and returns it.
		/// </summary>
		/// <param name="id">The new transform feedback object name.</param>
		public static void GenTransformFeedback(out uint id)
		{
			_GenTransformFeedback(1, out id);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many transform feedback object names and returns them as array.
		/// </summary>
		/// <param name="count">The number of transform feedback object names to be generated.</param>
		/// <returns>The new transform feedback object names as array.</returns>
		public static uint[] GenTransformFeedbacks(int count)
		{
			uint[] ret=new uint[count];
			_GenTransformFeedbacks(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many transform feedback object names.
		/// </summary>
		/// <param name="count">The number of transform feedback object names to be generated.</param>
		/// <param name="ids">The array that will receive the new transform feedback object names.</param>
		public static void GenTransformFeedbacks(int count, uint[] ids)
		{
			_GenTransformFeedbacks(count, ids);
		}
		#endregion
		#endregion

		private static void Load_VERSION_4_0()
		{
			MinSampleShading=GetAddress<glMinSampleShading>("glMinSampleShading");
			BlendEquationi=GetAddress<glBlendEquationi>("glBlendEquationi");
			BlendEquationSeparatei=GetAddress<glBlendEquationSeparatei>("glBlendEquationSeparatei");
			BlendFunci=GetAddress<glBlendFunci>("glBlendFunci");
			BlendFuncSeparatei=GetAddress<glBlendFuncSeparatei>("glBlendFuncSeparatei");
			DrawArraysIndirect=GetAddress<glDrawArraysIndirect>("glDrawArraysIndirect");
			DrawElementsIndirect=GetAddress<glDrawElementsIndirect>("glDrawElementsIndirect");
			Uniform1d=GetAddress<glUniform1d>("glUniform1d");
			Uniform2d=GetAddress<glUniform2d>("glUniform2d");
			Uniform3d=GetAddress<glUniform3d>("glUniform3d");
			Uniform4d=GetAddress<glUniform4d>("glUniform4d");
			Uniform1dv=GetAddress<glUniform1dv>("glUniform1dv");
			Uniform2dv=GetAddress<glUniform2dv>("glUniform2dv");
			Uniform3dv=GetAddress<glUniform3dv>("glUniform3dv");
			Uniform4dv=GetAddress<glUniform4dv>("glUniform4dv");
			UniformMatrix2dv=GetAddress<glUniformMatrix2dv>("glUniformMatrix2dv");
			UniformMatrix3dv=GetAddress<glUniformMatrix3dv>("glUniformMatrix3dv");
			UniformMatrix4dv=GetAddress<glUniformMatrix4dv>("glUniformMatrix4dv");
			UniformMatrix2x3dv=GetAddress<glUniformMatrix2x3dv>("glUniformMatrix2x3dv");
			UniformMatrix2x4dv=GetAddress<glUniformMatrix2x4dv>("glUniformMatrix2x4dv");
			UniformMatrix3x2dv=GetAddress<glUniformMatrix3x2dv>("glUniformMatrix3x2dv");
			UniformMatrix3x4dv=GetAddress<glUniformMatrix3x4dv>("glUniformMatrix3x4dv");
			UniformMatrix4x2dv=GetAddress<glUniformMatrix4x2dv>("glUniformMatrix4x2dv");
			UniformMatrix4x3dv=GetAddress<glUniformMatrix4x3dv>("glUniformMatrix4x3dv");
			GetUniformd=GetAddress<glGetUniformd>("glGetUniformdv");
			GetUniformdv=GetAddress<glGetUniformdv>("glGetUniformdv");
			GetSubroutineUniformLocation=GetAddress<glGetSubroutineUniformLocation>("glGetSubroutineUniformLocation");
			GetSubroutineIndex=GetAddress<glGetSubroutineIndex>("glGetSubroutineIndex");
			GetActiveSubroutineUniformi=GetAddress<glGetActiveSubroutineUniformi>("glGetActiveSubroutineUniformiv");
			GetActiveSubroutineUniformiv=GetAddress<glGetActiveSubroutineUniformiv>("glGetActiveSubroutineUniformiv");
			_GetActiveSubroutineUniformName=GetAddress<glGetActiveSubroutineUniformName>("glGetActiveSubroutineUniformName");
			_GetActiveSubroutineName=GetAddress<glGetActiveSubroutineName>("glGetActiveSubroutineName");
			UniformSubroutinesuiv=GetAddress<glUniformSubroutinesuiv>("glUniformSubroutinesuiv");
			GetUniformSubroutineui=GetAddress<glGetUniformSubroutineui>("glGetUniformSubroutineuiv");
			GetUniformSubroutineuiv=GetAddress<glGetUniformSubroutineuiv>("glGetUniformSubroutineuiv");
			GetProgramStagei=GetAddress<glGetProgramStagei>("glGetProgramStageiv");
			GetProgramStageiv=GetAddress<glGetProgramStageiv>("glGetProgramStageiv");
			PatchParameteri=GetAddress<glPatchParameteri>("glPatchParameteri");
			PatchParameterfv=GetAddress<glPatchParameterfv>("glPatchParameterfv");
			BindTransformFeedback=GetAddress<glBindTransformFeedback>("glBindTransformFeedback");
			DeleteTransformFeedbacks=GetAddress<glDeleteTransformFeedbacks>("glDeleteTransformFeedbacks");
			_GenTransformFeedback=GetAddress<glGenTransformFeedback>("glGenTransformFeedbacks");
			_GenTransformFeedbacks=GetAddress<glGenTransformFeedbacks>("glGenTransformFeedbacks");
			IsTransformFeedback=GetAddress<glIsTransformFeedback>("glIsTransformFeedback");
			PauseTransformFeedback=GetAddress<glPauseTransformFeedback>("glPauseTransformFeedback");
			ResumeTransformFeedback=GetAddress<glResumeTransformFeedback>("glResumeTransformFeedback");
			DrawTransformFeedback=GetAddress<glDrawTransformFeedback>("glDrawTransformFeedback");
			DrawTransformFeedbackStream=GetAddress<glDrawTransformFeedbackStream>("glDrawTransformFeedbackStream");
			BeginQueryIndexed=GetAddress<glBeginQueryIndexed>("glBeginQueryIndexed");
			EndQueryIndexed=GetAddress<glEndQueryIndexed>("glEndQueryIndexed");
			GetQueryIndexedi=GetAddress<glGetQueryIndexedi>("glGetQueryIndexediv");
			GetQueryIndexediv=GetAddress<glGetQueryIndexediv>("glGetQueryIndexediv");

			VERSION_4_0=VERSION_3_3&&MinSampleShading!=null&&BlendEquationi!=null&&BlendEquationSeparatei!=null&&
				BlendFunci!=null&&BlendFuncSeparatei!=null&&DrawArraysIndirect!=null&&DrawElementsIndirect!=null&&
				Uniform1d!=null&&Uniform2d!=null&&Uniform3d!=null&&Uniform4d!=null&&
				Uniform1dv!=null&&Uniform2dv!=null&&Uniform3dv!=null&&Uniform4dv!=null&&
				UniformMatrix2dv!=null&&UniformMatrix3dv!=null&&UniformMatrix4dv!=null&&
				UniformMatrix2x3dv!=null&&UniformMatrix2x4dv!=null&&UniformMatrix3x2dv!=null&&
				UniformMatrix3x4dv!=null&&UniformMatrix4x2dv!=null&&UniformMatrix4x3dv!=null&&
				GetUniformdv!=null&&GetSubroutineUniformLocation!=null&&GetSubroutineIndex!=null&&
				GetActiveSubroutineUniformiv!=null&&_GetActiveSubroutineUniformName!=null&&
				_GetActiveSubroutineName!=null&&UniformSubroutinesuiv!=null&&GetUniformSubroutineuiv!=null&&
				GetProgramStageiv!=null&&PatchParameteri!=null&&PatchParameterfv!=null&&
				BindTransformFeedback!=null&&DeleteTransformFeedbacks!=null&&_GenTransformFeedbacks!=null&&
				IsTransformFeedback!=null&&PauseTransformFeedback!=null&&ResumeTransformFeedback!=null&&
				DrawTransformFeedback!=null&&DrawTransformFeedbackStream!=null&&BeginQueryIndexed!=null&&
				EndQueryIndexed!=null&&GetQueryIndexediv!=null;
		}
	}
}
