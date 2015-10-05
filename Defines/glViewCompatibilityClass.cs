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
	/// Compatible internal formats for <b>gl.TextureView</b>.
	/// Returned by <see cref="gl.GetInternalformativ"/>(<see cref="glInternalformatParameter.VIEW_COMPATIBILITY_CLASS"/>).
	/// </summary>
	public enum glViewCompatibilityClass : uint
	{
		/// <summary>
		/// Returned if the resource has no other formats that are compatible or the resource does not support views or if
		/// texture views are not supported.
		/// </summary>
		NONE = 0,

		/// <summary>
		/// 128-bit class.
		/// </summary>
		VIEW_CLASS_128_BITS = 0x82C4,

		/// <summary>
		/// 96-bit class.
		/// </summary>
		VIEW_CLASS_96_BITS = 0x82C5,

		/// <summary>
		/// 64-bit class.
		/// </summary>
		VIEW_CLASS_64_BITS = 0x82C6,

		/// <summary>
		/// 48-bit class.
		/// </summary>
		VIEW_CLASS_48_BITS = 0x82C7,

		/// <summary>
		/// 32-bit class.
		/// </summary>
		VIEW_CLASS_32_BITS = 0x82C8,

		/// <summary>
		/// 24-bit class.
		/// </summary>
		VIEW_CLASS_24_BITS = 0x82C9,

		/// <summary>
		/// 16-bit class.
		/// </summary>
		VIEW_CLASS_16_BITS = 0x82CA,

		/// <summary>
		/// 8-bit class.
		/// </summary>
		VIEW_CLASS_8_BITS = 0x82CB,

		/// <summary>
		/// Compressed RGTC1 (red) class.
		/// </summary>
		VIEW_CLASS_RGTC1_RED = 0x82D0,

		/// <summary>
		/// Compressed RGTC2 (red+green) class.
		/// </summary>
		VIEW_CLASS_RGTC2_RG = 0x82D1,

		/// <summary>
		/// Compressed BPTC (unsigned normalized) class.
		/// </summary>
		VIEW_CLASS_BPTC_UNORM = 0x82D2,

		/// <summary>
		/// Compressed BPTC (float) class.
		/// </summary>
		VIEW_CLASS_BPTC_FLOAT = 0x82D3,

		//VIEW_CLASS_S3TC_DXT1_RGB=0x82CC,
		//VIEW_CLASS_S3TC_DXT1_RGBA=0x82CD,
		//VIEW_CLASS_S3TC_DXT3_RGBA=0x82CE,
		//VIEW_CLASS_S3TC_DXT5_RGBA=0x82CF,
	}
}
