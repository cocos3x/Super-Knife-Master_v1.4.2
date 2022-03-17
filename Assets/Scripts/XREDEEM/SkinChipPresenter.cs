using Configure.Tips;
using Master;
using System;
using System.Collections.Generic;

namespace XREDEEM
{
	public class SkinChipPresenter : Presenter<SkinChipPresenter>
	{
		public enum EventType
		{
			OnSkinChipCountChange
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnSkinChipCountChange(object objKey, Action callback)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<string, int, string> _003C_003E9__23_0;

			public static Comparison<SkinChipShowEntry> _003C_003E9__32_0;

			public static Func<string, int, string> _003C_003E9__49_0;

			internal string _003CGetRandomSkinChipRoleMeta_003Eb__23_0(string current, int weight)
			{
				return "";
			}

			internal int _003CGetSkinChipShowList_003Eb__32_0(SkinChipShowEntry entityA, SkinChipShowEntry entityB)
			{
				return 0;
			}

			internal string _003CGetMaxWeightSkinMeta_003Eb__49_0(string current, int weight)
			{
				return "";
			}
		}

		private SDataOption<SkinChipData> _option;

		private SkinChipData _data;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		public List<RedeemGameType> AllGameTypes => null;

		public SkinChipConfig skinChipConfig => null;

		public long minSkinChipProgress => 0L;

		public long offRatio => 0L;

		public bool isSkinChipOff => false;

		public int guideId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool finishNewGuideReward
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override void OnInit()
		{
		}

		private void CheckUpgradeData()
		{
		}

		public override void OnNewDay()
		{
		}

		private SkinData GetCurRewardChipData(RedeemGameType type, int skinChipId)
		{
			return null;
		}

		public void AddRewardChipCount(RedeemGameType type, int skinChipId, long rewardChipCount, SkinChipRewardDialog.SkinFromId fromId)
		{
		}

		private int GetStepIndex(double ratio)
		{
			return 0;
		}

		private SkinChipConfig.SkinChipMeta GetRandomSkinChipRoleMeta(RedeemGameType type)
		{
			return null;
		}

		public List<SkinChipRewardEntry> GetRandomChipList(RedeemGameType gameType = RedeemGameType.Error)
		{
			return null;
		}

		private List<RedeemGameType> GetRandomRewardGamesV2()
		{
			return null;
		}

		public SkinChipRewardEntry GetSingleRewardChip(RedeemGameType type, int skinChipId)
		{
			return null;
		}

		public long GetCurProgress(RedeemGameType type, int skinChipId)
		{
			return 0L;
		}

		private long CalcRewardChipCount(RedeemGameType type, int skinChipId)
		{
			return 0L;
		}

		private SkinChipConfig.SkinChipMeta GetSkinChipMeta(RedeemGameType type, int skinChipId)
		{
			return null;
		}

		private List<SkinChipConfig.SkinChipMeta> GetSkinChipListMeta(RedeemGameType gameType)
		{
			return null;
		}

		public List<List<SkinChipShowEntry>> GetAllSkinChipShowList()
		{
			return null;
		}

		public List<SkinChipShowEntry> GetSkinChipShowList(RedeemGameType gameType)
		{
			return null;
		}

		public SkinChipShowEntry GetSkinChipShowEntry(RedeemGameType type, int skinChipId)
		{
			return null;
		}

		public int GetSkinChipLevelIndex(RedeemGameType type, int skinChipId)
		{
			return 0;
		}

		public bool IsVideoLimit(RedeemGameType type, int skinChipId, bool log = false)
		{
			return false;
		}

		public void OnSkinChipCountChange()
		{
		}

		public void test_SetRewardChipProgressAll(float progress)
		{
		}

		public void test_AddRewardChipCount(RedeemGameType type, int skinChipId, long val)
		{
		}

		public void test_ClearData()
		{
		}

		public void test_allCoolingTime(long val)
		{
		}

		public void test_coolingTime(RedeemGameType type, int skinChipId, long val)
		{
		}

		public ResultCode CheckRedeemOk(RedeemGameType type, int skinChipId)
		{
			//IL_0003: Expected I4, but got O
			return (ResultCode)null;
		}

		public bool HasSkinChipOut(RedeemGameType type, int skinChipId)
		{
			return false;
		}

		public bool CostSkinChip(RedeemGameType type, int skinChipId)
		{
			return false;
		}

		public List<SkinChipRewardEntry> GetNewbieRewardList()
		{
			return null;
		}

		private SkinChipConfig.SkinChipMeta GetMaxWeightSkinMeta(RedeemGameType type)
		{
			return null;
		}
	}
}
