using sdk.ad.filter;
using System.Runtime.InteropServices;

namespace sdk.ad.position
{
	public class BannerAd : AdPosition
	{
		private bool _hasLoading;

		private bool _hasVisible;

		public BannerAd(string name, int positionId)
		{
		}

		public override string LogTag()
		{
			return "";
		}

		public new BannerAd AddAdFilter(params IAdFilter[] adFilter)
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

		public void SetVisible(bool visible = true, [Optional] AdEvent adEvent)
		{
		}

		private bool _003CCheckFilter4Load_003Eb__6_0(AdFilterVip filter)
		{
			return false;
		}
	}
}
