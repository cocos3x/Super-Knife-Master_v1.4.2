using UnityEngine;

namespace FairyGUI
{
	public class StraightLineMesh : IMeshFactory
	{
		public Color color;

		public Vector3 origin;

		public Vector3 end;

		public float lineWidth;

		public bool repeatFill;

		public StraightLineMesh()
		{
		}

		public StraightLineMesh(float lineWidth, Color color, bool repeatFill)
		{
		}

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}
	}
}
