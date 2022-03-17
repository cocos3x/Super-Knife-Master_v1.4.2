using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class HitTestContext
	{
		public static Vector3 screenPoint;

		public static Vector3 worldPoint;

		public static Vector3 direction;

		public static bool forTouch;

		public static Camera camera;

		public static int layerMask;

		public static float maxDistance;

		public static Camera cachedMainCamera;

		private static Dictionary<Camera, RaycastHit?> raycastHits;

		public static bool GetRaycastHitFromCache(Camera camera, out RaycastHit hit)
		{
			return false;
		}

		public static void CacheRaycastHit(Camera camera, ref RaycastHit hit)
		{
		}

		public static void ClearRaycastHitCache()
		{
		}
	}
}
