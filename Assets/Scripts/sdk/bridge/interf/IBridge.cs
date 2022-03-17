using sdk.ad;
using System;
using System.Runtime.InteropServices;

namespace sdk.bridge.interf
{
	public interface IBridge
	{
		void On(string key);

		void LoadAd(int position);

		bool Load2ShowAd(int position, AdEvent adEvent, Action sdkCallback);

		void LoadRewardAd(int position);

		void Load2ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback);

		bool ShowOpenAd(int position, AdEvent adEvent, Action sdkCallback);

		bool ShowAd(int position, AdEvent adEvent, Action sdkCallback);

		bool ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback);

		void Load2ShowBanner(int position, AdEvent adEvent);

		void SetBannerVisible(bool isVisible);

		bool HadCache(int position);

		void AdPageShow(int position, AdEvent adEvent);

		void AdPageClick(int position, AdEvent adEvent);

		void AddAdListener(int position, AdAction action);

		void PostAbRequest(string serverIdName);

		void AddAbListener(string abName, AbAction action);

		void RemoveAbListener(string abName);

		void AddNtpListener(Action action);

		void Track(int src, string eventName, string expands);

		void Jump(string key, string url = "");

		bool Is(string key);

		string GetString(string key, string str);

		int GetInt(string key);

		long GetLong(string key);

		void SetKeyVal(string key, string val);

		void SetObject(string key, object ob);

		void SetFissionListener(ShareAction action);

		void IOS_SetIsHideIdfaReward(Func<bool> func);

		void IOS_SetIdfaRewardCallback(Action<int> action);

		void IOS_SetIDFACallback(Action action);

		void IOS_SetAddTipsCallback(Action<string> action);

		void IOS_SetAudioAction(Action audioPause, Action audioResume);
	}
}
