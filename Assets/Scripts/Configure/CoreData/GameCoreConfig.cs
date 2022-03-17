using ExcelConfig;
using Master;
using Reward;
using System;
using System.Collections.Generic;
using XREDEEM;

namespace Configure.CoreData
{
	[Serializable]
	public class GameCoreConfig : ISGameCoreVersion
	{
		public GameSundryConfig sundryConfig;

		public List<BaseRewardConfigItem> baseReward;

		public List<RewardRatioItem> diamondCoefs;

		public List<RewardRatioItem> couponCoefs;

		public List<RewardBlockConfigItem> rewardBlocks;

		public string[] multipleList;

		public List<MultipleWeightConfig> multipleWeights;

		public List<NewbieStageConfig> newbieBlock;

		public Dictionary<int, KnifeAbConfig> weaponConfig;

		public List<StageFreeCoef> stageFreeCoef;

		public SkinChipConfig skinChip;

		public RedeemConfig redeems;

		public int version;

		public int subVersion;

		public int minSubVersion;

		public int GetVersion()
		{
			return 0;
		}

		public int GetSubVersion()
		{
			return 0;
		}

		public int GetMinSubVersion()
		{
			return 0;
		}

		public long GetCollectTarget(RewardItemType itemType)
		{
			return 0L;
		}
	}
}
