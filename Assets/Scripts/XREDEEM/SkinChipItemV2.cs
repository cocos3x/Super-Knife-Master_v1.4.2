using FairyGUI;
using FairyGUI.Utils;

namespace XREDEEM
{
	public class SkinChipItemV2 : GComponent
	{
		private sealed class _003C_003Ec__DisplayClass11_0
		{
			public SkinChipItemV2 _003C_003E4__this;

			public SkinChipShowEntry skinEntry;

			internal void _003CInit_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_0
		{
			public SkinChipItemV2 _003C_003E4__this;

			public GList testList;

			internal void _003CInitTest_003Eg__CreateTestBtn_007C0(string titleStr, EventCallback0 callback)
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_1
		{
			public long val;

			public _003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals1;

			internal void _003CInitTest_003Eb__1()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass23_2
		{
			public long val;

			public _003C_003Ec__DisplayClass23_0 CS_0024_003C_003E8__locals2;

			internal void _003CInitTest_003Eb__2()
			{
			}
		}

		public static string ITEMURL;

		private SkinChipShowEntry _skinEntry;

		private GButton _btnRedeem;

		private GProgressBar _progressBar;

		private GLoader _iconLabel;

		private GTextField _progressTitle;

		private GTextField _nameText;

		private GButton _btnClaim;

		private GTextField _btnClaimTime;

		private int _skinChipId;

		private bool isVideoLimit => false;

		private bool isCoolingEnd => false;

		private long coolingTime => 0L;

		public override void ConstructFromXML(XML xml)
		{
		}

		public void Init(SkinChipShowEntry skinEntry)
		{
		}

		private void OnSecondTick()
		{
		}

		public override void Dispose()
		{
		}

		private void InitTouchEvent()
		{
		}

		private void UpdateShowEntry()
		{
		}

		private void UpdateUi()
		{
		}

		private void InitTest()
		{
		}

		private void _003CInitTouchEvent_003Eb__20_0()
		{
		}

		private void _003CInitTouchEvent_003Eb__20_1()
		{
		}
	}
}
