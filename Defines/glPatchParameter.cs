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
	/// Enum for controlling patch parameter.
	/// </summary>
	public enum glPatchParameter : uint
	{
		/// <summary>
		/// Set the number of vertices the patch is given. (<see cref="gl.PatchParameteri"/>)
		/// </summary>
		PATCH_VERTICES=0x8E72,

		/// <summary>
		/// Set the two inner tesselation levels. (<see cref="gl.PatchParameterfv"/>)
		/// </summary>
		PATCH_DEFAULT_INNER_LEVEL=0x8E73,

		/// <summary>
		/// Set the four outer tesselation levels. (<see cref="gl.PatchParameterfv"/>)
		/// </summary>
		PATCH_DEFAULT_OUTER_LEVEL=0x8E74,
	}
}
