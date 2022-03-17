using FairyGUI;
using Master;
using System;

namespace XREDEEM
{
	public class XRedeemDialogV3 : SDialogX<XRedeemDialogV3>
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static EventCallback0 _003C_003E9__20_0;

			public static EventCallback0 _003C_003E9__23_1;

			internal void _003CInitTest_003Eb__20_0()
			{
			}

			internal void _003CInitTouchListener_003Eb__23_1()
			{
			}
		}

		public GComponent dailyBox;

		public GButton btnDailyOpen;

		private RedeemGameType _mainGame;

		private GButton _btnBack;

		private GButton _btnRule;

		private GLabel _goldLabel;

		private GLabel _diamondLabel;

		public GObject diamondIcon;

		public GTextField diamondText;

		private static bool _stopUpdateReward;

		private static XRedeemDialogV3 instance;

		public static bool stopUpdateReward
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected override void OnInit()
		{
		}

		protected override void OnEnter()
		{
		}

		private void InitTopRewardUi()
		{
		}

		private void UpdateTopRewardUi()
		{
		}

		private void OnSelectGameChanged()
		{
		}

		private void UpdateRedeemItems()
		{
		}

		private void InitTest()
		{
		}

		private void UpdateDailyBox()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void CheckRedeemGuide()
		{
		}

		private void _003CInitTouchListener_003Eb__23_0()
		{
		}

		private void _003CCheckRedeemGuide_003Eb__24_0()
		{
		}
	}
}
