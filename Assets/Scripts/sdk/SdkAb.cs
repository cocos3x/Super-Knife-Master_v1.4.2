using sdk.bridge.interf;
using System;

namespace sdk
{
	public static class SdkAb
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static AbAction _003C_003E9__2_0;

			internal void _003COnGameInit_003Eb__2_0(bool cache)
			{
			}
		}

		private static bool _allowGameFun;

		private static AbAction _eidABCallback;

		public static void OnGameInit()
		{
		}

		public static T GetFunAb<T>(string serverName, string key, T defaultValue)
		{
			return (T)null;
		}

		public static bool IsRateOpen()
		{
			return false;
		}

		public static bool AllowGameFun()
		{
			return false;
		}

		public static void UpdateAllowGameFun()
		{
		}

		public static bool IsAuditMode()
		{
			return false;
		}

		public static void AddAbListener(string serverName, AbAction action)
		{
		}

		public static void RemoveAbListener(string serverName, AbAction action)
		{
		}
	}
}
