using FairyGUI;
using Master;
using System.Collections.Generic;

namespace XREDEEM
{
	public class SelectGameDialogV3 : SDialogX<SelectGameDialogV3>
	{
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public GameShowEntry entry;

			public SelectGameDialogV3 _003C_003E4__this;

			internal void _003CInitGameList_003Eb__0()
			{
			}
		}

		private bool _isReselect;

		private GButton _btnConfirm;

		private GButton _btnReconfirm;

		private GButton _btnCancel;

		private RedeemGameType _curSelectGame;

		private Dictionary<RedeemGameType, GButton> _gameBtns;

		protected override float modalLayerAlpha => 0f;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void UpdateConfirmBtn()
		{
		}

		private void InitGameList()
		{
		}

		private void OnClickGameBtn(RedeemGameType gameType)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		private void OnClickConfirm()
		{
		}

		protected override void OnClose()
		{
		}

		private void _003CInitTouchListener_003Eb__15_0()
		{
		}
	}
}
