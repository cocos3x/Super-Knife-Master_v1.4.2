using UnityEngine;

namespace FairyGUI
{
	public class RegularPolygonMesh : IMeshFactory, IHitTest
	{
		public Rect? drawRect;

		public int sides;

		public float lineWidth;

		public Color32 lineColor;

		public Color32? centerColor;

		public Color32? fillColor;

		public float[] distances;

		public float rotation;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
