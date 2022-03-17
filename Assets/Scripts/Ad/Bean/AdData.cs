using System;
using System.Collections.Generic;

namespace Ad.Bean
{
	[Serializable]
	public class AdData
	{
		public int totalRewardAdPlayCount;

		public int dailyRewardAdPlayCount;

		public int totalFullAdPlayCount;

		public int dailyFullAdPlayCount;

		public Dictionary<string, int> totalCounts;

		public Dictionary<string, int> dailyCounts;
	}
}
