using System.Collections.Generic;

namespace sdk.bridge.interf
{
	public class ShareMgr
	{
		public static readonly ShareMgr Instance;

		private HashSet<ShareAction> _shareCallbacks;

		private IBridge _bridge;

		private bool _isInit;

		private StateChageCache _stateChageCache;

		private IconAnimCache _iconAnimCache;

		private RewardAnimCache _rewardAnimCache;

		static ShareMgr()
		{
		}

		private ShareMgr()
		{
		}

		private void CheckInit()
		{
		}

		public void CheckShare()
		{
		}

		public void EnterShare(int from)
		{
		}

		public void SetShareAppSwitch(bool open)
		{
		}

		public void setMainGameAndBaseWithdrawThreshold(int mainGameID, double thresholdMoney, double money2Coin)
		{
		}

		public void setFissionGameWithIDs(int[] gameIDs)
		{
		}

		public void AddListener(ShareAction action)
		{
		}

		public void RemoveListener(ShareAction action)
		{
		}

		private void OnShareCallback(ShareType shareType, int rewardType, double rewardVal, int animType, bool fissionSwitchOpen, bool crossSwitchOpen, double withdrawBalance)
		{
		}

		private void AbListener(bool isCache)
		{
		}
	}
}
