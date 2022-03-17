using System;
using System.Collections.Generic;

namespace XREDEEM
{
	[Serializable]
	public class XRedeemData
	{
		public int version;

		public int guideId;

		public bool isReceiveGuideVal;

		public int[] selectGameList;

		public Dictionary<string, RedeemRecordData> cashOutRecords;

		public Dictionary<int, UserInfo> userInfos;

		public bool hasGetDailyDiamond;
	}
}
