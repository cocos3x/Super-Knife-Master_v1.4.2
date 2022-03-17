using UnityEngine;

namespace FairyGUI
{
	public class RectMesh : IMeshFactory, IHitTest
	{
		public Rect? drawRect;

		public float lineWidth;

		public Color32 lineColor;

		public Color32? fillColor;

		public Color32[] colors;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
