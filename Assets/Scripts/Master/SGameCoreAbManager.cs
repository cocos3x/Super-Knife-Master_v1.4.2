namespace Master
{
	public static class SGameCoreAbManager
	{
		public static int GetGameCoreVersion()
		{
			return 0;
		}

		public static void SaveGameCoreVersion<T>(T coreConfig) where T : ISGameCoreVersion
		{
		}

		public static T LoadFromAbGameCoreData<T>(T coreConfig, ref string originData) where T : ISGameCoreVersion
		{
			return (T)null;
		}

		public static T UpdateAbGameCoreData<T>(T coreConfig, string adGameCoreStr, ref string originData) where T : ISGameCoreVersion
		{
			return (T)null;
		}
	}
}
