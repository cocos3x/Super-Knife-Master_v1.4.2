namespace sdk.bridge
{
	public class TestMgr
	{
		public static readonly TestMgr Instance;

		private string _testConfig;

		public bool NeedLog;

		public bool TestMode;

		public void OnGameInit()
		{
		}

		public T GetTest<T>(string testKey, T defaultVal)
		{
			return (T)null;
		}
	}
}
