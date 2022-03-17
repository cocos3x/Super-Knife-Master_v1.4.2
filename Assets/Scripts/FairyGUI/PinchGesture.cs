namespace FairyGUI
{
	public class PinchGesture : EventDispatcher
	{
		private GObject _003Chost_003Ek__BackingField;

		private EventListener _003ConBegin_003Ek__BackingField;

		private EventListener _003ConEnd_003Ek__BackingField;

		private EventListener _003ConAction_003Ek__BackingField;

		public float scale;

		public float delta;

		private float _startDistance;

		private float _lastScale;

		private int[] _touches;

		private bool _started;

		private bool _touchBegan;

		public GObject host
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onBegin
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onEnd
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onAction
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public PinchGesture(GObject host)
		{
		}

		public void Dispose()
		{
		}

		public void Enable(bool value)
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __touchMove(EventContext context)
		{
		}

		private void __touchEnd(EventContext context)
		{
		}
	}
}
