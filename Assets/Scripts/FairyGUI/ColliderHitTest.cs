using UnityEngine;

namespace FairyGUI
{
	public class ColliderHitTest : IHitTest
	{
		public Collider collider;

		public virtual bool HitTest(Rect contentRect, Vector2 localPoint)
		{
			return false;
		}
	}
}
