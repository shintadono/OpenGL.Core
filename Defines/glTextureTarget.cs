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
	/// Target for <see cref="gl.BindTexture"/>, <see cref="O:OpenGL.Core.gl.TexParameteri">gl.TexParameter*</see>,
	/// <see cref="O:OpenGL.Core.gl.GetTexParameteriv">gl.GetTexParameter*</see>,
	/// <see cref="gl.GetInternalformativ">gl.GetInternalformati*</see>,
	/// <see cref="gl.GenerateMipmap"/>, <see cref="gl.TextureView"/>, and <see cref="gl.CopyImageSubData"/>.
	/// </summary>
	public enum glTextureTarget : uint
	{
		/// <summary>
		/// Nothing bound.
		/// </summary>
		NONE=0,

		/// <summary>
		/// 1D texture object.
		/// </summary>
		TEXTURE_1D=0x0DE0,

		/// <summary>
		/// 1D texture array object.
		/// </summary>
		TEXTURE_1D_ARRAY=0x8C18,

		/// <summary>
		/// 2D texture object.
		/// </summary>
		TEXTURE_2D=0x0DE1,

		/// <summary>
		/// 2D texture array object.
		/// </summary>
		TEXTURE_2D_ARRAY=0x8C1A,

		/// <summary>
		/// 2D multisample texture object.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE=0x9100,

		/// <summary>
		/// 2D multisample texture array object.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE_ARRAY=0x9102,

		/// <summary>
		/// 3D texture object.
		/// </summary>
		TEXTURE_3D=0x806F,

		/// <summary>
		/// Buffer texture object.
		/// Allowed only as argument in <see cref="gl.BindTexture"/>, <see cref="gl.GetInternalformativ"/> and <see cref="gl.GetInternalformati64v"/>.
		/// </summary>
		TEXTURE_BUFFER=0x8C2A,

		/// <summary>
		/// Cube map texture object.
		/// </summary>
		TEXTURE_CUBE_MAP=0x8513,

		/// <summary>
		/// Cube map array texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_ARRAY=0x9009,

		/// <summary>
		/// 2D rectangle texture object.
		/// </summary>
		TEXTURE_RECTANGLE=0x84F5,

		/// <summary>
		/// Render buffer object.
		/// Allowed only as argument in <see cref="gl.GetInternalformativ"/> and <see cref="gl.GetInternalformati64v"/>.
		/// </summary>
		RENDERBUFFER=0x8D41,
	}
}
