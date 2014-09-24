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
	/// Returned by <see cref="gl.GetGraphicsResetStatus"/>.
	/// </summary>
	public enum glGraphicsResetStatus : uint
	{
		/// <summary>
		/// The GL context has not been in a reset state since the last call.
		/// </summary>
		NO_ERROR=0,

		/// <summary>
		/// A reset has been detected that is attributable to the current GL context.
		/// </summary>
		GUILTY_CONTEXT_RESET=0x8253,

		/// <summary>
		/// A reset has been detected that is not attributable to the current GL context.
		/// </summary>
		INNOCENT_CONTEXT_RESET=0x8254,

		/// <summary>
		/// A detected graphics reset whose cause is unknown.
		/// </summary>
		UNKNOWN_CONTEXT_RESET=0x8255,
	}
}
