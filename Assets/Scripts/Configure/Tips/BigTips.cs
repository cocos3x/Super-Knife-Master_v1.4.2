using FairyGUI;
using FairyGUI.Utils;
using System.Collections.Generic;

namespace Configure.Tips
{
	public class BigTips : GLabel
	{
		private static readonly List<BigTips> _bigTipsList;

		private bool _hasShow;

		private bool _needToRemove;

		private bool _isCostCount;

		public string msg
		{
			set
			{
			}
		}

		public static void ShowTips(string msg)
		{
		}

		public static void ShowTips(ResultCode code)
		{
		}

		public static void ClearBigTips()
		{
		}

		public override void ConstructFromXML(XML xml)
		{
		}

		private void OnEnter()
		{
		}

		private void CostTipsCount()
		{
		}

		private void OnExit()
		{
		}
	}
}
