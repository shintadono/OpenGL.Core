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
	/// Enum for texture parameter.
	/// </summary>
	public enum glTextureParameter : uint
	{
		/// <summary>
		/// Depth stencil texture mode. (<see cref="glDepthStencilTextureMode"/>)
		/// </summary>
		DEPTH_STENCIL_TEXTURE_MODE=0x90EA,

		/// <summary>
		/// Base texture array. (<b>int</b>)
		/// </summary>
		TEXTURE_BASE_LEVEL=0x813C,

		/// <summary>
		/// Border color. Array of four <b>float</b>s.
		/// </summary>
		TEXTURE_BORDER_COLOR=0x1004,

		/// <summary>
		/// Texture comparison function. (<see cref="glFunc"/>)
		/// </summary>
		TEXTURE_COMPARE_FUNC=0x884D,

		/// <summary>
		/// Texture comparison mode. (<see cref="glTextureCompareMode"/>)
		/// </summary>
		TEXTURE_COMPARE_MODE=0x884C,

		/// <summary>
		/// Texture level of detail bias. (<b>float</b>)
		/// </summary>
		TEXTURE_LOD_BIAS=0x8501,

		/// <summary>
		/// Magnification function. (<see cref="glFilter"/>)
		/// </summary>
		TEXTURE_MAG_FILTER=0x2800,

		/// <summary>
		/// Maximum texture array level. (<b>int</b>)
		/// </summary>
		TEXTURE_MAX_LEVEL=0x813D,

		/// <summary>
		/// Maximum level of detail. (<b>float</b>)
		/// </summary>
		TEXTURE_MAX_LOD=0x813B,

		/// <summary>
		/// Minification function. (<see cref="glFilter"/>)
		/// </summary>
		TEXTURE_MIN_FILTER=0x2801,

		/// <summary>
		/// Minimum level of detail. (<b>float</b>)
		/// </summary>
		TEXTURE_MIN_LOD=0x813A,

		/// <summary>
		/// Alpha component swizzle. (<see cref="glTextureSwizzleValue"/>)
		/// </summary>
		TEXTURE_SWIZZLE_A=0x8E45,

		/// <summary>
		/// Blue component swizzle. (<see cref="glTextureSwizzleValue"/>)
		/// </summary>
		TEXTURE_SWIZZLE_B=0x8E44,

		/// <summary>
		/// Green component swizzle. (<see cref="glTextureSwizzleValue"/>)
		/// </summary>
		TEXTURE_SWIZZLE_G=0x8E43,

		/// <summary>
		/// Red component swizzle. (<see cref="glTextureSwizzleValue"/>)
		/// </summary>
		TEXTURE_SWIZZLE_R=0x8E42,

		/// <summary>
		/// All components swizzle. Array of four <see cref="glTextureSwizzleValue"/>s.
		/// </summary>
		TEXTURE_SWIZZLE_RGBA=0x8E46,

		/// <summary>
		/// Texture wrap mode for texture coordinate <c>r</c>. (<see cref="glTextureWrapMode"/>)
		/// </summary>
		TEXTURE_WRAP_R=0x8072,

		/// <summary>
		/// Texture wrap mode for texture coordinate <c>s</c>. (<see cref="glTextureWrapMode"/>)
		/// </summary>
		TEXTURE_WRAP_S=0x2802,

		/// <summary>
		/// Texture wrap mode for texture coordinate <c>t</c>. (<see cref="glTextureWrapMode"/>)
		/// </summary>
		TEXTURE_WRAP_T=0x2803,

		/// <summary>
		/// Compatibility rules for texture use with image units. Only used by <b>GetTexParameter*</b>; returns <see cref="glImageFormatCompatibilityType"/>.
		/// </summary>
		IMAGE_FORMAT_COMPATIBILITY_TYPE=0x90C7,

		/// <summary>
		/// Indicates if size and format are immutable. Only used by <b>GetTexParameter*</b>; returns <b>bool</b>.
		/// </summary>
		TEXTURE_IMMUTABLE_FORMAT=0x912F,

		/// <summary>
		/// Immutable texture storage levels. Only used by <b>GetTexParameter*</b>; returns <b>int</b>.
		/// </summary>
		TEXTURE_IMMUTABLE_LEVELS=0x82DF,

		/// <summary>
		/// Base texture level for texture view. Only used by <b>GetTexParameter*</b>; returns <b>uint</b>.
		/// </summary>
		TEXTURE_VIEW_MIN_LEVEL=0x82DB,
		
		/// <summary>
		/// Number of texture level for texture view. Only used by <b>GetTexParameter*</b>; returns <b>uint</b>.
		/// </summary>
		TEXTURE_VIEW_NUM_LEVELS=0x82DC,
		
		/// <summary>
		/// Minimum texture array layer for texture view. Only used by <b>GetTexParameter*</b>; returns <b>uint</b>.
		/// </summary>
		TEXTURE_VIEW_MIN_LAYER=0x82DD,

		/// <summary>
		/// Number of texture array layer for texture view. Only used by <b>GetTexParameter*</b>; returns <b>uint</b>.
		/// </summary>
		TEXTURE_VIEW_NUM_LAYERS=0x82DE,

		/// <summary>
		/// The effective target of the texture object. Only used by <b>GetTexParameter*</b>; returns <see cref="glTextureTarget"/>.
		/// </summary>
		TEXTURE_TARGET=0x1006,
	}
}
