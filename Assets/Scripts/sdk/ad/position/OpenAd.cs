using sdk.ad.filter;
using System;
using System.Runtime.InteropServices;

namespace sdk.ad.position
{
	public class OpenAd : AdPosition
	{
		private bool _hasLoadOpen;

		public OpenAd(string name, int positionId)
		{
		}

		public override string LogTag()
		{
			return "";
		}

		public new OpenAd AddAdFilter(params IAdFilter[] adFilter)
		{
			return null;
		}

		public new bool CheckFilter4Load()
		{
			return false;
		}

		public bool PreShow()
		{
			return false;
		}

		public bool CheckShow([Optional] Action closeAction, [Optional] AdEvent adEvent)
		{
			return false;
		}
	}
}
