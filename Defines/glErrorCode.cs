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
	/// Returned by <see cref="gl.GetError"/>.
	/// </summary>
	public enum glErrorCode : uint
	{
		/// <summary>
		/// No error.
		/// </summary>
		NO_ERROR = 0,

		/// <summary>
		/// Enum argument out of range.
		/// </summary>
		INVALID_ENUM = 0x0500,

		/// <summary>
		/// Numeric argument out of range.
		/// </summary>
		INVALID_VALUE = 0x0501,

		/// <summary>
		/// Operation illegal in current state.
		/// </summary>
		INVALID_OPERATION = 0x0502,

		/// <summary>
		/// Framebuffer object is not complete.
		/// </summary>
		INVALID_FRAMEBUFFER_OPERATION = 0x0506,

		/// <summary>
		/// Not enough memory left to execute command.
		/// </summary>
		OUT_OF_MEMORY = 0x0505,

		/// <summary>
		/// Command would cause a stack overflow.
		/// </summary>
		STACK_OVERFLOW = 0x0503,

		/// <summary>
		/// Command would cause a stack underflow.
		/// </summary>
		STACK_UNDERFLOW = 0x0504,

		/// <summary>
		/// Context has been lost and reset by the driver.
		/// </summary>
		CONTEXT_LOST = 0x507,
	}
}
