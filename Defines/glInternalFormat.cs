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

namespace OpenGL.Core
{
	/// <summary>
	/// Internal (pixel data) format.
	/// </summary>
	public enum glInternalFormat : uint
	{
		/// <summary>
		/// Returned by <see cref="gl.GetInternalformativ">gl.GetInternalformat*</see>, if the specified <b>internalformat</b> is not supported.
		/// </summary>
		NONE=0,

		#region Base internal formats
		/// <summary>
		/// Base internal format. Depth buffer.
		/// </summary>
		DEPTH_COMPONENT=0x1902,

		/// <summary>
		/// Base internal format. Combined depth and stencil buffer.
		/// </summary>
		DEPTH_STENCIL=0x84F9,

		/// <summary>
		/// Base internal format. Stencil buffer.
		/// </summary>
		STENCIL_INDEX=0x1901,

		/// <summary>
		/// Base internal format. 1 color channel buffer (e.g. Alpha).
		/// </summary>
		RED=0x1903,

		/// <summary>
		/// Base internal format. 2 color channels buffer (e.g. Gray+Alpha).
		/// </summary>
		RG=0x8227,

		/// <summary>
		/// Base internal format. 3 color channels buffer.
		/// </summary>
		RGB=0x1907,

		/// <summary>
		/// Base internal format. 4 color channels buffer.
		/// </summary>
		RGBA=0x1908,

		/// <summary>
		/// Base internal format. 3 color channels buffer. (sRGB)
		/// </summary>
		SRGB=0x8C40,

		/// <summary>
		/// Base internal format. 4 color channels buffer. (sRGB)
		/// </summary>
		SRGB_ALPHA=0x8C42,
		#endregion

		#region Sized internal formats
		/// <summary>
		/// Sized internal format. Depth buffer. (16-bit)
		/// </summary>
		DEPTH_COMPONENT16=0x81A5,

		/// <summary>
		/// Sized internal format. Depth buffer. (24-bit)
		/// </summary>
		DEPTH_COMPONENT24=0x81A6,

		/// <summary>
		/// Sized internal format. Depth buffer. (32-bit)
		/// </summary>
		DEPTH_COMPONENT32=0x81A7,

		/// <summary>
		/// Sized internal format. Depth buffer. (32-bit; float)
		/// </summary>
		DEPTH_COMPONENT32F=0x8CAC,

		/// <summary>
		/// Sized internal format. Combined depth and stencil buffer. (24-bit + 8-bit)
		/// </summary>
		DEPTH24_STENCIL8=0x88F0,

		/// <summary>
		/// Sized internal format. Combined depth and stencil buffer. (32-bit; float + 8-bit)
		/// </summary>
		DEPTH32F_STENCIL8=0x8CAD,

		/// <summary>
		/// Sized internal format. Stencil buffer. (1-bit)
		/// </summary>
		STENCIL_INDEX1=0x8D46,

		/// <summary>
		/// Sized internal format. Stencil buffer. (4-bit)
		/// </summary>
		STENCIL_INDEX4=0x8D47,

		/// <summary>
		/// Sized internal format. Stencil buffer. (8-bit)
		/// </summary>
		STENCIL_INDEX8=0x8D48,

		/// <summary>
		/// Sized internal format. Stencil buffer. (16-bit)
		/// </summary>
		STENCIL_INDEX16=0x8D49,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (8-bit)
		/// </summary>
		R8=0x8229,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (8-bit; signed normalized)
		/// </summary>
		R8_SNORM=0x8F94,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (16-bit)
		/// </summary>
		R16=0x822A,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (16-bit; signed normalized)
		/// </summary>
		R16_SNORM=0x8F98,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 8-bit)
		/// </summary>
		RG8=0x822B,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 8-bit; signed normalized)
		/// </summary>
		RG8_SNORM=0x8F95,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 16-bit)
		/// </summary>
		RG16=0x822C,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 16-bit; signed normalized)
		/// </summary>
		RG16_SNORM=0x8F99,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3-bit + 3-bit + 2-bit)
		/// </summary>
		R3_G3_B2=0x2A10,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 4-bit)
		/// </summary>
		RGB4=0x804F,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 5-bit)
		/// </summary>
		RGB5=0x8050,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (5-bit + 6-bit + 5-bit)
		/// </summary>
		RGB565=0x8D62,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 8-bit)
		/// </summary>
		RGB8=0x8051,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 8-bit; signed normalized)
		/// </summary>
		RGB8_SNORM=0x8F96,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 10-bit)
		/// </summary>
		RGB10=0x8052,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 12-bit)
		/// </summary>
		RGB12=0x8053,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 16-bit)
		/// </summary>
		RGB16=0x8054,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 16-bit; signed normalized)
		/// </summary>
		RGB16_SNORM=0x8F9A,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 2-bit)
		/// </summary>
		RGBA2=0x8055,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 4-bit)
		/// </summary>
		RGBA4=0x8056,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (3 * 4-bit + 1-bit)
		/// </summary>
		RGB5_A1=0x8057,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 8-bit)
		/// </summary>
		RGBA8=0x8058,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 8-bit; signed normalized)
		/// </summary>
		RGBA8_SNORM=0x8F97,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (3 * 10-bit + 2-bit)
		/// </summary>
		RGB10_A2=0x8059,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (3 * 10-bit + 2-bit; unsigned integer)
		/// </summary>
		RGB10_A2UI=0x906F,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 12-bit)
		/// </summary>
		RGBA12=0x805A,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 16-bit)
		/// </summary>
		RGBA16=0x805B,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 16-bit; signed normalized)
		/// </summary>
		RGBA16_SNORM=0x8F9B,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 8-bit) (sRGB)
		/// </summary>
		SRGB8=0x8C41,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 8-bit) (sRGB)
		/// </summary>
		SRGB8_ALPHA8=0x8C43,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (16-bit; float)
		/// </summary>
		R16F=0x822D,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 16-bit; float)
		/// </summary>
		RG16F=0x822F,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 16-bit; float)
		/// </summary>
		RGB16F=0x881B,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 16-bit; float)
		/// </summary>
		RGBA16F=0x881A,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (32-bit; float)
		/// </summary>
		R32F=0x822E,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 32-bit; float)
		/// </summary>
		RG32F=0x8230,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 32-bit; float)
		/// </summary>
		RGB32F=0x8815,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 32-bit; float)
		/// </summary>
		RGBA32F=0x8814,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (11-bit + 11-bit + 10-bit; float)
		/// </summary>
		R11F_G11F_B10F=0x8C3A,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 9-bit + 5-bit shared exponent)
		/// </summary>
		RGB9_E5=0x8C3D,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (8-bit; integer)
		/// </summary>
		R8I=0x8231,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (8-bit; unsigned integer)
		/// </summary>
		R8UI=0x8232,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (16-bit; integer)
		/// </summary>
		R16I=0x8233,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (16-bit; unsigned integer)
		/// </summary>
		R16UI=0x8234,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (32-bit; integer)
		/// </summary>
		R32I=0x8235,

		/// <summary>
		/// Sized internal format. 1 color channel buffer. (32-bit; unsigned integer)
		/// </summary>
		R32UI=0x8236,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 8-bit; integer)
		/// </summary>
		RG8I=0x8237,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 8-bit; unsigned integer)
		/// </summary>
		RG8UI=0x8238,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 16-bit; integer)
		/// </summary>
		RG16I=0x8239,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 16-bit; unsigned integer)
		/// </summary>
		RG16UI=0x823A,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 32-bit; integer)
		/// </summary>
		RG32I=0x823B,

		/// <summary>
		/// Sized internal format. 2 color channels buffer. (2 * 32-bit; unsigned integer)
		/// </summary>
		RG32UI=0x823C,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 8-bit; integer)
		/// </summary>
		RGB8I=0x8D8F,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 8-bit; unsigned integer)
		/// </summary>
		RGB8UI=0x8D7D,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 16-bit; integer)
		/// </summary>
		RGB16I=0x8D89,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 16-bit; unsigned integer)
		/// </summary>
		RGB16UI=0x8D77,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 32-bit; integer)
		/// </summary>
		RGB32I=0x8D83,

		/// <summary>
		/// Sized internal format. 3 color channels buffer. (3 * 32-bit; unsigned integer)
		/// </summary>
		RGB32UI=0x8D71,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 8-bit; integer)
		/// </summary>
		RGBA8I=0x8D8E,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 8-bit; unsigned integer)
		/// </summary>
		RGBA8UI=0x8D7C,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 16-bit; integer)
		/// </summary>
		RGBA16I=0x8D88,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 16-bit; unsigned integer)
		/// </summary>
		RGBA16UI=0x8D76,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 32-bit; integer)
		/// </summary>
		RGBA32I=0x8D82,

		/// <summary>
		/// Sized internal format. 4 color channels buffer. (4 * 32-bit; unsigned integer)
		/// </summary>
		RGBA32UI=0x8D70,
		#endregion

		#region Generic compressed internal formats
		/// <summary>
		/// Generic compressed internal format. 1 color channel buffer (e.g. Alpha).
		/// </summary>
		COMPRESSED_RED=0x8225,

		/// <summary>
		/// Generic compressed internal format. 2 color channels buffer (e.g. Gray+Alpha).
		/// </summary>
		COMPRESSED_RG=0x8226,

		/// <summary>
		/// Generic compressed internal format. 3 color channels buffer.
		/// </summary>
		COMPRESSED_RGB=0x84ED,

		/// <summary>
		/// Generic compressed internal format. 4 color channels buffer.
		/// </summary>
		COMPRESSED_RGBA=0x84EE,

		/// <summary>
		/// Generic compressed internal format. 3 color channels buffer. (sRGB)
		/// </summary>
		COMPRESSED_SRGB=0x8C48,

		/// <summary>
		/// Generic compressed internal format. 4 color channels buffer. (sRGB)
		/// </summary>
		COMPRESSED_SRGB_ALPHA=0x8C49,
		#endregion

		#region Specific compressed internal formats
		/// <summary>
		/// Specific compressed internal format. 1 color channel buffer.
		/// </summary>
		COMPRESSED_RED_RGTC1=0x8DBB,

		/// <summary>
		/// Specific compressed internal format. 1 color channel buffer. (signed normalized)
		/// </summary>
		COMPRESSED_SIGNED_RED_RGTC1=0x8DBC,

		/// <summary>
		/// Specific compressed internal format. 2 color channels buffer.
		/// </summary>
		COMPRESSED_RG_RGTC2=0x8DBD,

		/// <summary>
		/// Specific compressed internal format. 2 color channels buffer. (signed normalized)
		/// </summary>
		COMPRESSED_SIGNED_RG_RGTC2=0x8DBE,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer.
		/// </summary>
		COMPRESSED_RGBA_BPTC_UNORM=0x8E8C,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer. (signed normalized)
		/// </summary>
		COMPRESSED_SRGB_ALPHA_BPTC_UNORM=0x8E8D,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer. (signed float)
		/// </summary>
		COMPRESSED_RGB_BPTC_SIGNED_FLOAT=0x8E8E,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer. (unsigned float)
		/// </summary>
		COMPRESSED_RGB_BPTC_UNSIGNED_FLOAT=0x8E8F,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer.
		/// </summary>
		COMPRESSED_RGB8_ETC2=0x9274,

		/// <summary>
		/// Specific compressed internal format. 3 color channels buffer. (sRGB)
		/// </summary>
		COMPRESSED_SRGB8_ETC2=0x9275,

		/// <summary>
		/// Specific compressed internal format. 4 color channels buffer (1-bit Alpha).
		/// </summary>
		COMPRESSED_RGB8_PUNCHTHROUGH_ALPHA1_ETC2=0x9276,

		/// <summary>
		/// Specific compressed internal format. 4 color channels buffer (1-bit Alpha). (sRGB)
		/// </summary>
		COMPRESSED_SRGB8_PUNCHTHROUGH_ALPHA1_ETC2=0x9277,

		/// <summary>
		/// Specific compressed internal format. 4 color channels buffer.
		/// </summary>
		COMPRESSED_RGBA8_ETC2_EAC=0x9278,

		/// <summary>
		/// Specific compressed internal format. 4 color channels buffer. (sRGB)
		/// </summary>
		COMPRESSED_SRGB8_ALPHA8_ETC2_EAC=0x9279,

		/// <summary>
		/// Specific compressed internal format. 1 color channel buffer.
		/// </summary>
		COMPRESSED_R11_EAC=0x9270,

		/// <summary>
		/// Specific compressed internal format. 1 color channel buffer. (signed normalized)
		/// </summary>
		COMPRESSED_SIGNED_R11_EAC=0x9271,

		/// <summary>
		/// Specific compressed internal format. 2 color channels buffer.
		/// </summary>
		COMPRESSED_RG11_EAC=0x9272,

		/// <summary>
		/// Specific compressed internal format. 2 color channels buffer. (signed normalized)
		/// </summary>
		COMPRESSED_SIGNED_RG11_EAC=0x9273,
		#endregion
	}
}
