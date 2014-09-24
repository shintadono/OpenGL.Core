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
	/// Type of debug message.
	/// </summary>
	public enum glDebugType : uint
	{
		/// <summary>
		/// Events that generated an error.
		/// </summary>
		DEBUG_TYPE_ERROR=0x824C,

		/// <summary>
		/// Behavior that has been marked for deprecation.
		/// </summary>
		DEBUG_TYPE_DEPRECATED_BEHAVIOR=0x824D,

		/// <summary>
		/// Behavior that is undefined according to the specification.
		/// </summary>
		DEBUG_TYPE_UNDEFINED_BEHAVIOR=0x824E,

		/// <summary>
		/// Implementation-dependent performance warnings.
		/// </summary>
		DEBUG_TYPE_PERFORMANCE=0x8250,

		/// <summary>
		/// Use of extensions or shaders in a way that is highly vendor-specific.
		/// </summary>
		DEBUG_TYPE_PORTABILITY=0x824F,

		/// <summary>
		/// Annotation of the command stream.
		/// </summary>
		DEBUG_TYPE_MARKER=0x8268,

		/// <summary>
		/// Entering a debug group.
		/// </summary>
		DEBUG_TYPE_PUSH_GROUP=0x8269,

		/// <summary>
		/// Leave a debug group.
		/// </summary>
		DEBUG_TYPE_POP_GROUP=0x826A,

		/// <summary>
		/// Types of events that do not fit any of the ones listed above.
		/// </summary>
		DEBUG_TYPE_OTHER=0x8251,

		/// <summary>
		/// Debug message control.
		/// </summary>
		DONT_CARE=0x1100,
	}
}
