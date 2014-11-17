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
	/// Bitmask for <see cref="gl.MemoryBarrier"/> and <see cref="gl.MemoryBarrierByRegion"/>.
	/// </summary>
	[Flags]
	public enum glMemoryBarrierMask : uint
	{
		/// <summary>
		/// Synchronize nothing.
		/// </summary>
		None=0x00000000,

		/// <summary>
		/// Synchronize vertex attrib arrays.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_BARRIER_BIT=0x00000001,

		/// <summary>
		/// Synchronize element arrays.
		/// </summary>
		ELEMENT_ARRAY_BARRIER_BIT=0x00000002,

		/// <summary>
		/// Synchronize uniforms.
		/// </summary>
		UNIFORM_BARRIER_BIT=0x00000004,

		/// <summary>
		/// Synchronize shader textures accesses.
		/// </summary>
		TEXTURE_FETCH_BARRIER_BIT=0x00000008,

		/// <summary>
		/// Synchronize shader image access.
		/// </summary>
		SHADER_IMAGE_ACCESS_BARRIER_BIT=0x00000020,

		/// <summary>
		/// Synchronize commands.
		/// </summary>
		COMMAND_BARRIER_BIT=0x00000040,
		
		/// <summary>
		/// Synchronize pixel buffer accesses.
		/// </summary>
		PIXEL_BUFFER_BARRIER_BIT=0x00000080,
		
		/// <summary>
		/// Synchronize texture accesses.
		/// </summary>
		TEXTURE_UPDATE_BARRIER_BIT=0x00000100,
		
		/// <summary>
		/// Synchronize buffer accesses.
		/// </summary>
		BUFFER_UPDATE_BARRIER_BIT=0x00000200,
		
		/// <summary>
		/// Synchronize framebuffer accesses.
		/// </summary>
		FRAMEBUFFER_BARRIER_BIT=0x00000400,
		
		/// <summary>
		/// Synchronize transform feedback buffer accesses.
		/// </summary>
		TRANSFORM_FEEDBACK_BARRIER_BIT=0x00000800,
		
		/// <summary>
		/// Synchronize accesses to atomic counters.
		/// </summary>
		ATOMIC_COUNTER_BARRIER_BIT=0x00001000,

		/// <summary>
		/// Synchronize shade buffer accesses.
		/// </summary>
		SHADER_STORAGE_BARRIER_BIT=0x00002000,

		/// <summary>
		/// Synchronize mapped buffer accesses.
		/// </summary>
		CLIENT_MAPPED_BUFFER_BARRIER_BIT=0x00004000,

		/// <summary>
		/// Synchronize query buffer accesses.
		/// </summary>
		QUERY_BUFFER_BARRIER_BIT=0x00008000,

		/// <summary>
		/// Synchronize everything.
		/// </summary>
		ALL_BARRIER_BITS=0xFFFFFFFF,
	}
}
