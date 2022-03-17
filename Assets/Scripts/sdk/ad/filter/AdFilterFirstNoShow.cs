using sdk.ad.position;

namespace sdk.ad.filter
{
	public class AdFilterFirstNoShow : IAdFilter
	{
		private const string Prefix = "AdFilter_First_";

		private readonly string _key;

		private readonly string _abName;

		private readonly string _abKey;

		private int _firstNoShowTimes;

		private bool _needResetEverDay;

		public AdFilterFirstNoShow(string name, string serverIdName, string abKey, int defaultNoShowTimes, bool needResetEverDay = false)
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

		private void UpdateAbContent()
		{
		}
	}
}
