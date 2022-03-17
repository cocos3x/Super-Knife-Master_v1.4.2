namespace sdk.bridge.interf
{
	public interface IShareCallback
	{
		void ShowFissionRewardAnimation(int rewardType, double rewardVal);

		void ShowIconAnimation(int animType);

		void OnFissionSwitchStateChange(bool shareSwitchOpen, bool crossSwitchOpen, double withdrawBalance);
	}
}
