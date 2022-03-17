namespace Master
{
	public abstract class SPresenter
	{
		private readonly string _003ClogTag_003Ek__BackingField;

		public virtual string logTag => "";

		internal virtual int Priority()
		{
			return 0;
		}

		internal virtual void Update(float dt)
		{
		}

		internal virtual void OnSecondTick()
		{
		}

		public string ToLogMessage(params object[] value)
		{
			return "";
		}

		public void LogDebug(params object[] value)
		{
		}

		public virtual void OnAwake()
		{
		}

		internal abstract void OnInit();

		public virtual void OnNewDay()
		{
		}

		public virtual void OnOfflineTimeTick(long offlineTime)
		{
		}

		internal virtual void OnEnter()
		{
		}

		public virtual void OnEnterMainScene()
		{
		}
	}
}
