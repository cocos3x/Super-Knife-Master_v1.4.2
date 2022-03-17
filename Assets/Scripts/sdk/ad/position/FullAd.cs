using sdk.ad.filter;
using System;
using System.Runtime.InteropServices;

namespace sdk.ad.position
{
	public class FullAd : AdPosition
	{
		public FullAd(string name, int positionId)
		{
		}

		public override string LogTag()
		{
			return "";
		}

		public new FullAd AddAdFilter(params IAdFilter[] adFilter)
		{
			return null;
		}

		public bool PreShow()
		{
			return false;
		}

		public new bool CheckFilter4Load()
		{
			return false;
		}

		public bool CheckShow([Optional] Action closeAction, [Optional] AdEvent adEvent)
		{
			return false;
		}

		public static int GetFullAdTimes()
		{
			return 0;
		}

		private bool _003CCheckFilter4Load_003Eb__4_0(AdFilterVip filter)
		{
			return false;
		}
	}
}
