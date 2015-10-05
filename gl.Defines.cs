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
	public static partial class gl
	{
		internal const string DLLName = "OPENGL32.DLL";

		const string platformErrorString = "Value to big for 32bit platform.";
		static string PlatformErrorString { get { return platformErrorString; } }

		const string platformWrongTypeErrorString = "Plattform is 64bit and value need 64bit to store, but argument is only 32bit.";
		static string PlatformWrongTypeErrorString { get { return platformWrongTypeErrorString; } }

		const string platformArrayErrorString = "A value in the array to big for 32bit platform.";
		static string PlatformArrayErrorString { get { return platformErrorString; } }

		/// <summary>
		/// Returned by <see cref="gl.GetProgramResourceIndex"/> on error.
		/// And outputted by <see cref="gl.GetUniformSubroutineuiv"/> , if location is unused.
		/// </summary>
		public const uint INVALID_INDEX = 0xFFFFFFFFu;

		/// <summary>
		/// Special timeout value for <see cref="gl.WaitSync"/>. (must be used)
		/// </summary>
		public const ulong TIMEOUT_IGNORED = 0xFFFFFFFFFFFFFFFFul;

		/// <summary>
		/// Value for <see cref="gl.VertexAttribFormat"/> and <see cref="O:gl.VertexAttribPointer"/>size argument.
		/// </summary>
		public const int BGRA = 0x80E1;

		/// <summary>
		/// For convenience: Use in places, where int is used instead of bool (GLboolean).
		/// </summary>
		public const int FALSE = 0;

		/// <summary>
		/// For convenience: Use in places, where int is used instead of bool (GLboolean).
		/// </summary>
		public const int TRUE = 1;

		/// <summary>
		/// For convenience: Can be used, in places where int is used instead of a specific enum, to avoid typecasts where unnecessary.
		/// </summary>
		public const int NONE = 0;
	}
}
