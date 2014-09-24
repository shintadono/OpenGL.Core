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
	/// Used by <see cref="gl.GetFramebufferAttachmentParameteriv"/>.
	/// </summary>
	public enum glFramebufferAttachmentParameter : uint
	{
		/// <summary>
		/// Color encoding of the framebuffer attachment as <see cref="glColorEncoding"/>.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_COLOR_ENCODING=0x8210,

		/// <summary>
		/// Component type of the framebuffer attachment as <see cref="glComponentType"/>
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_COMPONENT_TYPE=0x8211,

		/// <summary>
		/// Size in bits of the red component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_RED_SIZE=0x8212,

		/// <summary>
		/// Size in bits of the green component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_GREEN_SIZE=0x8213,

		/// <summary>
		/// Size in bits of the blue component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_BLUE_SIZE=0x8214,

		/// <summary>
		/// Size in bits of the alpha component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_ALPHA_SIZE=0x8215,

		/// <summary>
		/// Size in bits of the depth component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_DEPTH_SIZE=0x8216,

		/// <summary>
		/// Size in bits of the stencil component of the framebuffer attachment.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_STENCIL_SIZE=0x8217,

		/// <summary>
		/// Object type of the framebuffer attachment as <see cref="glFramebufferAttachmentObjectType"/>.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_OBJECT_TYPE=0x8CD0,

		/// <summary>
		/// Name of the object attached to the framebuffer.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_OBJECT_NAME=0x8CD1,

		/// <summary>
		/// Mipmap level of texture image attached, if object attached is texture.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_TEXTURE_LEVEL=0x8CD2,

		/// <summary>
		/// Face of cube map texture as <see cref="glTexture2DTarget"/> or <see cref="gl.NONE"/>.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_TEXTURE_CUBE_MAP_FACE=0x8CD3,

		/// <summary>
		/// Layer of texture image attached, if object attached is 3D texture.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_TEXTURE_LAYER=0x8CD4,

		/// <summary>
		/// Framebuffer attachment is layered.
		/// </summary>
		FRAMEBUFFER_ATTACHMENT_LAYERED=0x8DA7,
	}
}
