using Master;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Reward
{
	public class RewardPresenter : Presenter<RewardPresenter>
	{
		public enum EventType
		{
			OnCountChange,
			OnShowFlyEffect,
			OnNumberRoll
		}

		public class Listener : ISRemoveAbleContainer
		{
			private readonly Dictionary<RewardItemType, SLockList<EventType, Action>> items;

			private readonly Dictionary<RewardItemType, SLockList<EventType, Action<long>>> items2;

			private void Add(object objKey, RewardItemType itemType, EventType eventType, Action callback)
			{
			}

			public void EmitEvent(RewardItemType itemType, EventType eventType)
			{
			}

			public void EmitEvent(RewardItemType itemType, EventType eventType, long delta)
			{
			}

			private void Add(object objKey, RewardItemType itemType, EventType eventType, Action<long> callback)
			{
			}

			public void OnCountChange(object objKey, RewardItemType itemType, Action callback)
			{
			}

			public void OnShowFlyEffect(object objKey, RewardItemType itemType, Action<long> callback)
			{
			}

			public void OnNumberRoll(object objKey, RewardItemType itemType, Action callback)
			{
			}

			public void Remove(object objKey)
			{
			}
		}

		public static int CashSaveRatio;

		private readonly Listener _003Clistener_003Ek__BackingField;

		private SDataOption<RewardData> _option;

		private RewardData _data;

		private static long _lastRewardCashRatio;

		public int couponFlyStartTag;

		public int diamondFlyStartTag;

		public Vector2 couponFlyStartPos;

		public Vector2 diamondFlyStartPos;

		private double _lastRewardCoupon;

		private int _lastRewardDiamondNum;

		public Listener listener => null;

		public override string logTag => "";

		public string cashSymbol => "";

		public long coupon => 0L;

		public long couponAtom => 0L;

		public string couponString => "";

		public string diamondString => "";

		public string historyDiamondString => "";

		public string historyCouponString => "";

		public long diamondAtom => 0L;

		public double diamond => 0.0;

		internal override void OnInit()
		{
		}

		public long GetCollectTarget(RewardItemType itemType)
		{
			return 0L;
		}

		public double GetCollectRatio(RewardItemType itemType)
		{
			return 0.0;
		}

		public bool IsLimitCollectWithPercent(RewardItemType itemType, double percent)
		{
			return false;
		}

		public bool IsLimitCollectWithRatio(RewardItemType itemType, double ratio)
		{
			return false;
		}

		public long GetCount(RewardItemType itemType)
		{
			return 0L;
		}

		public long GetHistoryCount(RewardItemType itemType)
		{
			return 0L;
		}

		public double GetCountD(RewardItemType itemType)
		{
			return 0.0;
		}

		public double GetHistoryCountD(RewardItemType itemType)
		{
			return 0.0;
		}

		public long GetAtomCount(RewardItemType itemType)
		{
			return 0L;
		}

		public long GetHistoryAtomCount(RewardItemType itemType)
		{
			return 0L;
		}

		public bool Cost(RewardItemType itemType, long delta)
		{
			return false;
		}

		public bool Cost(RewardItemType itemType, double delta)
		{
			return false;
		}

		public void Add(RewardItemType itemType, double delta, int effectType = 0)
		{
		}

		public void Add(RewardItemType itemType, long delta, int effectType = 0)
		{
		}

		public bool CostAtom(RewardItemType itemType, long deltaAtom)
		{
			return false;
		}

		public void AddAtom(RewardItemType itemType, long deltaAtom, int effectType = 0)
		{
		}

		private static long DiamondToRatio(double v)
		{
			return 0L;
		}

		private void GetRewardDiamond(double nowValue)
		{
		}

		private void GetRewardCoupon(double nowValue)
		{
		}

		public long ToAtomUnit(long count)
		{
			return 0L;
		}

		public long ToAtomUnit(double count)
		{
			return 0L;
		}

		public long ToNormalUnit(long count)
		{
			return 0L;
		}

		public double ToNormalUnit(double count)
		{
			return 0.0;
		}

		public bool HasCount(RewardItemType itemType, double value)
		{
			return false;
		}

		public bool HasCount(RewardItemType itemType, long value)
		{
			return false;
		}

		public bool HasCountAtom(RewardItemType itemType, long value)
		{
			return false;
		}

		public void Clear(RewardItemType itemType)
		{
		}

		public bool IsLimit(RewardItemType itemType, long value)
		{
			return false;
		}

		public bool IsLimitAtom(RewardItemType itemType, long atomValue)
		{
			return false;
		}

		public bool IsLimit(RewardItemType itemType, double value)
		{
			return false;
		}

		public string ToCurrencyValueAtom(long value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string ToCurrencyValue(long value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string ToCurrencyValue(double value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string ToCurrencySymbol(double value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string AtomToString(RewardItemType itemType, long value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string NormalToString(RewardItemType itemType, long value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string ToDiamondString(long value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}

		public string ToDiamondString(double value, bool isTrimZero = true, int keepCount = -1)
		{
			return "";
		}
	}
}
