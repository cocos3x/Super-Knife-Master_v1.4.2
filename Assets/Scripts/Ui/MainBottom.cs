using Configure.Ad;
using FairyGUI;
using Presenter;
using System.Collections.Generic;

namespace Ui
{
	public class MainBottom : GComponent
	{
		public enum TabType
		{
			Buff = 1,
			Weapon,
			Legendary
		}

		private sealed class _003C_003Ec__DisplayClass25_0
		{
			public MainBottom _003C_003E4__this;

			public TabType type;

			internal void _003CAddTabBtn_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass47_0
		{
			public GComponent tip;

			internal void _003CShowQuickUpgradeEffectOnTap_003Eb__0()
			{
			}
		}

		private GButton _btnBuff;

		private GButton _btnLegendary;

		private GButton _btnWeapon;

		private GObject _tabBg;

		private Dictionary<TabType, GButton> tabs;

		public BuffPresenter.BuffType clickBuffType;

		private Dictionary<BuffPresenter.BuffType, BuffEntry> _buffEntrys;

		private Dictionary<int, KnifeEntry> _knifeEntrys;

		private Dictionary<int, KnifeEntry> _legendaryEntrys;

		public TabType CurTabType;

		public bool isShowingTapGuide;

		private GObject _tapFinger;

		public GComponent _weaponList;

		private GComponent _buffList;

		private bool isShowingLegendaryGuide;

		private GObject _legendaryFinger;

		private GComponent _legendaryList;

		private bool _showingUnlock2Guide;

		private GObject _unlock2Finger;

		public GObject firstKnifeBtn => null;

		public GButton buffTap => null;

		public void Init()
		{
		}

		public override void Dispose()
		{
		}

		private void AddTabBtn(TabType type, GButton btnBuff)
		{
		}

		public void ShowTabEntry(TabType type, bool showTween = false)
		{
		}

		private void InitLegendaryList()
		{
		}

		private void InitBuffList()
		{
		}

		private void UpdateAllBuffUi()
		{
		}

		public void OnQuickUpgradeFinish(List<int> quickUpgradeKnifes)
		{
		}

		public void UpdateAllKnifeEntry()
		{
		}

		private void InitWeaponList()
		{
		}

		private void CheckWeaponUnlockGuide()
		{
		}

		public void CheckBuffGuide()
		{
		}

		private void UpdateTapFingerPos()
		{
		}

		public void FinishTapGuide()
		{
		}

		public void CheckLegendaryGuide()
		{
		}

		private void CheckUpdateLegendaryGuiderPos()
		{
		}

		public void FinishLegendaryGuide()
		{
		}

		private void RemoveLegendaryFinger()
		{
		}

		public void CheckUnlock2Guide()
		{
		}

		private void UpdateUnlock2GuidePos()
		{
		}

		private void FinishUnlock2Guide()
		{
		}

		public void Scroll2BuffEntry(BuffPresenter.BuffType buffType)
		{
		}

		public BuffEntry GetBuffEntry(BuffPresenter.BuffType buffType)
		{
			return null;
		}

		private void ShowQuickUpgradeEffectOnTap(TabType tabType)
		{
		}

		private void _003CInit_003Eb__23_0(int kId)
		{
		}

		private void _003CInitBuffList_003Eb__29_0(SdkIdentify adPointId)
		{
		}
	}
}
