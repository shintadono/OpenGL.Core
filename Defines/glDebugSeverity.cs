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
	/// Severity of debug message.
	/// </summary>
	public enum glDebugSeverity : uint
	{
		/// <summary>
		/// Severity of debug message is high. OpenGL errors, dangerous undefined behaviour, GLSL compiler or linker errors.
		/// </summary>
		DEBUG_SEVERITY_HIGH=0x9146,

		/// <summary>
		/// Severity of debug message is medium. Severe performance warnings, GLSL compiler or linker warnings, deprecated behaviour.
		/// </summary>
		DEBUG_SEVERITY_MEDIUM=0x9147,

		/// <summary>
		/// Severity of debug message is low. Performance warnings, trival undefined behaviour.
		/// </summary>
		DEBUG_SEVERITY_LOW=0x9148,

		/// <summary>
		/// Debug message is just a message, which is not an error or performance concern.
		/// </summary>
		DEBUG_SEVERITY_NOTIFICATION=0x826B,

		/// <summary>
		/// Debug message control.
		/// </summary>
		DONT_CARE=0x1100,
	}
}
