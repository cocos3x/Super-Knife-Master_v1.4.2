using ExcelConfig;
using Master;
using SaveData;
using System;
using System.Collections.Generic;

namespace Presenter
{
	public class BuffPresenter : Presenter<BuffPresenter>
	{
		public enum BuffType
		{
			Tap = 1,
			Speed = 2,
			Atk = 3,
			Offline = 4,
			Reward = 5,
			Null = -1
		}

		public enum EventType
		{
			OnBuffChanged
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnBuffChanged(object objKey, Action callback)
			{
			}
		}

		public class BuffInfo
		{
			public BuffType buffType;

			public BuffConfigItem config;

			public string state;

			public string dailyLimitStr;

			public string leftTimeStr;

			public bool isDailyLimitVisible;
		}

		public Dictionary<BuffType, BuffInfo> _infos;

		private SDataOption<GameData> _option;

		private GameData _data;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		private int buffDailyLimit => 0;

		public double buffTapAttackMul => 0.0;

		public double buffAttackMul => 0.0;

		public double buffSpeedMul => 0.0;

		public double buffKnifeCoinRewardMul => 0.0;

		public bool finishTapGuide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int tipsFreeGetTimes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal override void OnInit()
		{
		}

		public Dictionary<BuffType, BuffInfo> GetBuffInfos()
		{
			return null;
		}

		public BuffInfo GetBuffInfo(BuffType type)
		{
			return null;
		}

		public void OnRewardBuff(BuffType type, int fromId, bool isBuy = false)
		{
		}

		public bool IsDailyLimited(BuffType type)
		{
			return false;
		}

		private BuffConfigItem GetBuffConfig(BuffType type)
		{
			return null;
		}

		public bool HasBuff(BuffType type)
		{
			return false;
		}

		private BuffData GetBuffData(BuffType type)
		{
			return null;
		}

		internal override void OnSecondTick()
		{
		}

		public override void OnNewDay()
		{
		}

		public void ClearAllBuffTime_Test()
		{
		}

		public void ClearAllBuffDailyCount_Test()
		{
		}

		public BuffType GetTipsBuffType()
		{
			//IL_0003: Expected I4, but got O
			return (BuffType)null;
		}
	}
}
