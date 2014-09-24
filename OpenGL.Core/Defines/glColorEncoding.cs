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
	/// Enum returns by <see cref="gl.GetInternalformativ"/> for <see cref="glInternalformatParameter.COLOR_ENCODING"/> and
	/// <see cref="gl.GetFramebufferAttachmentParameteriv"/> for <see cref="glFramebufferAttachmentParameter.FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING"/>.
	public enum glColorEncoding : uint
	{
		/// <summary>
		/// Returned if resource is not supported, or if image textures are not supported.
		/// </summary>
		NONE=0,

		/// <summary>
		/// Linear encoded color components.
		/// </summary>
		LINEAR=0x2601,

		/// <summary>
		/// sRGB-encoded color components.
		/// </summary>
		SRGB=0x8C40,
	}
}
