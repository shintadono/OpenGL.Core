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
	/// Enum for transform feedback buffer modes. Used by <see cref="gl.TransformFeedbackVaryings"/>.
	/// Also queried by <see cref="gl.GetProgramiv"/> and set by <see cref="gl.ProgramParameteri"/>
	/// with <see cref="glProgramParameter.TRANSFORM_FEEDBACK_BUFFER_MODE"/>.
	/// </summary>
	public enum glTransformFeedbackBufferMode : uint
	{
		/// <summary>
		/// Each subsequent variable is assigned to the same binding point as the previous variable
		/// and an offset equal to the sum of the offset and size of the previous variable.
		/// </summary>
		INTERLEAVED_ATTRIBS=0x8C8C,

		/// <summary>
		/// Each subsequent variable is assigned to the binding point following the
		/// binding point of the previous variable with an offset of zero.
		/// </summary>
		SEPARATE_ATTRIBS=0x8C8D,
	}
}
