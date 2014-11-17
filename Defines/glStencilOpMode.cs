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
	/// Stencil operation.
	/// </summary>
	public enum glStencilOpMode : uint
	{
		/// <summary>
		/// Keep current value.
		/// </summary>
		KEEP=0x1E00,

		/// <summary>
		/// Set to zero.
		/// </summary>
		ZERO=0,

		/// <summary>
		/// Replace with reference value.
		/// </summary>
		REPLACE=0x1E01,

		/// <summary>
		/// Increment with saturation current value.
		/// </summary>
		INCR=0x1E02,

		/// <summary>
		/// Decrement with saturation current value.
		/// </summary>
		DECR=0x1E03,

		/// <summary>
		/// Invert current value.
		/// </summary>
		INVERT=0x150A,

		/// <summary>
		/// Increment without saturation current value.
		/// </summary>
		INCR_WRAP=0x8507,

		/// <summary>
		/// Decrement without saturation current value.
		/// </summary>
		DECR_WRAP=0x8508,
	}
}
