using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GSlider : GComponent
	{
		private double _min;

		private double _max;

		private double _value;

		private ProgressTitleType _titleType;

		private bool _reverse;

		private bool _wholeNumbers;

		private GObject _titleObject;

		private GObject _barObjectH;

		private GObject _barObjectV;

		private float _barMaxWidth;

		private float _barMaxHeight;

		private float _barMaxWidthDelta;

		private float _barMaxHeightDelta;

		private GObject _gripObject;

		private Vector2 _clickPos;

		private float _clickPercent;

		private float _barStartX;

		private float _barStartY;

		private EventListener _onChanged;

		private EventListener _onGripTouchEnd;

		public bool changeOnClick;

		public bool canDrag;

		public EventListener onChanged => null;

		public EventListener onGripTouchEnd => null;

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

		public bool wholeNumbers
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Update()
		{
		}

		private void UpdateWithPercent(float percent, bool manual)
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

		private void __gripTouchBegin(EventContext context)
		{
		}

		private void __gripTouchMove(EventContext context)
		{
		}

		private void __gripTouchEnd(EventContext context)
		{
		}

		private void __barTouchBegin(EventContext context)
		{
		}
	}
}
