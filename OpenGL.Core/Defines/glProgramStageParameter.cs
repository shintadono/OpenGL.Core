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
	/// Enum for program stage parameter. Used by <see cref="gl.GetProgramStageiv"/>.
	/// </summary>
	public enum glProgramStageParameter : uint
	{
		/// <summary>
		/// Number of active subroutines.
		/// </summary>
		ACTIVE_SUBROUTINES=0x8DE5,

		/// <summary>
		/// Number of active subroutine variables.
		/// </summary>
		ACTIVE_SUBROUTINE_UNIFORMS=0x8DE6,

		/// <summary>
		/// Number of active subroutine variable locations.
		/// </summary>
		ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS=0x8E47,

		/// <summary>
		/// Length of the longest  subroutine name.
		/// </summary>
		ACTIVE_SUBROUTINE_MAX_LENGTH=0x8E48,

		/// <summary>
		/// Length of the longest subroutine uniform.
		/// </summary>
		ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH=0x8E49,
	}
}
