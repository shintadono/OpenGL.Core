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
	/// Renderbuffer parameters. Used by <see cref="gl.GetRenderbufferParameteriv"/>.
	/// </summary>
	public enum glRenderbufferParameter : uint
	{
		/// <summary>
		/// Width of the renderbuffer.
		/// </summary>
		RENDERBUFFER_WIDTH=0x8D42,

		/// <summary>
		/// Height of the renderbuffer.
		/// </summary>
		RENDERBUFFER_HEIGHT=0x8D43,

		/// <summary>
		/// Internal format (<see cref="glInternalFormat"/>) of the renderbuffer.
		/// </summary>
		RENDERBUFFER_INTERNAL_FORMAT=0x8D44,

		/// <summary>
		/// Size in bits of the red component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_RED_SIZE=0x8D50,

		/// <summary>
		/// Size in bits of the green component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_GREEN_SIZE=0x8D51,

		/// <summary>
		/// Size in bits of the blue component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_BLUE_SIZE=0x8D52,

		/// <summary>
		/// Size in bits of the alpha component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_ALPHA_SIZE=0x8D53,

		/// <summary>
		/// Size in bits of the depth component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_DEPTH_SIZE=0x8D54,

		/// <summary>
		/// Size in bits of the stencil component of the renderbuffer.
		/// </summary>
		RENDERBUFFER_STENCIL_SIZE=0x8D55,

		/// <summary>
		/// Number of samples of the renderbuffer.
		/// </summary>
		RENDERBUFFER_SAMPLES=0x8CAB,
	}
}
