using FairyGUI;
using Master;
using UnityEngine;

namespace Dialogs
{
	public class GuideDialog : SDialogX<GuideDialog>
	{
		private sealed class _003C_003Ec__DisplayClass18_0
		{
			public GuideDialog _003C_003E4__this;

			public int guideId;

			internal void _003CShowGuide_003Eb__0()
			{
			}
		}

		private sealed class _003C_003Ec__DisplayClass21_0
		{
			public GuideDialog _003C_003E4__this;

			public int guideId;

			public Vector2 pos;

			internal void _003CShowTips_003Eb__0()
			{
			}
		}

		private GImage _maskSprite;

		private GMovieClip _finger;

		private GComponent _tips;

		public int _guideId;

		private int _initGuideId;

		private readonly STimer _timer;

		private bool _allowTouchToNextGuide;

		private readonly string Tag;

		protected override float modalLayerAlpha => 0f;

		private int nextGuideId => 0;

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

		private void GotoNextGuide(float delayTime = 0f)
		{
		}

		private void ShowGuide(int guideId, float delayTime)
		{
		}

		private void ShowGuide(int guideId)
		{
		}

		private GObject GetTargetBtn(int guideId)
		{
			return null;
		}

		private void ShowTips(int guideId, Vector2 pos)
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

		private void HideMaskLayer()
		{
		}

		private void SwallowTouch(bool touchablee)
		{
		}

		protected override void OnUpdate()
		{
		}

		private void _003COnEnter_003Eb__12_0()
		{
		}

		private void _003CGotoNextGuide_003Eb__15_0()
		{
		}

		private void _003CShowGuide_003Eb__19_0()
		{
		}
	}
}
