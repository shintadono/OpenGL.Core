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

using System.Runtime.InteropServices;

namespace OpenGL.Core
{
	using Delegates;

	namespace Delegates
	{
		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2x3fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3x2fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix2x4fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4x2fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix3x4fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		/// <param name="location">The location of the uniform.</param>
		/// <param name="count">Number of matrices to be loaded. (>1 if uniform is array of matrices)</param>
		/// <param name="transpose">Set <b>true</b> if the matrix is to be transposed.</param>
		/// <param name="value">The values of the matrix.</param>
		public delegate void glUniformMatrix4x3fv(int location, int count, [MarshalAs(UnmanagedType.I1)] bool transpose, params float[] value);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 2.1 is available.
		/// </summary>
		public static bool VERSION_2_1;

		#region Delegates
		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2x3fv UniformMatrix2x3fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3x2fv UniformMatrix3x2fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix2x4fv UniformMatrix2x4fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4x2fv UniformMatrix4x2fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix3x4fv UniformMatrix3x4fv;

		/// <summary>
		/// Sets a uniform matrix value.
		/// </summary>
		public static glUniformMatrix4x3fv UniformMatrix4x3fv;
		#endregion

		private static void Load_VERSION_2_1()
		{
			UniformMatrix2x3fv=GetAddress<glUniformMatrix2x3fv>("glUniformMatrix2x3fv");
			UniformMatrix3x2fv=GetAddress<glUniformMatrix3x2fv>("glUniformMatrix3x2fv");
			UniformMatrix2x4fv=GetAddress<glUniformMatrix2x4fv>("glUniformMatrix2x4fv");
			UniformMatrix4x2fv=GetAddress<glUniformMatrix4x2fv>("glUniformMatrix4x2fv");
			UniformMatrix3x4fv=GetAddress<glUniformMatrix3x4fv>("glUniformMatrix3x4fv");
			UniformMatrix4x3fv=GetAddress<glUniformMatrix4x3fv>("glUniformMatrix4x3fv");

			VERSION_2_1=VERSION_2_0&&UniformMatrix2x3fv!=null&&UniformMatrix3x2fv!=null&&UniformMatrix2x4fv!=null&&
				UniformMatrix4x2fv!=null&&UniformMatrix3x4fv!=null&&UniformMatrix4x3fv!=null;
		}
	}
}
