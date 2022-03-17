using Master;
using SaveData;
using System;
using System.Numerics;

namespace Presenter
{
	public class OfflinePresenter : Presenter<OfflinePresenter>
	{
		public enum EventType
		{
			OnOfflineReward
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnOfflineReward(object objKey, Action callback)
			{
			}
		}

		private long _maxTimeLimit;

		public long offlineInterval;

		private SDataOption<GameData> _option;

		private GameData _data;

		public long curOfflineTime;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		public int todayGetOfflineTimes
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal override void OnInit()
		{
		}

		public override void OnOfflineTimeTick(long seconds)
		{
		}

		public BigInteger CalcOfflineReward(long offlineTime)
		{
			return (BigInteger)null;
		}

		public override void OnNewDay()
		{
		}

		public bool AllowShowOfflineDialog()
		{
			return false;
		}

		internal override void OnSecondTick()
		{
		}
	}
}
