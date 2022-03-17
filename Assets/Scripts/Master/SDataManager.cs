using System.Collections.Generic;

namespace Master
{
	public class SDataManager
	{
		private const string SaveKey = "__Option_";

		private const string PlaceSaveKey = "__PlaceOption_";

		private static readonly List<ISDataOption> _options;

		private bool _isInit;

		private static bool _needFlushData;

		private static readonly SDataManager _003Cinstance_003Ek__BackingField;

		public static SDataManager instance => null;

		private SDataManager()
		{
		}

		public void CheckInit()
		{
		}

		private static SDataOption<T> AddOption<T>(string name)
		{
			return null;
		}

		public static SDataOption<T> GetOption<T>()
		{
			return null;
		}

		public void Update()
		{
		}

		private static void SaveData(ISDataOption option)
		{
		}

		public static void NeedFlushData()
		{
		}

		private void LoadData(ISDataOption option)
		{
		}

		private void LoadAllData()
		{
		}

		public void SaveAllDataNow()
		{
		}

		public void SaveAllDataOnFrame()
		{
		}

		public static void SaveDataNow(ISDataOption option)
		{
		}
	}
}
