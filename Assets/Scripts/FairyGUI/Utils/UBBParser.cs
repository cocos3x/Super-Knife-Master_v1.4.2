using System.Collections.Generic;

namespace FairyGUI.Utils
{
	public class UBBParser
	{
		public delegate string TagHandler(string tagName, bool end, string attr);

		public static UBBParser inst;

		private string _text;

		private int _readPos;

		public TagHandler defaultTagHandler;

		public Dictionary<string, TagHandler> handlers;

		public int defaultImgWidth;

		public int defaultImgHeight;

		protected string onTag_URL(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_IMG(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_Simple(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_COLOR(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_FONT(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_SIZE(string tagName, bool end, string attr)
		{
			return "";
		}

		protected string onTag_ALIGN(string tagName, bool end, string attr)
		{
			return "";
		}

		public string GetTagText(bool remove)
		{
			return "";
		}

		public string Parse(string text)
		{
			return "";
		}
	}
}
