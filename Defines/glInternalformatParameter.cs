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
	/// Enum for internal format parameter. Used by <see cref="gl.GetInternalformativ"/> and <see cref="gl.GetInternalformati64v"/>.
	/// </summary>
	public enum glInternalformatParameter : uint
	{
		/// <summary>
		/// Support for using the resource with <b>ClearBuffer*Data</b> commands is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		CLEAR_BUFFER = 0x82B4,

		/// <summary>
		/// Support for using the resource with <b>ClearTex*Image</b> commands is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		CLEAR_TEXTURE = 0x9365,

		/// <summary>
		/// If the internal format contains any color components (R, G, B or A), <see cref="gl.TRUE"/> is returned.
		/// </summary>
		COLOR_COMPONENTS = 0x8283,

		/// <summary>
		/// The color encoding for the resource is returned as <see cref="glColorEncoding"/> or
		/// <see cref="gl.NONE"/> if non-color format (such as depth or stencil), or unsupported resources.
		/// </summary>
		COLOR_ENCODING = 0x8296,

		/// <summary>
		/// If the internal format is color-renderable, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		COLOR_RENDERABLE = 0x8286,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a compute shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		COMPUTE_TEXTURE = 0x82A0,

		/// <summary>
		/// If the internal format contains a depth component, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		DEPTH_COMPONENTS = 0x8284,

		/// <summary>
		/// If the internal format is depth-renderable, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		DEPTH_RENDERABLE = 0x8287,

		/// <summary>
		/// Support for filter type <see cref="glFilter.LINEAR"/> is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		FILTER = 0x829A,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a fragment shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		FRAGMENT_TEXTURE = 0x829F,

		/// <summary>
		/// Support for rendering to the resource via framebuffer attachment when blending is enabled is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		FRAMEBUFFER_BLEND = 0x828B,

		/// <summary>
		/// Support for rendering to the resource via framebuffer attachment is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		FRAMEBUFFER_RENDERABLE = 0x8289,

		/// <summary>
		/// Support for layered rendering to the resource via framebuffer attachment is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		FRAMEBUFFER_RENDERABLE_LAYERED = 0x828A,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a geometry shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		GEOMETRY_TEXTURE = 0x829E,

		/// <summary>
		/// The implementation-preferred format to pass to <see cref="O:OpenGL.Core.gl.GetTexImage">gl.GetTexImage</see>
		/// when querying texture image data from this resource is returned as <see cref="glPixelFormat"/> or <see cref="gl.NONE"/> if the resource does not support this operation.
		/// </summary>
		GET_TEXTURE_IMAGE_FORMAT = 0x8291,

		/// <summary>
		/// The implementation-preferred data type to pass to <see cref="O:OpenGL.Core.gl.GetTexImage">gl.GetTexImage</see>
		/// when querying texture image data from this resource is returned as <see cref="glPixelDataType"/> or <see cref="gl.NONE"/> if the resource does not support this operation.
		/// </summary>
		GET_TEXTURE_IMAGE_TYPE = 0x8292,

		/// <summary>
		/// The compatibility class of the resource when used as an image texture is returned as <see cref="glImageCompatiblityClass"/>.
		/// </summary>
		IMAGE_COMPATIBILITY_CLASS = 0x82A8,

		/// <summary>
		/// The matching criteria use for the resource when used as an image textures is returned as <see cref="glImageFormatCompatibilityType"/>.
		/// </summary>
		IMAGE_FORMAT_COMPATIBILITY_TYPE = 0x90C7,

		/// <summary>
		/// The pixel format of the resource when used as an image texture is returned as <see cref="glPixelFormat"/> or <see cref="gl.NONE"/> if the image textures not supported.
		/// </summary>
		IMAGE_PIXEL_FORMAT = 0x82A9,

		/// <summary>
		/// The pixel data type of the resource when used as an image texture is returned as <see cref="glPixelDataType"/> or <see cref="gl.NONE"/> if the image textures not supported.
		/// </summary>
		IMAGE_PIXEL_TYPE = 0x82AA,

		/// <summary>
		/// The size of a texel when the resource when used as an image texture is returned.
		/// </summary>
		IMAGE_TEXEL_SIZE = 0x82A7,

		/// <summary>
		/// The implementation-preferred internal format for representing resources if no less precision is return
		/// as <see cref="glInternalFormat"/> or <see cref="gl.NONE"/> if the specified internal format is not supported.
		/// </summary>
		INTERNALFORMAT_PREFERRED = 0x8270,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the red component is returned.
		/// </summary>
		INTERNALFORMAT_RED_SIZE = 0x8271,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the green component is returned.
		/// </summary>
		INTERNALFORMAT_GREEN_SIZE = 0x8272,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the blue component is returned.
		/// </summary>
		INTERNALFORMAT_BLUE_SIZE = 0x8273,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the alpha component is returned.
		/// </summary>
		INTERNALFORMAT_ALPHA_SIZE = 0x8274,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the depth component is returned.
		/// </summary>
		INTERNALFORMAT_DEPTH_SIZE = 0x8275,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the stencil component is returned.
		/// </summary>
		INTERNALFORMAT_STENCIL_SIZE = 0x8276,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) resolution of the shared exponent of the components is returned.
		/// </summary>
		INTERNALFORMAT_SHARED_SIZE = 0x8277,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the red component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_RED_TYPE = 0x8278,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the green component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_GREEN_TYPE = 0x8279,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the blue component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_BLUE_TYPE = 0x827A,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the alpha component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_ALPHA_TYPE = 0x827B,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the depth component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_DEPTH_TYPE = 0x827C,

		/// <summary>
		/// The actual (if not compressed) or uncompressed (if compressed) data type of the stencil component is returned as <see cref="glComponentType"/>.
		/// </summary>
		INTERNALFORMAT_STENCIL_TYPE = 0x827D,

		/// <summary>
		/// If the internal format is supported, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		INTERNALFORMAT_SUPPORTED = 0x826F,

		/// <summary>
		/// Support for manually generating mipmaps for the resource is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		MANUAL_GENERATE_MIPMAP = 0x8294,

		/// <summary>
		/// The maximum combined dimensions for the resource is returned as <b>long</b>.
		/// </summary>
		MAX_COMBINED_DIMENSIONS = 0x8282,

		/// <summary>
		/// The maximum supported depth for the resource is returned.
		/// </summary>
		MAX_DEPTH = 0x8280,

		/// <summary>
		/// The maximum supported height for the resource is returned.
		/// </summary>
		MAX_HEIGHT = 0x827F,

		/// <summary>
		/// The maximum supported number of layers for the resource is returned.
		/// </summary>
		MAX_LAYERS = 0x8281, // int

		/// <summary>
		/// The maximum supported width for the resource is returned.
		/// </summary>
		MAX_WIDTH = 0x827E,

		/// <summary>
		/// If the resource supports mipmaps, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		MIPMAP = 0x8293,

		/// <summary>
		/// The number of sample counts that would be returned by querying <see cref="SAMPLES"/> is returned.
		/// </summary>
		NUM_SAMPLE_COUNTS = 0x9380,

		/// <summary>
		/// Support for reading pixels from the resource when it is attached to a framebuffer is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		READ_PIXELS = 0x828C,

		/// <summary>
		/// The format to pass to <see cref="O:OpenGL.Core.gl.ReadPixels">gl.ReadPixels</see>
		/// to obtain the best performance and image quality when reading from framebuffers with the internal format is returned as
		/// <see cref="glPixelFormat"/> or <see cref="gl.NONE"/> if the internal format the not supported.
		/// </summary>
		READ_PIXELS_FORMAT = 0x828D,

		/// <summary>
		/// The data type to pass to <see cref="O:OpenGL.Core.gl.ReadPixels">gl.ReadPixels</see>
		/// to obtain the best performance and image quality when reading from framebuffers with the internal format is returned as
		/// <see cref="glPixelDataType"/> or <see cref="gl.NONE"/> if the internal format the not supported.
		/// </summary>
		READ_PIXELS_TYPE = 0x828E,

		/// <summary>
		/// The sample counts supported for the internal format and target are returned as array of <see cref="NUM_SAMPLE_COUNTS"/> <b>int</b>s, in descending numeric order
		/// </summary>
		SAMPLES = 0x80A9,

		/// <summary>
		/// Support for using the resource with atomic memory operations from shaders is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SHADER_IMAGE_ATOMIC = 0x82A6,

		/// <summary>
		/// Support for using the resource with image load operations in shaders is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SHADER_IMAGE_LOAD = 0x82A4,

		/// <summary>
		/// Support for using the resource with image store operations in shaders is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SHADER_IMAGE_STORE = 0x82A5,

		/// <summary>
		/// Support for using the resource both as a source for texture sampling while it is bound as a buffer for depth test is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SIMULTANEOUS_TEXTURE_AND_DEPTH_TEST = 0x82AC,

		/// <summary>
		/// Support for using the resource both as a source for texture sampling while performing depth writes to the resources is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SIMULTANEOUS_TEXTURE_AND_DEPTH_WRITE = 0x82AE,

		/// <summary>
		/// Support for using the resource both as a source for texture sampling while it is bound as a buffer for stencil test is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SIMULTANEOUS_TEXTURE_AND_STENCIL_TEST = 0x82AD,

		/// <summary>
		/// Support for using the resource both as a source for texture sampling while performing stencil writes to the resources is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SIMULTANEOUS_TEXTURE_AND_STENCIL_WRITE = 0x82AF,

		/// <summary>
		/// Support for converting from sRGB colorspace on read operations from the resource is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SRGB_READ = 0x8297,

		/// <summary>
		/// Support for converting from sRGB colorspace on write operations from the resource is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		SRGB_WRITE = 0x8298,

		/// <summary>
		/// If the internal format contains a stencil component, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		STENCIL_COMPONENTS = 0x8285,

		/// <summary>
		/// If the internal format is stencil-renderable, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		STENCIL_RENDERABLE = 0x8288,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a tessellation control shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TESS_CONTROL_TEXTURE = 0x829C,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a tessellation evaluation shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TESS_EVALUATION_TEXTURE = 0x829D,

		/// <summary>
		/// If the internal format is a compressed format that is supported for this type of resource, <see cref="gl.TRUE"/> is returned.
		/// </summary>
		TEXTURE_COMPRESSED = 0x86A1,

		/// <summary>
		/// If the resource contains a compressed format, the height of a compressed block (in bytes) is returned.
		/// </summary>
		TEXTURE_COMPRESSED_BLOCK_HEIGHT = 0x82B2,

		/// <summary>
		/// If the resource contains a compressed format the number of bytes per block is returned.
		/// </summary>
		TEXTURE_COMPRESSED_BLOCK_SIZE = 0x82B3,

		/// <summary>
		/// If the resource contains a compressed format, the width of a compressed block (in bytes) is returned.
		/// </summary>
		TEXTURE_COMPRESSED_BLOCK_WIDTH = 0x82B1,

		/// <summary>
		/// Support for using the resource with texture gather operations is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TEXTURE_GATHER = 0x82A2,

		/// <summary>
		/// Support for using resource with texture gather operations with shadow samplers is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TEXTURE_GATHER_SHADOW = 0x82A3,

		/// <summary>
		/// The implementation-preferred format to pass to <b>TexImage*D</b> or <b>TexSubImage*D</b> when specifying texture image data for this
		/// resource is returned as <see cref="glPixelFormat"/> or <see cref="gl.NONE"/> if the resource is not supported for this operation.
		/// </summary>
		TEXTURE_IMAGE_FORMAT = 0x828F,

		/// <summary>
		/// The implementation-preferred data type to pass to <b>TexImage*D</b> or <b>TexSubImage*D</b> when specifying texture image data for this
		/// resource is returned as <see cref="glPixelDataType"/> or <see cref="gl.NONE"/> if the resource is not supported for this operation.
		/// </summary>
		TEXTURE_IMAGE_TYPE = 0x8290,

		/// <summary>
		/// Support for using the resource with shadow samplers is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TEXTURE_SHADOW = 0x82A1,

		/// <summary>
		/// Support for using the resource with the <see cref="gl.TextureView"/> command is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		TEXTURE_VIEW = 0x82B5,

		/// <summary>
		/// Support for using the resource as a source for texture sampling in a vertex shader is returned as <see cref="glGetInternalformatResult"/>.
		/// </summary>
		VERTEX_TEXTURE = 0x829B,

		/// <summary>
		/// The compatibility class of the resource when used as a texture view is returned as <see cref="glViewCompatibilityClass"/>.
		/// </summary>
		VIEW_COMPATIBILITY_CLASS = 0x82B6,
	}
}
