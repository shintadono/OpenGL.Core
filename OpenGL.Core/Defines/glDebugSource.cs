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
	/// Source of debug message.
	/// </summary>
	public enum glDebugSource : uint
	{
		/// <summary>
		/// Message from OpenGL.
		/// </summary>
		DEBUG_SOURCE_API=0x8246,

		/// <summary>
		/// Message from the window system.
		/// </summary>
		DEBUG_SOURCE_WINDOW_SYSTEM=0x8247,

		/// <summary>
		/// Message from the shader compiler.
		/// </summary>
		DEBUG_SOURCE_SHADER_COMPILER=0x8248,

		/// <summary>
		/// Message from the third-party middleware or external debuggers.
		/// </summary>
		DEBUG_SOURCE_THIRD_PARTY=0x8249,

		/// <summary>
		/// Message from the application.
		/// </summary>
		DEBUG_SOURCE_APPLICATION=0x824A,

		/// <summary>
		/// Message from the other sources.
		/// </summary>
		DEBUG_SOURCE_OTHER=0x824B,

		/// <summary>
		/// Debug message control.
		/// </summary>
		DONT_CARE=0x1100,
	}
}
