using Configure.Ad;
using FairyGUI;
using Presenter;

namespace Ui
{
	public class BuffEntry : GComponent
	{
		private GTextField _nameText;

		private GTextField _lvText;

		private GTextField _atkText;

		public GLoader iconLoader;

		public GButton btnAd;

		private BuffPresenter.BuffInfo _info;

		private BuffPresenter.BuffType _type;

		private SdkIdentify _videoId;

		private MainBottom _mainBottom;

		private GTextField _durationText;

		private GTextField _dailyLimitText;

		private GButton btnBuy;

		public bool forbidUpdate;

		public override void ConstructFromResource()
		{
		}

		public void Init(MainBottom mainBottom, BuffPresenter.BuffType type)
		{
		}

		private void OnClickBuyBtn()
		{
		}

		private void OnClickAdBtn()
		{
		}

		public override void Dispose()
		{
		}

		public void UpdateUi()
		{
		}
	}
}
