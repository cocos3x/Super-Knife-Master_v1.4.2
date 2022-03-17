using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class UpdateContext
	{
		public struct ClipInfo
		{
			public Rect rect;

			public Vector4 clipBox;

			public bool soft;

			public Vector4 softness;

			public uint clipId;

			public int rectMaskDepth;

			public int referenceValue;

			public bool reversed;
		}

		private Stack<ClipInfo> _clipStack;

		public bool clipped;

		public ClipInfo clipInfo;

		public int renderingOrder;

		public int batchingDepth;

		public int rectMaskDepth;

		public int stencilReferenceValue;

		public int stencilCompareValue;

		public float alpha;

		public bool grayed;

		public static UpdateContext current;

		public static bool working;

		private static Action _tmpBegin;

		public static event Action OnBegin
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action OnEnd
		{
			add
			{
			}
			remove
			{
			}
		}

		public void Begin()
		{
		}

		public void End()
		{
		}

		public void EnterClipping(uint clipId, Rect clipRect, Vector4? softness)
		{
		}

		public void EnterClipping(uint clipId, bool reversedMask)
		{
		}

		public void LeaveClipping()
		{
		}

		public void EnterPaintingMode()
		{
		}

		public void LeavePaintingMode()
		{
		}

		public void ApplyClippingProperties(Material mat, bool isStdMaterial)
		{
		}

		public void ApplyAlphaMaskProperties(Material mat, bool erasing)
		{
		}
	}
}
