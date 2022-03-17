using System;
using System.Collections.Generic;

namespace XREDEEM
{
	[Serializable]
	public class RedeemConfig
	{
		[Serializable]
		public class ItemMeta
		{
			public int id;

			public int outType;

			public long rewardVal;

			public long collectTarget;

			public int index;
		}

		[Serializable]
		public class GameMeta
		{
			public int id;

			public string gameName;

			public string name;

			public string style;
		}

		public long guideReward;

		public Dictionary<string, ItemMeta> redeemList;

		public double[] scales;

		public Dictionary<string, GameMeta> gameList;
	}
}
