using System;
using UnityEngine;

namespace FairyGUI
{
	public class CaptureCamera : MonoBehaviour
	{
		[NonSerialized]
		public Transform cachedTransform;

		[NonSerialized]
		public Camera cachedCamera;

		[NonSerialized]
		private static CaptureCamera _main;

		[NonSerialized]
		private static int _layer;

		private static int _hiddenLayer;

		public const string Name = "Capture Camera";

		public const string LayerName = "VUI";

		public const string HiddenLayerName = "Hidden VUI";

		public static int layer => 0;

		public static int hiddenLayer => 0;

		private void OnEnable()
		{
		}

		public static void CheckMain()
		{
		}

		public static RenderTexture CreateRenderTexture(int width, int height, bool stencilSupport)
		{
			return null;
		}

		public static void Capture(DisplayObject target, RenderTexture texture, float contentHeight, Vector2 offset)
		{
		}
	}
}
