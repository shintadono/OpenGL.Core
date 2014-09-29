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
	/// Enum returns by <see cref="O:OpenGL.Core.gl.GetTexParameteriv">gl.GetTexParameteriv</see> for <see cref="glTextureParameter.IMAGE_FORMAT_COMPATIBILITY_TYPE"/> and
	/// <see cref="gl.GetInternalformativ"/> for <see cref="glInternalformatParameter.IMAGE_FORMAT_COMPATIBILITY_TYPE"/>.
	/// </summary>
	public enum glImageFormatCompatibilityType : uint
	{
		/// <summary>
		/// Returned if resource is not supported, or if image textures are not supported.
		/// </summary>
		NONE=0,

		/// <summary>
		/// Compatibility is matched by size.
		/// </summary>
		IMAGE_FORMAT_COMPATIBILITY_BY_SIZE=0x90C8,

		/// <summary>
		/// Compatibility is matched by class.
		/// </summary>
		IMAGE_FORMAT_COMPATIBILITY_BY_CLASS=0x90C9,
	}
}
