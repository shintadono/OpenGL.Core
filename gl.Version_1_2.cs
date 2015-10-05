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
		internal delegate void glDrawRangeElements(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, IntPtr indices);
		internal delegate void glTexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, IntPtr pixels);
		internal delegate void glTexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		/// <summary>
		/// Copies pixels inside the currently bound 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="zoffset">The texel offset in z-direction.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		public delegate void glCopyTexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 1.2 is available.
		/// </summary>
		public static bool VERSION_1_2;

		#region Delegates
		private static glDrawRangeElements _DrawRangeElements;
		private static glTexImage3D _TexImage3D;
		private static glTexSubImage3D _TexSubImage3D;

		/// <summary>
		/// Copies pixels inside the currently bound 3D texture.
		/// </summary>
		public static glCopyTexSubImage3D CopyTexSubImage3D;
		#endregion

		#region Overloads
		#region DrawRangeElements
		/// <summary>
		/// Render primitives from array via a range of indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		public static void DrawRangeElements(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, int offset)
		{
			_DrawRangeElements(mode, start, end, count, type, (IntPtr)offset);
		}

		/// <summary>
		/// Render primitives from array via a range of indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="start">Start of the range.</param>
		/// <param name="end">End of the range.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		public static void DrawRangeElements(glDrawMode mode, uint start, uint end, int count, glDrawElementsType type, long offset)
		{
			if (IntPtr.Size == 4 && ((long)offset >> 32) != 0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_DrawRangeElements(mode, start, end, count, type, (IntPtr)offset);
		}
		#endregion

		#region TexImage3D
		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, IntPtr pixels)
		{
			_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, int offset)
		{
			_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, long offset)
		{
			if (IntPtr.Size == 4 && ((long)offset >> 32) != 0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, byte[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, sbyte[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, short[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, ushort[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, int[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, uint[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, long[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, ulong[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, float[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="depth">The depth of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		public static void TexImage3D(glTexture3DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int depth, int border, glPixelFormat format, glPixelDataType type, double[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexImage3D(target, level, internalformat, width, height, depth, border, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion

		#region TexSubImage3D
		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, IntPtr pixels)
		{
			_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int offset)
		{
			_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, long offset)
		{
			if (IntPtr.Size == 4 && ((long)offset >> 32) != 0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, byte[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, sbyte[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, short[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ushort[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, int[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, uint[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, long[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, ulong[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, float[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}

		/// <summary>
		/// Loads a part a 3D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture3DTarget"/> specifying the texture target.</param>
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
		public static void TexSubImage3D(glTexture3DTarget target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, glPixelFormat format, glPixelDataType type, double[] pixels)
		{
			GCHandle hPixels = GCHandle.Alloc(pixels, GCHandleType.Pinned);
			try
			{
				_TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, hPixels.AddrOfPinnedObject());
			}
			finally
			{
				hPixels.Free();
			}
		}
		#endregion
		#endregion

		private static void Load_VERSION_1_2()
		{
			_DrawRangeElements = GetAddress<glDrawRangeElements>("glDrawRangeElements");
			_TexImage3D = GetAddress<glTexImage3D>("glTexImage3D");
			_TexSubImage3D = GetAddress<glTexSubImage3D>("glTexSubImage3D");
			CopyTexSubImage3D = GetAddress<glCopyTexSubImage3D>("glCopyTexSubImage3D");

			VERSION_1_2 = _DrawRangeElements != null && _TexImage3D != null && _TexSubImage3D != null && CopyTexSubImage3D != null;
		}
	}
}
