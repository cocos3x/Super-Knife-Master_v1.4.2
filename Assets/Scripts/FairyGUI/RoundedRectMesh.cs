using UnityEngine;

namespace FairyGUI
{
	public class RoundedRectMesh : IMeshFactory, IHitTest
	{
		public Rect? drawRect;

		public float lineWidth;

		public Color32 lineColor;

		public Color32? fillColor;

		public float topLeftRadius;

		public float topRightRadius;

		public float bottomLeftRadius;

		public float bottomRightRadius;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
