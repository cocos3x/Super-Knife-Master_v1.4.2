using Presenter;
using System;

namespace SaveData
{
	[Serializable]
	public class BuffData
	{
		public BuffPresenter.BuffType type;

		public long duration;

		public int todayCnt;
	}
}
