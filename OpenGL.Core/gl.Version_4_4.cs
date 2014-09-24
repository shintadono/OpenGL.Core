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
		internal delegate void glBufferStorage_32(glBufferTarget target, int size, IntPtr data, glBufferStorageFlag flags);
		internal delegate void glBufferStorage_64(glBufferTarget target, long size, IntPtr data, glBufferStorageFlag flags);
		internal delegate void glClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, IntPtr data);
		internal delegate void glClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr data);

		/// <summary>
		/// Binds one or more buffer objects to a sequence of indexed buffer targets.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="first">The index of the first binding point.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		public delegate void glBindBuffersBase(glBufferTarget target, uint first, int count, params uint[] buffers);

		internal delegate void glBindBuffersRange_32(glBufferTarget target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes);
		internal delegate void glBindBuffersRange_64(glBufferTarget target, uint first, int count, uint[] buffers, long[] offsets, long[] sizes);

		/// <summary>
		/// Binds one or more texture objects to a sequence of consecutive texture units.
		/// </summary>
		/// <param name="first">The index of the first texture unit.</param>
		/// <param name="count">The number of textures to bind.</param>
		/// <param name="textures">The textures to bind.</param>
		public delegate void glBindTextures(uint first, int count, params uint[] textures);

		/// <summary>
		/// Binds one or more sampler objects to a sequence of consecutive texture units.
		/// </summary>
		/// <param name="first">The index of the first texture unit.</param>
		/// <param name="count">The number of samplers to bind.</param>
		/// <param name="samplers">The samplers to bind.</param>
		public delegate void glBindSamplers(uint first, int count, params uint[] samplers);

		/// <summary>
		/// Binds one or more texture images to a sequence of consecutive image units.
		/// </summary>
		/// <param name="first">The index of the first image unit.</param>
		/// <param name="count">The number of textures to bind.</param>
		/// <param name="textures">The textures to bind.</param>
		public delegate void glBindImageTextures(uint first, int count, params uint[] textures);

		internal delegate void glBindVertexBuffers_32(uint first, int count, uint[] buffers, int[] offsets, int[] strides);
		internal delegate void glBindVertexBuffers_64(uint first, int count, uint[] buffers, long[] offsets, int[] strides);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 4.4 is available.
		/// </summary>
		public static bool VERSION_4_4;

		#region Delegates
		private static glBufferStorage_32 BufferStorage_32;
		private static glBufferStorage_64 BufferStorage_64;
		private static glClearTexImage _ClearTexImage;
		private static glClearTexSubImage _ClearTexSubImage;

		/// <summary>
		/// Binds one or more buffer objects to a sequence of indexed buffer targets.
		/// </summary>
		public static glBindBuffersBase BindBuffersBase;

		private static glBindBuffersRange_32 BindBuffersRange_32;
		private static glBindBuffersRange_64 BindBuffersRange_64;
		
		/// <summary>
		/// Binds one or more texture objects to a sequence of consecutive texture units.
		/// </summary>
		public static glBindTextures BindTextures;
		
		/// <summary>
		/// Binds one or more sampler objects to a sequence of consecutive texture units.
		/// </summary>
		public static glBindSamplers BindSamplers;
		
		/// <summary>
		/// Binds one or more texture images to a sequence of consecutive image units.
		/// </summary>
		public static glBindImageTextures BindImageTextures;

		private static glBindVertexBuffers_32 BindVertexBuffers_32;
		private static glBindVertexBuffers_64 BindVertexBuffers_64;
		#endregion

		#region Overloads
		#region BufferStorage
		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, IntPtr data, glBufferStorageFlag flags)
		{
			if(IntPtr.Size==4) BufferStorage_32(target, size, data, flags);
			else BufferStorage_64(target, size, data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, IntPtr data, glBufferStorageFlag flags)
		{
			if(IntPtr.Size==4)
			{
				if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("size", PlatformErrorString);

				BufferStorage_32(target, (int)size, data, flags);
			}
			else BufferStorage_64(target, size, data, flags);
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, byte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, byte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, sbyte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, sbyte[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, short[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, short[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, ushort[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, ushort[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, int[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, int[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, uint[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, uint[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, long[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, long[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, ulong[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, ulong[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, float[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, float[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, int size, double[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Creates and initializes a buffer object's immutable data store.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="size">The size of the storage in bytes.</param>
		/// <param name="data">The data used to initializes the buffer.</param>
		/// <param name="flags">A mask of <see cref="glBufferStorageFlag"/>s specifying the usage of the buffer's data store.</param>
		public static void BufferStorage(glBufferTarget target, long size, double[] data, glBufferStorageFlag flags)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				BufferStorage(target, size, hData.AddrOfPinnedObject(), flags);
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region ClearTexImage
		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, IntPtr data)
		{
			_ClearTexImage(texture, level, format, type, data);
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, byte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, sbyte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, short[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, ushort[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, int[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, uint[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, long[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, ulong[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, float[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills all texel of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexImage(uint texture, int level, glPixelFormat format, glPixelDataType type, double[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexImage(texture, level, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region ClearTexSubImage
		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr data)
		{
			_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, data);
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, byte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, sbyte[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, short[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ushort[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, uint[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, long[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ulong[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, float[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}

		/// <summary>
		/// Fills a region of a texture image with a constant value.
		/// </summary>
		/// <param name="texture">The name of the texture.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="xoffset">The offset in x-directions to the begin of the region.</param>
		/// <param name="yoffset">The offset in y-directions to the begin of the region.</param>
		/// <param name="zoffset">The offset in z-directions to the begin of the region.</param>
		/// <param name="width">The width of the region.</param>
		/// <param name="height">The height of the region.</param>
		/// <param name="depth">The depth of the region.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the pixel format of the constant value in <paramref name="data"/>.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type of the constant value in <paramref name="data"/>.</param>
		/// <param name="data">The constant value used to fill the texture.</param>
		public static void ClearTexSubImage(uint texture, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, double[] data)
		{
			GCHandle hData=GCHandle.Alloc(data, GCHandleType.Pinned);
			try
			{
				_ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hData.AddrOfPinnedObject());
			}
			finally
			{
				hData.Free();
			}
		}
		#endregion

		#region BindBuffersRange
		/// <summary>
		/// Binds ranges of one or more buffer objects to a sequence of indexed buffer targets.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="first">The index of the first binding point.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets into the buffers.</param>
		/// <param name="sizes">The sizes of the ranges.</param>
		public static void BindBuffersRange(glBufferTarget target, uint first, int count, uint[] buffers, int[] offsets, int[] sizes)
		{
			if(IntPtr.Size==4) BindBuffersRange_32(target, first, count, buffers, offsets, sizes);
			else
			{
				if(buffers==null)
				{
					BindBuffersRange_64(target, first, count, null, null, null);
					return;
				}

				long[] lOffsets=new long[offsets.Length];
				Array.Copy(offsets, lOffsets, offsets.Length);

				long[] lSizes=new long[sizes.Length];
				Array.Copy(sizes, lSizes, sizes.Length);

				BindBuffersRange_64(target, first, count, buffers, lOffsets, lSizes);
			}
		}

		/// <summary>
		/// Binds ranges of one or more buffer objects to a sequence of indexed buffer targets.
		/// </summary>
		/// <param name="target">A <see cref="glBufferTarget"/> specifying the buffer target.</param>
		/// <param name="first">The index of the first binding point.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets into the buffers.</param>
		/// <param name="sizes">The sizes of the ranges.</param>
		public static void BindBuffersRange(glBufferTarget target, uint first, int count, uint[] buffers, long[] offsets, long[] sizes)
		{
			if(IntPtr.Size==4)
			{
				if(buffers==null)
				{
					BindBuffersRange_32(target, first, count, null, null, null);
					return;
				}

				int[] iOffsets=new int[first+count];
				int[] iSizes=new int[first+count];
				for(int i=0; i<count; i++)
				{
					long offset=offsets[first+i];
					long size=sizes[first+i];
					if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offsets", PlatformArrayErrorString);
					if(((long)size>>32)!=0) throw new ArgumentOutOfRangeException("sizes", PlatformArrayErrorString);
					iOffsets[first+i]=(int)offset;
					iSizes[first+i]=(int)size;
				}

				BindBuffersRange_32(target, first, count, buffers, iOffsets, iSizes);
			}
			else BindBuffersRange_64(target, first, count, buffers, offsets, sizes);
		}
		#endregion

		#region BindVertexBuffers
		/// <summary>
		/// Attaches multiple buffer objects to a vertex array object.
		/// </summary>
		/// <param name="first">The first vertex buffer binding point to which a buffer object is to be bound.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets to associate with the binding points.</param>
		/// <param name="strides">The strides to associate with the binding points.</param>
		public static void BindVertexBuffers(uint first, int count, uint[] buffers, int[] offsets, int[] strides)
		{
			if(IntPtr.Size==4) BindVertexBuffers_32(first, count, buffers, offsets, strides);
			else
			{
				if(buffers==null)
				{
					BindVertexBuffers_64(first, count, null, null, null);
					return;
				}

				long[] lOffsets=new long[offsets.Length];
				Array.Copy(offsets, lOffsets, offsets.Length);

				BindVertexBuffers_64(first, count, buffers, lOffsets, strides);
			}
		}

		/// <summary>
		/// Attaches multiple buffer objects to a vertex array object.
		/// </summary>
		/// <param name="first">The first vertex buffer binding point to which a buffer object is to be bound.</param>
		/// <param name="count">The number of buffers to bind.</param>
		/// <param name="buffers">The buffers to bind.</param>
		/// <param name="offsets">The offsets to associate with the binding points.</param>
		/// <param name="strides">The strides to associate with the binding points.</param>
		public static void BindVertexBuffers(uint first, int count, uint[] buffers, long[] offsets, int[] strides)
		{
			if(IntPtr.Size==4)
			{
				if(buffers==null)
				{
					BindVertexBuffers_32(first, count, null, null, null);
					return;
				}

				int[] iOffsets=new int[first+count];
				for(int i=0; i<count; i++)
				{
					long offset=offsets[first+i];
					if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offsets", PlatformArrayErrorString);
					iOffsets[first+i]=(int)offset;
				}

				BindVertexBuffers_32(first, count, buffers, iOffsets, strides);
			}
			else BindVertexBuffers_64(first, count, buffers, offsets, strides);
		}
		#endregion
		#endregion

		private static void Load_VERSION_4_4()
		{
			_ClearTexImage=GetAddress<glClearTexImage>("glClearTexImage");
			_ClearTexSubImage=GetAddress<glClearTexSubImage>("glClearTexSubImage");
			BindBuffersBase=GetAddress<glBindBuffersBase>("glBindBuffersBase");
			BindTextures=GetAddress<glBindTextures>("glBindTextures");
			BindSamplers=GetAddress<glBindSamplers>("glBindSamplers");
			BindImageTextures=GetAddress<glBindImageTextures>("glBindImageTextures");

			bool platformDependend;
			if(IntPtr.Size==4)
			{
				BufferStorage_32=GetAddress<glBufferStorage_32>("glBufferStorage");
				BindBuffersRange_32=GetAddress<glBindBuffersRange_32>("glBindBuffersRange");
				BindVertexBuffers_32=GetAddress<glBindVertexBuffers_32>("glBindVertexBuffers");

				platformDependend=BufferStorage_32!=null&&BindBuffersRange_32!=null&&BindVertexBuffers_32!=null;
			}
			else
			{
				BufferStorage_64=GetAddress<glBufferStorage_64>("glBufferStorage");
				BindBuffersRange_64=GetAddress<glBindBuffersRange_64>("glBindBuffersRange");
				BindVertexBuffers_64=GetAddress<glBindVertexBuffers_64>("glBindVertexBuffers");

				platformDependend=BufferStorage_64!=null&&BindBuffersRange_64!=null&&BindVertexBuffers_64!=null;
			}

			VERSION_4_4=VERSION_4_3&&_ClearTexImage!=null&&_ClearTexSubImage!=null&&BindBuffersBase!=null&&
				BindTextures!=null&&BindSamplers!=null&&BindImageTextures!=null&&platformDependend;
		}
	}
}
