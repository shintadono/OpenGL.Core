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
	/// Enum returned by <see cref="O:OpenGL.Core.gl.GetTexLevelParameteriv">gl.GetTexLevelParameteriv</see>
	/// for <c>glGetTexLevelParameters.TEXTURE_*_TYPE</c>,
	/// <see cref="gl.GetFramebufferAttachmentParameteriv"/> for <see cref="glFramebufferAttachmentParameter.FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE"/> and 
	/// <see cref="gl.GetInternalformativ"/> for <c>glInternalformatParameter.INTERNALFORMAT_*_TYPE</c>
	/// (with * is <c>RED</c>, <c>GREEN</c>, <c>BLUE</c>, <c>ALPHA</c>,<c>DEPTH</c> and <c>STENCIL</c>).
	/// </summary>
	public enum glComponentType : uint
	{
		/// <summary>
		/// Component not present or not supported.
		/// </summary>
		NONE = 0,

		/// <summary>
		/// Component is signed integer.
		/// </summary>
		INT = 0x1404,

		/// <summary>
		/// Component is unsigned integer.
		/// </summary>
		UNSIGNED_INT = 0x1405,

		/// <summary>
		/// Component is floating-point.
		/// </summary>
		FLOAT = 0x1406,

		/// <summary>
		/// Component is unsigned normalized.
		/// </summary>
		UNSIGNED_NORMALIZED = 0x8C17,

		/// <summary>
		/// Component is signed normalized.
		/// </summary>
		SIGNED_NORMALIZED = 0x8F9C,
	}
}
