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
	/// Parameter of query objects state queries.
	/// </summary>
	public enum glQueryObjectParameter : uint
	{
		/// <summary>
		/// Returns the query result.
		/// </summary>
		QUERY_RESULT=0x8866,

		/// <summary>
		/// Returns <b>true</b>, if the query result is available.
		/// </summary>
		QUERY_RESULT_AVAILABLE=0x8867,

		/// <summary>
		/// Returns the query result, or nothing, if query result is not (yet) available.
		/// </summary>
		QUERY_RESULT_NO_WAIT=0x9194,

		/// <summary>
		/// Returns the target of the query object.
		/// </summary>
		QUERY_TARGET=0x82EA,
	}
}
