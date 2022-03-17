using FairyGUI;
using Master;

namespace Dialogs
{
	public class LevelAttrDialog : SDialogX<LevelAttrDialog>
	{
		private int _knifeId;

		private GComponent _top;

		private GList _itemList;

		protected override bool useContentAnimation => false;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void InitItemList()
		{
		}

		private string ToPercentString(double v)
		{
			return "";
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}
	}
}
