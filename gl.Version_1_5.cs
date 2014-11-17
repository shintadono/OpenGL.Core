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
		internal delegate void glGenQuery(int one, out uint id);
		internal delegate void glGenQueries(int count, uint[] ids);

		/// <summary>
		/// Releases <paramref name="count"/> many query-IDs.
		/// </summary>
		/// <param name="count">Number of query-IDs to be released.</param>
		/// <param name="ids">Array of query-IDs to be released.</param>
		public delegate void glDeleteQueries(int count, params uint[] ids);

		/// <summary>
		/// Determines if a name is a query-ID.
		/// </summary>
		/// <param name="id">The maybe query-ID.</param>
		/// <returns><b>true</b> if <paramref name="id"/> is a query-ID.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsQuery(uint id);

		/// <summary>
		/// Delimits the boundary of a query object.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="id">The query-ID to be used.</param>
		public delegate void glBeginQuery(glQueryTarget target, uint id);

		/// <summary>
		/// Delimits the boundary of a query object.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		public delegate void glEndQuery(glQueryTarget target);

		/// <summary>
		/// Returns the parameters of a query type.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="pname">A <see cref="glQueryParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetQueryi(glQueryTarget target, glQueryParameter pname, out int param);

		/// <summary>
		/// Returns the parameters of a query type.
		/// </summary>
		/// <param name="target">A <see cref="glQueryTarget"/> specifying the type of query.</param>
		/// <param name="pname">A <see cref="glQueryParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetQueryiv(glQueryTarget target, glQueryParameter pname, int[] @params);

		internal delegate void glGetQueryObjecti(uint id, glQueryObjectParameter pname, out int param);
		internal delegate void glGetQueryObjectiv(uint id, glQueryObjectParameter pname, IntPtr @params);

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetQueryObjectui(uint id, glQueryObjectParameter pname, out uint param);

		internal delegate void glGetQueryObjectuiv(uint id, glQueryObjectParameter pname, IntPtr @params);

		/// <summary>
		/// Binds a buffer object to a buffer target.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="buffer">The buffer name of the buffer object.</param>
		public delegate void glBindBuffer(glBufferTarget target, uint buffer);

		/// <summary>
		/// Releases <paramref name="count"/> many buffer names.
		/// </summary>
		/// <param name="count">Number of buffer names to be released.</param>
		/// <param name="buffers">Array of buffer names to be released.</param>
		public delegate void glDeleteBuffers(int count, params uint[] buffers);

		internal delegate void glGenBuffer(int one, out uint buffer);
		internal delegate void glGenBuffers(int count, uint[] buffers);

		/// <summary>
		/// Determines if a name is a buffer name.
		/// </summary>
		/// <param name="buffer">The maybe buffer name.</param>
		/// <returns><b>true</b> if <paramref name="buffer"/> is a buffer name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsBuffer(uint buffer);

		internal delegate void glBufferData_32(glBufferTarget target, int size, IntPtr data, glBufferUsage usage);
		internal delegate void glBufferData_64(glBufferTarget target, long size, IntPtr data, glBufferUsage usage);
		internal delegate void glBufferSubData_32(glBufferTarget target, int offset, int size, IntPtr data);
		internal delegate void glBufferSubData_64(glBufferTarget target, long offset, long size, IntPtr data);
		internal delegate void glGetBufferSubData_32(glBufferTarget target, int offset, int size, IntPtr data);
		internal delegate void glGetBufferSubData_64(glBufferTarget target, long offset, long size, IntPtr data);

		/// <summary>
		/// Maps a data store into client memory.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="access">A <see cref="glAccess"/> specifying the access.</param>
		/// <returns>The pointer to the data. Use result with Marshal.Copy(...); to access data.</returns>
		public delegate IntPtr glMapBuffer(glBufferTarget target, glAccess access);

		/// <summary>
		/// Releases a mapped data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <returns><b>true</b> unless the data store contents have become corrupt during the time the data store was mapped. If <b>false</b> is returned an application must reinitialize the data store.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glUnmapBuffer(glBufferTarget target);

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetBufferParameteri(glBufferTarget target, glGetBufferParameter pname, out int param);

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="pname">A <see cref="glGetBufferParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetBufferParameteriv(glBufferTarget target, glGetBufferParameter pname, int[] @params);

		/// <summary>
		/// Returns the pointer to a mapped data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="pname">Must be <see cref="glGetBufferParameter.BUFFER_MAP_POINTER"/>.</param>
		/// <param name="param">The pointer to the mapped data store.</param>
		public delegate void glGetBufferPointerv(glBufferTarget target, glGetBufferParameter pname, out IntPtr param);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 1.5 is available.
		/// </summary>
		public static bool VERSION_1_5;

		#region Delegates
		private static glGenQuery _GenQuery;
		private static glGenQueries _GenQueries;

		/// <summary>
		/// Releases multiple query-IDs at once.
		/// </summary>
		public static glDeleteQueries DeleteQueries;

		/// <summary>
		/// Determines if a name is a query-ID.
		/// </summary>
		public static glIsQuery IsQuery;

		/// <summary>
		/// Delimits the boundary of a query object.
		/// </summary>
		public static glBeginQuery BeginQuery;

		/// <summary>
		/// Delimits the boundary of a query object.
		/// </summary>
		public static glEndQuery EndQuery;

		/// <summary>
		/// Returns the parameters of a query type.
		/// </summary>
		public static glGetQueryi GetQueryi;

		/// <summary>
		/// Returns the parameters of a query type.
		/// </summary>
		public static glGetQueryiv GetQueryiv;

		private static glGetQueryObjecti _GetQueryObjecti;
		private static glGetQueryObjectiv _GetQueryObjectiv;

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		public static glGetQueryObjectui GetQueryObjectui;

		private static glGetQueryObjectuiv _GetQueryObjectuiv;

		/// <summary>
		/// Binds a buffer object to a buffer target.
		/// </summary>
		public static glBindBuffer BindBuffer;

		/// <summary>
		/// Releases multiple buffer names at once.
		/// </summary>
		public static glDeleteBuffers DeleteBuffers;

		private static glGenBuffer _GenBuffer;
		private static glGenBuffers _GenBuffers;

		/// <summary>
		/// Determines if a name is a buffer name.
		/// </summary>
		public static glIsBuffer IsBuffer;

		private static glBufferData_32 BufferData_32;
		private static glBufferData_64 BufferData_64;
		private static glBufferSubData_32 BufferSubData_32;
		private static glBufferSubData_64 BufferSubData_64;
		private static glGetBufferSubData_32 GetBufferSubData_32;
		private static glGetBufferSubData_64 GetBufferSubData_64;

		/// <summary>
		/// Maps a data store into client memory.
		/// </summary>
		public static glMapBuffer MapBuffer;

		/// <summary>
		/// Releases a mapped data store.
		/// </summary>
		public static glUnmapBuffer UnmapBuffer;

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		public static glGetBufferParameteri GetBufferParameteri;

		/// <summary>
		/// Returns parameter of a buffer object.
		/// </summary>
		public static glGetBufferParameteriv GetBufferParameteriv;

		/// <summary>
		/// Returns the pointer to a mapped data store.
		/// </summary>
		public static glGetBufferPointerv GetBufferPointerv;
		#endregion

		#region Overloads
		#region GenQuery&GenQueries
		/// <summary>
		/// Generates one query-ID and returns it.
		/// </summary>
		/// <returns>The new query-ID.</returns>
		public static uint GenQuery()
		{
			uint ret;
			_GenQuery(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one query-ID and returns it.
		/// </summary>
		/// <param name="id">The new query-ID.</param>
		public static void GenQuery(out uint id)
		{
			_GenQuery(1, out id);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many query-IDs and returns them as array.
		/// </summary>
		/// <param name="count">The number of query-IDs to be generated.</param>
		/// <returns>The new query-IDs as array.</returns>
		public static uint[] GenQueries(int count)
		{
			uint[] ret=new uint[count];
			_GenQueries(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many query-IDs.
		/// </summary>
		/// <param name="count">The number of query-IDs to be generated.</param>
		/// <param name="ids">The array that will receive the new query-IDs.</param>
		public static void GenQueries(int count, uint[] ids)
		{
			_GenQueries(count, ids);
		}
		#endregion

		#region GenBuffer(s)
		/// <summary>
		/// Generates one buffer name and returns it.
		/// </summary>
		/// <returns>The new buffer name.</returns>
		public static uint GenBuffer()
		{
			uint ret;
			_GenBuffer(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one buffer name and returns it.
		/// </summary>
		/// <param name="buffer">The new buffer name.</param>
		public static void GenBuffer(out uint buffer)
		{
			_GenBuffer(1, out buffer);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many buffer names and returns them as array.
		/// </summary>
		/// <param name="count">The number of buffer names to be generated.</param>
		/// <returns>The new buffer names as array.</returns>
		public static uint[] GenBuffers(int count)
		{
			uint[] ret=new uint[count];
			_GenBuffers(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many buffer names.
		/// </summary>
		/// <param name="count">The number of buffer names to be generated.</param>
		/// <param name="buffers">The array that will receive the new buffer names.</param>
		public static void GenBuffers(int count, uint[] buffers)
		{
			_GenBuffers(count, buffers);
		}
		#endregion

		#region GetQueryObjecti
		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetQueryObjecti(uint id, glQueryObjectParameter pname, out int param)
		{
			GetQueryObjecti(id, pname, out param);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetQueryObjecti(uint id, glQueryObjectParameter pname, out bool param)
		{
			int value;
			GetQueryObjecti(id, pname, out value);
			param=value!=gl.FALSE;
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">Must be <see cref="glQueryObjectParameter.QUERY_TARGET"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetQueryObjecti(uint id, glQueryObjectParameter pname, out glQueryTarget param)
		{
			int value;
			GetQueryObjecti(id, pname, out value);
			param=(glQueryTarget)value;
		}
		#endregion

		#region GetQueryObjectiv
		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetQueryObjectiv(uint id, glQueryObjectParameter pname, IntPtr @params)
		{
			_GetQueryObjectiv(id, pname, @params);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.QUERY_BUFFER"/>.</param>
		public static void GetQueryObjectiv(uint id, glQueryObjectParameter pname, int offset)
		{
			_GetQueryObjectiv(id, pname, (IntPtr)offset);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.QUERY_BUFFER"/>.</param>
		public static void GetQueryObjectiv(uint id, glQueryObjectParameter pname, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetQueryObjectiv(id, pname, (IntPtr)offset);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetQueryObjectiv(uint id, glQueryObjectParameter pname, int[] @params)
		{
			GCHandle hParams=GCHandle.Alloc(@params, GCHandleType.Pinned);
			try
			{
				_GetQueryObjectiv(id, pname, hParams.AddrOfPinnedObject());
			}
			finally
			{
				hParams.Free();
			}
		}
		#endregion

		#region GetQueryObjectuiv
		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetQueryObjectuiv(uint id, glQueryObjectParameter pname, IntPtr @params)
		{
			_GetQueryObjectuiv(id, pname, @params);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.QUERY_BUFFER"/>.</param>
		public static void GetQueryObjectuiv(uint id, glQueryObjectParameter pname, int offset)
		{
			_GetQueryObjectuiv(id, pname, (IntPtr)offset);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.QUERY_BUFFER"/>.</param>
		public static void GetQueryObjectuiv(uint id, glQueryObjectParameter pname, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_GetQueryObjectuiv(id, pname, (IntPtr)offset);
		}

		/// <summary>
		/// Returns the parameters of a query.
		/// </summary>
		/// <param name="id">The query-ID.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value.</param>
		public static void GetQueryObjectuiv(uint id, glQueryObjectParameter pname, uint[] @params)
		{
			GCHandle hParams=GCHandle.Alloc(@params, GCHandleType.Pinned);
			try
			{
				_GetQueryObjectuiv(id, pname, hParams.AddrOfPinnedObject());
			}
			finally
			{
				hParams.Free();
			}
		}
		#endregion

		#region BufferData
		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>IntPtr.Zero</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, IntPtr data, glBufferUsage usage)
		{
			if(IntPtr.Size==4) BufferData_32(target, size, data, usage);
			else BufferData_64(target, size, data, usage);
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>IntPtr.Zero</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, IntPtr data, glBufferUsage usage)
		{
			if(IntPtr.Size==4)
			{
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);
				BufferData_32(target, (int)size, data, usage);
			}
			else BufferData_64(target, size, data, usage);
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, byte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, byte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, sbyte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, sbyte[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, short[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, short[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, ushort[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, ushort[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, int[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, int[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, uint[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, uint[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, long[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, long[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, ulong[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, ulong[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, float[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, float[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, int size, double[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Creates a data store (and loads data into it).
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="size">The size of the data store in bytes.</param>
		/// <param name="data">The data that will be loaded, or <b>null</b> if nothing is to be loaded.</param>
		/// <param name="usage">A <see cref="glBufferUsage"/> specifying the usage of the data store.</param>
		public static void BufferData(glBufferTarget target, long size, double[] data, glBufferUsage usage)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferData(target, size, h.AddrOfPinnedObject(), usage);
			}
			finally
			{
				h.Free();
			}
		}
		#endregion

		#region BufferSubData
		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, IntPtr data)
		{
			if(IntPtr.Size==4) BufferSubData_32(target, offset, size, data);
			else BufferSubData_64(target, offset, size, data);
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, IntPtr data)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				BufferSubData_32(target, (int)offset, (int)size, data);
			}
			else BufferSubData_64(target, offset, size, data);
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, int offset, int size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Updates a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The data that will be loaded.</param>
		public static void BufferSubData(glBufferTarget target, long offset, long size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}
		#endregion

		#region GetBufferSubData
		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, IntPtr data)
		{
			if(IntPtr.Size==4) GetBufferSubData_32(target, offset, size, data);
			else GetBufferSubData_64(target, offset, size, data);
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, IntPtr data)
		{
			if(IntPtr.Size==4)
			{
				if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				GetBufferSubData_32(target, (int)offset, (int)size, data);
			}
			else GetBufferSubData_64(target, offset, size, data);
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, byte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, sbyte[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, short[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, ushort[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, int[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, uint[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, long[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, ulong[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, float[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, int offset, int size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}

		/// <summary>
		/// Returns a subset of a data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the target.</param>
		/// <param name="offset">The offset in bytes into the data store.</param>
		/// <param name="size">The size of the data store region in bytes.</param>
		/// <param name="data">The requested data.</param>
		public static void GetBufferSubData(glBufferTarget target, long offset, long size, double[] data)
		{
			GCHandle h=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				GetBufferSubData(target, offset, size, h.AddrOfPinnedObject());
			}
			finally
			{
				h.Free();
			}
		}
		#endregion
		#endregion

		private static void Load_VERSION_1_5()
		{
			_GenQuery=GetAddress<glGenQuery>("glGenQueries");
			_GenQueries=GetAddress<glGenQueries>("glGenQueries");
			DeleteQueries=GetAddress<glDeleteQueries>("glDeleteQueries");
			IsQuery=GetAddress<glIsQuery>("glIsQuery");
			BeginQuery=GetAddress<glBeginQuery>("glBeginQuery");
			EndQuery=GetAddress<glEndQuery>("glEndQuery");
			GetQueryi=GetAddress<glGetQueryi>("glGetQueryiv");
			GetQueryiv=GetAddress<glGetQueryiv>("glGetQueryiv");
			_GetQueryObjecti=GetAddress<glGetQueryObjecti>("glGetQueryObjectiv");
			_GetQueryObjectiv=GetAddress<glGetQueryObjectiv>("glGetQueryObjectiv");
			GetQueryObjectui=GetAddress<glGetQueryObjectui>("glGetQueryObjectuiv");
			_GetQueryObjectuiv=GetAddress<glGetQueryObjectuiv>("glGetQueryObjectuiv");
			BindBuffer=GetAddress<glBindBuffer>("glBindBuffer");
			DeleteBuffers=GetAddress<glDeleteBuffers>("glDeleteBuffers");
			_GenBuffer=GetAddress<glGenBuffer>("glGenBuffers");
			_GenBuffers=GetAddress<glGenBuffers>("glGenBuffers");
			IsBuffer=GetAddress<glIsBuffer>("glIsBuffer");
			MapBuffer=GetAddress<glMapBuffer>("glMapBuffer");
			UnmapBuffer=GetAddress<glUnmapBuffer>("glUnmapBuffer");
			GetBufferParameteri=GetAddress<glGetBufferParameteri>("glGetBufferParameteriv");
			GetBufferParameteriv=GetAddress<glGetBufferParameteriv>("glGetBufferParameteriv");
			GetBufferPointerv=GetAddress<glGetBufferPointerv>("glGetBufferPointerv");

			bool platformDependend;
			if(IntPtr.Size==4)
			{
				BufferData_32=GetAddress<glBufferData_32>("glBufferData");
				BufferSubData_32=GetAddress<glBufferSubData_32>("glBufferSubData");
				GetBufferSubData_32=GetAddress<glGetBufferSubData_32>("glGetBufferSubData");

				platformDependend=BufferData_32!=null&&BufferSubData_32!=null&&GetBufferSubData_32!=null;
			}
			else
			{
				BufferData_64=GetAddress<glBufferData_64>("glBufferData");
				BufferSubData_64=GetAddress<glBufferSubData_64>("glBufferSubData");
				GetBufferSubData_64=GetAddress<glGetBufferSubData_64>("glGetBufferSubData");

				platformDependend=BufferData_64!=null&&BufferSubData_64!=null&&GetBufferSubData_64!=null;
			}

			VERSION_1_5=VERSION_1_4&&_GenQueries!=null&&DeleteQueries!=null&&IsQuery!=null&&
				BeginQuery!=null&&EndQuery!=null&&GetQueryiv!=null&&
				_GetQueryObjectiv!=null&&_GetQueryObjectuiv!=null&&BindBuffer!=null&&
				DeleteBuffers!=null&&_GenBuffers!=null&&IsBuffer!=null&&
				MapBuffer!=null&&UnmapBuffer!=null&&GetBufferParameteriv!=null&&
				GetBufferPointerv!=null&&platformDependend;
		}
	}
}
