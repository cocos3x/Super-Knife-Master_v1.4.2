using System;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace FairyGUI
{
	public class InputTextField : RichTextField
	{
		private int _003CmaxLength_003Ek__BackingField;

		private bool _003CkeyboardInput_003Ek__BackingField;

		private int _003CkeyboardType_003Ek__BackingField;

		private bool _003ChideInput_003Ek__BackingField;

		private bool _003CdisableIME_003Ek__BackingField;

		private bool _003CmouseWheelEnabled_003Ek__BackingField;

		public static Action<InputTextField, string> onCopy;

		public static Action<InputTextField> onPaste;

		public static PopupMenu contextMenu;

		private string _text;

		private string _restrict;

		private Regex _restrictPattern;

		private bool _displayAsPassword;

		private string _promptText;

		private string _decodedPromptText;

		private int _border;

		private int _corner;

		private Color _borderColor;

		private Color _backgroundColor;

		private bool _editable;

		private bool _editing;

		private int _caretPosition;

		private int _selectionStart;

		private int _composing;

		private char _highSurrogateChar;

		private string _textBeforeEdit;

		private EventListener _onChanged;

		private EventListener _onSubmit;

		private Shape _caret;

		private SelectionShape _selectionShape;

		private float _nextBlink;

		private const int GUTTER_X = 2;

		private const int GUTTER_Y = 2;

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

		public EventListener onChanged => null;

		public EventListener onSubmit => null;

		public override string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override TextFormat textFormat
		{
			get
			{
				return null;
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

		public int selectionBeginIndex => 0;

		public int selectionEndIndex => 0;

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

		private void UpdateShape()
		{
		}

		public void SetSelection(int start, int length)
		{
		}

		public void ReplaceSelection(string value)
		{
		}

		public void ReplaceText(string value)
		{
		}

		private void GetPartialText(int startIndex, int endIndex, StringBuilder buffer)
		{
		}

		private int GetTextlength(string value)
		{
			return 0;
		}

		private string TruncateText(string value, int length)
		{
			return "";
		}

		private string ValidateInput(string source)
		{
			return "";
		}

		private void UpdateText()
		{
		}

		private string EncodePasswordText(string value)
		{
			return "";
		}

		private void ClearSelection()
		{
		}

		public string GetSelection()
		{
			return "";
		}

		private void Scroll(int hScroll, int vScroll)
		{
		}

		private void AdjustCaret(TextField.CharPosition cp, bool moveSelectionHeader = false)
		{
		}

		private void UpdateCaret(bool forceUpdate = false)
		{
		}

		private void MoveContent(Vector2 pos, bool forceUpdate)
		{
		}

		private void UpdateSelection(TextField.CharPosition cp)
		{
		}

		private TextField.CharPosition GetCharPosition(int caretIndex)
		{
			return (TextField.CharPosition)null;
		}

		private TextField.CharPosition GetCharPosition(Vector2 location)
		{
			return (TextField.CharPosition)null;
		}

		private Vector2 GetCharLocation(TextField.CharPosition cp)
		{
			return (Vector2)null;
		}

		internal override void RefreshObjects()
		{
		}

		protected void OnChanged()
		{
		}

		protected override void OnSizeChanged()
		{
		}

		public override void Update(UpdateContext context)
		{
		}

		public override void Dispose()
		{
		}

		private void DoCopy(string value)
		{
		}

		private void DoPaste()
		{
		}

		private void CreateCaret()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __touchMove(EventContext context)
		{
		}

		private void __mouseWheel(EventContext context)
		{
		}

		private void __focusIn(EventContext context)
		{
		}

		private void __focusOut(EventContext contxt)
		{
		}

		private void __keydown(EventContext context)
		{
		}

		private bool HandleKey(InputEvent evt)
		{
			return false;
		}

		internal void CheckComposition()
		{
		}

		private void __click(EventContext context)
		{
		}

		private void __rightClick(EventContext context)
		{
		}
	}
}
