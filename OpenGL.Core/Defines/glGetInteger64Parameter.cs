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
	/// Value for <see cref="gl.GetInteger64v"/>.
	/// </summary>
	public enum glGetInteger64Parameter : uint
	{
		/// <summary>
		/// Maximum value for element indices. (For compatibility with OpengGL ES implementations.)
		/// </summary>
		MAX_ELEMENT_INDEX=0x8D6B,

		/// <summary>
		/// Maximum shader storage size.
		/// </summary>
		MAX_SHADER_STORAGE_BLOCK_SIZE=0x90DE,

		/// <summary>
		/// Maximum server wait timeout value.
		/// </summary>
		MAX_SERVER_WAIT_TIMEOUT=0x9111,

		/// <summary>
		/// Current time.
		/// </summary>
		TIMESTAMP=0x8E28,
	}
}
