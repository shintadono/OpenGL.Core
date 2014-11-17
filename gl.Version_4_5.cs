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

namespace OpenGL.Core
{
	using Delegates;

	namespace Delegates
	{
		/// <summary>
		/// Controls the clipping volume behavior and the clip coordinate to window coordinate transformation behavior.
		/// </summary>
		/// <param name="origin">A <see cref="glOrientationOrigin"/> specifying the clip control origin.</param>
		/// <param name="depth">A <see cref="glClipDepthMode"/> specifying the clip control depth mode.</param>
		public delegate void glClipControl(glOrientationOrigin origin, glClipDepthMode depth);

		internal delegate void glCreateTransformFeedback(int one, out uint id);
		internal delegate void glCreateTransformFeedbacks(int count, uint[] ids);

		/// <summary>
		/// Binds a buffer object to a transform feedback object.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback object.</param>
		/// <param name="index">The index of the binding point of the transform feedback buffer object.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		public delegate void glTransformFeedbackBufferBase(uint xfb, uint index, uint buffer);

		internal delegate void glTransformFeedbackBufferRange_32(uint xfb, uint index, uint buffer, int offset, int size);
		internal delegate void glTransformFeedbackBufferRange_64(uint xfb, uint index, uint buffer, long offset, long size);

		/// <summary>
		/// Returns the parameters of transform feedback objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTransformFeedbacki(uint xfb, glTransformFeedbackParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of transform feedback objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested valu(e).</param>
		public delegate void glGetTransformFeedbackiv(uint xfb, glTransformFeedbackParameter pname, int[] param);

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the buffer binding point.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTransformFeedbacki_(uint xfb, glTransformFeedbackParameter pname, uint index, out int param);

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the buffer binding point.</param>
		/// <param name="param">Returns the requested value(s).</param>
		public delegate void glGetTransformFeedbacki_v(uint xfb, glTransformFeedbackParameter pname, uint index, int[] param);

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the buffer binding point.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTransformFeedbacki64_(uint xfb, glTransformFeedbackParameter pname, uint index, out long param);

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="pname">A <see cref="glTransformFeedbackParameter"/> specifying the parameter.</param>
		/// <param name="index">The index of the buffer binding point.</param>
		/// <param name="param">Returns the requested value(s).</param>
		public delegate void glGetTransformFeedbacki64_v(uint xfb, glTransformFeedbackParameter pname, uint index, long[] param);

		internal delegate void glCreateBuffer(int one, out uint buffer);
		internal delegate void glCreateBuffers(int count, uint[] buffers);
		internal delegate void glNamedBufferStorage_32(uint buffer, int size, IntPtr data, glBufferStorageFlag flags);
		internal delegate void glNamedBufferStorage_64(uint buffer, long size, IntPtr data, glBufferStorageFlag flags);
		internal delegate void glNamedBufferData_32(uint buffer, int size, IntPtr data, glBufferUsage usage);
		internal delegate void glNamedBufferData_64(uint buffer, long size, IntPtr data, glBufferUsage usage);
		internal delegate void glNamedBufferSubData_32(uint buffer, int offset, int size, IntPtr data);
		internal delegate void glNamedBufferSubData_64(uint buffer, long offset, long size, IntPtr data);
		internal delegate void glCopyNamedBufferSubData_32(uint readBuffer, uint writeBuffer, int readOffset, int writeOffset, int size);
		internal delegate void glCopyNamedBufferSubData_64(uint readBuffer, uint writeBuffer, long readOffset, long writeOffset, long size);
		internal delegate void glClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, IntPtr data);
		internal delegate void glClearNamedBufferSubData_32(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, IntPtr data);
		internal delegate void glClearNamedBufferSubData_64(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, IntPtr data);

		/// <summary>
		/// Maps a data store into client memory.
		/// </summary>
		/// <param name="buffer">The name of buffer object.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public delegate IntPtr glMapNamedBuffer(uint buffer, glAccess access);

		internal delegate IntPtr glMapNamedBufferRange_32(uint buffer, int offset, int length, glMapBufferRangeAccess access);
		internal delegate IntPtr glMapNamedBufferRange_64(uint buffer, long offset, long length, glMapBufferRangeAccess access);

		/// <summary>
		/// Releases a mapped data store.
		/// </summary>
		/// <param name="buffer">The name of buffer object.</param>
		/// <returns><b>true</b> unless the data store contents have become corrupt during the time the data store was mapped. If <b>false</b> is returned an application must reinitialize the data store.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glUnmapNamedBuffer(uint buffer);

		internal delegate void glFlushMappedNamedBufferRange_32(uint buffer, int offset, int length);
		internal delegate void glFlushMappedNamedBufferRange_64(uint buffer, long offset, long length);

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetNamedBufferParameteri(uint buffer, glGetBufferParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetNamedBufferParameteriv(uint buffer, glGetBufferParameter pname, int[] @params);

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetNamedBufferParameteri64(uint buffer, glGetBufferParameter pname, out long param);

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetNamedBufferParameteri64v(uint buffer, glGetBufferParameter pname, long[] @params);

		/// <summary>
		/// Returns the pointer to a mapped data store of a buffer object.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="pname">Must be <see cref="glGetBufferParameter.BUFFER_MAP_POINTER"/>.</param>
		/// <param name="param">The pointer to the mapped data store.</param>
		public delegate void glGetNamedBufferPointerv(uint buffer, glGetBufferParameter pname, out IntPtr param);

		internal delegate void glGetNamedBufferSubData_32(uint buffer, int offset, int size, IntPtr data);
		internal delegate void glGetNamedBufferSubData_64(uint buffer, long offset, long size, IntPtr data);
		internal delegate void glCreateFramebuffer(int one, out uint framebuffer);
		internal delegate void glCreateFramebuffers(int count, uint[] framebuffers);

		/// <summary>
		/// Attaches renderbuffers as a logical buffer of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="attachment">A <see cref="glBuffer"/> specifying the framebuffer attachment.</param>
		/// <param name="renderbuffertarget">A <see cref="glRenderbufferTarget"/> specifying the renderbuffer target.</param>
		/// <param name="renderbuffer">The name of the renderbuffer.</param>
		public delegate void glNamedFramebufferRenderbuffer(uint framebuffer, glBuffer attachment, glRenderbufferTarget renderbuffertarget, uint renderbuffer);

		/// <summary>
		/// Sets parameters of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="pname">A <see cref="glFramebufferParameter"/> specifying the parameter.</param>
		/// <param name="param">The new value.</param>
		public delegate void glNamedFramebufferParameteri(uint framebuffer, glFramebufferParameter pname, int param);

		/// <summary>
		/// Attaches levels of texture objects as a logical buffer of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="attachment">A <see cref="glBuffer"/> specifying the framebuffer attachment.</param>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail.</param>
		public delegate void glNamedFramebufferTexture(uint framebuffer, glBuffer attachment, uint texture, int level);

		/// <summary>
		/// Attaches layers of texture objects as a logical buffer of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="attachment">A <see cref="glBuffer"/> specifying the framebuffer attachment.</param>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="layer">The layer number.</param>
		public delegate void glNamedFramebufferTextureLayer(uint framebuffer, glBuffer attachment, uint texture, int level, int layer);

		/// <summary>
		/// Sets the color buffers to draw into.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object. (Zero for the default framebuffer.)</param>
		/// <param name="buf">A <see cref="glBuffer"/> specifying the buffer.</param>
		public delegate void glNamedFramebufferDrawBuffer(uint framebuffer, glBuffer buf);

		/// <summary>
		/// Sets the color buffers to draw into.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object. (Zero for the default framebuffer.)</param>
		/// <param name="count">Number of buffers.</param>
		/// <param name="bufs">A array of <see cref="glBuffer"/>s specifying the buffers.</param>
		public delegate void glNamedFramebufferDrawBuffers(uint framebuffer, int count, params glBuffer[] bufs);

		/// <summary>
		/// Sets the color buffers to read from.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object. (Zero for the default framebuffer.)</param>
		/// <param name="src">A <see cref="glBuffer"/> specifying the buffer.</param>
		public delegate void glNamedFramebufferReadBuffer(uint framebuffer, glBuffer src);

		/// <summary>
		/// Invalidates the content of some or all of a framebuffer's attachments.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="numAttachments">The number of attachments in <paramref name="attachments"/>.</param>
		/// <param name="attachments">An array of <see cref="glBuffer"/>s specifying the attachments.</param>
		public delegate void glInvalidateNamedFramebufferData(uint framebuffer, int numAttachments, params glBuffer[] attachments);

		/// <summary>
		/// Invalidates the content of a region of some or all of a framebuffer's attachments.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="numAttachments">The number of attachments in <paramref name="attachments"/>.</param>
		/// <param name="attachments">An array of <see cref="glBuffer"/>s specifying the attachments.</param>
		/// <param name="x">The X offset of the region to be invalidated.</param>
		/// <param name="y">The Y offset of the region to be invalidated.</param>
		/// <param name="width">The width of the region to be invalidated.</param>
		/// <param name="height">The height of the region to be invalidated.</param>
		public delegate void glInvalidateNamedFramebufferSubData(uint framebuffer, int numAttachments, glBuffer[] attachments, int x, int y, int width, int height);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearNamedFramebufferiv(uint framebuffer, glBuffer buffer, int drawbuffer, params int[] value);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearNamedFramebufferuiv(uint framebuffer, glBuffer buffer, int drawbuffer, params uint[] value);

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="buffer">A <see cref="glBuffer"/> specifying the buffer to be cleared.</param>
		/// <param name="drawbuffer">The index of the color buffer if <paramref name="buffer"/> is <see cref="glBuffer.COLOR"/></param>
		/// <param name="value">The value to be set.</param>
		public delegate void glClearNamedFramebufferfv(uint framebuffer, glBuffer buffer, int drawbuffer, params float[] value);

		/// <summary>
		/// Clears/Resets the values of the depth-stencil-buffer to a specific value.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="buffer">Must be <see cref="glBuffer.DEPTH_STENCIL"/>.</param>
		/// <param name="drawbuffer">Must be zero.</param>
		/// <param name="depth">The depth value to set.</param>
		/// <param name="stencil">The stencil value to set.</param>
		public delegate void glClearNamedFramebufferfi(uint framebuffer, glBuffer buffer, int drawbuffer, float depth, int stencil);

		/// <summary>
		/// Copies a block of pixels between two framebuffer objects.
		/// </summary>
		/// <param name="readFramebuffer">The name of the framebuffer object to read from.</param>
		/// <param name="drawFramebuffer">The name of the framebuffer object to write to.</param>
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
		public delegate void glBlitNamedFramebuffer(uint readFramebuffer, uint drawFramebuffer, int srcX0, int srcY0, int srcX1, int srcY1, int dstX0, int dstY0, int dstX1, int dstY1, glBufferMask mask, glFilter filter);

		/// <summary>
		/// Checks and returns the state of a framebuffer target.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the target against which the framebuffer completeness ist checked.</param>
		/// <returns>A <see cref="glFramebufferStatus"/> specifying the state of the framebuffer target</returns>
		public delegate glFramebufferStatus glCheckNamedFramebufferStatus(uint framebuffer, glFramebufferTarget target);

		/// <summary>
		/// Returns the parameters of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="pname">A <see cref="glFramebufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetNamedFramebufferParameteri(uint framebuffer, glFramebufferParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of framebuffer objects.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="pname">A <see cref="glFramebufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetNamedFramebufferParameteriv(uint framebuffer, glFramebufferParameter pname, int[] @params);

		/// <summary>
		/// Returns the parameters of framebuffer object attachments.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="attachment">A <see cref="glBuffer"/> specifying the attachment.</param>
		/// <param name="pname">A <see cref="glFramebufferAttachmentParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetNamedFramebufferAttachmentParameteri(uint framebuffer, glBuffer attachment, glFramebufferAttachmentParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of framebuffer object attachments.
		/// </summary>
		/// <param name="framebuffer">The name of the framebuffer object.</param>
		/// <param name="attachment">A <see cref="glBuffer"/> specifying the attachment.</param>
		/// <param name="pname">A <see cref="glFramebufferAttachmentParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetNamedFramebufferAttachmentParameteriv(uint framebuffer, glBuffer attachment, glFramebufferAttachmentParameter pname, int[] @params);

		internal delegate void glCreateRenderbuffer(int one, out uint renderbuffer);
		internal delegate void glCreateRenderbuffers(int count, uint[] renderbuffers);

		/// <summary>
		/// Creates renderbuffer storages for renderbuffer objects.
		/// </summary>
		/// <param name="renderbuffer">The name of the renderbuffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format of the storage.</param>
		/// <param name="width">The width of the storage in pixels.</param>
		/// <param name="height">The height of the storage in pixels.</param>
		public delegate void glNamedRenderbufferStorage(uint renderbuffer, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Creates multisample renderbuffer storages for renderbuffer objects.
		/// </summary>
		/// <param name="renderbuffer">The name of the renderbuffer object.</param>
		/// <param name="samples">The number of samples.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format of the storage.</param>
		/// <param name="width">The width of the storage in pixels.</param>
		/// <param name="height">The height of the storage in pixels.</param>
		public delegate void glNamedRenderbufferStorageMultisample(uint renderbuffer, int samples, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Returns parameters of renderbuffer objects.
		/// </summary>
		/// <param name="renderbuffer">The name of the renderbuffer object.</param>
		/// <param name="pname">A <see cref="glRenderbufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetNamedRenderbufferParameteri(uint renderbuffer, glRenderbufferParameter pname, out int param);

		/// <summary>
		/// Returns parameters of renderbuffer objects.
		/// </summary>
		/// <param name="renderbuffer">The name of the renderbuffer object.</param>
		/// <param name="pname">A <see cref="glRenderbufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetNamedRenderbufferParameteriv(uint renderbuffer, glRenderbufferParameter pname, int[] @params);

		internal delegate void glCreateTexture(glTextureTarget target, int one, out uint texture);
		internal delegate void glCreateTextures(glTextureTarget target, int count, uint[] textures);

		/// <summary>
		/// Attaches buffer objects to texture objects.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		public delegate void glTextureBuffer(uint texture, glInternalFormat internalformat, uint buffer);

		internal delegate void glTextureBufferRange_32(uint texture, glInternalFormat internalformat, uint buffer, int offset, int size);
		internal delegate void glTextureBufferRange_64(uint texture, glInternalFormat internalformat, uint buffer, long offset, long size);

		/// <summary>
		/// Creates a storage for all levels of a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		public delegate void glTextureStorage1D(uint texture, int levels, glInternalFormat internalformat, int width);

		/// <summary>
		/// Creates a storage for all levels of a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		public delegate void glTextureStorage2D(uint texture, int levels, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Creates a storage for all levels of a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		public delegate void glTextureStorage3D(uint texture, int levels, glInternalFormat internalformat, int width, int height, int depth);

		/// <summary>
		/// Creates a storage for of a 2D multisample texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="samples">The number of samples in the texture.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
		public delegate void glTextureStorage2DMultisample(uint texture, int samples, glInternalFormat internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

		/// <summary>
		/// Creates a storage for of a 3D multisample texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="samples">The number of samples in the texture.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
		public delegate void glTextureStorage3DMultisample(uint texture, int samples, glInternalFormat internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

		internal delegate void glTextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, IntPtr pixels);
		internal delegate void glTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, IntPtr pixels);
		internal delegate void glTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr pixels);
		internal delegate void glCompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, glInternalFormat format, int imageSize, IntPtr data);
		internal delegate void glCompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glInternalFormat format, int imageSize, IntPtr data);
		internal delegate void glCompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glInternalFormat format, int imageSize, IntPtr data);

		/// <summary>
		/// Copies pixels inside a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		public delegate void glCopyTextureSubImage1D(uint texture, int level, int xoffset, int x, int y, int width);

		/// <summary>
		/// Copies pixels inside a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		public delegate void glCopyTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		/// <summary>
		/// Copies pixels inside a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		public delegate void glCopyTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public delegate void glTextureParameterf(uint texture, glTextureParameter pname, float param);

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTextureParameterfv(uint texture, glTextureParameter pname, params float[] @params);

		internal delegate void glTextureParameteri(uint texture, glTextureParameter pname, int param);

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTextureParameteriv(uint texture, glTextureParameter pname, params int[] @params);

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTextureParameterIiv(uint texture, glTextureParameter pname, params int[] @params);

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glTextureParameterIuiv(uint texture, glTextureParameter pname, params uint[] @params);

		/// <summary>
		/// Generates the mipmap of a texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		public delegate void glGenerateTextureMipmap(uint texture);

		/// <summary>
		/// Bind a texture object to a texture unit.
		/// </summary>
		/// <param name="unit">The texture unit.</param>
		/// <param name="texture">The name of the texture.</param>
		public delegate void glBindTextureUnit(uint unit, uint texture);

		internal delegate void glGetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels);
		internal delegate void glGetCompressedTextureImage(uint texture, int level, int bufSize, IntPtr pixels);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTextureLevelParameterf(uint texture, int level, glTexLevelParameter pname, out float param);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTextureLevelParameterfv(uint texture, int level, glTexLevelParameter pname, float[] @params);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTextureLevelParameteri(uint texture, int level, glTexLevelParameter pname, out int param);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTextureLevelParameteriv(uint texture, int level, glTexLevelParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTextureParameterf(uint texture, glTextureParameter pname, out float param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTextureParameterfv(uint texture, glTextureParameter pname, float[] @params);

		internal delegate void glGetTextureParameteri(uint texture, glTextureParameter pname, out int param);
		internal delegate void glGetTextureParameteriv(uint texture, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTextureParameterIi(uint texture, glTextureParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTextureParameterIiv(uint texture, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetTextureParameterIui(uint texture, glTextureParameter pname, out uint param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetTextureParameterIuiv(uint texture, glTextureParameter pname, uint[] @params);

		internal delegate void glCreateVertexArray(int one, out uint array);
		internal delegate void glCreateVertexArrays(int count, uint[] arrays);

		/// <summary>
		/// Disables a vertex array attribute.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		public delegate void glDisableVertexArrayAttrib(uint vaobj, uint index);

		/// <summary>
		/// Enables a vertex array attribute.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		public delegate void glEnableVertexArrayAttrib(uint vaobj, uint index);

		/// <summary>
		/// Sets the element array buffer binding of a vertex array object.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		public delegate void glVertexArrayElementBuffer(uint vaobj, uint buffer);

		internal delegate void glVertexArrayVertexBuffer_32(uint vaobj, uint bindingindex, uint buffer, int offset, int stride);
		internal delegate void glVertexArrayVertexBuffer_64(uint vaobj, uint bindingindex, uint buffer, long offset, int stride);
		internal delegate void glVertexArrayVertexBuffers_32(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides);
		internal delegate void glVertexArrayVertexBuffers_64(uint vaobj, uint first, int count, uint[] buffers, long[] offsets, int[] strides);

		/// <summary>
		/// Associate a vertex attribute and a vertex buffer binding for a vertex array object.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="attribindex">The index of the attribute.</param>
		/// <param name="bindingindex">The index of the vertex buffer binding with which to associate the generic vertex attribute.</param>
		public delegate void glVertexArrayAttribBinding(uint vaobj, uint attribindex, uint bindingindex);

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="attribindex">The index of the vertex attribute.</param>
		/// <param name="size">The number of values per vertex that are stored in the array.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the type of the data stored in the array.</param>
		/// <param name="normalized">Set <b>true</b> if data is normalized.</param>
		/// <param name="relativeoffset">The distance between elements within the buffer.</param>
		public delegate void glVertexArrayAttribFormat(uint vaobj, uint attribindex, int size, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint relativeoffset);

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="attribindex">The index of the vertex attribute.</param>
		/// <param name="size">The number of values per vertex that are stored in the array.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the type of the data stored in the array.</param>
		/// <param name="relativeoffset">The distance between elements within the buffer.</param>
		public delegate void glVertexArrayAttribIFormat(uint vaobj, uint attribindex, int size, glVertexAttribType type, uint relativeoffset);

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="attribindex">The index of the vertex attribute.</param>
		/// <param name="size">The number of values per vertex that are stored in the array.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the type of the data stored in the array.</param>
		/// <param name="relativeoffset">The distance between elements within the buffer.</param>
		public delegate void glVertexArrayAttribLFormat(uint vaobj, uint attribindex, int size, glVertexAttribType type, uint relativeoffset);

		/// <summary>
		/// Sets the rate at which vertex attributes advance.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="bindingindex">The index of the binding.</param>
		/// <param name="divisor">The value for the instance step rate.</param>
		public delegate void glVertexArrayBindingDivisor(uint vaobj, uint bindingindex, uint divisor);

		/// <summary>
		/// Returns the parameters of vertex array objects.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="pname">Must be <see cref="glVertexArrayParameter.ELEMENT_ARRAY_BUFFER_BINDING"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexArrayi(uint vaobj, glVertexArrayParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of vertex array objects.
		/// </summary>
		/// <param name="vaobj">The name of the vertex attribute array object.</param>
		/// <param name="pname">Must be <see cref="glVertexArrayParameter.ELEMENT_ARRAY_BUFFER_BINDING"/>.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetVertexArrayiv(uint vaobj, glVertexArrayParameter pname, int[] @params);

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexArrayIndexedi(uint vaobj, uint index, glVertexAttribParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">A <see cref="glVertexAttribParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetVertexArrayIndexediv(uint vaobj, uint index, glVertexAttribParameter pname, int[] @params);

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">Must be <see cref="glVertexAttribParameter.VERTEX_BINDING_OFFSET"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetVertexArrayIndexed64i(uint vaobj, uint index, glVertexAttribParameter pname, out long param);

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="pname">Must be <see cref="glVertexAttribParameter.VERTEX_BINDING_OFFSET"/>.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetVertexArrayIndexed64iv(uint vaobj, uint index, glVertexAttribParameter pname, long[] @params);

		internal delegate void glCreateSampler(int one, out uint sampler);
		internal delegate void glCreateSamplers(int count, uint[] samplers);
		internal delegate void glCreateProgramPipeline(int one, out uint pipeline);
		internal delegate void glCreateProgramPipelines(int count, uint[] pipelines);
		internal delegate void glCreateQuery(glQueryTarget target, int one, out uint id);
		internal delegate void glCreateQueries(glQueryTarget target, int count, uint[] ids);
		internal delegate void glGetQueryBufferObjecti64v_32(uint id, uint buffer, glQueryObjectParameter pname, int offset);
		internal delegate void glGetQueryBufferObjecti64v_64(uint id, uint buffer, glQueryObjectParameter pname, long offset);
		internal delegate void glGetQueryBufferObjectiv_32(uint id, uint buffer, glQueryObjectParameter pname, int offset);
		internal delegate void glGetQueryBufferObjectiv_64(uint id, uint buffer, glQueryObjectParameter pname, long offset);
		internal delegate void glGetQueryBufferObjectui64v_32(uint id, uint buffer, glQueryObjectParameter pname, int offset);
		internal delegate void glGetQueryBufferObjectui64v_64(uint id, uint buffer, glQueryObjectParameter pname, long offset);
		internal delegate void glGetQueryBufferObjectuiv_32(uint id, uint buffer, glQueryObjectParameter pname, int offset);
		internal delegate void glGetQueryBufferObjectuiv_64(uint id, uint buffer, glQueryObjectParameter pname, long offset);

		/// <summary>
		/// Orders memory transactions for regions issued prior to this command relative to those issued after this.
		/// </summary>
		/// <param name="barriers">A <see cref="glMemoryBarrierMask"/> specifying the kind of memory transactions to be ordered.</param>
		public delegate void glMemoryBarrierByRegion(glMemoryBarrierMask barriers);

		internal delegate void glGetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels);
		internal delegate void glGetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, IntPtr pixels);

		/// <summary>
		/// Returns if the rendering context has not been lost due to software or hardware issues.
		/// </summary>
		/// <returns><see cref="glGraphicsResetStatus.NO_ERROR"/> if the rendering context wasn't lost.</returns>
		public delegate glGraphicsResetStatus glGetGraphicsResetStatus();

		internal delegate void glGetnCompressedTexImage(glTextureProxyTarget target, int level, int bufSize, IntPtr pixels);
		internal delegate void glGetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="bufSize">The number of elements available in <paramref name="params"/>.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetnUniformdv(uint program, int location, int bufSize, double[] @params);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="bufSize">The number of elements available in <paramref name="params"/>.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetnUniformfv(uint program, int location, int bufSize, float[] @params);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="bufSize">The number of elements available in <paramref name="params"/>.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetnUniformiv(uint program, int location, int bufSize, int[] @params);

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="location">The location of the uniform variable inside the program object.</param>
		/// <param name="bufSize">The number of elements available in <paramref name="params"/>.</param>
		/// <param name="params">The value(s) of the uniform variable.</param>
		public delegate void glGetnUniformuiv(uint program, int location, int bufSize, uint[] @params);

		internal delegate void glReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels);

		/// <summary>
		/// Controls the ordering of reads and writes to rendered fragments across drawing commands.
		/// </summary>
		public delegate void glTextureBarrier();
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 4.5 is available.
		/// </summary>
		public static bool VERSION_4_5;

		#region Delegates
		/// <summary>
		/// Controls the clipping volume behavior and the clip coordinate to window coordinate transformation behavior.
		/// </summary>
		public static glClipControl ClipControl;

		private static glCreateTransformFeedback _CreateTransformFeedback;
		private static glCreateTransformFeedbacks _CreateTransformFeedbacks;

		/// <summary>
		/// Binds a buffer object to a transform feedback object.
		/// </summary>
		public static glTransformFeedbackBufferBase TransformFeedbackBufferBase;

		private static glTransformFeedbackBufferRange_32 TransformFeedbackBufferRange_32;
		private static glTransformFeedbackBufferRange_64 TransformFeedbackBufferRange_64;

		/// <summary>
		/// Returns the parameters of transform feedback objects.
		/// </summary>
		public static glGetTransformFeedbacki GetTransformFeedbacki;

		/// <summary>
		/// Returns the parameters of transform feedback objects.
		/// </summary>
		public static glGetTransformFeedbackiv GetTransformFeedbackiv;

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		public static glGetTransformFeedbacki_ GetTransformFeedbacki_;

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		public static glGetTransformFeedbacki_v GetTransformFeedbacki_v;

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		public static glGetTransformFeedbacki64_ GetTransformFeedbacki64_;

		/// <summary>
		/// Returns the parameters of transform feedback buffer buffer objects.
		/// </summary>
		public static glGetTransformFeedbacki64_v GetTransformFeedbacki64_v;

		private static glCreateBuffer _CreateBuffer;
		private static glCreateBuffers _CreateBuffers;
		private static glNamedBufferStorage_32 NamedBufferStorage_32;
		private static glNamedBufferStorage_64 NamedBufferStorage_64;
		private static glNamedBufferData_32 NamedBufferData_32;
		private static glNamedBufferData_64 NamedBufferData_64;
		private static glNamedBufferSubData_32 NamedBufferSubData_32;
		private static glNamedBufferSubData_64 NamedBufferSubData_64;
		private static glCopyNamedBufferSubData_32 CopyNamedBufferSubData_32;
		private static glCopyNamedBufferSubData_64 CopyNamedBufferSubData_64;
		private static glClearNamedBufferData _ClearNamedBufferData;
		private static glClearNamedBufferSubData_32 ClearNamedBufferSubData_32;
		private static glClearNamedBufferSubData_64 ClearNamedBufferSubData_64;

		/// <summary>
		/// Maps a data store into client memory.
		/// </summary>
		public static glMapNamedBuffer MapNamedBuffer;

		private static glMapNamedBufferRange_32 MapNamedBufferRange_32;
		private static glMapNamedBufferRange_64 MapNamedBufferRange_64;

		/// <summary>
		/// Releases a mapped data store.
		/// </summary>
		public static glUnmapNamedBuffer UnmapNamedBuffer;

		private static glFlushMappedNamedBufferRange_32 FlushMappedNamedBufferRange_32;
		private static glFlushMappedNamedBufferRange_64 FlushMappedNamedBufferRange_64;

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		public static glGetNamedBufferParameteri GetNamedBufferParameteri;

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		public static glGetNamedBufferParameteriv GetNamedBufferParameteriv;

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		public static glGetNamedBufferParameteri64 GetNamedBufferParameteri64;

		/// <summary>
		/// Returns the parameters of buffer objects.
		/// </summary>
		public static glGetNamedBufferParameteri64v GetNamedBufferParameteri64v;

		/// <summary>
		/// Returns the pointer to a mapped data store of a buffer object.
		/// </summary>
		public static glGetNamedBufferPointerv GetNamedBufferPointerv;

		private static glGetNamedBufferSubData_32 GetNamedBufferSubData_32;
		private static glGetNamedBufferSubData_64 GetNamedBufferSubData_64;
		private static glCreateFramebuffer _CreateFramebuffer;
		private static glCreateFramebuffers _CreateFramebuffers;

		/// <summary>
		/// Attaches a renderbuffers as a logical buffer of a framebuffer objects.
		/// </summary>
		public static glNamedFramebufferRenderbuffer NamedFramebufferRenderbuffer;

		/// <summary>
		/// Sets parameters of framebuffer objects.
		/// </summary>
		public static glNamedFramebufferParameteri NamedFramebufferParameteri;

		/// <summary>
		/// Attaches levels of a texture objects as a logical buffer of framebuffer objects.
		/// </summary>
		public static glNamedFramebufferTexture NamedFramebufferTexture;

		/// <summary>
		/// Attaches layers of texture objects as a logical buffer of framebuffer objects.
		/// </summary>
		public static glNamedFramebufferTextureLayer NamedFramebufferTextureLayer;

		/// <summary>
		/// Sets the color buffers to draw into.
		/// </summary>
		public static glNamedFramebufferDrawBuffer NamedFramebufferDrawBuffer;

		/// <summary>
		/// Sets the color buffers to draw into.
		/// </summary>
		public static glNamedFramebufferDrawBuffers NamedFramebufferDrawBuffers;

		/// <summary>
		/// Sets the color buffers to read from.
		/// </summary>
		public static glNamedFramebufferReadBuffer NamedFramebufferReadBuffer;

		/// <summary>
		/// Invalidates the content of some or all of a framebuffer's attachments.
		/// </summary>
		public static glInvalidateNamedFramebufferData InvalidateNamedFramebufferData;

		/// <summary>
		/// Invalidates the content of a region of some or all of a framebuffer's attachments.
		/// </summary>
		public static glInvalidateNamedFramebufferSubData InvalidateNamedFramebufferSubData;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearNamedFramebufferiv ClearNamedFramebufferiv;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearNamedFramebufferuiv ClearNamedFramebufferuiv;

		/// <summary>
		/// Clears/Resets the values of a buffer to a specific value.
		/// </summary>
		public static glClearNamedFramebufferfv ClearNamedFramebufferfv;

		/// <summary>
		/// Clears/Resets the values of the depth-stencil-buffer to a specific value.
		/// </summary>
		public static glClearNamedFramebufferfi ClearNamedFramebufferfi;

		/// <summary>
		///  Copies a block of pixels between two framebuffer objects.
		/// </summary>
		public static glBlitNamedFramebuffer BlitNamedFramebuffer;

		/// <summary>
		/// Checks and returns the state of a framebuffer target.
		/// </summary>
		public static glCheckNamedFramebufferStatus CheckNamedFramebufferStatus;

		/// <summary>
		/// Returns the parameters of framebuffer objects.
		/// </summary>
		public static glGetNamedFramebufferParameteri GetNamedFramebufferParameteri;

		/// <summary>
		/// Returns the parameters of framebuffer objects.
		/// </summary>
		public static glGetNamedFramebufferParameteriv GetNamedFramebufferParameteriv;

		/// <summary>
		/// Returns the parameters of framebuffer object attachments.
		/// </summary>
		public static glGetNamedFramebufferAttachmentParameteri GetNamedFramebufferAttachmentParameteri;

		/// <summary>
		/// Returns the parameters of framebuffer object attachments.
		/// </summary>
		public static glGetNamedFramebufferAttachmentParameteriv GetNamedFramebufferAttachmentParameteriv;

		private static glCreateRenderbuffer _CreateRenderbuffer;
		private static glCreateRenderbuffers _CreateRenderbuffers;

		/// <summary>
		/// Creates renderbuffer storages for renderbuffer objects.
		/// </summary>
		public static glNamedRenderbufferStorage NamedRenderbufferStorage;

		/// <summary>
		/// Creates multisample renderbuffer storages for renderbuffer objects.
		/// </summary>
		public static glNamedRenderbufferStorageMultisample NamedRenderbufferStorageMultisample;

		/// <summary>
		/// Returns parameters of renderbuffer objects.
		/// </summary>
		public static glGetNamedRenderbufferParameteri GetNamedRenderbufferParameteri;

		/// <summary>
		/// Returns parameters of renderbuffer objects.
		/// </summary>
		public static glGetNamedRenderbufferParameteriv GetNamedRenderbufferParameteriv;

		private static glCreateTexture _CreateTexture;
		private static glCreateTextures _CreateTextures;

		/// <summary>
		/// Attaches buffer objects to texture objects.
		/// </summary>
		public static glTextureBuffer TextureBuffer;

		private static glTextureBufferRange_32 TextureBufferRange_32;
		private static glTextureBufferRange_64 TextureBufferRange_64;

		/// <summary>
		/// Creates a storage for all levels of a 1D texture.
		/// </summary>
		public static glTextureStorage1D TextureStorage1D;

		/// <summary>
		/// Creates a storage for all levels of a 2D texture.
		/// </summary>
		public static glTextureStorage2D TextureStorage2D;

		/// <summary>
		/// Creates a storage for all levels of a 3D texture.
		/// </summary>
		public static glTextureStorage3D TextureStorage3D;

		/// <summary>
		/// Creates a storage for of a 3D multisample texture.
		/// </summary>
		public static glTextureStorage2DMultisample TextureStorage2DMultisample;

		/// <summary>
		/// Creates a storage for of a 3D multisample texture.
		/// </summary>
		public static glTextureStorage3DMultisample TextureStorage3DMultisample;

		private static glTextureSubImage1D _TextureSubImage1D;
		private static glTextureSubImage2D _TextureSubImage2D;
		private static glTextureSubImage3D _TextureSubImage3D;
		private static glCompressedTextureSubImage1D _CompressedTextureSubImage1D;
		private static glCompressedTextureSubImage2D _CompressedTextureSubImage2D;
		private static glCompressedTextureSubImage3D _CompressedTextureSubImage3D;

		/// <summary>
		/// Copies pixels inside a 1D texture.
		/// </summary>
		public static glCopyTextureSubImage1D CopyTextureSubImage1D;

		/// <summary>
		/// Copies pixels inside a 2D texture.
		/// </summary>
		public static glCopyTextureSubImage2D CopyTextureSubImage2D;

		/// <summary>
		/// Copies pixels inside a 3D texture.
		/// </summary>
		public static glCopyTextureSubImage3D CopyTextureSubImage3D;

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		public static glTextureParameterf TextureParameterf;

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		public static glTextureParameterfv TextureParameterfv;

		private static glTextureParameteri _TextureParameteri;

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		public static glTextureParameteriv TextureParameteriv;

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		public static glTextureParameterIiv TextureParameterIiv;

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		public static glTextureParameterIuiv TextureParameterIuiv;

		/// <summary>
		/// Generates the mipmap of a texture object.
		/// </summary>
		public static glGenerateTextureMipmap GenerateTextureMipmap;

		/// <summary>
		/// Bind a texture object to a texture unit.
		/// </summary>
		public static glBindTextureUnit BindTextureUnit;

		private static glGetTextureImage _GetTextureImage;
		private static glGetCompressedTextureImage _GetCompressedTextureImage;

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		public static glGetTextureLevelParameterf GetTextureLevelParameterf;

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		public static glGetTextureLevelParameterfv GetTextureLevelParameterfv;

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		public static glGetTextureLevelParameteri GetTextureLevelParameteri;

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		public static glGetTextureLevelParameteriv GetTextureLevelParameteriv;

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		public static glGetTextureParameterf GetTextureParameterf;

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		public static glGetTextureParameterfv GetTextureParameterfv;

		private static glGetTextureParameteri _GetTextureParameteri;
		private static glGetTextureParameteriv _GetTextureParameteriv;

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		public static glGetTextureParameterIi GetTextureParameterIi;

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		public static glGetTextureParameterIiv GetTextureParameterIiv;

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		public static glGetTextureParameterIui GetTextureParameterIui;

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		public static glGetTextureParameterIuiv GetTextureParameterIuiv;

		private static glCreateVertexArray _CreateVertexArray;
		private static glCreateVertexArrays _CreateVertexArrays;

		/// <summary>
		/// Disables a vertex array attribute.
		/// </summary>
		public static glDisableVertexArrayAttrib DisableVertexArrayAttrib;

		/// <summary>
		/// Enables a vertex array attribute.
		/// </summary>
		public static glEnableVertexArrayAttrib EnableVertexArrayAttrib;

		/// <summary>
		/// Sets the element array buffer binding of a vertex array object.
		/// </summary>
		public static glVertexArrayElementBuffer VertexArrayElementBuffer;

		private static glVertexArrayVertexBuffer_32 VertexArrayVertexBuffer_32;
		private static glVertexArrayVertexBuffer_64 VertexArrayVertexBuffer_64;
		private static glVertexArrayVertexBuffers_32 VertexArrayVertexBuffers_32;
		private static glVertexArrayVertexBuffers_64 VertexArrayVertexBuffers_64;

		/// <summary>
		/// Associate a vertex attribute and a vertex buffer binding for a vertex array object.
		/// </summary>
		public static glVertexArrayAttribBinding VertexArrayAttribBinding;

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		public static glVertexArrayAttribFormat VertexArrayAttribFormat;

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		public static glVertexArrayAttribIFormat VertexArrayAttribIFormat;

		/// <summary>
		/// Sets the organization of vertex arrays.
		/// </summary>
		public static glVertexArrayAttribLFormat VertexArrayAttribLFormat;

		/// <summary>
		/// Sets the rate at which vertex attributes advance.
		/// </summary>
		public static glVertexArrayBindingDivisor VertexArrayBindingDivisor;

		/// <summary>
		/// Returns the parameters of vertex array objects.
		/// </summary>
		public static glGetVertexArrayi GetVertexArrayi;

		/// <summary>
		/// Returns the parameters of vertex array objects.
		/// </summary>
		public static glGetVertexArrayiv GetVertexArrayiv;

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		public static glGetVertexArrayIndexedi GetVertexArrayIndexedi;

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		public static glGetVertexArrayIndexediv GetVertexArrayIndexediv;

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		public static glGetVertexArrayIndexed64i GetVertexArrayIndexed64i;

		/// <summary>
		/// Returns the parameters of vertex attributes.
		/// </summary>
		public static glGetVertexArrayIndexed64iv GetVertexArrayIndexed64iv;

		private static glCreateSampler _CreateSampler;
		private static glCreateSamplers _CreateSamplers;
		private static glCreateProgramPipeline _CreateProgramPipeline;
		private static glCreateProgramPipelines _CreateProgramPipelines;
		private static glCreateQuery _CreateQuery;
		private static glCreateQueries _CreateQueries;
		private static glGetQueryBufferObjecti64v_32 GetQueryBufferObjecti64v_32;
		private static glGetQueryBufferObjecti64v_64 GetQueryBufferObjecti64v_64;
		private static glGetQueryBufferObjectiv_32 GetQueryBufferObjectiv_32;
		private static glGetQueryBufferObjectiv_64 GetQueryBufferObjectiv_64;
		private static glGetQueryBufferObjectui64v_32 GetQueryBufferObjectui64v_32;
		private static glGetQueryBufferObjectui64v_64 GetQueryBufferObjectui64v_64;
		private static glGetQueryBufferObjectuiv_32 GetQueryBufferObjectuiv_32;
		private static glGetQueryBufferObjectuiv_64 GetQueryBufferObjectuiv_64;

		/// <summary>
		/// Orders memory transactions for regions issued prior to this command relative to those issued after this.
		/// </summary>
		public static glMemoryBarrierByRegion MemoryBarrierByRegion;

		private static glGetTextureSubImage _GetTextureSubImage;
		private static glGetCompressedTextureSubImage _GetCompressedTextureSubImage;

		/// <summary>
		/// Returns if the rendering context has not been lost due to software or hardware issues.
		/// </summary>
		public static glGetGraphicsResetStatus GetGraphicsResetStatus;

		private static glGetnCompressedTexImage _GetnCompressedTexImage;
		private static glGetnTexImage _GetnTexImage;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetnUniformdv GetnUniformdv;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetnUniformfv GetnUniformfv;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetnUniformiv GetnUniformiv;

		/// <summary>
		/// Returns the value(s) of a uniform variable.
		/// </summary>
		public static glGetnUniformuiv GetnUniformuiv;

		private static glReadnPixels _ReadnPixels;

		/// <summary>
		/// Controls the ordering of reads and writes to rendered fragments across drawing commands.
		/// </summary>
		public static glTextureBarrier TextureBarrier;
		#endregion

		#region Overloads
		#region CreateTransformFeedback(s)
		/// <summary>
		/// Creates one transform feedback object and returns it's name.
		/// </summary>
		/// <returns>The name of the new transform feedback object.</returns>
		public static uint CreateTransformFeedback()
		{
			uint ret;
			_CreateTransformFeedback(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one transform feedback object and returns it's name.
		/// </summary>
		/// <param name="id">Returns the name of the new transform feedback object.</param>
		public static void CreateTransformFeedback(out uint id)
		{
			_CreateTransformFeedback(1, out id);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many transform feedback objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of transform feedback objects to be created.</param>
		/// <returns>The names of the new transform feedback objects as array.</returns>
		public static uint[] CreateTransformFeedbacks(int count)
		{
			uint[] ret=new uint[count];
			_CreateTransformFeedbacks(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many transform feedback objects.
		/// </summary>
		/// <param name="count">The number of transform feedback objects to be created.</param>
		/// <param name="ids">Returns the name of the new transform feedback objects.</param>
		public static void CreateTransformFeedbacks(int count, uint[] ids)
		{
			_CreateTransformFeedbacks(count, ids);
		}
		#endregion

		#region TransformFeedbackBufferRange
		/// <summary>
		/// Binds a range within a buffer object to a transform feedback buffer object.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="index">The index of the transform feedback stream.</param>
		/// <param name="buffer">The name of the buffer.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="size">The size of the region.</param>
		public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, int offset, int size)
		{
			if(IntPtr.Size==4) TransformFeedbackBufferRange_32(xfb, index, buffer, offset, size);
			else TransformFeedbackBufferRange_64(xfb, index, buffer, offset, size);
		}

		/// <summary>
		/// Binds a range within a buffer object to a transform feedback buffer object.
		/// </summary>
		/// <param name="xfb">The name of the transform feedback buffer object.</param>
		/// <param name="index">The index of the transform feedback stream.</param>
		/// <param name="buffer">The name of the buffer.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="size">The size of the region.</param>
		public static void TransformFeedbackBufferRange(uint xfb, uint index, uint buffer, long offset, long size)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				TransformFeedbackBufferRange_32(xfb, index, buffer, (int)offset, (int)size);
			}
			else TransformFeedbackBufferRange_64(xfb, index, buffer, offset, size);
		}
		#endregion

		#region CreateBuffer(s)
		/// <summary>
		/// Creates one buffer object and returns it's name.
		/// </summary>
		/// <returns>The name of the new buffer object.</returns>
		public static uint CreateBuffer()
		{
			uint ret;
			_CreateBuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one buffer object and returns it's name.
		/// </summary>
		/// <param name="buffer">Returns the name of the new buffer object.</param>
		public static void CreateBuffer(out uint buffer)
		{
			_CreateBuffer(1, out buffer);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many buffer objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of buffer objects to be created.</param>
		/// <returns>The names of the new buffer objects as array.</returns>
		public static uint[] CreateBuffers(int count)
		{
			uint[] ret=new uint[count];
			_CreateBuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many buffer objects.
		/// </summary>
		/// <param name="count">The number of buffer objects to be created.</param>
		/// <param name="buffers">Returns the name of the new buffer objects.</param>
		public static void CreateBuffers(int count, uint[] buffers)
		{
			_CreateBuffers(count, buffers);
		}
		#endregion

		#region NamedBufferStorage
		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, IntPtr data, glBufferStorageFlag flags)
		{
			if(IntPtr.Size==4) NamedBufferStorage_32(buffer, size, data, flags);
			else NamedBufferStorage_64(buffer, size, data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, IntPtr data, glBufferStorageFlag flags)
		{
			if(IntPtr.Size==4)
			{
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				NamedBufferStorage_32(buffer, (int)size, data, flags);
			}
			else NamedBufferStorage_64(buffer, size, data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, byte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, byte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, sbyte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, sbyte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, short[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, short[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, ushort[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, ushort[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, int[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, int[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, uint[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, uint[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, long[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, long[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, ulong[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, ulong[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, float[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, float[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, int size, double[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void NamedBufferStorage(uint buffer, long size, double[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferStorage(buffer, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region NamedBufferData
		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>IntPtr.Zero</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, IntPtr data, glBufferUsage usage)
		{
			if(IntPtr.Size==4) NamedBufferData_32(buffer, size, data, usage);
			else NamedBufferData_64(buffer, size, data, usage);
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>IntPtr.Zero</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, IntPtr data, glBufferUsage usage)
		{
			if(IntPtr.Size==4)
			{
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);
				NamedBufferData_32(buffer, (int)size, data, usage);
			}
			else NamedBufferData_64(buffer, size, data, usage);
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, byte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, byte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, sbyte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, sbyte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, short[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, short[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, ushort[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, ushort[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, int[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, int[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, uint[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, uint[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, long[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, long[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, ulong[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, ulong[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, float[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, float[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, int size, double[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void NamedBufferData(uint buffer, long size, double[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferData(buffer, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}
		#endregion

		#region NamedBufferSubData
		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			if(IntPtr.Size==4) NamedBufferSubData_32(buffer, offset, size, data);
			else NamedBufferSubData_64(buffer, offset, size, data);
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, IntPtr data)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				NamedBufferSubData_32(buffer, (int)offset, (int)size, data);
			}
			else NamedBufferSubData_64(buffer, offset, size, data);
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, int offset, int size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void NamedBufferSubData(uint buffer, long offset, long size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				NamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}
		#endregion

		#region CopyNamedBufferSubData
		/// <summary>
		/// Copies data between buffer objects.
		/// </summary>
		/// <param name="readbuffer">The name of the buffer object to read from.</param>
		/// <param name="writebuffer">The name of the buffer object to write to.</param>
		/// <param name="readOffset">The offset into the read buffer.</param>
		/// <param name="writeOffset">The offset into the write buffer.</param>
		/// <param name="size">The size of the data block to be copied.</param>
		public static void CopyNamedBufferSubData(uint readbuffer, uint writebuffer, int readOffset, int writeOffset, int size)
		{
			if(IntPtr.Size==4) CopyNamedBufferSubData_32(readbuffer, writebuffer, readOffset, writeOffset, size);
			else CopyNamedBufferSubData_64(readbuffer, writebuffer, readOffset, writeOffset, size);
		}

		/// <summary>
		/// Copies data between buffer objects.
		/// </summary>
		/// <param name="readbuffer">The name of the buffer object to read from.</param>
		/// <param name="writebuffer">The name of the buffer object to write to.</param>
		/// <param name="readOffset">The offset into the read buffer.</param>
		/// <param name="writeOffset">The offset into the write buffer.</param>
		/// <param name="size">The size of the data block to be copied.</param>
		public static void CopyNamedBufferSubData(uint readbuffer, uint writebuffer, long readOffset, long writeOffset, long size)
		{
			if(IntPtr.Size==4)
			{
				if(((long)readOffset>>32)!=0) throw new ArgumentOutOfRangeException("readOffset", PlatformErrorString);
				if(((long)writeOffset>>32)!=0) throw new ArgumentOutOfRangeException("writeOffset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				CopyNamedBufferSubData_32(readbuffer, writebuffer, (int)readOffset, (int)writeOffset, (int)size);
			}
			else CopyNamedBufferSubData_64(readbuffer, writebuffer, readOffset, writeOffset, size);
		}
		#endregion

		#region ClearNamedBufferData
		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, IntPtr data)
		{
			_ClearNamedBufferData(buffer, internalformat, format, type, data);
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, byte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, sbyte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, short[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, ushort[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, int[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, uint[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, long[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, ulong[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, float[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferData(uint buffer, glInternalFormat internalformat, glPixelFormat format, glPixelDataType type, double[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearNamedBufferData(buffer, internalformat, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region ClearNamedBufferSubData
		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, IntPtr data)
		{
			if(IntPtr.Size==4) ClearNamedBufferSubData_32(buffer, internalformat, offset, size, format, type, data);
			else ClearNamedBufferSubData_64(buffer, internalformat, offset, size, format, type, data);
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, IntPtr data)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				ClearNamedBufferSubData_32(buffer, internalformat, (int)offset, (int)size, format, type, data);
			}
			else ClearNamedBufferSubData_64(buffer, internalformat, offset, size, format, type, data);
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, byte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, byte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, sbyte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, sbyte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, short[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, short[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, ushort[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, ushort[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, int[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, int[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, uint[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, uint[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, long[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, long[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, ulong[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, ulong[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, float[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, float[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, int offset, int size, glPixelFormat format, glPixelDataType type, double[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all or parts a buffer object's data store with a fixed value.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The size of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format used in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the pixel data type used in <paramref name="data"/>.</param>
		/// <param name="data">The 'fixed' value.</param>
		public static void ClearNamedBufferSubData(uint buffer, glInternalFormat internalformat, long offset, long size, glPixelFormat format, glPixelDataType type, double[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				ClearNamedBufferSubData(buffer, internalformat, offset, size, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region MapNamedBufferRange
		/// <summary>
		/// Maps all or parts of a data store into client memory.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public static IntPtr MapNamedBufferRange(uint buffer, int offset, int length, glMapBufferRangeAccess access)
		{
			if(IntPtr.Size==4) return MapNamedBufferRange_32(buffer, offset, length, access);
			return MapNamedBufferRange_64(buffer, offset, length, access);
		}

		/// <summary>
		/// Maps all or parts of a data store into client memory.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public static IntPtr MapNamedBufferRange(uint buffer, long offset, long length, glMapBufferRangeAccess access)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)length>>32)!=0) throw new ArgumentOutOfRangeException("length", PlatformErrorString);
				return MapNamedBufferRange_32(buffer, (int)offset, (int)length, access);
			}
			return MapNamedBufferRange_64(buffer, offset, length, access);
		}
		#endregion

		#region FlushMappedNamedBufferRange
		/// <summary>
		/// Flushes modifications to a range of a mapped buffer.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		public static void FlushMappedNamedBufferRange(uint buffer, int offset, int length)
		{
			if(IntPtr.Size==4) FlushMappedNamedBufferRange_32(buffer, offset, length);
			else FlushMappedNamedBufferRange_64(buffer, offset, length);
		}

		/// <summary>
		/// Flushes modifications to a range of a mapped buffer.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the buffer.</param>
		/// <param name="length">The size of the region.</param>
		public static void FlushMappedNamedBufferRange(uint buffer, long offset, long length)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)length>>32)!=0) throw new ArgumentOutOfRangeException("length", PlatformErrorString);
				FlushMappedNamedBufferRange_32(buffer, (int)offset, (int)length);
			}
			else FlushMappedNamedBufferRange_64(buffer, offset, length);
		}
		#endregion

		#region GetNamedBufferSubData
		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, IntPtr data)
		{
			if(IntPtr.Size==4) GetNamedBufferSubData_32(buffer, offset, size, data);
			else GetNamedBufferSubData_64(buffer, offset, size, data);
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, IntPtr data)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				GetNamedBufferSubData_32(buffer, (int)offset, (int)size, data);
			}
			else GetNamedBufferSubData_64(buffer, offset, size, data);
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, int offset, int size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetNamedBufferSubData(uint buffer, long offset, long size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetNamedBufferSubData(buffer, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}
		#endregion

		#region CreateFramebuffer(s)
		/// <summary>
		/// Creates one framebuffer object and returns it's name.
		/// </summary>
		/// <returns>The name of the new framebuffer object.</returns>
		public static uint CreateFramebuffer()
		{
			uint ret;
			_CreateFramebuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one framebuffer object and returns it's name.
		/// </summary>
		/// <param name="framebuffer">Returns the name of the new framebuffer object.</param>
		public static void CreateFramebuffer(out uint framebuffer)
		{
			_CreateFramebuffer(1, out framebuffer);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many framebuffer objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of framebuffer objects to be created.</param>
		/// <returns>The names of the new framebuffer objects as array.</returns>
		public static uint[] CreateFramebuffers(int count)
		{
			uint[] ret=new uint[count];
			_CreateFramebuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many framebuffer objects.
		/// </summary>
		/// <param name="count">The number of framebuffer objects to be created.</param>
		/// <param name="framebuffers">Returns the name of the new framebuffer objects.</param>
		public static void CreateFramebuffers(int count, uint[] framebuffers)
		{
			_CreateFramebuffers(count, framebuffers);
		}
		#endregion

		#region CreateRenderbuffer(s)
		/// <summary>
		/// Creates one renderbuffer object and returns it's name.
		/// </summary>
		/// <returns>The name of the new renderbuffer object.</returns>
		public static uint CreateRenderbuffer()
		{
			uint ret;
			_CreateRenderbuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one renderbuffer object and returns it's name.
		/// </summary>
		/// <param name="renderbuffer">Returns the name of the new renderbuffer object.</param>
		public static void CreateRenderbuffer(out uint renderbuffer)
		{
			_CreateRenderbuffer(1, out renderbuffer);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many renderbuffer objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of renderbuffer objects to be created.</param>
		/// <returns>The names of the new renderbuffer objects as array.</returns>
		public static uint[] CreateRenderbuffers(int count)
		{
			uint[] ret=new uint[count];
			_CreateRenderbuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many renderbuffer objects.
		/// </summary>
		/// <param name="count">The number of renderbuffer objects to be created.</param>
		/// <param name="renderbuffers">Returns the name of the new renderbuffer objects.</param>
		public static void CreateRenderbuffers(int count, uint[] renderbuffers)
		{
			_CreateRenderbuffers(count, renderbuffers);
		}
		#endregion

		#region CreateTexture(s)
		/// <summary>
		/// Creates one texture object and returns it's name.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the effective texture target.</param>
		/// <returns>The name of the new texture object.</returns>
		public static uint CreateTexture(glTextureTarget target)
		{
			uint ret;
			_CreateTexture(target, 1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one texture object and returns it's name.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the effective texture target.</param>
		/// <param name="texture">Returns the name of the new texture object.</param>
		public static void CreateTexture(glTextureTarget target, out uint texture)
		{
			_CreateTexture(target, 1, out texture);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many texture objects and returns their names as array.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the effective texture target.</param>
		/// <param name="count">The number of texture objects to be created.</param>
		/// <returns>The names of the new texture objects as array.</returns>
		public static uint[] CreateTextures(glTextureTarget target, int count)
		{
			uint[] ret=new uint[count];
			_CreateTextures(target, count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many texture objects.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the effective texture target.</param>
		/// <param name="count">The number of texture objects to be created.</param>
		/// <param name="textures">Returns the name of the new texture objects.</param>
		public static void CreateTextures(glTextureTarget target, int count, uint[] textures)
		{
			_CreateTextures(target, count, textures);
		}
		#endregion

		#region TextureBufferRange
		/// <summary>
		/// Attaches a range of a buffer object's data store to a buffer texture object.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The length of the region.</param>
		public static void TextureBufferRange(uint texture, glInternalFormat internalformat, uint buffer, int offset, int size)
		{
			if(IntPtr.Size==4) TextureBufferRange_32(texture, internalformat, buffer, offset, size);
			else TextureBufferRange_64(texture, internalformat, buffer, offset, size);
		}

		/// <summary>
		/// Attaches a range of a buffer object's data store to a buffer texture object.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="buffer">The name of the buffer object.</param>
		/// <param name="offset">The offset into the data store.</param>
		/// <param name="size">The length of the region.</param>
		public static void TextureBufferRange(uint texture, glInternalFormat internalformat, uint buffer, long offset, long size)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				TextureBufferRange_32(texture, internalformat, buffer, (int)offset, (int)size);
			}
			else TextureBufferRange_64(texture, internalformat, buffer, offset, size);
		}
		#endregion

		#region TextureSubImage1D
		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, IntPtr pixels)
		{
			_TextureSubImage1D(texture, level, xoffset, width, format, type, pixels);
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, int offset)
		{
			_TextureSubImage1D(texture, level, xoffset, width, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_TextureSubImage1D(texture, level, xoffset, width, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage1D(uint texture, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage1D(texture, level, xoffset, width, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region TextureSubImage2D
		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, IntPtr pixels)
		{
			_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, pixels);
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, int offset)
		{
			_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region TextureSubImage3D
		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr pixels)
		{
			_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int offset)
		{
			_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region CompressedTextureSubImage1D
		/// <summary>
		/// Loads a compressed texture as part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, glInternalFormat format, int imageSize, int offset)
		{
			_CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, glInternalFormat format, int imageSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 1D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void CompressedTextureSubImage1D(uint texture, int level, int xoffset, int width, glInternalFormat format, int imageSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_CompressedTextureSubImage1D(texture, level, xoffset, width, format, imageSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region CompressedTextureSubImage2D
		/// <summary>
		/// Loads a compressed texture as part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glInternalFormat format, int imageSize, int offset)
		{
			_CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glInternalFormat format, int imageSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 2D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void CompressedTextureSubImage2D(uint texture, int level, int xoffset, int yoffset, int width, int height, glInternalFormat format, int imageSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_CompressedTextureSubImage2D(texture, level, xoffset, yoffset, width, height, format, imageSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region CompressedTextureSubImage3D
		/// <summary>
		/// Loads a compressed texture as part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glInternalFormat format, int imageSize, int offset)
		{
			_CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glInternalFormat format, int imageSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a compressed texture as part a 3D texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the format of the compressed data.</param>
		/// <param name="imageSize">Size of the compressed texture in bytes.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void CompressedTextureSubImage3D(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glInternalFormat format, int imageSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_CompressedTextureSubImage3D(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region TextureParameteri
		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, int param)
		{
			_TextureParameteri(texture, pname, param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture filtering parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glFilter param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture wrapping parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glTextureWrapMode param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glTextureCompareMode param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glFunc param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.DEPTH_STENCIL_TEXTURE_MODE"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glDepthStencilTextureMode param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameters of texture object.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture swizzle parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void TextureParameteri(uint texture, glTextureParameter pname, glTextureSwizzleValue param)
		{
			_TextureParameteri(texture, pname, (int)param);
		}
		#endregion

		#region GetTextureImage
		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels)
		{
			_GetTextureImage(texture, level, format, type, bufSize, pixels);
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, int offset)
		{
			_GetTextureImage(texture, level, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetTextureImage(texture, level, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int bufSize, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureImage(texture, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region GetCompressedTextureImage
		/// <summary>
		/// Read a texture as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetCompressedTextureImage(uint texture, int level, int bufSize, int offset)
		{
			_GetCompressedTextureImage(texture, level, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Read a texture as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetCompressedTextureImage(uint texture, int level, int bufSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetCompressedTextureImage(texture, level, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Read a texture as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetCompressedTextureImage(uint texture, int level, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetCompressedTextureImage(texture, level, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region GetTextureParameteri(v)
		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out int param)
		{
			_GetTextureParameteri(texture, pname, out param);
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glFilter param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glFilter)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glTextureWrapMode param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glTextureWrapMode)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glTextureCompareMode param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glTextureCompareMode)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glFunc param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glFunc)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.DEPTH_STENCIL_TEXTURE_MODE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glDepthStencilTextureMode param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glDepthStencilTextureMode)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_TARGET"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glTextureTarget param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glTextureTarget)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.IMAGE_FORMAT_COMPATIBILITY_TYPE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glImageFormatCompatibilityType param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glImageFormatCompatibilityType)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetTextureParameteri(uint texture, glTextureParameter pname, out glTextureSwizzleValue param)
		{
			int ret;
			_GetTextureParameteri(texture, pname, out ret);
			param=(glTextureSwizzleValue)ret;
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetTextureParameteriv(uint texture, glTextureParameter pname, int[] @params)
		{
			_GetTextureParameteriv(texture, pname, @params);
		}

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetTextureParameteriv(uint texture, glTextureParameter pname, glTextureSwizzleValue[] @params)
		{
			int[] ret=new int[@params.Length];
			_GetTextureParameteriv(texture, pname, ret);
			for(int i=0; i<ret.Length; i++) @params[i]=(glTextureSwizzleValue)ret[i];
		}
		#endregion

		#region CreateVertexArray(s)
		/// <summary>
		/// Creates one vertex array object and returns it's name.
		/// </summary>
		/// <returns>The name of the new vertex array object.</returns>
		public static uint CreateVertexArray()
		{
			uint ret;
			_CreateVertexArray(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one vertex array object and returns it's name.
		/// </summary>
		/// <param name="array">Returns the name of the new vertex array object.</param>
		public static void CreateVertexArray(out uint array)
		{
			_CreateVertexArray(1, out array);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many vertex array objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of vertex array objects to be created.</param>
		/// <returns>The names of the new vertex array objects as array.</returns>
		public static uint[] CreateVertexArrays(int count)
		{
			uint[] ret=new uint[count];
			_CreateVertexArrays(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many vertex array objects.
		/// </summary>
		/// <param name="count">The number of vertex array objects to be created.</param>
		/// <param name="arrays">Returns the name of the new vertex array objects.</param>
		public static void CreateVertexArrays(int count, uint[] arrays)
		{
			_CreateVertexArrays(count, arrays);
		}
		#endregion

		#region VertexArrayVertexBuffer
		/// <summary>
		/// Binds a buffer to a vertex buffer binding point.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="bindingindex">The index of the vertex buffer binding point to which to bind the buffer.</param>
		/// <param name="buffer">The name of a buffer.</param>
		/// <param name="offset">The offset of the first element of the buffer.</param>
		/// <param name="stride">The distance between elements within the buffer.</param>
		public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, int offset, int stride)
		{
			if(IntPtr.Size==4) VertexArrayVertexBuffer_32(vaobj, bindingindex, buffer, offset, stride);
			else VertexArrayVertexBuffer_64(vaobj, bindingindex, buffer, offset, stride);
		}

		/// <summary>
		/// Binds a buffer to a vertex buffer binding point.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="bindingindex">The index of the vertex buffer binding point to which to bind the buffer.</param>
		/// <param name="buffer">The name of a buffer.</param>
		/// <param name="offset">The offset of the first element of the buffer.</param>
		/// <param name="stride">The distance between elements within the buffer.</param>
		public static void VertexArrayVertexBuffer(uint vaobj, uint bindingindex, uint buffer, long offset, int stride)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);

				VertexArrayVertexBuffer_32(vaobj, bindingindex, buffer, (int)offset, stride);
			}
			else VertexArrayVertexBuffer_64(vaobj, bindingindex, buffer, offset, stride);
		}
		#endregion

		#region VertexArrayVertexBuffers
		/// <summary>
		/// Attaches multiple buffer objects to a vertex array object.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="first">The first vertex buffer binding point to which a buffer object is to be bound.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets to associate with the binding points.</param>
		/// <param name="strides">The strides to associate with the binding points.</param>
		public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			if(IntPtr.Size==4) VertexArrayVertexBuffers_32(vaobj, first, count, buffers, offsets, strides);
			else
			{
				if(buffers==null)
				{
					VertexArrayVertexBuffers_64(vaobj, first, count, null, null, null);
					return;
				}

				long[] lOffsets=new long[offsets.Length];
				Array.Copy(offsets, lOffsets, offsets.Length);

				VertexArrayVertexBuffers_64(vaobj, first, count, buffers, lOffsets, strides);
			}
		}

		/// <summary>
		/// Attaches multiple buffer objects to a vertex array object.
		/// </summary>
		/// <param name="vaobj">The name of the vertex array object.</param>
		/// <param name="first">The first vertex buffer binding point to which a buffer object is to be bound.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets to associate with the binding points.</param>
		/// <param name="strides">The strides to associate with the binding points.</param>
		public static void VertexArrayVertexBuffers(uint vaobj, uint first, int count, uint[] buffers, long[] offsets, int[] strides)
		{
			if(IntPtr.Size==4)
			{
				if(buffers==null)
				{
					VertexArrayVertexBuffers_32(vaobj, first, count, null, null, null);
					return;
				}

				int[] iOffsets=new int[first+count];
				for(int i=0; i<count; i++)
				{
					long offset=offsets[first+i];
					if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offsets", PlatformArrayErrorString);
					iOffsets[first+i]=(int)offset;
				}

				VertexArrayVertexBuffers_32(vaobj, first, count, buffers, iOffsets, strides);
			}
			else VertexArrayVertexBuffers_64(vaobj, first, count, buffers, offsets, strides);
		}
		#endregion

		#region CreateSampler(s)
		/// <summary>
		/// Creates one sampler object and returns it's name.
		/// </summary>
		/// <returns>The name of the new sampler object.</returns>
		public static uint CreateSampler()
		{
			uint ret;
			_CreateSampler(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one sampler object and returns it's name.
		/// </summary>
		/// <param name="sampler">Returns the name of the new sampler object.</param>
		public static void CreateSampler(out uint sampler)
		{
			_CreateSampler(1, out sampler);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many sampler objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of sampler objects to be created.</param>
		/// <returns>The names of the new sampler objects as array.</returns>
		public static uint[] CreateSamplers(int count)
		{
			uint[] ret=new uint[count];
			_CreateSamplers(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many sampler objects.
		/// </summary>
		/// <param name="count">The number of sampler objects to be created.</param>
		/// <param name="samplers">Returns the name of the new sampler objects.</param>
		public static void CreateSamplers(int count, uint[] samplers)
		{
			_CreateSamplers(count, samplers);
		}
		#endregion

		#region CreateProgramPipeline(s)
		/// <summary>
		/// Creates one program pipeline object and returns it's name.
		/// </summary>
		/// <returns>The name of the new program pipeline object.</returns>
		public static uint CreateProgramPipeline()
		{
			uint ret;
			_CreateProgramPipeline(1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one program pipeline object and returns it's name.
		/// </summary>
		/// <param name="pipeline">Returns the name of the new program pipeline object.</param>
		public static void CreateProgramPipeline(out uint pipeline)
		{
			_CreateProgramPipeline(1, out pipeline);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many program pipeline objects and returns their names as array.
		/// </summary>
		/// <param name="count">The number of program pipeline objects to be created.</param>
		/// <returns>The names of the new program pipeline objects as array.</returns>
		public static uint[] CreateProgramPipelines(int count)
		{
			uint[] ret=new uint[count];
			_CreateProgramPipelines(count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many program pipeline objects.
		/// </summary>
		/// <param name="count">The number of program pipeline objects to be created.</param>
		/// <param name="pipelines">Returns the name of the new program pipeline objects.</param>
		public static void CreateProgramPipelines(int count, uint[] pipelines)
		{
			_CreateProgramPipelines(count, pipelines);
		}
		#endregion

		#region CreateQuery/CreateQueries
		/// <summary>
		/// Creates one query object and returns it's name.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the query type.</param>
		/// <returns>The name of the new query object.</returns>
		public static uint CreateQuery(glQueryTarget target)
		{
			uint ret;
			_CreateQuery(target, 1, out ret);
			return ret;
		}

		/// <summary>
		/// Creates one query object and returns it's name.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the query type.</param>
		/// <param name="id">Returns the name of the new query object.</param>
		public static void CreateQuery(glQueryTarget target, out uint id)
		{
			_CreateQuery(target, 1, out id);
		}

		/// <summary>
		/// Creates <paramref name="count"/> many query objects and returns their names as array.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the query type.</param>
		/// <param name="count">The number of query objects to be created.</param>
		/// <returns>The names of the new query objects as array.</returns>
		public static uint[] CreateQueries(glQueryTarget target, int count)
		{
			uint[] ret=new uint[count];
			_CreateQueries(target, count, ret);
			return ret;
		}

		/// <summary>
		/// Creates <paramref name="count"/> many query objects.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the query type.</param>
		/// <param name="count">The number of query objects to be created.</param>
		/// <param name="ids">Returns the name of the new query objects.</param>
		public static void CreateQueries(glQueryTarget target, int count, uint[] ids)
		{
			_CreateQueries(target, count, ids);
		}
		#endregion

		#region GetQueryBufferObject
		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjecti64v(uint id, uint buffer, glQueryObjectParameter pname, int offset)
		{
			if(IntPtr.Size==4) GetQueryBufferObjecti64v_32(id, buffer, pname, offset);
			else GetQueryBufferObjecti64v_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjecti64v(uint id, uint buffer, glQueryObjectParameter pname, long offset)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);

				GetQueryBufferObjecti64v_32(id, buffer, pname, (int)offset);
			}
			else GetQueryBufferObjecti64v_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectiv(uint id, uint buffer, glQueryObjectParameter pname, int offset)
		{
			if(IntPtr.Size==4) GetQueryBufferObjectiv_32(id, buffer, pname, offset);
			else GetQueryBufferObjectiv_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectiv(uint id, uint buffer, glQueryObjectParameter pname, long offset)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);

				GetQueryBufferObjectiv_32(id, buffer, pname, (int)offset);
			}
			else GetQueryBufferObjectiv_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectui64v(uint id, uint buffer, glQueryObjectParameter pname, int offset)
		{
			if(IntPtr.Size==4) GetQueryBufferObjectui64v_32(id, buffer, pname, offset);
			else GetQueryBufferObjectui64v_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectui64v(uint id, uint buffer, glQueryObjectParameter pname, long offset)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);

				GetQueryBufferObjectui64v_32(id, buffer, pname, (int)offset);
			}
			else GetQueryBufferObjectui64v_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectuiv(uint id, uint buffer, glQueryObjectParameter pname, int offset)
		{
			if(IntPtr.Size==4) GetQueryBufferObjectuiv_32(id, buffer, pname, offset);
			else GetQueryBufferObjectuiv_64(id, buffer, pname, offset);
		}

		/// <summary>
		/// Writes the parameters of a query into a query buffer object.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="buffer">The name of the query buffer object to write into.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The object into the query buffer object to write into.</param>
		public static void GetQueryBufferObjectuiv(uint id, uint buffer, glQueryObjectParameter pname, long offset)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);

				GetQueryBufferObjectuiv_32(id, buffer, pname, (int)offset);
			}
			else GetQueryBufferObjectuiv_64(id, buffer, pname, offset);
		}
		#endregion

		#region GetTextureSubImage
		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels)
		{
			_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, pixels);
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, int offset)
		{
			_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, long offset)
		{
			_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int bufSize, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region GetCompressedTextureSubImage
		/// <summary>
		/// Reads/Copies all or part of a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/> as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, int offset)
		{
			_GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/> as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies all or part of a texture into client memory as compressed texture.
		/// </summary>
		/// <param name="texture">The name of the texture object.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in Z direction.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetCompressedTextureSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetCompressedTextureSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region GetnCompressedTexImage
		/// <summary>
		/// Reads/Copies a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/> as compressed texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetnCompressedTexImage(glTextureProxyTarget target, int level, int bufSize, int offset)
		{
			_GetnCompressedTexImage(target, level, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/> as compressed texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetnCompressedTexImage(glTextureProxyTarget target, int level, int bufSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetnCompressedTexImage(target, level, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies a texture into client memory as compressed texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnCompressedTexImage(glTextureProxyTarget target, int level, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnCompressedTexImage(target, level, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region GetnTexImage
		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels)
		{
			_GetnTexImage(target, level, format, type, bufSize, pixels);
		}

		/// <summary>
		/// Reads/Copies a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, int offset)
		{
			_GetnTexImage(target, level, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies a texture into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetnTexImage(target, level, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads/Copies a texture into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void GetnTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int bufSize, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_GetnTexImage(target, level, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region ReadnPixels
		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, IntPtr pixels)
		{
			_ReadnPixels(x, y, width, height, format, type, bufSize, pixels);
		}

		/// <summary>
		/// Reads pixels form the framebuffer into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, int offset)
		{
			_ReadnPixels(x, y, width, height, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads pixels form the framebuffer into <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of the receiving buffer in bytes.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, long offset)
		{
			_ReadnPixels(x, y, width, height, format, type, bufSize, (IntPtr)offset);
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, byte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, sbyte[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, short[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, ushort[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, int[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, uint[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, long[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, ulong[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, float[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Reads pixels form the framebuffer into client memory. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="bufSize">Size of <paramref name="pixels"/> in bytes.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		public static void ReadnPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int bufSize, double[] pixels)
		{
			GCHandle hPixels=GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_ReadnPixels(x, y, width, height, format, type, bufSize, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion
		#endregion

		private static void Load_VERSION_4_5()
		{
			ClipControl=GetAddress<glClipControl>("glClipControl");
			_CreateTransformFeedback=GetAddress<glCreateTransformFeedback>("glCreateTransformFeedbacks");
			_CreateTransformFeedbacks=GetAddress<glCreateTransformFeedbacks>("glCreateTransformFeedbacks");
			TransformFeedbackBufferBase=GetAddress<glTransformFeedbackBufferBase>("glTransformFeedbackBufferBase");
			GetTransformFeedbacki=GetAddress<glGetTransformFeedbacki>("glGetTransformFeedbackiv");
			GetTransformFeedbackiv=GetAddress<glGetTransformFeedbackiv>("glGetTransformFeedbackiv");
			GetTransformFeedbacki_=GetAddress<glGetTransformFeedbacki_>("glGetTransformFeedbacki_v");
			GetTransformFeedbacki_v=GetAddress<glGetTransformFeedbacki_v>("glGetTransformFeedbacki_v");
			GetTransformFeedbacki64_=GetAddress<glGetTransformFeedbacki64_>("glGetTransformFeedbacki64_v");
			GetTransformFeedbacki64_v=GetAddress<glGetTransformFeedbacki64_v>("glGetTransformFeedbacki64_v");
			_CreateBuffer=GetAddress<glCreateBuffer>("glCreateBuffers");
			_CreateBuffers=GetAddress<glCreateBuffers>("glCreateBuffers");
			_ClearNamedBufferData=GetAddress<glClearNamedBufferData>("glClearNamedBufferData");
			MapNamedBuffer=GetAddress<glMapNamedBuffer>("glMapNamedBuffer");
			UnmapNamedBuffer=GetAddress<glUnmapNamedBuffer>("glUnmapNamedBuffer");
			GetNamedBufferParameteri=GetAddress<glGetNamedBufferParameteri>("glGetNamedBufferParameteriv");
			GetNamedBufferParameteriv=GetAddress<glGetNamedBufferParameteriv>("glGetNamedBufferParameteriv");
			GetNamedBufferParameteri64=GetAddress<glGetNamedBufferParameteri64>("glGetNamedBufferParameteri64v");
			GetNamedBufferParameteri64v=GetAddress<glGetNamedBufferParameteri64v>("glGetNamedBufferParameteri64v");
			GetNamedBufferPointerv=GetAddress<glGetNamedBufferPointerv>("glGetNamedBufferPointerv");
			_CreateFramebuffer=GetAddress<glCreateFramebuffer>("glCreateFramebuffers");
			_CreateFramebuffers=GetAddress<glCreateFramebuffers>("glCreateFramebuffers");
			NamedFramebufferRenderbuffer=GetAddress<glNamedFramebufferRenderbuffer>("glNamedFramebufferRenderbuffer");
			NamedFramebufferParameteri=GetAddress<glNamedFramebufferParameteri>("glNamedFramebufferParameteri");
			NamedFramebufferTexture=GetAddress<glNamedFramebufferTexture>("glNamedFramebufferTexture");
			NamedFramebufferTextureLayer=GetAddress<glNamedFramebufferTextureLayer>("glNamedFramebufferTextureLayer");
			NamedFramebufferDrawBuffer=GetAddress<glNamedFramebufferDrawBuffer>("glNamedFramebufferDrawBuffer");
			NamedFramebufferDrawBuffers=GetAddress<glNamedFramebufferDrawBuffers>("glNamedFramebufferDrawBuffers");
			NamedFramebufferReadBuffer=GetAddress<glNamedFramebufferReadBuffer>("glNamedFramebufferReadBuffer");
			InvalidateNamedFramebufferData=GetAddress<glInvalidateNamedFramebufferData>("glInvalidateNamedFramebufferData");
			InvalidateNamedFramebufferSubData=GetAddress<glInvalidateNamedFramebufferSubData>("glInvalidateNamedFramebufferSubData");
			ClearNamedFramebufferiv=GetAddress<glClearNamedFramebufferiv>("glClearNamedFramebufferiv");
			ClearNamedFramebufferuiv=GetAddress<glClearNamedFramebufferuiv>("glClearNamedFramebufferuiv");
			ClearNamedFramebufferfv=GetAddress<glClearNamedFramebufferfv>("glClearNamedFramebufferfv");
			ClearNamedFramebufferfi=GetAddress<glClearNamedFramebufferfi>("glClearNamedFramebufferfi");
			BlitNamedFramebuffer=GetAddress<glBlitNamedFramebuffer>("glBlitNamedFramebuffer");
			CheckNamedFramebufferStatus=GetAddress<glCheckNamedFramebufferStatus>("glCheckNamedFramebufferStatus");
			GetNamedFramebufferParameteri=GetAddress<glGetNamedFramebufferParameteri>("glGetNamedFramebufferParameteriv");
			GetNamedFramebufferParameteriv=GetAddress<glGetNamedFramebufferParameteriv>("glGetNamedFramebufferParameteriv");
			GetNamedFramebufferAttachmentParameteri=GetAddress<glGetNamedFramebufferAttachmentParameteri>("glGetNamedFramebufferAttachmentParameteriv");
			GetNamedFramebufferAttachmentParameteriv=GetAddress<glGetNamedFramebufferAttachmentParameteriv>("glGetNamedFramebufferAttachmentParameteriv");
			_CreateRenderbuffer=GetAddress<glCreateRenderbuffer>("glCreateRenderbuffers");
			_CreateRenderbuffers=GetAddress<glCreateRenderbuffers>("glCreateRenderbuffers");
			NamedRenderbufferStorage=GetAddress<glNamedRenderbufferStorage>("glNamedRenderbufferStorage");
			NamedRenderbufferStorageMultisample=GetAddress<glNamedRenderbufferStorageMultisample>("glNamedRenderbufferStorageMultisample");
			GetNamedRenderbufferParameteri=GetAddress<glGetNamedRenderbufferParameteri>("glGetNamedRenderbufferParameteriv");
			GetNamedRenderbufferParameteriv=GetAddress<glGetNamedRenderbufferParameteriv>("glGetNamedRenderbufferParameteriv");
			_CreateTexture=GetAddress<glCreateTexture>("glCreateTextures");
			_CreateTextures=GetAddress<glCreateTextures>("glCreateTextures");
			TextureBuffer=GetAddress<glTextureBuffer>("glTextureBuffer");
			TextureStorage1D=GetAddress<glTextureStorage1D>("glTextureStorage1D");
			TextureStorage2D=GetAddress<glTextureStorage2D>("glTextureStorage2D");
			TextureStorage3D=GetAddress<glTextureStorage3D>("glTextureStorage3D");
			TextureStorage2DMultisample=GetAddress<glTextureStorage2DMultisample>("glTextureStorage2DMultisample");
			TextureStorage3DMultisample=GetAddress<glTextureStorage3DMultisample>("glTextureStorage3DMultisample");
			_TextureSubImage1D=GetAddress<glTextureSubImage1D>("glTextureSubImage1D");
			_TextureSubImage2D=GetAddress<glTextureSubImage2D>("glTextureSubImage2D");
			_TextureSubImage3D=GetAddress<glTextureSubImage3D>("glTextureSubImage3D");
			_CompressedTextureSubImage1D=GetAddress<glCompressedTextureSubImage1D>("glCompressedTextureSubImage1D");
			_CompressedTextureSubImage2D=GetAddress<glCompressedTextureSubImage2D>("glCompressedTextureSubImage2D");
			_CompressedTextureSubImage3D=GetAddress<glCompressedTextureSubImage3D>("glCompressedTextureSubImage3D");
			CopyTextureSubImage1D=GetAddress<glCopyTextureSubImage1D>("glCopyTextureSubImage1D");
			CopyTextureSubImage2D=GetAddress<glCopyTextureSubImage2D>("glCopyTextureSubImage2D");
			CopyTextureSubImage3D=GetAddress<glCopyTextureSubImage3D>("glCopyTextureSubImage3D");
			TextureParameterf=GetAddress<glTextureParameterf>("glTextureParameterf");
			TextureParameterfv=GetAddress<glTextureParameterfv>("glTextureParameterfv");
			_TextureParameteri=GetAddress<glTextureParameteri>("glTextureParameteri");
			TextureParameteriv=GetAddress<glTextureParameteriv>("glTextureParameteriv");
			TextureParameterIiv=GetAddress<glTextureParameterIiv>("glTextureParameterIiv");
			TextureParameterIuiv=GetAddress<glTextureParameterIuiv>("glTextureParameterIuiv");
			GenerateTextureMipmap=GetAddress<glGenerateTextureMipmap>("glGenerateTextureMipmap");
			BindTextureUnit=GetAddress<glBindTextureUnit>("glBindTextureUnit");
			_GetTextureImage=GetAddress<glGetTextureImage>("glGetTextureImage");
			_GetCompressedTextureImage=GetAddress<glGetCompressedTextureImage>("glGetCompressedTextureImage");
			GetTextureLevelParameterf=GetAddress<glGetTextureLevelParameterf>("glGetTextureLevelParameterfv");
			GetTextureLevelParameterfv=GetAddress<glGetTextureLevelParameterfv>("glGetTextureLevelParameterfv");
			GetTextureLevelParameteri=GetAddress<glGetTextureLevelParameteri>("glGetTextureLevelParameteriv");
			GetTextureLevelParameteriv=GetAddress<glGetTextureLevelParameteriv>("glGetTextureLevelParameteriv");
			GetTextureParameterf=GetAddress<glGetTextureParameterf>("glGetTextureParameterfv");
			GetTextureParameterfv=GetAddress<glGetTextureParameterfv>("glGetTextureParameterfv");
			_GetTextureParameteri=GetAddress<glGetTextureParameteri>("glGetTextureParameteriv");
			_GetTextureParameteriv=GetAddress<glGetTextureParameteriv>("glGetTextureParameteriv");
			GetTextureParameterIi=GetAddress<glGetTextureParameterIi>("glGetTextureParameterIiv");
			GetTextureParameterIiv=GetAddress<glGetTextureParameterIiv>("glGetTextureParameterIiv");
			GetTextureParameterIui=GetAddress<glGetTextureParameterIui>("glGetTextureParameterIuiv");
			GetTextureParameterIuiv=GetAddress<glGetTextureParameterIuiv>("glGetTextureParameterIuiv");
			_CreateVertexArray=GetAddress<glCreateVertexArray>("glCreateVertexArrays");
			_CreateVertexArrays=GetAddress<glCreateVertexArrays>("glCreateVertexArrays");
			DisableVertexArrayAttrib=GetAddress<glDisableVertexArrayAttrib>("glDisableVertexArrayAttrib");
			EnableVertexArrayAttrib=GetAddress<glEnableVertexArrayAttrib>("glEnableVertexArrayAttrib");
			VertexArrayElementBuffer=GetAddress<glVertexArrayElementBuffer>("glVertexArrayElementBuffer");
			VertexArrayAttribBinding=GetAddress<glVertexArrayAttribBinding>("glVertexArrayAttribBinding");
			VertexArrayAttribFormat=GetAddress<glVertexArrayAttribFormat>("glVertexArrayAttribFormat");
			VertexArrayAttribIFormat=GetAddress<glVertexArrayAttribIFormat>("glVertexArrayAttribIFormat");
			VertexArrayAttribLFormat=GetAddress<glVertexArrayAttribLFormat>("glVertexArrayAttribLFormat");
			VertexArrayBindingDivisor=GetAddress<glVertexArrayBindingDivisor>("glVertexArrayBindingDivisor");
			GetVertexArrayi=GetAddress<glGetVertexArrayi>("glGetVertexArrayiv");
			GetVertexArrayiv=GetAddress<glGetVertexArrayiv>("glGetVertexArrayiv");
			GetVertexArrayIndexedi=GetAddress<glGetVertexArrayIndexedi>("glGetVertexArrayIndexediv");
			GetVertexArrayIndexediv=GetAddress<glGetVertexArrayIndexediv>("glGetVertexArrayIndexediv");
			GetVertexArrayIndexed64i=GetAddress<glGetVertexArrayIndexed64i>("glGetVertexArrayIndexed64iv");
			GetVertexArrayIndexed64iv=GetAddress<glGetVertexArrayIndexed64iv>("glGetVertexArrayIndexed64iv");
			_CreateSampler=GetAddress<glCreateSampler>("glCreateSamplers");
			_CreateSamplers=GetAddress<glCreateSamplers>("glCreateSamplers");
			_CreateProgramPipeline=GetAddress<glCreateProgramPipeline>("glCreateProgramPipelines");
			_CreateProgramPipelines=GetAddress<glCreateProgramPipelines>("glCreateProgramPipelines");
			_CreateQuery=GetAddress<glCreateQuery>("glCreateQueries");
			_CreateQueries=GetAddress<glCreateQueries>("glCreateQueries");
			MemoryBarrierByRegion=GetAddress<glMemoryBarrierByRegion>("glMemoryBarrierByRegion");
			_GetTextureSubImage=GetAddress<glGetTextureSubImage>("glGetTextureSubImage");
			_GetCompressedTextureSubImage=GetAddress<glGetCompressedTextureSubImage>("glGetCompressedTextureSubImage");
			GetGraphicsResetStatus=GetAddress<glGetGraphicsResetStatus>("glGetGraphicsResetStatus");
			_GetnCompressedTexImage=GetAddress<glGetnCompressedTexImage>("glGetnCompressedTexImage");
			_GetnTexImage=GetAddress<glGetnTexImage>("glGetnTexImage");
			GetnUniformdv=GetAddress<glGetnUniformdv>("glGetnUniformdv");
			GetnUniformfv=GetAddress<glGetnUniformfv>("glGetnUniformfv");
			GetnUniformiv=GetAddress<glGetnUniformiv>("glGetnUniformiv");
			GetnUniformuiv=GetAddress<glGetnUniformuiv>("glGetnUniformuiv");
			_ReadnPixels=GetAddress<glReadnPixels>("glReadnPixels");
			TextureBarrier=GetAddress<glTextureBarrier>("glTextureBarrier");

			bool platformDependend;
			if(IntPtr.Size==4)
			{
				TransformFeedbackBufferRange_32=GetAddress<glTransformFeedbackBufferRange_32>("glTransformFeedbackBufferRange");
				NamedBufferStorage_32=GetAddress<glNamedBufferStorage_32>("glNamedBufferStorage");
				NamedBufferData_32=GetAddress<glNamedBufferData_32>("glNamedBufferData");
				NamedBufferSubData_32=GetAddress<glNamedBufferSubData_32>("glNamedBufferSubData");
				CopyNamedBufferSubData_32=GetAddress<glCopyNamedBufferSubData_32>("glCopyNamedBufferSubData");
				ClearNamedBufferSubData_32=GetAddress<glClearNamedBufferSubData_32>("glClearNamedBufferSubData");
				MapNamedBufferRange_32=GetAddress<glMapNamedBufferRange_32>("glMapNamedBufferRange");
				FlushMappedNamedBufferRange_32=GetAddress<glFlushMappedNamedBufferRange_32>("glFlushMappedNamedBufferRange");
				GetNamedBufferSubData_32=GetAddress<glGetNamedBufferSubData_32>("glGetNamedBufferSubData");
				TextureBufferRange_32=GetAddress<glTextureBufferRange_32>("glTextureBufferRange");
				VertexArrayVertexBuffer_32=GetAddress<glVertexArrayVertexBuffer_32>("glVertexArrayVertexBuffer");
				VertexArrayVertexBuffers_32=GetAddress<glVertexArrayVertexBuffers_32>("glVertexArrayVertexBuffers");
				GetQueryBufferObjecti64v_32=GetAddress<glGetQueryBufferObjecti64v_32>("glGetQueryBufferObjecti64v");
				GetQueryBufferObjectiv_32=GetAddress<glGetQueryBufferObjectiv_32>("glGetQueryBufferObjectiv");
				GetQueryBufferObjectui64v_32=GetAddress<glGetQueryBufferObjectui64v_32>("glGetQueryBufferObjectui64v");
				GetQueryBufferObjectuiv_32=GetAddress<glGetQueryBufferObjectuiv_32>("glGetQueryBufferObjectuiv");

				platformDependend=TransformFeedbackBufferRange_32!=null&&NamedBufferStorage_32!=null&&NamedBufferData_32!=null&&
					NamedBufferSubData_32!=null&&CopyNamedBufferSubData_32!=null&&ClearNamedBufferSubData_32!=null&&
					MapNamedBufferRange_32!=null&&FlushMappedNamedBufferRange_32!=null&&GetNamedBufferSubData_32!=null&&
					TextureBufferRange_32!=null&&VertexArrayVertexBuffer_32!=null&&VertexArrayVertexBuffers_32!=null&&
					GetQueryBufferObjecti64v_32!=null&&GetQueryBufferObjectiv_32!=null&&GetQueryBufferObjectui64v_32!=null&&
					GetQueryBufferObjectuiv_32!=null;
			}
			else
			{
				TransformFeedbackBufferRange_64=GetAddress<glTransformFeedbackBufferRange_64>("glTransformFeedbackBufferRange");
				NamedBufferStorage_64=GetAddress<glNamedBufferStorage_64>("glNamedBufferStorage");
				NamedBufferData_64=GetAddress<glNamedBufferData_64>("glNamedBufferData");
				NamedBufferSubData_64=GetAddress<glNamedBufferSubData_64>("glNamedBufferSubData");
				CopyNamedBufferSubData_64=GetAddress<glCopyNamedBufferSubData_64>("glCopyNamedBufferSubData");
				ClearNamedBufferSubData_64=GetAddress<glClearNamedBufferSubData_64>("glClearNamedBufferSubData");
				MapNamedBufferRange_64=GetAddress<glMapNamedBufferRange_64>("glMapNamedBufferRange");
				FlushMappedNamedBufferRange_64=GetAddress<glFlushMappedNamedBufferRange_64>("glFlushMappedNamedBufferRange");
				GetNamedBufferSubData_64=GetAddress<glGetNamedBufferSubData_64>("glGetNamedBufferSubData");
				TextureBufferRange_64=GetAddress<glTextureBufferRange_64>("glTextureBufferRange");
				VertexArrayVertexBuffer_64=GetAddress<glVertexArrayVertexBuffer_64>("glVertexArrayVertexBuffer");
				VertexArrayVertexBuffers_64=GetAddress<glVertexArrayVertexBuffers_64>("glVertexArrayVertexBuffers");
				GetQueryBufferObjecti64v_64=GetAddress<glGetQueryBufferObjecti64v_64>("glGetQueryBufferObjecti64v");
				GetQueryBufferObjectiv_64=GetAddress<glGetQueryBufferObjectiv_64>("glGetQueryBufferObjectiv");
				GetQueryBufferObjectui64v_64=GetAddress<glGetQueryBufferObjectui64v_64>("glGetQueryBufferObjectui64v");
				GetQueryBufferObjectuiv_64=GetAddress<glGetQueryBufferObjectuiv_64>("glGetQueryBufferObjectuiv");

				platformDependend=TransformFeedbackBufferRange_64!=null&&NamedBufferStorage_64!=null&&NamedBufferData_64!=null&&
					NamedBufferSubData_64!=null&&CopyNamedBufferSubData_64!=null&&ClearNamedBufferSubData_64!=null&&
					MapNamedBufferRange_64!=null&&FlushMappedNamedBufferRange_64!=null&&GetNamedBufferSubData_64!=null&&
					TextureBufferRange_64!=null&&VertexArrayVertexBuffer_64!=null&&VertexArrayVertexBuffers_64!=null&&
					GetQueryBufferObjecti64v_64!=null&&GetQueryBufferObjectiv_64!=null&&GetQueryBufferObjectui64v_64!=null&&
					GetQueryBufferObjectuiv_64!=null;
			}

			VERSION_4_5=VERSION_4_4&&ClipControl!=null&&_CreateTransformFeedbacks!=null&&TransformFeedbackBufferBase!=null&&
				GetTransformFeedbackiv!=null&&GetTransformFeedbacki_v!=null&&GetTransformFeedbacki64_v!=null&&_CreateBuffers!=null&&
				_ClearNamedBufferData!=null&&MapNamedBuffer!=null&&UnmapNamedBuffer!=null&&GetNamedBufferParameteriv!=null&&
				GetNamedBufferParameteri64v!=null&&GetNamedBufferPointerv!=null&&_CreateFramebuffers!=null&&NamedFramebufferRenderbuffer!=null&&
				NamedFramebufferParameteri!=null&&NamedFramebufferTexture!=null&&NamedFramebufferTextureLayer!=null&&
				NamedFramebufferDrawBuffers!=null&&NamedFramebufferReadBuffer!=null&&InvalidateNamedFramebufferData!=null&&
				InvalidateNamedFramebufferSubData!=null&&ClearNamedFramebufferiv!=null&&ClearNamedFramebufferuiv!=null&&
				ClearNamedFramebufferfv!=null&&ClearNamedFramebufferfi!=null&&BlitNamedFramebuffer!=null&&CheckNamedFramebufferStatus!=null&&
				GetNamedFramebufferParameteriv!=null&&GetNamedFramebufferAttachmentParameteriv!=null&&_CreateRenderbuffers!=null&&
				NamedRenderbufferStorage!=null&&NamedRenderbufferStorageMultisample!=null&&GetNamedRenderbufferParameteriv!=null&&
				_CreateTextures!=null&&TextureBuffer!=null&&TextureStorage1D!=null&&TextureStorage2D!=null&&TextureStorage3D!=null&&
				TextureStorage2DMultisample!=null&&TextureStorage3DMultisample!=null&&_TextureSubImage1D!=null&&_TextureSubImage2D!=null&&
				_TextureSubImage3D!=null&&_CompressedTextureSubImage1D!=null&&_CompressedTextureSubImage2D!=null&&
				_CompressedTextureSubImage3D!=null&&CopyTextureSubImage1D!=null&&CopyTextureSubImage2D!=null&&CopyTextureSubImage3D!=null&&
				TextureParameterfv!=null&&TextureParameteriv!=null&&TextureParameterIiv!=null&&
				TextureParameterIuiv!=null&&GenerateTextureMipmap!=null&&BindTextureUnit!=null&&_GetTextureImage!=null&&
				_GetCompressedTextureImage!=null&&GetTextureLevelParameterfv!=null&&GetTextureLevelParameteriv!=null&&
				GetTextureParameterfv!=null&&_GetTextureParameteriv!=null&&GetTextureParameterIiv!=null&&GetTextureParameterIuiv!=null&&
				_CreateVertexArrays!=null&&DisableVertexArrayAttrib!=null&&EnableVertexArrayAttrib!=null&&VertexArrayElementBuffer!=null&&
				VertexArrayAttribBinding!=null&&VertexArrayAttribFormat!=null&&VertexArrayAttribIFormat!=null&&VertexArrayAttribLFormat!=null&&
				VertexArrayBindingDivisor!=null&&GetVertexArrayiv!=null&&GetVertexArrayIndexediv!=null&&GetVertexArrayIndexed64iv!=null&&
				_CreateSamplers!=null&&_CreateProgramPipelines!=null&&_CreateQueries!=null&&MemoryBarrierByRegion!=null&&_GetTextureSubImage!=null&&
				_GetCompressedTextureSubImage!=null&&GetGraphicsResetStatus!=null&&_GetnCompressedTexImage!=null&&_GetnTexImage!=null&&
				GetnUniformdv!=null&&GetnUniformfv!=null&&GetnUniformiv!=null&&GetnUniformuiv!=null&&_ReadnPixels!=null&&
				TextureBarrier!=null&&platformDependend;
		}
	}
}
