using System;

namespace GameSdk.Bean
{
	[Serializable]
	public class SdkFilterConfigure
	{
		public SdkFilterConfigureType SdkFilterConfigureType;

		public bool NeedResetEverDay;

		public string SaveKey;

		public string ControllerKey;

		public int DefaultContent;

		public string ServerIdName => "";

		public override string ToString()
		{
			return "";
		}
	}
}
