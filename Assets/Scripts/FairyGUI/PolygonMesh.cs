using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class PolygonMesh : IMeshFactory, IHitTest
	{
		public readonly List<Vector2> points;

		public readonly List<Vector2> texcoords;

		public float lineWidth;

		public Color32 lineColor;

		public Color32? fillColor;

		public Color32[] colors;

		public bool usePercentPositions;

		private static List<int> sRestIndices;

		public void Add(Vector2 point)
		{
		}

		public void Add(Vector2 point, Vector2 texcoord)
		{
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		private void DrawOutline(VertexBuffer vb)
		{
		}

		private bool IsPointInTriangle(ref Vector2 p, ref Vector2 a, ref Vector2 b, ref Vector2 c)
		{
			return false;
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
