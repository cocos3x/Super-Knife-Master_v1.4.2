using FairyGUI;
using Master;
using System.Text.RegularExpressions;

namespace XREDEEM
{
	public class XRedeemInputDialog : SDialogX<XRedeemInputDialog>
	{
		private bool isFocusIn;

		private GLabel _inputBox;

		private GTextInput _input;

		private static string form;

		private static Regex _regexNum;

		private RedeemGameType _gameType;

		private GameOutType _outType;

		private int _redeemId;

		private int _skinId;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void FocusInEv()
		{
		}

		private void ChangedEv()
		{
		}

		private void FocusOutEv()
		{
		}

		private void SubmitEv()
		{
		}

		private bool CheckInputVal()
		{
			return false;
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}
	}
}
