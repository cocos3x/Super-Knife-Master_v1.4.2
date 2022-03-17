using FairyGUI.Utils;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GComponent : GObject
	{
		private sealed class _003C_003Ec__DisplayClass123_0
		{
			public string str;

			public string str2;

			public GComponent _003C_003E4__this;

			internal void _003CConstructFromResource_003Eb__0()
			{
			}

			internal void _003CConstructFromResource_003Eb__1()
			{
			}
		}

		private Container _003CrootContainer_003Ek__BackingField;

		private Container _003Ccontainer_003Ek__BackingField;

		private ScrollPane _003CscrollPane_003Ek__BackingField;

		internal List<GObject> _children;

		internal List<Controller> _controllers;

		internal List<Transition> _transitions;

		internal bool _buildingDisplayList;

		protected Margin _margin;

		protected bool _trackBounds;

		protected bool _boundsChanged;

		protected ChildrenRenderOrder _childrenRenderOrder;

		protected int _apexIndex;

		internal Vector2 _alignOffset;

		private Vector2 _clipSoftness;

		private int _sortingChildCount;

		private Action _buildDelegate;

		private Controller _applyingController;

		private EventListener _onDrop;

		public Container rootContainer
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public Container container
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public ScrollPane scrollPane
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public EventListener onDrop => null;

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

		public bool opaque
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Margin margin
		{
			get
			{
				return (Margin)null;
			}
			set
			{
			}
		}

		public ChildrenRenderOrder childrenRenderOrder
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (ChildrenRenderOrder)null;
			}
			set
			{
			}
		}

		public int apexIndex
		{
			get
			{
				return 0;
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

		public int numChildren => 0;

		public List<Controller> Controllers => null;

		public Vector2 clipSoftness
		{
			get
			{
				return (Vector2)null;
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

		public bool reversedMask
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string baseUserData => "";

		public float viewWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float viewHeight
		{
			get
			{
				return 0f;
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

		public void InvalidateBatchingState(bool childChanged)
		{
		}

		public GObject AddChild(GObject child)
		{
			return null;
		}

		public virtual GObject AddChildAt(GObject child, int index)
		{
			return null;
		}

		private int GetInsertPosForSortingChild(GObject target)
		{
			return 0;
		}

		public GObject RemoveChild(GObject child)
		{
			return null;
		}

		public GObject RemoveChild(GObject child, bool dispose)
		{
			return null;
		}

		public GObject RemoveChildAt(int index)
		{
			return null;
		}

		public virtual GObject RemoveChildAt(int index, bool dispose)
		{
			return null;
		}

		public void RemoveChildren()
		{
		}

		public void RemoveChildren(int beginIndex, int endIndex, bool dispose)
		{
		}

		public GObject GetChildAt(int index)
		{
			return null;
		}

		public GObject GetChild(string name)
		{
			return null;
		}

		public GObject GetChildByPath(string path)
		{
			return null;
		}

		public GObject GetVisibleChild(string name)
		{
			return null;
		}

		public GObject GetChildInGroup(GGroup group, string name)
		{
			return null;
		}

		internal GObject GetChildById(string id)
		{
			return null;
		}

		public GObject[] GetChildren()
		{
			return null;
		}

		public int GetChildIndex(GObject child)
		{
			return 0;
		}

		public void SetChildIndex(GObject child, int index)
		{
		}

		public int SetChildIndexBefore(GObject child, int index)
		{
			return 0;
		}

		private int _SetChildIndex(GObject child, int oldIndex, int index)
		{
			return 0;
		}

		public void SwapChildren(GObject child1, GObject child2)
		{
		}

		public void SwapChildrenAt(int index1, int index2)
		{
		}

		public bool IsAncestorOf(GObject obj)
		{
			return false;
		}

		public void ChangeChildrenOrder(IList<GObject> objs)
		{
		}

		public void AddController(Controller controller)
		{
		}

		public Controller GetControllerAt(int index)
		{
			return null;
		}

		public Controller GetController(string name)
		{
			return null;
		}

		public void RemoveController(Controller c)
		{
		}

		public Transition GetTransitionAt(int index)
		{
			return null;
		}

		public Transition GetTransition(string name)
		{
			return null;
		}

		internal void ChildStateChanged(GObject child)
		{
		}

		private void BuildNativeDisplayList()
		{
		}

		internal void ApplyController(Controller c)
		{
		}

		private void ApplyAllControllers()
		{
		}

		internal void AdjustRadioGroupDepth(GObject obj, Controller c)
		{
		}

		public bool IsChildInView(GObject child)
		{
			return false;
		}

		public virtual int GetFirstChildInView()
		{
			return 0;
		}

		protected void SetupScroll(ByteBuffer buffer)
		{
		}

		protected void SetupOverflow(OverflowType overflow)
		{
		}

		private void UpdateClipRect()
		{
		}

		protected override void HandleSizeChanged()
		{
		}

		protected override void HandleGrayedChanged()
		{
		}

		public override void HandleControllerChanged(Controller c)
		{
		}

		public void SetBoundsChangedFlag()
		{
		}

		public void EnsureBoundsCorrect()
		{
		}

		protected virtual void UpdateBounds()
		{
		}

		protected void SetBounds(float ax, float ay, float aw, float ah)
		{
		}

		protected internal virtual void GetSnappingPosition(ref float xValue, ref float yValue)
		{
		}

		internal void ChildSortingOrderChanged(GObject child, int oldValue, int newValue)
		{
		}

		protected virtual void OnUpdate()
		{
		}

		public override void ConstructFromResource()
		{
		}

		internal void ConstructFromResource(List<GObject> objectPool, int poolIndex)
		{
		}

		protected virtual void ConstructExtension(ByteBuffer buffer)
		{
		}

		public virtual void ConstructFromXML(XML xml)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}

		private void __playSound(string soundRes, float volumeScale)
		{
		}

		private void __addedToStage()
		{
		}

		private void __removedFromStage()
		{
		}
	}
}
