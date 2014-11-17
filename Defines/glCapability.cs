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
	/// Target for <see cref="gl.Enable"/>, <see cref="gl.Disable"/> and <see cref="gl.IsEnabled"/>.
	/// </summary>
	public enum glCapability : uint
	{
		/// <summary>
		/// Blending activation state.
		/// </summary>
		BLEND=0x0BE2,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE0=0x3000,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE1=0x3001,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE2=0x3002,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE3=0x3003,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE4=0x3004,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE5=0x3005,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE6=0x3006,

		/// <summary>
		/// Clipping plane activation state.
		/// </summary>
		CLIP_DISTANCE7=0x3007,
		// ... until CLIP_DISTANCE4095=0x3FFF,

		/// <summary>
		/// Logic operation activation state.
		/// </summary>
		COLOR_LOGIC_OP=0x0BF2,

		/// <summary>
		/// Face culling activation state.
		/// </summary>
		CULL_FACE=0x0B44,

		/// <summary>
		/// Debug output activation state.
		/// </summary>
		DEBUG_OUTPUT=0x92E0,

		/// <summary>
		/// Synchronous debug output activation state.
		/// </summary>
		DEBUG_OUTPUT_SYNCHRONOUS=0x8242,

		/// <summary>
		/// Depth clamping activation state.
		/// </summary>
		DEPTH_CLAMP=0x864F,

		/// <summary>
		/// Depth test activation state.
		/// </summary>
		DEPTH_TEST=0x0B71,

		/// <summary>
		/// Dithering activation state.
		/// </summary>
		DITHER=0x0BD0,

		/// <summary>
		/// sRGB update and blending activation state.
		/// </summary>
		FRAMEBUFFER_SRGB=0x8DB9,

		/// <summary>
		/// Line antialiasing activation state.
		/// </summary>
		LINE_SMOOTH=0x0B20,

		/// <summary>
		/// Multisample rasterization activation state.
		/// </summary>
		MULTISAMPLE=0x809D,

		/// <summary>
		/// Polygon offset for <see cref="glPolygonMode.FILL"/> mode rasterization activation state.
		/// </summary>
		POLYGON_OFFSET_FILL=0x8037,

		/// <summary>
		/// Polygon offset for <see cref="glPolygonMode.LINE"/> mode rasterization activation state.
		/// </summary>
		POLYGON_OFFSET_LINE=0x2A02,

		/// <summary>
		/// Polygon offset for <see cref="glPolygonMode.POINT"/> mode rasterization activation state.
		/// </summary>
		POLYGON_OFFSET_POINT=0x2A01,

		/// <summary>
		/// Polygon antialiasing activation state.
		/// </summary>
		POLYGON_SMOOTH=0x0B41,

		/// <summary>
		/// Primitive restart activation state.
		/// </summary>
		PRIMITIVE_RESTART=0x8F9D,

		/// <summary>
		/// Fixed index primitice restart activation state.
		/// </summary>
		PRIMITIVE_RESTART_FIXED_INDEX=0x8D69,

		/// <summary>
		/// Program point size activation state.
		/// </summary>
		PROGRAM_POINT_SIZE=0x8642,

		/// <summary>
		/// Discard primitives before rasterization activation state.
		/// </summary>
		RASTERIZER_DISCARD=0x8C89,

		/// <summary>
		/// Modify coverage from alpha activation state.
		/// </summary>
		SAMPLE_ALPHA_TO_COVERAGE=0x809E,

		/// <summary>
		/// Set alpha to maximum activation state.
		/// </summary>
		SAMPLE_ALPHA_TO_ONE=0x809F,

		/// <summary>
		/// Mask to modify coverage activation state.
		/// </summary>
		SAMPLE_COVERAGE=0x80A0,

		/// <summary>
		/// Sample masking activation state.
		/// </summary>
		SAMPLE_MASK=0x8E51,

		/// <summary>
		/// Sample shading activation state.
		/// </summary>
		SAMPLE_SHADING=0x8C36,

		/// <summary>
		/// Scissor test activation state.
		/// </summary>
		SCISSOR_TEST=0x0C11,

		/// <summary>
		/// Stencil test activation state.
		/// </summary>
		STENCIL_TEST=0x0B90,

		/// <summary>
		/// Seamless cube map texturing activation state.
		/// </summary>
		TEXTURE_CUBE_MAP_SEAMLESS=0x884F,
	}
}
