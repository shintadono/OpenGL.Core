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
	/// Target for <see cref="O:OpenGL.Core.gl.TexImage3D">gl.TexImage3D</see>,
	/// <see cref="gl.TexImage3DMultisample"/>,
	/// <see cref="O:OpenGL.Core.gl.CompressedTexImage3D">gl.CompressedTexImage3D</see>,
	/// <see cref="gl.TexStorage3D"/> and <see cref="gl.TexStorage3DMultisample"/>.
	/// </summary>
	public enum glTexture3DProxyTarget : uint
	{
		/// <summary>
		/// 3D texture object.
		/// </summary>
		TEXTURE_3D = 0x806F,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// </summary>
		PROXY_TEXTURE_3D = 0x8070,

		/// <summary>
		/// 2D texture array object.
		/// </summary>
		TEXTURE_2D_ARRAY = 0x8C1A,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// </summary>
		PROXY_TEXTURE_2D_ARRAY = 0x8C1B,

		/// <summary>
		/// Cube map array texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_ARRAY = 0x9009,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// </summary>
		PROXY_TEXTURE_CUBE_MAP_ARRAY = 0x900B,

		/// <summary>
		/// 2D multisample texture array object.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9102,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// </summary>
		PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY = 0x9103,
	}
}
