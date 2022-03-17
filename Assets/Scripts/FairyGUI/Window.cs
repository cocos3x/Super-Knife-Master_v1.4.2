using System.Collections.Generic;

namespace FairyGUI
{
	public class Window : GComponent
	{
		public bool bringToFontOnClick;

		private GComponent _frame;

		private GComponent _contentPane;

		private GObject _modalWaitPane;

		private GObject _closeButton;

		private GObject _dragArea;

		private GObject _contentArea;

		private bool _modal;

		private List<IUISource> _uiSources;

		private bool _inited;

		private bool _loading;

		protected int _requestingCmd;

		public GComponent contentPane
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GComponent frame => null;

		public GObject closeButton
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GObject dragArea
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GObject contentArea
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GObject modalWaitingPane => null;

		public bool isShowing => false;

		public bool isTop => false;

		public bool modal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool modalWaiting => false;

		public void AddUISource(IUISource source)
		{
		}

		public void Show()
		{
		}

		public void ShowOn(GRoot r)
		{
		}

		public void Hide()
		{
		}

		public void HideImmediately()
		{
		}

		public void CenterOn(GRoot r, bool restraint)
		{
		}

		public void ToggleStatus()
		{
		}

		public void BringToFront()
		{
		}

		public void ShowModalWait()
		{
		}

		public void ShowModalWait(int requestingCmd)
		{
		}

		protected virtual void LayoutModalWaitPane()
		{
		}

		public bool CloseModalWait()
		{
			return false;
		}

		public bool CloseModalWait(int requestingCmd)
		{
			return false;
		}

		public void Init()
		{
		}

		protected virtual void OnInit()
		{
		}

		protected virtual void OnShown()
		{
		}

		protected virtual void OnHide()
		{
		}

		protected virtual void DoShowAnimation()
		{
		}

		protected virtual void DoHideAnimation()
		{
		}

		private void __uiLoadComplete()
		{
		}

		private void _init()
		{
		}

		public override void Dispose()
		{
		}

		protected virtual void closeEventHandler(EventContext context)
		{
		}

		private void __addedToStage()
		{
		}

		private void __removeFromStage()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __dragStart(EventContext context)
		{
		}
	}
}
