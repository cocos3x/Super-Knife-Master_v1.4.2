using Ad.Bean;
using Configure.Ad;
using GameSdk.Bean;
using Master;
using sdk.ad;
using sdk.ad.filter;
using sdk.ad.position;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace GameSdk
{
	public class AdSdkPresenter : Presenter<AdSdkPresenter>
	{
		public enum EventType
		{
			OnVideoAdReward,
			OnFullAdFinish,
			OnRewardAdFinish
		}

		public class Listener : SEventDispatch<EventType>
		{
			protected readonly SLockList<EventType, Action<SdkIdentify>> videoADItems;

			protected readonly SLockList<EventType, Action> ADItems;

			public override void Remove(object objKey)
			{
			}

			public void EmitAdReward(SdkIdentify adPointId)
			{
			}

			public void OnVideoAdReward(object objKey, Action<SdkIdentify> callback)
			{
			}

			public void EmitFullAdFinish()
			{
			}

			public void OnFullAdFinish(object objKey, Action callback)
			{
			}

			public void EmitRewardAdFinish()
			{
			}

			public void OnRewardAdFinish(object objKey, Action callback)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static VipAction _003C_003E9__18_0;

			internal bool _003CAddFilter_003Eb__18_0()
			{
				return false;
			}
		}

		private sealed class _003C_003Ec__DisplayClass35_0
		{
			public AdSdkPresenter _003C_003E4__this;

			public Action rewardAction;

			public SdkIdentify adkey;

			internal void _003CCheckShowReward_003Eb__0()
			{
			}
		}

		private SdkConfigure _configure;

		private Dictionary<string, SdkAdConfigure> _configureDict;

		private Dictionary<string, AdPosition> _adPostionDict;

		private Dictionary<string, IAdFilter> _filterDict;

		public bool Test_FREE_VIDEO;

		public bool Test_FREE_FULL;

		private readonly Listener _003Clistener_003Ek__BackingField;

		private SDataOption<AdData> _option;

		private AdData _data;

		private readonly string _saveKeyPrefix;

		public Listener listener => null;

		public int totalRewardAdPlayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int dailyRewardAdPlayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int totalFullAdPlayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int dailyFullAdPlayCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int totalAdPlayCount => 0;

		public int dailyAdPlayCount => 0;

		internal override int Priority()
		{
			return 0;
		}

		public override void OnAwake()
		{
		}

		internal override void OnInit()
		{
		}

		private void ParseConfigure()
		{
		}

		private void AddFilter(SdkAdConfigure sdkAdConfigure, AdPosition adPosition)
		{
		}

		private void AddFilter(IAdFilter adFilter, AdPosition adPosition)
		{
		}

		private IAdFilter GenFilter(SdkAdConfigure sdkAdConfigure, SdkFilterConfigure sdkFilterConfigure)
		{
			return null;
		}

		public override void OnEnterMainScene()
		{
		}

		private void InitGame()
		{
		}

		private void AdjustLog()
		{
		}

		private void InitBugly()
		{
		}

		private void PreloadAd<T>() where T : AdPosition
		{
		}

		private bool ShowOpenAd()
		{
			return false;
		}

		public override void OnNewDay()
		{
		}

		private void AddDailyCount(string key, int count)
		{
		}

		private int GetDailyCount(string key)
		{
			return 0;
		}

		private void AddTotalCount(string key, int count)
		{
		}

		private int GetTotalCount(string key)
		{
			return 0;
		}

		private string GetSaveKey(string key, UsedType type)
		{
			return "";
		}

		public void PreShow(SdkIdentify adkey, [Optional] AdEvent adEvent)
		{
		}

		public bool CheckShowFull(SdkIdentify adkey, [Optional] Action closeAction, [Optional] AdEvent adEvent)
		{
			return false;
		}

		public void CheckShowReward(SdkIdentify adkey, [Optional] Action rewardAction, [Optional] Action failAction, [Optional] AdEvent adEvent)
		{
		}

		private void OnAdReward(Action action, SdkIdentify adkey)
		{
		}

		public void AddCount(SdkIdentify adkey, UsedType type, int count = 1)
		{
		}

		private void AddRealCount(SdkIdentify adkey, UsedType type, int count = 1)
		{
		}

		public int GetTotalCount(SdkIdentify adkey, UsedType type)
		{
			return 0;
		}

		public int GetDailyCount(SdkIdentify adkey, UsedType type)
		{
			return 0;
		}

		public int GetMaxCount(SdkIdentify adkey, UsedType type)
		{
			return 0;
		}

		public ValidAdCountResult GetValidAdCountResult(SdkIdentify adkey)
		{
			return null;
		}
	}
}
