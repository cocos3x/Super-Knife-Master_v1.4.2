using Master;
using SaveData;
using System;
using System.Numerics;

namespace Reward
{
	public class KnifeCoinPresenter : Presenter<KnifeCoinPresenter>
	{
		public enum EventType
		{
			OnKnifeCoinChanged,
			ShowKnifeCoinFlyEffect,
			OnCollectKnifeCoinChanged,
			ShowCollectKnifeCoinFlyEffect
		}

		public class Listener : SEventDispatch<EventType>
		{
			public void OnKnifeCoinChanged(object objKey, Action callback)
			{
			}

			public void ShowKnifeCoinFlyEffect(object objKey, Action callback)
			{
			}

			public void OnCollectKnifeCoinChanged(object objKey, Action callback)
			{
			}

			public void ShowCollectKnifeCoinFlyEffect(object objKey, Action callback)
			{
			}
		}

		private SDataOption<GameData> _option;

		private GameData _data;

		public bool showCollectFly;

		private BigInteger _knifeCoin;

		private BigInteger _collectKnifeCoin;

		private readonly Listener _003Clistener_003Ek__BackingField;

		public Listener listener => null;

		public BigInteger knifeCoin
		{
			get
			{
				return (BigInteger)null;
			}
			private set
			{
			}
		}

		public BigInteger collectKnifeCoin
		{
			get
			{
				return (BigInteger)null;
			}
			private set
			{
			}
		}

		public string collectKnifeCoinString => "";

		public string knifeCoinString => "";

		internal override void OnInit()
		{
		}

		public bool HasKnifeCoin(BigInteger value)
		{
			return false;
		}

		public void AddKnifeCoin(string value, bool showEffect = false)
		{
		}

		public void AddKnifeCoin(BigInteger value, bool showEffect = false)
		{
		}

		public bool CostKnifeCoin(BigInteger value)
		{
			return false;
		}

		public void AddCollectKnifeCoin(BigInteger value, bool showEffect = false)
		{
		}

		public bool CostCollectKnifeCoin(BigInteger value)
		{
			return false;
		}

		public bool HasCollectKnifeCoin(BigInteger value)
		{
			return false;
		}

		public void ClearKnifeCoin()
		{
		}

		public void ClearCollectKnifeCoin()
		{
		}

		public bool AllowShowDoubleKnifeCoin()
		{
			return false;
		}

		private double GetFreeCoef()
		{
			return 0.0;
		}

		public string GetDoubleCollectKnifeCoinLog_Test()
		{
			return "";
		}
	}
}
