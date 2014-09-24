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

using System.Runtime.InteropServices;

namespace OpenGL.Core
{
	/// <summary>
	/// Data structure holding draw element commands. Used by <see cref="gl.DrawElementsIndirect"/> and
	/// <see cref="gl.MultiDrawElementsIndirect"/>.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct glDrawElementsIndirectCommand
	{
		/// <summary>
		/// Number of elements (in an instance) to be drawn.
		/// </summary>
		[FieldOffset(0)]
		public uint count;

		/// <summary>
		/// Number of instance to be drawn.
		/// </summary>
		[FieldOffset(4)]
		public uint instanceCount;

		/// <summary>
		/// Index of the first element to be drawn.
		/// </summary>
		[FieldOffset(8)]
		public uint firstIndex;

		/// <summary>
		/// Constant that should be added to each element when chosing elements from the enabled vertex arrays.
		/// </summary>
		[FieldOffset(12)]
		public uint baseVertex;

		/// <summary>
		/// Base instance for use in fetching instanced vertex attributes.
		/// </summary>
		[FieldOffset(16)]
		public uint baseInstance;
	}
}
