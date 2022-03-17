using sdk.ad.position;

namespace sdk.ad.filter
{
	public class AdFilterCount : IAdFilter
	{
		private const string Prefix = "AdFilter_Count_";

		private readonly string _key;

		private int _intervalCount;

		private readonly string _abName;

		private readonly string _abKey;

		private bool _needResetEverDay;

		public AdFilterCount(string name, string serverIdName, string abKey, int defaultIntervalCount, bool needResetEverDay = false)
		{
		}

		public bool Filter(AdPosition gAd)
		{
			return false;
		}

		public void OnShow(AdPosition gAd)
		{
		}

		public string GetRecordKey()
		{
			return "";
		}

		public void Reset()
		{
		}

		private void UpdateAbContent()
		{
		}
	}
}
