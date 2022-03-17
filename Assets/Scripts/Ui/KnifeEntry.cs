using Core;
using FairyGUI;
using Master;

namespace Ui
{
	public class KnifeEntry : GComponent
	{
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public int index;

			public KnifeEntry _003C_003E4__this;

			public int levelCnt;

			internal void _003COnLongTouchUpgradeBtn_003Eb__0()
			{
			}
		}

		private GTextField _nameText;

		private GTextField _lvText;

		private GTextField _atkText;

		private GLoader _iconLoader;

		public GButton buyBtn;

		private KnifeShowInfo _showInfo;

		public int knifeId;

		private GButton _btnInfo;

		private STimer _timer;

		private string _longTouchTimerName;

		public static bool stopUpdateUi;

		private GComponent _upgradeTips;

		private bool _isShowingUpgradeEffect;

		public override void ConstructFromResource()
		{
		}

		public void Init(KnifeShowInfo info)
		{
		}

		private void InitListener()
		{
		}

		private void InitTouch()
		{
		}

		private void RemoveLongTouchTimer()
		{
		}

		private void OnLongTouchUpgradeBtn()
		{
		}

		public override void Dispose()
		{
		}

		private bool OnClickUpgradeBtn()
		{
			return false;
		}

		private void UpdateBuyBtn()
		{
		}

		public void UpdateUi()
		{
		}

		public void ShowUpgradeEffect()
		{
		}

		private void _003CInit_003Eb__14_0()
		{
		}

		private void _003CInitListener_003Eb__15_0(int kid)
		{
		}

		private void _003CInitListener_003Eb__15_1(int kid)
		{
		}

		private void _003CInitTouch_003Eb__16_0()
		{
		}

		private void _003CInitTouch_003Eb__16_1(EventContext context)
		{
		}

		private void _003CInitTouch_003Eb__16_2()
		{
		}

		private void _003CShowUpgradeEffect_003Eb__23_0()
		{
		}

		private void _003CShowUpgradeEffect_003Eb__23_1()
		{
		}
	}
}
