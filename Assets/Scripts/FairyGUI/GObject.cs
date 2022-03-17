using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GObject : EventDispatcher
	{
		private string _003Cid_003Ek__BackingField;

		public string name;

		public object data;

		public int sourceWidth;

		public int sourceHeight;

		public int initWidth;

		public int initHeight;

		public int minWidth;

		public int maxWidth;

		public int minHeight;

		public int maxHeight;

		private Relations _003Crelations_003Ek__BackingField;

		public Rect? dragBounds;

		private GComponent _003Cparent_003Ek__BackingField;

		private DisplayObject _003CdisplayObject_003Ek__BackingField;

		private static GObject _003CdraggingObject_003Ek__BackingField;

		public PackageItem packageItem;

		private float _x;

		private float _y;

		private float _z;

		private float _pivotX;

		private float _pivotY;

		private bool _pivotAsAnchor;

		private float _alpha;

		private float _rotation;

		private float _rotationX;

		private float _rotationY;

		private bool _visible;

		private bool _internalVisible;

		private bool _handlingController;

		private bool _touchable;

		private bool _grayed;

		private bool _draggable;

		private float _scaleX;

		private float _scaleY;

		private int _sortingOrder;

		private string _tooltips;

		private GGroup _group;

		private GearBase[] _gears;

		private EventListener _onClick;

		private EventListener _onRightClick;

		private EventListener _onTouchBegin;

		private EventListener _onTouchMove;

		private EventListener _onTouchEnd;

		private EventListener _onRollOver;

		private EventListener _onRollOut;

		private EventListener _onAddedToStage;

		private EventListener _onRemovedFromStage;

		private EventListener _onKeyDown;

		private EventListener _onClickLink;

		private EventListener _onPositionChanged;

		private EventListener _onSizeChanged;

		private EventListener _onDragStart;

		private EventListener _onDragMove;

		private EventListener _onDragEnd;

		private EventListener _onGearStop;

		private EventListener _onFocusIn;

		private EventListener _onFocusOut;

		private EventListener _onDisposed;

		protected internal bool underConstruct;

		internal float _width;

		internal float _height;

		internal float _rawWidth;

		internal float _rawHeight;

		internal bool _gearLocked;

		internal float _sizePercentInGroup;

		internal bool _disposed;

		internal GTreeNode _treeNode;

		internal static uint _gInstanceCounter;

		private Vector2 _dragTouchStartPos;

		private bool _dragTesting;

		private static Vector2 sGlobalDragStart;

		private static Rect sGlobalRect;

		private static bool sUpdateInDragging;

		public string id
		{
			get
			{
				return "";
			}
			private set
			{
			}
		}

		public Relations relations
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GComponent parent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public DisplayObject displayObject
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public static GObject draggingObject
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onClick => null;

		public EventListener onRightClick => null;

		public EventListener onTouchBegin => null;

		public EventListener onTouchMove => null;

		public EventListener onTouchEnd => null;

		public EventListener onRollOver => null;

		public EventListener onRollOut => null;

		public EventListener onAddedToStage => null;

		public EventListener onRemovedFromStage => null;

		public EventListener onDisposed => null;

		public EventListener onKeyDown => null;

		public EventListener onClickLink => null;

		public EventListener onPositionChanged => null;

		public EventListener onSizeChanged => null;

		public EventListener onDragStart => null;

		public EventListener onDragMove => null;

		public EventListener onDragEnd => null;

		public EventListener onGearStop => null;

		public EventListener onFocusIn => null;

		public EventListener onFocusOut => null;

		public float x
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float y
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float z
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 xy
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return (Vector3)null;
			}
			set
			{
			}
		}

		public bool pixelSnapping
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float width
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float height
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 size
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public float actualWidth => 0f;

		public float actualHeight => 0f;

		public float xMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float yMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaleX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float scaleY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 scale
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public Vector2 skew
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public float pivotX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float pivotY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 pivot
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public bool pivotAsAnchor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool touchable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool grayed
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationX
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float rotationY
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		internal bool internalVisible => false;

		internal bool internalVisible2 => false;

		internal bool internalVisible3 => false;

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool focusable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool tabStop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool focused => false;

		public string tooltips
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string cursor
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual IFilter filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual BlendMode blendMode
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (BlendMode)null;
			}
			set
			{
			}
		}

		public string gameObjectName
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool inContainer => false;

		public bool onStage => false;

		public string resourceURL => "";

		public GearXY gearXY => null;

		public GearSize gearSize => null;

		public GearLook gearLook => null;

		public GGroup group
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GRoot root => null;

		public virtual string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual string icon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool draggable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool dragging => false;

		public bool isDisposed => false;

		public GImage asImage => null;

		public GComponent asCom => null;

		public GButton asButton => null;

		public GLabel asLabel => null;

		public GProgressBar asProgress => null;

		public GSlider asSlider => null;

		public GComboBox asComboBox => null;

		public GTextField asTextField => null;

		public GRichTextField asRichTextField => null;

		public GTextInput asTextInput => null;

		public GLoader asLoader => null;

		public GLoader3D asLoader3D => null;

		public GList asList => null;

		public GGraph asGraph => null;

		public GGroup asGroup => null;

		public GMovieClip asMovieClip => null;

		public GTree asTree => null;

		public GTreeNode treeNode => null;

		public void SetXY(float xv, float yv)
		{
		}

		public void SetXY(float xv, float yv, bool topLeftValue)
		{
		}

		public void SetPosition(float xv, float yv, float zv)
		{
		}

		public void Center()
		{
		}

		public void Center(bool restraint)
		{
		}

		public void MakeFullScreen()
		{
		}

		public void SetSize(float wv, float hv)
		{
		}

		public void SetSize(float wv, float hv, bool ignorePivot)
		{
		}

		protected void SetSizeDirectly(float wv, float hv)
		{
		}

		public void SetScale(float wv, float hv)
		{
		}

		public void SetPivot(float xv, float yv)
		{
		}

		public void SetPivot(float xv, float yv, bool asAnchor)
		{
		}

		public void RequestFocus()
		{
		}

		public void RequestFocus(bool byKey)
		{
		}

		private void __rollOver()
		{
		}

		private void __rollOut()
		{
		}

		public void SetHome(GObject obj)
		{
		}

		public GearBase GetGear(int index)
		{
			return null;
		}

		protected void UpdateGear(int index)
		{
		}

		internal bool CheckGearController(int index, Controller c)
		{
			return false;
		}

		internal void UpdateGearFromRelations(int index, float dx, float dy)
		{
		}

		internal uint AddDisplayLock()
		{
			return 0u;
		}

		internal void ReleaseDisplayLock(uint token)
		{
		}

		private void CheckGearDisplay()
		{
		}

		public void InvalidateBatchingState()
		{
		}

		public virtual void HandleControllerChanged(Controller c)
		{
		}

		public void AddRelation(GObject target, RelationType relationType)
		{
		}

		public void AddRelation(GObject target, RelationType relationType, bool usePercent)
		{
		}

		public void RemoveRelation(GObject target, RelationType relationType)
		{
		}

		public void RemoveFromParent()
		{
		}

		public void StartDrag()
		{
		}

		public void StartDrag(int touchId)
		{
		}

		public void StopDrag()
		{
		}

		public Vector2 LocalToGlobal(Vector2 pt)
		{
			return (Vector2)null;
		}

		public Vector2 GlobalToLocal(Vector2 pt)
		{
			return (Vector2)null;
		}

		public Rect LocalToGlobal(Rect rect)
		{
			return (Rect)null;
		}

		public Rect GlobalToLocal(Rect rect)
		{
			return (Rect)null;
		}

		public Vector2 LocalToRoot(Vector2 pt, GRoot r)
		{
			return (Vector2)null;
		}

		public Vector2 RootToLocal(Vector2 pt, GRoot r)
		{
			return (Vector2)null;
		}

		public Vector2 WorldToLocal(Vector3 pt)
		{
			return (Vector2)null;
		}

		public Vector2 WorldToLocal(Vector3 pt, Camera camera)
		{
			return (Vector2)null;
		}

		public Vector2 TransformPoint(Vector2 pt, GObject targetSpace)
		{
			return (Vector2)null;
		}

		public Rect TransformRect(Rect rect, GObject targetSpace)
		{
			return (Rect)null;
		}

		public virtual void Dispose()
		{
		}

		protected virtual void CreateDisplayObject()
		{
		}

		internal void InternalSetParent(GComponent value)
		{
		}

		protected virtual void HandlePositionChanged()
		{
		}

		protected virtual void HandleSizeChanged()
		{
		}

		protected virtual void HandleScaleChanged()
		{
		}

		protected virtual void HandleGrayedChanged()
		{
		}

		protected virtual void HandleAlphaChanged()
		{
		}

		protected internal virtual void HandleVisibleChanged()
		{
		}

		public virtual void ConstructFromResource()
		{
		}

		public virtual void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}

		public virtual void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}

		private void InitDrag()
		{
		}

		private void DragBegin(int touchId)
		{
		}

		private void DragEnd()
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

		public GTweener TweenMove(Vector2 endValue, float duration)
		{
			return null;
		}

		public GTweener TweenMoveX(float endValue, float duration)
		{
			return null;
		}

		public GTweener TweenMoveY(float endValue, float duration)
		{
			return null;
		}

		public GTweener TweenScale(Vector2 endValue, float duration)
		{
			return null;
		}

		public GTweener TweenScaleX(float endValue, float duration)
		{
			return null;
		}

		public GTweener TweenScaleY(float endValue, float duration)
		{
			return null;
		}

		public GTweener TweenResize(Vector2 endValue, float duration)
		{
			return null;
		}

		public GTweener TweenFade(float endValue, float duration)
		{
			return null;
		}

		public GTweener TweenRotate(float endValue, float duration)
		{
			return null;
		}
	}
}
