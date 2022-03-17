using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GLoader3D : GObject, IAnimationGear, IColorGear
	{
		private string _url;

		private AlignType _align;

		private VertAlignType _verticalAlign;

		private bool _autoSize;

		private FillType _fill;

		private bool _shrinkOnly;

		private string _animationName;

		private string _skinName;

		private bool _playing;

		private int _frame;

		private bool _loop;

		private bool _updatingLayout;

		private Color _color;

		protected PackageItem _contentItem;

		protected GoWrapper _content;

		private float _003CtimeScale_003Ek__BackingField;

		private bool _003CignoreEngineTimeScale_003Ek__BackingField;

		public string url
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override string icon
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public AlignType align
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (AlignType)null;
			}
			set
			{
			}
		}

		public VertAlignType verticalAlign
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (VertAlignType)null;
			}
			set
			{
			}
		}

		public FillType fill
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FillType)null;
			}
			set
			{
			}
		}

		public bool shrinkOnly
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool autoSize
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool playing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int frame
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float timeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool ignoreEngineTimeScale
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool loop
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string animationName
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public string skinName
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string shader
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public Color color
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public GameObject wrapTarget => null;

		public override IFilter filter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override BlendMode blendMode
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

		protected override void CreateDisplayObject()
		{
		}

		public override void Dispose()
		{
		}

		public void Advance(float time)
		{
		}

		public void SetWrapTarget(GameObject gameObject, bool cloneMaterial, int width, int height)
		{
		}

		protected void LoadContent()
		{
		}

		protected virtual void OnChange(string propertyName)
		{
		}

		protected virtual void LoadExternal()
		{
		}

		protected virtual void FreeExternal()
		{
		}

		protected void UpdateLayout()
		{
		}

		protected void ClearContent()
		{
		}

		protected void OnUpdateContent(UpdateContext context)
		{
		}

		protected override void HandleSizeChanged()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
