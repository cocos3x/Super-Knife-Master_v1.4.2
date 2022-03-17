using FairyGUI.Utils;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace FairyGUI
{
	public class TextField : DisplayObject, IMeshFactory
	{
		public class LineInfo
		{
			public float width;

			public float height;

			public float baseline;

			public int charIndex;

			public short charCount;

			public float y;

			internal float y2;

			private static Stack<LineInfo> pool;

			public static LineInfo Borrow()
			{
				return null;
			}

			public static void Return(LineInfo value)
			{
			}

			public static void Return(List<LineInfo> values)
			{
			}
		}

		public struct LineCharInfo
		{
			public float width;

			public float height;

			public float baseline;
		}

		public struct CharPosition
		{
			public int charIndex;

			public short lineIndex;

			public float offsetX;

			public short vertCount;

			public short width;

			public short imgIndex;
		}

		private VertAlignType _verticalAlign;

		private TextFormat _textFormat;

		private bool _input;

		private string _text;

		private AutoSizeType _autoSize;

		private bool _wordWrap;

		private bool _singleLine;

		private bool _html;

		private RTLSupport.DirectionType _textDirection;

		private int _maxWidth;

		private List<HtmlElement> _elements;

		private List<LineInfo> _lines;

		private List<CharPosition> _charPositions;

		private BaseFont _font;

		private float _textWidth;

		private float _textHeight;

		private bool _textChanged;

		private float _yOffset;

		private float _fontSizeScale;

		private float _renderScale;

		private int _fontVersion;

		private string _parsedText;

		private RichTextField _richTextField;

		private const int GUTTER_X = 2;

		private const int GUTTER_Y = 2;

		private const float IMAGE_BASELINE = 0.8f;

		private static float[] STROKE_OFFSET;

		private static List<LineCharInfo> sLineChars;

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

		public string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string htmlText
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string parsedText => "";

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

		public bool wordWrap
		{
			get
			{
				return false;
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

		public float textWidth => 0f;

		public float textHeight => 0f;

		public int maxWidth
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public List<HtmlElement> htmlElements => null;

		public List<LineInfo> lines => null;

		public List<CharPosition> charPositions => null;

		public RichTextField richTextField => null;

		internal void EnableRichSupport(RichTextField richTextField)
		{
		}

		public void EnableCharPositionSupport()
		{
		}

		public void ApplyFormat()
		{
		}

		public bool Redraw()
		{
			return false;
		}

		public bool HasCharacter(char ch)
		{
			return false;
		}

		public void GetLinesShape(int startLine, float startCharX, int endLine, float endCharX, bool clipped, List<Rect> resultRects)
		{
		}

		protected override void OnSizeChanged()
		{
		}

		public override void EnsureSizeCorrect()
		{
		}

		public override void Update(UpdateContext context)
		{
		}

		private void RequestText()
		{
		}

		private void BuildLines()
		{
		}

		private void ParseText()
		{
		}

		private void BuildLines2()
		{
		}

		private void UpdateLineInfo(LineInfo line, float letterSpacing, int cnt)
		{
		}

		private void DoShrink()
		{
		}

		private int ParseText(StringBuilder buffer, string source, int elementIndex)
		{
			return 0;
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		private void Cleanup()
		{
		}

		private void ApplyVertAlign()
		{
		}
	}
}
