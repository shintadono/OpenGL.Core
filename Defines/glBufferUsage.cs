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
	/// Enum used by <see cref="O:OpenGL.Core.gl.BufferData">gl.BufferData</see>.
	/// </summary>
	public enum glBufferUsage : uint
	{
		/// <summary>
		/// The data store contents will be specified once by the application, and sourced at most a few times.
		/// </summary>
		STREAM_DRAW=0x88E0,

		/// <summary>
		/// The data store contents will be specified once by reading data from OpenGL, and queried at most a few times by the application.
		/// </summary>
		STREAM_READ=0x88E1,

		/// <summary>
		/// The data store contents will be specified once by reading data from OpenGL, and sourced at most a few times.
		/// </summary>
		STREAM_COPY=0x88E2,

		/// <summary>
		/// The data store contents will be specified once by the application, and sourced many times.
		/// </summary>
		STATIC_DRAW=0x88E4,

		/// <summary>
		/// The data store contents will be specified once by reading data from OpenGL, and queried many times by the application.
		/// </summary>
		STATIC_READ=0x88E5,

		/// <summary>
		/// The data store contents will be specified once by reading data from OpenGL, and sourced many times.
		/// </summary>
		STATIC_COPY=0x88E6,

		/// <summary>
		/// The data store contents will be respecified repeatedly by the application, and sourced many times.
		/// </summary>
		DYNAMIC_DRAW=0x88E8,

		/// <summary>
		/// The data store contents will be respecified repeatedly by reading data from OpenGL, and queried many times by the application.
		/// </summary>
		DYNAMIC_READ=0x88E9,

		/// <summary>
		/// The data store contents will be respecified repeatedly by reading data from OpenGL, and sourced many times.
		/// </summary>
		DYNAMIC_COPY=0x88EA,
	}
}
