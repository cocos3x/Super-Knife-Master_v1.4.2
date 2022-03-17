using Newtonsoft.Json.Linq;
using sdk.ad;
using sdk.bridge.interf;
using System;
using System.Runtime.InteropServices;

namespace sdk.bridge.proxy
{
	public class DefaultProxy : IBridge
	{
		public static JObject _testJson;

		private int fullAdTimes;

		private int rewardAdTimes;

		private ShareAction _shareAction;

		public static void SetTestJson(JObject s)
		{
		}

		public static DefaultProxy Create()
		{
			return null;
		}

		public void On(string key)
		{
		}

		public void LoadAd(int position)
		{
		}

		public bool Load2ShowAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		public void LoadRewardAd(int position)
		{
		}

		public void Load2ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback)
		{
		}

		public bool ShowOpenAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		public bool ShowAd(int position, AdEvent adEvent, Action sdkCallback)
		{
			return false;
		}

		public bool ShowRewardAd(int position, AdEvent adEvent, Action sdkCallback, [Optional] Action sdkFailCallback)
		{
			return false;
		}

		public void Load2ShowBanner(int position, AdEvent staticsMsg)
		{
		}

		public void SetBannerVisible(bool isVisible)
		{
		}

		public bool HadCache(int position)
		{
			return false;
		}

		public void AdPageShow(int position, AdEvent adEvent)
		{
		}

		public void AdPageClick(int position, AdEvent adEvent)
		{
		}

		public void AddAdListener(int position, AdAction action)
		{
		}

		public void PostAbRequest(string serverIdName)
		{
		}

		public void AddAbListener(string abName, AbAction action)
		{
		}

		public void RemoveAbListener(string abName)
		{
		}

		public void AddNtpListener(Action action)
		{
		}

		public void Track(int src, string eventName, string expands)
		{
		}

		public void Jump(string key, string url)
		{
		}

		public bool Is(string key)
		{
			return false;
		}

		public string GetString(string key, string str)
		{
			return "";
		}

		public string GetTestConfig()
		{
			return "";
		}

		public string GetAbContent(string serverIdName)
		{
			return "";
		}

		public int GetInt(string key)
		{
			return 0;
		}

		public long GetLong(string key)
		{
			return 0L;
		}

		public void SetKeyVal(string key, string val)
		{
		}

		public void SetObject(string key, object ob)
		{
		}

		public void SetFissionListener(ShareAction action)
		{
		}

		public void IOS_SetIsHideIdfaReward(Func<bool> func)
		{
		}

		public void IOS_SetIdfaRewardCallback(Action<int> action)
		{
		}

		public void IOS_SetIDFACallback(Action action)
		{
		}

		public void IOS_SetAddTipsCallback(Action<string> action)
		{
		}

		public void IOS_SetAudioAction(Action audioPause, Action audioResume)
		{
		}
	}
}
