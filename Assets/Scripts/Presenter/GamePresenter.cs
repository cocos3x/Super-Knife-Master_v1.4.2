using Core;
using Master;
using SaveData;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Presenter
{
	public class GamePresenter : Presenter<GamePresenter>
	{
		public enum EventType
		{
			OnStageLvChanged
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnStageLvChanged(object objKey, Action callback)
			{
			}
		}

		private SDataOption<GameData> _option;

		private GameData _data;

		private BigInteger _stageTotalHp;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public int firstStartStage
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Listener listener => null;

		public int stageLv
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool isBossStage => false;

		public Dictionary<string, BlockData> blockDatas => null;

		public BigInteger stageTotalHp
		{
			get
			{
				return (BigInteger)null;
			}
			set
			{
			}
		}

		public int enterGameTimes => 0;

		public bool finishUnlock2Guide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool openCollect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal override void OnInit()
		{
		}

		public List<BlockType> GetStageBlocks()
		{
			return null;
		}

		private void CheckBlockDead()
		{
		}

		public bool IsAllBlockDead()
		{
			return false;
		}

		public void RecordBlocks(List<BlockData> tempRecordList, bool saveNow = false)
		{
		}

		public void SetBlockDead(string key)
		{
		}

		public override void OnEnterMainScene()
		{
		}
	}
}
