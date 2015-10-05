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
	/// OpenGL.Core's gl class is intented for the use with OpenGL core profile implementations.
	/// </summary>
	/// <remarks>
	/// <para>OpenGL.Core includes only the API of the latest OpenGL core profile. It does
	/// not, and never will, include functionality removed from the core profile, such as
	/// fixed-function vertex and fragment processing.</para>
	/// <para>To load OpenGL functions not available via interop binding you have call
	/// <see cref="LoadOpenGL"/> while the rendering context is made current.</para>
	/// <para>The class is currently intended to be used with Microsoft Windows OS and the
	/// Net-Framework. It uses the Win32 WGL API to load the OpenGL functions of the core
	/// profile that aren't available in Microsoft's OpenGL32.dll, which is basicly
	/// everything newer than OpenGL version 1.1. To adapt the class to a different OS and/or
	/// runtime environment you'll have to change the code at certain points if necessary.</para>
	/// <para>1. Change the name of the dll in <b>gl.DLLName</b> constant. (see gl.Defines.cs)</para>
	/// <para>2. Change the method <b>gl.GetAddress&lt;TDelegate&gt;</b> to use your function loading mechanism. (see gl.cs)</para>
	/// <para>3. Add/remove the function available via interop binding. (<b>[DllImport]</b>)</para>
	/// <para>4. Add/remove the function not available via interop binding. (loaded with <b>gl.GetAddress&lt;&gt;</b>)</para>
	/// </remarks>
	[SuppressUnmanagedCodeSecurity]
	public static partial class gl
	{
		#region WGL binding
		[DllImport(DLLName, CharSet = CharSet.Ansi)]
		private static extern IntPtr wglGetProcAddress(string lpszProc);

		private static TDelegate GetAddress<TDelegate>(string name) where TDelegate : class
		{
			IntPtr addr = wglGetProcAddress(name);
			if (addr == IntPtr.Zero) return null;
			return (TDelegate)(object)Marshal.GetDelegateForFunctionPointer(addr, typeof(TDelegate));
		}
		#endregion

		/// <summary>
		/// Loads the available functions of the OpenGL core profile of the currently active OpenGL rendering context into the static delegates of <see cref="gl"/>.
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

			Marshal.GetLastWin32Error(); // clear 127 'procedure not found' error
		}
	}
}
