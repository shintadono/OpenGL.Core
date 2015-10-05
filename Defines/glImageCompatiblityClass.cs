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
	/// Enum returned by <see cref="gl.GetInternalformativ"/> for <see cref="glInternalformatParameter.IMAGE_COMPATIBILITY_CLASS"/>.
	/// </summary>
	public enum glImageCompatiblityClass : uint
	{
		/// <summary>
		/// Returned if resource is not supported, or if image textures are not supported.
		/// </summary>
		NONE = 0,

		/// <summary>
		/// Resource is compatible to image class 4x32.
		/// </summary>
		IMAGE_CLASS_4_X_32 = 0x82B9,

		/// <summary>
		/// Resource is compatible to image class 2x32.
		/// </summary>
		IMAGE_CLASS_2_X_32 = 0x82BA,

		/// <summary>
		/// Resource is compatible to image class 1x32.
		/// </summary>
		IMAGE_CLASS_1_X_32 = 0x82BB,

		/// <summary>
		/// Resource is compatible to image class 4x16.
		/// </summary>
		IMAGE_CLASS_4_X_16 = 0x82BC,

		/// <summary>
		/// Resource is compatible to image class 2x16.
		/// </summary>
		IMAGE_CLASS_2_X_16 = 0x82BD,

		/// <summary>
		/// Resource is compatible to image class 1x16.
		/// </summary>
		IMAGE_CLASS_1_X_16 = 0x82BE,

		/// <summary>
		/// Resource is compatible to image class 4x8.
		/// </summary>
		IMAGE_CLASS_4_X_8 = 0x82BF,

		/// <summary>
		/// Resource is compatible to image class 2x8.
		/// </summary>
		IMAGE_CLASS_2_X_8 = 0x82C0,

		/// <summary>
		/// Resource is compatible to image class 1x8.
		/// </summary>
		IMAGE_CLASS_1_X_8 = 0x82C1,

		/// <summary>
		/// Resource is compatible to image class 11/11/10 packed floating-point.
		/// </summary>
		IMAGE_CLASS_11_11_10 = 0x82C2,

		/// <summary>
		/// Resource is compatible to image class 10/10/10/2 packed.
		/// </summary>
		IMAGE_CLASS_10_10_10_2 = 0x82C3,
	}
}
