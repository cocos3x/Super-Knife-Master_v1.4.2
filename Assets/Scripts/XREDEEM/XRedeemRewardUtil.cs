namespace XREDEEM
{
	public static class XRedeemRewardUtil
	{
		public static long goldAtom => 0L;

		public static long diamondAtom => 0L;

		public static string goldStr => "";

		public static string diamondStr => "";

		public static void AddReward(GameOutType type, long v, bool showEffect = false)
		{
		}

		public static void AddRewardAtom(GameOutType type, long atomV, bool showEffect = false)
		{
		}

		public static bool HasRewardAtom(GameOutType type, long atomV)
		{
			return false;
		}

		public static bool CostRewardAtom(GameOutType type, long atomV)
		{
			return false;
		}

		public static long ToAtomUnit(long v)
		{
			return 0L;
		}

		public static string ToDiamondString(long v)
		{
			return "";
		}

		public static string ToDiamondAtomString(long atomValue, int keepPointCount = 3)
		{
			return "";
		}

		public static string ToGoldAtomString(long goldAtom)
		{
			return "";
		}

		public static string ToThousandDecimalsString(double v)
		{
			return "";
		}
	}
}
