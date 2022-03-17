using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class RichTextField : Container
	{
		private IHtmlPageContext _003ChtmlPageContext_003Ek__BackingField;

		private HtmlParseOptions _003ChtmlParseOptions_003Ek__BackingField;

		private Dictionary<uint, Emoji> _003Cemojies_003Ek__BackingField;

		private TextField _003CtextField_003Ek__BackingField;

		public IHtmlPageContext htmlPageContext
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public HtmlParseOptions htmlParseOptions
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Dictionary<uint, Emoji> emojies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextField textField
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public virtual string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual string htmlText
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual TextFormat textFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int htmlElementCount => 0;

		public HtmlElement GetHtmlElement(string name)
		{
			return null;
		}

		public HtmlElement GetHtmlElementAt(int index)
		{
			return null;
		}

		public void ShowHtmlObject(int index, bool show)
		{
		}

		public override void EnsureSizeCorrect()
		{
		}

		protected override void OnSizeChanged()
		{
		}

		public override void Update(UpdateContext context)
		{
		}

		public override void Dispose()
		{
		}

		internal void CleanupObjects()
		{
		}

		internal virtual void RefreshObjects()
		{
		}
	}
}
