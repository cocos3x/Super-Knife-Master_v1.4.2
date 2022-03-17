using FairyGUI;
using FairyGUI.Utils;

namespace XREDEEM
{
	public class XRedeemItem : GLabel
	{
		public static string UI_URL;

		private GButton _btnRedeem;

		private RedeemShowEntry _showEntry;

		private RedeemGameType _gameType;

		private GProgressBar _bar;

		private GTextField _barTitle;

		private float _iconWidth;

		public override void ConstructFromXML(XML xml)
		{
		}

		public void Init(RedeemShowEntry showEntry, RedeemGameType redeemGameType)
		{
		}

		public void UpdateAllData()
		{
		}

		private void UpdateUi()
		{
		}

		private void DoRedeem()
		{
		}

		private void InitTouchEvents()
		{
		}
	}
}
