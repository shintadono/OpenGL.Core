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
	/// Draw mode. Used for e.g. <see cref="O:OpenGL.Core.gl.DrawElements">gl.DrawElements</see>.
	/// </summary>
	public enum glDrawMode : uint
	{
		/// <summary>
		/// Draw points.
		/// </summary>
		POINTS=0x0000,

		/// <summary>
		/// Draw line strip.
		/// </summary>
		LINE_STRIP=0x0003,

		/// <summary>
		/// Draw line loop.
		/// </summary>
		LINE_LOOP=0x0002,

		/// <summary>
		/// Draw lines.
		/// </summary>
		LINES=0x0001,

		/// <summary>
		/// Draw triangle strip.
		/// </summary>
		TRIANGLE_STRIP=0x0005,

		/// <summary>
		/// Draw triangle fan.
		/// </summary>
		TRIANGLE_FAN=0x0006,

		/// <summary>
		/// Draw triangles.
		/// </summary>
		TRIANGLES=0x0004,

		/// <summary>
		/// Draw lines with adjacency.
		/// </summary>
		LINES_ADJACENCY=0x000A,

		/// <summary>
		/// Draw line strip with adjacency.
		/// </summary>
		LINE_STRIP_ADJACENCY=0x000B,

		/// <summary>
		/// Draw triangles with adjacency.
		/// </summary>
		TRIANGLES_ADJACENCY=0x000C,

		/// <summary>
		/// Draw triangle strip with adjacency.
		/// </summary>
		TRIANGLE_STRIP_ADJACENCY=0x000D,

		/// <summary>
		/// Draw patches.
		/// </summary>
		PATCHES=0x000E,
	}
}
