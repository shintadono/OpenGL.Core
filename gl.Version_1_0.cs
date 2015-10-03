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
		/// Sets what side(s) of a polygon is/are not rasterized.
		/// </summary>
		/// <param name="mode">A <see cref="glFace"/> specifying the face(s).</param>
		[DllImport(DLLName, EntryPoint="glCullFace")]
		public static extern void CullFace(glFace mode);

		/// <summary>
		/// Sets the order, in which vertices are arranged, to define the front of a polygon.
		/// </summary>
		/// <param name="dir">A <see cref="glFrontFaceDirection"/> specifying the order.</param>
		[DllImport(DLLName, EntryPoint="glFrontFace")]
		public static extern void FrontFace(glFrontFaceDirection dir);

		/// <summary>
		/// Controls OpenGL behavior (via hints).
		/// </summary>
		/// <param name="target">A <see cref="glHintTarget"/> specifying the hint.</param>
		/// <param name="mode">A <see cref="glHintMode"/> specifying the mode.</param>
		[DllImport(DLLName, EntryPoint="glHint")]
		public static extern void Hint(glHintTarget target, glHintMode mode);

		/// <summary>
		/// Sets the line width.
		/// </summary>
		/// <param name="width">The new line width.</param>
		[DllImport(DLLName, EntryPoint="glLineWidth")]
		public static extern void LineWidth(float width);

		/// <summary>
		/// Sets the point size.
		/// </summary>
		/// <param name="size">The new point size.</param>
		[DllImport(DLLName, EntryPoint="glPointSize")]
		public static extern void PointSize(float size);

		/// <summary>
		/// Sets the polygon rasterization mode.
		/// </summary>
		/// <param name="face">Must be <see cref="glFace.FRONT_AND_BACK"/>.</param>
		/// <param name="mode">A <see cref="glPolygonMode"/> specifying the rasterization methode.</param>
		[DllImport(DLLName, EntryPoint="glPolygonMode")]
		public static extern void PolygonMode(glFace face, glPolygonMode mode);

		/// <summary>
		/// Defines the scissor rectangle for all viewports.
		/// </summary>
		/// <param name="left">Left start position of rectangle.</param>
		/// <param name="bottom">Bottom start position of rectangle.</param>
		/// <param name="width">Width of rectangle.</param>
		/// <param name="height">Height of rectangle.</param>
		[DllImport(DLLName, EntryPoint="glScissor")]
		public static extern void Scissor(int left, int bottom, int width, int height);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameterf")]
		public static extern void TexParameterf(glTextureTarget target, glTextureParameter pname, float param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameterfv")]
		public static extern void TexParameterfv(glTextureTarget target, glTextureParameter pname, params float[] @params);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, int param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteriv")]
		public static extern void TexParameteriv(glTextureTarget target, glTextureParameter pname, params int[] @params);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture filtering parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glFilter param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture wrapping parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glTextureWrapMode param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glTextureCompareMode param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glFunc param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.DEPTH_STENCIL_TEXTURE_MODE"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glDepthStencilTextureMode param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture swizzle parameter is allowed.</param>
		/// <param name="param">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteri")]
		public static extern void TexParameteri(glTextureTarget target, glTextureParameter pname, glTextureSwizzleValue param);

		/// <summary>
		/// Sets texture parameter for the currently bound texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set. Only one of the texture swizzle parameter in allowed.</param>
		/// <param name="params">The value the parameter is set to.</param>
		[DllImport(DLLName, EntryPoint="glTexParameteriv")]
		public static extern void TexParameteriv(glTextureTarget target, glTextureParameter pname, params glTextureSwizzleValue[] @params);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for TexImage1D
		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, int offset)
		{
			TexImage1D(target, level, internalformat, width, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			TexImage1D(target, level, internalformat, width, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Loads a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Loads a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Loads a 1D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Loads a 1D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture1DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage1D")]
		public static extern void TexImage1D(glTexture1DProxyTarget target, int level, glInternalFormat internalformat, int width, int border, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for TexImage2D
		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, int offset)
		{
			TexImage2D(target, level, internalformat, width, height, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_UNPACK_BUFFER"/>.</param>
		public static void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			TexImage2D(target, level, internalformat, width, height, border, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Loads a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Loads a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Loads a 2D texture.
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Loads a 2D texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTexture2DProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be filled.</param>
		/// <param name="internalformat">A <see cref="glInternalFormat"/> specifying the internal format to be used.</param>
		/// <param name="width">The width of the texture.</param>
		/// <param name="height">The height of the texture.</param>
		/// <param name="border">Must be zero for core profile.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given in.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given in.</param>
		/// <param name="pixels">Pointer to the pixels.</param>
		[DllImport(DLLName, EntryPoint="glTexImage2D")]
		public static extern void TexImage2D(glTexture2DProxyTarget target, int level, glInternalFormat internalformat, int width, int height, int border, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Sets the draw buffer.
		/// </summary>
		/// <param name="buf">A <see cref="glBuffer"/> specifying the buffer(s).</param>
		[DllImport(DLLName, EntryPoint="glDrawBuffer")]
		public static extern void DrawBuffer(glBuffer buf);

		/// <summary>
		/// Clears buffers.
		/// </summary>
		/// <param name="mask">A <see cref="glBufferMask"/> specifying the buffers.</param>
		[DllImport(DLLName, EntryPoint="glClear")]
		public static extern void Clear(glBufferMask mask);

		/// <summary>
		/// Sets the clear color for color buffers.
		/// </summary>
		/// <param name="red">Red value.</param>
		/// <param name="green">Green value.</param>
		/// <param name="blue">Blue value.</param>
		/// <param name="alpha">Alpha value.</param>
		[DllImport(DLLName, EntryPoint="glClearColor")]
		public static extern void ClearColor(float red, float green, float blue, float alpha);

		/// <summary>
		/// Sets the stencil value for clear operations on stencil buffers.
		/// </summary>
		/// <param name="s">Stencil value.</param>
		[DllImport(DLLName, EntryPoint="glClearStencil")]
		public static extern void ClearStencil(int s);

		/// <summary>
		/// Sets the depth value for clear operations on depth buffers.
		/// </summary>
		/// <param name="depth">Depth value.</param>
		[DllImport(DLLName, EntryPoint="glClearDepth")]
		public static extern void ClearDepth(double depth);

		/// <summary>
		/// Sets the stencil mask for stencil write operations.
		/// </summary>
		/// <param name="mask">The bitmask.</param>
		[DllImport(DLLName, EntryPoint="glStencilMask")]
		public static extern void StencilMask(uint mask);

		/// <summary>
		/// Sets the color mask for color write operations.
		/// </summary>
		/// <param name="red">Wether or not the write the red components.</param>
		/// <param name="green">Wether or not the write the green components.</param>
		/// <param name="blue">Wether or not the write the blue components.</param>
		/// <param name="alpha">Wether or not the write the alpha components.</param>
		[DllImport(DLLName, EntryPoint="glColorMask")]
		public static extern void ColorMask([MarshalAs(UnmanagedType.I1)] bool red, [MarshalAs(UnmanagedType.I1)] bool green,
			[MarshalAs(UnmanagedType.I1)] bool blue, [MarshalAs(UnmanagedType.I1)] bool alpha);

		/// <summary>
		/// Sets the mask for depth operations.
		/// </summary>
		/// <param name="flag">>Wether or not the write the depth values.</param>
		[DllImport(DLLName, EntryPoint="glDepthMask")]
		public static extern void DepthMask([MarshalAs(UnmanagedType.I1)] bool flag);

		/// <summary>
		/// Disables OpenGL capabilities.
		/// </summary>
		/// <param name="cap">The capability to be disabled.</param>
		[DllImport(DLLName, EntryPoint="glDisable")]
		public static extern void Disable(glCapability cap);

		/// <summary>
		/// Enables OpenGL capabilities.
		/// </summary>
		/// <param name="cap">The capability to be enabled.</param>
		[DllImport(DLLName, EntryPoint="glEnable")]
		public static extern void Enable(glCapability cap);

		/// <summary>
		/// Finishes all outstandig OpenGL operations before returning.
		/// </summary>
		[DllImport(DLLName, EntryPoint="glFinish")]
		public static extern void Finish();

		/// <summary>
		/// Forces outstandig OpenGL operations to execute.
		/// </summary>
		[DllImport(DLLName, EntryPoint="glFlush")]
		public static extern void Flush();

		/// <summary>
		/// Sets the blend function factors.
		/// </summary>
		/// <param name="sfactor">Factor to the source value.</param>
		/// <param name="dfactor">Factor to the destination value.</param>
		[DllImport(DLLName, EntryPoint="glBlendFunc")]
		public static extern void BlendFunc(glBlendFuncFactor sfactor, glBlendFuncFactor dfactor);

		/// <summary>
		/// Sets the logical pixel operation to perform.
		/// </summary>
		/// <param name="opcode">A <see cref="glLogicOpMode"/> specifying the logical operation.</param>
		[DllImport(DLLName, EntryPoint="glLogicOp")]
		public static extern void LogicOp(glLogicOpMode opcode);

		/// <summary>
		/// Sets the stencil test function.
		/// </summary>
		/// <param name="func">A <see cref="glFunc"/> specifying the test function.</param>
		/// <param name="refvalue">The reference value.</param>
		/// <param name="mask">The bitmask for the operation.</param>
		[DllImport(DLLName, EntryPoint="glStencilFunc")]
		public static extern void StencilFunc(glFunc func, int refvalue, uint mask);

		/// <summary>
		/// Sets the stencil operation.
		/// </summary>
		/// <param name="fail">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil test fails.</param>
		/// <param name="zfail">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil test passed, but the depth test fails.</param>
		/// <param name="zpass">A <see cref="glStencilOpMode"/> specifying the action to take when the stencil and depth test passes.</param>
		[DllImport(DLLName, EntryPoint="glStencilOp")]
		public static extern void StencilOp(glStencilOpMode fail, glStencilOpMode zfail, glStencilOpMode zpass);

		/// <summary>
		/// Sets the depth test function.
		/// </summary>
		/// <param name="func">A <see cref="glFunc"/> specifying the test function.</param>
		[DllImport(DLLName, EntryPoint="glDepthFunc")]
		public static extern void DepthFunc(glFunc func);

		/// <summary>
		/// Sets the parameter for pixel pack or unpack operations.
		/// </summary>
		/// <param name="pname">A <see cref="glPixelStoreParameter"/> specifying the parameter.</param>
		/// <param name="param">The value.</param>
		[DllImport(DLLName, EntryPoint="glPixelStoref")]
		public static extern void PixelStoref(glPixelStoreParameter pname, float param);

		/// <summary>
		/// Sets the parameter for pixel pack or unpack operations.
		/// </summary>
		/// <param name="pname">A <see cref="glPixelStoreParameter"/> specifying the parameter.</param>
		/// <param name="param">The value.</param>
		[DllImport(DLLName, EntryPoint="glPixelStorei")]
		public static extern void PixelStorei(glPixelStoreParameter pname, int param);

		/// <summary>
		/// Sets the read buffer.
		/// </summary>
		/// <param name="src">A <see cref="glBuffer"/> specifying the buffer(s).</param>
		[DllImport(DLLName, EntryPoint="glReadBuffer")]
		public static extern void ReadBuffer(glBuffer src);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for ReadPixels
		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int offset)
		{
			ReadPixels(x, y, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			ReadPixels(x, y, width, height, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer.
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Reads pixels form the frame buffer. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="x">The start position in x-direction from which to read.</param>
		/// <param name="y">The start position in y-direction from which to read.</param>
		/// <param name="width">The width of the rectangle to read.</param>
		/// <param name="height">The height of the rectangle to read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glReadPixels")]
		public static extern void ReadPixels(int x, int y, int width, int height, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetBooleanv")]
		public static extern void GetBooleanv(glGetBooleanParameter pname, [MarshalAs(UnmanagedType.I1)] out bool param);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetBooleanv")]
		public static extern void GetBooleanv(glGetBooleanParameter pname, byte[] @params);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetBooleanv")]
		private static extern void GetBooleanv(glGetBooleanParameter pname, IntPtr @params);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetBooleanParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public static void GetBooleanv(glGetBooleanParameter pname, bool[] @params)
		{
			GCHandle pin=GCHandle.Alloc(@params, GCHandleType.Pinned);
			GetBooleanv(pname, pin.AddrOfPinnedObject());
			pin.Free();
		}

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetDoublev")]
		public static extern void GetDoublev(glGetFloatParameter pname, out double param);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetDoublev")]
		public static extern void GetDoublev(glGetFloatParameter pname, double[] @params);

		/// <summary>
		/// Returns the error code.
		/// </summary>
		/// <returns>A <see cref="glErrorCode"/> specifying the error.</returns>
		[DllImport(DLLName, EntryPoint="glGetError")]
		public static extern glErrorCode GetError();

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetFloatv")]
		public static extern void GetFloatv(glGetFloatParameter pname, out float param);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetFloatv")]
		public static extern void GetFloatv(glGetFloatParameter pname, float[] @params);

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetIntegerParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetIntegerv")]
		public static extern void GetIntegerv(glGetIntegerParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetIntegerParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetIntegerv")]
		public static extern void GetIntegerv(glGetIntegerParameter pname, int[] @params);

		[DllImport(DLLName, EntryPoint="glGetString")]
		private static extern IntPtr GetStringAsIntPtr(glGetStringParameter pname);

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetStringParameter"/> specifying the parameter.</param>
		/// <returns>The requested value as <b>string</b>.</returns>
		public static string GetString(glGetStringParameter pname)
		{
			return Marshal.PtrToStringAnsi(GetStringAsIntPtr(pname));
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, IntPtr pixels);

		#region Overloads for GetTexImage
		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int offset)
		{
			GetTexImage(target, level, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="offset">The offset into the array bound to <see cref="glBufferTarget.PIXEL_PACK_BUFFER"/>.</param>
		public static void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, long offset)
		{
			if(((long)offset>>32)!=0) throw new ArgumentOutOfRangeException("offset", PlatformErrorString);
			GetTexImage(target, level, format, type, (IntPtr)offset);
		}

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.UNSIGNED_BYTE"/>, <see cref="glPixelDataType.UNSIGNED_BYTE_3_3_2"/> or <see cref="glPixelDataType.UNSIGNED_BYTE_2_3_3_REV"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, byte[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.BYTE"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, sbyte[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.SHORT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, short[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_SHORT*</b>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, ushort[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.INT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, int[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <b>glPixelDataType.UNSIGNED_INT*</b>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, uint[] pixels);

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, long[] pixels);

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, ulong[] pixels);

		/// <summary>
		/// Reads a texture.
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out. Must be <see cref="glPixelDataType.FLOAT"/>.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, float[] pixels);

		/// <summary>
		/// Reads a texture. (For future use. Type not yet supported.)
		/// </summary>
		/// <param name="target">A <see cref="glTextureProxyTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail to be read.</param>
		/// <param name="format">A <see cref="glPixelFormat"/> specifying the format the pixels a given out.</param>
		/// <param name="type">A <see cref="glPixelDataType"/> specifying the data type the pixels a given out.</param>
		/// <param name="pixels">Pointer to the buffer for the returning data.</param>
		[DllImport(DLLName, EntryPoint="glGetTexImage")]
		public static extern void GetTexImage(glTextureProxyTarget target, int level, glPixelFormat format, glPixelDataType type, double[] pixels);
		#endregion

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameterfv")]
		public static extern void GetTexParameterfv(glTextureTarget target, glTextureParameter pname, out float param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameterfv")]
		public static extern void GetTexParameterfv(glTextureTarget target, glTextureParameter pname, float[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter. Only one of the texture filtering parameter is allowed.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glFilter param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter. Only one of the texture wrapping parameter is allowed.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glTextureWrapMode param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glTextureCompareMode param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glFunc param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.DEPTH_STENCIL_TEXTURE_MODE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glDepthStencilTextureMode param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_TARGET"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glTextureTarget param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.IMAGE_FORMAT_COMPATIBILITY_TYPE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glImageFormatCompatibilityType param);

		/// <summary>
		/// Returns the value of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, out glTextureSwizzleValue param);

		/// <summary>
		/// Returns the value(s) of a texture parameter.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetTexParameteriv")]
		public static extern void GetTexParameteriv(glTextureTarget target, glTextureParameter pname, glTextureSwizzleValue[] @params);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexLevelParameterfv")]
		public static extern void GetTexLevelParameterfv(glTextureProxyTarget target, int level, glTexLevelParameter pname, out float param);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetTexLevelParameterfv")]
		public static extern void GetTexLevelParameterfv(glTextureProxyTarget target, int level, glTexLevelParameter pname, float[] @params);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		[DllImport(DLLName, EntryPoint="glGetTexLevelParameteriv")]
		public static extern void GetTexLevelParameteriv(glTextureProxyTarget target, int level, glTexLevelParameter pname, out int param);

		/// <summary>
		/// Returns the texture parameter of a texture level.
		/// </summary>
		/// <param name="target">A <see cref="glTextureTarget"/> specifying the texture target.</param>
		/// <param name="level">The level-of-detail.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		[DllImport(DLLName, EntryPoint="glGetTexLevelParameteriv")]
		public static extern void GetTexLevelParameteriv(glTextureProxyTarget target, int level, glTexLevelParameter pname, int[] @params);

		/// <summary>
		/// Checks wether or not a OpenGL capability is enabled.
		/// </summary>
		/// <param name="cap">A <see cref="glCapability"/> specifying the capability to check.</param>
		/// <returns><b>true</b> if the capability is enabled.</returns>
		[DllImport(DLLName, EntryPoint="glIsEnabled")]
		[return: MarshalAs(UnmanagedType.I1)]
		public static extern bool IsEnabled(glCapability cap);

		/// <summary>
		/// Sets the depth range.
		/// </summary>
		/// <param name="zNear">The near value.</param>
		/// <param name="zFar">The far value.</param>
		[DllImport(DLLName, EntryPoint="glDepthRange")]
		public static extern void DepthRange(double zNear, double zFar);

		/// <summary>
		/// Sets the viewport.
		/// </summary>
		/// <param name="x">The start position in x-direction.</param>
		/// <param name="y">The start position in y-direction.</param>
		/// <param name="width">The width of the viewport.</param>
		/// <param name="height">The height of the viewport.</param>
		[DllImport(DLLName, EntryPoint="glViewport")]
		public static extern void Viewport(int x, int y, int width, int height);

		#region Get*
		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <returns>The requested value.</returns>
		public static double GetDouble(glGetFloatParameter pname)
		{
			double ret;
			GetDoublev(pname, out ret);
			return ret;
		}

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="size">The number of values.</param>
		/// <returns>The requested value(s).</returns>
		public static double[] GetDoubles(glGetFloatParameter pname, int size)
		{
			double[] res=new double[size];
			GetDoublev(pname, res);
			return res;
		}

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <returns>The requested value.</returns>
		public static float GetFloat(glGetFloatParameter pname)
		{
			float ret;
			GetFloatv(pname, out ret);
			return ret;
		}

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetFloatParameter"/> specifying the parameter.</param>
		/// <param name="size">The number of values.</param>
		/// <returns>The requested value(s).</returns>
		public static float[] GetFloats(glGetFloatParameter pname, int size)
		{
			float[] res=new float[size];
			GetFloatv(pname, res);
			return res;
		}

		/// <summary>
		/// Returns the value of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetIntegerParameter"/> specifying the parameter.</param>
		/// <returns>The requested value.</returns>
		public static int GetInteger(glGetIntegerParameter pname)
		{
			int ret;
			GetIntegerv(pname, out ret);
			return ret;
		}

		/// <summary>
		/// Returns the value(s) of a parameter.
		/// </summary>
		/// <param name="pname">A <see cref="glGetIntegerParameter"/> specifying the parameter.</param>
		/// <param name="size">The number of values.</param>
		/// <returns>The requested value(s).</returns>
		public static int[] GetIntegers(glGetIntegerParameter pname, int size)
		{
			int[] res=new int[size];
			GetIntegerv(pname, res);
			return res;
		}
		#endregion
	}
}
