using Configure.CoreData;
using Master;
using System;

namespace CoreData
{
	public class CoreDataPresenter : Presenter<CoreDataPresenter>
	{
		public enum EventType
		{
			OnAbUpdate
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnAbUpdate(object objKey, Action callback)
			{
			}
		}

		private bool _hadEnterMainScene;

		private GameCoreConfig _gameCoreConfig;

		private string _gameCoreConfigOriginData;

		private GameCoreConfig _defaultCoreConfig;

		private string _defaultCoreConfigOriginData;

		private GameAbData _gameAbData;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public static GameCoreConfig GameCoreConfig => null;

		public static string GameCoreConfigOriginData => "";

		public static GameAbData GameAbData => null;

		public GameCoreConfig coreConfig => null;

		public string coreConfigOriginData => "";

		public Listener listener => null;

		internal override int Priority()
		{
			return 0;
		}

		internal override void OnInit()
		{
		}

		private void InitData()
		{
		}

		private GameCoreConfig LoadConfigWithVersion(int version, ref string originData)
		{
			return null;
		}

		public override void OnEnterMainScene()
		{
		}

		private void LoadAbValue(string serverName, object obj)
		{
		}

		private void SyncSdkGameData(bool isCache)
		{
		}
	}
}
