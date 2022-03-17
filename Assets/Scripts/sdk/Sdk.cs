using System;

namespace sdk
{
	public static class Sdk
	{
		public const string Version = "SDK_12.0.0";

		public static bool IsEmptyPackage => false;

		public static void OnGameInit()
		{
		}

		public static void On(string key)
		{
		}

		public static void OnGameEnter()
		{
		}

		public static void SetKeyVal(string key, string val)
		{
		}

		public static int GetInt(string key)
		{
			return 0;
		}

		public static int GetFullAdTimes()
		{
			return 0;
		}

		public static int GetRewardAdTimes()
		{
			return 0;
		}

		public static string GetString(string key, string str = "")
		{
			return "";
		}

		public static string GetAbContent(string serverName)
		{
			return "";
		}

		public static string GetTestConfig()
		{
			return "";
		}

		public static int GetNotchScreen()
		{
			return 0;
		}

		public static string GetConfigBuglyId()
		{
			return "";
		}

		public static bool IsUpdateUser()
		{
			return false;
		}

		public static bool IsSdkReady()
		{
			return false;
		}

		public static bool HadInitNtpTime()
		{
			return false;
		}

		public static long GetCurrentNtpTime()
		{
			return 0L;
		}

		public static void Jump(string key, string url = "")
		{
		}

		public static void Jump2Email(string eMai = "")
		{
		}

		public static void Jump2PrivacyCenter(string url = "")
		{
		}

		public static void Jump2TermsUse(string url = "")
		{
		}

		public static void Jump2GpMark()
		{
		}

		public static void Jump2FbPage()
		{
		}

		public static string getString(string key)
		{
			return "";
		}

		public static string GetAppName()
		{
			return "";
		}

		public static string GetEmail()
		{
			return "";
		}

		public static string GetSysLanguageCode()
		{
			return "";
		}

		public static void SetAppLanguageCode(string code)
		{
		}

		public static void SetAppCurrency(string currencyUnit, float currencyRate, int decimalPoint)
		{
		}

		public static string GetSysCountryCode()
		{
			return "";
		}

		public static string GetNetCountryCode()
		{
			return "";
		}

		public static string GetHost()
		{
			return "";
		}

		public static string GetHeader()
		{
			return "";
		}

		public static string GetGaId()
		{
			return "";
		}

		public static bool Is(string key)
		{
			return false;
		}

		public static bool IsNetworkOk()
		{
			return false;
		}

		public static bool NeedLog()
		{
			return false;
		}

		public static void SetNeedLog(bool log)
		{
		}

		public static void SetTestMode(bool isTest)
		{
		}

		public static void SetTestKeyVal(string key, string val)
		{
		}

		public static string GetMediaSource()
		{
			return "";
		}

		public static string GetMediaSourceAdSet()
		{
			return "";
		}

		public static void IOS_SetIdfaRewardCallback(Action<int> action)
		{
		}

		public static void IOS_SetIsHideIdfaReward(Func<bool> func)
		{
		}

		public static void IOS_SetIDFACallback(Action action)
		{
		}

		public static void IOS_SetAddTipsCallback(Action<string> action)
		{
		}

		public static void IOS_SetAudioAction(Action audioPause, Action audioResume)
		{
		}

		public static void Log(object message)
		{
		}
	}
}
