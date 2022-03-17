using UnityEngine;

namespace FairyGUI
{
	public class EllipseMesh : IMeshFactory, IHitTest
	{
		public Rect? drawRect;

		public float lineWidth;

		public Color32 lineColor;

		public Color32? centerColor;

		public Color32? fillColor;

		public float startDegree;

		public float endDegreee;

		private static int[] SECTOR_CENTER_TRIANGLES;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
