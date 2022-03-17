using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class Shape : DisplayObject
	{
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

		public bool isEmpty => false;

		public void DrawRect(float lineSize, Color lineColor, Color fillColor)
		{
		}

		public void DrawRect(float lineSize, Color32[] colors)
		{
		}

		public void DrawRoundRect(float lineSize, Color lineColor, Color fillColor, float topLeftRadius, float topRightRadius, float bottomLeftRadius, float bottomRightRadius)
		{
		}

		public void DrawEllipse(Color fillColor)
		{
		}

		public void DrawEllipse(float lineSize, Color centerColor, Color lineColor, Color fillColor, float startDegree, float endDegree)
		{
		}

		public void DrawPolygon(IList<Vector2> points, Color fillColor)
		{
		}

		public void DrawPolygon(IList<Vector2> points, Color32[] colors)
		{
		}

		public void DrawPolygon(IList<Vector2> points, Color fillColor, float lineSize, Color lineColor)
		{
		}

		public void DrawRegularPolygon(int sides, float lineSize, Color centerColor, Color lineColor, Color fillColor, float rotation, float[] distances)
		{
		}

		public void Clear()
		{
		}

		protected override DisplayObject HitTest()
		{
			return null;
		}
	}
}
