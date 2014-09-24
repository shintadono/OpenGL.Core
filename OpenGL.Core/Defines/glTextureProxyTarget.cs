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
	/// Target for <see cref="gl.GetTexImage(glTextureProxyTarget, int, glPixelFormat, glPixelDataType, System.IntPtr)">gl.GetTexImage</see>,
	/// <see cref="gl.GetTexParameteriv(glTextureTarget, glTextureParameter, int[])">gl.GetTexParameter*</see> and
	/// <see cref="gl.GetCompressedTexImage(glTextureProxyTarget, int, byte[])">gl.GetCompressedTexImage</see>.
	/// </summary>
	public enum glTextureProxyTarget : uint
	{
		/// <summary>
		/// 1D texture object.
		/// </summary>
		TEXTURE_1D=0x0DE0,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_1D=0x8063,

		/// <summary>
		/// 2D texture object.
		/// </summary>
		TEXTURE_2D=0x0DE1,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_2D=0x8064,

		/// <summary>
		/// 3D texture object.
		/// </summary>
		TEXTURE_3D=0x806F,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_3D=0x8070,

		/// <summary>
		/// 2D rectangle texture object.
		/// </summary>
		TEXTURE_RECTANGLE=0x84F5,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_RECTANGLE=0x84F7,

		///// <summary>
		///// Cube map texture object.
		///// </summary>
		//TEXTURE_CUBE_MAP=0x8513,

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
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_CUBE_MAP=0x851B,

		/// <summary>
		/// 1D texture array object.
		/// </summary>
		TEXTURE_1D_ARRAY=0x8C18,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_1D_ARRAY=0x8C19,

		/// <summary>
		/// 2D texture array object.
		/// </summary>
		TEXTURE_2D_ARRAY=0x8C1A,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_2D_ARRAY=0x8C1B,

		/// <summary>
		/// Buffer texture object.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		TEXTURE_BUFFER=0x8C2A,

		/// <summary>
		/// Cube map array texture object.
		/// </summary>
		TEXTURE_CUBE_MAP_ARRAY=0x9009,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_CUBE_MAP_ARRAY=0x900B,

		/// <summary>
		/// 2D multisample texture object.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE=0x9100,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_2D_MULTISAMPLE=0x9101,

		/// <summary>
		/// 2D multisample texture array object.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		TEXTURE_2D_MULTISAMPLE_ARRAY=0x9102,

		/// <summary>
		/// Virtual texture object, used to check, if a real texture object of that kind and specification could be created.
		/// Allowed only as argument in <see cref="gl.GetTexLevelParameterfv(glTextureProxyTarget, int, glTexLevelParameter, float[])">gl.GetTexLevelParameterfv</see>
		/// and <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
		/// </summary>
		PROXY_TEXTURE_2D_MULTISAMPLE_ARRAY=0x9103,
	}
}
