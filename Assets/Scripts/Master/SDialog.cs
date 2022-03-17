using FairyGUI;
using System.Collections.Generic;

namespace Master
{
	public abstract class SDialog : GComponent
	{
		protected enum FixMode
		{
			Center,
			Full
		}

		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public SDialog _003C_003E4__this;

			public GObject obj;

			public float clickInterval;

			public EventCallback0 callback;

			internal void _003CAddButtonClick_003Eb__0()
			{
			}
		}

		private bool _isRemovePlayerListener;

		private GComponent _contentPane;

		protected GGraph _modalLayer;

		private bool _003CisOpen_003Ek__BackingField;

		private EventListener _onClose;

		private SNameTree _names;

		private Dictionary<object, float> _lastButtonClickTimes;

		protected virtual bool useContentAnimation => false;

		protected virtual float modalLayerAlpha => 0f;

		public bool isOpen
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		public GComponent contentPane => null;

		public EventListener onClose => null;

		public SNameTree names => null;

		protected void SetContentWith(string pkgName, string resName, FixMode fixMode = FixMode.Center)
		{
		}

		protected virtual void InitData(object[] args)
		{
		}

		protected T TryGetArgs<T>(object[] args, int index, T defaultValue)
		{
			return (T)null;
		}

		protected virtual void DoShowAnimation()
		{
		}

		protected virtual void OnShowAnimationFinish()
		{
		}

		protected virtual void DoHideAnimation()
		{
		}

		protected virtual void OnClose()
		{
		}

		public GObject AddButtonClick(string name, EventCallback0 callback, float clickInterval = 0f)
		{
			return null;
		}

		public GObject AddButtonClick(GObject obj, EventCallback0 callback, float clickInterval = 0f)
		{
			return null;
		}

		protected abstract void OnInit();

		protected abstract void OnEnter();

		protected abstract void OnExit();

		protected abstract void InitTouchListener();

		public void Open(params object[] args)
		{
		}

		protected virtual void ShowModelLayer()
		{
		}

		protected virtual void OnTouchModalLayer()
		{
		}

		protected virtual void RemoveModalLayer()
		{
		}

		protected virtual void OnCloseAnimationFinish()
		{
		}

		protected void DisabledAllTouch(GComponent obj)
		{
		}

		public void Close()
		{
		}

		private void _003COpen_003Eb__34_0()
		{
		}
	}
}
