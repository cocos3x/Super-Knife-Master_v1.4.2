namespace sdk.bridge.interf
{
	public interface IAdCallback
	{
		void OnRewarded(int position);

		void OnAdClosed(int position);

		void OnAdFail(int position);

		void OnAdClick(int position);

		void OnAdShow(int position);
	}
}
