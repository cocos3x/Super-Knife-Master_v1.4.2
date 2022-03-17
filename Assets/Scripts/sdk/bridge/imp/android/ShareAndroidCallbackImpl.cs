using sdk.bridge.interf;
using UnityEngine;

namespace sdk.bridge.imp.android
{
	public class ShareAndroidCallbackImpl : AndroidJavaProxy, IShareCallback
	{
		private ShareAction _shareAction;

		private int _rewardType;

		private double _rewardVal;

		private int _animType;

		private bool _fissionSwitchOpen;

		private bool _crossSwitchOpen;

		private double _withdrawBalance;

		public static ShareAndroidCallbackImpl Create(string javaInterface, ShareAction shareAction)
		{
			return null;
		}

		public ShareAndroidCallbackImpl(string javaInterface, ShareAction shareAction)
		{
		}

		public void ShowFissionRewardAnimation(int rewardType, double rewardVal)
		{
		}

		public void ShowIconAnimation(int animType)
		{
		}

		public void OnFissionSwitchStateChange(bool fissionSwitchOpen, bool crossSwitchOpen, double withdrawBalance)
		{
		}

		private void PostRewardAnim()
		{
		}

		private void PostIconAnim()
		{
		}

		private void PostStateChange()
		{
		}
	}
}
