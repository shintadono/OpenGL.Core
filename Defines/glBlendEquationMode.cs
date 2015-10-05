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
	/// Blend equations.
	/// </summary>
	public enum glBlendEquationMode : uint
	{
		/// <summary>
		/// Add weighted source and weighted destination.
		/// </summary>
		FUNC_ADD = 0x8006,

		/// <summary>
		/// Subtract weighted destination from weighted source.
		/// </summary>
		FUNC_SUBTRACT = 0x800A,

		/// <summary>
		/// Subtract weighted source from weighted destination.
		/// </summary>
		FUNC_REVERSE_SUBTRACT = 0x800B,

		/// <summary>
		/// Minimum of source and destination.
		/// </summary>
		MIN = 0x8007,

		/// <summary>
		/// Maximum of source and destination.
		/// </summary>
		MAX = 0x8008,
	}
}
