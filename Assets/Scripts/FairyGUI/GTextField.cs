using FairyGUI.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GTextField : GObject, ITextColorGear, IColorGear
	{
		protected TextField _textField;

		protected string _text;

		protected bool _ubbEnabled;

		protected bool _updatingSize;

		protected Dictionary<string, string> _templateVars;

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

		public Dictionary<string, string> templateVars
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextFormat textFormat
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public AlignType align
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (AlignType)null;
			}
			set
			{
			}
		}

		public VertAlignType verticalAlign
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (VertAlignType)null;
			}
			set
			{
			}
		}

		public bool singleLine
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float stroke
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Color strokeColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public Vector2 shadowOffset
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public bool UBBEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AutoSizeType autoSize
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (AutoSizeType)null;
			}
			set
			{
			}
		}

		public float textWidth => 0f;

		public float textHeight => 0f;

		protected override void CreateDisplayObject()
		{
		}

		protected virtual void SetTextFieldText()
		{
		}

		public GTextField SetVar(string name, string value)
		{
			return null;
		}

		public void FlushVars()
		{
		}

		public bool HasCharacter(char ch)
		{
			return false;
		}

		protected string ParseTemplate(string template)
		{
			return "";
		}

		protected void UpdateSize()
		{
		}

		protected override void HandleSizeChanged()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
