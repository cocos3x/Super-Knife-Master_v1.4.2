using UnityEngine;

namespace FairyGUI
{
	public class MeshColliderHitTest : ColliderHitTest
	{
		public Vector2 lastHit;

		public MeshColliderHitTest(MeshCollider collider)
		{
		}

		public override bool HitTest(Rect contentRect, Vector2 localPoint)
		{
			return false;
		}
	}
}
