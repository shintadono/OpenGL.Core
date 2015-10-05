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
	/// Enum identifying objects in <see cref="gl.ObjectLabel"/> and <see cref="gl.GetObjectLabel"/>.
	/// </summary>
	public enum glObjectNamespaceIdentifier : uint
	{
		/// <summary>
		/// Buffer object.
		/// </summary>
		BUFFER = 0x82E0,

		/// <summary>
		/// Framebuffer object.
		/// </summary>
		FRAMEBUFFER = 0x8D40,

		/// <summary>
		/// Program pipeline object.
		/// </summary>
		PROGRAM_PIPELINE = 0x82E4,

		/// <summary>
		/// Programm object.
		/// </summary>
		PROGRAM = 0x82E2,

		/// <summary>
		/// Query object.
		/// </summary>
		QUERY = 0x82E3,

		/// <summary>
		/// Renderbuffer object.
		/// </summary>
		RENDERBUFFER = 0x8D41,

		/// <summary>
		/// Sampler object.
		/// </summary>
		SAMPLER = 0x82E6,

		/// <summary>
		/// Shader object.
		/// </summary>
		SHADER = 0x82E1,

		/// <summary>
		/// Texture object.
		/// </summary>
		TEXTURE = 0x1702,

		/// <summary>
		/// Transform feedback object.
		/// </summary>
		TRANSFORM_FEEDBACK = 0x8E22,

		/// <summary>
		/// Vertex array object.
		/// </summary>
		VERTEX_ARRAY = 0x8074,
	}
}
