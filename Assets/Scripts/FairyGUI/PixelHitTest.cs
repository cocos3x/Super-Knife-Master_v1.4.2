using UnityEngine;

namespace FairyGUI
{
	public class PixelHitTest : IHitTest
	{
		public int offsetX;

		public int offsetY;

		public float sourceWidth;

		public float sourceHeight;

		private PixelHitTestData _data;

		public PixelHitTest(PixelHitTestData data, int offsetX, int offsetY, float sourceWidth, float sourceHeight)
		{
		}

		public bool HitTest(Rect contentRect, Vector2 localPoint)
		{
			return false;
		}
	}
}
