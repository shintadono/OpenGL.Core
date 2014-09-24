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
	/// Target for <see cref="gl.TexSubImage3D(glTexture3DTarget, int, int, int, int, int, int, int, glPixelFormat, glPixelDataType, System.IntPtr)">gl.TexSubImage3D</see>,
	/// <see cref="gl.CopyTexSubImage3D"/> and
	/// <see cref="gl.CompressedTexImage3D(glTexture3DProxyTarget, int, glInternalFormat, int, int, int, int, int, byte[])">gl.CompressedTexImage3D</see>,
	/// and texture target for <see cref="gl.FramebufferTexture3D"/>.
	/// </summary>
	public enum glTexture3DTarget : uint
	{
		/// <summary>
		/// 3D texture object.
		/// </summary>
		TEXTURE_3D=0x806F,

		/// <summary>
		/// 2D texture array object.
		/// </summary>
		TEXTURE_2D_ARRAY=0x8C1A,

		/// <summary>
		/// Cube map array texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_ARRAY=0x9009,
	}
}
