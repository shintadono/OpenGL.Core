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
	/// Value for <see cref="O:OpenGL.Core.gl.GetIntegerv">gl.GetIntegerv</see>.
	/// </summary>
	public enum glGetIntegerParameter : uint
	{
		/// <summary>
		/// Active texture unit. Returns <see cref="glTextureUnit"/>.
		/// </summary>
		ACTIVE_TEXTURE = 0x84E0,

		/// <summary>
		/// Element array buffer binding.
		/// </summary>
		ARRAY_BUFFER_BINDING = 0x8894,

		/// <summary>
		/// Number of atomic counter bindings.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_BINDING = 0x92C1,

		/// <summary>
		/// Buffer object storage flags. Returns <see cref="glBufferStorageFlag"/>.
		/// </summary>
		BUFFER_STORAGE_FLAGS = 0x8220,

		/// <summary>
		/// Color clamping mode. Returns <see cref="glClampColorMode"/>.
		/// </summary>
		CLAMP_READ_COLOR = 0x891C,

		/// <summary>
		/// Clip origin. Returns <see cref="glOrientationOrigin"/>.
		/// </summary>
		CLIP_ORIGIN = 0x935C,

		/// <summary>
		/// Clip depth mode. Returns <see cref="glClipDepthMode"/>.
		/// </summary>
		CLIP_DEPTH_MODE = 0x935D,

		/// <summary>
		/// List of compressed texture formats. Returns <see cref="glInternalFormat"/>[<see cref="gl.GetInteger">gl.GetIntegerv</see>(<see cref="glGetIntegerParameter.NUM_COMPRESSED_TEXTURE_FORMATS"/>)]
		/// </summary>
		[Obsolete("Deprecated since 4.2")]
		COMPRESSED_TEXTURE_FORMATS = 0x86A3,

		/// <summary>
		/// Current context flags. Returns <see cref="glContextFlag"/>.
		/// </summary>
		CONTEXT_FLAGS = 0x821E,

		/// <summary>
		/// Current context profile flags. Returns <see cref="glContextProfileMask"/>.
		/// </summary>
		CONTEXT_PROFILE_MASK = 0x9126,

		/// <summary>
		/// The behavior of the context when it is made no longer current (released) by the platform. Returns <see cref="glContextReleaseBehavior"/>.
		/// </summary>
		CONTEXT_RELEASE_BEHAVIOR = 0x82FB,

		/// <summary>
		/// Returns <see cref="gl.TRUE"/> if context supports robust access.
		/// </summary>
		[Obsolete("Use gl.GetIntegerv with glGetIntegerParameter.CONTEXT_FLAGS and check the glContextFlag.CONTEXT_FLAG_ROBUST_ACCESS_BIT instead.")]
		CONTEXT_ROBUST_ACCESS = 0x90F3,

		/// <summary>
		/// Read buffer binding for copy operations.
		/// </summary>
		COPY_READ_BUFFER_BINDING = 0x8F36,

		/// <summary>
		/// Write buffer binding for copy operations.
		/// </summary>
		COPY_WRITE_BUFFER_BINDING = 0x8F37,

		/// <summary>
		/// Current face culling mode. Returns <see cref="glFace"/>
		/// </summary>
		CULL_FACE_MODE = 0x0B45,

		/// <summary>
		/// Current program.
		/// </summary>
		CURRENT_PROGRAM = 0x8B8D,

		/// <summary>
		/// Current debug group stack depth.
		/// </summary>
		DEBUG_GROUP_STACK_DEPTH = 0x826D,

		/// <summary>
		/// Number of currently logged debug messages.
		/// </summary>
		DEBUG_LOGGED_MESSAGES = 0x9145,

		/// <summary>
		/// Length of the next debug message.
		/// </summary>
		DEBUG_NEXT_LOGGED_MESSAGE_LENGTH = 0x8243,

		/// <summary>
		/// Current depth function. Returns <see cref="glFunc"/>.
		/// </summary>
		DEPTH_FUNC = 0x0B74,

		/// <summary>
		/// Indirect dispatch buffer binding.
		/// </summary>
		DISPATCH_INDIRECT_BUFFER_BINDING = 0x90EF,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. DRAW_BUFFER is equivalent to <see cref="glGetIntegerParameter.DRAW_BUFFER0"/>.
		/// Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER = 0x0C01,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER0 = 0x8825,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER1 = 0x8826,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER2 = 0x8827,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER3 = 0x8828,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER4 = 0x8829,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER5 = 0x882A,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER6 = 0x882B,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER7 = 0x882C,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER8 = 0x882D,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER9 = 0x882E,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER10 = 0x882F,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER11 = 0x8830,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER12 = 0x8831,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER13 = 0x8832,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER14 = 0x8833,

		/// <summary>
		/// Draw buffer of the currently bound draw framebuffer. Returns <see cref="glBuffer"/>.
		/// </summary>
		DRAW_BUFFER15 = 0x8834,

		/// <summary>
		/// Framebuffer object bound to <see cref="glFramebufferTarget.DRAW_FRAMEBUFFER"/>.
		/// </summary>
		DRAW_FRAMEBUFFER_BINDING = 0x8CA6,

		/// <summary>
		/// Indirect command buffer binding.
		/// </summary>
		DRAW_INDIRECT_BUFFER_BINDING = 0x8F43,

		/// <summary>
		/// Element array buffer binding.
		/// </summary>
		ELEMENT_ARRAY_BUFFER_BINDING = 0x8895,

		/// <summary>
		/// Subpixel bits for <c>interpolateAtOffset</c>.
		/// </summary>
		FRAGMENT_INTERPOLATION_OFFSET_BITS = 0x8E5D,

		/// <summary>
		/// Derivative accuracy for fragment processing built-in functions <c>dFdx</c>, <c>dFdy</c> and <c>fwidth</c>.
		/// Returns <see cref="glHintMode"/>.
		/// </summary>
		FRAGMENT_SHADER_DERIVATIVE_HINT = 0x8B8B,

		/// <summary>
		/// Framebuffer object bound to <see cref="glFramebufferTarget.DRAW_FRAMEBUFFER"/>.
		/// FRAMEBUFFER_BINDING is equivalent to <see cref="glGetIntegerParameter.DRAW_FRAMEBUFFER_BINDING"/>.
		/// </summary>
		[Obsolete("Use DRAW_FRAMEBUFFER_BINDING.")]
		FRAMEBUFFER_BINDING = DRAW_FRAMEBUFFER_BINDING,

		/// <summary>
		/// Vertex order to define the front face of a polygon. Returns <see cref="glFrontFaceDirection"/>.
		/// </summary>
		FRONT_FACE = 0x0B46,

		/// <summary>
		/// Implementation preferred pixel format. Returns <see cref="glImplementationColorReadFormat"/>.
		/// </summary>
		IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B,

		/// <summary>
		/// Implementation preferred pixel data type. Returns <see cref="glImplementationColorReadType"/>.
		/// </summary>
		IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,

		/// <summary>
		/// Vertex convention followed by <c>gl_Layer</c>. Returns <see cref="glProvokingVertexMode"/>.
		/// </summary>
		LAYER_PROVOKING_VERTEX = 0x825E,

		/// <summary>
		/// Line sampling quality. Returns <see cref="glHintMode"/>.
		/// </summary>
		LINE_SMOOTH_HINT = 0x0C52,

		/// <summary>
		/// Current logic operation function. Returns <see cref="glLogicOpMode"/>.
		/// </summary>
		LOGIC_OP_MODE = 0x0BF0,

		/// <summary>
		/// Major OpenGL version number.
		/// </summary>
		MAJOR_VERSION = 0x821B,

		/// <summary>
		/// Maximum 3D texture images dimension.
		/// </summary>
		MAX_3D_TEXTURE_SIZE = 0x8073,

		/// <summary>
		/// Maximum number of layers for texture arrays.
		/// </summary>
		MAX_ARRAY_TEXTURE_LAYERS = 0x88FF,

		/// <summary>
		/// Maximum number of atomic counter buffer bindings.
		/// </summary>
		MAX_ATOMIC_COUNTER_BUFFER_BINDINGS = 0x92DC,

		/// <summary>
		/// Maximum size of atomic counter buffers.
		/// </summary>
		MAX_ATOMIC_COUNTER_BUFFER_SIZE = 0x92D8,

		/// <summary>
		/// Maximum number of user defined culling planes.
		/// </summary>
		MAX_CULL_DISTANCES = 0x82F9,

		/// <summary>
		/// Maximum number of user defined clip planes.
		/// </summary>
		MAX_CLIP_DISTANCES = 0x0D32,

		/// <summary>
		/// Maximum number of framebuffer object attachment points for color buffers.
		/// </summary>
		MAX_COLOR_ATTACHMENTS = 0x8CDF,

		/// <summary>
		/// Maximum number of samples supported for all color formats in a multisample texture.
		/// </summary>
		MAX_COLOR_TEXTURE_SAMPLES = 0x910E,

		/// <summary>
		/// Maximum number of atomic counter buffers per program.
		/// </summary>
		MAX_COMBINED_ATOMIC_COUNTER_BUFFERS = 0x92D1,

		/// <summary>
		/// Maximum number of atomic counter uniforms per program.
		/// </summary>
		MAX_COMBINED_ATOMIC_COUNTERS = 0x92D7,

		/// <summary>
		/// Maximum combined number of user defined clipping and calling planes.
		/// </summary>
		MAX_COMBINED_CLIP_AND_CULL_DISTANCES = 0x82FA,

		/// <summary>
		/// Maximum number of words for compute shader uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_COMPUTE_UNIFORM_COMPONENTS = 0x8266,

		/// <summary>
		/// Maximum number of words for fragment shader uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_FRAGMENT_UNIFORM_COMPONENTS = 0x8A33,

		/// <summary>
		/// Maximum number of words for geometry shader uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_GEOMETRY_UNIFORM_COMPONENTS = 0x8A32,

		/// <summary>
		/// Maximum number of image variables in all shaders.
		/// </summary>
		MAX_COMBINED_IMAGE_UNIFORMS = 0x90CF,

		/// <summary>
		/// Limit on active image units plus shader storages block plus fragment outputs.
		/// </summary>
		MAX_COMBINED_SHADER_OUTPUT_RESOURCES = 0x8F39,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a program.
		/// </summary>
		MAX_COMBINED_SHADER_STORAGE_BLOCKS = 0x90DC,

		/// <summary>
		/// Maximum number of words for TCS uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E1E,

		/// <summary>
		/// Maximum number of words for TES uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E1F,

		/// <summary>
		/// Total number of texture units accessible by OpenGL.
		/// </summary>
		MAX_COMBINED_TEXTURE_IMAGE_UNITS = 0x8B4D,

		/// <summary>
		/// Maximum number of uniform buffers per program.
		/// </summary>
		MAX_COMBINED_UNIFORM_BLOCKS = 0x8A2E,

		/// <summary>
		/// Maximum number of words for vertex shader uniform variables in all uniform blocks (including default).
		/// </summary>
		MAX_COMBINED_VERTEX_UNIFORM_COMPONENTS = 0x8A31,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a compute shader.
		/// </summary>
		MAX_COMPUTE_ATOMIC_COUNTER_BUFFERS = 0x8264,

		/// <summary>
		/// Maximum number of atomic counters accessed by a compute shader.
		/// </summary>
		MAX_COMPUTE_ATOMIC_COUNTERS = 0x8265,

		/// <summary>
		/// Maximum number of image variables in compute shaders.
		/// </summary>
		MAX_COMPUTE_IMAGE_UNIFORMS = 0x91BD,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a compute shader.
		/// </summary>
		MAX_COMPUTE_SHADER_STORAGE_BLOCKS = 0x90DB,

		/// <summary>
		/// Maximum total storage size of all variables declared as shared in all compute shaders linked into a single program object.
		/// </summary>
		MAX_COMPUTE_SHARED_MEMORY_SIZE = 0x8262,

		/// <summary>
		/// Maximum number of texture image units accessible by a compute shader.
		/// </summary>
		MAX_COMPUTE_TEXTURE_IMAGE_UNITS = 0x91BC,

		/// <summary>
		/// Maximum number of uniform blocks per compute program.
		/// </summary>
		MAX_COMPUTE_UNIFORM_BLOCKS = 0x91BB,

		/// <summary>
		/// Maximum number of components for compute shader uniform variables.
		/// </summary>
		MAX_COMPUTE_UNIFORM_COMPONENTS = 0x8263,

		/// <summary>
		/// Maximum total compute shader invocations in a single local work group.
		/// </summary>
		MAX_COMPUTE_WORK_GROUP_INVOCATIONS = 0x90EB,

		/// <summary>
		/// Maximum cube map texture image dimension.
		/// </summary>
		MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C,

		/// <summary>
		/// Maximum debug group stack depth.
		/// </summary>
		MAX_DEBUG_GROUP_STACK_DEPTH = 0x826C,

		/// <summary>
		/// Maximum number of logged debug messages.
		/// </summary>
		MAX_DEBUG_LOGGED_MESSAGES = 0x9144,

		/// <summary>
		/// Maximum length of the debug messages.
		/// </summary>
		MAX_DEBUG_MESSAGE_LENGTH = 0x9143,

		/// <summary>
		/// Maximum number of samples supported for all depth/stencil formats in a multisample texture.
		/// </summary>
		MAX_DEPTH_TEXTURE_SAMPLES = 0x910F,

		/// <summary>
		/// Maximum number of active draw buffers.
		/// </summary>
		MAX_DRAW_BUFFERS = 0x8824,

		/// <summary>
		/// Maximum number of active draw buffers when using dual source blending.
		/// </summary>
		MAX_DUAL_SOURCE_DRAW_BUFFERS = 0x88FC,

		/// <summary>
		/// Recommended maximum number of <see cref="O:OpenGL.Core.gl.DrawRangeElements">gl.DrawRangeElements</see> indices.
		/// </summary>
		MAX_ELEMENTS_INDICES = 0x80E9,

		/// <summary>
		/// Recommended maximum number of <see cref="O:OpenGL.Core.gl.DrawRangeElements">gl.DrawRangeElements</see> vertices.
		/// </summary>
		MAX_ELEMENTS_VERTICES = 0x80E8,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a fragment shader.
		/// </summary>
		MAX_FRAGMENT_ATOMIC_COUNTER_BUFFERS = 0x92D0,

		/// <summary>
		/// Maximum number of atomic counters accessed by a fragment shader.
		/// </summary>
		MAX_FRAGMENT_ATOMIC_COUNTERS = 0x92D6,

		/// <summary>
		/// Maximum number of image variables in fragment shaders.
		/// </summary>
		MAX_FRAGMENT_IMAGE_UNIFORMS = 0x90CE,

		/// <summary>
		/// Maximum number of components of inputs read by a fragment shader.
		/// </summary>
		MAX_FRAGMENT_INPUT_COMPONENTS = 0x9125,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a fragment shader.
		/// </summary>
		MAX_FRAGMENT_SHADER_STORAGE_BLOCKS = 0x90DA,

		/// <summary>
		/// Maximum number of fragment shader uniform buffers per program.
		/// </summary>
		MAX_FRAGMENT_UNIFORM_BLOCKS = 0x8A2D,

		/// <summary>
		/// Maximum number of components for fragment shader uniform variables.
		/// </summary>
		MAX_FRAGMENT_UNIFORM_COMPONENTS = 0x8B49,

		/// <summary>
		/// Maximum number of vectors for fragment shader uniform variables.
		/// </summary>
		MAX_FRAGMENT_UNIFORM_VECTORS = 0x8DFD,

		/// <summary>
		/// Maximum height for framebuffer object.
		/// </summary>
		MAX_FRAMEBUFFER_HEIGHT = 0x9316,

		/// <summary>
		/// Maximum layer count for framebuffer object.
		/// </summary>
		MAX_FRAMEBUFFER_LAYERS = 0x9317,

		/// <summary>
		/// Maximum sample count for framebuffer object.
		/// </summary>
		MAX_FRAMEBUFFER_SAMPLES = 0x9318,

		/// <summary>
		/// Maximum width for framebuffer object.
		/// </summary>
		MAX_FRAMEBUFFER_WIDTH = 0x9315,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_ATOMIC_COUNTER_BUFFERS = 0x92CF,

		/// <summary>
		/// Maximum number of atomic counters accessed by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_ATOMIC_COUNTERS = 0x92D5,

		/// <summary>
		/// Maximum number of image variables in geometry shaders.
		/// </summary>
		MAX_GEOMETRY_IMAGE_UNIFORMS = 0x90CD,

		/// <summary>
		/// Maximum number of components of inputs read by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_INPUT_COMPONENTS = 0x9123,

		/// <summary>
		/// Maximum number of components of outputs written by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_OUTPUT_COMPONENTS = 0x9124,

		/// <summary>
		/// Maximum number of vertices that any that a geometry shader can emit.
		/// </summary>
		MAX_GEOMETRY_OUTPUT_VERTICES = 0x8DE0,

		/// <summary>
		/// Maximum number of supported geometry shader invocations.
		/// </summary>
		MAX_GEOMETRY_SHADER_INVOCATIONS = 0x8E5A,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_SHADER_STORAGE_BLOCKS = 0x90D7,

		/// <summary>
		/// Maximum number of texture image units accessible by a geometry shader.
		/// </summary>
		MAX_GEOMETRY_TEXTURE_IMAGE_UNITS = 0x8C29,

		/// <summary>
		/// Maximum number of total components (all vertices) of active outputs that a geometry shader can emit.
		/// </summary>
		MAX_GEOMETRY_TOTAL_OUTPUT_COMPONENTS = 0x8DE1,

		/// <summary>
		/// Maximum number of geometry shader uniform buffers per program.
		/// </summary>
		MAX_GEOMETRY_UNIFORM_BLOCKS = 0x8A2C,

		/// <summary>
		/// Maximum number of components for geometry shader uniform variables.
		/// </summary>
		MAX_GEOMETRY_UNIFORM_COMPONENTS = 0x8DDF,

		/// <summary>
		/// Maximum allowed samples for a texture level bound to an image unit.
		/// </summary>
		MAX_IMAGE_SAMPLES = 0x906D,

		/// <summary>
		/// Maximum number of units for image load, store and atomic operations.
		/// </summary>
		MAX_IMAGE_UNITS = 0x8F38,

		/// <summary>
		/// Maximum number of samples supported for all integer format multisample buffers.
		/// </summary>
		MAX_INTEGER_SAMPLES = 0x9110,

		/// <summary>
		/// Maximum length of a label string.
		/// </summary>
		MAX_LABEL_LENGTH = 0x82E8,

		/// <summary>
		/// Maximum patch size.
		/// </summary>
		MAX_PATCH_VERTICES = 0x8E7D,

		/// <summary>
		/// Maximum texel offset allowed in lookup.
		/// </summary>
		MAX_PROGRAM_TEXEL_OFFSET = 0x8905,

		/// <summary>
		/// Maximum texel offset for <c>textureGatherOffsets</c>.
		/// </summary>
		MAX_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5F,

		/// <summary>
		/// Maximum dimension of rectangle textures.
		/// </summary>
		MAX_RECTANGLE_TEXTURE_SIZE = 0x84F8,

		/// <summary>
		/// Maximum dimension of renderbuffers.
		/// </summary>
		MAX_RENDERBUFFER_SIZE = 0x84E8,

		/// <summary>
		/// Maximum number of sample mask words.
		/// </summary>
		MAX_SAMPLE_MASK_WORDS = 0x8E59,

		/// <summary>
		/// Maximum number of samples supported for multisampling.
		/// </summary>
		MAX_SAMPLES = 0x8D57,

		/// <summary>
		/// Maximum number of shader storage buffer bindings in the context.
		/// </summary>
		MAX_SHADER_STORAGE_BUFFER_BINDINGS = 0x90DD,

		/// <summary>
		/// Maximum number of subroutine uniform locations per stage.
		/// </summary>
		MAX_SUBROUTINE_UNIFORM_LOCATIONS = 0x8DE8,

		/// <summary>
		/// Maximum number of subroutines per shader stage.
		/// </summary>
		MAX_SUBROUTINES = 0x8DE7,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_ATOMIC_COUNTER_BUFFERS = 0x92CD,

		/// <summary>
		/// Maximum number of atomic counters accessed by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_ATOMIC_COUNTERS = 0x92D3,

		/// <summary>
		/// Maximum number of image variables in tesselation control shaders.
		/// </summary>
		MAX_TESS_CONTROL_IMAGE_UNIFORMS = 0x90CB,

		/// <summary>
		/// Maximum number of components of inputs read by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_INPUT_COMPONENTS = 0x886C,

		/// <summary>
		/// Maximum number of components of outputs written by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_OUTPUT_COMPONENTS = 0x8E83,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_SHADER_STORAGE_BLOCKS = 0x90D8,

		/// <summary>
		/// Maximum number of texture image units accessible by a tesselation control shader.
		/// </summary>
		MAX_TESS_CONTROL_TEXTURE_IMAGE_UNITS = 0x8E81,

		/// <summary>
		/// Total number of components for tesselation control shader outputs.
		/// </summary>
		MAX_TESS_CONTROL_TOTAL_OUTPUT_COMPONENTS = 0x8E85,

		/// <summary>
		/// Maximum number of tesselation control shader uniform buffers per program.
		/// </summary>
		MAX_TESS_CONTROL_UNIFORM_BLOCKS = 0x8E89,

		/// <summary>
		/// Maximum number of words for tesselation control shader uniforms.
		/// </summary>
		MAX_TESS_CONTROL_UNIFORM_COMPONENTS = 0x8E7F,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_ATOMIC_COUNTER_BUFFERS = 0x92CE,

		/// <summary>
		/// Maximum number of atomic counters accessed by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_ATOMIC_COUNTERS = 0x92D4,

		/// <summary>
		/// Maximum number of image variables in tesselation evaluation shaders.
		/// </summary>
		MAX_TESS_EVALUATION_IMAGE_UNIFORMS = 0x90CC,

		/// <summary>
		/// Maximum number of components of inputs read by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_INPUT_COMPONENTS = 0x886D,

		/// <summary>
		/// Maximum number of components of outputs written by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_OUTPUT_COMPONENTS = 0x8E86,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_SHADER_STORAGE_BLOCKS = 0x90D9,

		/// <summary>
		/// Maximum number of texture image units accessible by a tesselation evaluation shader.
		/// </summary>
		MAX_TESS_EVALUATION_TEXTURE_IMAGE_UNITS = 0x8E82,

		/// <summary>
		/// Maximum number of tesselation evaluation shader uniform buffers per program.
		/// </summary>
		MAX_TESS_EVALUATION_UNIFORM_BLOCKS = 0x8E8A,

		/// <summary>
		/// Maximum number of words for tesselation evaluation shader uniforms.
		/// </summary>
		MAX_TESS_EVALUATION_UNIFORM_COMPONENTS = 0x8E80,

		/// <summary>
		/// Maximum level supported by tesselation primitive generator.
		/// </summary>
		MAX_TESS_GEN_LEVEL = 0x8E7E,

		/// <summary>
		/// Maximum number of components for tesselation control shader per-patch output.
		/// </summary>
		MAX_TESS_PATCH_COMPONENTS = 0x8E84,

		/// <summary>
		/// Maximum number of addressable texels for buffer textures.
		/// </summary>
		MAX_TEXTURE_BUFFER_SIZE = 0x8C2B,

		/// <summary>
		/// Maximum number of texture image units accessible by a fragment shader.
		/// </summary>
		MAX_TEXTURE_IMAGE_UNITS = 0x8872,

		/// <summary>
		/// Maximum 2D/1D texture images dimension.
		/// </summary>
		MAX_TEXTURE_SIZE = 0x0D33,

		/// <summary>
		/// Maximum number of buffer objects to write with transform feedback.
		/// </summary>
		MAX_TRANSFORM_FEEDBACK_BUFFERS = 0x8E70,

		/// <summary>
		/// Maximum number of components to write to a single buffer in interleaved mode.
		/// </summary>
		MAX_TRANSFORM_FEEDBACK_INTERLEAVED_COMPONENTS = 0x8C8A,

		/// <summary>
		/// Maximum number of separate attributes or outputs that can be captured in transform feedback.
		/// </summary>
		MAX_TRANSFORM_FEEDBACK_SEPARATE_ATTRIBS = 0x8C8B,

		/// <summary>
		/// Maximum number of components per attribute or output in separate mode.
		/// </summary>
		MAX_TRANSFORM_FEEDBACK_SEPARATE_COMPONENTS = 0x8C80,

		/// <summary>
		/// Maximum size in basic machine units of a uniform block.
		/// </summary>
		MAX_UNIFORM_BLOCK_SIZE = 0x8A30,

		/// <summary>
		/// Maximum number of uniform buffer binding points on the context.
		/// </summary>
		MAX_UNIFORM_BUFFER_BINDINGS = 0x8A2F,

		/// <summary>
		/// Maximum number of user-assignable uniform locations.
		/// </summary>
		MAX_UNIFORM_LOCATIONS = 0x826E,

		/// <summary>
		/// Maximum number of components for output variables.
		/// Deprecated but still supported.
		/// </summary>
		MAX_VARYING_COMPONENTS = 0x8B4B,

		/// <summary>
		/// Maximum number of components for output variables.
		/// Deprecated but still supported.
		/// Equivalent to <see cref="glGetIntegerParameter.MAX_VARYING_COMPONENTS"/>.
		/// </summary>
		[Obsolete("Use MAX_VARYING_COMPONENTS.")]
		MAX_VARYING_FLOATS = MAX_VARYING_COMPONENTS,

		/// <summary>
		/// Maximum number of vectors for output variables.
		/// </summary>
		MAX_VARYING_VECTORS = 0x8DFC,

		/// <summary>
		/// Maximum number of atomic counter buffers accessed by a vertex shader.
		/// </summary>
		MAX_VERTEX_ATOMIC_COUNTER_BUFFERS = 0x92CC,

		/// <summary>
		/// Maximum number of atomic counters accessed by a vertex shader.
		/// </summary>
		MAX_VERTEX_ATOMIC_COUNTERS = 0x92D2,

		/// <summary>
		/// Maximum number of vertex buffers.
		/// </summary>
		MAX_VERTEX_ATTRIB_BINDINGS = 0x82DA,

		/// <summary>
		/// Maximum offset added to vertex buffer binding offset.
		/// </summary>
		MAX_VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D9,

		/// <summary>
		/// Maximum vertex attribute stride.
		/// </summary>
		MAX_VERTEX_ATTRIB_STRIDE = 0x82E5,

		/// <summary>
		/// Maximum number of active vertex attributes.
		/// </summary>
		MAX_VERTEX_ATTRIBS = 0x8869,

		/// <summary>
		/// Maximum number of image variables in vertex shaders.
		/// </summary>
		MAX_VERTEX_IMAGE_UNIFORMS = 0x90CA,

		/// <summary>
		/// Maximum number of components of outputs written by a vertex shader.
		/// </summary>
		MAX_VERTEX_OUTPUT_COMPONENTS = 0x9122,

		/// <summary>
		/// Maximum number of shader storage blocks accessed by a vertex shader.
		/// </summary>
		MAX_VERTEX_SHADER_STORAGE_BLOCKS = 0x90D6,

		/// <summary>
		/// Total number of vertex streams.
		/// </summary>
		MAX_VERTEX_STREAMS = 0x8E71,

		/// <summary>
		/// Maximum number of texture image units accessible by a vertex shader.
		/// </summary>
		MAX_VERTEX_TEXTURE_IMAGE_UNITS = 0x8B4C,

		/// <summary>
		/// Maximum number of vertex shader uniform buffers per program.
		/// </summary>
		MAX_VERTEX_UNIFORM_BLOCKS = 0x8A2B,

		/// <summary>
		/// Maximum number of words for vertex shader uniforms.
		/// </summary>
		MAX_VERTEX_UNIFORM_COMPONENTS = 0x8B4A,

		/// <summary>
		/// Maximum number of vectors for vertex shader uniform variables
		/// </summary>
		MAX_VERTEX_UNIFORM_VECTORS = 0x8DFB,

		/// <summary>
		/// Maximum number of active viewports.
		/// </summary>
		MAX_VIEWPORTS = 0x825B,

		/// <summary>
		/// Minimum byte alignment of pointers returned by <b>gl.Map*Buffer</b>.
		/// </summary>
		MIN_MAP_BUFFER_ALIGNMENT = 0x90BC,

		/// <summary>
		/// Minimum texel offset allowed in lookup.
		/// </summary>
		MIN_PROGRAM_TEXEL_OFFSET = 0x8904,

		/// <summary>
		/// Minimum texel offset for <c>textureGatherOffsets</c>.
		/// </summary>
		MIN_PROGRAM_TEXTURE_GATHER_OFFSET = 0x8E5E,

		/// <summary>
		/// Minor OpenGL version number.
		/// </summary>
		MINOR_VERSION = 0x821C,

		/// <summary>
		/// Number of compressed texture formats.
		/// </summary>
		[Obsolete("Deprecated since 4.2")]
		NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2,

		/// <summary>
		/// Number of extensions.
		/// </summary>
		NUM_EXTENSIONS = 0x821D,

		/// <summary>
		/// Number of supported binary program formats.
		/// </summary>
		NUM_PROGRAM_BINARY_FORMATS = 0x87FE,

		/// <summary>
		/// Number of supported binary shader formats.
		/// </summary>
		NUM_SHADER_BINARY_FORMATS = 0x8DF9,

		/// <summary>
		/// Number of supported shading language version.
		/// </summary>
		NUM_SHADING_LANGUAGE_VERSIONS = 0x82E9,

		/// <summary>
		/// Aligment for pack operations.
		/// </summary>
		PACK_ALIGNMENT = 0x0D05,

		/// <summary>
		/// Compressed block depth for pack operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_DEPTH = 0x912D,

		/// <summary>
		/// Compressed block height for pack operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_HEIGHT = 0x912C,

		/// <summary>
		/// Compressed block size for pack operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_SIZE = 0x912E,

		/// <summary>
		/// Compressed block width for pack operations.
		/// </summary>
		PACK_COMPRESSED_BLOCK_WIDTH = 0x912B,

		/// <summary>
		/// Image height for pack operations.
		/// </summary>
		PACK_IMAGE_HEIGHT = 0x806C,

		/// <summary>
		/// Image width for pack operations.
		/// </summary>
		PACK_ROW_LENGTH = 0x0D02,

		/// <summary>
		/// Skip images for pack operations.
		/// </summary>
		PACK_SKIP_IMAGES = 0x806B,

		/// <summary>
		/// Skip pixels for pack operations.
		/// </summary>
		PACK_SKIP_PIXELS = 0x0D04,

		/// <summary>
		/// Skip rows for pack operations.
		/// </summary>
		PACK_SKIP_ROWS = 0x0D03,

		/// <summary>
		/// Number of vertices in input patch. 
		/// </summary>
		PATCH_VERTICES = 0x8E72,

		/// <summary>
		/// Pixel pack buffer binding.
		/// </summary>
		PIXEL_PACK_BUFFER_BINDING = 0x88ED,

		/// <summary>
		/// Pixel unpack buffer binding.
		/// </summary>
		PIXEL_UNPACK_BUFFER_BINDING = 0x88EF,

		/// <summary>
		/// Origin orientation for point sprite. Returns <see cref="glOrientationOrigin"/>.
		/// </summary>
		POINT_SPRITE_COORD_ORIGIN = 0x8CA0,

		/// <summary>
		/// Current polygon rasterization mode. Returns <see cref="glPolygonMode"/>.
		/// </summary>
		POLYGON_MODE = 0x0B40,

		/// <summary>
		/// Polygon smooth hint. Returns <see cref="glHintMode"/>.
		/// </summary>
		POLYGON_SMOOTH_HINT = 0x0C53,

		/// <summary>
		/// Primitive restart index.
		/// </summary>
		PRIMITIVE_RESTART_INDEX = 0x8F9E,

		/// <summary>
		/// Binary program formats. Returns uint[<see cref="glGetIntegerParameter.NUM_PROGRAM_BINARY_FORMATS"/>].
		/// </summary>
		PROGRAM_BINARY_FORMATS = 0x87FF,

		/// <summary>
		/// Current program pipeline object binding.
		/// </summary>
		PROGRAM_PIPELINE_BINDING = 0x825A,

		/// <summary>
		/// Provoking vertex convention. Returns <see cref="glProvokingVertexMode"/>.
		/// </summary>
		PROVOKING_VERTEX = 0x8E4F,

		/// <summary>
		/// Query result buffer binding.
		/// </summary>
		QUERY_BUFFER_BINDING = 0x9193,

		/// <summary>
		/// Read source buffer. Returns <see cref="glBuffer"/>
		/// </summary>
		READ_BUFFER = 0x0C02,

		/// <summary>
		/// Framebuffer object bound to <see cref="glFramebufferTarget.READ_FRAMEBUFFER"/>.
		/// </summary>
		READ_FRAMEBUFFER_BINDING = 0x8CAA,

		/// <summary>
		/// Currently bound renderbuffer object.
		/// </summary>
		RENDERBUFFER_BINDING = 0x8CA7,

		/// <summary>
		/// Reset notification strategy. Returns <see cref="glResetNotificationStrategy"/>.
		/// </summary>
		RESET_NOTIFICATION_STRATEGY = 0x8256,

		/// <summary>
		/// Number of multisample buffers.
		/// </summary>
		SAMPLE_BUFFERS = 0x80A8,

		/// <summary>
		/// Sampler object bound to active texture unit.
		/// </summary>
		SAMPLER_BINDING = 0x8919,

		/// <summary>
		/// Coverage mask size.
		/// </summary>
		SAMPLES = 0x80A9,

		/// <summary>
		/// Binary shader formats. Returns uint[<see cref="glGetIntegerParameter.NUM_SHADER_BINARY_FORMATS"/>].
		/// </summary>
		SHADER_BINARY_FORMATS = 0x8DF8,

		/// <summary>
		/// Buffer object bound to each shader storage buffer binding point.
		/// </summary>
		SHADER_STORAGE_BUFFER_BINDING = 0x90D3,

		/// <summary>
		/// Maximum required alignment for shader storage buffer binding offsets.
		/// </summary>
		SHADER_STORAGE_BUFFER_OFFSET_ALIGNMENT = 0x90DF,

		/// <summary>
		/// Back stencil fail action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_BACK_FAIL = 0x8801,

		/// <summary>
		/// Back stencil function. Returns <see cref="glFunc"/>.
		/// </summary>
		STENCIL_BACK_FUNC = 0x8800,

		/// <summary>
		/// Back stencil depth buffer fail action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_BACK_PASS_DEPTH_FAIL = 0x8802,

		/// <summary>
		/// Back stencil depth buffer pass action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_BACK_PASS_DEPTH_PASS = 0x8803,

		/// <summary>
		/// Back stencil reference value.
		/// </summary>
		STENCIL_BACK_REF = 0x8CA3,

		/// <summary>
		/// Back stencil mask.
		/// </summary>
		STENCIL_BACK_VALUE_MASK = 0x8CA4,

		/// <summary>
		/// Back stencil buffer writemask.
		/// </summary>
		STENCIL_BACK_WRITEMASK = 0x8CA5,

		/// <summary>
		/// Stencil clear value.
		/// </summary>
		STENCIL_CLEAR_VALUE = 0x0B91,

		/// <summary>
		/// Front stencil fail action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_FAIL = 0x0B94,

		/// <summary>
		/// Front stencil function. Returns <see cref="glFunc"/>.
		/// </summary>
		STENCIL_FUNC = 0x0B92,

		/// <summary>
		/// Front stencil depth buffer fail action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_PASS_DEPTH_FAIL = 0x0B95,

		/// <summary>
		/// Front stencil depth buffer pass action. Returns <see cref="glStencilOpMode"/>.
		/// </summary>
		STENCIL_PASS_DEPTH_PASS = 0x0B96,

		/// <summary>
		/// Front stencil reference value.
		/// </summary>
		STENCIL_REF = 0x0B97,

		/// <summary>
		/// Front stencil mask.
		/// </summary>
		STENCIL_VALUE_MASK = 0x0B93,

		/// <summary>
		/// Front stencil buffer writemask.
		/// </summary>
		STENCIL_WRITEMASK = 0x0B98,

		/// <summary>
		/// Number of bits of subpixel precision in screen <c>xw</c> and <c>yw</c>.
		/// </summary>
		SUBPIXEL_BITS = 0x0D50,

		/// <summary>
		/// Currently bound 1D texture object.
		/// </summary>
		TEXTURE_BINDING_1D = 0x8068,

		/// <summary>
		/// Currently bound 1D texture array object.
		/// </summary>
		TEXTURE_BINDING_1D_ARRAY = 0x8C1C,

		/// <summary>
		/// Currently bound 2D texture object.
		/// </summary>
		TEXTURE_BINDING_2D = 0x8069,

		/// <summary>
		/// Currently bound 2D texture array object.
		/// </summary>
		TEXTURE_BINDING_2D_ARRAY = 0x8C1D,

		/// <summary>
		/// Currently bound 2D multisample texture object.
		/// </summary>
		TEXTURE_BINDING_2D_MULTISAMPLE = 0x9104,

		/// <summary>
		/// Currently bound 2D multisample texture array object.
		/// </summary>
		TEXTURE_BINDING_2D_MULTISAMPLE_ARRAY = 0x9105,

		/// <summary>
		/// Currently bound 3D texture object.
		/// </summary>
		TEXTURE_BINDING_3D = 0x806A,

		/// <summary>
		/// Currently bound texture buffer object.
		/// </summary>
		TEXTURE_BINDING_BUFFER = 0x8C2C,

		/// <summary>
		/// Currently bound cube map texture object.
		/// </summary>
		TEXTURE_BINDING_CUBE_MAP = 0x8514,

		/// <summary>
		/// Currently bound cube map texture array object.
		/// </summary>
		TEXTURE_BINDING_CUBE_MAP_ARRAY = 0x900A,

		/// <summary>
		/// Currently bound rectangle texture object.
		/// </summary>
		TEXTURE_BINDING_RECTANGLE = 0x84F6,

		/// <summary>
		/// Buffer object bound to texture buffer binding point.
		/// </summary>
		TEXTURE_BUFFER_BINDING = 0x8C2A,

		/// <summary>
		/// Maximum required alignment for texture buffer offsets.
		/// </summary>
		TEXTURE_BUFFER_OFFSET_ALIGNMENT = 0x919F,

		/// <summary>
		/// Texture compression hint. Returns <see cref="glHintMode"/>.
		/// </summary>
		TEXTURE_COMPRESSION_HINT = 0x84EF,

		/// <summary>
		/// Object bound for transform feedback operation.
		/// </summary>
		TRANSFORM_FEEDBACK_BINDING = 0x8E25,

		/// <summary>
		/// Buffer object bound to generic binding point for transform feedback.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_BINDING = 0x8C8F,

		/// <summary>
		/// Uniform buffer object bound to the context for buffer object manipulation.
		/// </summary>
		UNIFORM_BUFFER_BINDING = 0x8A28,

		/// <summary>
		/// Maximum required alignment for uniform buffer sizes and offsets.
		/// </summary>
		UNIFORM_BUFFER_OFFSET_ALIGNMENT = 0x8A34,

		/// <summary>
		/// Aligment for unpack operations.
		/// </summary>
		UNPACK_ALIGNMENT = 0x0CF5,

		/// <summary>
		/// Compressed block depth for unpack operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_DEPTH = 0x9129,

		/// <summary>
		/// Compressed block height for unpack operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_HEIGHT = 0x9128,

		/// <summary>
		/// Compressed block size for unpack operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_SIZE = 0x912A,

		/// <summary>
		/// Compressed block width for pack operations.
		/// </summary>
		UNPACK_COMPRESSED_BLOCK_WIDTH = 0x9127,

		/// <summary>
		/// Image height for unpack operations.
		/// </summary>
		UNPACK_IMAGE_HEIGHT = 0x806E,

		/// <summary>
		/// Image width for unpack operations.
		/// </summary>
		UNPACK_ROW_LENGTH = 0x0CF2,

		/// <summary>
		/// Skip images for unpack operations.
		/// </summary>
		UNPACK_SKIP_IMAGES = 0x806D,

		/// <summary>
		/// Skip pixels for unpack operations.
		/// </summary>
		UNPACK_SKIP_PIXELS = 0x0CF4,

		/// <summary>
		/// Skip rows for unpack operations.
		/// </summary>
		UNPACK_SKIP_ROWS = 0x0CF3,

		/// <summary>
		/// Current vertex array object binding.
		/// </summary>
		VERTEX_ARRAY_BINDING = 0x85B5,

		/// <summary>
		/// Vertex convention followed by <c>gl_ViewportIndex</c>. Returns <see cref="glProvokingVertexMode"/>.
		/// </summary>
		VIEWPORT_INDEX_PROVOKING_VERTEX = 0x825F,

		/// <summary>
		/// Number of bits of subpixel precision for viewport bounds.
		/// </summary>
		VIEWPORT_SUBPIXEL_BITS = 0x825C,
	}
}
