using DG.Tweening;
using FairyGUI;

namespace XREDEEM
{
	public class RunTextUtil
	{
		private sealed class _003C_003Ec__DisplayClass0_0
		{
			public string iconUrl;

			public GComponent parent;

			public GObject flyToTarget;

			public float startX;

			public float startY;

			public float width;

			public TweenCallback onOneFinish;
		}

		private sealed class _003C_003Ec__DisplayClass0_1
		{
			public float delay;

			public _003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowFlyAni_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass1_0
		{
			public TweenCallback onFinish;

			public GComponent node;

			internal void _003CCreateFlyCoin_003Eb__0()
			{
			}
		}

		public static void ShowFlyAni(string iconUrl, GComponent parent, GObject flyToTarget, int count, float startX, float startY, float width, TweenCallback onOneFinish)
		{
		}

		public static void CreateFlyCoin(string iconUrl, GComponent parent, GObject flyToTarget, float delay, float startX, float startY, float width, TweenCallback onFinish)
		{
		}

		public static void RunNumber(GTextField node, long fromValue, long toValue, bool isGold, string prefix, string suffix, float duration)
		{
		}
	}
}
