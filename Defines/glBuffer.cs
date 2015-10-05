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
	/// Default drawbuffers and framebuffer attachments.
	/// </summary>
	public enum glBuffer : uint
	{
		/// <summary>
		/// -
		/// </summary>
		NONE = 0,

		/// <summary>
		/// Front left drawbuffer.
		/// </summary>
		FRONT_LEFT = 0x0400,

		/// <summary>
		/// Front right drawbuffer.
		/// </summary>
		FRONT_RIGHT = 0x0401,

		/// <summary>
		/// Back left drawbuffer.
		/// </summary>
		BACK_LEFT = 0x0402,

		/// <summary>
		/// Back right drawbuffer.
		/// </summary>
		BACK_RIGHT = 0x0403,

		/// <summary>
		/// Front (left+right) drawbuffer.
		/// </summary>
		FRONT = 0x0404,

		/// <summary>
		/// Back (left+right) drawbuffer.
		/// </summary>
		BACK = 0x0405,

		/// <summary>
		/// Left (front+back) drawbuffer.
		/// </summary>
		LEFT = 0x0406,

		/// <summary>
		/// Right (front+back) drawbuffer.
		/// </summary>
		RIGHT = 0x0407,

		/// <summary>
		/// Front and back (left+right) drawbuffer.
		/// </summary>
		FRONT_AND_BACK = 0x0408,

		/// <summary>
		/// Color drawbuffer.
		/// </summary>
		COLOR = 0x1800,

		/// <summary>
		/// Depth-buffer.
		/// </summary>
		DEPTH = 0x1801,

		/// <summary>
		/// Stencil-buffer.
		/// </summary>
		STENCIL = 0x1802,

		/// <summary>
		/// Depth- and stencil-buffer.
		/// </summary>
		DEPTH_STENCIL = 0x84F9,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT0 = 0x8CE0,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT1 = 0x8CE1,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT2 = 0x8CE2,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT3 = 0x8CE3,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT4 = 0x8CE4,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT5 = 0x8CE5,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT6 = 0x8CE6,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT7 = 0x8CE7,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT8 = 0x8CE8,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT9 = 0x8CE9,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT10 = 0x8CEA,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT11 = 0x8CEB,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT12 = 0x8CEC,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT13 = 0x8CED,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT14 = 0x8CEE,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT15 = 0x8CEF,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT16 = 0x8CF0,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT17 = 0x8CF1,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT18 = 0x8CF2,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT19 = 0x8CF3,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT20 = 0x8CF4,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT21 = 0x8CF5,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT22 = 0x8CF6,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT23 = 0x8CF7,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT24 = 0x8CF8,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT25 = 0x8CF9,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT26 = 0x8CFA,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT27 = 0x8CFB,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT28 = 0x8CFC,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT29 = 0x8CFD,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT30 = 0x8CFE,

		/// <summary>
		/// Framebuffer color attachment point.
		/// </summary>
		COLOR_ATTACHMENT31 = 0x8CFF,

		/// <summary>
		/// Framebuffer depth attachment point.
		/// </summary>
		DEPTH_ATTACHMENT = 0x8D00,

		/// <summary>
		/// Framebuffer stencil attachment point.
		/// </summary>
		STENCIL_ATTACHMENT = 0x8D20,

		/// <summary>
		/// Framebuffer depth and stencil attachment point.
		/// </summary>
		DEPTH_STENCIL_ATTACHMENT = 0x821A,
	}
}
