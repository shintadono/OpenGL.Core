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
	/// Enum for subroutine uniform parameter. Used by <see cref="gl.GetActiveSubroutineUniformiv"/>.
	/// </summary>
	public enum glSubroutineUniformParameter : uint
	{
		/// <summary>
		/// Number of elements in subroutine uniform array.
		/// </summary>
		UNIFORM_SIZE=0x8A38,

		/// <summary>
		/// Length of subroutine uniform name.
		/// </summary>
		UNIFORM_NAME_LENGTH=0x8A39,

		/// <summary>
		/// Number of compatible subroutines.
		/// </summary>
		NUM_COMPATIBLE_SUBROUTINES=0x8E4A,

		/// <summary>
		/// List of <see cref="NUM_COMPATIBLE_SUBROUTINES"/> many compatible subroutines.
		/// </summary>
		COMPATIBLE_SUBROUTINES=0x8E4B,
	}
}
