using System;
using System.Collections.Generic;
using UnityEngine;

namespace Master
{
	public class SPlayer
	{
		public enum EventType
		{
			OnGameInitFinish,
			OnSecondTick,
			OnRunningChange,
			OnUpdate,
			OnNewDay
		}

		private class SPlayerComponent : MonoBehaviour
		{
			internal SPlayer _player;

			private void Update()
			{
			}

			private void OnApplicationPause(bool pauseStatus)
			{
			}

			private void OnApplicationQuit()
			{
			}
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnGameInitFinish(object objKey, Action callback)
			{
			}

			public void OnSecondTick(object objKey, Action callback)
			{
			}

			public void OnRunningChange(object objKey, Action callback)
			{
			}

			public void OnUpdate(object objKey, Action callback)
			{
			}

			public void OnNewDay(object objKey, Action callback)
			{
			}
		}

		public delegate void UpdateCallback();

		[Serializable]
		private sealed class _003C_003Ec__42<T> where T : SPresenter
		{
			public static readonly _003C_003Ec__42<T> _003C_003E9;

			public static Comparison<SPresenter> _003C_003E9__42_0;

			internal int _003CAddPresenter_003Eb__42_0(SPresenter c1, SPresenter c2)
			{
				return 0;
			}
		}

		public static bool IsEmptyPackage;

		private static readonly SPlayer _003Cinstance_003Ek__BackingField;

		protected static List<SPresenter> s_presenters;

		private static List<ISRemoveAbleContainer> s_presenterListeners;

		public static readonly STimer timer;

		private static readonly Listener _003Clistener_003Ek__BackingField;

		private static long _003CcurTime_003Ek__BackingField;

		private static int _pauseGame;

		private static bool _isPauseGameOtherTag;

		public static bool useNetworkTime;

		private static UpdateCallback s_updateCallback;

		protected bool _isInit;

		private float _secondTickInterval;

		private bool _isGameInitFinish;

		private static bool _isRunning;

		private static int _runningState;

		private bool _isInitAllPresenter;

		public static SPlayer instance => null;

		public static Listener listener => null;

		public static long curTime
		{
			get
			{
				return 0L;
			}
			private set
			{
			}
		}

		public static bool isTimeOk => false;

		public bool isInitValid => false;

		public static bool isRunning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool isPauseGameOtherTag
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static float totalPlayTime => 0f;

		public static float offlineTime => 0f;

		public long countdownNewDay => 0L;

		private static void UpdateRunningState()
		{
		}

		protected SPlayer()
		{
		}

		public void CheckInit()
		{
		}

		public void OnEnterMainScene()
		{
		}

		private void LoadAllPresenter()
		{
		}

		protected virtual void OnTimeUpdate(long time)
		{
		}

		protected virtual void OnNewDay()
		{
		}

		public static T AddPresenter<T>(T presenter) where T : SPresenter
		{
			return null;
		}

		public static T GetPresenter<T>() where T : SPresenter
		{
			return null;
		}

		public static bool HasPresenter(Type t)
		{
			return false;
		}

		protected virtual void Update()
		{
		}

		public static void AddUpdate(UpdateCallback update)
		{
		}

		public static void RemoveUpdate(UpdateCallback update)
		{
		}

		public static void RemoveAllListener(object objKey)
		{
		}

		public virtual void OnGameInitFinish()
		{
		}

		public virtual void RequestServerTime()
		{
		}

		public virtual void ResponseServerTime(long time)
		{
		}

		public static void AddPauseGame()
		{
		}

		public static void CostPauseGame()
		{
		}
	}
}
