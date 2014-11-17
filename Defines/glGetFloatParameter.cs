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
	/// Value for <see cref="O:OpenGL.Core.gl.GetFloatv">gl.GetFloatv</see> and <see cref="O:OpenGL.Core.gl.GetDoublev">gl.GetDoublev</see>.
	/// </summary>
	public enum glGetFloatParameter : uint
	{
		/// <summary>
		/// Range of aliased line widths. Array of two <b>float</b>s (lo and hi).
		/// </summary>
		ALIASED_LINE_WIDTH_RANGE=0x846E,

		/// <summary>
		/// Constant blend color. Array of four <b>float</b>s (RGBA).
		/// </summary>
		BLEND_COLOR=0x8005,

		/// <summary>
		/// Color buffer clear value. Array of four <b>float</b>s (RGBA).
		/// </summary>
		COLOR_CLEAR_VALUE=0x0C22,

		/// <summary>
		/// Depth buffer clear value.
		/// </summary>
		DEPTH_CLEAR_VALUE=0x0B73,

		/// <summary>
		/// Current line width.
		/// </summary>
		LINE_WIDTH=0x0B21,

		/// <summary>
		/// Furthest positive offset for <c>interpolateAtOffset</c>.
		/// </summary>
		MAX_FRAGMENT_INTERPOLATION_OFFSET=0x8E5C,

		/// <summary>
		/// Maximum absolute texture level of detail bias.
		/// </summary>
		MAX_TEXTURE_LOD_BIAS=0x84FD,

		/// <summary>
		/// Maximum viewport dimensions. Array of two <b>float</b>s (x and y).
		/// </summary>
		MAX_VIEWPORT_DIMS=0x0D3A,

		/// <summary>
		/// Furthest negative offset for <c>interpolateAtOffset</c>.
		/// </summary>
		MIN_FRAGMENT_INTERPOLATION_OFFSET=0x8E5B,

		/// <summary>
		/// Fraction of multisamples to use for sample shading.
		/// </summary>
		MIN_SAMPLE_SHADING_VALUE=0x8C37,

		/// <summary>
		/// Default inner tesselation level without control shader. Array of two <b>float</b>s.
		/// </summary>
		PATCH_DEFAULT_INNER_LEVEL=0x8E73,

		/// <summary>
		/// Default inner tesselation level without control shader. Array of four <b>float</b>s.
		/// </summary>
		PATCH_DEFAULT_OUTER_LEVEL=0x8E74,

		/// <summary>
		/// Threshold for alpha attenuation.
		/// </summary>
		POINT_FADE_THRESHOLD_SIZE=0x8128,

		/// <summary>
		/// Current point size.
		/// </summary>
		POINT_SIZE=0x0B11,

		/// <summary>
		/// Range of point sprite sizes. Array of two <b>float</b>s (lo and hi).
		/// </summary>
		POINT_SIZE_RANGE=0x0B12,

		/// <summary>
		/// Point sprite size granularity.
		/// </summary>
		POINT_SIZE_GRANULARITY=0x0B13,

		/// <summary>
		/// Polygon offset factor.
		/// </summary>
		POLYGON_OFFSET_FACTOR=0x8038,

		/// <summary>
		/// Polygon offset units.
		/// </summary>
		POLYGON_OFFSET_UNITS=0x2A00,

		/// <summary>
		/// Coverage mask value.
		/// </summary>
		SAMPLE_COVERAGE_VALUE=0x80AA,

		/// <summary>
		/// Range of antialiased line widths. Array of two <b>float</b>s (lo and hi).
		/// </summary>
		SMOOTH_LINE_WIDTH_RANGE=0x0B22,

		/// <summary>
		/// Antialiased line width granularity.
		/// </summary>
		SMOOTH_LINE_WIDTH_GRANULARITY=0x0B23,

		/// <summary>
		/// Viewport bounds range. Array of two <b>float</b>s (min and max).
		/// </summary>
		VIEWPORT_BOUNDS_RANGE=0x825D,
	}
}
