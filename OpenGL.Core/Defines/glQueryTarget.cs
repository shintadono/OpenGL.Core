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
	/// Target for query operations.
	/// </summary>
	public enum glQueryTarget : uint
	{
		/// <summary>
		/// No query target set yet. Only returned as value by <b>gl.GetQueryObjecti(v)</b> with <see cref="glQueryObjectParameter.QUERY_TARGET"/>.
		/// </summary>
		NONE=0,

		/// <summary>
		/// Number of samples passed in occlusion query.
		/// </summary>
		SAMPLES_PASSED=0x8914,
		
		/// <summary>
		/// 1 if number of samples passed is non-zero in an occlusion query.
		/// </summary>
		ANY_SAMPLES_PASSED=0x8C2F,
		
		/// <summary>
		/// 1 if number of samples passed is non-zero in an (implementation-dependent less precise version of an) occlusion query.
		/// </summary>
		ANY_SAMPLES_PASSED_CONSERVATIVE=0x8D6A,

		/// <summary>
		/// Timer query.
		/// </summary>
		TIME_ELAPSED=0x88BF,

		/// <summary>
		/// Number of primitives processed in a primitive query.
		/// </summary>
		PRIMITIVES_GENERATED=0x8C87,

		/// <summary>
		/// Number of primitives written to feedback buffer in a primitive query.
		/// </summary>
		TRANSFORM_FEEDBACK_PRIMITIVES_WRITTEN=0x8C88,

		/// <summary>
		/// Timer query.
		/// </summary>
		TIMESTAMP=0x8E28,
	}
}
