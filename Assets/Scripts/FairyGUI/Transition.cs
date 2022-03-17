using FairyGUI.Utils;

namespace FairyGUI
{
	public class Transition : ITweenListener
	{
		private sealed class _003C_003Ec__DisplayClass76_0
		{
			public Transition _003C_003E4__this;

			public TransitionItem item;

			internal void _003CDecodeValue_003Eb__0()
			{
			}
		}

		private string _003Cname_003Ek__BackingField;

		public bool invalidateBatchingEveryFrame;

		private GComponent _owner;

		private TransitionItem[] _items;

		private int _totalTimes;

		private int _totalTasks;

		private bool _playing;

		private bool _paused;

		private float _ownerBaseX;

		private float _ownerBaseY;

		private PlayCompleteCallback _onComplete;

		private int _options;

		private bool _reversed;

		private float _totalDuration;

		private bool _autoPlay;

		private int _autoPlayTimes;

		private float _autoPlayDelay;

		private float _timeScale;

		private bool _ignoreEngineTimeScale;

		private float _startTime;

		private float _endTime;

		private GTweenCallback _delayedCallDelegate;

		private GTweenCallback _checkAllDelegate;

		private GTweenCallback1 _delayedCallDelegate2;

		private const int OPTION_IGNORE_DISPLAY_CONTROLLER = 1;

		private const int OPTION_AUTO_STOP_DISABLED = 2;

		private const int OPTION_AUTO_STOP_AT_END = 4;

		public string name
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public bool playing => false;

		public float timeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreEngineTimeScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transition(GComponent owner)
		{
		}

		public void Play()
		{
		}

		public void Play(PlayCompleteCallback onComplete)
		{
		}

		public void Play(int times, float delay, PlayCompleteCallback onComplete)
		{
		}

		public void Play(int times, float delay, float startTime, float endTime, PlayCompleteCallback onComplete)
		{
		}

		public void PlayReverse()
		{
		}

		public void PlayReverse(PlayCompleteCallback onComplete)
		{
		}

		public void PlayReverse(int times, float delay, PlayCompleteCallback onComplete)
		{
		}

		public void ChangePlayTimes(int value)
		{
		}

		public void SetAutoPlay(bool autoPlay, int times, float delay)
		{
		}

		private void _Play(int times, float delay, float startTime, float endTime, PlayCompleteCallback onComplete, bool reverse)
		{
		}

		public void Stop()
		{
		}

		public void Stop(bool setToComplete, bool processCallback)
		{
		}

		private void StopItem(TransitionItem item, bool setToComplete)
		{
		}

		public void SetPaused(bool paused)
		{
		}

		public void Dispose()
		{
		}

		public void SetValue(string label, params object[] aParams)
		{
		}

		public void SetHook(string label, TransitionHook callback)
		{
		}

		public void ClearHooks()
		{
		}

		public void SetTarget(string label, GObject newTarget)
		{
		}

		public void SetDuration(string label, float value)
		{
		}

		public float GetLabelTime(string label)
		{
			return 0f;
		}

		internal void UpdateFromRelations(string targetId, float dx, float dy)
		{
		}

		internal void OnOwnerAddedToStage()
		{
		}

		internal void OnOwnerRemovedFromStage()
		{
		}

		private void OnDelayedPlay()
		{
		}

		private void InternalPlay()
		{
		}

		private void PlayItem(TransitionItem item)
		{
		}

		private void SkipAnimations()
		{
		}

		private void OnDelayedPlayItem(GTweener tweener)
		{
		}

		public void OnTweenStart(GTweener tweener)
		{
		}

		public void OnTweenUpdate(GTweener tweener)
		{
		}

		public void OnTweenComplete(GTweener tweener)
		{
		}

		private void OnPlayTransCompleted(TransitionItem item)
		{
		}

		private void CallHook(TransitionItem item, bool tweenEnd)
		{
		}

		private void CheckAllComplete()
		{
		}

		private void ApplyValue(TransitionItem item)
		{
		}

		public void Setup(ByteBuffer buffer)
		{
		}

		private void DecodeValue(TransitionItem item, ByteBuffer buffer, object value)
		{
		}
	}
}
