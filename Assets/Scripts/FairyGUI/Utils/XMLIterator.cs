using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FairyGUI.Utils
{
	public class XMLIterator
	{
		public static string tagName;

		public static XMLTagType tagType;

		public static string lastTagName;

		private static string source;

		private static int sourceLen;

		private static int parsePos;

		private static int tagPos;

		private static int tagLength;

		private static int lastTagEnd;

		private static bool attrParsed;

		private static bool lowerCaseName;

		private static StringBuilder buffer;

		private static Dictionary<string, string> attributes;

		private const string CDATA_START = "<![CDATA[";

		private const string CDATA_END = "]]>";

		private const string COMMENT_START = "<!--";

		private const string COMMENT_END = "-->";

		public static void Begin(string source, bool lowerCaseName = false)
		{
		}

		public static bool NextTag()
		{
			return false;
		}

		public static string GetTagSource()
		{
			return "";
		}

		public static string GetRawText(bool trim = false)
		{
			return "";
		}

		public static string GetText(bool trim = false)
		{
			return "";
		}

		public static bool HasAttribute(string attrName)
		{
			return false;
		}

		public static string GetAttribute(string attrName)
		{
			return "";
		}

		public static string GetAttribute(string attrName, string defValue)
		{
			return "";
		}

		public static int GetAttributeInt(string attrName)
		{
			return 0;
		}

		public static int GetAttributeInt(string attrName, int defValue)
		{
			return 0;
		}

		public static float GetAttributeFloat(string attrName)
		{
			return 0f;
		}

		public static float GetAttributeFloat(string attrName, float defValue)
		{
			return 0f;
		}

		public static bool GetAttributeBool(string attrName)
		{
			return false;
		}

		public static bool GetAttributeBool(string attrName, bool defValue)
		{
			return false;
		}

		public static Dictionary<string, string> GetAttributes(Dictionary<string, string> result)
		{
			return null;
		}

		public static Hashtable GetAttributes(Hashtable result)
		{
			return null;
		}

		private static void ParseAttributes(IDictionary attrs)
		{
		}
	}
}
