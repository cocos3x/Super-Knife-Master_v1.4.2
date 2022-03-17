using FairyGUI.Utils;
using System;

namespace FairyGUI
{
	public class GGroup : GObject
	{
		private GroupLayoutType _layout;

		private int _lineGap;

		private int _columnGap;

		private bool _excludeInvisibles;

		private bool _autoSizeDisabled;

		private int _mainGridIndex;

		private int _mainGridMinSize;

		private bool _percentReady;

		private bool _boundsChanged;

		private int _mainChildIndex;

		private float _totalSize;

		private int _numChildren;

		internal int _updating;

		private Action _refreshDelegate;

		public GroupLayoutType layout
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (GroupLayoutType)null;
			}
			set
			{
			}
		}

		public int lineGap
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int columnGap
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool excludeInvisibles
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool autoSizeDisabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int mainGridMinSize
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int mainGridIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public void SetBoundsChangedFlag(bool positionChangedOnly = false)
		{
		}

		public void EnsureBoundsCorrect()
		{
		}

		private void UpdateBounds()
		{
		}

		private void HandleLayout()
		{
		}

		internal void MoveChildren(float dx, float dy)
		{
		}

		internal void ResizeChildren(float dw, float dh)
		{
		}

		protected override void HandleAlphaChanged()
		{
		}

		protected internal override void HandleVisibleChanged()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
