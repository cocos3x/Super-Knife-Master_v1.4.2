using System;

namespace XREDEEM
{
	[Serializable]
	public class RedeemRecordData
	{
		public string orderKey;

		public string orderKey2;

		public int redeemId;

		public long createTime;

		public long rewardVal;

		public int collectType;

		public long collectTarget;

		public string centerText;

		public float queueRatio;

		public int queueIndex;

		public int gameType;
	}
}
