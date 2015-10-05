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

namespace OpenGL.Core
{
	/// <summary>
	/// Enum for controlling pixel storage modes. Used by <see cref="gl.PixelStorei"/>.
	/// The parameter names prefixed <c>UNPACK_</c> are used for write operations like <b>TexImage*</b> and
	/// those prefixed <c>PACK_</c> are used for reading operations like <b>ReadPixels</b>.
	/// </summary>
	public enum glPixelStoreParameter : uint
	{
		/// <summary>
		/// <b>Boolean</b> value indicating, if byte-order for multi-byte values are swapped.
		/// </summary>
		UNPACK_SWAP_BYTES = 0x0CF0,

		/// <summary>
		/// <b>Boolean</b> value indicating the bit-order.
		/// </summary>
		[Obsolete("Deprecated since 4.3")]
		UNPACK_LSB_FIRST = 0x0CF1,

		/// <summary>
		/// <b>Integer</b>, overrides the <i>width</i> argument of pixel storage operations.
		/// </summary>
		UNPACK_ROW_LENGTH = 0x0CF2,

		/// <summary>
		/// <b>Integer</b>, specifying the number of rows skipped (for each image) in pixel storage operations.
		/// </summary>
		UNPACK_SKIP_ROWS = 0x0CF3,

		/// <summary>
		/// <b>Integer</b>, specifying the number of pixels skipped in each row in pixel storage operations.
		/// </summary>
		UNPACK_SKIP_PIXELS = 0x0CF4,

		/// <summary>
		/// <b>Integer</b>, specifying the row-to-row spacing of the elements (byte position).
		/// </summary>
		UNPACK_ALIGNMENT = 0x0CF5,

		/// <summary>
		/// <b>Integer</b>, specifying the number of images skipped in pixel storage operations.
		/// </summary>
		UNPACK_SKIP_IMAGES = 0x806D,

		/// <summary>
		/// <b>Integer</b>, overrides the <i>height</i> argument of pixel storage operations.
		/// </summary>
		UNPACK_IMAGE_HEIGHT = 0x806E,

		/// <summary>
		/// <b>Boolean</b> value indicating, if byte-order for multi-byte values are swapped.
		/// </summary>
		PACK_SWAP_BYTES = 0x0D00,

		/// <summary>
		/// <b>Boolean</b> value indicating the bit-order.
		/// </summary>
		[Obsolete("Deprecated since 4.3")]
		PACK_LSB_FIRST = 0x0D01,

		/// <summary>
		/// <b>Integer</b>, overrides the <i>width</i> argument of pixel storage operations.
		/// </summary>
		PACK_ROW_LENGTH = 0x0D02,

		/// <summary>
		/// <b>Integer</b>, specifying the number of rows skipped (for each image) in pixel storage operations.
		/// </summary>
		PACK_SKIP_ROWS = 0x0D03,

		/// <summary>
		/// <b>Integer</b>, specifying the number of pixels skipped in each row in pixel storage operations.
		/// </summary>
		PACK_SKIP_PIXELS = 0x0D04,

		/// <summary>
		/// <b>Integer</b>, specifying the row-to-row spacing of the elements (byte position).
		/// </summary>
		PACK_ALIGNMENT = 0x0D05,

		/// <summary>
		/// <b>Integer</b>, specifying the number of images skipped in pixel storage operations.
		/// </summary>
		PACK_SKIP_IMAGES = 0x806B,

		/// <summary>
		/// <b>Integer</b>, overrides the <i>height</i> argument of pixel storage operations.
		/// </summary>
		PACK_IMAGE_HEIGHT = 0x806C,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block width in pixel storage operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block height in pixel storage operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block depth in pixel storage operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block size in bytes in pixel storage operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block width in pixel storage operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_WIDTH = 0x912B,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block height in pixel storage operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block depth in pixel storage operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_DEPTH = 0x912D,

		/// <summary>
		/// <b>Integer</b>, specifying the compressed block size in bytes in pixel storage operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_SIZE = 0x912E,
	}
}
