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
	/// Blend function factors.
	/// </summary>
	public enum glBlendFuncFactor : uint
	{
		/// <summary>
		/// Zero.
		/// </summary>
		ZERO=0,

		/// <summary>
		/// One.
		/// </summary>
		ONE=1,

		/// <summary>
		/// Source color.
		/// </summary>
		SRC_COLOR=0x0300,

		/// <summary>
		/// One - source color.
		/// </summary>
		ONE_MINUS_SRC_COLOR=0x0301,

		/// <summary>
		/// Source alpha.
		/// </summary>
		SRC_ALPHA=0x0302,

		/// <summary>
		/// One - source alpha.
		/// </summary>
		ONE_MINUS_SRC_ALPHA=0x0303,

		/// <summary>
		/// Destination alpha.
		/// </summary>
		DST_ALPHA=0x0304,

		/// <summary>
		/// One - destination alpha.
		/// </summary>
		ONE_MINUS_DST_ALPHA=0x0305,

		/// <summary>
		/// Destination color.
		/// </summary>
		DST_COLOR=0x0306,

		/// <summary>
		/// One - destination color.
		/// </summary>
		ONE_MINUS_DST_COLOR=0x0307,

		/// <summary>
		/// Source color and alpha 1.
		/// </summary>
		SRC_ALPHA_SATURATE=0x0308,

		/// <summary>
		/// Constant color.
		/// </summary>
		CONSTANT_COLOR=0x8001,

		/// <summary>
		/// One - constant color.
		/// </summary>
		ONE_MINUS_CONSTANT_COLOR=0x8002,

		/// <summary>
		/// Constant alpha.
		/// </summary>
		CONSTANT_ALPHA=0x8003,

		/// <summary>
		/// One - constant alpha.
		/// </summary>
		ONE_MINUS_CONSTANT_ALPHA=0x8004,

		/// <summary>
		/// 2nd source color.
		/// </summary>
		SRC1_COLOR=0x88F9,

		/// <summary>
		/// One - 2nd source color.
		/// </summary>
		ONE_MINUS_SRC1_COLOR=0x88FA,

		/// <summary>
		/// 2nd source alpha.
		/// </summary>
		SRC1_ALPHA=0x8589,

		/// <summary>
		/// One - 2nd source alpha.
		/// </summary>
		ONE_MINUS_SRC1_ALPHA=0x88FB,
	}
}
