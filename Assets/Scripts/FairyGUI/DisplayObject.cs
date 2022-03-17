using System;
using UnityEngine;

namespace FairyGUI
{
	public class DisplayObject : EventDispatcher
	{
		protected internal class PaintingInfo
		{
			public Action captureDelegate;

			public Margin extend;

			public float scale;

			public int flag;
		}

		[Flags]
		protected internal enum Flags
		{
			Disposed = 0x1,
			UserGameObject = 0x2,
			TouchDisabled = 0x4,
			OutlineChanged = 0x8,
			UpdatingSize = 0x10,
			WidthChanged = 0x20,
			HeightChanged = 0x40,
			PixelPerfect = 0x80,
			LayerSet = 0x100,
			LayerFromParent = 0x200,
			NotFocusable = 0x400,
			TabStop = 0x800,
			TabStopChildren = 0x1000,
			FairyBatching = 0x2000,
			BatchingRequested = 0x4000,
			BatchingRoot = 0x8000,
			SkipBatching = 0x10000,
			CacheAsBitmap = 0x20000,
			GameObjectDisposed = 0x40000,
			DisposedWarning = 0x80000
		}

		public string name;

		private Container _003Cparent_003Ek__BackingField;

		private GameObject _003CgameObject_003Ek__BackingField;

		private Transform _003CcachedTransform_003Ek__BackingField;

		private NGraphics _003Cgraphics_003Ek__BackingField;

		private NGraphics _003CpaintingGraphics_003Ek__BackingField;

		public GObject gOwner;

		public uint id;

		private bool _visible;

		private bool _touchable;

		private Vector2 _pivot;

		private Vector3 _pivotOffset;

		private Vector3 _rotation;

		private Vector2 _skew;

		private int _renderingOrder;

		private float _alpha;

		private bool _grayed;

		private BlendMode _blendMode;

		private IFilter _filter;

		private Transform _home;

		private string _cursor;

		private bool _perspective;

		private int _focalLength;

		private Vector3 _pixelPerfectAdjustment;

		private int _checkPixelPerfect;

		private EventListener _onClick;

		private EventListener _onRightClick;

		private EventListener _onTouchBegin;

		private EventListener _onTouchMove;

		private EventListener _onTouchEnd;

		private EventListener _onRollOver;

		private EventListener _onRollOut;

		private EventListener _onMouseWheel;

		private EventListener _onAddedToStage;

		private EventListener _onRemovedFromStage;

		private EventListener _onKeyDown;

		private EventListener _onClickLink;

		private EventListener _onFocusIn;

		private EventListener _onFocusOut;

		protected internal int _paintingMode;

		protected internal PaintingInfo _paintingInfo;

		protected Rect _contentRect;

		protected NGraphics.VertexMatrix _vertexMatrix;

		protected internal Flags _flags;

		protected internal float[] _batchingBounds;

		internal static uint _gInstanceCounter;

		internal static HideFlags hideFlags;

		public Container parent
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public GameObject gameObject
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public Transform cachedTransform
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public NGraphics graphics
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public NGraphics paintingGraphics
		{
			get
			{
				return null;
			}
			protected set
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

		public EventListener onMouseWheel => null;

		public EventListener onAddedToStage => null;

		public EventListener onRemovedFromStage => null;

		public EventListener onKeyDown => null;

		public EventListener onClickLink => null;

		public EventListener onFocusIn => null;

		public EventListener onFocusOut => null;

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

		public bool pixelPerfect
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

		public bool perspective
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int focalLength
		{
			get
			{
				return 0;
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

		public Vector3 location
		{
			get
			{
				return (Vector3)null;
			}
			set
			{
			}
		}

		public virtual Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual string shader
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public virtual int renderingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int layer
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

		public bool isDisposed => false;

		public Container topmost => null;

		public Stage stage => null;

		public Container worldSpaceContainer => null;

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

		public bool touchDisabled => false;

		public bool paintingMode => false;

		public bool cacheAsBitmap
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public IFilter filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public BlendMode blendMode
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

		public Transform home
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action onPaint
		{
			add
			{
			}
			remove
			{
			}
		}

		protected void CreateGameObject(string gameObjectName)
		{
		}

		protected void SetGameObject(GameObject gameObject)
		{
		}

		protected void DestroyGameObject()
		{
		}

		public void SetXY(float xv, float yv)
		{
		}

		public void SetPosition(float xv, float yv, float zv)
		{
		}

		public void SetSize(float wv, float hv)
		{
		}

		public virtual void EnsureSizeCorrect()
		{
		}

		protected virtual void OnSizeChanged()
		{
		}

		public void SetScale(float xv, float yv)
		{
		}

		private float ValidateScale(float value)
		{
			return 0f;
		}

		private void UpdateTransformMatrix()
		{
		}

		private void UpdatePivotOffset()
		{
		}

		private void ApplyPivot()
		{
		}

		internal bool _AcceptTab()
		{
			return false;
		}

		internal void InternalSetParent(Container value)
		{
		}

		public void EnterPaintingMode()
		{
		}

		public void EnterPaintingMode(int requestorId, Margin? extend)
		{
		}

		public void EnterPaintingMode(int requestorId, Margin? extend, float scale)
		{
		}

		public void LeavePaintingMode(int requestorId)
		{
		}

		public Texture2D GetScreenShot(Margin? extend, float scale)
		{
			return null;
		}

		public virtual Rect GetBounds(DisplayObject targetSpace)
		{
			return (Rect)null;
		}

		internal DisplayObject InternalHitTest()
		{
			return null;
		}

		internal DisplayObject InternalHitTestMask()
		{
			return null;
		}

		protected virtual DisplayObject HitTest()
		{
			return null;
		}

		public Vector2 GlobalToLocal(Vector2 point)
		{
			return (Vector2)null;
		}

		public Vector2 LocalToGlobal(Vector2 point)
		{
			return (Vector2)null;
		}

		public Vector3 WorldToLocal(Vector3 worldPoint, Vector3 direction)
		{
			return (Vector3)null;
		}

		public Vector3 LocalToWorld(Vector3 localPoint)
		{
			return (Vector3)null;
		}

		public Vector2 TransformPoint(Vector2 point, DisplayObject targetSpace)
		{
			return (Vector2)null;
		}

		public Rect TransformRect(Rect rect, DisplayObject targetSpace)
		{
			return (Rect)null;
		}

		protected void TransformRectPoint(float px, float py, DisplayObject targetSpace, ref Vector4 vec4)
		{
		}

		public void RemoveFromParent()
		{
		}

		public void InvalidateBatchingState()
		{
		}

		public virtual void Update(UpdateContext context)
		{
		}

		private void UpdatePainting()
		{
		}

		private void Capture()
		{
		}

		private void UpdateHierarchy()
		{
		}

		protected virtual bool SetLayer(int value, bool fromParent)
		{
			return false;
		}

		internal void _SetLayerDirect(int value)
		{
		}

		public virtual void Dispose()
		{
		}

		internal void DisplayDisposedWarning()
		{
		}
	}
}
