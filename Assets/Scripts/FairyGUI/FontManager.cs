using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace FairyGUI
{
	public class FontManager
	{
		public static Dictionary<string, BaseFont> sFontFactory;

		public static void RegisterFont(BaseFont font, [Optional] string alias)
		{
		}

		public static void UnregisterFont(BaseFont font)
		{
		}

		public static BaseFont GetFont(string name)
		{
			return null;
		}

		private static BaseFont Fallback(string name)
		{
			return null;
		}

		public static void Clear()
		{
		}
	}
}
