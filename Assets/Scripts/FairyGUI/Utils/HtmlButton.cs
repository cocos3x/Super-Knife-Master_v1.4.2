namespace FairyGUI.Utils
{
	public class HtmlButton : IHtmlObject
	{
		private GComponent _003Cbutton_003Ek__BackingField;

		public const string CLICK_EVENT = "OnHtmlButtonClick";

		public static string resource;

		private RichTextField _owner;

		private HtmlElement _element;

		private EventCallback1 _clickHandler;

		public GComponent button
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

		private void _003C_002Ector_003Eb__9_0(EventContext context)
		{
		}
	}
}
