using UnityEngine;

namespace FairyGUI.Utils
{
	public class HtmlInput : IHtmlObject
	{
		private GTextInput _003CtextInput_003Ek__BackingField;

		private RichTextField _owner;

		private HtmlElement _element;

		private bool _hidden;

		public static int defaultBorderSize;

		public static Color defaultBorderColor;

		public static Color defaultBackgroundColor;

		public GTextInput textInput
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DisplayObject displayObject => null;

		public HtmlElement element => null;

		public float width => 0f;

		public float height => 0f;

		public void Create(RichTextField owner, HtmlElement element)
		{
		}

		public void SetPosition(float x, float y)
		{
		}

		public void Add()
		{
		}

		public void Remove()
		{
		}

		public void Release()
		{
		}

		public void Dispose()
		{
		}
	}
}
