using FairyGUI;
using Master;
using System;
using System.Collections.Generic;

namespace XREDEEM
{
	public class XRedeemDialog : SDialogX<XRedeemDialog>
	{
		private class TopItem
		{
			public RedeemGameType RedeemGameType;

			public int index;

			public GButton obj;
		}

		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public GameShowEntry entry;

			public XRedeemDialog _003C_003E4__this;

			internal void _003CInitGameList_003Eb__0()
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static EventCallback0 _003C_003E9__13_0;

			public static EventCallback0 _003C_003E9__23_0;

			internal void _003CInitTest_003Eb__13_0()
			{
			}

			internal void _003CInitTouchListener_003Eb__23_0()
			{
			}
		}

		private GList _topList;

		private readonly List<TopItem> _topItemList;

		private readonly List<XRedeemItem> _itemList;

		private RedeemGameType _selectedRedeemGameId;

		public GButton _goldLabel;

		public GButton _diamondLabel;

		private List<GameShowEntry> _gameList;

		private TopItem _selectedItem;

		private GButton _btnBack;

		protected override void OnInit()
		{
		}

		protected override void OnEnter()
		{
		}

		private void InitGameList()
		{
		}

		private void InitTest()
		{
		}

		private void InitTopRewardUi()
		{
		}

		private void CheckRedeemGuide()
		{
		}

		private void InitRedeemList()
		{
		}

		private void UpdateAllItem()
		{
		}

		private void SetTopItemGameId(RedeemGameType redeemGameType)
		{
		}

		private void UpdateTopListItem()
		{
		}

		private void DoSpecialEffect()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnClose()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void _003CInitTopRewardUi_003Eg__UpdateTopRewardUi_007C14_0()
		{
		}

		private void _003CCheckRedeemGuide_003Eb__15_0()
		{
		}
	}
}
