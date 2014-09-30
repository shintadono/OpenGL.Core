OpenGL.Core
===========

OpenGL core profile binding for C#

OpenGL.Core includes only the API of the latest OpenGL core profile. It does not, and shall never,
include functionality removed from the core profile, such as fixed-function vertex and fragment
processing.

OpenGL.Core's gl class is intented for the use with OpenGL core profile implementations.<br/>
**!!!Do not use, until a core profile rendering context is made current!!!**

* The binding is strongly type.
* Defines (e.g. GL_POLYGON_SMOOTH_HINT, GL_CCW) are sorted and encapsulated into enums. For example, the enum glErrorCode contains all error codes returned by gl.GetError and gl.GetError returns this enum.
* Functions are overloaded for different input data types. For example, texture can be loaded with gl.TexImage2D using an array of byte, sbyte, short, ushort, int, uint, long, ulong, float, or double.
* Functions are ready for 64 bit execution, pointers to client space memory can be IntPtr. Functions are overloaded for 32 and 64 bit offset and size values.
* Functions that handle/return strings, are encapsulated to use the string class instead of arrays of byte.
* The structures for the indirect drawing commands are available (glDrawArraysIndirectCommand, glDrawElementsIndirectCommand).
* A delegate for the debug callback is supplied (glDebugProc).
* A converter (glPixelFormatAdapter) and structures (UFloat11, UFloat10 and Float16) for working with packed data types are available.

**Authors**

Copyright (c) 2013-2014 The Khronos Group Inc.<br/>
Copyright (c) of C# port 2014 by Shinta <shintadono@googlemail.com><br/>
