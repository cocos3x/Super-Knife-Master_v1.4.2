using sdk.ad.position;

namespace sdk.ad.filter
{
	public interface IAdFilter
	{
		bool Filter(AdPosition ad);

		void OnShow(AdPosition ad);

		string GetRecordKey();

		void Reset();
	}
}
