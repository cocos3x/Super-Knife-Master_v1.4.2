namespace FairyGUI
{
	internal class EventBridge
	{
		public EventDispatcher owner;

		private EventCallback0 _callback0;

		private EventCallback1 _callback1;

		private EventCallback1 _captureCallback;

		internal bool _dispatching;

		public bool isEmpty => false;

		public EventBridge(EventDispatcher owner)
		{
		}

		public void AddCapture(EventCallback1 callback)
		{
		}

		public void RemoveCapture(EventCallback1 callback)
		{
		}

		public void Add(EventCallback1 callback)
		{
		}

		public void Remove(EventCallback1 callback)
		{
		}

		public void Add(EventCallback0 callback)
		{
		}

		public void Remove(EventCallback0 callback)
		{
		}

		public void Clear()
		{
		}

		public void CallInternal(EventContext context)
		{
		}

		public void CallCaptureInternal(EventContext context)
		{
		}
	}
}
