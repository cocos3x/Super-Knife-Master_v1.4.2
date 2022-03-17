using Configure.Tips;
using Core;
using ExcelConfig;
using Master;
using SaveData;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Presenter
{
	public class KnifePresenter : Presenter<KnifePresenter>
	{
		public enum EventType
		{
			OnKnifeUnlock,
			OnKnifeLvChanged,
			OnKnifeAttrUpdate
		}

		public class CEventDispatch<TEventType> : SEventDispatch<TEventType>
		{
			protected readonly SLockList<TEventType, Action<int>> items2;

			public virtual void Add(object objKey, TEventType eventType, Action<int> callback)
			{
			}

			public void EmitEvent(TEventType eventType, int v)
			{
			}
		}

		public class Listener : CEventDispatch<EventType>
		{
			public void OnKnifeUnlock(object objKey, Action<int> callback)
			{
			}

			public void OnKnifeLvChanged(object objKey, Action<int> callback)
			{
			}

			public void OnKnifeAttrUpdate(object objKey, Action<int> callback)
			{
			}
		}

		public class UpgradeResult
		{
			public ResultCode resultCode;

			public bool isUnlock;

			public int knifeId;
		}

		private SDataOption<GameData> _option;

		private GameData _data;

		private Dictionary<int, KnifeShowInfo> _knifeInfos;

		private int _maxUpgradePerformanceKnifeId;

		private bool _startQuickUpgrade;

		private int _quickUpgradeTimes;

		public static bool OpenAtkLog;

		private List<int> quickUpgradeKnifes;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		internal override void OnInit()
		{
		}

		public override void OnEnterMainScene()
		{
		}

		private void InitKnifeShowInfos()
		{
		}

		public bool IsValidKnifeId(int knifeId)
		{
			return false;
		}

		public Dictionary<int, KnifeShowInfo> GetKnifeShowInfos()
		{
			return null;
		}

		public KnifeLocalConfig GetKnifeConfig(int knifeId)
		{
			return null;
		}

		public void UpdateAllKnifeInfos()
		{
		}

		private void UpdateKnifeInfo(int knifeId)
		{
		}

		private BigInteger CalcUpgradePerformance(int knifeId, int lv, BigInteger curRealAck)
		{
			return (BigInteger)null;
		}

		private BigInteger CalcAttack(int knifeId, int lv)
		{
			return (BigInteger)null;
		}

		private string GetShowAttackStr(int knifeId, int lv, BigInteger baseAtk)
		{
			return "";
		}

		private string floatToStrLog(double v)
		{
			return "";
		}

		private BigInteger CalcRealAttack(int knifeId, int lv, BigInteger baseAtk)
		{
			return (BigInteger)null;
		}

		private double GetBaseAttackMul(int lv)
		{
			return 0.0;
		}

		private BigInteger CalcUpgradePrice(int knifeId)
		{
			return (BigInteger)null;
		}

		public bool AllowUpgradeKnife(int knifeId)
		{
			return false;
		}

		public UpgradeResult UpgradeKnife(int knifeId, int fromId)
		{
			return null;
		}

		private KnifeData GetKnifeData(int knifeId)
		{
			return null;
		}

		public KnifeShowInfo GetKnifeShowInfo(int knifeId)
		{
			return null;
		}

		public string GetUpgradeBtnState(int knifeId)
		{
			return "";
		}

		public BigInteger GetTotalAttack()
		{
			return (BigInteger)null;
		}

		public bool AllowUnlockFireBall()
		{
			return false;
		}

		public bool AllowUnlockAnyLegendaryWeapon()
		{
			return false;
		}

		public bool AllowUnlockAnyNormalWeapon()
		{
			return false;
		}

		public int GetMaxUnlockableKnifeId()
		{
			return 0;
		}

		public TrailConfig GetTrailConfig(int knifeId)
		{
			return null;
		}

		public void UnlockAllNormalKnife_Test()
		{
		}

		public void AllKnifeAddLv100_Test()
		{
		}

		public void ClearAllKnife_Test()
		{
		}

		internal override void Update(float dt)
		{
		}

		public bool QuickUpgradeKnife()
		{
			return false;
		}

		public int AllowQuickUpgrade()
		{
			return 0;
		}

		private void UpdateMaxUpgradePerformanceKnifeId()
		{
		}

		private int GetMinLockKnifeId()
		{
			return 0;
		}

		public void AddKnifeLv_Test(int knifeId, int lv)
		{
		}
	}
}
