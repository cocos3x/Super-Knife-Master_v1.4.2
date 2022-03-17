using UnityEngine;

namespace FairyGUI
{
	public class FillMesh : IMeshFactory
	{
		public FillMethod method;

		public int origin;

		public float amount;

		public bool clockwise;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		private static void FillHorizontal(VertexBuffer vb, Rect vertRect, int origin, float amount)
		{
		}

		private static void FillVertical(VertexBuffer vb, Rect vertRect, int origin, float amount)
		{
		}

		private static void FillRadial90(VertexBuffer vb, Rect vertRect, Origin90 origin, float amount, bool clockwise)
		{
		}

		private static void FillRadial180(VertexBuffer vb, Rect vertRect, Origin180 origin, float amount, bool clockwise)
		{
		}

		private static void FillRadial360(VertexBuffer vb, Rect vertRect, Origin360 origin, float amount, bool clockwise)
		{
		}
	}
}
