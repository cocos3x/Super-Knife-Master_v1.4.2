using Configure.Ad;
using DG.Tweening;
using FairyGUI;
using Master;
using Presenter;
using System;
using UnityEngine;

namespace Ui
{
	public class BuffTipsBtn : GButton
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static TweenCallback _003C_003E9__17_0;

			internal void _003COnStartStage_003Eb__17_0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public GComponent com;

			public float t3;

			public Vector2 endPos;

			public BuffEntry buffEntry;

			internal void _003CDoRewardFlyEffect_003Eb__0()
			{
			}

			internal void _003CDoRewardFlyEffect_003Eb__1()
			{
			}
		}

		private SdkIdentify _videoId;

		private Vector2 _originalPos;

		private int _showTimes;

		private BuffPresenter.BuffType _buffType;

		private GLoader _iconLoader;

		private GTextField _nameText;

		private string _iconUrl;

		private STimer _timer;

		private bool _isClickTips;

		private int _openLv;

		private readonly float lifeTime;

		private readonly float showLaterInterval;

		private readonly int maxShowTimes;

		private bool _isFree;

		private int _freeTimes;

		public void Init()
		{
		}

		private void OnReward()
		{
		}

		public void OnStartStage()
		{
		}

		private void OnShow()
		{
		}

		private void DoAppearEffect()
		{
		}

		private void DoDisappearEffect()
		{
		}

		private void DoRewardFlyEffect()
		{
		}

		private void _003CInit_003Eb__15_0()
		{
		}

		private void _003CInit_003Eb__15_1()
		{
		}

		private void _003CInit_003Eb__15_2(SdkIdentify adPointId)
		{
		}

		private void _003COnShow_003Eb__18_0()
		{
		}

		private void _003CDoDisappearEffect_003Eb__20_0()
		{
		}
	}
}
