using System;

namespace Master
{
	public class SDateManager
	{
		private class GameTimeData
		{
			public long time;

			public long createTime;

			public long playTime;

			public long loginTime;

			public void Load()
			{
			}

			public void Save()
			{
			}
		}

		private static SDateManager s_instance;

		private long _curTime;

		private bool _isInit;

		private GameTimeData _data;

		private long _lastSaveTime;

		private long _nextNewDay;

		private int _requestCount;

		private long _offlineTime;

		private bool _isDirty;

		private int _saveInterval;

		private float _requestPassTime;

		private float _requestInterval;

		private Action<long> _onTimeUpdateCallback;

		private Action _onNewDayCallback;

		private Action _requestServerTimeImpl;

		private long _countdownNewDay;

		private static bool _requestTimeOk;

		private float _secondTickInterval;

		public static SDateManager instance => null;

		public long countdownNewDay => 0L;

		public static bool requestTimeOk => false;

		public float playTime => 0f;

		public long offlineTime => 0L;

		public void CheckInit()
		{
		}

		private static long GetNextNewDayWithLocalTime(long secondTick)
		{
			return 0L;
		}

		private int CalcRequestTimeInterval()
		{
			return 0;
		}

		public void SendGetTimeRequest()
		{
		}

		public void EnterForeground()
		{
		}

		private void RequestTime()
		{
		}

		public void OnTimeResponse(long timeStampSeconds)
		{
		}

		private void SetCurrentTime(long time)
		{
		}

		private void SaveData()
		{
		}

		public void AddNewDayCallback(Action callback)
		{
		}

		public void RemoveNewDayCallback(Action callback)
		{
		}

		public void AddTimeUpdateCallback(Action<long> callback)
		{
		}

		public void RemoveTimeUpdateCallback(Action<long> callback)
		{
		}

		public void AddRequestServerTimeImpl(Action callback)
		{
		}

		public void RemoveRequestServerTimeImpl(Action callback)
		{
		}

		private void OnNewDay()
		{
		}

		private void OnSecondTick()
		{
		}

		public void Update()
		{
		}
	}
}
