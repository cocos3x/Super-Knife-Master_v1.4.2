using Configure.Ad;
using DG.Tweening;
using FairyGUI;
using Master;
using System;
using System.Collections.Generic;

namespace XREDEEM
{
	public class SkinChipRewardDialog : SkinUIDialog
	{
		public enum SkinFromId
		{
			skinShop_video = 1,
			game_fullAd
		}

		public class ChipItem
		{
			public GComponent card;

			public GLabel chipCount;

			public GLoader gameSkin;
		}

		private sealed class _003C_003Ec__DisplayClass29_0
		{
			public GComponent card;

			internal void _003CInitCard_003Eb__0()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static TweenCallback _003C_003E9__33_0;

			internal void _003CShowRewardEffect_003Eb__33_0()
			{
			}
		}

		private readonly STimer _timer;

		private GObject _noThanks;

		private GButton _btnFree;

		private GButton _btnVideo;

		protected SkinChipShowEntry _showEntry;

		private List<SkinChipRewardEntry> _randomChipList;

		private List<ChipItem> _chipItemList;

		public Action onRewardCard;

		private RedeemGameType _oneGameType;

		private int _oneRewardCount;

		private bool _isNewGuide;

		private GComponent _endNode;

		private bool _isRewarded;

		private SdkIdentify _videoId;

		private SdkIdentify _fullId;

		private SkinFromId _fromId;

		private GComponent endNode => null;

		private bool allowFree => false;

		private bool isFullAd => false;

		private bool isVideo => false;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void InitCard()
		{
		}

		private void DelayShowButtons(float delayTime)
		{
		}

		protected override void OnExit()
		{
		}

		private void ShowAward()
		{
		}

		private void ShowRewardEffect()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void OnVideoBtnClick()
		{
		}

		protected override void OnClose()
		{
		}

		private void _003COnEnter_003Eb__28_0(SdkIdentify pointId)
		{
		}

		private void _003COnEnter_003Eb__28_1()
		{
		}

		private void _003CDelayShowButtons_003Eb__30_0()
		{
		}

		private void _003CDelayShowButtons_003Eb__30_1()
		{
		}
	}
}
