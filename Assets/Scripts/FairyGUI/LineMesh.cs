using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class LineMesh : IMeshFactory
	{
		public GPath path;

		public float lineWidth;

		public AnimationCurve lineWidthCurve;

		public Gradient gradient;

		public bool roundEdge;

		public float fillStart;

		public float fillEnd;

		public float pointDensity;

		public bool repeatFill;

		private static List<Vector3> points;

		private static List<float> ts;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		private void DrawRoundEdge(VertexBuffer vb, Vector2 p0, Vector2 p1, float lw, Color32 color, Vector2 uv)
		{
		}
	}
}
