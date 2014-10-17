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
	public static partial class gl
	{
		/// <summary>
		/// Renders primitives from array.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to be rendered.</param>
		/// <param name="first">Start index in the array.</param>
		/// <param name="count">Number of elements to be rendered.</param>
		[DllImport(DLLName, EntryPoint="glDrawArrays")]
		public static extern void DrawArrays(glDrawMode mode, int first, int count);

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		[DllImport(DLLName, EntryPoint="glDrawElements")]
		public static extern void DrawElements(glDrawMode mode, int count, glDrawElementsType type, IntPtr indices);

		#region Overloads for DrawElements
		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		public static void DrawElements(glDrawMode mode, int count, glDrawElementsType type, int offset)
		{
			DrawElements(mode, count, type, (IntPtr)offset);
		}

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.ELEMENT_ARRAY_BUFFER"/>.</param>
		public static void DrawElements(glDrawMode mode, int count, glDrawElementsType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			DrawElements(mode, count, type, (IntPtr)offset);
		}

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices. Must be <see cref="glDrawElementsType.UNSIGNED_BYTE"/>.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		[DllImport(DLLName, EntryPoint="glDrawElements")]
		public static extern void DrawElements(glDrawMode mode, int count, glDrawElementsType type, byte[] indices);

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices. Must be <see cref="glDrawElementsType.UNSIGNED_SHORT"/>.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		[DllImport(DLLName, EntryPoint="glDrawElements")]
		public static extern void DrawElements(glDrawMode mode, int count, glDrawElementsType type, ushort[] indices);

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices. Must be <see cref="glDrawElementsType.UNSIGNED_INT"/>.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		[DllImport(DLLName, EntryPoint="glDrawElements")]
		public static extern void DrawElements(glDrawMode mode, int count, glDrawElementsType type, int[] indices);

		/// <summary>
		/// Renders primitives from array via indices.
		/// </summary>
		/// <param name="mode">A <see cref="glDrawMode"/> specifying the type of primitive to render.</param>
		/// <param name="count">Number of indices.</param>
		/// <param name="type">A <see cref="glDrawElementsType"/> specifying the data type of the indices. Must be <see cref="glDrawElementsType.UNSIGNED_INT"/>.</param>
		/// <param name="indices">The array, where the indices are stored.</param>
		[DllImport(DLLName, EntryPoint="glDrawElements")]
		public static extern void DrawElements(glDrawMode mode, int count, glDrawElementsType type, uint[] indices);
		#endregion

		/// <summary>
		/// Returns the pointer for different user-supplied elements.
		/// </summary>
		/// <param name="pname">A <see cref="glGetPointerParameter"/> specifying the pointer to return.</param>
		/// <param name="param">The pointer.</param>
		[DllImport(DLLName, EntryPoint="glGetPointerv")]
		public static extern void GetPointerv(glGetPointerParameter pname, out IntPtr param);

		/// <summary>
		/// Sets factor and units used to calculate depth values.
		/// </summary>
		/// <param name="factor">Factor to the depth offset.</param>
		/// <param name="units">Factor to the value that is guaranteed to produce a resolvable offset for a given implementation.</param>
		[DllImport(DLLName, EntryPoint="glPolygonOffset")]
		public static extern void PolygonOffset(float factor, float units);

		/// <summary>
		/// Copies pixels from the current read buffer to the currently bound 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		[DllImport(DLLName, EntryPoint="glCopyTexImage1D")]
		public static extern void CopyTexImage1D(glTexture1DTarget target, int level, glInternalFormat internalformat, int x, int y, int width, int border);

		/// <summary>
		/// Copies pixels from the current read buffer to the currently bound 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		[DllImport(DLLName, EntryPoint="glCopyTexImage2D")]
		public static extern void CopyTexImage2D(glTexture2DTarget target, int level, glInternalFormat internalformat, int x, int y, int width, int height, int border);

		/// <summary>
		/// Copies pixels inside the currently bound 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		[DllImport(DLLName, EntryPoint="glCopyTexSubImage1D")]
		public static extern void CopyTexSubImage1D(glTexture1DTarget target, int level, int xoffset, int x, int y, int width);

		/// <summary>
		/// Copies pixels inside the currently bound 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="x">Horizontal start position of the region to be copied, in window coordinates.</param>
		/// <param name="y">Vertical start position of the region to be copied, in window coordinates.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		[DllImport(DLLName, EntryPoint="glCopyTexSubImage2D")]
		public static extern void CopyTexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for TexSubImage1D
		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, int offset)
		{
			TexSubImage1D(target, level, xoffset, width, format, type, offset);
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			TexSubImage1D(target, level, xoffset, width, format, type, offset);
		}

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Loads a part a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Loads a part a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage1D")]
		public static extern void TexSubImage1D(glTexture1DTarget target, int level, int xoffset, int width, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for TexSubImage2D
		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, int offset)
		{
			TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Loads a part a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Loads a part a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="xoffset">The horizontal texel offset.</param>
		/// <param name="yoffset">The vertical texel offset.</param>
		/// <param name="width">The width of the texture subimage.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexSubImage2D")]
		public static extern void TexSubImage2D(glTexture2DTarget target, int level, int xoffset, int yoffset, int width, int height, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Binds/unbinds texture name to texture target.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="texture">The texture name to be bound.</param>
		[DllImport(DLLName, EntryPoint="glBindTexture")]
		public static extern void BindTexture(glTextureTarget target, uint texture);

		/// <summary>
		/// Releases <paramref name="count"/> many texture names.
		/// </summary>
		/// <param name="count">Number of texture names to be released.</param>
		/// <param name="textures">Array of texture names to be released.</param>
		[DllImport(DLLName, EntryPoint="glDeleteTextures")]
		public static extern void DeleteTextures(int count, params uint[] textures);

		/// <summary>
		/// Generates <paramref name="count"/> many texture names.
		/// </summary>
		/// <param name="count">The number of texture names to be generated.</param>
		/// <param name="textures">The array that will receive the new texture names.</param>
		[DllImport(DLLName, EntryPoint="glGenTextures")]
		public static extern void GenTextures(int count, uint[] textures);

		/// <summary>
		/// Generates one texture name and returns it.
		/// </summary>
		/// <param name="one">Must be one.</param>
		/// <param name="texture">The new texture name.</param>
		[DllImport(DLLName, EntryPoint="glGenTextures")]
		private static extern void GenTextures(int one, out uint texture);

		/// <summary>
		/// Determines if a name is a texture name.
		/// </summary>
		/// <param name="texture">The maybe texture name.</param>
		/// <returns><b>true</b> if <paramref name="texture"/> is a texture name.</returns>
		[DllImport(DLLName, EntryPoint="glIsTexture")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IsTexture(uint texture);

		#region GenTexture(s)
		/// <summary>
		/// Generates one texture name and returns it.
		/// </summary>
		/// <returns>The new texture name.</returns>
		public static uint GenTexture()
		{
			uint i=0;
			GenTextures(1, out i);
			return i;
		}

		/// <summary>
		/// Generates one texture name and returns it.
		/// </summary>
		/// <param name="texture">The new texture name.</param>
		public static void GenTexture(out uint texture)
		{
			GenTextures(1, out texture);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many texture names and returns them as array.
		/// </summary>
		/// <param name="count">The number of texture names to be generated.</param>
		/// <returns>The new texture names as array.</returns>
		public static uint[] GenTextures(int count)
		{
			uint[] res=new uint[count];
			GenTextures(count, res);
			return res;
		}
		#endregion
	}
}
