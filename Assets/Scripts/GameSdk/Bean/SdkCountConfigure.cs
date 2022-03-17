using System;

namespace GameSdk.Bean
{
	[Serializable]
	public class SdkCountConfigure
	{
		public UsedType UsedType;

		public bool NeedResetEverDay;

		public int MaxCount;

		public override string ToString()
		{
			return "";
		}
	}
}
