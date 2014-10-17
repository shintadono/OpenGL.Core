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
	/// Provoking vertex convention. Used by <see cref="gl.ProvokingVertex"/>.
	/// </summary>
	public enum glProvokingVertexMode : uint
	{
		/// <summary>
		/// Use first vertex of primitive.
		/// </summary>
		FIRST_VERTEX_CONVENTION=0x8E4D,

		/// <summary>
		/// Use last vertex of primitive.
		/// </summary>
		LAST_VERTEX_CONVENTION=0x8E4E,

		/// <summary>
		/// Default convention. Not used with <see cref="gl.ProvokingVertex"/>. Returned by queries only.
		/// </summary>
		PROVOKING_VERTEX=0x8E4F,

		/// <summary>
		/// Undefined behavior. Not used with <see cref="gl.ProvokingVertex"/>. Returned by queries only.
		/// </summary>
		UNDEFINED_VERTEX=0x8260,
	}
}
