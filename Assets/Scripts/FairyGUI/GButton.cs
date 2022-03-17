using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GButton : GComponent, IColorGear
	{
		private sealed class _003C_003Ec__DisplayClass66_0
		{
			public GButton _003C_003E4__this;

			public bool clickCall;

			internal void _003CFireClick_003Eb__0(object param)
			{
			}

			internal void _003CFireClick_003Eb__1(object param)
			{
			}
		}

		public NAudioClip sound;

		public float soundVolumeScale;

		public bool changeStateOnClick;

		public GObject linkedPopup;

		protected GObject _titleObject;

		protected GObject _iconObject;

		protected Controller _relatedController;

		protected string _relatedPageId;

		private ButtonMode _mode;

		private bool _selected;

		private string _title;

		private string _icon;

		private string _selectedTitle;

		private string _selectedIcon;

		private Controller _buttonController;

		private int _downEffect;

		private float _downEffectValue;

		private bool _downScaled;

		private bool _down;

		private bool _over;

		private EventListener _onChanged;

		public const string UP = "up";

		public const string DOWN = "down";

		public const string OVER = "over";

		public const string SELECTED_OVER = "selectedOver";

		public const string DISABLED = "disabled";

		public const string SELECTED_DISABLED = "selectedDisabled";

		public EventListener onChanged => null;

		public override string icon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string title
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string selectedIcon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string selectedTitle
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Color titleColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public int titleFontSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool selected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ButtonMode mode
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (ButtonMode)null;
			}
			set
			{
			}
		}

		public Controller relatedController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string relatedPageId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public void FireClick(bool downEffect, bool clickCall = false)
		{
		}

		public GTextField GetTextField()
		{
			return null;
		}

		protected void SetState(string val)
		{
		}

		protected void SetCurrentState()
		{
		}

		public override void HandleControllerChanged(Controller c)
		{
		}

		protected override void HandleGrayedChanged()
		{
		}

		protected override void ConstructExtension(ByteBuffer buffer)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}

		private void __rollover()
		{
		}

		private void __rollout()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __touchEnd()
		{
		}

		private void __removedFromStage()
		{
		}

		private void __click()
		{
		}
	}
}
