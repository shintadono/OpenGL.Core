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
		/// Sets the blend equation separately for color and alpha.
		/// </summary>
		/// <param name="modeRGB">A <see cref="glBlendEquationMode"/> specifying the color blend equation.</param>
		/// <param name="modeAlpha">A <see cref="glBlendEquationMode"/> specifying the alpha blend equation.</param>
		public delegate void glBlendEquationSeparate(glBlendEquationMode modeRGB, glBlendEquationMode modeAlpha);

		/// <summary>
		/// Sets the buffers to be drawn into.
		/// </summary>
		/// <param name="count">Number of buffers.</param>
		/// <param name="bufs">A array of <see cref="glBuffer"/>s specifying the buffers.</param>
		public delegate void glDrawBuffers(int count, params glBuffer[] bufs);

		/// <summary>
		/// Sets the front and/or back face stencil operation.
		/// </summary>
		/// <param name="face">A <see cref="glFace"/> specifying the face(s).</param>
		/// <param name="sfail">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil test fails.</param>
		/// <param name="dpfail">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil test passed, but the depth test fails.</param>
		/// <param name="dppass">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil and depth test passes.</param>
		public delegate void glStencilOpSeparate(glFace face, glStencilOpMode sfail, glStencilOpMode dpfail, glStencilOpMode dppass);

		/// <summary>
		/// Sets the front and/or back face stencil test function.
		/// </summary>
		/// <param name="face">A <see cref="glFace"/> specifying the face(s).</param>
		/// <param name="func">A <see cref="glFunc"/> specifying the test function.</param>
		/// <param name="ref">The reference value.</param>
		/// <param name="mask">The bitmask for the operation.</param>
		public delegate void glStencilFuncSeparate(glFace face, glFunc func, int @ref, uint mask);

		/// <summary>
		/// Sets the front and/or back face stencil mask for stencil write operations.
		/// </summary>
		/// <param name="face">A <see cref="glFace"/> specifying the face(s).</param>
		/// <param name="mask">The bitmask.</param>
		public delegate void glStencilMaskSeparate(glFace face, uint mask);

		/// <summary>
		/// Attaches a shader to a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shader">The name of the shader.</param>
		public delegate void glAttachShader(uint program, uint shader);

		/// <summary>
		/// Binds a vertex attribute index to a named attribute vertex shader variable.
		/// </summary>
		/// <param name="program"></param>
		/// <param name="index">The attribute index to be bound.</param>
		/// <param name="name">The name of the vertex shader variable.</param>
		public delegate void glBindAttribLocation(uint program, uint index, string name);

		/// <summary>
		/// Compiles a shader.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		public delegate void glCompileShader(uint shader);

		/// <summary>
		/// Creates a program and returns the name of the program.
		/// </summary>
		/// <returns>The name of the program.</returns>
		public delegate uint glCreateProgram();

		/// <summary>
		/// Creates a shader of a specific type and returns the name of the shader object.
		/// </summary>
		/// <param name="type">A <see cref="glShaderType"/> specifying the shader type.</param>
		/// <returns>The name of the shader object.</returns>
		public delegate uint glCreateShader(glShaderType type);

		/// <summary>
		/// Releases/Destroys a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		public delegate void glDeleteProgram(uint program);

		/// <summary>
		/// Releases/Destroys a shader.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		public delegate void glDeleteShader(uint shader);

		/// <summary>
		/// Detaches a shader from a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="shader">The name of the shader.</param>
		public delegate void glDetachShader(uint program, uint shader);

		/// <summary>
		/// Disables a vertex attribute array.
		/// </summary>
		/// <param name="index">The index of the vertex attribute array.</param>
		public delegate void glDisableVertexAttribArray(uint index);

		/// <summary>
		/// Enables a vertex attribute array.
		/// </summary>
		/// <param name="index">The index of the vertex attribute array.</param>
		public delegate void glEnableVertexAttribArray(uint index);

		internal delegate void glGetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out glGLSLType type, StringBuilder name);
		internal delegate void glGetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, out glGLSLType type, StringBuilder name);

		/// <summary>
		/// Returns the attached shaders of a program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="maxCount">The maximum number of shader names to be returned. (Size of the <paramref name="obj"/> array.)</param>
		/// <param name="count">Returns the number of actual returned shader names.</param>
		/// <param name="obj">Returns the shader names.</param>
		public delegate void glGetAttachedShaders(uint program, int maxCount, out int count, uint[] obj);

		/// <summary>
		/// Returns the location of a vertex attribute that is bound to a named attribute variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="name">The name of the attribute variable.</param>
		/// <returns>The index of the vertex attribute.</returns>
		public delegate int glGetAttribLocation(uint program, string name);

		/// <summary>
		/// Returns the parameters of program object.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="pname">A <see cref="glProgramParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetProgrami(uint program, glProgramParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of program object.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="pname">A <see cref="glProgramParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetProgramiv(uint program, glProgramParameter pname, int[] @params);

		internal delegate void glGetProgramInfoLog(uint program, int maxLength, out int length, StringBuilder infoLog);

		/// <summary>
		/// Returns the parameters of shader object.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="pname">A <see cref="glShaderParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetShaderi(uint shader, glShaderParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of shader object.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="pname">A <see cref="glShaderParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public delegate void glGetShaderiv(uint shader, glShaderParameter pname, int[] @params);

		internal delegate void glGetShaderInfoLog(uint shader, int bufSize, out int length, StringBuilder infoLog);
		internal delegate void glGetShaderSource(uint shader, int bufSize, out int length, StringBuilder source);

		/// <summary>
		/// Returns the location of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="name">The name of the uniform variable.</param>
		/// <returns>The location of the uniform variable inside the program object.</returns>
		public delegate int glGetUniformLocation(uint program, string name);

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="param">The value of the uniform variable.</param>
		public delegate void glGetUniformf(uint program, int location, out float param);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetUniformfv(uint program, int location, float[] @params);

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="param">The value of the uniform variable.</param>
		public delegate void glGetUniformi(uint program, int location, out int param);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetUniformiv(uint program, int location, int[] @params);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribd(uint index, glVertexAttribParameter pname, out double param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribdv(uint index, glVertexAttribParameter pname, double[] @params);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribf(uint index, glVertexAttribParameter pname, out float param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribfv(uint index, glVertexAttribParameter pname, float[] @params);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribi(uint index, glVertexAttribParameter pname, out int param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribiv(uint index, glVertexAttribParameter pname, int[] @params);

		internal delegate void glGetVertexAttribPointerv_32(uint index, glVertexAttribPointerParameter pname, out int pointer);
		internal delegate void glGetVertexAttribPointerv_64(uint index, glVertexAttribPointerParameter pname, out long pointer);

		/// <summary>
		/// Determines if a name is a program name.
		/// </summary>
		/// <param name="program">>The maybe program name.</param>
		/// <returns><b>true</b> if <paramref name="program"/> is a program name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsProgram(uint program);

		/// <summary>
		/// Determines if a name is a shader name.
		/// </summary>
		/// <param name="shader">>The maybe shader name.</param>
		/// <returns><b>true</b> if <paramref name="shader"/> is a shader name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsShader(uint shader);

		/// <summary>
		/// Links a program object.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		public delegate void glLinkProgram(uint program);

		internal delegate void glShaderSource(uint shader, int count, string[] strings, int[] lengths);

		/// <summary>
		/// Sets the active program.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		public delegate void glUseProgram(uint program);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glUniform1f(int location, float v0);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glUniform2f(int location, float v0, float v1);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Thrid value of a tuple to set.</param>
		public delegate void glUniform3f(int location, float v0, float v1, float v2);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glUniform4f(int location, float v0, float v1, float v2, float v3);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glUniform1i(int location, int v0);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glUniform2i(int location, int v0, int v1);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Thrid value of a tuple to set.</param>
		public delegate void glUniform3i(int location, int v0, int v1, int v2);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glUniform4i(int location, int v0, int v1, int v2, int v3);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform1fv(int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform2fv(int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform3fv(int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform4fv(int location, int count, params float[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform1iv(int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform2iv(int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform3iv(int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform4iv(int location, int count, params int[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Validates a program. The status of the validation will be stored in <see cref="glProgramParameter.VALIDATE_STATUS"/>.
		/// </summary>
		/// <param name="program">The name of the program to be validated.</param>
		public delegate void glValidateProgram(uint program);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttrib1d(uint index, double x);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttrib1dv(uint index, double[] v);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttrib1f(uint index, float x);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttrib1fv(uint index, float[] v);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttrib1s(uint index, short x);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttrib1sv(uint index, short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttrib2d(uint index, double x, double y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib2dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttrib2f(uint index, float x, float y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib2fv(uint index, float[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttrib2s(uint index, short x, short y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib2sv(uint index, short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttrib3d(uint index, double x, double y, double z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib3dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttrib3f(uint index, float x, float y, float z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib3fv(uint index, float[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttrib3s(uint index, short x, short y, short z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib3sv(uint index, short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Nbv(uint index, params sbyte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Niv(uint index, params int[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Nsv(uint index, params short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttrib4Nub(uint index, byte x, byte y, byte z, byte w);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Nubv(uint index, byte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Nuiv(uint index, params uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4Nusv(uint index, params ushort[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4bv(uint index, params sbyte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttrib4d(uint index, double x, double y, double z, double w);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4dv(uint index, double[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttrib4f(uint index, float x, float y, float z, float w);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4fv(uint index, float[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4iv(uint index, params int[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttrib4s(uint index, short x, short y, short z, short w);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4sv(uint index, short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4ubv(uint index, params byte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4uiv(uint index, params uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttrib4usv(uint index, params ushort[] v);

		internal delegate void glVertexAttribPointer_32(uint index, int size, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, int stride, int pointer);
		internal delegate void glVertexAttribPointer_64(uint index, int size, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, int stride, long pointer);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 2.0 is available.
		/// </summary>
		public static bool VERSION_2_0;

		#region Delegates
		/// <summary>
		/// Sets the blend equation separately for color and alpha.
		/// </summary>
		public static glBlendEquationSeparate BlendEquationSeparate;

		/// <summary>
		/// Sets the buffers to be drawn into.
		/// </summary>
		public static glDrawBuffers DrawBuffers;

		/// <summary>
		/// Sets the front and/or back face stencil operation.
		/// </summary>
		public static glStencilOpSeparate StencilOpSeparate;

		/// <summary>
		/// Sets the front and/or back face stencil test function.
		/// </summary>
		public static glStencilFuncSeparate StencilFuncSeparate;

		/// <summary>
		/// Sets the front and/or back face stencil mask for stencil write operations.
		/// </summary>
		public static glStencilMaskSeparate StencilMaskSeparate;

		/// <summary>
		/// Attaches a shader to a program.
		/// </summary>
		public static glAttachShader AttachShader;

		/// <summary>
		/// Binds a vertex attribute index to a named attribute vertex shader variable.
		/// </summary>
		public static glBindAttribLocation BindAttribLocation;

		/// <summary>
		/// Compiles a shader.
		/// </summary>
		public static glCompileShader CompileShader;

		/// <summary>
		/// Creates a program and returns the name of the program.
		/// </summary>
		public static glCreateProgram CreateProgram;

		/// <summary>
		/// Creates a shader of a specific type and returns the name of the shader object.
		/// </summary>
		public static glCreateShader CreateShader;

		/// <summary>
		/// Releases/Destroys a program.
		/// </summary>
		public static glDeleteProgram DeleteProgram;

		/// <summary>
		/// Releases/Destroys a shader.
		/// </summary>
		public static glDeleteShader DeleteShader;

		/// <summary>
		/// Detaches a shader from a program.
		/// </summary>
		public static glDetachShader DetachShader;

		/// <summary>
		/// Disables a vertex attribute array.
		/// </summary>
		public static glDisableVertexAttribArray DisableVertexAttribArray;

		/// <summary>
		/// Enables a vertex attribute array.
		/// </summary>
		public static glEnableVertexAttribArray EnableVertexAttribArray;

		private static glGetActiveAttrib _GetActiveAttrib;
		private static glGetActiveUniform _GetActiveUniform;

		/// <summary>
		/// Returns the attached shaders of a program.
		/// </summary>
		public static glGetAttachedShaders GetAttachedShaders;

		/// <summary>
		/// Returns the location of a vertex attribute that is bound to a named attribute variable.
		/// </summary>
		public static glGetAttribLocation GetAttribLocation;

		/// <summary>
		/// Returns the parameters of program object.
		/// </summary>
		public static glGetProgrami GetProgrami;

		/// <summary>
		/// Returns the parameters of program object.
		/// </summary>
		public static glGetProgramiv GetProgramiv;

		private static glGetProgramInfoLog _GetProgramInfoLog;

		/// <summary>
		/// Returns the parameters of shader object.
		/// </summary>
		public static glGetShaderi GetShaderi;

		/// <summary>
		/// Returns the parameters of shader object.
		/// </summary>
		public static glGetShaderiv GetShaderiv;

		private static glGetShaderInfoLog _GetShaderInfoLog;
		private static glGetShaderSource _GetShaderSource;

		/// <summary>
		/// Returns the location of a uniform variable.
		/// </summary>
		public static glGetUniformLocation GetUniformLocation;

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		public static glGetUniformf GetUniformf;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetUniformfv GetUniformfv;

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		public static glGetUniformi GetUniformi;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetUniformiv GetUniformiv;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribd GetVertexAttribd;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribdv GetVertexAttribdv;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribf GetVertexAttribf;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribfv GetVertexAttribfv;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribi GetVertexAttribi;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribiv GetVertexAttribiv;

		private static glGetVertexAttribPointerv_32 GetVertexAttribPointerv_32;
		private static glGetVertexAttribPointerv_64 GetVertexAttribPointerv_64;

		/// <summary>
		/// Determines if a name is a program name.
		/// </summary>
		public static glIsProgram IsProgram;

		/// <summary>
		/// Determines if a name is a shader name.
		/// </summary>
		public static glIsShader IsShader;

		/// <summary>
		/// Links a program object.
		/// </summary>
		public static glLinkProgram LinkProgram;

		private static glShaderSource _ShaderSource;

		/// <summary>
		/// Sets the active program.
		/// </summary>
		public static glUseProgram UseProgram;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1f Uniform1f;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2f Uniform2f;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3f Uniform3f;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4f Uniform4f;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1i Uniform1i;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2i Uniform2i;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3i Uniform3i;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4i Uniform4i;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1fv Uniform1fv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2fv Uniform2fv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3fv Uniform3fv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4fv Uniform4fv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1iv Uniform1iv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2iv Uniform2iv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3iv Uniform3iv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4iv Uniform4iv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2fv UniformMatrix2fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3fv UniformMatrix3fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4fv UniformMatrix4fv;

		/// <summary>
		/// Validates a program. The status of the validation will be stored in <see cref="glProgramParameter.VALIDATE_STATUS"/>.
		/// </summary>
		public static glValidateProgram ValidateProgram;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1d VertexAttrib1d;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1dv VertexAttrib1dv;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1f VertexAttrib1f;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1fv VertexAttrib1fv;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1s VertexAttrib1s;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttrib1sv VertexAttrib1sv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2d VertexAttrib2d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2dv VertexAttrib2dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2f VertexAttrib2f;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2fv VertexAttrib2fv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2s VertexAttrib2s;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib2sv VertexAttrib2sv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3d VertexAttrib3d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3dv VertexAttrib3dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3f VertexAttrib3f;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3fv VertexAttrib3fv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3s VertexAttrib3s;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib3sv VertexAttrib3sv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nbv VertexAttrib4Nbv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Niv VertexAttrib4Niv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nsv VertexAttrib4Nsv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nub VertexAttrib4Nub;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nubv VertexAttrib4Nubv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nuiv VertexAttrib4Nuiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4Nusv VertexAttrib4Nusv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4bv VertexAttrib4bv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4d VertexAttrib4d;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4dv VertexAttrib4dv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4f VertexAttrib4f;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4fv VertexAttrib4fv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4iv VertexAttrib4iv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4s VertexAttrib4s;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4sv VertexAttrib4sv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4ubv VertexAttrib4ubv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4uiv VertexAttrib4uiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttrib4usv VertexAttrib4usv;

		private static glVertexAttribPointer_32 VertexAttribPointer_32;
		private static glVertexAttribPointer_64 VertexAttribPointer_64;
		#endregion

		#region Overloads
		#region GetActiveAttrib
		/// <summary>
		/// Returns multiple informations about an active attribute variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="index">The index of the attribute variable.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="name"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="name"/>.</param>
		/// <param name="size">Returns the size of the attribute variable.</param>
		/// <param name="type">Returns the type of the attribute variable as <see cref="glGLSLType"/> value.</param>
		/// <param name="name">Returns the name of the attribute variable.</param>
		public static void GetActiveAttrib(uint program, uint index, int bufSize, out int length, out int size, out glGLSLType type, out string name)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetActiveAttrib(program, index, bufSize+1, out length, out size, out type, tmp);
			name=tmp.ToString();
		}
		#endregion

		#region GetActiveUniform
		/// <summary>
		///  Returns multiple informations about an active uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="index">The index of the uniform variable.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="name"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="name"/>.</param>
		/// <param name="size">Returns the size of the uniform variable.</param>
		/// <param name="type">Returns the type of the uniform variable as <see cref="glGLSLType"/> value.</param>
		/// <param name="name">Returns the name of the uniform variable.</param>
		public static void GetActiveUniform(uint program, uint index, int bufSize, out int length, out int size, ref glGLSLType type, out string name)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetActiveUniform(program, index, bufSize+1, out length, out size, out type, tmp);
			name=tmp.ToString();
		}
		#endregion

		#region GetProgramInfoLog
		/// <summary>
		/// Returns the information log for a program object.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="maxLength">The size of the buffer used to retrieve <paramref name="infoLog"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="infoLog"/>.</param>
		/// <param name="infoLog">Returns the information log.</param>
		public static void GetProgramInfoLog(uint program, int maxLength, out int length, out string infoLog)
		{
			StringBuilder tmp=new StringBuilder(maxLength+1);
			_GetProgramInfoLog(program, maxLength+1, out length, tmp);
			infoLog=tmp.ToString();
		}
		#endregion

		#region GetShaderInfoLog
		/// <summary>
		/// Returns the information log for a shader object.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="maxLength">The size of the buffer used to retrieve <paramref name="infoLog"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="infoLog"/>.</param>
		/// <param name="infoLog">Returns the information log.</param>
		public static void GetShaderInfoLog(uint shader, int maxLength, out int length, out string infoLog)
		{
			StringBuilder tmp=new StringBuilder(maxLength+1);
			_GetShaderInfoLog(shader, maxLength+1, out length, tmp);
			infoLog=tmp.ToString();
		}
		#endregion

		#region GetShaderSource
		/// <summary>
		/// Returns the source code for a shader.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="maxLength">The size of the buffer used to retrieve <paramref name="source"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="source"/>.</param>
		/// <param name="source">Returns the information log.</param>
		public static void GetShaderSource(uint shader, int maxLength, out int length, out string source)
		{
			StringBuilder tmp=new StringBuilder(maxLength+1);
			_GetShaderSource(shader, maxLength+1, out length, tmp);
			source=tmp.ToString();
		}
		#endregion

		#region GetVertexAttribPointerv
		/// <summary>
		/// Returns the address of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">Must be <see cref="glVertexAttribPointerParameter.VERTEX_ATTRIB_ARRAY_POINTER"/>.</param>
		/// <param name="pointer">Returns a offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void GetVertexAttribPointerv(uint index, glVertexAttribPointerParameter pname, out int pointer)
		{
			if(IntPtr.Size==4) GetVertexAttribPointerv_32(index, pname, out pointer);
			else
			{
				long lPointer;
				GetVertexAttribPointerv_64(index, pname, out lPointer);
				if(((long)lPointer>>32)!=0) throw new ArgumentOutOfRangeException("indirect", PlatformErrorString);
				pointer=(int)lPointer;
			}
		}

		/// <summary>
		/// Returns the address of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">Must be <see cref="glVertexAttribPointerParameter.VERTEX_ATTRIB_ARRAY_POINTER"/>.</param>
		/// <param name="pointer">Returns a offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/></param>
		public static void GetVertexAttribPointerv(uint index, glVertexAttribPointerParameter pname, out long pointer)
		{
			if(IntPtr.Size==4)
			{
				int iPointer;
				GetVertexAttribPointerv_32(index, pname, out iPointer);
				pointer=iPointer;
			}
			else GetVertexAttribPointerv_64(index, pname, out pointer);
		}
		#endregion

		#region ShaderSource
		/// <summary>
		/// Sets the source code for a shader.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="count">Number of strings (source code lines)</param>
		/// <param name="strings">Array of strings countaining the source code.</param>
		/// <param name="lengths">Array of lengths of the strings in <paramref name="strings"/></param>
		public static void ShaderSource(uint shader, int count, string[] strings, int[] lengths)
		{
			_ShaderSource(shader, count, strings, lengths);
		}

		/// <summary>
		/// Sets the source code for a shader.
		/// </summary>
		/// <param name="shader">The name of the shader.</param>
		/// <param name="strings">Array of strings countaining the source code.</param>
		public static void ShaderSource(uint shader, params string[] strings)
		{
			_ShaderSource(shader, strings.Length, strings, null);
		}
		#endregion

		#region VertexAttribPointer
		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute. Can be <see cref="gl.BGRA"/>.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="normalized">Set <b>true</b> if data is normalized.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribPointer(uint index, int size, glVertexAttribType type, bool normalized, int stride, int pointer)
		{
			if(IntPtr.Size==4) VertexAttribPointer_32(index, size, type, normalized, stride, pointer);
			else VertexAttribPointer_64(index, size, type, normalized, stride, pointer);
		}

		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute. Can be <see cref="gl.BGRA"/>.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="normalized">Set <b>true</b> if data is normalized.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribPointer(uint index, int size, glVertexAttribType type, bool normalized, int stride, long pointer)
		{
			if(IntPtr.Size==4)
			{
				if(((long)pointer>>32)!=0) throw new ArgumentOutOfRangeException("indirect", PlatformErrorString);

				VertexAttribPointer_32(index, size, type, normalized, stride, (int)pointer);
			}
			else VertexAttribPointer_64(index, size, type, normalized, stride, pointer);
		}
		#endregion
		#endregion

		private static void Load_VERSION_2_0()
		{
			BlendEquationSeparate=GetAddress<glBlendEquationSeparate>("glBlendEquationSeparate");
			DrawBuffers=GetAddress<glDrawBuffers>("glDrawBuffers");
			StencilOpSeparate=GetAddress<glStencilOpSeparate>("glStencilOpSeparate");
			StencilFuncSeparate=GetAddress<glStencilFuncSeparate>("glStencilFuncSeparate");
			StencilMaskSeparate=GetAddress<glStencilMaskSeparate>("glStencilMaskSeparate");
			AttachShader=GetAddress<glAttachShader>("glAttachShader");
			BindAttribLocation=GetAddress<glBindAttribLocation>("glBindAttribLocation");
			CompileShader=GetAddress<glCompileShader>("glCompileShader");
			CreateProgram=GetAddress<glCreateProgram>("glCreateProgram");
			CreateShader=GetAddress<glCreateShader>("glCreateShader");
			DeleteProgram=GetAddress<glDeleteProgram>("glDeleteProgram");
			DeleteShader=GetAddress<glDeleteShader>("glDeleteShader");
			DetachShader=GetAddress<glDetachShader>("glDetachShader");
			DisableVertexAttribArray=GetAddress<glDisableVertexAttribArray>("glDisableVertexAttribArray");
			EnableVertexAttribArray=GetAddress<glEnableVertexAttribArray>("glEnableVertexAttribArray");
			_GetActiveAttrib=GetAddress<glGetActiveAttrib>("glGetActiveAttrib");
			_GetActiveUniform=GetAddress<glGetActiveUniform>("glGetActiveUniform");
			GetAttachedShaders=GetAddress<glGetAttachedShaders>("glGetAttachedShaders");
			GetAttribLocation=GetAddress<glGetAttribLocation>("glGetAttribLocation");
			GetProgrami=GetAddress<glGetProgrami>("glGetProgramiv");
			GetProgramiv=GetAddress<glGetProgramiv>("glGetProgramiv");
			_GetProgramInfoLog=GetAddress<glGetProgramInfoLog>("glGetProgramInfoLog");
			GetShaderi=GetAddress<glGetShaderi>("glGetShaderiv");
			GetShaderiv=GetAddress<glGetShaderiv>("glGetShaderiv");
			_GetShaderInfoLog=GetAddress<glGetShaderInfoLog>("glGetShaderInfoLog");
			_GetShaderSource=GetAddress<glGetShaderSource>("glGetShaderSource");
			GetUniformLocation=GetAddress<glGetUniformLocation>("glGetUniformLocation");
			GetUniformf=GetAddress<glGetUniformf>("glGetUniformfv");
			GetUniformfv=GetAddress<glGetUniformfv>("glGetUniformfv");
			GetUniformi=GetAddress<glGetUniformi>("glGetUniformiv");
			GetUniformiv=GetAddress<glGetUniformiv>("glGetUniformiv");
			GetVertexAttribd=GetAddress<glGetVertexAttribd>("glGetVertexAttribdv");
			GetVertexAttribdv=GetAddress<glGetVertexAttribdv>("glGetVertexAttribdv");
			GetVertexAttribf=GetAddress<glGetVertexAttribf>("glGetVertexAttribfv");
			GetVertexAttribfv=GetAddress<glGetVertexAttribfv>("glGetVertexAttribfv");
			GetVertexAttribi=GetAddress<glGetVertexAttribi>("glGetVertexAttribiv");
			GetVertexAttribiv=GetAddress<glGetVertexAttribiv>("glGetVertexAttribiv");
			IsProgram=GetAddress<glIsProgram>("glIsProgram");
			IsShader=GetAddress<glIsShader>("glIsShader");
			LinkProgram=GetAddress<glLinkProgram>("glLinkProgram");
			_ShaderSource=GetAddress<glShaderSource>("glShaderSource");
			UseProgram=GetAddress<glUseProgram>("glUseProgram");
			Uniform1f=GetAddress<glUniform1f>("glUniform1f");
			Uniform2f=GetAddress<glUniform2f>("glUniform2f");
			Uniform3f=GetAddress<glUniform3f>("glUniform3f");
			Uniform4f=GetAddress<glUniform4f>("glUniform4f");
			Uniform1i=GetAddress<glUniform1i>("glUniform1i");
			Uniform2i=GetAddress<glUniform2i>("glUniform2i");
			Uniform3i=GetAddress<glUniform3i>("glUniform3i");
			Uniform4i=GetAddress<glUniform4i>("glUniform4i");
			Uniform1fv=GetAddress<glUniform1fv>("glUniform1fv");
			Uniform2fv=GetAddress<glUniform2fv>("glUniform2fv");
			Uniform3fv=GetAddress<glUniform3fv>("glUniform3fv");
			Uniform4fv=GetAddress<glUniform4fv>("glUniform4fv");
			Uniform1iv=GetAddress<glUniform1iv>("glUniform1iv");
			Uniform2iv=GetAddress<glUniform2iv>("glUniform2iv");
			Uniform3iv=GetAddress<glUniform3iv>("glUniform3iv");
			Uniform4iv=GetAddress<glUniform4iv>("glUniform4iv");
			UniformMatrix2fv=GetAddress<glUniformMatrix2fv>("glUniformMatrix2fv");
			UniformMatrix3fv=GetAddress<glUniformMatrix3fv>("glUniformMatrix3fv");
			UniformMatrix4fv=GetAddress<glUniformMatrix4fv>("glUniformMatrix4fv");
			ValidateProgram=GetAddress<glValidateProgram>("glValidateProgram");
			VertexAttrib1d=GetAddress<glVertexAttrib1d>("glVertexAttrib1d");
			VertexAttrib1dv=GetAddress<glVertexAttrib1dv>("glVertexAttrib1dv");
			VertexAttrib1f=GetAddress<glVertexAttrib1f>("glVertexAttrib1f");
			VertexAttrib1fv=GetAddress<glVertexAttrib1fv>("glVertexAttrib1fv");
			VertexAttrib1s=GetAddress<glVertexAttrib1s>("glVertexAttrib1s");
			VertexAttrib1sv=GetAddress<glVertexAttrib1sv>("glVertexAttrib1sv");
			VertexAttrib2d=GetAddress<glVertexAttrib2d>("glVertexAttrib2d");
			VertexAttrib2dv=GetAddress<glVertexAttrib2dv>("glVertexAttrib2dv");
			VertexAttrib2f=GetAddress<glVertexAttrib2f>("glVertexAttrib2f");
			VertexAttrib2fv=GetAddress<glVertexAttrib2fv>("glVertexAttrib2fv");
			VertexAttrib2s=GetAddress<glVertexAttrib2s>("glVertexAttrib2s");
			VertexAttrib2sv=GetAddress<glVertexAttrib2sv>("glVertexAttrib2sv");
			VertexAttrib3d=GetAddress<glVertexAttrib3d>("glVertexAttrib3d");
			VertexAttrib3dv=GetAddress<glVertexAttrib3dv>("glVertexAttrib3dv");
			VertexAttrib3f=GetAddress<glVertexAttrib3f>("glVertexAttrib3f");
			VertexAttrib3fv=GetAddress<glVertexAttrib3fv>("glVertexAttrib3fv");
			VertexAttrib3s=GetAddress<glVertexAttrib3s>("glVertexAttrib3s");
			VertexAttrib3sv=GetAddress<glVertexAttrib3sv>("glVertexAttrib3sv");
			VertexAttrib4Nbv=GetAddress<glVertexAttrib4Nbv>("glVertexAttrib4Nbv");
			VertexAttrib4Niv=GetAddress<glVertexAttrib4Niv>("glVertexAttrib4Niv");
			VertexAttrib4Nsv=GetAddress<glVertexAttrib4Nsv>("glVertexAttrib4Nsv");
			VertexAttrib4Nub=GetAddress<glVertexAttrib4Nub>("glVertexAttrib4Nub");
			VertexAttrib4Nubv=GetAddress<glVertexAttrib4Nubv>("glVertexAttrib4Nubv");
			VertexAttrib4Nuiv=GetAddress<glVertexAttrib4Nuiv>("glVertexAttrib4Nuiv");
			VertexAttrib4Nusv=GetAddress<glVertexAttrib4Nusv>("glVertexAttrib4Nusv");
			VertexAttrib4bv=GetAddress<glVertexAttrib4bv>("glVertexAttrib4bv");
			VertexAttrib4d=GetAddress<glVertexAttrib4d>("glVertexAttrib4d");
			VertexAttrib4dv=GetAddress<glVertexAttrib4dv>("glVertexAttrib4dv");
			VertexAttrib4f=GetAddress<glVertexAttrib4f>("glVertexAttrib4f");
			VertexAttrib4fv=GetAddress<glVertexAttrib4fv>("glVertexAttrib4fv");
			VertexAttrib4iv=GetAddress<glVertexAttrib4iv>("glVertexAttrib4iv");
			VertexAttrib4s=GetAddress<glVertexAttrib4s>("glVertexAttrib4s");
			VertexAttrib4sv=GetAddress<glVertexAttrib4sv>("glVertexAttrib4sv");
			VertexAttrib4ubv=GetAddress<glVertexAttrib4ubv>("glVertexAttrib4ubv");
			VertexAttrib4uiv=GetAddress<glVertexAttrib4uiv>("glVertexAttrib4uiv");
			VertexAttrib4usv=GetAddress<glVertexAttrib4usv>("glVertexAttrib4usv");

			bool platformDependend;
			if(IntPtr.Size==4)
			{
				GetVertexAttribPointerv_32=GetAddress<glGetVertexAttribPointerv_32>("glGetVertexAttribPointerv");
				VertexAttribPointer_32=GetAddress<glVertexAttribPointer_32>("glVertexAttribPointer");

				platformDependend=GetVertexAttribPointerv_32!=null&&VertexAttribPointer_32!=null;
			}
			else
			{
				GetVertexAttribPointerv_64=GetAddress<glGetVertexAttribPointerv_64>("glGetVertexAttribPointerv");
				VertexAttribPointer_64=GetAddress<glVertexAttribPointer_64>("glVertexAttribPointer");

				platformDependend=GetVertexAttribPointerv_64!=null&&VertexAttribPointer_64!=null;
			}

			VERSION_2_0=VERSION_1_5&&BlendEquationSeparate!=null&&DrawBuffers!=null&&StencilOpSeparate!=null&&
				StencilFuncSeparate!=null&&StencilMaskSeparate!=null&&AttachShader!=null&&
				BindAttribLocation!=null&&CompileShader!=null&&CreateProgram!=null&&
				CreateShader!=null&&DeleteProgram!=null&&DeleteShader!=null&&
				DetachShader!=null&&DisableVertexAttribArray!=null&&EnableVertexAttribArray!=null&&
				_GetActiveAttrib!=null&&_GetActiveUniform!=null&&GetAttachedShaders!=null&&
				GetAttribLocation!=null&&GetProgramiv!=null&&_GetProgramInfoLog!=null&&
				GetShaderiv!=null&&_GetShaderInfoLog!=null&&_GetShaderSource!=null&&
				GetUniformLocation!=null&&GetUniformfv!=null&&GetUniformiv!=null&&
				GetVertexAttribdv!=null&&GetVertexAttribfv!=null&&GetVertexAttribiv!=null&&
				IsProgram!=null&&IsShader!=null&&LinkProgram!=null&&_ShaderSource!=null&&
				UseProgram!=null&&Uniform4f!=null&&Uniform4i!=null&&Uniform4fv!=null&&
				Uniform4iv!=null&&UniformMatrix4fv!=null&&ValidateProgram!=null&&
				VertexAttrib1dv!=null&&VertexAttrib2dv!=null&&VertexAttrib3dv!=null&&
				VertexAttrib4dv!=null&&VertexAttrib4Niv!=null&&platformDependend;
		}
	}
}
