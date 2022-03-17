using System;
using System.Collections.Generic;

namespace SaveData
{
	[Serializable]
	public class GameData
	{
		public int version;

		public int openCount;

		public int stageLv;

		public string knifeCoin;

		public string collectKnifeCoin;

		public Dictionary<int, KnifeData> knives;

		public Dictionary<string, BlockData> blocks;

		public Dictionary<int, BuffData> buffs;

		public int evaluateGuide;

		public string stageTotalHp;

		public int guideId;

		public int firstStartStage;

		public int todayGetOfflineTimes;

		public bool finishTapGuide;

		public bool finishUnlock2Guide;

		public int tipsFreeGetTimes;

		public int collect_switch;
	}
}
