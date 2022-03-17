using System;
using System.Collections.Generic;

namespace Reward
{
	[Serializable]
	public class RewardData
	{
		public int version;

		public Dictionary<RewardItemType, long> items;

		public Dictionary<RewardItemType, long> histories;
	}
}
