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
	/// Value for <see cref="O:OpenGL.Core.gl.GetBooleanv">gl.GetBooleanv</see>.
	/// </summary>
	public enum glGetBooleanParameter : uint
	{
		/// <summary>
		/// Is the currently bound buffer immutable?
		/// </summary>
		BUFFER_IMMUTABLE_STORAGE=0x821F,

		/// <summary>
		/// [Not standard: May not be supported.] Returns <b>true</b> if context supports robust access.
		/// </summary>
		CONTEXT_ROBUST_ACCESS=0x90F3,

		/// <summary>
		/// Is depth buffer enabled for writing?
		/// </summary>
		DEPTH_WRITEMASK=0x0B72,

		/// <summary>
		/// Is doublebuffering supported?
		/// </summary>
		DOUBLEBUFFER=0x0C32,

		/// <summary>
		/// Is Least-Significant-Bit-First enabled for pack operations? Deprecated since 4.3.
		/// </summary>
		PACK_LSB_FIRST=0x0D01,

		/// <summary>
		/// Is the byte-order of multi-byte-values (e.g. indices or colors) swapped for pack operations?
		/// </summary>
		PACK_SWAP_BYTES=0x0D00,

		/// <summary>
		/// Is primitive restart for patches supported?
		/// </summary>
		PRIMITIVE_RESTART_FOR_PATCHES_SUPPORTED=0x8221,

		/// <summary>
		/// Is the sample coverage mask temporarily inverted?
		/// </summary>
		SAMPLE_COVERAGE_INVERT=0x80AB,

		/// <summary>
		/// Is shader complilation supported?
		/// </summary>
		SHADER_COMPILER=0x8DFA,

		/// <summary>
		/// Is stereo supported?
		/// </summary>
		STEREO=0x0C33,

		/// <summary>
		/// Is transform feedback active?
		/// </summary>
		TRANSFORM_FEEDBACK_ACTIVE=0x8E24,

		/// <summary>
		/// Is transform feedback paused?
		/// </summary>
		TRANSFORM_FEEDBACK_PAUSED=0x8E23,

		/// <summary>
		/// Is Least-Significant-Bit-First enabled for unpack operations? Deprecated since 4.3.
		/// </summary>
		UNPACK_LSB_FIRST=0x0CF1,

		/// <summary>
		/// Is the byte-order of multi-byte-values (e.g. indices or colors) swapped for unpack operations?
		/// </summary>
		UNPACK_SWAP_BYTES=0x0CF0,
	}
}
