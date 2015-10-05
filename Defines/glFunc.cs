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
	/// Function for stencil and depth operations.
	/// </summary>
	public enum glFunc : uint
	{
		/// <summary>
		/// Test never passes.
		/// </summary>
		NEVER = 0x0200,

		/// <summary>
		/// Test passes if referenced value is less than the stored value.
		/// </summary>
		LESS = 0x0201,

		/// <summary>
		/// Test passes if referenced value is equal to the stored value.
		/// </summary>
		EQUAL = 0x0202,

		/// <summary>
		/// Test passes if referenced value is less than or equal to the stored value.
		/// </summary>
		LEQUAL = 0x0203,

		/// <summary>
		/// Test passes if referenced value is greater than the stored value.
		/// </summary>
		GREATER = 0x0204,

		/// <summary>
		/// Test passes if referenced value is not equal to the stored value.
		/// </summary>
		NOTEQUAL = 0x0205,

		/// <summary>
		/// Test passes if referenced value is greater than or equal to the stored value.
		/// </summary>
		GEQUAL = 0x0206,

		/// <summary>
		/// Test always passes.
		/// </summary>
		ALWAYS = 0x0207,
	}
}
