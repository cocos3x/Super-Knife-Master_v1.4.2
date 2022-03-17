using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class CompositeMesh : IMeshFactory, IHitTest
	{
		public readonly List<IMeshFactory> elements;

		public int activeIndex;

		public void OnPopulateMesh(VertexBuffer vb)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 point)
		{
			return false;
		}
	}
}
