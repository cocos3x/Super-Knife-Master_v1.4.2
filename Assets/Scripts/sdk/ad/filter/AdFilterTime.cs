using sdk.ad.position;

namespace sdk.ad.filter
{
	public class AdFilterTime : IAdFilter
	{
		private const string Prefix = "AdFilter_Time_";

		private readonly string _key;

		private readonly string _abName;

		private readonly string _abKey;

		private int _intervalTime;

		private bool _needResetEverDay;

		public AdFilterTime(string name, string serverIdName, string abKey, int defaultTimeInterval, bool needResetEverDay = false)
		{
		}

		public bool Filter(AdPosition ad)
		{
			return false;
		}

		private static long GetLocalTime()
		{
			return 0L;
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
