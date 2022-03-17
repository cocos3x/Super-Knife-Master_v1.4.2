using System;
using UnityEngine;

namespace FairyGUI
{
	public class StageCamera : MonoBehaviour
	{
		public bool constantSize;

		[NonSerialized]
		public float unitsPerPixel;

		[NonSerialized]
		public Transform cachedTransform;

		[NonSerialized]
		public Camera cachedCamera;

		[NonSerialized]
		private int screenWidth;

		[NonSerialized]
		private int screenHeight;

		[NonSerialized]
		private bool isMain;

		[NonSerialized]
		private Display _display;

		[NonSerialized]
		public static Camera main;

		[NonSerialized]
		public static int screenSizeVer;

		public const string Name = "Stage Camera";

		public const string LayerName = "UI";

		public static float DefaultCameraSize;

		public static float DefaultUnitsPerPixel;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnScreenSizeChanged(int newWidth, int newHeight)
		{
		}

		private void OnRenderObject()
		{
		}

		public void ApplyModifiedProperties()
		{
		}

		public static void CheckMainCamera()
		{
		}

		public static void CheckCaptureCamera()
		{
		}

		public static Camera CreateCamera(string name, int cullingMask)
		{
			return null;
		}
	}
}
