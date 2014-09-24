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
	/// Uniform parameter. Used by <see cref="gl.GetActiveUniformsiv"/>.
	/// </summary>
	public enum glUniformParameter : uint
	{
		/// <summary>
		/// Type of the uniform.
		/// </summary>
		UNIFORM_TYPE=0x8A37,

		/// <summary>
		/// Size of the uniform.
		/// </summary>
		UNIFORM_SIZE=0x8A38,

		/// <summary>
		/// Length of the uniform name.
		/// </summary>
		UNIFORM_NAME_LENGTH=0x8A39,

		/// <summary>
		/// Block index of the uniform.
		/// </summary>
		UNIFORM_BLOCK_INDEX=0x8A3A,

		/// <summary>
		/// Offset of the uniform.
		/// </summary>
		UNIFORM_OFFSET=0x8A3B,

		/// <summary>
		/// Array stride of the uniform.
		/// </summary>
		UNIFORM_ARRAY_STRIDE=0x8A3C,

		/// <summary>
		/// Matrix stride of the uniform.
		/// </summary>
		UNIFORM_MATRIX_STRIDE=0x8A3D,

		/// <summary>
		/// Boolean indicating the kind of matrix order of the uniform.
		/// </summary>
		UNIFORM_IS_ROW_MAJOR=0x8A3E,

		/// <summary>
		/// Atomic counter buffer index of the uniform.
		/// </summary>
		UNIFORM_ATOMIC_COUNTER_BUFFER_INDEX=0x92DA,
	}
}
