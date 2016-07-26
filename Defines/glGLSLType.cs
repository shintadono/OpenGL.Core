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

using System;

namespace OpenGL.Core
{
	/// <summary>
	/// Enum to discribe OpenGL Shading Language (GLSL) data type.
	/// </summary>
	public enum glGLSLType : uint
	{
		/// <summary>
		/// Equivalent to GLSL keyword <c>float</c>.
		/// </summary>
		FLOAT = 0x1406,

		/// <summary>
		/// Equivalent to GLSL keyword <c>vec2</c>.
		/// </summary>
		FLOAT_VEC2 = 0x8B50,

		/// <summary>
		/// Equivalent to GLSL keyword <c>vec3</c>.
		/// </summary>
		FLOAT_VEC3 = 0x8B51,

		/// <summary>
		/// Equivalent to GLSL keyword <c>vec4</c>.
		/// </summary>
		FLOAT_VEC4 = 0x8B52,

		/// <summary>
		/// Equivalent to GLSL keyword <c>double</c>.
		/// </summary>
		DOUBLE = 0x140A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dvec2</c>.
		/// </summary>
		DOUBLE_VEC2 = 0x8FFC,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dvec3</c>.
		/// </summary>
		DOUBLE_VEC3 = 0x8FFD,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dvec4</c>.
		/// </summary>
		DOUBLE_VEC4 = 0x8FFE,

		/// <summary>
		/// Equivalent to GLSL keyword <c>int</c>.
		/// </summary>
		INT = 0x1404,

		/// <summary>
		/// Equivalent to GLSL keyword <c>ivec2</c>.
		/// </summary>
		INT_VEC2 = 0x8B53,

		/// <summary>
		/// Equivalent to GLSL keyword <c>ivec3</c>.
		/// </summary>
		INT_VEC3 = 0x8B54,

		/// <summary>
		/// Equivalent to GLSL keyword <c>ivec4</c>.
		/// </summary>
		INT_VEC4 = 0x8B55,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uint</c>.
		/// </summary>
		UNSIGNED_INT = 0x1405,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uvec2</c>.
		/// </summary>
		UNSIGNED_INT_VEC2 = 0x8DC6,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uvec3</c>.
		/// </summary>
		UNSIGNED_INT_VEC3 = 0x8DC7,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uvec4</c>.
		/// </summary>
		UNSIGNED_INT_VEC4 = 0x8DC8,

		/// <summary>
		/// Equivalent to GLSL keyword <c>bool</c>.
		/// </summary>
		BOOL = 0x8B56,

		/// <summary>
		/// Equivalent to GLSL keyword <c>bvec2</c>.
		/// </summary>
		BOOL_VEC2 = 0x8B57,

		/// <summary>
		/// Equivalent to GLSL keyword <c>bvec3</c>.
		/// </summary>
		BOOL_VEC3 = 0x8B58,

		/// <summary>
		/// Equivalent to GLSL keyword <c>bvec4</c>.
		/// </summary>
		BOOL_VEC4 = 0x8B59,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat2</c>.
		/// </summary>
		FLOAT_MAT2 = 0x8B5A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat3</c>.
		/// </summary>
		FLOAT_MAT3 = 0x8B5B,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat4</c>.
		/// </summary>
		FLOAT_MAT4 = 0x8B5C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat2x3</c>.
		/// </summary>
		FLOAT_MAT2x3 = 0x8B65,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat2x4</c>.
		/// </summary>
		FLOAT_MAT2x4 = 0x8B66,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat3x2</c>.
		/// </summary>
		FLOAT_MAT3x2 = 0x8B67,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat3x4</c>.
		/// </summary>
		FLOAT_MAT3x4 = 0x8B68,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat4x2</c>.
		/// </summary>
		FLOAT_MAT4x2 = 0x8B69,

		/// <summary>
		/// Equivalent to GLSL keyword <c>mat4x3</c>.
		/// </summary>
		FLOAT_MAT4x3 = 0x8B6A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat2</c>.
		/// </summary>
		DOUBLE_MAT2 = 0x8F46,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat3</c>.
		/// </summary>
		DOUBLE_MAT3 = 0x8F47,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat4</c>.
		/// </summary>
		DOUBLE_MAT4 = 0x8F48,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat2x3</c>.
		/// </summary>
		DOUBLE_MAT2x3 = 0x8F49,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat2x4</c>.
		/// </summary>
		DOUBLE_MAT2x4 = 0x8F4A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat3x2</c>.
		/// </summary>
		DOUBLE_MAT3x2 = 0x8F4B,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat3x4</c>.
		/// </summary>
		DOUBLE_MAT3x4 = 0x8F4C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat4x2</c>.
		/// </summary>
		DOUBLE_MAT4x2 = 0x8F4D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>dmat4x3</c>.
		/// </summary>
		DOUBLE_MAT4x3 = 0x8F4E,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler1D</c>.
		/// </summary>
		SAMPLER_1D = 0x8B5D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2D</c>.
		/// </summary>
		SAMPLER_2D = 0x8B5E,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler3D</c>.
		/// </summary>
		SAMPLER_3D = 0x8B5F,

		/// <summary>
		/// Equivalent to GLSL keyword <c>samplerCube</c>.
		/// </summary>
		SAMPLER_CUBE = 0x8B60,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler1DShadow</c>.
		/// </summary>
		SAMPLER_1D_SHADOW = 0x8B61,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DShadow</c>.
		/// </summary>
		SAMPLER_2D_SHADOW = 0x8B62,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler1DArray</c>.
		/// </summary>
		SAMPLER_1D_ARRAY = 0x8DC0,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DArray</c>.
		/// </summary>
		SAMPLER_2D_ARRAY = 0x8DC1,

		/// <summary>
		/// Equivalent to GLSL keyword <c>samplerCubeArray</c>.
		/// </summary>
		SAMPLER_CUBE_MAP_ARRAY = 0x900C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler1DShadowArray</c>.
		/// </summary>
		SAMPLER_1D_ARRAY_SHADOW = 0x8DC3,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DShadowArray</c>.
		/// </summary>
		SAMPLER_2D_ARRAY_SHADOW = 0x8DC4,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DMS</c>.
		/// </summary>
		SAMPLER_2D_MULTISAMPLE = 0x9108,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DMSArray</c>.
		/// </summary>
		SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910B,

		/// <summary>
		/// Equivalent to GLSL keyword <c>samplerCubeShadow</c>.
		/// </summary>
		SAMPLER_CUBE_SHADOW = 0x8DC5,

		/// <summary>
		/// Equivalent to GLSL keyword <c>samplerCubeArrayShadow</c>.
		/// </summary>
		SAMPLER_CUBE_MAP_ARRAY_SHADOW = 0x900D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>samplerBuffer</c>.
		/// </summary>
		SAMPLER_BUFFER = 0x8DC2,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DRect</c>.
		/// </summary>
		SAMPLER_2D_RECT = 0x8B63,

		/// <summary>
		/// Equivalent to GLSL keyword <c>sampler2DRectShadow</c>.
		/// </summary>
		SAMPLER_2D_RECT_SHADOW = 0x8B64,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler1D</c>.
		/// </summary>
		INT_SAMPLER_1D = 0x8DC9,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler2D</c>.
		/// </summary>
		INT_SAMPLER_2D = 0x8DCA,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler3D</c>.
		/// </summary>
		INT_SAMPLER_3D = 0x8DCB,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isamplerCube</c>.
		/// </summary>
		INT_SAMPLER_CUBE = 0x8DCC,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler1DArray</c>.
		/// </summary>
		INT_SAMPLER_1D_ARRAY = 0x8DCE,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler2DArray</c>.
		/// </summary>
		INT_SAMPLER_2D_ARRAY = 0x8DCF,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isamplerCubeArray</c>.
		/// </summary>
		INT_SAMPLER_CUBE_MAP_ARRAY = 0x900E,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler2DMS</c>.
		/// </summary>
		INT_SAMPLER_2D_MULTISAMPLE = 0x9109,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler2DMSArray</c>.
		/// </summary>
		INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isamplerBuffer</c>.
		/// </summary>
		INT_SAMPLER_BUFFER = 0x8DD0,

		/// <summary>
		/// Equivalent to GLSL keyword <c>isampler2DRect</c>.
		/// </summary>
		INT_SAMPLER_2D_RECT = 0x8DCD,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler1D</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_1D = 0x8DD1,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler2D</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_2D = 0x8DD2,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler3D</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_3D = 0x8DD3,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usamplerCube</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_CUBE = 0x8DD4,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler1DArray</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_1D_ARRAY = 0x8DD6,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler2DArray</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_2D_ARRAY = 0x8DD7,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usamplerCubeArray</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_CUBE_MAP_ARRAY = 0x900F,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler2DMS</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE = 0x910A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler2DMSArray</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_2D_MULTISAMPLE_ARRAY = 0x910D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usamplerBuffer</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_BUFFER = 0x8DD8,

		/// <summary>
		/// Equivalent to GLSL keyword <c>usampler2DRect</c>.
		/// </summary>
		UNSIGNED_INT_SAMPLER_2D_RECT = 0x8DD5,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image1D</c>.
		/// </summary>
		IMAGE_1D = 0x904C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image2D</c>.
		/// </summary>
		IMAGE_2D = 0x904D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image3D</c>.
		/// </summary>
		IMAGE_3D = 0x904E,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image2DRect</c>.
		/// </summary>
		IMAGE_2D_RECT = 0x904F,

		/// <summary>
		/// Equivalent to GLSL keyword <c>imageCube</c>.
		/// </summary>
		IMAGE_CUBE = 0x9050,

		/// <summary>
		/// Equivalent to GLSL keyword <c>imageBuffer</c>.
		/// </summary>
		IMAGE_BUFFER = 0x9051,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image1DArray</c>.
		/// </summary>
		IMAGE_1D_ARRAY = 0x9052,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image2DArray</c>.
		/// </summary>
		IMAGE_2D_ARRAY = 0x9053,

		/// <summary>
		/// Equivalent to GLSL keyword <c>imageCubeArray</c>.
		/// </summary>
		IMAGE_CUBE_MAP_ARRAY = 0x9054,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image2DMS</c>.
		/// </summary>
		IMAGE_2D_MULTISAMPLE = 0x9055,

		/// <summary>
		/// Equivalent to GLSL keyword <c>image2DMSArray</c>.
		/// </summary>
		IMAGE_2D_MULTISAMPLE_ARRAY = 0x9056,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage1D</c>.
		/// </summary>
		INT_IMAGE_1D = 0x9057,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage2D</c>.
		/// </summary>
		INT_IMAGE_2D = 0x9058,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage3D</c>.
		/// </summary>
		INT_IMAGE_3D = 0x9059,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage2DRect</c>.
		/// </summary>
		INT_IMAGE_2D_RECT = 0x905A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimageCube</c>.
		/// </summary>
		INT_IMAGE_CUBE = 0x905B,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimageBuffer</c>.
		/// </summary>
		INT_IMAGE_BUFFER = 0x905C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage1DArray</c>.
		/// </summary>
		INT_IMAGE_1D_ARRAY = 0x905D,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage2DArray</c>.
		/// </summary>
		INT_IMAGE_2D_ARRAY = 0x905E,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimageCubeArray</c>.
		/// </summary>
		INT_IMAGE_CUBE_MAP_ARRAY = 0x905F,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage2DMS</c>.
		/// </summary>
		INT_IMAGE_2D_MULTISAMPLE = 0x9060,

		/// <summary>
		/// Equivalent to GLSL keyword <c>iimage2DMSArray</c>.
		/// </summary>
		INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x9061,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage1D</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_1D = 0x9062,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage2D</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_2D = 0x9063,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage3D</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_3D = 0x9064,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage2DRect</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_2D_RECT = 0x9065,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimageCube</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_CUBE = 0x9066,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimageBuffer</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_BUFFER = 0x9067,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage1DArray</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_1D_ARRAY = 0x9068,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage2DArray</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_2D_ARRAY = 0x9069,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimageCubeArray</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_CUBE_MAP_ARRAY = 0x906A,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage2DMS</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_2D_MULTISAMPLE = 0x906B,

		/// <summary>
		/// Equivalent to GLSL keyword <c>uimage2DMSArray</c>.
		/// </summary>
		UNSIGNED_INT_IMAGE_2D_MULTISAMPLE_ARRAY = 0x906C,

		/// <summary>
		/// Equivalent to GLSL keyword <c>atomic_uint</c>.
		/// </summary>
		UNSIGNED_INT_ATOMIC_COUNTER = 0x92DB,

		///// <summary>
		///// Equivalent to GLSL keyword <c>int64_t</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//INT64_ARB = 0x140E,

		///// <summary>
		///// Equivalent to GLSL keyword <c>i64vec2</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//INT64_VEC2_ARB = 0x8FE9,

		///// <summary>
		///// Equivalent to GLSL keyword <c>i64vec3</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//INT64_VEC3_ARB = 0x8FEA,

		///// <summary>
		///// Equivalent to GLSL keyword <c>i64vec4</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//INT64_VEC4_ARB = 0x8FEB,

		///// <summary>
		///// Equivalent to GLSL keyword <c>uint64_t</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//UNSIGNED_INT64_ARB = 0x140F,

		///// <summary>
		///// Equivalent to GLSL keyword <c>u64vec2</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//UNSIGNED_INT64_VEC2_ARB = 0x8FF5,

		///// <summary>
		///// Equivalent to GLSL keyword <c>u64vec3</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//UNSIGNED_INT64_VEC3_ARB = 0x8FF6,

		///// <summary>
		///// Equivalent to GLSL keyword <c>u64vec4</c>.
		///// </summary>
		//[Obsolete("OpenGL extension: GL_ARB_gpu_shader_int64")]
		//UNSIGNED_INT64_VEC4_ARB = 0x8FF7,
	}
}
