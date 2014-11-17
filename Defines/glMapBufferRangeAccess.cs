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
	/// Flags for <see cref="O:OpenGL.Core.gl.MapBufferRange">gl.MapBufferRange</see>.
	/// </summary>
	[Flags]
	public enum glMapBufferRangeAccess : uint
	{
		/// <summary>
		/// -
		/// </summary>
		None=0x0000,

		/// <summary>
		/// Get read access.
		/// </summary>
		MAP_READ_BIT=0x0001,

		/// <summary>
		/// Get write access.
		/// </summary>
		MAP_WRITE_BIT=0x0002,

		/// <summary>
		/// Specified range of the buffer may be discarded.
		/// </summary>
		MAP_INVALIDATE_RANGE_BIT=0x0004,

		/// <summary>
		/// Entire buffer may be discarded.
		/// </summary>
		MAP_INVALIDATE_BUFFER_BIT=0x0008,

		/// <summary>
		/// Modification to the buffer must/will be flushed by calling <see cref="O:OpenGL.Core.gl.FlushMappedBufferRange">gl.FlushMappedBufferRange</see>
		/// </summary>
		MAP_FLUSH_EXPLICIT_BIT=0x0010,

		/// <summary>
		/// Do not attempt to synchronize pending operations on buffer before returning.
		/// </summary>
		MAP_UNSYNCHRONIZED_BIT=0x0020,

		/// <summary>
		/// Shared buffer with OpenGL while mapped.
		/// </summary>
		MAP_PERSISTENT_BIT=0x0040,

		/// <summary>
		/// Perform mapping coherently. (When mapped and accessed by OpenGL.)
		/// </summary>
		MAP_COHERENT_BIT=0x0080,
	}
}
