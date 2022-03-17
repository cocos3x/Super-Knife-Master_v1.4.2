using sdk.ad.filter;
using sdk.bridge.interf;
using System;
using System.Runtime.InteropServices;

namespace sdk.ad.position
{
	public class RewardAd : AdPosition
	{
		private bool _hasPerShow;

		public RewardAd(string name, int positionId)
		{
		}

		public override string LogTag()
		{
			return "";
		}

		public new RewardAd AddAdFilter(params IAdFilter[] adFilter)
		{
			return null;
		}

		public bool IsCanShow()
		{
			return false;
		}

		public void PreShow([Optional] AdEvent adEvent)
		{
		}

		public void Load2ShowRewardAd(Action rewardAction, [Optional] Action failAction, [Optional] AdEvent adEvent)
		{
		}

		private void OnAdAdAction(AdType type)
		{
		}

		public static int GetRewardAdTimes()
		{
			return 0;
		}
	}
}
