namespace FairyGUI
{
	public class MovieClip : Image
	{
		public class Frame
		{
			public NTexture texture;

			public float addDelay;
		}

		public float interval;

		public bool swing;

		public float repeatDelay;

		public float timeScale;

		public bool ignoreEngineTimeScale;

		private Frame[] _frames;

		private int _frameCount;

		private int _frame;

		private bool _playing;

		private int _start;

		private int _end;

		private int _times;

		private int _endAt;

		private int _status;

		private float _frameElapsed;

		private bool _reversed;

		private int _repeatedCount;

		private TimerCallback _timerDelegate;

		private EventListener _onPlayEnd;

		public EventListener onPlayEnd => null;

		public Frame[] frames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool playing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int frame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void Rewind()
		{
		}

		public void SyncStatus(MovieClip anotherMc)
		{
		}

		public void Advance(float time)
		{
		}

		public void SetPlaySettings()
		{
		}

		public void SetPlaySettings(int start, int end, int times, int endAt)
		{
		}

		private void OnAddedToStage()
		{
		}

		private void OnRemoveFromStage()
		{
		}

		private void CheckTimer()
		{
		}

		private void OnTimer(object param)
		{
		}

		private void DrawFrame()
		{
		}
	}
}
