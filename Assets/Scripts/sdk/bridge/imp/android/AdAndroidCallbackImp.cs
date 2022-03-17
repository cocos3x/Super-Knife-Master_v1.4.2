using sdk.bridge.interf;
using System;
using UnityEngine;

namespace sdk.bridge.imp.android
{
	public class AdAndroidCallbackImp : AndroidJavaProxy, IAdCallback
	{
		public Action Action;

		public Action FailAction;

		public bool IsReward;

		public int Position;

		private AdType _adType;

		public static AdAndroidCallbackImp Create(int positin, Action action, string javaInterface, bool isReward = true)
		{
			return null;
		}

		public AdAndroidCallbackImp(string javaInterface)
		{
		}

		public void OnRewarded(int position)
		{
		}

		public void OnAdClosed(int position)
		{
		}

		public void OnAdFail(int position)
		{
		}

		public void OnAdClick(int position)
		{
		}

		public void OnAdShow(int position)
		{
		}

		private void PostAdRewardListener()
		{
		}

		private void PostAdCloseListener()
		{
		}

		private void PostAdFailListener()
		{
		}

		private void PostAdClickListener()
		{
		}

		private void PostAdShowListener()
		{
		}
	}
}
