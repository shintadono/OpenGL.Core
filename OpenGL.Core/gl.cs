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

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace OpenGL.Core
{
	/// <summary>
	/// OpenGLCore is for use with OpenGL core profile implementations.
	/// </summary>
	/// <remarks>
	/// OpenGLCore includes only APIs in the latest OpenGL core profile
	/// implementation together with APIs and newer ARB extensions which
	/// can be supported by the core profile. It does not, and never will
	/// include functionality removed from the core profile, such as
	/// fixed-function vertex and fragment processing.
	/// </remarks>
	[SuppressUnmanagedCodeSecurity()]
	public static partial class gl
	{
		#region WGL binding
		[DllImport(DLLName, CharSet=CharSet.Ansi)]
		private static extern IntPtr wglGetProcAddress(string lpszProc);

		private static TDelegate GetAddress<TDelegate>(string name) where TDelegate : class
		{
			IntPtr addr=wglGetProcAddress(name);
			if(addr==IntPtr.Zero) return null;
			return (TDelegate)(object)Marshal.GetDelegateForFunctionPointer(addr, typeof(TDelegate));
		}
		#endregion

		/// <summary>
		/// Loads the available functions of the OpenGL core profile of the currently active OpenGL context into the static delegates of <see cref="gl"/>.
		/// </summary>
		/// <remarks>
		/// The OpenGL context must be made current before and still be current when this funtion is called.
		/// </remarks>
		public static void LoadOpenGL()
		{
			Load_VERSION_1_2();
			Load_VERSION_1_3();
			Load_VERSION_1_4();
			Load_VERSION_1_5();
			Load_VERSION_2_0();
			Load_VERSION_2_1();
			Load_VERSION_3_0();
			Load_VERSION_3_1();
			Load_VERSION_3_2();
			Load_VERSION_3_3();
			Load_VERSION_4_0();
			Load_VERSION_4_1();
			Load_VERSION_4_2();
			Load_VERSION_4_3();
			Load_VERSION_4_4();
			Load_VERSION_4_5();
		}
	}
}
