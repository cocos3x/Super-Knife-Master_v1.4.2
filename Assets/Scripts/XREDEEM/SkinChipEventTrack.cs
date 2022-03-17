using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace XREDEEM
{
	public class SkinChipEventTrack
	{
		public static void Track512(string eventName, [Optional] string ebk1, [Optional] string ebk2, [Optional] Dictionary<string, string> expands)
		{
		}

		public static void ShowSkinRedeem()
		{
		}

		public static void ShowSkinReward(RedeemGameType gameType, int skinChipId)
		{
		}

		public static void ShowSuccess(RedeemGameType gameType)
		{
		}

		public static void OnSkinChipReward(long skinDataCurCount, int type, int fromId, int skinChipId)
		{
		}
	}
}
