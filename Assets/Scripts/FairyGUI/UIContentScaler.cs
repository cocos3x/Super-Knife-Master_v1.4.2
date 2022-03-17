using System;
using UnityEngine;

namespace FairyGUI
{
	public class UIContentScaler : MonoBehaviour
	{
		public enum ScaleMode
		{
			ConstantPixelSize,
			ScaleWithScreenSize,
			ConstantPhysicalSize
		}

		public enum ScreenMatchMode
		{
			MatchWidthOrHeight,
			MatchWidth,
			MatchHeight
		}

		public ScaleMode scaleMode;

		public ScreenMatchMode screenMatchMode;

		public int designResolutionX;

		public int designResolutionY;

		public int fallbackScreenDPI;

		public int defaultSpriteDPI;

		public float constantScaleFactor;

		public bool ignoreOrientation;

		[NonSerialized]
		public static float scaleFactor;

		[NonSerialized]
		public static int scaleLevel;

		[NonSerialized]
		private bool _changed;

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		public void ApplyModifiedProperties()
		{
		}

		public void ApplyChange()
		{
		}

		private void UpdateScaleLevel()
		{
		}
	}
}
