using sdk.ad.filter;
using sdk.bridge.interf;
using System.Collections.Generic;

namespace sdk.ad.position
{
	public abstract class AdPosition
	{
		private const string Prefix = "Daily_Count_";

		public readonly int PositionId;

		public readonly string Name;

		private string _key;

		protected List<IAdFilter> AdFilters;

		private int _003CdailyCount_003Ek__BackingField;

		public int dailyCount
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		protected AdPosition(string name, int positionId)
		{
		}

		public abstract string LogTag();

		public void LoadAd()
		{
		}

		public bool HadCache()
		{
			return false;
		}

		public void AddAdFilter(params IAdFilter[] adFilter)
		{
		}

		protected bool CheckFilter4Load()
		{
			return false;
		}

		protected bool CheckFilter4Show()
		{
			return false;
		}

		public void OnFilterShow()
		{
		}

		public static void AddAdListener(int positionId, AdAction action)
		{
		}

		public static void RemoveAdListener(int positionId, AdAction action)
		{
		}

		public void OnNewDay()
		{
		}

		private bool _003CCheckFilter4Show_003Eb__15_0(IAdFilter adFilter)
		{
			return false;
		}
	}
}
