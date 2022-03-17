using Configure.Ad;
using FairyGUI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace XREDEEM
{
	public class XRedeemHelper
	{
		private sealed class _003CPreloadUiAssets_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPreloadUiAssets_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		public const string Version = "XRdeem_2.0.0";

		private static XRedeemHelper _instance;

		private bool _hasInit;

		public static string commonPkg;

		public static string skinPkg;

		public static string redeemPkgV1;

		public static string redeemPkgV2;

		public static string redeemPkgV3;

		public static SdkIdentify skinChipVideoId;

		public static SdkIdentify skinChipFullId;

		public static XRedeemHelper instance => null;

		public long TaskTargetCurrentVal => 0L;

		public static long TaskTarget => 0L;

		public string taskProgressStr => "";

		public float skinProgress => 0f;

		public bool isSkinChipOff => false;

		public void Init(GButton redeemBtn, GButton skinBtn)
		{
		}

		private IEnumerator PreloadUiAssets()
		{
			return null;
		}

		public static void CheckGameGuide()
		{
		}

		public string GetGameCoinIcon(RedeemGameType gameType)
		{
			return "";
		}

		public string GetGameCoinIconBig(RedeemGameType gameType)
		{
			return "";
		}

		public string GetMainGameCoinIcon()
		{
			return "";
		}

		public long GetMainGameRewardCount()
		{
			return 0L;
		}

		public void Track_ClickRedeem()
		{
		}

		public void Track_ClickSkinChip()
		{
		}

		public SkinRewardGroup GetSkinRewardGroup()
		{
			return null;
		}

		public string GetRewardTypeIcon(GameOutType outType)
		{
			return "";
		}

		public void OpenRedeemDialog()
		{
		}

		public void OpenSkinDialog()
		{
		}

		public long GetDailyRewardDiamondV3()
		{
			return 0L;
		}
	}
}
