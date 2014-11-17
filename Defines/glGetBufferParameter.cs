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
	/// Enum buffer parameter. Used by <see cref="gl.GetBufferParameteriv"/> and <see cref="gl.GetBufferPointerv"/>.
	/// </summary>
	public enum glGetBufferParameter : uint
	{
		/// <summary>
		/// Returns size of the buffer.
		/// </summary>
		BUFFER_SIZE=0x8764,

		/// <summary>
		/// Returns buffer usage as <see cref="glBufferUsage"/>.
		/// </summary>
		BUFFER_USAGE=0x8765,

		/// <summary>
		/// Returns buffer access as <see cref="glAccess"/>.
		/// </summary>
		BUFFER_ACCESS=0x88BB,

		/// <summary>
		/// Returns buffer access flags as <see cref="glMapBufferRangeAccess"/>.
		/// </summary>
		BUFFER_ACCESS_FLAGS=0x911F,

		/// <summary>
		/// <see cref="gl.TRUE"/> if the storage is set immutable, <see cref="gl.FALSE"/> otherwise.
		/// </summary>
		BUFFER_IMMUTABLE_STORAGE=0x821F,

		/// <summary>
		/// <see cref="gl.TRUE"/> if a region of the buffer is mapped, <see cref="gl.FALSE"/> otherwise.
		/// </summary>
		BUFFER_MAPPED=0x88BC,

		/// <summary>
		/// Only allowed in <see cref="gl.GetBufferPointerv"/>.
		/// </summary>
		BUFFER_MAP_POINTER=0x88BD,

		/// <summary>
		/// Returns the offset of the mapped region.
		/// </summary>
		BUFFER_MAP_OFFSET=0x9121,

		/// <summary>
		/// Returns the size of the mapped region.
		/// </summary>
		BUFFER_MAP_LENGTH=0x9120,

		/// <summary>
		/// Returns buffer storage flags as <see cref="glBufferStorageFlag"/>.
		/// </summary>
		BUFFER_STORAGE_FLAGS=0x8220,
	}
}
