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
	/// Enum returned by <see cref="gl.CheckFramebufferStatus"/>.
	/// </summary>
	public enum glFramebufferStatus : uint
	{
		/// <summary>
		/// Error in <see cref="gl.CheckFramebufferStatus"/>.
		/// </summary>
		ERROR=0,

		/// <summary>
		/// Framebuffer is complete.
		/// </summary>
		FRAMEBUFFER_COMPLETE=0x8CD5,

		/// <summary>
		/// Framebuffer has an incomplete attachment.
		/// </summary>
		FRAMEBUFFER_INCOMPLETE_ATTACHMENT=0x8CD6,

		/// <summary>
		/// Framebuffer is missing an attachment.
		/// </summary>
		FRAMEBUFFER_INCOMPLETE_MISSING_ATTACHMENT=0x8CD7,
		//FRAMEBUFFER_INCOMPLETE_DRAW_BUFFER=0x8CDB, // not in standard
		//FRAMEBUFFER_INCOMPLETE_READ_BUFFER=0x8CDC, // not in standard

		/// <summary>
		/// Number of samples or sample locations for attached buffer is/are different.
		/// </summary>
		FRAMEBUFFER_INCOMPLETE_MULTISAMPLE=0x8D56,

		/// <summary>
		/// Not all attachments are layered or of the same texture target.
		/// </summary>
		FRAMEBUFFER_INCOMPLETE_LAYER_TARGETS=0x8DA8,

		/// <summary>
		/// Framebuffer not (yet) defined.
		/// </summary>
		FRAMEBUFFER_UNDEFINED=0x8219,

		/// <summary>
		/// Combination of internal formats is not supported.
		/// </summary>
		FRAMEBUFFER_UNSUPPORTED=0x8CDD,
	}
}
