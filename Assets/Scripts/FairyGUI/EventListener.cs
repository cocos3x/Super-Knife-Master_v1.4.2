namespace FairyGUI
{
	public class EventListener
	{
		private EventBridge _bridge;

		private string _type;

		public string type => "";

		public bool isEmpty => false;

		public bool isDispatching => false;

		public EventListener(EventDispatcher owner, string type)
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

		public void Set(EventCallback1 callback)
		{
		}

		public void Set(EventCallback0 callback)
		{
		}

		public void Clear()
		{
		}

		public bool Call()
		{
			return false;
		}

		public bool Call(object data)
		{
			return false;
		}

		public bool BubbleCall(object data)
		{
			return false;
		}

		public bool BubbleCall()
		{
			return false;
		}

		public bool BroadcastCall(object data)
		{
			return false;
		}

		public bool BroadcastCall()
		{
			return false;
		}
	}
}
