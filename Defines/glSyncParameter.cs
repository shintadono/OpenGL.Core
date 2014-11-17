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
	/// Enum for querying sync object parameters with <see cref="gl.GetSynciv"/>.
	/// </summary>
	public enum glSyncParameter : uint
	{
		/// <summary>
		/// Returns object type as <see cref="glSyncObjectType"/>.
		/// </summary>
		OBJECT_TYPE=0x9112,

		/// <summary>
		/// Returns object condition as <see cref="glSyncCondition"/>.
		/// </summary>
		SYNC_CONDITION=0x9113,

		/// <summary>
		/// Returns object status as <see cref="glSyncStatus"/>.
		/// </summary>
		SYNC_STATUS=0x9114,

		/// <summary>
		/// Returns object flags as <see cref="glSyncFlag"/>.
		/// </summary>
		SYNC_FLAGS=0x9115,
	}
}
