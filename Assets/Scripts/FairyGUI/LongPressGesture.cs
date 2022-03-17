using UnityEngine;

namespace FairyGUI
{
	public class LongPressGesture : EventDispatcher
	{
		private GObject _003Chost_003Ek__BackingField;

		private EventListener _003ConBegin_003Ek__BackingField;

		private EventListener _003ConEnd_003Ek__BackingField;

		private EventListener _003ConAction_003Ek__BackingField;

		public float trigger;

		public float interval;

		public bool once;

		public int holdRangeRadius;

		private Vector2 _startPoint;

		private bool _started;

		private int _touchId;

		public static float TRIGGER;

		public static float INTERVAL;

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

		public LongPressGesture(GObject host)
		{
		}

		public void Dispose()
		{
		}

		public void Enable(bool value)
		{
		}

		public void Cancel()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __timer(object param)
		{
		}

		private void __touchEnd(EventContext context)
		{
		}
	}
}
