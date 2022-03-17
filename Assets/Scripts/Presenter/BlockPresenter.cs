using Core;
using Master;
using SaveData;
using System.Numerics;

namespace Presenter
{
	public class BlockPresenter : Presenter<BlockPresenter>
	{
		public enum EventType
		{

		}

		public class Listener : SEventDispatch<EventType>
		{
		}

		private SDataOption<GameData> _option;

		private GameData _data;

		public BigInteger normalBlockHp;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		internal override void OnInit()
		{
		}

		public BigInteger CalcBlockHp(BlockType type)
		{
			return (BigInteger)null;
		}

		public void UpdateNormalBlockHp()
		{
		}
	}
}
