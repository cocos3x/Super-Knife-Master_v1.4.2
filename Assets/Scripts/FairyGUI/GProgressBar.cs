using FairyGUI.Utils;

namespace FairyGUI
{
	public class GProgressBar : GComponent
	{
		private sealed class _003C_003Ec__DisplayClass35_0
		{
			public string sound;
		}

		private sealed class _003C_003Ec__DisplayClass35_1
		{
			public float volumeScale;

			public _003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals1;

			internal void _003CSetup_AfterAdd_003Eb__0()
			{
			}
		}

		private double _min;

		private double _max;

		private double _value;

		private ProgressTitleType _titleType;

		private bool _reverse;

		private GObject _titleObject;

		private GMovieClip _aniObject;

		private GObject _barObjectH;

		private GObject _barObjectV;

		private float _barMaxWidth;

		private float _barMaxHeight;

		private float _barMaxWidthDelta;

		private float _barMaxHeightDelta;

		private float _barStartX;

		private float _barStartY;

		public ProgressTitleType titleType
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (ProgressTitleType)null;
			}
			set
			{
			}
		}

		public double min
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double max
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public double value
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		public bool reverse
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GTweener TweenValue(double value, float duration)
		{
			return null;
		}

		public void Update(double newValue)
		{
		}

		private bool SetFillAmount(GObject bar, float amount)
		{
			return false;
		}

		protected override void ConstructExtension(ByteBuffer buffer)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}

		protected override void HandleSizeChanged()
		{
		}
	}
}
