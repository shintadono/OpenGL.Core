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
	/// Target for <see cref="O:OpenGL.Core.gl.TexSubImage2D">gl.TexSubImage2D</see>,
	/// <see cref="gl.CopyTexImage2D"/>, <see cref="gl.CopyTexSubImage1D"/> and
	/// <see cref="O:OpenGL.Core.gl.CompressedTexImage2D">gl.CompressedTexImage2D</see>,
	/// and texture target for <see cref="gl.FramebufferTexture2D"/>.
	/// </summary>
	public enum glTexture2DTarget : uint
	{
		/// <summary>
		/// 2D texture object.
		/// </summary>
		TEXTURE_2D=0x0DE1,

		/// <summary>
		/// 2D rectangle texture object.
		/// </summary>
		TEXTURE_RECTANGLE=0x84F5,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_POSITIVE_X=0x8515,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_NEGATIVE_X=0x8516,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_POSITIVE_Y=0x8517,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_NEGATIVE_Y=0x8518,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_POSITIVE_Z=0x8519,

		/// <summary>
		/// Face of a cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_NEGATIVE_Z=0x851A,

		/// <summary>
		/// 1D texture array object.
		/// </summary>
		TEXTURE_1D_ARRAY=0x8C18,

		/// <summary>
		/// 2D multisample texture object.
		/// Allowed only as argument in <see cref="gl.FramebufferTexture2D"/>.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE=0x9100,
	}
}
