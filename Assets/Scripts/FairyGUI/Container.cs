using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class Container : DisplayObject
	{
		private struct DescendantsEnumerator : IEnumerator<DisplayObject>, IEnumerator, IDisposable
		{
			private Container _root;

			private Container _com;

			private DisplayObject _current;

			private int _index;

			private bool _forward;

			public DisplayObject Current => null;

			private object System_002ECollections_002EIEnumerator_002ECurrent => null;

			public DescendantsEnumerator(Container root, bool backward)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}

			public void Dispose()
			{
			}
		}

		public RenderMode renderMode;

		public Camera renderCamera;

		public bool opaque;

		public Vector4? clipSoftness;

		public IHitTest hitArea;

		public bool touchChildren;

		public bool reversedMask;

		private List<DisplayObject> _children;

		private DisplayObject _mask;

		private Rect? _clipRect;

		private List<DisplayObject> _descendants;

		internal int _panelOrder;

		internal DisplayObject _lastFocus;

		public int numChildren => 0;

		public Rect? clipRect
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DisplayObject mask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool fairyBatching
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool tabStopChildren
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public event Action onUpdate
		{
			add
			{
			}
			remove
			{
			}
		}

		public Container()
		{
		}

		public Container(string gameObjectName)
		{
		}

		public Container(GameObject attachTarget)
		{
		}

		private void Init()
		{
		}

		public DisplayObject AddChild(DisplayObject child)
		{
			return null;
		}

		public DisplayObject AddChildAt(DisplayObject child, int index)
		{
			return null;
		}

		public bool Contains(DisplayObject child)
		{
			return false;
		}

		public DisplayObject GetChildAt(int index)
		{
			return null;
		}

		public DisplayObject GetChild(string name)
		{
			return null;
		}

		public DisplayObject[] GetChildren()
		{
			return null;
		}

		public int GetChildIndex(DisplayObject child)
		{
			return 0;
		}

		public DisplayObject RemoveChild(DisplayObject child)
		{
			return null;
		}

		public DisplayObject RemoveChild(DisplayObject child, bool dispose)
		{
			return null;
		}

		public DisplayObject RemoveChildAt(int index)
		{
			return null;
		}

		public DisplayObject RemoveChildAt(int index, bool dispose)
		{
			return null;
		}

		public void RemoveChildren()
		{
		}

		public void RemoveChildren(int beginIndex, int endIndex, bool dispose)
		{
		}

		public void SetChildIndex(DisplayObject child, int index)
		{
		}

		public void SwapChildren(DisplayObject child1, DisplayObject child2)
		{
		}

		public void SwapChildrenAt(int index1, int index2)
		{
		}

		public void ChangeChildrenOrder(IList<int> indice, IList<DisplayObject> objs)
		{
		}

		public IEnumerator<DisplayObject> GetDescendants(bool backward)
		{
			return null;
		}

		public void CreateGraphics()
		{
		}

		public override Rect GetBounds(DisplayObject targetSpace)
		{
			return (Rect)null;
		}

		public Camera GetRenderCamera()
		{
			return null;
		}

		public DisplayObject HitTest(Vector2 stagePoint, bool forTouch)
		{
			return null;
		}

		protected override DisplayObject HitTest()
		{
			return null;
		}

		private DisplayObject HitTest_Container()
		{
			return null;
		}

		public bool IsAncestorOf(DisplayObject obj)
		{
			return false;
		}

		internal void UpdateBatchingFlags()
		{
		}

		public void InvalidateBatchingState(bool childrenChanged)
		{
		}

		public void SetChildrenLayer(int value)
		{
		}

		public override void Update(UpdateContext context)
		{
		}

		private void SetRenderingOrder(UpdateContext context)
		{
		}

		private void DoFairyBatching()
		{
		}

		private void CollectChildren(Container initiator, bool outlineChanged)
		{
		}

		public override void Dispose()
		{
		}
	}
}
