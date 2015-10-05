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
	/// Enum for vertex attribute parameters. Used by the <b>gl.GetVertexAttrib*</b> methodes and <see cref="gl.GetVertexArrayIndexediv"/>.
	/// </summary>
	public enum glVertexAttribParameter : uint
	{
		/// <summary>
		/// Vertex buffer binding. New in OpenGL 4.3.
		/// </summary>
		VERTEX_ATTRIB_BINDING = 0x82D4,

		/// <summary>
		/// Attribute array buffer binding.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_BUFFER_BINDING = 0x889F,

		/// <summary>
		/// Vertex attrib array instance divisor.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_DIVISOR = 0x88FE,

		/// <summary>
		/// Vertex attrib array enable.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_ENABLED = 0x8622,

		/// <summary>
		/// Vertex attrib array has unconverted integers.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_INTEGER = 0x88FD,

		/// <summary>
		/// Vertex attrib array has unconverted doubles.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_LONG = 0x874E,

		/// <summary>
		/// Vertex attrib array normalized.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_NORMALIZED = 0x886A,

		/// <summary>
		/// Vertex attrib array size.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_SIZE = 0x8623,

		/// <summary>
		/// Vertex attrib array stride.
		/// </summary>
		VERTEX_ATTRIB_ARRAY_STRIDE = 0x8624,

		/// <summary>
		/// Vertex attrib array type. (<see cref="glVertexAttribType"/>)
		/// </summary>
		VERTEX_ATTRIB_ARRAY_TYPE = 0x8625,

		/// <summary>
		/// Byte offset added to vertex binding offset for this attribute. New in OpenGL 4.3.
		/// </summary>
		VERTEX_ATTRIB_RELATIVE_OFFSET = 0x82D5,

		/// <summary>
		/// Byte offset of the first element in data store of the buffer bound to each (indexed) vertex binding.
		/// </summary>
		VERTEX_BINDING_OFFSET = 0x82D7,

		/// <summary>
		/// Current generic vertex attribute values. Array of four <b>float</b>s.
		/// </summary>
		CURRENT_VERTEX_ATTRIB = 0x8626,
	}
}
