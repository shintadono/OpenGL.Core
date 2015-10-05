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
	/// Conditional rendering mode. Used by <see cref="gl.BeginConditionalRender"/>.
	/// </summary>
	public enum glConditionalRenderMode : uint
	{
		/// <summary>
		/// Wait for the results of the query to be available and then use the results to determine if subsquent rendering commands are discarded.
		/// </summary>
		QUERY_WAIT = 0x8E13,

		/// <summary>
		/// OpenGL may choose to unconditionally execute the subsequent rendering commands without waiting for the query to complete.
		/// </summary>
		QUERY_NO_WAIT = 0x8E14,

		/// <summary>
		/// Wait for occlusion query results and discard rendering commands if the result of the occlusion query is zero.
		/// </summary>
		QUERY_BY_REGION_WAIT = 0x8E15,

		/// <summary>
		/// As <see cref="QUERY_BY_REGION_WAIT"/>, but may choose to unconditionally execute the subsequent rendering commands without waiting for the query to complete.
		/// </summary>
		QUERY_BY_REGION_NO_WAIT = 0x8E16,

		/// <summary>
		/// As <see cref="QUERY_WAIT"/>, but inverted behavior.
		/// </summary>
		QUERY_WAIT_INVERTED = 0x8E17,

		/// <summary>
		/// As <see cref="QUERY_NO_WAIT"/>, but inverted behavior.
		/// </summary>
		QUERY_NO_WAIT_INVERTED = 0x8E18,

		/// <summary>
		/// As <see cref="QUERY_BY_REGION_WAIT"/>, but inverted behavior.
		/// </summary>
		QUERY_BY_REGION_WAIT_INVERTED = 0x8E19,

		/// <summary>
		/// As <see cref="QUERY_BY_REGION_NO_WAIT"/>, but inverted behavior.
		/// </summary>
		QUERY_BY_REGION_NO_WAIT_INVERTED = 0x8E1A,
	}
}
