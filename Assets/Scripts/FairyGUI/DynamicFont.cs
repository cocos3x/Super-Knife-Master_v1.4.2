using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class DynamicFont : BaseFont
	{
		private Font _font;

		private int _size;

		private float _ascent;

		private float _lineHeight;

		private float _scale;

		private TextFormat _format;

		private FontStyle _style;

		private bool _boldVertice;

		private CharacterInfo _char;

		private CharacterInfo _lineChar;

		private bool _gotLineChar;

		private static Vector3 bottomLeft;

		private static Vector3 topLeft;

		private static Vector3 topRight;

		private static Vector3 bottomRight;

		private static Vector2 uvBottomLeft;

		private static Vector2 uvTopLeft;

		private static Vector2 uvTopRight;

		private static Vector2 uvBottomRight;

		private static Color32[] vertexColors;

		private static Vector3[] BOLD_OFFSET;

		public Font nativeFont
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DynamicFont()
		{
		}

		public DynamicFont(string name, Font font)
		{
		}

		public override void Dispose()
		{
		}

		public override void SetFormat(TextFormat format, float fontSizeScale)
		{
		}

		public override void PrepareCharacters(string text)
		{
		}

		public override bool GetGlyph(char ch, out float width, out float height, out float baseline)
		{
			return false;
		}

		public override int DrawGlyph(float x, float y, List<Vector3> vertList, List<Vector2> uvList, List<Vector2> uv2List, List<Color32> colList)
		{
			return 0;
		}

		public override int DrawLine(float x, float y, float width, int fontSize, int type, List<Vector3> vertList, List<Vector2> uvList, List<Vector2> uv2List, List<Color32> colList)
		{
			return 0;
		}

		public override bool HasCharacter(char ch)
		{
			return false;
		}

		public override int GetLineHeight(int size)
		{
			return 0;
		}

		private void textureRebuildCallback(Font targetFont)
		{
		}
	}
}
