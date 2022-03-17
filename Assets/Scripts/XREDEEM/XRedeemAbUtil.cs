using System;

namespace XREDEEM
{
	public class XRedeemAbUtil
	{
		[Serializable]
		public class XRedeemCoreConfig
		{
			public RedeemConfig redeems;

			public SkinChipConfig skinChip;
		}

		private static XRedeemAbUtil _instance;

		private RedeemConfig _redeemConfig;

		private SkinChipConfig _skinChipConfig;

		public static string defaultChooseStrV3;

		public static XRedeemAbUtil instance => null;

		public static int abTargetLv => 0;

		public static bool openTaskRedeem => false;

		public static string chooseGameAbStr => "";

		public static string chooseGameAbStrV3 => "";

		public static int abVersion => 0;

		public RedeemConfig redeemConfig => null;

		public SkinChipConfig skinChipConfig => null;
	}
}
