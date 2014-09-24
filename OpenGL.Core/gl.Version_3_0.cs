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
		/// Sets the color mask for color write operations for a specific draw buffer.
		/// </summary>
		/// <param name="index">The index of the draw buffer.</param>
		/// <param name="red">Wether or not the write the red components.</param>
		/// <param name="green">Wether or not the write the green components.</param>
		/// <param name="blue">Wether or not the write the blue components.</param>
		/// <param name="alpha">Wether or not the write the alpha components.</param>
		public delegate void glColorMaski(uint index, [MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green, [MarshalAs(UnmanagedType.I1)] bool blue, [MarshalAs(UnmanagedType.I1)] bool alpha);

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the element.</param>
		/// <param name="data">Returns the requested value.</param>
		public delegate void glGetBooleani_(glGetBooleanIndexedParameter target, uint index, [MarshalAs(UnmanagedType.I1)] out bool data);

		internal delegate void glGetBooleani_v(glGetBooleanIndexedParameter target, uint index, IntPtr data); // bool[]

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the element.</param>
		/// <param name="data">Returns the requested value.</param>
		public delegate void glGetIntegeri_(glGetIntegerIndexedParameter target, uint index, out int data);

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the element.</param>
		/// <param name="data">Returns the requested value.</param>
		public delegate void glGetIntegeri_v(glGetIntegerIndexedParameter target, uint index, int[] data);

		/// <summary>
		/// Enables indexed OpenGL capabilities.
		/// </summary>
		/// <param name="target">The capability to be enabled.</param>
		/// <param name="index">The index of the indexed capability.</param>
		public delegate void glEnablei(glIndexedCapability target, uint index);

		/// <summary>
		/// Disables indexed OpenGL capabilities.
		/// </summary>
		/// <param name="target">The capability to be enabled.</param>
		/// <param name="index">The index of the indexed capability.</param>
		public delegate void glDisablei(glIndexedCapability target, uint index);

		/// <summary>
		/// Checks wether or not a indexed OpenGL capability is enabled.
		/// </summary>
		/// <param name="target">The capability to be enabled.</param>
		/// <param name="index">The index of the indexed capability.</param>
		/// <returns><b>true</b> if the indexed capability is enabled.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsEnabledi(glIndexedCapability target, uint index);

		/// <summary>
		/// Starts transform feedback operation.
		/// </summary>
		/// <param name="primitiveMode">A <see cref="glDrawMode"/> specifying the output type of the primitives.</param>
		public delegate void glBeginTransformFeedback(glDrawMode primitiveMode);

		/// <summary>
		/// Stops transform feedback operation.
		/// </summary>
		public delegate void glEndTransformFeedback();

		internal delegate void glBindBufferRange_32(glBufferTarget target, uint index, uint buffer, int offset, int size);
		internal delegate void glBindBufferRange_64(glBufferTarget target, uint index, uint buffer, long offset, long size);

		/// <summary>
		/// Binds buffer objects to indexed buffer target.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer.</param>
		/// <param name="index">The index of the indexed buffer target.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		public delegate void glBindBufferBase(glBufferTarget target, uint index, uint buffer);

		/// <summary>
		/// Sets values to record in transform feedback buffers.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="count">The number of varying variables.</param>
		/// <param name="varyings">The name(s) of the varying variable(s).</param>
		/// <param name="bufferMode">A <see cref="glTransformFeedbackBufferMode"/> specifying the transform feedback buffer mode.</param>
		public delegate void glTransformFeedbackVaryings(uint program, int count, string[] varyings, glTransformFeedbackBufferMode bufferMode);

		internal delegate void glGetTransformFeedbackVarying(uint program, uint index, int bufSize, out int length, out int size, out glGLSLType type, StringBuilder name);

		/// <summary>
		/// Sets read color clamping states.
		/// </summary>
		/// <param name="target">Must be <see cref="glClampColorTarget.CLAMP_READ_COLOR"/>.</param>
		/// <param name="clamp">One of <see cref="glClampColorMode"/>.</param>
		public delegate void glClampColor(glClampColorTarget target, glClampColorMode clamp);

		/// <summary>
		/// Starts conditional rendering.
		/// </summary>
		/// <param name="id">Specifies the name of an occlusion query object whose results are used to determine if the rendering commands are discarded.</param>
		/// <param name="mode">A <see cref="glConditionalRenderMode"/> specifying how <b>gl.BeginConditionalRender</b> interprets the results of the occlusion query.</param>
		public delegate void glBeginConditionalRender(uint id, glConditionalRenderMode mode);

		/// <summary>
		/// Stops conditional rendering.
		/// </summary>
		public delegate void glEndConditionalRender();

		internal delegate void glVertexAttribIPointer_32(uint index, int size, glVertexAttribType type, int stride, int pointer);
		internal delegate void glVertexAttribIPointer_64(uint index, int size, glVertexAttribType type, int stride, long pointer);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribIi(uint index, glVertexAttribParameter pname, out int param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribIiv(uint index, glVertexAttribParameter pname, int[] @params);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexAttribIui(uint index, glVertexAttribParameter pname, out uint param);

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">The requested value(s).</param>
		public delegate void glGetVertexAttribIuiv(uint index, glVertexAttribParameter pname, uint[] @params);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttribI1i(uint index, int x);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttribI2i(uint index, int x, int y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttribI3i(uint index, int x, int y, int z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttribI4i(uint index, int x, int y, int z, int w);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">The value to set.</param>
		public delegate void glVertexAttribI1ui(uint index, uint x);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		public delegate void glVertexAttribI2ui(uint index, uint x, uint y);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		public delegate void glVertexAttribI3ui(uint index, uint x, uint y, uint z);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="x">First value to set.</param>
		/// <param name="y">Second value to set.</param>
		/// <param name="z">Third value to set.</param>
		/// <param name="w">Fourth value to set.</param>
		public delegate void glVertexAttribI4ui(uint index, uint x, uint y, uint z, uint w);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttribI1iv(uint index, int[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI2iv(uint index, int[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI3iv(uint index, int[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4iv(uint index, int[] v);

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The value to set.</param>
		public delegate void glVertexAttribI1uiv(uint index, uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI2uiv(uint index, uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI3uiv(uint index, uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4uiv(uint index, uint[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4bv(uint index, params sbyte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4sv(uint index, params short[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4ubv(uint index, params byte[] v);

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="v">The values to set.</param>
		public delegate void glVertexAttribI4usv(uint index, params ushort[] v);

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="param">The value of the uniform variable.</param>
		public delegate void glGetUniformui(uint program, int location, out uint param);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetUniformuiv(uint program, int location, uint[] @params);

		/// <summary>
		/// Binds a varing output variable to fragment shader color.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="color">The index of the color output.</param>
		/// <param name="name">The name of the varing output variable.</param>
		public delegate void glBindFragDataLocation(uint program, uint color, string name);

		/// <summary>
		/// Returns the fragment shader color index of a bound varing output variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="name">The name of the varing output variable.</param>
		/// <returns>The color index of the bound varing output variable.</returns>
		public delegate int glGetFragDataLocation(uint program, string name);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">The value to set.</param>
		public delegate void glUniform1ui(int location, uint v0);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		public delegate void glUniform2ui(int location, uint v0, uint v1);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		public delegate void glUniform3ui(int location, uint v0, uint v1, uint v2);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="v0">First value of a tuple to set.</param>
		/// <param name="v1">Second value of a tuple to set.</param>
		/// <param name="v2">Third value of a tuple to set.</param>
		/// <param name="v3">Fourth value of a tuple to set.</param>
		public delegate void glUniform4ui(int location, uint v0, uint v1, uint v2, uint v3);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform1uiv(int location, int count, uint[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform2uiv(int location, int count, uint[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform3uiv(int location, int count, uint[] value);

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">The number of values to be set. (>1 if uniform is an array)</param>
		/// <param name="value">The value(s) to set.</param>
		public delegate void glUniform4uiv(int location, int count, uint[] value);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTexParameterIiv(glTextureTarget target, glTextureParameter pname, params int[] @params);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTexParameterIuiv(glTextureTarget target, glTextureParameter pname, params uint[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTexParameterIi(glTextureTarget target, glTextureParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTexParameterIiv(glTextureTarget target, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTexParameterIui(glTextureTarget target, glTextureParameter pname, out uint param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTexParameterIuiv(glTextureTarget target, glTextureParameter pname, uint[] @params);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearBufferiv(glBuffer buffer, int drawbuffer, params int[] value);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearBufferuiv(glBuffer buffer, int drawbuffer, params uint[] value);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearBufferfv(glBuffer buffer, int drawbuffer, params float[] value);
		
		/// <summary>
		/// Clears/Resets the values of the depth-stencil-buffer to a specific value.
		/// </summary>
		/// <param name="buffer">Must be <see cref="glBuffer.DEPTH_STENCIL"/>.</param>
		/// <param name="drawbuffer">Must be zero.</param>
		/// <param name="depth">The depth value to set.</param>
		/// <param name="stencil">The stencil value to set.</param>
		public delegate void glClearBufferfi(glBuffer buffer, int drawbuffer, float depth, int stencil);

		internal delegate IntPtr glGetStringi(glGetStringIndexedParameter name, uint index);

		/// <summary>
		/// Determines if a name is a renderbuffer name.
		/// </summary>
		/// <param name="renderbuffer">The maybe renderbuffer name.</param>
		/// <returns><b>true</b> if <paramref name="renderbuffer"/> is a renderbuffer name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsRenderbuffer(uint renderbuffer);

		/// <summary>
		/// Binds a renderbuffer.
		/// </summary>
		/// <param name="target">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="renderbuffer">The name of the renderbuffer to be bound.</param>
		public delegate void glBindRenderbuffer(glRenderbufferTarget target, uint renderbuffer);

		/// <summary>
		/// Releases <paramref name="count"/> many renderbuffer names.
		/// </summary>
		/// <param name="count">Number of renderbuffer names to be released.</param>
		/// <param name="renderbuffers">Array of renderbuffer names to be released.</param>
		public delegate void glDeleteRenderbuffers(int count, params uint[] renderbuffers);

		internal delegate void glGenRenderbuffer(int one, out uint renderbuffer);
		internal delegate void glGenRenderbuffers(int count, uint[] renderbuffers);

		/// <summary>
		/// Creates a renderbuffer storage for the currently bound renderbuffer object.
		/// </summary>
		/// <param name="target">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format of the storage.</param>
		/// <param name="width">The width of the storage in pixels.</param>
		/// <param name="height">The height of the storage in pixels.</param>
		public delegate void glRenderbufferStorage(glRenderbufferTarget target, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Returns the value of a renderbuffer parameter.
		/// </summary>
		/// <param name="target">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="pname">A <see cref="glRenderbufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns requested the value.</param>
		public delegate void glGetRenderbufferParameteri(glRenderbufferTarget target, glRenderbufferParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a renderbuffer parameter.
		/// </summary>
		/// <param name="target">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="pname">A <see cref="glRenderbufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns requested the value(s).</param>
		public delegate void glGetRenderbufferParameteriv(glRenderbufferTarget target, glRenderbufferParameter pname, int[] @params);

		/// <summary>
		/// Determines if a name is a framebuffer name.
		/// </summary>
		/// <param name="framebuffer">The maybe framebuffer name.</param>
		/// <returns><b>true</b> if <paramref name="framebuffer"/> is a framebuffer name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsFramebuffer(uint framebuffer);

		/// <summary>
		/// Binds a framebuffer to a framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="framebuffer">The name of the framebuffer to be bound.</param>
		public delegate void glBindFramebuffer(glFramebufferTarget target, uint framebuffer);

		/// <summary>
		/// Releases <paramref name="count"/> many framebuffer names.
		/// </summary>
		/// <param name="count">Number of framebuffer names to be released.</param>
		/// <param name="framebuffers">Array of framebuffer names to be released.</param>
		public delegate void glDeleteFramebuffers(int count, params uint[] framebuffers);

		internal delegate void glGenFramebuffer(int one, out uint framebuffer);
		internal delegate void glGenFramebuffers(int count, uint[] framebuffers);

		/// <summary>
		/// Checks and returns the state of a framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <returns>A <see cref="glFramebufferStatus"/> specifying the state of the framebuffer target</returns>
		public delegate glFramebufferStatus glCheckFramebufferStatus(glFramebufferTarget target);

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="textarget">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level of the texture.</param>
		public delegate void glFramebufferTexture1D(glFramebufferTarget target, glBuffer attachment, glTexture1DTarget textarget, uint texture, int level);

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="textarget">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level of the texture.</param>
		public delegate void glFramebufferTexture2D(glFramebufferTarget target, glBuffer attachment, glTexture2DTarget textarget, uint texture, int level);

		/// <summary>
		/// Attachs a layer of a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="textarget">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level of the texture.</param>
		/// <param name="layer">The 2D layer image within a 3D texture.</param>
		public delegate void glFramebufferTexture3D(glFramebufferTarget target, glBuffer attachment, glTexture3DTarget textarget, uint texture, int level, int layer);

		/// <summary>
		/// Attachs a renderbuffer as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="renderbuffertarget">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="renderbuffer">The name of the renderbuffer.</param>
		public delegate void glFramebufferRenderbuffer(glFramebufferTarget target, glBuffer attachment, glRenderbufferTarget renderbuffertarget, uint renderbuffer);

		/// <summary>
		/// Returns the value of a framebuffer attachment parameter.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="pname">A <see cref="glFramebufferAttachmentParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetFramebufferAttachmentParameteri(glFramebufferTarget target, glBuffer attachment, glFramebufferAttachmentParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a framebuffer attachment parameter.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="pname">A <see cref="glFramebufferAttachmentParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetFramebufferAttachmentParameteriv(glFramebufferTarget target, glBuffer attachment, glFramebufferAttachmentParameter pname, int[] @params);

		/// <summary>
		/// Generates the mipmap for the texture currently bound to a specific texture target.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		public delegate void glGenerateMipmap(glTextureTarget target);

		/// <summary>
		/// Copies a block of pixels from the framebuffer bound to <see cref="glFramebufferTarget.READ_FRAMEBUFFER"/> to the framebuffer bound to <see cref="glFramebufferTarget.DRAW_FRAMEBUFFER"/>.
		/// </summary>
		/// <param name="srcX0">The left bound of the region to copy.</param>
		/// <param name="srcY0">The bottom bound of the region to copy.</param>
		/// <param name="srcX1">The right bound of the region to copy.</param>
		/// <param name="srcY1">The top bound of the region to copy.</param>
		/// <param name="dstX0">The left bound of the region to be copied in.</param>
		/// <param name="dstY0">The bottom bound of the region to be copied in.</param>
		/// <param name="dstX1">The right bound of the region to be copied in.</param>
		/// <param name="dstY1">The top bound of the region to be copied in.</param>
		/// <param name="mask">A <see cref="glBufferMask"/> specifying the values to copy.</param>
		/// <param name="filter">A <see cref="glFilter"/> specifying the interpolation methode to use when resizing.</param>
		public delegate void glBlitFramebuffer(int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, glBufferMask mask, glFilter filter);

		/// <summary>
		/// Creates a multisample renderbuffer storage for the currently bound renderbuffer object.
		/// </summary>
		/// <param name="target">Must be <see cref="glRenderbufferTarget.RENDERBUFFER"/>.</param>
		/// <param name="samples">The number of samples.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format of the storage.</param>
		/// <param name="width">The width of the storage in pixels.</param>
		/// <param name="height">The height of the storage in pixels.</param>
		public delegate void glRenderbufferStorageMultisample(glRenderbufferTarget target, int samples, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Attachs a layer of a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level of the texture.</param>
		/// <param name="layer">The 2D layer image within a 3D texture or the face of a cubemap (array).</param>
		public delegate void glFramebufferTextureLayer(glFramebufferTarget target, glBuffer attachment, uint texture, int level, int layer);

		internal delegate IntPtr glMapBufferRange_32(glBufferTarget target, int offset, int length, glMapBufferRangeAccess access);
		internal delegate IntPtr glMapBufferRange_64(glBufferTarget target, long offset, long length, glMapBufferRangeAccess access);
		internal delegate void glFlushMappedBufferRange_32(glBufferTarget target, int offset, int length);
		internal delegate void glFlushMappedBufferRange_64(glBufferTarget target, long offset, long length);

		/// <summary>
		/// Binds a vertex array object.
		/// </summary>
		/// <param name="array">The name of the vertex array.</param>
		public delegate void glBindVertexArray(uint array);

		/// <summary>
		/// Releases <paramref name="count"/> many vertex array names.
		/// </summary>
		/// <param name="count">Number of vertex array names to be released.</param>
		/// <param name="arrays">Array of vertex array names to be released.</param>
		public delegate void glDeleteVertexArrays(int count, params uint[] arrays);

		internal delegate void glGenVertexArray(int one, out uint array);
		internal delegate void glGenVertexArrays(int count, uint[] arrays);

		/// <summary>
		/// Determines if a name is a vertex array name.
		/// </summary>
		/// <param name="array">The maybe vertex array name.</param>
		/// <returns><b>true</b> if <paramref name="array"/> is a vertex array name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsVertexArray(uint array);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 3.0 is available.
		/// </summary>
		public static bool VERSION_3_0;

		#region Delegates
		/// <summary>
		/// Sets the color mask for color write operations for a specific draw buffer.
		/// </summary>
		public static glColorMaski ColorMaski;

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		public static glGetBooleani_ GetBooleani_;

		private static glGetBooleani_v _GetBooleani_v;

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		public static glGetIntegeri_ GetIntegeri_;

		/// <summary>
		/// Returns the value of a index parameter.
		/// </summary>
		public static glGetIntegeri_v GetIntegeri_v;

		/// <summary>
		/// Enables indexed OpenGL capabilities.
		/// </summary>
		public static glEnablei Enablei;

		/// <summary>
		/// Disables indexed OpenGL capabilities.
		/// </summary>
		public static glDisablei Disablei;

		/// <summary>
		/// Checks wether or not a indexed OpenGL capability is enabled.
		/// </summary>
		public static glIsEnabledi IsEnabledi;

		/// <summary>
		/// Starts transform feedback operation.
		/// </summary>
		public static glBeginTransformFeedback BeginTransformFeedback;
		
		/// <summary>
		/// Stops transform feedback operation.
		/// </summary>
		public static glEndTransformFeedback EndTransformFeedback;

		private static glBindBufferRange_32 BindBufferRange_32;
		private static glBindBufferRange_64 BindBufferRange_64;

		/// <summary>
		/// Binds buffer objects to indexed buffer target.
		/// </summary>
		public static glBindBufferBase BindBufferBase;

		/// <summary>
		/// Sets values to record in transform feedback buffers.
		/// </summary>
		public static glTransformFeedbackVaryings TransformFeedbackVaryings;
		
		private static glGetTransformFeedbackVarying _GetTransformFeedbackVarying;

		/// <summary>
		/// Sets read color clamping states.
		/// </summary>
		public static glClampColor ClampColor;

		/// <summary>
		/// Starts conditional rendering.
		/// </summary>
		public static glBeginConditionalRender BeginConditionalRender;

		/// <summary>
		/// Stops conditional rendering.
		/// </summary>
		public static glEndConditionalRender EndConditionalRender;

		private static glVertexAttribIPointer_32 VertexAttribIPointer_32;
		private static glVertexAttribIPointer_64 VertexAttribIPointer_64;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribIi GetVertexAttribIi;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribIiv GetVertexAttribIiv;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribIui GetVertexAttribIui;

		/// <summary>
		/// Returns parameters of vertex attributes.
		/// </summary>
		public static glGetVertexAttribIuiv GetVertexAttribIuiv;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribI1i VertexAttribI1i;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI2i VertexAttribI2i;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI3i VertexAttribI3i;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4i VertexAttribI4i;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribI1ui VertexAttribI1ui;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI2ui VertexAttribI2ui;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI3ui VertexAttribI3ui;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4ui VertexAttribI4ui;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribI1iv VertexAttribI1iv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI2iv VertexAttribI2iv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI3iv VertexAttribI3iv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4iv VertexAttribI4iv;

		/// <summary>
		/// Sets the value of a vertex attribute.
		/// </summary>
		public static glVertexAttribI1uiv VertexAttribI1uiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI2uiv VertexAttribI2uiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI3uiv VertexAttribI3uiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4uiv VertexAttribI4uiv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4bv VertexAttribI4bv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4sv VertexAttribI4sv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4ubv VertexAttribI4ubv;

		/// <summary>
		/// Sets the values of a vertex attribute.
		/// </summary>
		public static glVertexAttribI4usv VertexAttribI4usv;

		/// <summary>
		/// Returns the value of a uniform variable.
		/// </summary>
		public static glGetUniformui GetUniformui;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetUniformuiv GetUniformuiv;

		/// <summary>
		/// Binds a varing output variable to fragment shader color.
		/// </summary>
		public static glBindFragDataLocation BindFragDataLocation;

		/// <summary>
		/// Returns the fragment shader color index of a bound varing output variable.
		/// </summary>
		public static glGetFragDataLocation GetFragDataLocation;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1ui Uniform1ui;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2ui Uniform2ui;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3ui Uniform3ui;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4ui Uniform4ui;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform1uiv Uniform1uiv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform2uiv Uniform2uiv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform3uiv Uniform3uiv;

		/// <summary>
		/// Sets a uniform value.
		/// </summary>
		public static glUniform4uiv Uniform4uiv;

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		public static glTexParameterIiv TexParameterIiv;

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		public static glTexParameterIuiv TexParameterIuiv;

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		public static glGetTexParameterIi GetTexParameterIi;

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		public static glGetTexParameterIiv GetTexParameterIiv;

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		public static glGetTexParameterIui GetTexParameterIui;

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		public static glGetTexParameterIuiv GetTexParameterIuiv;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearBufferiv ClearBufferiv;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearBufferuiv ClearBufferuiv;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearBufferfv ClearBufferfv;

		/// <summary>
		/// Clears/Resets the values of the depth-stencil-buffer to a specific value.
		/// </summary>
		public static glClearBufferfi ClearBufferfi;

		private static glGetStringi _GetStringi;

		/// <summary>
		/// Determines if a name is a renderbuffer name.
		/// </summary>
		public static glIsRenderbuffer IsRenderbuffer;

		/// <summary>
		/// Binds a renderbuffer.
		/// </summary>
		public static glBindRenderbuffer BindRenderbuffer;

		/// <summary>
		/// Releases multiple renderbuffer names at once.
		/// </summary>
		public static glDeleteRenderbuffers DeleteRenderbuffers;

		private static glGenRenderbuffer _GenRenderbuffer;
		private static glGenRenderbuffers _GenRenderbuffers;

		/// <summary>
		/// Creates a renderbuffer storage for the currently bound renderbuffer object.
		/// </summary>
		public static glRenderbufferStorage RenderbufferStorage;

		/// <summary>
		/// Returns the value of a renderbuffer parameter.
		/// </summary>
		public static glGetRenderbufferParameteri GetRenderbufferParameteri;

		/// <summary>
		/// Returns the value(s) of a renderbuffer parameter.
		/// </summary>
		public static glGetRenderbufferParameteriv GetRenderbufferParameteriv;

		/// <summary>
		/// Determines if a name is a framebuffer name.
		/// </summary>
		public static glIsFramebuffer IsFramebuffer;

		/// <summary>
		/// Binds a framebuffer to a framebuffer target.
		/// </summary>
		public static glBindFramebuffer BindFramebuffer;

		/// <summary>
		/// Releases multiple framebuffer names at once.
		/// </summary>
		public static glDeleteFramebuffers DeleteFramebuffers;

		private static glGenFramebuffer _GenFramebuffer;
		private static glGenFramebuffers _GenFramebuffers;

		/// <summary>
		/// Checks and returns the state of a framebuffer target.
		/// </summary>
		public static glCheckFramebufferStatus CheckFramebufferStatus;

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferTexture1D FramebufferTexture1D;

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferTexture2D FramebufferTexture2D;

		/// <summary>
		/// Attachs a layer of a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferTexture3D FramebufferTexture3D;

		/// <summary>
		/// Attachs a renderbuffer as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferRenderbuffer FramebufferRenderbuffer;

		/// <summary>
		/// Returns the value of a framebuffer attachment parameter.
		/// </summary>
		public static glGetFramebufferAttachmentParameteri GetFramebufferAttachmentParameteri;

		/// <summary>
		/// Returns the value(s) of a framebuffer attachment parameter.
		/// </summary>
		public static glGetFramebufferAttachmentParameteriv GetFramebufferAttachmentParameteriv;

		/// <summary>
		/// Generates the mipmap for the texture currently bound to a specific texture target.
		/// </summary>
		public static glGenerateMipmap GenerateMipmap;

		/// <summary>
		/// Copies a block of pixels from the framebuffer bound to <see cref="glFramebufferTarget.READ_FRAMEBUFFER"/> to the framebuffer bound to <see cref="glFramebufferTarget.DRAW_FRAMEBUFFER"/>.
		/// </summary>
		public static glBlitFramebuffer BlitFramebuffer;

		/// <summary>
		/// Creates a multisample renderbuffer storage for the currently bound renderbuffer object.
		/// </summary>
		public static glRenderbufferStorageMultisample RenderbufferStorageMultisample;

		/// <summary>
		/// Attachs a layer of a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferTextureLayer FramebufferTextureLayer;

		private static glMapBufferRange_32 MapBufferRange_32;
		private static glMapBufferRange_64 MapBufferRange_64;
		private static glFlushMappedBufferRange_32 FlushMappedBufferRange_32;
		private static glFlushMappedBufferRange_64 FlushMappedBufferRange_64;

		/// <summary>
		/// Binds a vertex array object.
		/// </summary>
		public static glBindVertexArray BindVertexArray;

		/// <summary>
		/// Releases multiple  vertex array names.
		/// </summary>
		public static glDeleteVertexArrays DeleteVertexArrays;
		private static glGenVertexArray _GenVertexArray;
		private static glGenVertexArrays _GenVertexArrays;

		/// <summary>
		/// Determines if a name is a vertex array name.
		/// </summary>
		public static glIsVertexArray IsVertexArray;
		#endregion

		#region Overloads
		#region GetBooleani_v
		/// <summary>
		/// Returns the value(s) of a index parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the element.</param>
		/// <param name="data">Returns the requested value(s).</param>
		public static void GetBooleani_v(glGetBooleanIndexedParameter target, uint index, bool[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_GetBooleani_v(target, index, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region BindBufferRange
		/// <summary>
		/// Binds a range of a buffer objects to indexed buffer target.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer.</param>
		/// <param name="index">The index of the indexed buffer target.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset inside the buffer.</param>
		/// <param name="size">The size of the range.</param>
		public static void BindBufferRange(glBufferTarget target, uint index, uint buffer, int offset, int size)
		{
			if(IntPtr.Size==4) BindBufferRange_32(target, index, buffer, offset, size);
			else BindBufferRange_64(target, index, buffer, offset, size);
		}

		/// <summary>
		/// Binds a range of a buffer objects to indexed buffer target.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer.</param>
		/// <param name="index">The index of the indexed buffer target.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset inside the buffer.</param>
		/// <param name="size">The size of the range.</param>
		public static void BindBufferRange(glBufferTarget target, uint index, uint buffer, long offset, long size)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);
				BindBufferRange_32(target, index, buffer, (int)offset, (int)size);
			}
			else BindBufferRange_64(target, index, buffer, offset, size);
		}
		#endregion

		#region GetTransformFeedbackVarying
		/// <summary>
		/// Retrieves informations about varying variables selected for transform feedback.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="index">The index of the varying variable.</param>
		/// <param name="bufSize">The size of the buffer used to retrieve <paramref name="name"/>.</param>
		/// <param name="length">Returns the actual length of the result in <paramref name="name"/>.</param>
		/// <param name="size">Returns the size of the attribute variable.</param>
		/// <param name="type">Returns the type of the attribute variable as <see cref="glGLSLType"/> value.</param>
		/// <param name="name">Returns the name of the attribute variable.</param>
		public static void GetTransformFeedbackVarying(uint program, uint index, int bufSize, out int length, out int size, out glGLSLType type, out string name)
		{
			StringBuilder tmp=new StringBuilder(bufSize+1);
			_GetTransformFeedbackVarying(program, index, bufSize+1, out length, out size, out type, tmp);
			name=tmp.ToString();
		}
		#endregion

		#region VertexAttribIPointer
		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribIPointer(uint index, int size, glVertexAttribType type, int stride, int pointer)
		{
			if(IntPtr.Size==4) VertexAttribIPointer_32(index, size, type, stride, pointer);
			else VertexAttribIPointer_64(index, size, type, stride, pointer);
		}

		/// <summary>
		/// Sets the address of an array of vertex attributes.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="size">Size of the vertex attribute.</param>
		/// <param name="type">Data type of the vertex attribute data.</param>
		/// <param name="stride">The byte offset between consecutive vertex attributes.</param>
		/// <param name="pointer">Offset in bytes into the data store of the buffer bound to <see cref="glBufferTarget.ARRAY_BUFFER"/>.</param>
		public static void VertexAttribIPointer(uint index, int size, glVertexAttribType type, int stride, long pointer)
		{
			if(IntPtr.Size==4)
			{
				if(((long)pointer>>32)!=0) throw new ArgumentOutOfRangeException("indirect", PlatformErrorString);

				VertexAttribIPointer_32(index, size, type, stride, (int)pointer);
			}
			else VertexAttribIPointer_64(index, size, type, stride, pointer);
		}
		#endregion

		#region GetStringi
		/// <summary>
		/// Returns the values of indexed string parameters.
		/// </summary>
		/// <param name="name">A <see cref="glGetStringIndexedParameter"/> specifying the indexed string parameter.</param>
		/// <param name="index">The index.</param>
		/// <returns>The retquested value.</returns>
		public static string GetStringi(glGetStringIndexedParameter name, uint index)
		{
			return Marshal.PtrToStringAnsi(_GetStringi(name, index));
		}
		#endregion

		#region GenRenderbuffer(s)
		/// <summary>
		/// Generates one renderbuffer name and returns it.
		/// </summary>
		/// <returns>The new renderbuffer name.</returns>
		public static uint GenRenderbuffer()
		{
			uint ret;
			_GenRenderbuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one renderbuffer name and returns it.
		/// </summary>
		/// <param name="renderbuffer">The new renderbuffer name.</param>
		public static void GenRenderbuffer(out uint renderbuffer)
		{
			_GenRenderbuffer(1, out renderbuffer);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many renderbuffer names and returns them as array.
		/// </summary>
		/// <param name="count">The number of renderbuffer names to be generated.</param>
		/// <returns>The new renderbuffer names as array.</returns>
		public static uint[] GenRenderbuffers(int count)
		{
			uint[] ret=new uint[count];
			_GenRenderbuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many renderbuffer names.
		/// </summary>
		/// <param name="count">The number of renderbuffer names to be generated.</param>
		/// <param name="renderbuffers">The array that will receive the new renderbuffer names.</param>
		public static void GenRenderbuffers(int count, uint[] renderbuffers)
		{
			_GenRenderbuffers(count, renderbuffers);
		}
		#endregion

		#region GenFramebuffer(s)
		/// <summary>
		/// Generates one framebuffer name and returns it.
		/// </summary>
		/// <returns>The new framebuffer name.</returns>
		public static uint GenFramebuffer()
		{
			uint ret;
			_GenFramebuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one framebuffer name and returns it.
		/// </summary>
		/// <param name="framebuffer">The new framebuffer name.</param>
		public static void GenFramebuffer(out uint framebuffer)
		{
			_GenFramebuffer(1, out framebuffer);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many framebuffer names and returns them as array.
		/// </summary>
		/// <param name="count">The number of framebuffer names to be generated.</param>
		/// <returns>The new framebuffer names as array.</returns>
		public static uint[] GenFramebuffers(int count)
		{
			uint[] ret=new uint[count];
			_GenFramebuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many framebuffer names.
		/// </summary>
		/// <param name="count">The number of framebuffer names to be generated.</param>
		/// <param name="framebuffers">The array that will receive the new framebuffer names.</param>
		public static void GenFramebuffers(int count, uint[] framebuffers)
		{
			_GenFramebuffers(count, framebuffers);
		}
		#endregion

		#region MapBufferRange
		/// <summary>
		/// Maps all or parts of a data store into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public static IntPtr MapBufferRange(glBufferTarget target, int offset, int length, glMapBufferRangeAccess access)
		{
			if(IntPtr.Size==4) return MapBufferRange_32(target, offset, length, access);
			return MapBufferRange_64(target, offset, length, access);
		}

		/// <summary>
		/// Maps all or parts of a data store into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public static IntPtr MapBufferRange(glBufferTarget target, long offset, long length, glMapBufferRangeAccess access)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)length>>32)!=0) throw new ArgumentOutOfRangeException("length", PlatformErrorString);
				return MapBufferRange_32(target, (int)offset, (int)length, access);
			}
			return MapBufferRange_64(target, offset, length, access);
		}
		#endregion

		#region FlushMappedBufferRange
		/// <summary>
		/// Flushes modifications to a range of a mapped buffer.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		public static void FlushMappedBufferRange(glBufferTarget target, int offset, int length)
		{
			if(IntPtr.Size==4) FlushMappedBufferRange_32(target, offset, length);
			else FlushMappedBufferRange_64(target, offset, length);
		}

		/// <summary>
		/// Flushes modifications to a range of a mapped buffer.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		public static void FlushMappedBufferRange(glBufferTarget target, long offset, long length)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)length>>32)!=0) throw new ArgumentOutOfRangeException("length", PlatformErrorString);
				FlushMappedBufferRange_32(target, (int)offset, (int)length);
			}
			else FlushMappedBufferRange_64(target, offset, length);
		}
		#endregion

		#region GenVertexArray(s)
		/// <summary>
		/// Generates one vertex array name and returns it.
		/// </summary>
		/// <returns>The new vertex array name.</returns>
		public static uint GenVertexArray()
		{
			uint ret;
			_GenVertexArray(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one vertex array name and returns it.
		/// </summary>
		/// <param name="array">The new vertex array name.</param>
		public static void GenVertexArray(out uint array)
		{
			_GenVertexArray(1, out array);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many vertex array names and returns them as array.
		/// </summary>
		/// <param name="count">The number of vertex array names to be generated.</param>
		/// <returns>The new vertex array names as array.</returns>
		public static uint[] GenVertexArrays(int count)
		{
			uint[] ret=new uint[count];
			_GenVertexArrays(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many vertex array names.
		/// </summary>
		/// <param name="count">The number of vertex array names to be generated.</param>
		/// <param name="arrays">The array that will receive the new vertex array names.</param>
		public static void GenVertexArrays(int count, uint[] arrays)
		{
			_GenVertexArrays(count, arrays);
		}
		#endregion
		#endregion

		private static void Load_VERSION_3_0()
		{
			ColorMaski=GetAddress<glColorMaski>("glColorMaski");
			GetBooleani_=GetAddress<glGetBooleani_>("glGetBooleani_v");
			_GetBooleani_v=GetAddress<glGetBooleani_v>("glGetBooleani_v");
			GetIntegeri_=GetAddress<glGetIntegeri_>("glGetIntegeri_v");
			GetIntegeri_v=GetAddress<glGetIntegeri_v>("glGetIntegeri_v");
			Enablei=GetAddress<glEnablei>("glEnablei");
			Disablei=GetAddress<glDisablei>("glDisablei");
			IsEnabledi=GetAddress<glIsEnabledi>("glIsEnabledi");
			BeginTransformFeedback=GetAddress<glBeginTransformFeedback>("glBeginTransformFeedback");
			EndTransformFeedback=GetAddress<glEndTransformFeedback>("glEndTransformFeedback");
			BindBufferBase=GetAddress<glBindBufferBase>("glBindBufferBase");
			TransformFeedbackVaryings=GetAddress<glTransformFeedbackVaryings>("glTransformFeedbackVaryings");
			_GetTransformFeedbackVarying=GetAddress<glGetTransformFeedbackVarying>("glGetTransformFeedbackVarying");
			ClampColor=GetAddress<glClampColor>("glClampColor");
			BeginConditionalRender=GetAddress<glBeginConditionalRender>("glBeginConditionalRender");
			EndConditionalRender=GetAddress<glEndConditionalRender>("glEndConditionalRender");
			GetVertexAttribIi=GetAddress<glGetVertexAttribIi>("glGetVertexAttribIiv");
			GetVertexAttribIiv=GetAddress<glGetVertexAttribIiv>("glGetVertexAttribIiv");
			GetVertexAttribIui=GetAddress<glGetVertexAttribIui>("glGetVertexAttribIuiv");
			GetVertexAttribIuiv=GetAddress<glGetVertexAttribIuiv>("glGetVertexAttribIuiv");
			VertexAttribI1i=GetAddress<glVertexAttribI1i>("glVertexAttribI1i");
			VertexAttribI2i=GetAddress<glVertexAttribI2i>("glVertexAttribI2i");
			VertexAttribI3i=GetAddress<glVertexAttribI3i>("glVertexAttribI3i");
			VertexAttribI4i=GetAddress<glVertexAttribI4i>("glVertexAttribI4i");
			VertexAttribI1ui=GetAddress<glVertexAttribI1ui>("glVertexAttribI1ui");
			VertexAttribI2ui=GetAddress<glVertexAttribI2ui>("glVertexAttribI2ui");
			VertexAttribI3ui=GetAddress<glVertexAttribI3ui>("glVertexAttribI3ui");
			VertexAttribI4ui=GetAddress<glVertexAttribI4ui>("glVertexAttribI4ui");
			VertexAttribI1iv=GetAddress<glVertexAttribI1iv>("glVertexAttribI1iv");
			VertexAttribI2iv=GetAddress<glVertexAttribI2iv>("glVertexAttribI2iv");
			VertexAttribI3iv=GetAddress<glVertexAttribI3iv>("glVertexAttribI3iv");
			VertexAttribI4iv=GetAddress<glVertexAttribI4iv>("glVertexAttribI4iv");
			VertexAttribI1uiv=GetAddress<glVertexAttribI1uiv>("glVertexAttribI1uiv");
			VertexAttribI2uiv=GetAddress<glVertexAttribI2uiv>("glVertexAttribI2uiv");
			VertexAttribI3uiv=GetAddress<glVertexAttribI3uiv>("glVertexAttribI3uiv");
			VertexAttribI4uiv=GetAddress<glVertexAttribI4uiv>("glVertexAttribI4uiv");
			VertexAttribI4bv=GetAddress<glVertexAttribI4bv>("glVertexAttribI4bv");
			VertexAttribI4sv=GetAddress<glVertexAttribI4sv>("glVertexAttribI4sv");
			VertexAttribI4ubv=GetAddress<glVertexAttribI4ubv>("glVertexAttribI4ubv");
			VertexAttribI4usv=GetAddress<glVertexAttribI4usv>("glVertexAttribI4usv");
			GetUniformui=GetAddress<glGetUniformui>("glGetUniformuiv");
			GetUniformuiv=GetAddress<glGetUniformuiv>("glGetUniformuiv");
			BindFragDataLocation=GetAddress<glBindFragDataLocation>("glBindFragDataLocation");
			GetFragDataLocation=GetAddress<glGetFragDataLocation>("glGetFragDataLocation");
			Uniform1ui=GetAddress<glUniform1ui>("glUniform1ui");
			Uniform2ui=GetAddress<glUniform2ui>("glUniform2ui");
			Uniform3ui=GetAddress<glUniform3ui>("glUniform3ui");
			Uniform4ui=GetAddress<glUniform4ui>("glUniform4ui");
			Uniform1uiv=GetAddress<glUniform1uiv>("glUniform1uiv");
			Uniform2uiv=GetAddress<glUniform2uiv>("glUniform2uiv");
			Uniform3uiv=GetAddress<glUniform3uiv>("glUniform3uiv");
			Uniform4uiv=GetAddress<glUniform4uiv>("glUniform4uiv");
			TexParameterIiv=GetAddress<glTexParameterIiv>("glTexParameterIiv");
			TexParameterIuiv=GetAddress<glTexParameterIuiv>("glTexParameterIuiv");
			GetTexParameterIi=GetAddress<glGetTexParameterIi>("glGetTexParameterIiv");
			GetTexParameterIiv=GetAddress<glGetTexParameterIiv>("glGetTexParameterIiv");
			GetTexParameterIui=GetAddress<glGetTexParameterIui>("glGetTexParameterIuiv");
			GetTexParameterIuiv=GetAddress<glGetTexParameterIuiv>("glGetTexParameterIuiv");
			ClearBufferiv=GetAddress<glClearBufferiv>("glClearBufferiv");
			ClearBufferuiv=GetAddress<glClearBufferuiv>("glClearBufferuiv");
			ClearBufferfv=GetAddress<glClearBufferfv>("glClearBufferfv");
			ClearBufferfi=GetAddress<glClearBufferfi>("glClearBufferfi");
			_GetStringi=GetAddress<glGetStringi>("glGetStringi");
			IsRenderbuffer=GetAddress<glIsRenderbuffer>("glIsRenderbuffer");
			BindRenderbuffer=GetAddress<glBindRenderbuffer>("glBindRenderbuffer");
			DeleteRenderbuffers=GetAddress<glDeleteRenderbuffers>("glDeleteRenderbuffers");
			_GenRenderbuffer=GetAddress<glGenRenderbuffer>("glGenRenderbuffers");
			_GenRenderbuffers=GetAddress<glGenRenderbuffers>("glGenRenderbuffers");
			RenderbufferStorage=GetAddress<glRenderbufferStorage>("glRenderbufferStorage");
			GetRenderbufferParameteri=GetAddress<glGetRenderbufferParameteri>("glGetRenderbufferParameteriv");
			GetRenderbufferParameteriv=GetAddress<glGetRenderbufferParameteriv>("glGetRenderbufferParameteriv");
			IsFramebuffer=GetAddress<glIsFramebuffer>("glIsFramebuffer");
			BindFramebuffer=GetAddress<glBindFramebuffer>("glBindFramebuffer");
			DeleteFramebuffers=GetAddress<glDeleteFramebuffers>("glDeleteFramebuffers");
			_GenFramebuffer=GetAddress<glGenFramebuffer>("glGenFramebuffers");
			_GenFramebuffers=GetAddress<glGenFramebuffers>("glGenFramebuffers");
			CheckFramebufferStatus=GetAddress<glCheckFramebufferStatus>("glCheckFramebufferStatus");
			FramebufferTexture1D=GetAddress<glFramebufferTexture1D>("glFramebufferTexture1D");
			FramebufferTexture2D=GetAddress<glFramebufferTexture2D>("glFramebufferTexture2D");
			FramebufferTexture3D=GetAddress<glFramebufferTexture3D>("glFramebufferTexture3D");
			FramebufferRenderbuffer=GetAddress<glFramebufferRenderbuffer>("glFramebufferRenderbuffer");
			GetFramebufferAttachmentParameteri=GetAddress<glGetFramebufferAttachmentParameteri>("glGetFramebufferAttachmentParameteriv");
			GetFramebufferAttachmentParameteriv=GetAddress<glGetFramebufferAttachmentParameteriv>("glGetFramebufferAttachmentParameteriv");
			GenerateMipmap=GetAddress<glGenerateMipmap>("glGenerateMipmap");
			BlitFramebuffer=GetAddress<glBlitFramebuffer>("glBlitFramebuffer");
			RenderbufferStorageMultisample=GetAddress<glRenderbufferStorageMultisample>("glRenderbufferStorageMultisample");
			FramebufferTextureLayer=GetAddress<glFramebufferTextureLayer>("glFramebufferTextureLayer");
			BindVertexArray=GetAddress<glBindVertexArray>("glBindVertexArray");
			DeleteVertexArrays=GetAddress<glDeleteVertexArrays>("glDeleteVertexArrays");
			_GenVertexArray=GetAddress<glGenVertexArray>("glGenVertexArrays");
			_GenVertexArrays=GetAddress<glGenVertexArrays>("glGenVertexArrays");
			IsVertexArray=GetAddress<glIsVertexArray>("glIsVertexArray");

			bool platformDependend;
			if(IntPtr.Size==4)
			{
				BindBufferRange_32=GetAddress<glBindBufferRange_32>("glBindBufferRange");
				VertexAttribIPointer_32=GetAddress<glVertexAttribIPointer_32>("glVertexAttribIPointer");
				MapBufferRange_32=GetAddress<glMapBufferRange_32>("glMapBufferRange");
				FlushMappedBufferRange_32=GetAddress<glFlushMappedBufferRange_32>("glFlushMappedBufferRange");

				platformDependend=BindBufferRange_32!=null&&VertexAttribIPointer_32!=null&&
					MapBufferRange_32!=null&&FlushMappedBufferRange_32!=null;
			}
			else
			{
				BindBufferRange_64=GetAddress<glBindBufferRange_64>("glBindBufferRange");
				VertexAttribIPointer_64=GetAddress<glVertexAttribIPointer_64>("glVertexAttribIPointer");
				MapBufferRange_64=GetAddress<glMapBufferRange_64>("glMapBufferRange");
				FlushMappedBufferRange_64=GetAddress<glFlushMappedBufferRange_64>("glFlushMappedBufferRange");

				platformDependend=BindBufferRange_64!=null&&VertexAttribIPointer_64!=null&&
					MapBufferRange_64!=null&&FlushMappedBufferRange_64!=null;
			}

			VERSION_3_0=VERSION_2_1&&ColorMaski!=null&&_GetBooleani_v!=null&&GetIntegeri_v!=null&&
				Enablei!=null&&Disablei!=null&&IsEnabledi!=null&&BeginTransformFeedback!=null&&
				EndTransformFeedback!=null&&BindBufferBase!=null&&TransformFeedbackVaryings!=null&&
				_GetTransformFeedbackVarying!=null&&ClampColor!=null&&BeginConditionalRender!=null&&
				EndConditionalRender!=null&&GetVertexAttribIiv!=null&&GetVertexAttribIuiv!=null&&
				VertexAttribI4i!=null&&VertexAttribI4ui!=null&&VertexAttribI4iv!=null&&VertexAttribI4uiv!=null&&
				VertexAttribI4bv!=null&&VertexAttribI4sv!=null&&VertexAttribI4ubv!=null&&
				VertexAttribI4usv!=null&&GetUniformuiv!=null&&BindFragDataLocation!=null&&
				GetFragDataLocation!=null&&Uniform4ui!=null&&Uniform4uiv!=null&&TexParameterIiv!=null&&
				TexParameterIuiv!=null&&GetTexParameterIiv!=null&&GetTexParameterIuiv!=null&&
				ClearBufferiv!=null&&ClearBufferuiv!=null&&ClearBufferfv!=null&&ClearBufferfi!=null&&
				_GetStringi!=null&&IsRenderbuffer!=null&&BindRenderbuffer!=null&&DeleteRenderbuffers!=null&&
				_GenRenderbuffers!=null&&RenderbufferStorage!=null&&GetRenderbufferParameteriv!=null&&
				IsFramebuffer!=null&&BindFramebuffer!=null&&DeleteFramebuffers!=null&&
				_GenFramebuffers!=null&&CheckFramebufferStatus!=null&&FramebufferTexture1D!=null&&
				FramebufferRenderbuffer!=null&&GetFramebufferAttachmentParameteriv!=null&&GenerateMipmap!=null&&
				BlitFramebuffer!=null&&RenderbufferStorageMultisample!=null&&FramebufferTextureLayer!=null&&
				BindVertexArray!=null&&DeleteVertexArrays!=null&&_GenVertexArrays!=null&&
				IsVertexArray!=null&&platformDependend;
		}
	}
}
