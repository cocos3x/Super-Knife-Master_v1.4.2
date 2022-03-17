using DG.Tweening;
using FairyGUI;
using UnityEngine;

namespace Master
{
	public static class TweenTool
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public GObject node;

			internal void _003CDelayShow_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public GObject node;

			public float normalScale;

			public float fromX;

			public float fromY;

			public float toX;

			public float toY;

			public TweenCallback onFinish;

			internal void _003CRunBezierJump_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass3_0
		{
			public string iconUrl;

			public GComponent parent;

			public GObject flyToTarget;

			public float startX;

			public float startY;

			public float width;

			public TweenCallback onOneFinish;
		}

		private sealed class _003C_003Ec__DisplayClass3_1
		{
			public float delay;

			public _003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowFlyAni_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public string iconUrl;

			public GComponent parent;

			public GObject flyToTarget;

			public float startX;

			public float startY;

			public float width;

			public TweenCallback onOneFinish;
		}

		private sealed class _003C_003Ec__DisplayClass4_1
		{
			public float delay;

			public _003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowFlyAni2_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass5_0
		{
			public GComponent node;

			public Vector2 endPos;

			public TweenCallback onFinish;

			internal void _003CCreateFlyCoin2_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass6_0
		{
			public TweenCallback onFinish;

			public GComponent node;

			internal void _003CCreateFlyCoin_003Eb__0()
			{
			}
		}

		public static void DelayShow(GObject node, float delayTime)
		{
		}

		public static void RunBezierJump(GObject node, float normalScale, float toX, float toY, TweenCallback onFinish)
		{
		}

		public static void RunNumber(GTextField node, long fromValue, long toValue, bool isGold, string prefix, string suffix, float duration)
		{
		}

		public static void ShowFlyAni(string iconUrl, GComponent parent, GObject flyToTarget, int count, float startX, float startY, float width, TweenCallback onOneFinish)
		{
		}

		public static void ShowFlyAni2(string iconUrl, GComponent parent, GObject flyToTarget, int count, float startX, float startY, float width, TweenCallback onOneFinish)
		{
		}

		public static void CreateFlyCoin2(string iconUrl, GComponent parent, GObject flyToTarget, float delay, float startX, float startY, float width, TweenCallback onFinish)
		{
		}

		public static void CreateFlyCoin(string iconUrl, GComponent parent, GObject flyToTarget, float delay, float startX, float startY, float width, TweenCallback onFinish)
		{
		}

		public static void ShowIconFlyToEffect(GObject iconObj, GObject targetIcon, float normalScale, TweenCallback onFinish)
		{
		}
	}
}
