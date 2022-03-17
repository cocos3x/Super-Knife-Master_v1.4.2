using Newtonsoft.Json.Linq;
using sdk.ad;
using sdk.bridge.interf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace sdk.bridge
{
	public class Mgr
	{
		public static readonly Mgr Instance;

		private readonly Dictionary<string, ArrayList> _abCallbacks;

		private ArrayList _ntpCallbacks;

		private readonly Dictionary<int, ArrayList> _adCallbacks;

		private IBridge _bridge;

		public bool IsEmptyPackage => false;

		static Mgr()
		{
		}

		private Mgr()
		{
		}

		public IBridge getBridge()
		{
			return null;
		}

		public void OnGameInit()
		{
		}

		public void On(string key)
		{
		}

		public void OnGameEnter()
		{
		}

		public void LoadAd(int position)
		{
		}

		public bool Load2ShowAd(int position, AdEvent staticsMsg, [Optional] Action sdkCallback)
		{
			return false;
		}

		public void LoadRewardAd(int position)
		{
		}

		public void Load2ShowRewardAd(int position, AdEvent staticsMsg, Action action, [Optional] Action failAction)
		{
		}

		public bool ShowOpenAd(int position, AdEvent staticsMsg, [Optional] Action sdkCallback)
		{
			return false;
		}

		public bool ShowAd(int position, AdEvent staticsMsg, [Optional] Action sdkCallback)
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

		public void AdPageShow(int position, AdEvent staticsMsg)
		{
		}

		public void AdPageClick(int position, AdEvent staticsMsg)
		{
		}

		public void AddAdListener(int position, AdAction action)
		{
		}

		public void RemoveAdListener(int position, AdAction action)
		{
		}

		public void PostAdListener(int position, AdType adType)
		{
		}

		public void PostAbRequest(string serverIdName)
		{
		}

		public void PostAbListener(string abName, bool isCache)
		{
		}

		public void PostAllAbListener(bool isCache)
		{
		}

		public void AddAbListener(string abName, AbAction action)
		{
		}

		public void RemoveAbListener(string abName, AbAction action)
		{
		}

		public void AddNtpListener(Action action)
		{
		}

		public void RemoveNtpListener(Action action)
		{
		}

		public bool HadInitNtpTime()
		{
			return false;
		}

		private void OnNtpCallback()
		{
		}

		public void Track(short src, string eventName, string expands)
		{
		}

		public void Jump(string key, string url = "")
		{
		}

		public bool Is(string key)
		{
			return false;
		}

		public string GetString(string key, string str = "")
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

		public void SetAppCurrency(string currencyUnit, float currencyRate, int decimalPoint)
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

		public T GetAb<T>(string serverName, string childKey, T defaultValue)
		{
			return (T)null;
		}

		public T GetJsonValue<T>(JObject jo, string childKey, T defaultValue)
		{
			return (T)null;
		}
	}
}
