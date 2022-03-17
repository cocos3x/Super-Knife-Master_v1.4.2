using FairyGUI.Utils;
using UnityEngine;

namespace FairyGUI
{
	public class GScrollBar : GComponent
	{
		private GObject _grip;

		private GObject _arrowButton1;

		private GObject _arrowButton2;

		private GObject _bar;

		private ScrollPane _target;

		private bool _vertical;

		private float _scrollPerc;

		private bool _fixedGripSize;

		private bool _gripDragging;

		private Vector2 _dragOffset;

		public float minSize => 0f;

		public bool gripDragging => false;

		public void SetScrollPane(ScrollPane target, bool vertical)
		{
		}

		public void SetDisplayPerc(float value)
		{
		}

		public void setScrollPerc(float value)
		{
		}

		protected override void ConstructExtension(ByteBuffer buffer)
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

		private void __arrowButton1Click(EventContext context)
		{
		}

		private void __arrowButton2Click(EventContext context)
		{
		}

		private void __touchBegin(EventContext context)
		{
		}
	}
}
