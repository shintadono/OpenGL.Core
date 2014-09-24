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
	/// Enum for shader parameter. Used by <see cref="gl.GetShaderiv"/>.
	/// </summary>
	public enum glShaderParameter : uint
	{
		/// <summary>
		/// Returns the shader type (<see cref="glShaderType"/>).
		/// </summary>
		SHADER_TYPE=0x8B4F,

		/// <summary>
		/// <b>gl.TRUE</b> is returned if the shader has been flagged for deletion, and <b>gl.FALSE</b> is returned otherwise.
		/// </summary>
		DELETE_STATUS=0x8B80,

		/// <summary>
		/// <b>gl.TRUE</b> is returned if the shader was last compiled successfully, and <b>gl.FALSE</b> is returned otherwise.
		/// </summary>
		COMPILE_STATUS=0x8B81,

		/// <summary>
		/// Length of the info log, including a null terminator, is returned. If there is no info log, zero is returned.
		/// </summary>
		INFO_LOG_LENGTH=0x8B84,

		/// <summary>
		/// Length of the concatenation of the source strings making up the shader source, including a null terminator,
		/// is returned. If no source has been defined, zero is returned.
		/// </summary>
		SHADER_SOURCE_LENGTH=0x8B88,
	}
}
