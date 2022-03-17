using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GImage : GObject, IColorGear
	{
		private Image _content;

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

		public FlipType flip
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (FlipType)null;
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

		protected override void CreateDisplayObject()
		{
		}

		public override void ConstructFromResource()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
