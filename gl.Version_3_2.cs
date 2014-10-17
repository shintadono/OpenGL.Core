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
		internal delegate void glDrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int basevertex);
		internal delegate void glDrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, IntPtr indices, int basevertex);
		internal delegate void glDrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, int basevertex);
		internal delegate void glMultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, IntPtr[] indices, int drawcount, int[] basevertex);

		/// <summary>
		/// Sets the provoking vertex for flat shading.
		/// </summary>
		/// <param name="mode">A <see cref="glProvokingVertexMode"/> specifying the vertex.</param>
		public delegate void glProvokingVertex(glProvokingVertexMode mode);

		/// <summary>
		/// Creates a sync object and inserts it into the command stream.
		/// </summary>
		/// <param name="condition">Must be <see cref="glSyncCondition.SYNC_GPU_COMMANDS_COMPLETE"/>.</param>
		/// <param name="flags">Must be zero.</param>
		/// <returns>Return the handle sync object.</returns>
		public delegate IntPtr glFenceSync(glSyncCondition condition, glSyncFlag flags);

		/// <summary>
		/// Determines if a handle is a sync object.
		/// </summary>
		/// <param name="sync">The handle to check.</param>
		/// <returns><b>true</b> if <paramref name="sync"/> is a sync object.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsSync(IntPtr sync);

		/// <summary>
		/// Deletes a sync object.
		/// </summary>
		/// <param name="sync">The handle to the sync object.</param>
		public delegate void glDeleteSync(IntPtr sync);

		/// <summary>
		/// Waits for a sync object for a time.
		/// </summary>
		/// <param name="sync">The handle to the sync object.</param>
		/// <param name="flags">A <see cref="glClientWaitSyncFlag"/> controlling command flushing behavior.</param>
		/// <param name="timeout">Timeout in nanoseconds.</param>
		/// <returns>Returns information on the waiting operation.</returns>
		public delegate glClientWaitSyncResult glClientWaitSync(IntPtr sync, glClientWaitSyncFlag flags, ulong timeout);

		/// <summary>
		/// Instructs the GL server to block until the specified sync object becomes signaled.
		/// </summary>
		/// <param name="sync">The handle to the sync object.</param>
		/// <param name="flags">Must be zero.</param>
		/// <param name="timeout">Must be <see cref="gl.TIMEOUT_IGNORED"/>.</param>
		public delegate void glWaitSync(IntPtr sync, glWaitSyncFlag flags, ulong timeout);

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetInteger64Parameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetInteger64(glGetInteger64Parameter pname, out long param);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetInteger64Parameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetInteger64v(glGetInteger64Parameter pname, long[] @params);

		/// <summary>
		/// Returns the value of parameters of sync objects.
		/// </summary>
		/// <param name="sync">The handle of the sync object.</param>
		/// <param name="pname">A <see cref="glSyncParameter"/> specifying the parameter.</param>
		/// <param name="bufSize">Must be one.</param>
		/// <param name="length">Will be one.</param>
		/// <param name="value">The requested value.</param>
		public delegate void glGetSynci(IntPtr sync, glSyncParameter pname, int bufSize, out int length, out int value);

		/// <summary>
		/// Returns the value(s) of parameters of sync objects.
		/// </summary>
		/// <param name="sync">The handle of the sync object.</param>
		/// <param name="pname">A <see cref="glSyncParameter"/> specifying the parameter.</param>
		/// <param name="bufSize">Size of the <paramref name="values"/> buffer.</param>
		/// <param name="length">The number of value(s) actually writter to <paramref name="values"/>.</param>
		/// <param name="values">The requested value(s).</param>
		public delegate void glGetSynciv(IntPtr sync, glSyncParameter pname, int bufSize, out int length, int[] values);

		/// <summary>
		/// Returns the value of an indexed parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetInteger64Parameter"/> specifying the parameter.</param>
		/// <param name="index"></param>
		/// <param name="data">Returns the requested value.</param>
		public delegate void glGetInteger64i_(glGetInteger64IndexedParameter target, uint index, out long data);

		/// <summary>
		/// Returns the value(s) of an indexed parameter.
		/// </summary>
		/// <param name="target">A <see cref="glGetInteger64Parameter"/> specifying the parameter.</param>
		/// <param name="index"></param>
		/// <param name="data">Returns the requested value(s).</param>
		public delegate void glGetInteger64i_v(glGetInteger64IndexedParameter target, uint index, long[] data);

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetBufferParameteri64(glBufferTarget target, glGetBufferParameter pname, out long param);

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetBufferParameteri64v(glBufferTarget target, glGetBufferParameter pname, long[] @params);

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		/// <param name="target">A <see cref="glFramebufferTarget"/> specifying the framebuffer target.</param>
		/// <param name="attachment">The framebuffer attachment.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level of the texture.</param>
		public delegate void glFramebufferTexture(glFramebufferTarget target, glBuffer attachment, uint texture, int level);

		/// <summary>
		/// Creates storage for a 2D multisample texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="samples">Number of samples.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
		public delegate void glTexImage2DMultisample(glTexture2DProxyTarget target, int samples, glInternalFormat internalformat, int width, int height, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

		/// <summary>
		/// Creates storage for a 3D multisample texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="samples">Number of samples.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="fixedsamplelocations">Specifies whether the image will use identical sample locations and the same number of samples for all texels in the image, and the sample locations will not depend on the internal format or size of the image.</param>
		public delegate void glTexImage3DMultisample(glTexture3DProxyTarget target, int samples, glInternalFormat internalformat, int width, int height, int depth, [MarshalAs(UnmanagedType.I1)] bool fixedsamplelocations);

		/// <summary>
		/// Retrieves the location of a sample.
		/// </summary>
		/// <param name="pname">Must be <see cref="glMultisampleParameter.SAMPLE_POSITION"/>.</param>
		/// <param name="index">The index of the sample.</param>
		/// <param name="val">A <b>float[2]</b> to receive the sample position.</param>
		public delegate void glGetMultisamplefv(glMultisampleParameter pname, uint index, float[] val);

		/// <summary>
		/// Sets the value of a sub-word of the sample mask.
		/// </summary>
		/// <param name="index">Specifies which 32-bit sub-word of the sample mask to update.</param>
		/// <param name="mask">The new mask value.</param>
		public delegate void glSampleMaski(uint index, uint mask);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 3.2 is available.
		/// </summary>
		public static bool VERSION_3_2;

		#region Delegates
		private static glDrawElementsBaseVertex _DrawElementsBaseVertex;
		private static glDrawRangeElementsBaseVertex _DrawRangeElementsBaseVertex;
		private static glDrawElementsInstancedBaseVertex _DrawElementsInstancedBaseVertex;
		private static glMultiDrawElementsBaseVertex _MultiDrawElementsBaseVertex;

		/// <summary>
		/// Sets the provoking vertex for flat shading.
		/// </summary>
		public static glProvokingVertex ProvokingVertex;

		/// <summary>
		/// Creates a sync object and inserts it into the command stream.
		/// </summary>
		public static glFenceSync FenceSync;

		/// <summary>
		/// Determines if a handle is a sync object.
		/// </summary>
		public static glIsSync IsSync;

		/// <summary>
		/// Deletes a sync object.
		/// </summary>
		public static glDeleteSync DeleteSync;

		/// <summary>
		/// Waits for a sync object for a time.
		/// </summary>
		public static glClientWaitSync ClientWaitSync;

		/// <summary>
		/// Instructs the GL server to block until the specified sync object becomes signaled.
		/// </summary>
		public static glWaitSync WaitSync;

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		public static glGetInteger64 GetInteger64;

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		public static glGetInteger64v GetInteger64v;

		/// <summary>
		/// Returns the value of parameters of sync objects.
		/// </summary>
		public static glGetSynci GetSynci;

		/// <summary>
		/// Returns the value(s) of parameters of sync objects.
		/// </summary>
		public static glGetSynciv GetSynciv;

		/// <summary>
		/// Returns the value of an indexed parameter.
		/// </summary>
		public static glGetInteger64i_ GetInteger64i_;

		/// <summary>
		/// Returns the value(s) of an indexed parameter.
		/// </summary>
		public static glGetInteger64i_v GetInteger64i_v;

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		public static glGetBufferParameteri64 GetBufferParameteri64;

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		public static glGetBufferParameteri64v GetBufferParameteri64v;

		/// <summary>
		/// Attachs a level of a texture as a buffer to a attachment of the currently bound framebuffer bound to a specific framebuffer target.
		/// </summary>
		public static glFramebufferTexture FramebufferTexture;

		/// <summary>
		/// Creates storage for a 2D multisample texture.
		/// </summary>
		public static glTexImage2DMultisample TexImage2DMultisample;

		/// <summary>
		/// Creates storage for a 3D multisample texture.
		/// </summary>
		public static glTexImage3DMultisample TexImage3DMultisample;

		/// <summary>
		/// Retrieves the location of a sample.
		/// </summary>
		public static glGetMultisamplefv GetMultisamplefv;

		/// <summary>
		/// Sets the value of a sub-word of the sample mask.
		/// </summary>
		public static glSampleMaski SampleMaski;
		#endregion

		#region Overloads
		#region DrawElementsBaseVertex
		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int basevertex)
		{
			_DrawElementsBaseVertex(mode, count, type, indices, basevertex);
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, byte[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, ushort[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, int[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsBaseVertex(glDrawMode mode, int count, glDrawElementsType type, uint[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}
		#endregion

		#region DrawRangeElementsBaseVertex
		/// <summary>
		/// Render primitives from array via a range of indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, IntPtr indices, int basevertex)
		{
			_DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
		}

		/// <summary>
		/// Render primitives from array via a range of indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, byte[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawRangeElementsBaseVertex(mode, start, end, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Render primitives from array via a range of indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, ushort[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawRangeElementsBaseVertex(mode, start, end, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Render primitives from array via a range of indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, int[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawRangeElementsBaseVertex(mode, start, end, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Render primitives from array via a range of indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawRangeElementsBaseVertex(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, uint[] indices, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawRangeElementsBaseVertex(mode, start, end, count, type, hIndices.AddrOfPinnedObject(), basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}
		#endregion

		#region DrawElementsInstancedBaseVertex
		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, int basevertex)
		{
			_DrawElementsInstancedBaseVertex(mode, count, type, indices, instancecount, basevertex);
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, byte[] indices, int instancecount, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, ushort[] indices, int instancecount, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, int[] indices, int instancecount, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void DrawElementsInstancedBaseVertex(glDrawMode mode, int count, glDrawElementsType type, uint[] indices, int instancecount, int basevertex)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertex(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex);
			}
			finally
			{
				hIndices.Free();
			}
		}
		#endregion

		#region MultiDrawElementsBaseVertex
		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Numbers of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offsets">The offsets into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		/// <param name="drawcount">Number of draws (Length of <paramref name="count"/> and <paramref name="offsets"/>.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void MultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, IntPtr[] offsets, int drawcount, int[] basevertex)
		{
			_MultiDrawElementsBaseVertex(mode, count, type, offsets, drawcount, basevertex);
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Numbers of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offsets">The offsets into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		/// <param name="drawcount">Number of draws (Length of <paramref name="count"/> and <paramref name="offsets"/>.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void MultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, byte[][] offsets, int drawcount, int[] basevertex)
		{
			GCHandle[] hOffsets=new GCHandle[drawcount];
			IntPtr[] iOffsets=new IntPtr[drawcount];

			for(int i=0; i<drawcount; i++)
			{
				hOffsets[i]=GCHandle.Alloc(offsets[i], GCHandleType.Pinned);
				iOffsets[i]=hOffsets[i].AddrOfPinnedObject();
			}

			try
			{
				_MultiDrawElementsBaseVertex(mode, count, type, iOffsets, drawcount, basevertex);
			}
			finally
			{
				for(int i=0; i<drawcount; i++) hOffsets[i].Free();
				hOffsets=null;
				iOffsets=null;
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Numbers of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offsets">The offsets into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		/// <param name="drawcount">Number of draws (Length of <paramref name="count"/> and <paramref name="offsets"/>.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void MultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, ushort[][] offsets, int drawcount, int[] basevertex)
		{
			GCHandle[] hOffsets=new GCHandle[drawcount];
			IntPtr[] iOffsets=new IntPtr[drawcount];

			for(int i=0; i<drawcount; i++)
			{
				hOffsets[i]=GCHandle.Alloc(offsets[i], GCHandleType.Pinned);
				iOffsets[i]=hOffsets[i].AddrOfPinnedObject();
			}

			try
			{
				_MultiDrawElementsBaseVertex(mode, count, type, iOffsets, drawcount, basevertex);
			}
			finally
			{
				for(int i=0; i<drawcount; i++) hOffsets[i].Free();
				hOffsets=null;
				iOffsets=null;
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Numbers of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offsets">The offsets into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		/// <param name="drawcount">Number of draws (Length of <paramref name="count"/> and <paramref name="offsets"/>.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void MultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, int[][] offsets, int drawcount, int[] basevertex)
		{
			GCHandle[] hOffsets=new GCHandle[drawcount];
			IntPtr[] iOffsets=new IntPtr[drawcount];

			for(int i=0; i<drawcount; i++)
			{
				hOffsets[i]=GCHandle.Alloc(offsets[i], GCHandleType.Pinned);
				iOffsets[i]=hOffsets[i].AddrOfPinnedObject();
			}

			try
			{
				_MultiDrawElementsBaseVertex(mode, count, type, iOffsets, drawcount, basevertex);
			}
			finally
			{
				for(int i=0; i<drawcount; i++) hOffsets[i].Free();
				hOffsets=null;
				iOffsets=null;
			}
		}

		/// <summary>
		/// Renders primitives from array via indices with a per-element offset.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Numbers of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offsets">The offsets into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		/// <param name="drawcount">Number of draws (Length of <paramref name="count"/> and <paramref name="offsets"/>.</param>
		/// <param name="basevertex">The per-element offset.</param>
		public static void MultiDrawElementsBaseVertex(glDrawMode mode, int[] count, glDrawElementsType type, uint[][] offsets, int drawcount, int[] basevertex)
		{
			GCHandle[] hOffsets=new GCHandle[drawcount];
			IntPtr[] iOffsets=new IntPtr[drawcount];

			for(int i=0; i<drawcount; i++)
			{
				hOffsets[i]=GCHandle.Alloc(offsets[i], GCHandleType.Pinned);
				iOffsets[i]=hOffsets[i].AddrOfPinnedObject();
			}

			try
			{
				_MultiDrawElementsBaseVertex(mode, count, type, iOffsets, drawcount, basevertex);
			}
			finally
			{
				for(int i=0; i<drawcount; i++) hOffsets[i].Free();
				hOffsets=null;
				iOffsets=null;
			}
		}
		#endregion
		#endregion

		private static void Load_VERSION_3_2()
		{
			_DrawElementsBaseVertex=GetAddress<glDrawElementsBaseVertex>("glDrawElementsBaseVertex");
			_DrawRangeElementsBaseVertex=GetAddress<glDrawRangeElementsBaseVertex>("glDrawRangeElementsBaseVertex");
			_DrawElementsInstancedBaseVertex=GetAddress<glDrawElementsInstancedBaseVertex>("glDrawElementsInstancedBaseVertex");
			_MultiDrawElementsBaseVertex=GetAddress<glMultiDrawElementsBaseVertex>("glMultiDrawElementsBaseVertex");
			ProvokingVertex=GetAddress<glProvokingVertex>("glProvokingVertex");
			FenceSync=GetAddress<glFenceSync>("glFenceSync");
			IsSync=GetAddress<glIsSync>("glIsSync");
			DeleteSync=GetAddress<glDeleteSync>("glDeleteSync");
			ClientWaitSync=GetAddress<glClientWaitSync>("glClientWaitSync");
			WaitSync=GetAddress<glWaitSync>("glWaitSync");
			GetInteger64=GetAddress<glGetInteger64>("glGetInteger64v");
			GetInteger64v=GetAddress<glGetInteger64v>("glGetInteger64v");
			GetSynci=GetAddress<glGetSynci>("glGetSynciv");
			GetSynciv=GetAddress<glGetSynciv>("glGetSynciv");
			GetInteger64i_=GetAddress<glGetInteger64i_>("glGetInteger64i_v");
			GetInteger64i_v=GetAddress<glGetInteger64i_v>("glGetInteger64i_v");
			GetBufferParameteri64=GetAddress<glGetBufferParameteri64>("glGetBufferParameteri64v");
			GetBufferParameteri64v=GetAddress<glGetBufferParameteri64v>("glGetBufferParameteri64v");
			FramebufferTexture=GetAddress<glFramebufferTexture>("glFramebufferTexture");
			TexImage2DMultisample=GetAddress<glTexImage2DMultisample>("glTexImage2DMultisample");
			TexImage3DMultisample=GetAddress<glTexImage3DMultisample>("glTexImage3DMultisample");
			GetMultisamplefv=GetAddress<glGetMultisamplefv>("glGetMultisamplefv");
			SampleMaski=GetAddress<glSampleMaski>("glSampleMaski");

			VERSION_3_2=VERSION_3_1&&_DrawElementsBaseVertex!=null&&_DrawRangeElementsBaseVertex!=null&&
				_DrawElementsInstancedBaseVertex!=null&&_MultiDrawElementsBaseVertex!=null&&
				ProvokingVertex!=null&&FenceSync!=null&&IsSync!=null&&DeleteSync!=null&&ClientWaitSync!=null&&
				WaitSync!=null&&GetInteger64v!=null&&GetSynciv!=null&&GetInteger64i_v!=null&&GetBufferParameteri64v!=null&&
				FramebufferTexture!=null&&TexImage2DMultisample!=null&&TexImage3DMultisample!=null&&
				GetMultisamplefv!=null&&SampleMaski!=null;
		}
	}
}
