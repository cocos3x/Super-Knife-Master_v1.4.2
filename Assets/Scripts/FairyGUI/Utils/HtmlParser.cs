using System.Collections.Generic;

namespace FairyGUI.Utils
{
	public class HtmlParser
	{
		protected class TextFormat2 : TextFormat
		{
			public bool colorChanged;
		}

		public static HtmlParser inst;

		protected List<TextFormat2> _textFormatStack;

		protected int _textFormatStackTop;

		protected TextFormat2 _format;

		protected List<HtmlElement> _elements;

		protected HtmlParseOptions _defaultOptions;

		private static List<string> sHelperList1;

		private static List<string> sHelperList2;

		public virtual void Parse(string aSource, TextFormat defaultFormat, List<HtmlElement> elements, HtmlParseOptions parseOptions)
		{
		}

		protected void PushTextFormat()
		{
		}

		protected void PopTextFormat()
		{
		}

		protected bool IsNewLine()
		{
			return false;
		}

		protected void AppendText(string text)
		{
		}
	}
}
