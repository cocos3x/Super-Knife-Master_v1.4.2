using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GLabel : GComponent, IColorGear
	{
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			public string sound;
		}

		private sealed class _003C_003Ec__DisplayClass26_1
		{
			public float volumeScale;

			public _003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals1;

			internal void _003CSetup_AfterAdd_003Eb__0()
			{
			}
		}

		protected GObject _titleObject;

		protected GObject _iconObject;

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

		public string title
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public override string text
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public bool editable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Color titleColor
		{
			get
			{
				return (Color)null;
			}
			set
			{
			}
		}

		public int titleFontSize
		{
			get
			{
				return 0;
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

		public GTextField GetTextField()
		{
			return null;
		}

		protected override void ConstructExtension(ByteBuffer buffer)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
