using System.Collections.Generic;

namespace FairyGUI
{
	public class EventDispatcher : IEventDispatcher
	{
		private Dictionary<string, EventBridge> _dic;

		private static InputEvent sCurrentInputEvent;

		public void AddEventListener(string strType, EventCallback1 callback)
		{
		}

		public void AddEventListener(string strType, EventCallback0 callback)
		{
		}

		public void RemoveEventListener(string strType, EventCallback1 callback)
		{
		}

		public void RemoveEventListener(string strType, EventCallback0 callback)
		{
		}

		public void AddCapture(string strType, EventCallback1 callback)
		{
		}

		public void RemoveCapture(string strType, EventCallback1 callback)
		{
		}

		public void RemoveEventListeners()
		{
		}

		public void RemoveEventListeners(string strType)
		{
		}

		public bool hasEventListeners(string strType)
		{
			return false;
		}

		public bool isDispatching(string strType)
		{
			return false;
		}

		internal EventBridge TryGetEventBridge(string strType)
		{
			return null;
		}

		internal EventBridge GetEventBridge(string strType)
		{
			return null;
		}

		public bool DispatchEvent(string strType)
		{
			return false;
		}

		public bool DispatchEvent(string strType, object data)
		{
			return false;
		}

		public bool DispatchEvent(string strType, object data, object initiator)
		{
			return false;
		}

		internal bool InternalDispatchEvent(string strType, EventBridge bridge, object data, object initiator)
		{
			return false;
		}

		public bool DispatchEvent(EventContext context)
		{
			return false;
		}

		internal bool BubbleEvent(string strType, object data, List<EventBridge> addChain)
		{
			return false;
		}

		public bool BubbleEvent(string strType, object data)
		{
			return false;
		}

		public bool BroadcastEvent(string strType, object data)
		{
			return false;
		}

		private EventBridge GetBridge(string strType)
		{
			return null;
		}

		private static void GetChildEventBridges(string strType, Container container, List<EventBridge> bridges)
		{
		}

		private static void GetChildEventBridges(string strType, GComponent container, List<EventBridge> bridges)
		{
		}

		internal void GetChainBridges(string strType, List<EventBridge> chain, bool bubble)
		{
		}
	}
}
