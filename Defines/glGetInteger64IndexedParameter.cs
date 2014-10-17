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
	/// Value for <see cref="gl.GetInteger64i_v"/>.
	/// </summary>
	public enum glGetInteger64IndexedParameter : uint
	{
		/// <summary>
		/// Size of binding range for each (indexed) atomic counter buffer. Used <see cref="O:OpenGL.Core.gl.GetIntegerv">gl.GetIntegerv</see>
		/// for <see cref="glGetIntegerParameter.ATOMIC_COUNTER_BUFFER_BINDING"/> to get the current number of bindings.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_SIZE=0x92C3,

		/// <summary>
		/// Start offset of binding range for each (indexed) atomic counter buffer. Used by <see cref="O:OpenGL.Core.gl.GetIntegerv">gl.GetIntegerv</see> for <see cref="glGetIntegerParameter.ATOMIC_COUNTER_BUFFER_BINDING"/> to get the current number of bindings.
		/// </summary>
		ATOMIC_COUNTER_BUFFER_START=0x92C2,

		/// <summary>
		/// Size of binding range for each (indexed) shader storage buffer.
		/// </summary>
		SHADER_STORAGE_BUFFER_SIZE=0x90D5,

		/// <summary>
		/// Start offset of binding range for each (indexed) shader storage buffer.
		/// </summary>
		SHADER_STORAGE_BUFFER_START=0x90D4,

		/// <summary>
		/// Size of binding range for each (indexed) transform feedback attribute stream.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_SIZE=0x8C85,

		/// <summary>
		/// Start offset of binding range for each (indexed) transform feedback attribute stream.
		/// </summary>
		TRANSFORM_FEEDBACK_BUFFER_START=0x8C84,

		/// <summary>
		/// Size of binding range for each (indexed) uniform buffer.
		/// </summary>
		UNIFORM_BUFFER_SIZE=0x8A2A,

		/// <summary>
		/// Start offset of binding range for each (indexed) uniform buffer.
		/// </summary>
		UNIFORM_BUFFER_START=0x8A29,

		/// <summary>
		/// Byte offset of the first element in data store of the buffer bound to each (indexed) vertex binding.
		/// </summary>
		VERTEX_BINDING_OFFSET=0x82D7,
	}
}
