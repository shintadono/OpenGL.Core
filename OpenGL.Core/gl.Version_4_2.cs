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
		/// Renders multiple instances of a range of elements with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="first">Start index in the array.</param>
		/// <param name="count">Number of elements to be rendered.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public delegate void glDrawArraysInstancedBaseInstance(glDrawMode mode, int first, int count, int instancecount, uint baseinstance);
		
		internal delegate void glDrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, uint baseinstance);
		internal delegate void glDrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, int basevertex, uint baseinstance);

		/// <summary>
		/// Returns parameters of internal formats.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target the <paramref name="internalformat"/> is used for.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="pname">A <see cref="glInternalformatParameter"/> specifying the parameter.</param>
		/// <param name="bufSize">Must be one.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetInternalformati(glTextureTarget target, glInternalFormat internalformat, glInternalformatParameter pname, int bufSize, out int param);

		/// <summary>
		/// Returns parameters of internal formats.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target the <paramref name="internalformat"/> is used for.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="pname">A <see cref="glInternalformatParameter"/> specifying the parameter.</param>
		/// <param name="bufSize">Must be one.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetInternalformativ(glTextureTarget target, glInternalFormat internalformat, glInternalformatParameter pname, int bufSize, int[] @params);

		/// <summary>
		/// Returns parameter of atomic counter buffer objects.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="bufferIndex">The index of the active atomic counter.</param>
		/// <param name="pname">A <see cref="glAtomicCounterBufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetActiveAtomicCounterBufferi(uint program, uint bufferIndex, glAtomicCounterBufferParameter pname, out int param);

		/// <summary>
		/// Returns parameter of atomic counter buffer objects.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="bufferIndex">The index of the active atomic counter.</param>
		/// <param name="pname">A <see cref="glAtomicCounterBufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetActiveAtomicCounterBufferiv(uint program, uint bufferIndex, glAtomicCounterBufferParameter pname, int[] @params);

		/// <summary>
		/// Binds a texture to an image unit.
		/// </summary>
		/// <param name="unit">The image unit.</param>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail of the texture.</param>
		/// <param name="layered">Set <b>true</b> if the whole level is to be bound, <b>false</b> if only the layer specified by <paramref name="layer"/> is to be bound.</param>
		/// <param name="layer">If <paramref name="layered"/> is <b>false</b> only this layer will be bound.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the kind of access.</param>
		/// <param name="format">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		public delegate void glBindImageTexture(uint unit, uint texture, int level, [MarshalAs(UnmanagedType.I1)] bool layered, int layer, glAccess access, glInternalFormat format);

		/// <summary>
		/// Orders memory transactions issued prior to this command relative to those issued after this.
		/// </summary>
		/// <param name="barriers">A <see cref="glMemoryBarrierMask"/> specifying the kind of memory transactions to be ordered.</param>
		public delegate void glMemoryBarrier(glMemoryBarrierMask barriers);

		/// <summary>
		/// Creates a storage for all levels of a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		public delegate void glTexStorage1D(glTexture1DProxyTarget target, int levels, glInternalFormat internalformat, int width);

		/// <summary>
		/// Creates a storage for all levels of a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		public delegate void glTexStorage2D(glTexture2DProxyTarget target, int levels, glInternalFormat internalformat, int width, int height);

		/// <summary>
		/// Creates a storage for all levels of a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="levels">Number of levels.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		public delegate void glTexStorage3D(glTexture3DProxyTarget target, int levels, glInternalFormat internalformat, int width, int height, int depth);

		/// <summary>
		/// Renders multiple instances of primitives using the count derived from transform feedback objects.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitives to render.</param>
		/// <param name="id">The name of the transform feedback object.</param>
		/// <param name="instancecount">The number of instances.</param>
		public delegate void glDrawTransformFeedbackInstanced(glDrawMode mode, uint id, int instancecount);

		/// <summary>
		/// Renders multiple instances of primitives using the count derived from a specific stream of transform feedback objects.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitives to render.</param>
		/// <param name="id">The name of the transform feedback object.</param>
		/// <param name="stream">The index of the stream.</param>
		/// <param name="instancecount">The number of instances.</param>
		public delegate void glDrawTransformFeedbackStreamInstanced(glDrawMode mode, uint id, uint stream, int instancecount);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 4.2 is available.
		/// </summary>
		public static bool VERSION_4_2;

		#region Delegates
		/// <summary>
		/// Renders multiple instances of a range of elements with an offset to all instanced vertex attributes.
		/// </summary>
		public static glDrawArraysInstancedBaseInstance DrawArraysInstancedBaseInstance;

		private static glDrawElementsInstancedBaseInstance _DrawElementsInstancedBaseInstance;
		private static glDrawElementsInstancedBaseVertexBaseInstance _DrawElementsInstancedBaseVertexBaseInstance;

		/// <summary>
		/// Returns parameters of internal formats.
		/// </summary>
		public static glGetInternalformati GetInternalformati;

		/// <summary>
		/// Returns parameters of internal formats.
		/// </summary>
		public static glGetInternalformativ GetInternalformativ;

		/// <summary>
		/// Returns parameter of atomic counter buffer objects.
		/// </summary>
		public static glGetActiveAtomicCounterBufferi GetActiveAtomicCounterBufferi;

		/// <summary>
		/// Returns parameter of atomic counter buffer objects.
		/// </summary>
		public static glGetActiveAtomicCounterBufferiv GetActiveAtomicCounterBufferiv;

		/// <summary>
		/// Binds a texture to an image unit.
		/// </summary>
		public static glBindImageTexture BindImageTexture;

		/// <summary>
		/// Orders memory transactions issued prior to this command relative to those issued after this.
		/// </summary>
		public static glMemoryBarrier MemoryBarrier;

		/// <summary>
		/// Creates a storage for all levels of a 1D texture.
		/// </summary>
		public static glTexStorage1D TexStorage1D;

		/// <summary>
		/// Creates a storage for all levels of a 2D texture.
		/// </summary>
		public static glTexStorage2D TexStorage2D;

		/// <summary>
		/// Creates a storage for all levels of a 3D texture.
		/// </summary>
		public static glTexStorage3D TexStorage3D;

		/// <summary>
		/// Renders multiple instances of primitives using the count derived from transform feedback objects.
		/// </summary>
		public static glDrawTransformFeedbackInstanced DrawTransformFeedbackInstanced;

		/// <summary>
		/// Renders multiple instances of primitives using the count derived from a specific stream of transform feedback objects.
		/// </summary>
		public static glDrawTransformFeedbackStreamInstanced DrawTransformFeedbackStreamInstanced;
		#endregion

		#region Overloads
		#region DrawElementsInstancedBaseInstance
		/// <summary>
		/// Renders multiple instances from array via indices with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, uint baseinstance)
		{
			_DrawElementsInstancedBaseInstance(mode, count, type, indices, instancecount, baseinstance);
		}

		/// <summary>
		/// Renders multiple instances from array via indices with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, byte[] indices, int instancecount, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, ushort[] indices, int instancecount, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, int[] indices, int instancecount, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseInstance(glDrawMode mode, int count, glDrawElementsType type, uint[] indices, int instancecount, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}
		#endregion

		#region DrawElementsInstancedBaseVertexBaseInstance
		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset and an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices, int instancecount, int basevertex, uint baseinstance)
		{
			_DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, indices, instancecount, basevertex, baseinstance);
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset and an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, byte[] indices, int instancecount, int basevertex, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset and an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, ushort[] indices, int instancecount, int basevertex, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset and an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, int[] indices, int instancecount, int basevertex, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}

		/// <summary>
		/// Renders multiple instances from array via indices with a per-element offset and an offset to all instanced vertex attributes.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		/// <param name="instancecount">Number of instances to be rendered.</param>
		/// <param name="basevertex">The per-element offset.</param>
		/// <param name="baseinstance">Offset to all instanced vertex attributes.</param>
		public static void DrawElementsInstancedBaseVertexBaseInstance(glDrawMode mode, int count, glDrawElementsType type, uint[] indices, int instancecount, int basevertex, uint baseinstance)
		{
			GCHandle hIndices=GCHandle.Alloc(indices, GCHandleType.Pinned);
			try
			{
				_DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, hIndices.AddrOfPinnedObject(), instancecount, basevertex, baseinstance);
			}
			finally
			{
				hIndices.Free();
			}
		}
		#endregion
		#endregion

		private static void Load_VERSION_4_2()
		{
			DrawArraysInstancedBaseInstance=GetAddress<glDrawArraysInstancedBaseInstance>("glDrawArraysInstancedBaseInstance");
			_DrawElementsInstancedBaseInstance=GetAddress<glDrawElementsInstancedBaseInstance>("glDrawElementsInstancedBaseInstance");
			_DrawElementsInstancedBaseVertexBaseInstance=GetAddress<glDrawElementsInstancedBaseVertexBaseInstance>("glDrawElementsInstancedBaseVertexBaseInstance");
			GetInternalformati=GetAddress<glGetInternalformati>("glGetInternalformativ");
			GetInternalformativ=GetAddress<glGetInternalformativ>("glGetInternalformativ");
			GetActiveAtomicCounterBufferi=GetAddress<glGetActiveAtomicCounterBufferi>("glGetActiveAtomicCounterBufferiv");
			GetActiveAtomicCounterBufferiv=GetAddress<glGetActiveAtomicCounterBufferiv>("glGetActiveAtomicCounterBufferiv");
			BindImageTexture=GetAddress<glBindImageTexture>("glBindImageTexture");
			MemoryBarrier=GetAddress<glMemoryBarrier>("glMemoryBarrier");
			TexStorage1D=GetAddress<glTexStorage1D>("glTexStorage1D");
			TexStorage2D=GetAddress<glTexStorage2D>("glTexStorage2D");
			TexStorage3D=GetAddress<glTexStorage3D>("glTexStorage3D");
			DrawTransformFeedbackInstanced=GetAddress<glDrawTransformFeedbackInstanced>("glDrawTransformFeedbackInstanced");
			DrawTransformFeedbackStreamInstanced=GetAddress<glDrawTransformFeedbackStreamInstanced>("glDrawTransformFeedbackStreamInstanced");

			VERSION_4_2=VERSION_4_1&&DrawArraysInstancedBaseInstance!=null&&_DrawElementsInstancedBaseInstance!=null&&
				_DrawElementsInstancedBaseVertexBaseInstance!=null&&GetInternalformati!=null&&GetInternalformativ!=null&&
				GetActiveAtomicCounterBufferi!=null&&GetActiveAtomicCounterBufferiv!=null&&BindImageTexture!=null&&
				MemoryBarrier!=null&&TexStorage1D!=null&&TexStorage2D!=null&&TexStorage3D!=null&&
				DrawTransformFeedbackInstanced!=null&&DrawTransformFeedbackStreamInstanced!=null;
		}
	}
}
