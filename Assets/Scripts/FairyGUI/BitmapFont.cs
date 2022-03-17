using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class BitmapFont : BaseFont
	{
		public class BMGlyph
		{
			public float x;

			public float y;

			public float width;

			public float height;

			public int advance;

			public int lineHeight;

			public Vector2[] uv;

			public int channel;
		}

		public int size;

		public bool resizable;

		public bool hasChannel;

		protected Dictionary<int, BMGlyph> _dict;

		protected BMGlyph _glyph;

		private float _scale;

		private static Vector3 bottomLeft;

		private static Vector3 topLeft;

		private static Vector3 topRight;

		private static Vector3 bottomRight;

		private static Color32[] vertexColors;

		public void AddChar(char ch, BMGlyph glyph)
		{
		}

		public override void SetFormat(TextFormat format, float fontSizeScale)
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

		public override bool HasCharacter(char ch)
		{
			return false;
		}

		public override int GetLineHeight(int size)
		{
			return 0;
		}
	}
}
