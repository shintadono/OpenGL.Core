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
	/// Flags for <see cref="O:OpenGL.Core.gl.BufferStorage">gl.BufferStorage</see>.
	/// </summary>
	[Flags]
	public enum glBufferStorageFlag : uint
	{
		/// <summary>
		/// Handle nothing.
		/// </summary>
		None=0x0000,

		/// <summary>
		/// Read access to mapped store.
		/// </summary>
		MAP_READ_BIT=0x0001,

		/// <summary>
		/// Write access to mapped store.
		/// </summary>
		MAP_WRITE_BIT=0x0002,

		/// <summary>
		/// Allow server to read from and write to buffer, while mapped.
		/// </summary>
		MAP_PERSISTENT_BIT=0x0040,

		/// <summary>
		/// OpenGL keeps simultaneously mapped (to client and server) buffer automatically coherent.
		/// </summary>
		MAP_COHERENT_BIT=0x0080,

		/// <summary>
		/// Allow client updates to buffer through calls to <see cref="O:OpenGL.Core.gl.BufferSubData">gl.BufferSubData</see>.
		/// </summary>
		DYNAMIC_STORAGE_BIT=0x0100,

		/// <summary>
		/// Tell implentation to use client side backing store for buffer.
		/// </summary>
		CLIENT_STORAGE_BIT=0x0200,
	}
}
