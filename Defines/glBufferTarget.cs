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
	/// Buffer target.
	/// </summary>
	public enum glBufferTarget : uint
	{
		/// <summary>
		/// Buffer for vertex attributes.
		/// </summary>
		ARRAY_BUFFER=0x8892,

		/// <summary>
		/// Atomic counter storages.
		/// </summary>
		ATOMIC_COUNTER_BUFFER=0x92C0,

		/// <summary>
		/// Source buffer for copy operations.
		/// </summary>
		COPY_READ_BUFFER=0x8F36,

		/// <summary>
		/// Destination buffer for copy operations.
		/// </summary>
		COPY_WRITE_BUFFER=0x8F37,

		/// <summary>
		/// Buffer for indirect compute dispatch commands.
		/// </summary>
		DISPATCH_INDIRECT_BUFFER=0x90EE,

		/// <summary>
		/// Buffer for indirect command arguments.
		/// </summary>
		DRAW_INDIRECT_BUFFER=0x8F3F,

		/// <summary>
		/// Buffer for vertex array indices.
		/// </summary>
		ELEMENT_ARRAY_BUFFER=0x8893,

		/// <summary>
		/// Target buffer for pixel read operations.
		/// </summary>
		PIXEL_PACK_BUFFER=0x88EB,

		/// <summary>
		/// Source buffer for pixel write operations.
		/// </summary>
		PIXEL_UNPACK_BUFFER=0x88EC,

		/// <summary>
		/// Buffer for query results.
		/// </summary>
		QUERY_BUFFER=0x9192,

		/// <summary>
		/// Read-write storages for shaders.
		/// </summary>
		SHADER_STORAGE_BUFFER=0x90D2,

		/// <summary>
		/// Buffer for texture data.
		/// </summary>
		TEXTURE_BUFFER=0x8C2A,

		/// <summary>
		/// Buffer for transform feedback results.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER=0x8C8E,

		/// <summary>
		/// Uniform block storage.
		/// </summary>
		UNIFORM_BUFFER=0x8A11,
	}
}
