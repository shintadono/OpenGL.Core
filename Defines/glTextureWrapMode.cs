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
	/// Value for <see cref="glTextureParameter.TEXTURE_WRAP_S"/>, <see cref="glTextureParameter.TEXTURE_WRAP_T"/> and
	/// <see cref="glTextureParameter.TEXTURE_WRAP_R"/>. Used as value by
	/// <see cref="O:OpenGL.Core.gl.TexParameteri">gl.TexParameteri</see> and
	/// <see cref="O:OpenGL.Core.gl.GetTexParameteriv">gl.GetTexParameter</see>.
	/// </summary>
	public enum glTextureWrapMode : uint
	{
		/// <summary>
		/// Clamp texture to image edge.
		/// </summary>
		CLAMP_TO_EDGE=0x812F,

		/// <summary>
		/// Clamp texture to border color.
		/// </summary>
		CLAMP_TO_BORDER=0x812D,

		/// <summary>
		/// Repeat texture.
		/// </summary>
		REPEAT=0x2901,

		/// <summary>
		/// Repeat texture mirrored.
		/// </summary>
		MIRRORED_REPEAT=0x8370,

		/// <summary>
		/// Same as <see cref="CLAMP_TO_EDGE"/>, but mirrored. New in OpenGL 4.4.
		/// </summary>
		MIRROR_CLAMP_TO_EDGE=0x8743,
	}
}
