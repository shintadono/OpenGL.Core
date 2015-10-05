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
		/// Binds a varying output variable to a fragment shader color number and index.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="colorNumber">The color number to bind the varying output variable to.</param>
		/// <param name="index">The index of the color input to bind the varying output variable to.</param>
		/// <param name="name">The name of the varing output variable.</param>
		public delegate void glBindFragDataLocationIndexed(uint program, uint colorNumber, uint index, string name);

		/// <summary>
		/// Returns the color indices of varying output variables.
		/// </summary>
		/// <param name="program">The name of the program.</param>
		/// <param name="name">The name of the varing output variable.</param>
		/// <returns>The color index.</returns>
		public delegate int glGetFragDataIndex(uint program, string name);

		internal delegate void glGenSampler(int one, out uint sampler);
		internal delegate void glGenSamplers(int count, uint[] samplers);

		/// <summary>
		/// Releases <paramref name="count"/> many sampler names.
		/// </summary>
		/// <param name="count">Number of sampler names to be released.</param>
		/// <param name="samplers">Array of sampler names to be released.</param>
		public delegate void glDeleteSamplers(int count, params uint[] samplers);

		/// <summary>
		/// Determines if a name is a sampler name.
		/// </summary>
		/// <param name="sampler">The maybe sampler name.</param>
		/// <returns><b>true</b> if <paramref name="sampler"/> is a sampler name.</returns>
		[return: MarshalAs(UnmanagedType.I1)]
		public delegate bool glIsSampler(uint sampler);

		/// <summary>
		/// Binds a sampler to a texturing unit.
		/// </summary>
		/// <param name="unit">The texture unit.</param>
		/// <param name="sampler">The name of the sampler.</param>
		public delegate void glBindSampler(uint unit, uint sampler);

		internal delegate void glSamplerParameteri(uint sampler, glTextureParameter pname, int param);

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glSamplerParameteriv(uint sampler, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public delegate void glSamplerParameterf(uint sampler, glTextureParameter pname, float param);

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glSamplerParameterfv(uint sampler, glTextureParameter pname, float[] @params);

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glSamplerParameterIiv(uint sampler, glTextureParameter pname, params int[] @params);

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="params">The value the parameter is set to.</param>
		public delegate void glSamplerParameterIuiv(uint sampler, glTextureParameter pname, params uint[] @params);

		internal delegate void glGetSamplerParameteri(uint sampler, glTextureParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetSamplerParameteriv(uint sampler, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetSamplerParameterIi(uint sampler, glTextureParameter pname, out int param);

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetSamplerParameterIiv(uint sampler, glTextureParameter pname, int[] @params);

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetSamplerParameterf(uint sampler, glTextureParameter pname, out float param);

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetSamplerParameterfv(uint sampler, glTextureParameter pname, float[] @params);

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetSamplerParameterIui(uint sampler, glTextureParameter pname, out uint param);

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetSamplerParameterIuiv(uint sampler, glTextureParameter pname, uint[] @params);

		/// <summary>
		/// Records the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
		/// </summary>
		/// <param name="id">The name of the query object into which to record.</param>
		/// <param name="target">Must by <see cref="glQueryTarget.TIMESTAMP"/></param>
		public delegate void glQueryCounter(uint id, glQueryTarget target);

		/// <summary>
		/// Returns the value of parameters of query objects.
		/// </summary>
		/// <param name="id">The name of the query object.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetQueryObjecti64(uint id, glQueryObjectParameter pname, out long param);

		/// <summary>
		/// Returns the value(s) of parameters of query objects.
		/// </summary>
		/// <param name="id">The name of the query object.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetQueryObjecti64v(uint id, glQueryObjectParameter pname, long[] @params);

		/// <summary>
		/// Returns the value of parameters of query objects.
		/// </summary>
		/// <param name="id">The name of the query object.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public delegate void glGetQueryObjectui64(uint id, glQueryObjectParameter pname, out ulong param);

		/// <summary>
		/// Returns the value(s) of parameters of query objects.
		/// </summary>
		/// <param name="id">The name of the query object.</param>
		/// <param name="pname">A <see cref="glQueryObjectParameter"/> specifying the parameter.</param>
		/// <param name="params">Returns the requested value(s).</param>
		public delegate void glGetQueryObjectui64v(uint id, glQueryObjectParameter pname, ulong[] @params);

		/// <summary>
		/// Sets the rate at which vertex attributes advance during instanced rendering.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="divisor">The number of instances that will pass between updates.</param>
		public delegate void glVertexAttribDivisor(uint index, uint divisor);

		/// <summary>
		/// Sets the value of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed value.</param>
		/// <param name="normalized">Set <b>true</b> if the value are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The value to set.</param>
		public delegate void glVertexAttribP1ui(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

		/// <summary>
		/// Sets the value of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed value.</param>
		/// <param name="normalized">Set <b>true</b> if the value are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The value to set.</param>
		public delegate void glVertexAttribP1uiv(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint[] value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP2ui(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP2uiv(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint[] value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP3ui(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP3uiv(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint[] value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP4ui(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint value);

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		/// <param name="index">The index of the vertex attribute.</param>
		/// <param name="type">A <see cref="glVertexAttribType"/> specifying the data type of the packed values.</param>
		/// <param name="normalized">Set <b>true</b> if the values are to be normalized on conversion to floating-point.</param>
		/// <param name="value">The values to set.</param>
		public delegate void glVertexAttribP4uiv(uint index, glVertexAttribType type, [MarshalAs(UnmanagedType.I1)] bool normalized, uint[] value);
	}

	public static partial class gl
	{
		/// <summary>
		/// Indicates if OpenGL version 3.3 is available.
		/// </summary>
		public static bool VERSION_3_3;

		#region Delegates
		/// <summary>
		/// Binds a varying output variable to a fragment shader color number and index.
		/// </summary>
		public static glBindFragDataLocationIndexed BindFragDataLocationIndexed;

		/// <summary>
		/// Returns the color indices of varying output variables.
		/// </summary>
		public static glGetFragDataIndex GetFragDataIndex;

		private static glGenSampler _GenSampler;
		private static glGenSamplers _GenSamplers;

		/// <summary>
		/// Releases multiple sampler names at once.
		/// </summary>
		public static glDeleteSamplers DeleteSamplers;

		/// <summary>
		/// Determines if a name is a sampler name.
		/// </summary>
		public static glIsSampler IsSampler;

		/// <summary>
		/// Binds a sampler to a texturing unit.
		/// </summary>
		public static glBindSampler BindSampler;

		private static glSamplerParameteri _SamplerParameteri;

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		public static glSamplerParameteriv SamplerParameteriv;

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		public static glSamplerParameterf SamplerParameterf;

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		public static glSamplerParameterfv SamplerParameterfv;

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		public static glSamplerParameterIiv SamplerParameterIiv;

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		public static glSamplerParameterIuiv SamplerParameterIuiv;

		private static glGetSamplerParameteri _GetSamplerParameteri;

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameteriv GetSamplerParameteriv;

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterIi GetSamplerParameterIi;

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterIiv GetSamplerParameterIiv;

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterf GetSamplerParameterf;

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterfv GetSamplerParameterfv;

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterIui GetSamplerParameterIui;

		/// <summary>
		/// Returns the value(s) of a texture parameter of a sampler.
		/// </summary>
		public static glGetSamplerParameterIuiv GetSamplerParameterIuiv;

		/// <summary>
		/// Records the GL time into a query object after all previous commands have reached the GL server but have not yet necessarily executed.
		/// </summary>
		public static glQueryCounter QueryCounter;

		/// <summary>
		/// Returns the value of parameters of query objects.
		/// </summary>
		public static glGetQueryObjecti64 GetQueryObjecti64;

		/// <summary>
		/// Returns the value(s) of parameters of query objects.
		/// </summary>
		public static glGetQueryObjecti64v GetQueryObjecti64v;

		/// <summary>
		/// Returns the value of parameters of query objects.
		/// </summary>
		public static glGetQueryObjectui64 GetQueryObjectui64;

		/// <summary>
		/// Returns the value(s) of parameters of query objects.
		/// </summary>
		public static glGetQueryObjectui64v GetQueryObjectui64v;

		/// <summary>
		/// Sets the rate at which vertex attributes advance during instanced rendering.
		/// </summary>
		public static glVertexAttribDivisor VertexAttribDivisor;

		/// <summary>
		/// Sets the value of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP1ui VertexAttribP1ui;

		/// <summary>
		/// Sets the value of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP1uiv VertexAttribP1uiv;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP2ui VertexAttribP2ui;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP2uiv VertexAttribP2uiv;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP3ui VertexAttribP3ui;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP3uiv VertexAttribP3uiv;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP4ui VertexAttribP4ui;

		/// <summary>
		/// Sets the values of a vertex attribute in packed form.
		/// </summary>
		public static glVertexAttribP4uiv VertexAttribP4uiv;
		#endregion

		#region Overloads
		#region GenSampler(s)
		/// <summary>
		/// Generates one sampler name and returns it.
		/// </summary>
		/// <returns>The new sampler name.</returns>
		public static uint GenSampler()
		{
			uint ret;
			_GenSampler(1, out ret);
			return ret;
		}

		/// <summary>
		/// Generates one sampler name and returns it.
		/// </summary>
		/// <param name="sampler">The new sampler name.</param>
		public static void GenSampler(out uint sampler)
		{
			_GenSampler(1, out sampler);
		}

		/// <summary>
		/// Generates <paramref name="count"/> many sampler names and returns them as array.
		/// </summary>
		/// <param name="count">The number of sampler names to be generated.</param>
		/// <returns>The new sampler names as array.</returns>
		public static uint[] GenSamplers(int count)
		{
			uint[] ret = new uint[count];
			_GenSamplers(count, ret);
			return ret;
		}

		/// <summary>
		/// Generates <paramref name="count"/> many sampler names.
		/// </summary>
		/// <param name="count">The number of sampler names to be generated.</param>
		/// <param name="samplers">The array that will receive the new sampler names.</param>
		public static void GenSamplers(int count, uint[] samplers)
		{
			_GenSamplers(count, samplers);
		}
		#endregion

		#region GetSamplerParameteri
		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetSamplerParameteri(uint sampler, glTextureParameter pname, out int param)
		{
			_GetSamplerParameteri(sampler, pname, out param);
		}

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetSamplerParameteri(uint sampler, glTextureParameter pname, out glFilter param)
		{
			int p;
			_GetSamplerParameteri(sampler, pname, out p);
			param = (glFilter)p;
		}

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> specifying the texture parameter.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetSamplerParameteri(uint sampler, glTextureParameter pname, out glTextureWrapMode param)
		{
			int p;
			_GetSamplerParameteri(sampler, pname, out p);
			param = (glTextureWrapMode)p;
		}

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetSamplerParameteri(uint sampler, glTextureParameter pname, out glTextureCompareMode param)
		{
			int p;
			_GetSamplerParameteri(sampler, pname, out p);
			param = (glTextureCompareMode)p;
		}

		/// <summary>
		/// Returns the value of a texture parameter of a sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">Returns the requested value.</param>
		public static void GetSamplerParameteri(uint sampler, glTextureParameter pname, out glFunc param)
		{
			int p;
			_GetSamplerParameteri(sampler, pname, out p);
			param = (glFunc)p;
		}
		#endregion

		#region SamplerParameteri
		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void SamplerParameteri(uint sampler, glTextureParameter pname, int param)
		{
			_SamplerParameteri(sampler, pname, param);
		}

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void SamplerParameteri(uint sampler, glTextureParameter pname, glFilter param)
		{
			_SamplerParameteri(sampler, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">A <see cref="glTextureParameter"/> selecting the parameter to be set.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void SamplerParameteri(uint sampler, glTextureParameter pname, glTextureWrapMode param)
		{
			_SamplerParameteri(sampler, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_MODE"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void SamplerParameteri(uint sampler, glTextureParameter pname, glTextureCompareMode param)
		{
			_SamplerParameteri(sampler, pname, (int)param);
		}

		/// <summary>
		/// Sets texture parameter for the sampler.
		/// </summary>
		/// <param name="sampler">The name of the sampler.</param>
		/// <param name="pname">Must be <see cref="glTextureParameter.TEXTURE_COMPARE_FUNC"/>.</param>
		/// <param name="param">The value the parameter is set to.</param>
		public static void SamplerParameteri(uint sampler, glTextureParameter pname, glFunc param)
		{
			_SamplerParameteri(sampler, pname, (int)param);
		}
		#endregion
		#endregion

		private static void Load_VERSION_3_3()
		{
			BindFragDataLocationIndexed = GetAddress<glBindFragDataLocationIndexed>("glBindFragDataLocationIndexed");
			GetFragDataIndex = GetAddress<glGetFragDataIndex>("glGetFragDataIndex");
			_GenSampler = GetAddress<glGenSampler>("glGenSamplers");
			_GenSamplers = GetAddress<glGenSamplers>("glGenSamplers");
			DeleteSamplers = GetAddress<glDeleteSamplers>("glDeleteSamplers");
			IsSampler = GetAddress<glIsSampler>("glIsSampler");
			BindSampler = GetAddress<glBindSampler>("glBindSampler");
			_SamplerParameteri = GetAddress<glSamplerParameteri>("glSamplerParameteri");
			SamplerParameteriv = GetAddress<glSamplerParameteriv>("glSamplerParameteriv");
			SamplerParameterf = GetAddress<glSamplerParameterf>("glSamplerParameterf");
			SamplerParameterfv = GetAddress<glSamplerParameterfv>("glSamplerParameterfv");
			SamplerParameterIiv = GetAddress<glSamplerParameterIiv>("glSamplerParameterIiv");
			SamplerParameterIuiv = GetAddress<glSamplerParameterIuiv>("glSamplerParameterIuiv");
			_GetSamplerParameteri = GetAddress<glGetSamplerParameteri>("glGetSamplerParameteriv");
			GetSamplerParameteriv = GetAddress<glGetSamplerParameteriv>("glGetSamplerParameteriv");
			GetSamplerParameterIi = GetAddress<glGetSamplerParameterIi>("glGetSamplerParameterIiv");
			GetSamplerParameterIiv = GetAddress<glGetSamplerParameterIiv>("glGetSamplerParameterIiv");
			GetSamplerParameterf = GetAddress<glGetSamplerParameterf>("glGetSamplerParameterfv");
			GetSamplerParameterfv = GetAddress<glGetSamplerParameterfv>("glGetSamplerParameterfv");
			GetSamplerParameterIui = GetAddress<glGetSamplerParameterIui>("glGetSamplerParameterIuiv");
			GetSamplerParameterIuiv = GetAddress<glGetSamplerParameterIuiv>("glGetSamplerParameterIuiv");
			QueryCounter = GetAddress<glQueryCounter>("glQueryCounter");
			GetQueryObjecti64 = GetAddress<glGetQueryObjecti64>("glGetQueryObjecti64v");
			GetQueryObjecti64v = GetAddress<glGetQueryObjecti64v>("glGetQueryObjecti64v");
			GetQueryObjectui64 = GetAddress<glGetQueryObjectui64>("glGetQueryObjectui64v");
			GetQueryObjectui64v = GetAddress<glGetQueryObjectui64v>("glGetQueryObjectui64v");
			VertexAttribDivisor = GetAddress<glVertexAttribDivisor>("glVertexAttribDivisor");
			VertexAttribP1ui = GetAddress<glVertexAttribP1ui>("glVertexAttribP1ui");
			VertexAttribP1uiv = GetAddress<glVertexAttribP1uiv>("glVertexAttribP1uiv");
			VertexAttribP2ui = GetAddress<glVertexAttribP2ui>("glVertexAttribP2ui");
			VertexAttribP2uiv = GetAddress<glVertexAttribP2uiv>("glVertexAttribP2uiv");
			VertexAttribP3ui = GetAddress<glVertexAttribP3ui>("glVertexAttribP3ui");
			VertexAttribP3uiv = GetAddress<glVertexAttribP3uiv>("glVertexAttribP3uiv");
			VertexAttribP4ui = GetAddress<glVertexAttribP4ui>("glVertexAttribP4ui");
			VertexAttribP4uiv = GetAddress<glVertexAttribP4uiv>("glVertexAttribP4uiv");

			VERSION_3_3 = VERSION_3_2 && BindFragDataLocationIndexed != null && GetFragDataIndex != null && _GenSamplers != null &&
				DeleteSamplers != null && IsSampler != null && BindSampler != null && _SamplerParameteri != null &&
				SamplerParameteriv != null && SamplerParameterf != null && SamplerParameterfv != null && SamplerParameterIiv != null &&
				SamplerParameterIuiv != null && GetSamplerParameteriv != null && GetSamplerParameterIiv != null &&
				GetSamplerParameterfv != null && GetSamplerParameterIuiv != null && QueryCounter != null &&
				GetQueryObjecti64v != null && GetQueryObjectui64v != null && VertexAttribDivisor != null && VertexAttribP1uiv != null &&
				VertexAttribP2uiv != null && VertexAttribP3uiv != null && VertexAttribP4uiv != null;
		}
	}
}
