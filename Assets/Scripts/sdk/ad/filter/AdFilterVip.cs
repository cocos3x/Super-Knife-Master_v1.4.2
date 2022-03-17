using sdk.ad.position;

namespace sdk.ad.filter
{
	public class AdFilterVip : IAdFilter
	{
		private readonly VipAction _isVip;

		public AdFilterVip(VipAction isVip)
		{
		}

		public bool Filter(AdPosition ad)
		{
			return false;
		}

		public void OnShow(AdPosition ad)
		{
		}

		public string GetRecordKey()
		{
			return "";
		}

		public void Reset()
		{
		}
	}
}
