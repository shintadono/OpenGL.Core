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
	/// Enum for setting and getting framebuffer parameter.
	/// </summary>
	public enum glFramebufferParameter : uint
	{
		/// <summary>
		/// Default width of framebuffer without attachments.
		/// </summary>
		FRAMEBUFFER_DEFAULT_WIDTH = 0x9310,

		/// <summary>
		/// Default height of framebuffer without attachments.
		/// </summary>
		FRAMEBUFFER_DEFAULT_HEIGHT = 0x9311,

		/// <summary>
		/// Default number of layers of framebuffer without attachments.
		/// </summary>
		FRAMEBUFFER_DEFAULT_LAYERS = 0x9312,

		/// <summary>
		/// Default number of samples of framebuffer without attachments.
		/// </summary>
		FRAMEBUFFER_DEFAULT_SAMPLES = 0x9313,

		/// <summary>
		/// Default sample location pattern of framebuffer without attachments.
		/// </summary>
		FRAMEBUFFER_DEFAULT_FIXED_SAMPLE_LOCATIONS = 0x9314,

		/// <summary>
		/// Is doublebuffering supported?
		/// </summary>
		DOUBLEBUFFER = 0x0C32,

		/// <summary>
		/// Implementation preferred pixel format. Returns <see cref="glImplementationColorReadFormat"/>.
		/// </summary>
		IMPLEMENTATION_COLOR_READ_FORMAT = 0x8B9B,

		/// <summary>
		/// Implementation preferred pixel data type. Returns <see cref="glImplementationColorReadType"/>.
		/// </summary>
		IMPLEMENTATION_COLOR_READ_TYPE = 0x8B9A,

		/// <summary>
		/// Number of multisample buffers.
		/// </summary>
		SAMPLE_BUFFERS = 0x80A8,

		/// <summary>
		/// Coverage mask size.
		/// </summary>
		SAMPLES = 0x80A9,

		/// <summary>
		/// Is stereo supported?
		/// </summary>
		STEREO = 0x0C33,
	}
}
