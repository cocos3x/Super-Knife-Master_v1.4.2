using UnityEngine;

namespace FairyGUI
{
	public class InputEvent
	{
		private float _003Cx_003Ek__BackingField;

		private float _003Cy_003Ek__BackingField;

		private KeyCode _003CkeyCode_003Ek__BackingField;

		private char _003Ccharacter_003Ek__BackingField;

		private EventModifiers _003Cmodifiers_003Ek__BackingField;

		private float _003CmouseWheelDelta_003Ek__BackingField;

		private int _003CtouchId_003Ek__BackingField;

		private int _003Cbutton_003Ek__BackingField;

		private int _003CclickCount_003Ek__BackingField;

		private float _003CholdTime_003Ek__BackingField;

		public float x
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public KeyCode keyCode
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (KeyCode)null;
			}
			internal set
			{
			}
		}

		public char character
		{
			get
			{
				return '\0';
			}
			internal set
			{
			}
		}

		public EventModifiers modifiers
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (EventModifiers)null;
			}
			internal set
			{
			}
		}

		public float mouseWheelDelta
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public int touchId
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int button
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public int clickCount
		{
			get
			{
				return 0;
			}
			internal set
			{
			}
		}

		public float holdTime
		{
			get
			{
				return 0f;
			}
			internal set
			{
			}
		}

		public Vector2 position => (Vector2)null;

		public bool isDoubleClick => false;

		public bool ctrlOrCmd => false;

		public bool ctrl => false;

		public bool shift => false;

		public bool alt => false;

		public bool command => false;
	}
}
