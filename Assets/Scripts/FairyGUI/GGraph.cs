using FairyGUI.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GGraph : GObject, IColorGear
	{
		private Shape _shape;

		private int _shapeType;

		public int shapeType => 0;

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

		public Shape shape => null;

		protected override void CreateDisplayObject()
		{
		}

		public void ReplaceMe(GObject target)
		{
		}

		public void AddBeforeMe(GObject target)
		{
		}

		public void AddAfterMe(GObject target)
		{
		}

		public void SetNativeObject(DisplayObject obj)
		{
		}

		public void DrawRect(float aWidth, float aHeight, int lineSize, Color lineColor, Color fillColor)
		{
		}

		public void DrawRoundRect(float aWidth, float aHeight, Color fillColor, float[] corner)
		{
		}

		public void DrawEllipse(float aWidth, float aHeight, Color fillColor)
		{
		}

		public void DrawPolygon(float aWidth, float aHeight, IList<Vector2> points, Color fillColor)
		{
		}

		public void DrawPolygon(float aWidth, float aHeight, IList<Vector2> points, Color fillColor, float lineSize, Color lineColor)
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
