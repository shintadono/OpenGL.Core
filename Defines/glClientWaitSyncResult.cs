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
	/// Returned by <see cref="gl.ClientWaitSync"/>.
	/// </summary>
	public enum glClientWaitSyncResult : uint
	{
		/// <summary>
		/// Sync object was signaled at the time <see cref="gl.ClientWaitSync"/> was called.
		/// </summary>
		ALREADY_SIGNALED=0x911A,

		/// <summary>
		/// <see cref="gl.ClientWaitSync"/> retured because the timeout period expired.
		/// </summary>
		TIMEOUT_EXPIRED=0x911B,

		/// <summary>
		/// Sync object was signaled before timeout period expired.
		/// </summary>
		CONDITION_SATISFIED=0x911C,

		/// <summary>
		/// <see cref="gl.ClientWaitSync"/> failed and returned immediately.
		/// </summary>
		WAIT_FAILED=0x911D,
	}
}
