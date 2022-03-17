using FairyGUI.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GTextInput : GTextField
	{
		private InputTextField _003CinputTextField_003Ek__BackingField;

		private EventListener _onChanged;

		private EventListener _onSubmit;

		public InputTextField inputTextField
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onChanged => null;

		public EventListener onSubmit => null;

		public bool editable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool hideInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int maxLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string restrict
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool displayAsPassword
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int caretPosition
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string promptText
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool keyboardInput
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int keyboardType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool disableIME
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Dictionary<uint, Emoji> emojies
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int border
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int corner
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Color borderColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public Color backgroundColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public bool mouseWheelEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void SetSelection(int start, int length)
		{
		}

		public void ReplaceSelection(string value)
		{
		}

		protected override void SetTextFieldText()
		{
		}

		protected override void CreateDisplayObject()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
