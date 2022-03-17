using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	internal class TouchInfo
	{
		public float x;

		public float y;

		public int touchId;

		public int clickCount;

		public KeyCode keyCode;

		public char character;

		public EventModifiers modifiers;

		public float mouseWheelDelta;

		public int button;

		public float downX;

		public float downY;

		public float downTime;

		public int downFrame;

		public bool began;

		public bool clickCancelled;

		public float lastClickTime;

		public float lastClickX;

		public float lastClickY;

		public int lastClickButton;

		public float holdTime;

		public DisplayObject target;

		public List<DisplayObject> downTargets;

		public DisplayObject lastRollOver;

		public List<EventDispatcher> touchMonitors;

		public InputEvent evt;

		private static List<EventBridge> sHelperChain;

		public void Reset()
		{
		}

		public void UpdateEvent()
		{
		}

		public void Begin()
		{
		}

		public void Move()
		{
		}

		public void End()
		{
		}

		public DisplayObject ClickTest()
		{
			return null;
		}
	}
}
