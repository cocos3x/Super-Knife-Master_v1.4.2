using UnityEngine;

namespace FairyGUI
{
	public class ShapeHitTest : IHitTest
	{
		public DisplayObject shape;

		public ShapeHitTest(DisplayObject obj)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 localPoint)
		{
			return false;
		}
	}
}
