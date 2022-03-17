using FairyGUI;
using Master;
using System;
using Ui;

namespace Reward
{
	public class RewardRefreshAnimation
	{
		private class RewardRefreshConfig
		{
			private readonly MainScene _sceneUI;

			internal RewardRefreshConfig(MainScene sceneUI)
			{
			}

			public GObject GetEndIcon(AnimationType animationType)
			{
				return null;
			}

			public GObject GetEndTextField(AnimationType animationType)
			{
				return null;
			}

			public string GetAnimationUrl(AnimationType animationType)
			{
				return "";
			}

			public string GetFlyFinishSound(AnimationType animationType)
			{
				return "";
			}

			public long GetCurrentValue(AnimationType animationType)
			{
				return 0L;
			}

			public string GetRewardSound(AnimationType animationType)
			{
				return "";
			}

			public void UpdateCurrentText(AnimationType animationCurValue, long value)
			{
			}
		}

		private enum AnimationType
		{
			Coupon,
			Diamond,
			MaxCount
		}

		private class AnimationEntry
		{
			private double passTime;

			private long targetValue;

			private long startValue;

			private long deltaValue;

			private bool running;

			private double duration;

			internal long curValue;

			internal bool isValueChange;

			internal int flyCount;

			internal bool isUpdateValueWith10000;

			internal readonly AnimationType animationType;

			public AnimationEntry(int index)
			{
			}

			public void RefreshValue(long newValue)
			{
			}

			public void Update(float dt)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass7_0
		{
			public RewardRefreshAnimation _003C_003E4__this;

			public AnimationType animationType;

			public int index;

			internal void _003CShowNumberRoll_003Eb__0()
			{
			}

			internal void _003CShowNumberRoll_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass10_0
		{
			public int finishCnt;

			public RewardRefreshAnimation _003C_003E4__this;

			public AnimationType animationType;

			public int count;

			public long rewardVal;

			internal void _003CShowFlyEffect_003Eb__0(AnimationType a)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public RewardRefreshAnimation _003C_003E4__this;

			public AnimationType type;

			public GComponent parent;

			public float startX;

			public float startY;

			public Action<AnimationType> onFinish;
		}

		private sealed class _003C_003Ec__DisplayClass13_1
		{
			public float delay;

			public _003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowFlyAni_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass14_0
		{
			public GObject sprite;

			public Action<AnimationType> onFinish;

			public AnimationType type;

			public GComponent node;

			internal void _003CCreateFlyCoin_003Eb__0()
			{
			}
		}

		private readonly AnimationEntry[] _animationList;

		private readonly RewardRefreshConfig _config;

		private readonly STimer _timer;

		public RewardRefreshAnimation(MainScene sceneUI)
		{
		}

		private void ShowNumberRoll(AnimationType animationType)
		{
		}

		private void CheckAndSyncCurrentValue(AnimationType animationType)
		{
		}

		private void SyncCurrentValue(AnimationType animationType)
		{
		}

		private void ShowFlyEffect(AnimationType animationType, long rewardVal)
		{
		}

		private void ShowFlyText(AnimationType animationType, long delta)
		{
		}

		private void OnFlyAnimationFinish(AnimationType animationType)
		{
		}

		private void ShowFlyAni(AnimationType type, GComponent parent, int count, float startX, float startY, Action<AnimationType> onFinish)
		{
		}

		private void CreateFlyCoin(AnimationType type, GComponent parent, float delay, float startX, float startY, Action<AnimationType> onFinish)
		{
		}

		private void Update()
		{
		}

		private void _003C_002Ector_003Eb__6_0()
		{
		}

		private void _003C_002Ector_003Eb__6_1()
		{
		}

		private void _003C_002Ector_003Eb__6_2()
		{
		}

		private void _003C_002Ector_003Eb__6_3(long delta)
		{
		}

		private void _003C_002Ector_003Eb__6_4(long delta)
		{
		}

		private void _003C_002Ector_003Eb__6_5()
		{
		}

		private void _003C_002Ector_003Eb__6_6()
		{
		}
	}
}
