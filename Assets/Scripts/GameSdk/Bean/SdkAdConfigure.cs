using System;
using System.Collections.Generic;

namespace GameSdk.Bean
{
	[Serializable]
	public class SdkAdConfigure
	{
		public const int PositionOpen = 1;

		public const int PositionFull = 2;

		public const int PositionReward = 3;

		public const int PositionBanner = 4;

		public SdkAdConfigureType SdkAdConfigureType;

		public string StatictKey;

		public List<SdkFilterConfigure> AdFilterConfigures;

		public List<SdkCountConfigure> AdCountConfigures;

		public int position => 0;

		public override string ToString()
		{
			return "";
		}
	}
}
