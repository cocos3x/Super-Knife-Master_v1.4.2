using FairyGUI.Utils;
using System;
using UnityEngine;

namespace FairyGUI
{
	public class GLoader : GObject, IAnimationGear, IColorGear
	{
		public bool showErrorSign;

		private string _url;

		private AlignType _align;

		private VertAlignType _verticalAlign;

		private bool _autoSize;

		private FillType _fill;

		private bool _shrinkOnly;

		private bool _updatingLayout;

		private PackageItem _contentItem;

		private Action<NTexture> _reloadDelegate;

		private MovieClip _content;

		private GObject _errorSign;

		private GComponent _content2;

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

		public FillMethod fillMethod
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FillMethod)null;
			}
			set
			{
			}
		}

		public int fillOrigin
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool fillClockwise
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fillAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Image image => null;

		public MovieClip movieClip => null;

		public GComponent component => null;

		public NTexture texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		protected void LoadContent()
		{
		}

		protected void LoadFromPackage(string itemURL)
		{
		}

		protected virtual void LoadExternal()
		{
		}

		protected virtual void FreeExternal(NTexture texture)
		{
		}

		protected void onExternalLoadSuccess(NTexture texture)
		{
		}

		protected void onExternalLoadFailed()
		{
		}

		private void OnExternalReload(NTexture texture)
		{
		}

		private void SetErrorState()
		{
		}

		protected void ClearErrorState()
		{
		}

		protected void UpdateLayout()
		{
		}

		private void ClearContent()
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
