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
	/// Value for <see cref="gl.GetIntegeri_v"/>.
	/// </summary>
	public enum glGetIntegerIndexedParameter : uint
	{
		/// <summary>
		/// Buffer objects bound to each (indexed) atomic counter buffer.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_BINDING=0x92C1,

		/// <summary>
		/// Blend equation mode for alpha for each (indexed) drawbuffer. Returns <see cref="glBlendEquationMode"/>.
		/// </summary>
		BLEND_EQUATION_ALPHA=0x883D,

		/// <summary>
		/// Blend equation mode for color for each (indexed) drawbuffer. Returns <see cref="glBlendEquationMode"/>.
		/// </summary>
		BLEND_EQUATION_RGB=0x8009,

		/// <summary>
		/// Blend function factor for destination alpha for each (indexed) drawbuffer. Returns <see cref="glBlendFuncFactor"/>.
		/// </summary>
		BLEND_DST_ALPHA=0x80CA,

		/// <summary>
		/// Blend function factor for destination color for each (indexed) drawbuffer. Returns <see cref="glBlendFuncFactor"/>.
		/// </summary>
		BLEND_DST_RGB=0x80C8,

		/// <summary>
		/// Blend function factor for source alpha for each (indexed) drawbuffer. Returns <see cref="glBlendFuncFactor"/>.
		/// </summary>
		BLEND_SRC_ALPHA=0x80CB,

		/// <summary>
		/// Blend function factor for source color for each (indexed) drawbuffer. Returns <see cref="glBlendFuncFactor"/>.
		/// </summary>
		BLEND_SRC_RGB=0x80C9,

		/// <summary>
		/// Read and/or write access for bound texture. Returns <see cref="glAccess"/>.
		/// </summary>
		IMAGE_BINDING_ACCESS=0x8F3E,

		/// <summary>
		/// Format used for accesses to bound texture. Returns <see cref="glInternalFormat"/>.
		/// </summary>
		IMAGE_BINDING_FORMAT=0x906E,

		/// <summary>
		/// Layer of bound texture, if not layered.
		/// </summary>
		IMAGE_BINDING_LAYER=0x8F3D,

		/// <summary>
		/// Level of bound texture object.
		/// </summary>
		IMAGE_BINDING_LEVEL=0x8F3B,

		/// <summary>
		/// Name of bound texture object.
		/// </summary>
		IMAGE_BINDING_NAME=0x8F3A,

		/// <summary>
		/// Maximum number of work groups that may be dispatched by a single dispatch command (indexed per dimension).
		/// </summary>
		MAX_COMPUTE_WORK_GROUP_COUNT=0x91BE,

		/// <summary>
		/// Maximum local size of a compute (indexed per dimension).
		/// </summary>
		MAX_COMPUTE_WORK_GROUP_SIZE=0x91BF,

		/// <summary>
		/// Scissor box (indexed per viewport). Array of four <b>integer</b>s.
		/// </summary>
		SCISSOR_BOX=0x0C10,

		/// <summary>
		/// Sample mask words.
		/// </summary>
		SAMPLE_MASK_VALUE=0x8E52,

		/// <summary>
		/// Sampler object bound to texture unit.
		/// </summary>
		SAMPLER_BINDING=0x8919,

		/// <summary>
		/// Buffer objects bound to each (indexed) shader storage buffer.
		/// </summary>
		SHADER_STORAGE_BUFFER_BINDING=0x90D3,

		/// <summary>
		/// Texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING=0x82EB,

		/// <summary>
		/// 1D texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_1D=0x8068,

		/// <summary>
		/// 1D texture array object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_1D_ARRAY=0x8C1C,

		/// <summary>
		/// 2D texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_2D=0x8069,

		/// <summary>
		/// 2D texture array object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_2D_ARRAY=0x8C1D,

		/// <summary>
		/// 2D multisample texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_2D_MULTISAMPLE=0x9104,

		/// <summary>
		/// 2D multisample texture array object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY=0x9105,

		/// <summary>
		/// 3D texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_3D=0x806A,

		/// <summary>
		/// Texture buffer object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_BUFFER=0x8C2C,

		/// <summary>
		/// Cube map texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_CUBE_MAP=0x8514,

		/// <summary>
		/// Cube map texture array object. bound to the texture unit
		/// </summary>
		TEXTURE_BINDING_CUBE_MAP_ARRAY=0x900A,

		/// <summary>
		/// Rectangle texture object bound to the texture unit.
		/// </summary>
		TEXTURE_BINDING_RECTANGLE=0x84F6,

		/// <summary>
		/// Buffer objects bound to each (indexed) transform feedback buffer.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_BINDING=0x8C8F,

		/// <summary>
		/// Buffer objects bound to each (indexed) uniform buffer bindings.
		/// </summary>
		UNIFORM_BUFFER_BINDING=0x8A28,

		/// <summary>
		/// Name of buffer for each (indexed) vertex binding.
		/// </summary>
		VERTEX_BINDING_BUFFER=0x8F4F,

		/// <summary>
		/// Instance divisor for each (indexed) vertex binding.
		/// </summary>
		VERTEX_BINDING_DIVISOR=0x82D6,

		/// <summary>
		/// Stride between elements for each (indexed) vertex binding.
		/// </summary>
		VERTEX_BINDING_STRIDE=0x82D8,
	}
}
