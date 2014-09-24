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
	/// Texture level parameter. Used by <see cref="gl.GetTexLevelParameteriv(glTextureProxyTarget, int, glTexLevelParameter, int[])">gl.GetTexLevelParameteriv</see>.
	/// </summary>
	public enum glTexLevelParameter : uint
	{
		/// <summary>
		/// Width of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_WIDTH=0x1000,

		/// <summary>
		/// Height of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_HEIGHT=0x1001,

		/// <summary>
		/// Depth of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_DEPTH=0x8071,

		/// <summary>
		/// Internal format of the specified level-of-detail of the current texture. (<see cref="glInternalFormat"/>)
		/// </summary>
		TEXTURE_INTERNAL_FORMAT=0x1003,

		/// <summary>
		/// Number of samples per texel of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_SAMPLES=0x9106,

		/// <summary>
		/// Fixed sample pattern used for the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_FIXED_SAMPLE_LOCATIONS=0x9107,

		/// <summary>
		/// Type (<see cref="glComponentType"/>) of the red component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_RED_TYPE=0x8C10,

		/// <summary>
		/// Type (<see cref="glComponentType"/>) of the green component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_GREEN_TYPE=0x8C11,

		/// <summary>
		/// Type (<see cref="glComponentType"/>) of the blue component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_BLUE_TYPE=0x8C12,

		/// <summary>
		/// Type (<see cref="glComponentType"/>) of the alpha component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_ALPHA_TYPE=0x8C13,

		/// <summary>
		/// Type (<see cref="glComponentType"/>) of the depth component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_DEPTH_TYPE=0x8C16,

		/// <summary>
		/// Size/Resolition of the red component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_RED_SIZE=0x805C,

		/// <summary>
		/// Size/Resolition of the green component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_GREEN_SIZE=0x805D,

		/// <summary>
		/// Size/Resolition of the blue component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_BLUE_SIZE=0x805E,

		/// <summary>
		/// Size/Resolition of the alpha component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_ALPHA_SIZE=0x805F,

		/// <summary>
		/// Size/Resolition of the depth component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_DEPTH_SIZE=0x884A,

		/// <summary>
		/// Size/Resolition of the stencil component of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_STENCIL_SIZE=0x88F1,

		/// <summary>
		/// Size/Resolition of the shared exponent of the components of the specified level-of-detail of the current texture.
		/// </summary>
		TEXTURE_SHARED_SIZE=0x8C3F,

		/// <summary>
		/// <b>True</b> if image has a compressed internal format.
		/// </summary>
		TEXTURE_COMPRESSED=0x86A1,

		/// <summary>
		/// Size (in bytes) of compressed image.
		/// </summary>
		TEXTURE_COMPRESSED_IMAGE_SIZE=0x86A0,

		/// <summary>
		/// Buffer object bound as the data store for the active image unit's buffer texture.
		/// </summary>
		TEXTURE_BUFFER_DATA_STORE_BINDING=0x8C2D,

		/// <summary>
		/// Offset into buffer's data store used for the active image unit's buffer texture.
		/// </summary>
		TEXTURE_BUFFER_OFFSET=0x919D,

		/// <summary>
		/// Size into buffer's data store used for the active image unit's buffer texture.
		/// </summary>
		TEXTURE_BUFFER_SIZE=0x919E,
	}
}
