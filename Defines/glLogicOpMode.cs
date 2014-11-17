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
	/// Logic fragment operation.
	/// </summary>
	public enum glLogicOpMode : uint
	{
		/// <summary>
		/// Re-Set to 0.
		/// </summary>
		CLEAR=0x1500,

		/// <summary>
		/// Source AND destination.
		/// </summary>
		AND=0x1501,

		/// <summary>
		/// Source AND inverse destination.
		/// </summary>
		AND_REVERSE=0x1502,

		/// <summary>
		/// Copy source.
		/// </summary>
		COPY=0x1503,

		/// <summary>
		/// Inverse source AND destination.
		/// </summary>
		AND_INVERTED=0x1504,

		/// <summary>
		/// Copy destination.
		/// </summary>
		NOOP=0x1505,

		/// <summary>
		/// Antivalance. Source XOR destination.
		/// </summary>
		XOR=0x1506,

		/// <summary>
		/// Source OR destination.
		/// </summary>
		OR=0x1507,

		/// <summary>
		/// Inverse of (source OR destination).
		/// </summary>
		NOR=0x1508,

		/// <summary>
		/// Equivalance. Inverse of (source XOR destination).
		/// </summary>
		EQUIV=0x1509,

		/// <summary>
		/// Inverse destination.
		/// </summary>
		INVERT=0x150A,

		/// <summary>
		/// Source OR inverse destination.
		/// </summary>
		OR_REVERSE=0x150B,

		/// <summary>
		/// Inverse source.
		/// </summary>
		COPY_INVERTED=0x150C,

		/// <summary>
		/// Inverse source OR destination.
		/// </summary>
		OR_INVERTED=0x150D,

		/// <summary>
		/// Inverse of (source AND destination).
		/// </summary>
		NAND=0x150E,

		/// <summary>
		/// Set all bit.
		/// </summary>
		SET=0x150F,
	}
}
