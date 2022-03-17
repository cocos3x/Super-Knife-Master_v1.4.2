using UnityEngine;

namespace FairyGUI
{
	public class GTweener
	{
		internal object _target;

		internal TweenPropType _propType;

		internal bool _killed;

		internal bool _paused;

		private float _delay;

		private float _duration;

		private float _breakpoint;

		private EaseType _easeType;

		private float _easeOvershootOrAmplitude;

		private float _easePeriod;

		private int _repeat;

		private bool _yoyo;

		private float _timeScale;

		private bool _ignoreEngineTimeScale;

		private bool _snapping;

		private object _userData;

		private GPath _path;

		private CustomEase _customEase;

		private GTweenCallback _onUpdate;

		private GTweenCallback _onStart;

		private GTweenCallback _onComplete;

		private GTweenCallback1 _onUpdate1;

		private GTweenCallback1 _onStart1;

		private GTweenCallback1 _onComplete1;

		private ITweenListener _listener;

		private TweenValue _startValue;

		private TweenValue _endValue;

		private TweenValue _value;

		private TweenValue _deltaValue;

		private int _valueSize;

		private bool _started;

		private int _ended;

		private float _elapsedTime;

		private float _normalizedTime;

		private int _smoothStart;

		public float delay => 0f;

		public float duration => 0f;

		public int repeat => 0;

		public object target => null;

		public object userData => null;

		public TweenValue startValue => null;

		public TweenValue endValue => null;

		public TweenValue value => null;

		public TweenValue deltaValue => null;

		public float normalizedTime => 0f;

		public bool completed => false;

		public bool allCompleted => false;

		public GTweener SetDelay(float value)
		{
			return null;
		}

		public GTweener SetDuration(float value)
		{
			return null;
		}

		public GTweener SetBreakpoint(float value)
		{
			return null;
		}

		public GTweener SetEase(EaseType value)
		{
			return null;
		}

		public GTweener SetEase(EaseType value, CustomEase customEase)
		{
			return null;
		}

		public GTweener SetEasePeriod(float value)
		{
			return null;
		}

		public GTweener SetEaseOvershootOrAmplitude(float value)
		{
			return null;
		}

		public GTweener SetRepeat(int times, bool yoyo = false)
		{
			return null;
		}

		public GTweener SetTimeScale(float value)
		{
			return null;
		}

		public GTweener SetIgnoreEngineTimeScale(bool value)
		{
			return null;
		}

		public GTweener SetSnapping(bool value)
		{
			return null;
		}

		public GTweener SetPath(GPath value)
		{
			return null;
		}

		public GTweener SetTarget(object value)
		{
			return null;
		}

		public GTweener SetTarget(object value, TweenPropType propType)
		{
			return null;
		}

		public GTweener SetUserData(object value)
		{
			return null;
		}

		public GTweener OnUpdate(GTweenCallback callback)
		{
			return null;
		}

		public GTweener OnStart(GTweenCallback callback)
		{
			return null;
		}

		public GTweener OnComplete(GTweenCallback callback)
		{
			return null;
		}

		public GTweener OnUpdate(GTweenCallback1 callback)
		{
			return null;
		}

		public GTweener OnStart(GTweenCallback1 callback)
		{
			return null;
		}

		public GTweener OnComplete(GTweenCallback1 callback)
		{
			return null;
		}

		public GTweener SetListener(ITweenListener value)
		{
			return null;
		}

		public GTweener SetPaused(bool paused)
		{
			return null;
		}

		public void Seek(float time)
		{
		}

		public void Kill(bool complete = false)
		{
		}

		internal GTweener _To(float start, float end, float duration)
		{
			return null;
		}

		internal GTweener _To(Vector2 start, Vector2 end, float duration)
		{
			return null;
		}

		internal GTweener _To(Vector3 start, Vector3 end, float duration)
		{
			return null;
		}

		internal GTweener _To(Vector4 start, Vector4 end, float duration)
		{
			return null;
		}

		internal GTweener _To(Color start, Color end, float duration)
		{
			return null;
		}

		internal GTweener _To(double start, double end, float duration)
		{
			return null;
		}

		internal GTweener _Shake(Vector3 start, float amplitude, float duration)
		{
			return null;
		}

		internal void _Init()
		{
		}

		internal void _Reset()
		{
		}

		internal void _Update()
		{
		}

		private void Update()
		{
		}

		private void CallStartCallback()
		{
		}

		private void CallUpdateCallback()
		{
		}

		private void CallCompleteCallback()
		{
		}
	}
}
