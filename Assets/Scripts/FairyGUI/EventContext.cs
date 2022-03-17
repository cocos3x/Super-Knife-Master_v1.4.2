using System.Collections.Generic;

namespace FairyGUI
{
	public class EventContext
	{
		private EventDispatcher _003Csender_003Ek__BackingField;

		private object _003Cinitiator_003Ek__BackingField;

		private InputEvent _003CinputEvent_003Ek__BackingField;

		public string type;

		public object data;

		internal bool _defaultPrevented;

		internal bool _stopsPropagation;

		internal bool _touchCapture;

		internal List<EventBridge> callChain;

		private static Stack<EventContext> pool;

		public EventDispatcher sender
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public object initiator
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public InputEvent inputEvent
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool isDefaultPrevented => false;

		public void StopPropagation()
		{
		}

		public void PreventDefault()
		{
		}

		public void CaptureTouch()
		{
		}

		internal static EventContext Get()
		{
			return null;
		}

		internal static void Return(EventContext value)
		{
		}
	}
}
