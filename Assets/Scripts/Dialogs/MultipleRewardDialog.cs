using Configure.Ad;
using DG.Tweening;
using FairyGUI;
using Master;
using Presenter;
using System;

namespace Dialogs
{
	public class MultipleRewardDialog : SDialogX<MultipleRewardDialog>
	{
		private sealed class _003C_003Ec__DisplayClass13_0
		{
			public MultipleRewardDialog _003C_003E4__this;

			public double mul;

			internal void _003COnSpinFinish_003Eb__0()
			{
			}

			internal void _003COnSpinFinish_003Eb__2()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static TweenCallback _003C_003E9__13_1;

			internal void _003COnSpinFinish_003Eb__13_1()
			{
			}
		}

		private MultipleListNode _multipleNode;

		private bool _hasReward;

		private GButton _btnAd;

		private GButton _btnNoThanks;

		private CalculatePresenter.MultipleInfo _multipleInfo;

		private GTextField _rewardText;

		private SdkIdentify _videoId;

		private bool isFree;

		private bool _isVideoReward;

		private MultipleRewardInfo _rewardInfo;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void OnSpinFinish()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void OnVideoReward()
		{
		}

		private void OnReward(double multiple)
		{
		}

		protected override void OnClose()
		{
		}

		private void _003COnEnter_003Eb__12_0()
		{
		}

		private void _003COnEnter_003Eb__12_1(SdkIdentify adPointId)
		{
		}

		private void _003CInitTouchListener_003Eb__15_0()
		{
		}

		private void _003CInitTouchListener_003Eb__15_1()
		{
		}

		private void _003COnVideoReward_003Eb__16_0()
		{
		}
	}
}
