using FairyGUI;
using FairyGUI.Utils;

namespace XREDEEM
{
	public class XRedeemItemV3 : GComponent
	{
		public static string ITEMURL;

		private RedeemGameType _gameType;

		private RedeemShowEntry _redeemEntry;

		private int _redeemId;

		private GLoader _iconBig;

		private GTextField _rewardText;

		private GLoader _ico;

		private GLabel _barNode;

		private GProgressBar _bar;

		private GTextField _barTitle;

		public override void ConstructFromXML(XML xml)
		{
		}

		public void Init(RedeemGameType gameType, RedeemShowEntry redeemEntry)
		{
		}

		private void UpdateUi()
		{
		}

		private void UpdateDescText()
		{
		}

		private void DoRedeem()
		{
		}

		public override void Dispose()
		{
		}
	}
}
