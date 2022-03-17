using FairyGUI;
using Master;
using UnityEngine;

namespace XREDEEM
{
	public class RedeemGuideDialog : SDialogX<RedeemGuideDialog>
	{
		private sealed class _003C_003Ec__DisplayClass15_0
		{
			public RedeemGuideDialog _003C_003E4__this;

			public int guideId;

			public Vector2 size;

			public Vector2 leftXY;
		}

		private sealed class _003C_003Ec__DisplayClass15_1
		{
			public Vector2 targetCenter;

			public _003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals1;

			internal void _003CShowGuide_003Eb__0()
			{
			}
		}

		private GImage _maskSprite;

		private GObject _finger;

		private GComponent _tips;

		private int _guideId;

		private int _initGuideId;

		private readonly STimer _timer;

		private bool _allowTouchToNextGuide;

		protected override float modalLayerAlpha => 0f;

		protected override void OnInit()
		{
		}

		protected override void InitData(object[] args)
		{
		}

		protected override void OnEnter()
		{
		}

		private void AddClickEventToGoNextGuide(GObject target)
		{
		}

		private void ClickToNextGuide(EventContext eventContext)
		{
		}

		private void GotoNextGuide()
		{
		}

		private void ShowGuide(int guideId)
		{
		}

		private void HideMaskLayer()
		{
		}

		protected override void DoShowAnimation()
		{
		}

		protected override void DoHideAnimation()
		{
		}

		protected override void OnExit()
		{
		}

		protected override void InitTouchListener()
		{
		}

		protected override void ShowModelLayer()
		{
		}

		protected override void OnUpdate()
		{
		}

		private SDialog GetCurRedeemDialog()
		{
			return null;
		}

		private void _003COnEnter_003Eb__11_0()
		{
		}

		private void _003COnEnter_003Eb__11_1()
		{
		}

		private void _003COnEnter_003Eb__11_2()
		{
		}
	}
}
