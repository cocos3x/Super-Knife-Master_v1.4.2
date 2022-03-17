using FairyGUI.Utils;
using System;
using UnityEngine;

namespace FairyGUI
{
	public class ScrollPane : EventDispatcher
	{
		private static ScrollPane _003CdraggingPane_003Ek__BackingField;

		private ScrollType _scrollType;

		private float _scrollStep;

		private float _decelerationRate;

		private Margin _scrollBarMargin;

		private bool _bouncebackEffect;

		private bool _touchEffect;

		private bool _scrollBarDisplayAuto;

		private bool _vScrollNone;

		private bool _hScrollNone;

		private bool _needRefresh;

		private int _refreshBarAxis;

		private bool _displayOnLeft;

		private bool _snapToItem;

		internal bool _displayInDemand;

		private bool _mouseWheelEnabled;

		private bool _softnessOnTopOrLeftSide;

		private bool _pageMode;

		private Vector2 _pageSize;

		private bool _inertiaDisabled;

		private bool _maskDisabled;

		private bool _floating;

		private bool _dontClipMargin;

		private float _xPos;

		private float _yPos;

		private Vector2 _viewSize;

		private Vector2 _contentSize;

		private Vector2 _overlapSize;

		private Vector2 _containerPos;

		private Vector2 _beginTouchPos;

		private Vector2 _lastTouchPos;

		private Vector2 _lastTouchGlobalPos;

		private Vector2 _velocity;

		private float _velocityScale;

		private float _lastMoveTime;

		private bool _dragged;

		private bool _isHoldAreaDone;

		private int _aniFlag;

		internal int _loop;

		private int _headerLockedSize;

		private int _footerLockedSize;

		private bool _hover;

		private int _tweening;

		private Vector2 _tweenStart;

		private Vector2 _tweenChange;

		private Vector2 _tweenTime;

		private Vector2 _tweenDuration;

		private Action _refreshDelegate;

		private TimerCallback _tweenUpdateDelegate;

		private GTweenCallback1 _hideScrollBarDelegate;

		private GComponent _owner;

		private Container _maskContainer;

		private Container _container;

		private GScrollBar _hzScrollBar;

		private GScrollBar _vtScrollBar;

		private GComponent _header;

		private GComponent _footer;

		private Controller _pageController;

		private EventListener _onScroll;

		private EventListener _onScrollEnd;

		private EventListener _onPullDownRelease;

		private EventListener _onPullUpRelease;

		private static int _gestureFlag;

		public static float TWEEN_TIME_GO;

		public static float TWEEN_TIME_DEFAULT;

		public static float PULL_RATIO;

		public static ScrollPane draggingPane
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onScroll => null;

		public EventListener onScrollEnd => null;

		public EventListener onPullDownRelease => null;

		public EventListener onPullUpRelease => null;

		public GComponent owner => null;

		public GScrollBar hzScrollBar => null;

		public GScrollBar vtScrollBar => null;

		public GComponent header => null;

		public GComponent footer => null;

		public bool bouncebackEffect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool touchEffect
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool inertiaDisabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool softnessOnTopOrLeftSide
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float scrollStep
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool snapToItem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool pageMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Controller pageController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool mouseWheelEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float decelerationRate
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isDragged => false;

		public float percX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float percY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float posX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float posY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isBottomMost => false;

		public bool isRightMost => false;

		public int currentPageX
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int currentPageY
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float scrollingPosX => 0f;

		public float scrollingPosY => 0f;

		public float contentWidth => 0f;

		public float contentHeight => 0f;

		public float viewWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float viewHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public ScrollPane(GComponent owner)
		{
		}

		public void Setup(ByteBuffer buffer)
		{
		}

		public void Dispose()
		{
		}

		public void SetPercX(float value, bool ani)
		{
		}

		public void SetPercY(float value, bool ani)
		{
		}

		public void SetPosX(float value, bool ani)
		{
		}

		public void SetPosY(float value, bool ani)
		{
		}

		public void SetCurrentPageX(int value, bool ani)
		{
		}

		public void SetCurrentPageY(int value, bool ani)
		{
		}

		public void ScrollTop()
		{
		}

		public void ScrollTop(bool ani)
		{
		}

		public void ScrollBottom()
		{
		}

		public void ScrollBottom(bool ani)
		{
		}

		public void ScrollUp()
		{
		}

		public void ScrollUp(float ratio, bool ani)
		{
		}

		public void ScrollDown()
		{
		}

		public void ScrollDown(float ratio, bool ani)
		{
		}

		public void ScrollLeft()
		{
		}

		public void ScrollLeft(float ratio, bool ani)
		{
		}

		public void ScrollRight()
		{
		}

		public void ScrollRight(float ratio, bool ani)
		{
		}

		public void ScrollToView(GObject obj)
		{
		}

		public void ScrollToView(GObject obj, bool ani)
		{
		}

		public void ScrollToView(GObject obj, bool ani, bool setFirst)
		{
		}

		public void ScrollToView(Rect rect, bool ani, bool setFirst)
		{
		}

		public bool IsChildInView(GObject obj)
		{
			return false;
		}

		public void CancelDragging()
		{
		}

		public void LockHeader(int size)
		{
		}

		public void LockFooter(int size)
		{
		}

		internal void OnOwnerSizeChanged()
		{
		}

		internal void HandleControllerChanged(Controller c)
		{
		}

		private void UpdatePageController()
		{
		}

		internal void AdjustMaskContainer()
		{
		}

		private void SetSize(float aWidth, float aHeight)
		{
		}

		internal void SetContentSize(float aWidth, float aHeight)
		{
		}

		internal void ChangeContentSizeOnScrolling(float deltaWidth, float deltaHeight, float deltaPosX, float deltaPosY)
		{
		}

		private void HandleSizeChanged()
		{
		}

		private void PosChanged(bool ani)
		{
		}

		private void Refresh()
		{
		}

		private void Refresh2()
		{
		}

		private void __touchBegin(EventContext context)
		{
		}

		private void __touchMove(EventContext context)
		{
		}

		private void __touchEnd(EventContext context)
		{
		}

		private void __mouseWheel(EventContext context)
		{
		}

		private void __rollOver()
		{
		}

		private void __rollOut()
		{
		}

		internal void UpdateClipSoft()
		{
		}

		private void UpdateScrollBarPos()
		{
		}

		public void UpdateScrollBarVisible()
		{
		}

		private void UpdateScrollBarVisible2(GScrollBar bar)
		{
		}

		private void __barTweenComplete(GTweener tweener)
		{
		}

		private float GetLoopPartSize(float division, int axis)
		{
			return 0f;
		}

		private bool LoopCheckingCurrent()
		{
			return false;
		}

		private void LoopCheckingTarget(ref Vector2 endPos)
		{
		}

		private void LoopCheckingTarget(ref Vector2 endPos, int axis)
		{
		}

		private void LoopCheckingNewPos(ref float value, int axis)
		{
		}

		private void AlignPosition(ref Vector2 pos, bool inertialScrolling)
		{
		}

		private float AlignByPage(float pos, int axis, bool inertialScrolling)
		{
			return 0f;
		}

		private Vector2 UpdateTargetAndDuration(Vector2 orignPos)
		{
			return (Vector2)null;
		}

		private float UpdateTargetAndDuration(float pos, int axis)
		{
			return 0f;
		}

		private void FixDuration(int axis, float oldChange)
		{
		}

		private void StartTween(int type)
		{
		}

		private void KillTween()
		{
		}

		private void CheckRefreshBar()
		{
		}

		private void TweenUpdate(object param)
		{
		}

		private float RunTween(int axis)
		{
			return 0f;
		}

		private static float EaseFunc(float t, float d)
		{
			return 0f;
		}
	}
}
