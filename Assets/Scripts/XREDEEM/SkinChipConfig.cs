using System;
using System.Collections.Generic;

namespace XREDEEM
{
	[Serializable]
	public class SkinChipConfig
	{
		[Serializable]
		public class CountWeightItem
		{
			public float progress;

			public int[] weight;
		}

		[Serializable]
		public class SkinChipMeta
		{
			public int id;

			public string level;

			public string msg;

			public string name;

			public float collectChip;

			public string icon;

			public string card;

			public int[] weights;

			public long maxVal => 0L;
		}

		public long[] stepList;

		public long[] rewardCountList;

		public int videoLimitCount;

		public long offRatio;

		public long skinChipDoubled;

		public List<CountWeightItem> config;

		public List<SkinChipMeta> gameML;

		public List<SkinChipMeta> gameFF;

		public List<SkinChipMeta> gameRB;

		public List<SkinChipMeta> gameLOL;

		public List<SkinChipMeta> gamePM;

		public List<SkinChipMeta> gameBS;

		public List<SkinChipMeta> gameLM;

		public List<SkinChipMeta> gameCC;

		public List<SkinChipMeta> gameCD;
	}
}
