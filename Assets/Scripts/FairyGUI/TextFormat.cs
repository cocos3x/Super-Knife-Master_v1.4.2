using UnityEngine;

namespace FairyGUI
{
	public class TextFormat
	{
		public enum SpecialStyle
		{
			None,
			Superscript,
			Subscript
		}

		public int size;

		public string font;

		public Color color;

		public int lineSpacing;

		public int letterSpacing;

		public bool bold;

		public bool underline;

		public bool italic;

		public bool strikethrough;

		public Color32[] gradientColor;

		public AlignType align;

		public SpecialStyle specialStyle;

		public float outline;

		public Color outlineColor;

		public Vector2 shadowOffset;

		public Color shadowColor;

		public void SetColor(uint value)
		{
		}

		public bool EqualStyle(TextFormat aFormat)
		{
			return false;
		}

		public void CopyFrom(TextFormat source)
		{
		}

		public void FillVertexColors(Color32[] vertexColors)
		{
		}
	}
}
