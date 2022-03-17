using UnityEngine;

namespace FairyGUI
{
	public class SwipeGesture : EventDispatcher
	{
		private GObject _003Chost_003Ek__BackingField;

		private EventListener _003ConBegin_003Ek__BackingField;

		private EventListener _003ConEnd_003Ek__BackingField;

		private EventListener _003ConMove_003Ek__BackingField;

		private EventListener _003ConAction_003Ek__BackingField;

		public Vector2 velocity;

		public Vector2 position;

		public Vector2 delta;

		public int actionDistance;

		public bool snapping;

		private Vector2 _startPoint;

		private Vector2 _lastPoint;

		private float _time;

		private bool _started;

		private bool _touchBegan;

		public static int ACTION_DISTANCE;

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

		public EventListener onMove
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

		public SwipeGesture(GObject host)
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
