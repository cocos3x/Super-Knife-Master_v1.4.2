using FairyGUI;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace XREDEEM
{
	public class RedeemSelectGameDialog : RedeemsUIDialog
	{
		private class TabMeta
		{
			public GButton button;

			public GameShowEntry entry;

			public Vector2 startPos;

			public Vector2 endPos;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<RedeemGameType, bool> _003C_003E9__13_0;

			internal bool _003Cget_selectGameCount_003Eb__13_0(RedeemGameType gameType)
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public GameShowEntry entry;

			public RedeemSelectGameDialog _003C_003E4__this;

			internal void _003COnEnter_003Eb__0()
			{
			}
		}

		private RedeemShowEntry _showEntry;

		private List<TabMeta> tabList;

		private RedeemGameType _firstSelectGame;

		private RedeemGameType[] _selectGameList;

		private GButton _btnSubmit;

		private GObject _noThanks;

		private int _gameCount;

		private GComponent _tabBox;

		private List<Vector2> _endPosList;

		private GComponent _bg;

		private GTextField _title;

		private GTextField _info;

		private GTextField _info2;

		private bool isSelectFirst => false;

		private RedeemGameType firstSelectGameType => (RedeemGameType)null;

		private int selectGameCount => 0;

		protected override void OnInit()
		{
		}

		private void UpdateBgUI()
		{
		}

		private void UpdateEndUI()
		{
		}

		protected override void OnEnter()
		{
		}

		private void ShowNextAnim()
		{
		}

		private void UpdateSelectedUI(RedeemGameType type = (RedeemGameType)0)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void UpdateNoThanks()
		{
		}

		protected override void OnClose()
		{
		}

		private void _003CShowNextAnim_003Eb__24_0()
		{
		}

		private void _003CInitTouchListener_003Eb__27_0()
		{
		}

		private void _003CUpdateNoThanks_003Eb__28_0()
		{
		}
	}
}
