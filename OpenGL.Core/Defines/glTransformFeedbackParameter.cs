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
	/// Enum for transform feedback parameter. Used by <b>gl.GetTransformFeedbacki*</b> methodes.
	/// </summary>
	public enum glTransformFeedbackParameter : uint
	{
		/// <summary>
		/// For <see cref="gl.GetTransformFeedbackiv"/>: Buffer object bound to generic binding point for transform feedback.
		/// For <see cref="gl.GetTransformFeedbacki_v"/>: Buffer objects bound to each (indexed) transform feedback buffer.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_BINDING=0x8C8F,

		/// <summary>
		/// Size of binding range for each (indexed) transform feedback attribute stream. Only used with <see cref="gl.GetTransformFeedbacki64_v"/>.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_SIZE=0x8C85,

		/// <summary>
		/// Start offset of binding range for each (indexed) transform feedback attribute stream. Only used with <see cref="gl.GetTransformFeedbacki64_v"/>.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_START=0x8C84,

		/// <summary>
		/// Is transform feedback active? Only used with <see cref="gl.GetTransformFeedbackiv"/>.
		/// </summary>
		TRANSFORM_FEEDBACK_ACTIVE=0x8E24,

		/// <summary>
		/// Is transform feedback paused? Only used with <see cref="gl.GetTransformFeedbackiv"/>.
		/// </summary>
		TRANSFORM_FEEDBACK_PAUSED=0x8E23,
	}
}
