using System;

namespace OpenGL.Core
{
	/// <summary>
	/// Static class for converting pixel formats (from and to packed pixel formats).
	/// </summary>
	public static class glPixelFormatAdapter
	{
		#region Lookup tables
		static readonly byte[] To4Bits =
		{
			0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2,
			2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6,
			6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9,
			9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11, 11,
			11, 11, 11, 11, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13, 13,
			13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15, 15
		};

		static readonly byte[] To5Bits =
		{
			0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 3, 3, 3, 4, 4, 4,
			4, 4, 4, 4, 4, 4, 5, 5, 5, 5, 5, 5, 5, 5, 6, 6, 6, 6, 6, 6, 6, 6, 7, 7, 7, 7, 7, 7, 7, 7, 8, 8,
			8, 8, 8, 8, 8, 8, 9, 9, 9, 9, 9, 9, 9, 9, 9, 10, 10, 10, 10, 10, 10, 10, 10, 11, 11, 11, 11, 11, 11, 11, 11, 12,
			12, 12, 12, 12, 12, 12, 12, 13, 13, 13, 13, 13, 13, 13, 13, 13, 14, 14, 14, 14, 14, 14, 14, 14, 15, 15, 15, 15, 15, 15, 15, 15,
			16, 16, 16, 16, 16, 16, 16, 16, 17, 17, 17, 17, 17, 17, 17, 17, 18, 18, 18, 18, 18, 18, 18, 18, 18, 19, 19, 19, 19, 19, 19, 19,
			19, 20, 20, 20, 20, 20, 20, 20, 20, 21, 21, 21, 21, 21, 21, 21, 21, 22, 22, 22, 22, 22, 22, 22, 22, 22, 23, 23, 23, 23, 23, 23,
			23, 23, 24, 24, 24, 24, 24, 24, 24, 24, 25, 25, 25, 25, 25, 25, 25, 25, 26, 26, 26, 26, 26, 26, 26, 26, 27, 27, 27, 27, 27, 27,
			27, 27, 27, 28, 28, 28, 28, 28, 28, 28, 28, 29, 29, 29, 29, 29, 29, 29, 29, 30, 30, 30, 30, 30, 30, 30, 30, 31, 31, 31, 31, 31
		};

		static readonly byte[] To6Bits =
		{
			0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8,
			8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13, 14, 14, 14, 14, 15, 15, 15, 15, 16,
			16, 16, 16, 17, 17, 17, 17, 18, 18, 18, 18, 19, 19, 19, 19, 20, 20, 20, 20, 21, 21, 21, 21, 21, 22, 22, 22, 22, 23, 23, 23, 23,
			24, 24, 24, 24, 25, 25, 25, 25, 26, 26, 26, 26, 27, 27, 27, 27, 28, 28, 28, 28, 29, 29, 29, 29, 30, 30, 30, 30, 31, 31, 31, 31,
			32, 32, 32, 32, 33, 33, 33, 33, 34, 34, 34, 34, 35, 35, 35, 35, 36, 36, 36, 36, 37, 37, 37, 37, 38, 38, 38, 38, 39, 39, 39, 39,
			40, 40, 40, 40, 41, 41, 41, 41, 42, 42, 42, 42, 42, 43, 43, 43, 43, 44, 44, 44, 44, 45, 45, 45, 45, 46, 46, 46, 46, 47, 47, 47,
			47, 48, 48, 48, 48, 49, 49, 49, 49, 50, 50, 50, 50, 51, 51, 51, 51, 52, 52, 52, 52, 53, 53, 53, 53, 54, 54, 54, 54, 55, 55, 55,
			55, 56, 56, 56, 56, 57, 57, 57, 57, 58, 58, 58, 58, 59, 59, 59, 59, 60, 60, 60, 60, 61, 61, 61, 61, 62, 62, 62, 62, 63, 63, 63
		};
		#endregion

		#region UNSIGNED_BYTE_3_3_2
		/// <summary>
		/// Packs color values (RGB) in the range [0, 1] into one <b>byte</b>, as 3 bit for each red and green, and 2 bit for blue.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>byte</b> containing the packed color values.</returns>
		public static byte To_UnsignedByte_3_3_2(float red, float green, float blue)
		{
			byte r = (byte)(red * 7 + 0.5);
			byte g = (byte)(green * 7 + 0.5);
			byte b = (byte)(blue * 3 + 0.5);
			return (byte)((r << 5) | (g << 2) | b);
		}

		/// <summary>
		/// Packs color values (RGB) in the range [0, 255] into one <b>byte</b>, as 3 bit for each red and green, and 2 bit for blue.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>byte</b> containing the packed color values.</returns>
		public static byte To_UnsignedByte_3_3_2(byte red, byte green, byte blue)
		{
			byte ret = 0;

			if (red >= 19) ret = 0x20;
			else if (red >= 55) ret = 0x40;
			else if (red >= 92) ret = 0x60;
			else if (red >= 128) ret = 0x80;
			else if (red >= 164) ret = 0xA0;
			else if (red >= 201) ret = 0xC0;
			else if (red >= 237) ret = 0xE0;

			if (green >= 19) ret |= 0x04;
			else if (green >= 55) ret |= 0x08;
			else if (green >= 92) ret |= 0x0C;
			else if (green >= 128) ret |= 0x10;
			else if (green >= 164) ret |= 0x14;
			else if (green >= 201) ret |= 0x18;
			else if (green >= 237) ret |= 0x1C;

			if (blue >= 43) ret |= 0x01;
			else if (blue >= 128) ret |= 0x02;
			else if (blue >= 213) ret |= 0x03;

			return ret;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>byte</b>, with 3 bit for each red and green, and 2 bit for blue.
		/// </summary>
		/// <param name="value">The <b>byte</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedByte_3_3_2(byte value, out float red, out float green, out float blue)
		{
			red = (value & 0xE0) / 224f;
			green = (value & 0x1C) / 28f;
			blue = (value & 0x3) / 3f;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>byte</b>, with 3 bit for each red and green, and 2 bit for blue.
		/// </summary>
		/// <param name="value">The <b>byte</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedByte_3_3_2(byte value, out byte red, out byte green, out byte blue)
		{
			red = (byte)(value & 0xE0);
			red |= (byte)((red >> 3) | (red >> 6));
			green = (byte)((value & 0x1C) << 3);
			green |= (byte)((green >> 3) | (green >> 6));
			blue = (byte)((value & 0x3) * 17);
		}
		#endregion

		#region UNSIGNED_BYTE_2_3_3_REV
		/// <summary>
		/// Packs color values (RGB) in the range [0, 1] into one <b>byte</b>, as 3 bit for each red and green, and 2 bit for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>byte</b> containing the packed color values. (Reversed order of components)</returns>
		public static byte To_UnsignedByte_2_3_3_Rev(float red, float green, float blue)
		{
			byte r = (byte)(red * 7 + 0.5);
			byte g = (byte)(green * 7 + 0.5);
			byte b = (byte)(blue * 3 + 0.5);
			return (byte)((b << 6) | (g << 3) | r);
		}

		/// <summary>
		/// Packs color values (RGB) in the range [0, 255] into one <b>byte</b>, as 3 bit for each red and green, and 2 bit for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>byte</b> containing the packed color values. (Reversed order of components.)</returns>
		public static byte To_UnsignedByte_2_3_3_Rev(byte red, byte green, byte blue)
		{
			byte ret = 0;

			if (red >= 19) ret = 0x01;
			else if (red >= 55) ret = 0x02;
			else if (red >= 92) ret = 0x03;
			else if (red >= 128) ret = 0x04;
			else if (red >= 164) ret = 0x05;
			else if (red >= 201) ret = 0x06;
			else if (red >= 237) ret = 0x07;

			if (green >= 19) ret |= 0x08;
			else if (green >= 55) ret |= 0x10;
			else if (green >= 92) ret |= 0x18;
			else if (green >= 128) ret |= 0x20;
			else if (green >= 164) ret |= 0x28;
			else if (green >= 201) ret |= 0x30;
			else if (green >= 237) ret |= 0x38;

			if (blue >= 43) ret |= 0x40;
			else if (blue >= 128) ret |= 0x80;
			else if (blue >= 213) ret |= 0xC0;

			return ret;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>byte</b>, with 3 bit for each red and green, and 2 bit for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>byte</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedByte_2_3_3_Rev(byte value, out float red, out float green, out float blue)
		{
			red = (value & 0x7) / 7f;
			green = (value & 0x38) / 56f;
			blue = (value & 0xC0) / 192f;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>byte</b>, with 3 bit for each red and green, and 2 bit for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>byte</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedByte_2_3_3_Rev(byte value, out byte red, out byte green, out byte blue)
		{
			red = (byte)((value & 0x7) << 5);
			red |= (byte)((red >> 3) | (red >> 6));
			green = (byte)((value & 0x38) << 2);
			green |= (byte)((green >> 3) | (green >> 6));
			blue = (byte)((value & 0xC0 >> 6) * 17);
		}
		#endregion

		#region UNSIGNED_SHORT_5_6_5
		/// <summary>
		/// Packs color values (RGB) in the range [0, 1] into one <b>ushort</b>, as 5 bit for each red and blue, and 6 bit for green.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_5_6_5(float red, float green, float blue)
		{
			byte r = (byte)(red * 31 + 0.5);
			byte g = (byte)(green * 63 + 0.5);
			byte b = (byte)(blue * 31 + 0.5);
			return (ushort)((r << 11) | (g << 5) | b);
		}

		/// <summary>
		/// Packs color values (RGB) in the range [0, 255] into one <b>ushort</b>, as 5 bit for each red and blue, and 6 bit for green.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_5_6_5(byte red, byte green, byte blue)
		{
			return (ushort)((To5Bits[red] << 11) | (To6Bits[green] << 5) | To5Bits[blue]);
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>ushort</b>, with 5 bit for each red and blue, and 6 bit for green.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_5_6_5(ushort value, out float red, out float green, out float blue)
		{
			red = (value & 0xF800) / 63488f;
			green = (value & 0x07E0) / 2016f;
			blue = (value & 0x001F) / 31f;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>ushort</b>, with 5 bit for each red and blue, and 6 bit for green.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_5_6_5(ushort value, out byte red, out byte green, out byte blue)
		{
			red = (byte)((value & 0xF800) >> 8);
			red |= (byte)(red >> 5);
			green = (byte)((value & 0x07E0) >> 3);
			green |= (byte)(green >> 6);
			blue = (byte)((value & 0x001F) << 3);
			blue |= (byte)(blue >> 5);
		}
		#endregion

		#region UNSIGNED_SHORT_5_6_5_REV
		/// <summary>
		/// Packs color values (RGB) in the range [0, 1] into one <b>ushort</b>, as 5 bit for each red and blue, and 6 bit for green. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_5_6_5_Rev(float red, float green, float blue)
		{
			byte r = (byte)(red * 31 + 0.5);
			byte g = (byte)(green * 63 + 0.5);
			byte b = (byte)(blue * 31 + 0.5);
			return (ushort)((b << 11) | (g << 5) | r);
		}

		/// <summary>
		/// Packs color values (RGB) in the range [0, 255] into one <b>ushort</b>, as 5 bit for each red and blue, and 6 bit for green. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_5_6_5_Rev(byte red, byte green, byte blue)
		{
			return (ushort)((To5Bits[blue] << 11) | (To6Bits[green] << 5) | To5Bits[red]);
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>ushort</b>, with 5 bit for each red and blue, and 6 bit for green. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_5_6_5_Rev(ushort value, out float red, out float green, out float blue)
		{
			red = (value & 0x001F) / 31f;
			green = (value & 0x07E0) / 2016f;
			blue = (value & 0xF800) / 63488f;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>ushort</b>, with 5 bit for each red and blue, and 6 bit for green. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_5_6_5_Rev(ushort value, out byte red, out byte green, out byte blue)
		{
			red = (byte)((value & 0x001F) << 3);
			red |= (byte)(red >> 5);
			green = (byte)((value & 0x07E0) >> 3);
			green |= (byte)(green >> 6);
			blue = (byte)((value & 0xF800) >> 8);
			blue |= (byte)(blue >> 5);
		}
		#endregion

		#region UNSIGNED_SHORT_4_4_4_4
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>ushort</b>, as 4 bit for each red, green, blue and alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_4_4_4_4(float red, float green, float blue, float alpha)
		{
			byte r = (byte)(red * 15 + 0.5);
			byte g = (byte)(green * 15 + 0.5);
			byte b = (byte)(blue * 15 + 0.5);
			byte a = (byte)(alpha * 15 + 0.5);
			return (ushort)((r << 12) | (g << 8) | (b << 4) | a);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 255] into one <b>ushort</b>, as 4 bit for each red, green, blue and alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_4_4_4_4(byte red, byte green, byte blue, byte alpha)
		{
			return (ushort)((To4Bits[red] << 12) | (To4Bits[green] << 8) | (To4Bits[blue] << 4) | To4Bits[alpha]);
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 4 bit for each red, green, blue and alpha.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_4_4_4_4(ushort value, out float red, out float green, out float blue, out float alpha)
		{
			red = (value & 0xF000) / 61440f;
			green = (value & 0x0F00) / 3840f;
			blue = (value & 0x00F0) / 240f;
			alpha = (value & 0x000F) / 15f;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 4 bit for each red, green, blue and alpha.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="alpha">Returns the alpha value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_4_4_4_4(ushort value, out byte red, out byte green, out byte blue, out byte alpha)
		{
			red = (byte)((value & 0xF000) >> 12);
			red |= (byte)(red << 4);
			green = (byte)((value & 0x0F00) >> 8);
			green |= (byte)(green << 4);
			blue = (byte)((value & 0x00F0) >> 4);
			blue |= (byte)(blue << 4);
			alpha = (byte)(value & 0x000F);
			alpha |= (byte)(alpha << 4);
		}
		#endregion

		#region UNSIGNED_SHORT_4_4_4_4_REV
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>ushort</b>, as 4 bit for each red, green, blue and alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_4_4_4_4_Rev(float red, float green, float blue, float alpha)
		{
			byte r = (byte)(red * 15 + 0.5);
			byte g = (byte)(green * 15 + 0.5);
			byte b = (byte)(blue * 15 + 0.5);
			byte a = (byte)(alpha * 15 + 0.5);
			return (ushort)((a << 12) | (b << 8) | (g << 4) | r);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 255] into one <b>ushort</b>, as 4 bit for each red, green, blue and alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_4_4_4_4_Rev(byte red, byte green, byte blue, byte alpha)
		{
			return (ushort)((To4Bits[alpha] << 12) | (To4Bits[blue] << 8) | (To4Bits[green] << 4) | To4Bits[red]);
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 4 bit for each red, green, blue and alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_4_4_4_4_Rev(ushort value, out float red, out float green, out float blue, out float alpha)
		{
			red = (value & 0x000F) / 15f;
			green = (value & 0x00F0) / 240f;
			blue = (value & 0x0F00) / 3840f;
			alpha = (value & 0xF000) / 61440f;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 4 bit for each red, green, blue and alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="alpha">Returns the alpha value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_4_4_4_4_Rev(ushort value, out byte red, out byte green, out byte blue, out byte alpha)
		{
			red = (byte)(value & 0x000F);
			red |= (byte)(red << 4);
			green = (byte)((value & 0x00F0) >> 4);
			green |= (byte)(green << 4);
			blue = (byte)((value & 0x0F00) >> 8);
			blue |= (byte)(blue << 4);
			alpha = (byte)((value & 0xF000) >> 12);
			alpha |= (byte)(alpha << 4);
		}
		#endregion

		#region UNSIGNED_SHORT_5_5_5_1
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>ushort</b>, as 5 bit for each red, green and blue, and 1 bit for alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_5_5_5_1(float red, float green, float blue, float alpha)
		{
			byte r = (byte)(red * 31 + 0.5);
			byte g = (byte)(green * 31 + 0.5);
			byte b = (byte)(blue * 31 + 0.5);
			byte a = (byte)(alpha + 0.5);
			return (ushort)((r << 11) | (g << 6) | (b << 1) | a);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 255] into one <b>ushort</b>, as 5 bit for each red, green and blue, and 1 bit for alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values.</returns>
		public static ushort To_UnsignedShort_5_5_5_1(byte red, byte green, byte blue, byte alpha)
		{
			return (ushort)((To5Bits[red] << 11) | (To5Bits[green] << 6) | (To5Bits[blue] << 1) | (alpha >> 7));
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 5 bit for each red, green and blue, and 1 bit for alpha.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_5_5_5_1(ushort value, out float red, out float green, out float blue, out float alpha)
		{
			red = (value & 0xF800) / 63488f;
			green = (value & 0x07C0) / 1984f;
			blue = (value & 0x003E) / 62f;
			alpha = value & 1;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 5 bit for each red, green and blue, and 1 bit for alpha.
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="alpha">Returns the alpha value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_5_5_5_1(ushort value, out byte red, out byte green, out byte blue, out byte alpha)
		{
			red = (byte)((value & 0xF800) >> 8);
			red |= (byte)(red >> 5);
			green = (byte)((value & 0x07C0) >> 3);
			green |= (byte)(green >> 5);
			blue = (byte)((value & 0x003E) << 2);
			blue |= (byte)(blue >> 5);
			alpha = (byte)((value & 1) != 0 ? 255 : 0);
		}
		#endregion

		#region UNSIGNED_SHORT_1_5_5_5_REV
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>ushort</b>, as 5 bit for each red, green and blue, and 1 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_1_5_5_5_Rev(float red, float green, float blue, float alpha)
		{
			byte r = (byte)(red * 31 + 0.5);
			byte g = (byte)(green * 31 + 0.5);
			byte b = (byte)(blue * 31 + 0.5);
			byte a = (byte)(alpha + 0.5);
			return (ushort)((a << 15) | (b << 10) | (g << 5) | r);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 255] into one <b>ushort</b>, as 5 bit for each red, green and blue, and 1 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>ushort</b> containing the packed color values. (Reversed order of components.)</returns>
		public static ushort To_UnsignedShort_1_5_5_5_Rev(byte red, byte green, byte blue, byte alpha)
		{
			return (ushort)(((alpha & 0x80) << 8) | (To5Bits[blue] << 10) | (To5Bits[green] << 5) | To5Bits[red]);
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 5 bit for each red, green and blue, and 1 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedShort_1_5_5_5_Rev(ushort value, out float red, out float green, out float blue, out float alpha)
		{
			alpha = (value & 0x8000) != 0 ? 1 : 0;
			blue = (value & 0x7C00) / 31744f;
			green = (value & 0x03E0) / 992f;
			red = (value & 0x001F) / 31f;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>ushort</b>, with 5 bit for each red, green and blue, and 1 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>ushort</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="green">Returns the green color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="blue">Returns the blue color value as <b>byte</b> in the range [0, 255].</param>
		/// <param name="alpha">Returns the alpha value as <b>byte</b> in the range [0, 255].</param>
		public static void From_UnsignedShort_1_5_5_5_Rev(ushort value, out byte red, out byte green, out byte blue, out byte alpha)
		{
			alpha = (byte)((value & 0x8000) != 0 ? 255 : 0);
			blue = (byte)((value & 0x7C00) << 7);
			blue |= (byte)(blue >> 5);
			green = (byte)((value & 0x03E0) >> 2);
			green |= (byte)(green >> 5);
			red = (byte)((value & 0x001F) << 3);
			red |= (byte)(red >> 5);
		}
		#endregion

		#region UNSIGNED_INT_10_10_10_2
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>uint</b>, as 10 bit for each red, green and blue, and 2 bit for alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>uint</b> containing the packed color values.</returns>
		public static uint To_UnsignedInt_10_10_10_2(float red, float green, float blue, float alpha)
		{
			uint r = (uint)(red * 1023 + 0.5);
			uint g = (uint)(green * 1023 + 0.5);
			uint b = (uint)(blue * 1023 + 0.5);
			uint a = (uint)(alpha * 3 + 0.5);
			return (uint)((r << 22) | (g << 12) | (b << 2) | a);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 65535] into one <b>uint</b>, as 10 bit for each red, green and blue, and 2 bit for alpha.
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>uint</b> containing the packed color values.</returns>
		public static uint To_UnsignedInt_10_10_10_2(ushort red, ushort green, ushort blue, ushort alpha)
		{
			return To_UnsignedInt_10_10_10_2(red / 65535f, green / 65535f, blue / 65535f, alpha / 65535f); // the arrays would be gigantic and integer arthimetic would be messy, so lets use the float case.
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>uint</b>, with 10 bit for each red, green and blue, and 2 bit for alpha.
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedInt_10_10_10_2(uint value, out float red, out float green, out float blue, out float alpha)
		{
			red = (value & 0xFFC00000) / 4290772992f;
			green = (value & 0x003FF000) / 4190208f;
			blue = (value & 0x00000FFC) / 4092f;
			alpha = (value & 0x00000003) / 3f;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>uint</b>, with 10 bit for each red, green and blue, and 2 bit for alpha.
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values.</param>
		/// <param name="red">Returns the red color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="green">Returns the green color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="blue">Returns the blue color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="alpha">Returns the alpha value as <b>ushort</b> in the range [0, 65535].</param>
		public static void From_UnsignedInt_10_10_10_2(uint value, out ushort red, out ushort green, out ushort blue, out ushort alpha)
		{
			red = (ushort)((value & 0xFFC00000) >> 16);
			red |= (ushort)(red >> 10);
			green = (ushort)((value & 0x003FF000) >> 6);
			green |= (ushort)(green >> 10);
			blue = (ushort)((value & 0x00000FFC) << 4);
			blue |= (ushort)(blue >> 10);
			alpha = (ushort)(0x5555 * (value & 3));
		}
		#endregion

		#region UNSIGNED_INT_2_10_10_10_REV
		/// <summary>
		/// Packs color values (RGBA) in the range [0, 1] into one <b>uint</b>, as 10 bit for each red, green and blue, and 2 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>uint</b> containing the packed color values. (Reversed order of components.)</returns>
		public static uint To_UnsignedInt_2_10_10_10_Rev(float red, float green, float blue, float alpha)
		{
			uint r = (uint)(red * 1023 + 0.5);
			uint g = (uint)(green * 1023 + 0.5);
			uint b = (uint)(blue * 1023 + 0.5);
			uint a = (uint)(alpha * 3 + 0.5);
			return (uint)((a << 30) | (b << 20) | (g << 10) | r);
		}

		/// <summary>
		/// Packs color values (RGBA) in the range [0, 65535] into one <b>uint</b>, as 10 bit for each red, green and blue, and 2 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <param name="alpha">The alpha value.</param>
		/// <returns>The <b>uint</b> containing the packed color values. (Reversed order of components.)</returns>
		public static uint To_UnsignedInt_2_10_10_10_Rev(ushort red, ushort green, ushort blue, ushort alpha)
		{
			return To_UnsignedInt_2_10_10_10_Rev(red / 65535f, green / 65535f, blue / 65535f, alpha / 65535f); // the arrays would be gigantic and integer arthimetic would be messy, so lets use the float case.
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>uint</b>, with 10 bit for each red, green and blue, and 2 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="alpha">Returns the alpha value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedInt_2_10_10_10_Rev(uint value, out float red, out float green, out float blue, out float alpha)
		{
			alpha = (value & 0xC0000000) / 3221225472f;
			blue = (value & 0x3FF00000) / 1072693248f;
			green = (value & 0x000FFC00) / 1047552f;
			red = (value & 0x000003FF) / 1023f;
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>uint</b>, with 10 bit for each red, green and blue, and 2 bit for alpha. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="green">Returns the green color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="blue">Returns the blue color value as <b>ushort</b> in the range [0, 65535].</param>
		/// <param name="alpha">Returns the alpha value as <b>ushort</b> in the range [0, 65535].</param>
		public static void From_UnsignedInt_2_10_10_10_Rev(uint value, out ushort red, out ushort green, out ushort blue, out ushort alpha)
		{
			alpha = (ushort)(0x5555 * ((value & 0xC0000000) >> 30));
			blue = (ushort)((value & 0x3FF00000) >> 14);
			blue |= (ushort)(blue >> 10);
			green = (ushort)((value & 0x000FFC00) >> 4);
			green |= (ushort)(green >> 10);
			red = (ushort)((value & 0x000003FF) << 6);
			red |= (ushort)(red >> 10);
		}
		#endregion

		#region UNSIGNED_INT_24_8
		/// <summary>
		/// Packs a 24 bit z (depth) value and a 8 bit stencil value into one <b>uint</b>.
		/// </summary>
		/// <param name="z24">The depth value.</param>
		/// <param name="stencil">The stencil value.</param>
		/// <returns>The <b>uint</b> containing the packed values.</returns>
		public static uint To_UnsignedInt_24_8(uint z24, byte stencil)
		{
			return (uint)((z24 << 8) | stencil);
		}

		/// <summary>
		/// Unpacks the 24 bit z (depth) value and a 8 bit stencil value from a packed <b>uint</b>.
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed values.</param>
		/// <param name="z24">Returns the depth value. [0, 16777215]</param>
		/// <param name="stencil">Returns the stencil value. [0, 255]</param>
		public static void From_UnsignedInt_24_8(uint value, out uint z24, out byte stencil)
		{
			z24 = value >> 8;
			stencil = (byte)value;
		}
		#endregion

		#region UNSIGNED_INT_10F_11F_11F_REV
		/// <summary>
		/// Packs color values (RGB) in the range [0, 1] into one <b>uint</b>, as 11 bit unsigned float for each red and green, and 10 bit unsigned float for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>uint</b> containing the packed color values.</returns>
		public static uint To_UnsignedInt_10f_11f_11f_Rev(float red, float green, float blue)
		{
			glUFloat11 r = new glUFloat11(red);
			glUFloat11 g = new glUFloat11(green);
			glUFloat10 b = new glUFloat10(blue);
			return ((uint)b.Value << 22) | ((uint)g.Value << 11) | r.Value;
		}

		/// <summary>
		/// Unpacks the color values (RGB) from a packed <b>uint</b>, with 11 bit unsigned float for each red and green, and 10 bit unsigned float for blue. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 1].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 1].</param>
		public static void From_UnsignedInt_10f_11f_11f_Rev(uint value, out float red, out float green, out float blue)
		{
			glUFloat10 f10;
			glUFloat11 f11;
			f11.Value = (ushort)value; red = f11;
			value >>= 11;
			f11.Value = (ushort)value; green = f11;
			value >>= 11;
			f10.Value = (ushort)value; blue = f10;
		}
		#endregion

		#region UNSIGNED_INT_5_9_9_9_REV
		/// <summary>
		/// Packs color values (RGB) in the range [0, 65408] into one <b>uint</b>, as 9 bit unsigned float with shared exponent for each red, green and blue. (Reversed order of components.)
		/// </summary>
		/// <param name="red">The red color value.</param>
		/// <param name="green">The green color value.</param>
		/// <param name="blue">The blue color value.</param>
		/// <returns>The <b>uint</b> containing the packed color values.</returns>
		public static uint To_UnsignedInt_5_9_9_9_Rev(float red, float green, float blue)
		{
			red = Math.Max(0, Math.Min(65408, red));
			green = Math.Max(0, Math.Min(65408, green));
			blue = Math.Max(0, Math.Min(65408, blue));

			float maxc = Math.Max(red, Math.Max(green, blue));
			int exp = Math.Max(0, (int)Math.Log(maxc, 2) + 16);

			int maxs = (int)(maxc / Math.Pow(2, exp - 24) + 0.5);
			if (maxs >= 512) exp++;

			int r = (int)(red / Math.Pow(2, exp - 24) + 0.5);
			int g = (int)(green / Math.Pow(2, exp - 24) + 0.5);
			int b = (int)(blue / Math.Pow(2, exp - 24) + 0.5);

			return (uint)((exp << 27) | (b << 18) | (g << 9) | r);
		}

		/// <summary>
		/// Unpacks the color values (RGBA) from a packed <b>uint</b>, with 9 bit unsigned float with shared exponent for each red, green and blue. (Reversed order of components.)
		/// </summary>
		/// <param name="value">The <b>uint</b> containing the packed color values. (Reversed order of components.)</param>
		/// <param name="red">Returns the red color value as <b>float</b> in the range [0, 65408].</param>
		/// <param name="green">Returns the green color value as <b>float</b> in the range [0, 65408].</param>
		/// <param name="blue">Returns the blue color value as <b>float</b> in the range [0, 65408].</param>
		public static void From_UnsignedInt_5_9_9_9_Rev(uint value, out float red, out float green, out float blue)
		{
			float exp = (float)Math.Pow(2, (value & 0xF8000000) >> 27 - 24);
			red = (value & 0x000001FF) * exp;
			green = ((value & 0x0003FE00) >> 9) * exp;
			blue = ((value & 0x07FC0000) >> 18) * exp;
		}
		#endregion
	}
}
