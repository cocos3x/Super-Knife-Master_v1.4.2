using Configure.Tips;
using Master;
using System;
using System.Collections.Generic;

namespace XREDEEM
{
	public class XRedeemPresenter : Presenter<XRedeemPresenter>
	{
		public enum EventType
		{
			OnCashOutOk,
			OnChooseGameChanges,
			OnUpdateRewardUi,
			OnMainGameChanged,
			OnDailyDiamondChanged,
			OnRewardValueUpdate
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnMainGameChanged(object objKey, Action callback)
			{
			}

			public void OnCashOutOk(object objKey, Action callback)
			{
			}

			public void OnChooseGameChanges(object objKey, Action callback)
			{
			}

			public void OnDailyDiamondChanged(object objKey, Action callback)
			{
			}

			public void OnRewardValueUpdate(object objKey, Action callback)
			{
			}
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Func<string, RedeemGameType, string> _003C_003E9__32_0;

			public static Func<string, int, string> _003C_003E9__32_1;

			public static Comparison<GameShowEntry> _003C_003E9__33_0;

			public static Comparison<RedeemShowEntry> _003C_003E9__42_0;

			public static Func<int, bool> _003C_003E9__50_0;

			internal string _003CGetGameList_003Eb__32_0(string current, RedeemGameType type)
			{
				return "";
			}

			internal string _003CGetGameList_003Eb__32_1(string current, int type)
			{
				return "";
			}

			internal int _003CGetGameShowList_003Eb__33_0(GameShowEntry entityA, GameShowEntry entityB)
			{
				return 0;
			}

			internal int _003CGetRedeemShowList_003Eb__42_0(RedeemShowEntry entityA, RedeemShowEntry entityB)
			{
				return 0;
			}

			internal bool _003Cget_selectGameCount_003Eb__50_0(int gameType)
			{
				return false;
			}
		}

		private SDataOption<XRedeemData> _option;

		private XRedeemData _data;

		private RedeemConfig _redeemConfig;

		private bool _enterMainScene;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public static int[] supportVersions;

		private long _lastDiamondAtom;

		private long _lastGoldAtom;

		public bool isReceiveGuideVal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Listener listener => null;

		public int guideId
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public long TaskTargetCurrentVal => 0L;

		public long TaskTarget => 0L;

		public long TaskTargetConfig => 0L;

		public RedeemConfig redeemConfig => null;

		public Dictionary<string, RedeemConfig.ItemMeta> redeemMeta => null;

		public List<RedeemGameType> DefaultGameType => null;

		private Dictionary<string, RedeemConfig.GameMeta> configGameList => null;

		private List<RedeemGameType> AllRedeemGameTypesConfig => null;

		public List<RedeemGameType> AllRedeemGameTypes => null;

		public int selectGameCount => 0;

		public int[] selectGameList => null;

		public RedeemGameType firstSelectGame => (RedeemGameType)null;

		public RedeemGameType secondSelectGame => (RedeemGameType)null;

		public RedeemGameType thirdSelectGame => (RedeemGameType)null;

		public long minTargetDiamond => 0L;

		public long minTargetGold => 0L;

		public string mainGameUserName => "";

		public int xRedeemVersion
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool hasGetDailyDiamond
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool HasTaskTarget(long targetVal)
		{
			return false;
		}

		internal override void OnInit()
		{
		}

		private void CheckUpgradeData()
		{
		}

		public void OnChooseGameChanges()
		{
		}

		public RedeemConfig.ItemMeta GetRedeemItem(int redeemId)
		{
			return null;
		}

		public RedeemGameType[] GetGameList()
		{
			return null;
		}

		public List<GameShowEntry> GetGameShowList()
		{
			return null;
		}

		public List<GameShowEntry> GetSelectableGames()
		{
			return null;
		}

		private GameShowEntry GetGameShowEntry(RedeemGameType redeemGameType)
		{
			return null;
		}

		public List<RedeemShowEntry> GetRedeemShowList()
		{
			return null;
		}

		public RedeemShowEntry GetTaskRedeemEntry()
		{
			return null;
		}

		public RedeemShowEntry GetRedeemShowEntry(int redeemId)
		{
			return null;
		}

		private static GameOutType RedeemIdToType(int redeemId)
		{
			//IL_0003: Expected I4, but got O
			return (GameOutType)null;
		}

		public ResultCode AllowDoRedeem(int redeemId)
		{
			//IL_0003: Expected I4, but got O
			return (ResultCode)null;
		}

		public ResultCode DoRedeem(int redeemId, RedeemGameType redeemGameType, string inputVal = "")
		{
			//IL_0003: Expected I4, but got O
			return (ResultCode)null;
		}

		private bool DoCreatOrder(RedeemGameType redeemGameType, int redeemId, string msg)
		{
			return false;
		}

		public ResultCode SetFirstSelectGame(RedeemGameType gameType)
		{
			//IL_0003: Expected I4, but got O
			return (ResultCode)null;
		}

		public ResultCode SubmitSelection(RedeemGameType gameType)
		{
			//IL_0003: Expected I4, but got O
			return (ResultCode)null;
		}

		public bool HasSelectGame()
		{
			return false;
		}

		public bool HasSelectGame(RedeemGameType gameType)
		{
			return false;
		}

		public bool HasRedeemOut(GameOutType outType)
		{
			return false;
		}

		public void ClearSelectGameData_Test()
		{
		}

		public UserInfo GetUserInfo(RedeemGameType gameType)
		{
			return null;
		}

		public string GetUserName(RedeemGameType gameType)
		{
			return "";
		}

		public void SetUserName(RedeemGameType gameType, string name)
		{
		}

		public override void OnEnterMainScene()
		{
		}

		public int GetGameSelectTimes(RedeemGameType gameType)
		{
			return 0;
		}

		public override void OnNewDay()
		{
		}

		internal override void Update(float dt)
		{
		}

		private void CheckRewardValueUpdate()
		{
		}
	}
}
