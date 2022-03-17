using System;
using System.Collections.Generic;

namespace XREDEEM
{
	[Serializable]
	public class SkinChipData
	{
		public int guideId;

		public Dictionary<string, SkinData> skinDatas;

		public bool finishGuideReward;
	}
}
