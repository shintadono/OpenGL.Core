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
	/// Enum for atomic counter buffer parameter. Used by <see cref="gl.GetActiveAtomicCounterBufferiv"/>.
	/// </summary>
	public enum glAtomicCounterBufferParameter : uint
	{
		/// <summary>
		/// Current atomic counter buffer binding.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1,

		/// <summary>
		/// Size of the active atomic counter buffer.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_DATA_SIZE = 0x92C4,

		/// <summary>
		/// Number of active atomic counters in atomic counter buffer.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS = 0x92C5,

		/// <summary>
		/// Indices of the active atomic counters in atomic counter buffer.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES = 0x92C6,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the vertex shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER = 0x92C7,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the tesselation control shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER = 0x92C8,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the tesselation evaluation shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER = 0x92C9,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the geometry shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER = 0x92CA,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the fragment shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER = 0x92CB,

		/// <summary>
		/// Indicates if the active atomic counter buffer is referenced by the compute shader.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER = 0x90ED,
	}
}
