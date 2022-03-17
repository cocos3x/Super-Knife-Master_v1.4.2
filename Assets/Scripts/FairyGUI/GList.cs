using FairyGUI.Utils;
using System.Collections.Generic;
using UnityEngine;

namespace FairyGUI
{
	public class GList : GComponent
	{
		private class ItemInfo
		{
			public Vector2 size;

			public GObject obj;

			public uint updateFlag;

			public bool selected;
		}

		public string defaultItem;

		public bool foldInvisibleItems;

		public ListSelectionMode selectionMode;

		public ListItemRenderer itemRenderer;

		public ListItemProvider itemProvider;

		public bool scrollItemToViewOnClick;

		private ListLayoutType _layout;

		private int _lineCount;

		private int _columnCount;

		private int _lineGap;

		private int _columnGap;

		private AlignType _align;

		private VertAlignType _verticalAlign;

		private bool _autoResizeItem;

		private Controller _selectionController;

		private GObjectPool _pool;

		private int _lastSelectedIndex;

		private EventListener _onClickItem;

		private EventListener _onRightClickItem;

		private bool _virtual;

		private bool _loop;

		private int _numItems;

		private int _realNumItems;

		private int _firstIndex;

		private int _curLineItemCount;

		private int _curLineItemCount2;

		private Vector2 _itemSize;

		private int _virtualListChanged;

		private uint itemInfoVer;

		private int _miscFlags;

		private List<ItemInfo> _virtualItems;

		private EventCallback1 _itemClickDelegate;

		public EventListener onClickItem => null;

		public EventListener onRightClickItem => null;

		public ListLayoutType layout
		{
			get
			{
				//IL_0003: Expected I4, but got O
				return (ListLayoutType)null;
			}
			set
			{
			}
		}

		public int lineCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int columnCount
		{
			get
			{
				return 0;
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

		public bool autoResizeItem
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 defaultItemSize
		{
			get
			{
				return (Vector2)null;
			}
			set
			{
			}
		}

		public GObjectPool itemPool => null;

		public int selectedIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Controller selectionController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GObject touchItem => null;

		public bool isVirtual => false;

		public int numItems
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void Dispose()
		{
		}

		public GObject GetFromPool(string url)
		{
			return null;
		}

		private void ReturnToPool(GObject obj)
		{
		}

		public GObject AddItemFromPool()
		{
			return null;
		}

		public GObject AddItemFromPool(string url)
		{
			return null;
		}

		public override GObject AddChildAt(GObject child, int index)
		{
			return null;
		}

		public override GObject RemoveChildAt(int index, bool dispose)
		{
			return null;
		}

		public void RemoveChildToPoolAt(int index)
		{
		}

		public void RemoveChildToPool(GObject child)
		{
		}

		public void RemoveChildrenToPool()
		{
		}

		public void RemoveChildrenToPool(int beginIndex, int endIndex)
		{
		}

		public List<int> GetSelection()
		{
			return null;
		}

		public List<int> GetSelection(List<int> result)
		{
			return null;
		}

		public void AddSelection(int index, bool scrollItToView)
		{
		}

		public void RemoveSelection(int index)
		{
		}

		public void ClearSelection()
		{
		}

		private void ClearSelectionExcept(GObject g)
		{
		}

		public void SelectAll()
		{
		}

		public void SelectNone()
		{
		}

		public void SelectReverse()
		{
		}

		public void EnableSelectionFocusEvents(bool enabled)
		{
		}

		private void NotifySelection(EventContext context)
		{
		}

		public void EnableArrowKeyNavigation(bool enabled)
		{
		}

		private void __keydown(EventContext context)
		{
		}

		public int HandleArrowKey(int dir)
		{
			return 0;
		}

		private void __clickItem(EventContext context)
		{
		}

		protected virtual void DispatchItemEvent(GObject item, EventContext context)
		{
		}

		private void SetSelectionOnEvent(GObject item, InputEvent evt)
		{
		}

		public void ResizeToFit()
		{
		}

		public void ResizeToFit(int itemCount)
		{
		}

		public void ResizeToFit(int itemCount, int minSize)
		{
		}

		protected override void HandleSizeChanged()
		{
		}

		public override void HandleControllerChanged(Controller c)
		{
		}

		private void UpdateSelectionController(int index)
		{
		}

		public void ScrollToView(int index)
		{
		}

		public void ScrollToView(int index, bool ani)
		{
		}

		public void ScrollToView(int index, bool ani, bool setFirst)
		{
		}

		public override int GetFirstChildInView()
		{
			return 0;
		}

		public int ChildIndexToItemIndex(int index)
		{
			return 0;
		}

		public int ItemIndexToChildIndex(int index)
		{
			return 0;
		}

		public void SetVirtual()
		{
		}

		public void SetVirtualAndLoop()
		{
		}

		private void SetVirtual(bool loop)
		{
		}

		public void RefreshVirtualList()
		{
		}

		private void CheckVirtualList()
		{
		}

		private void SetVirtualListChangedFlag(bool layoutChanged)
		{
		}

		private void RefreshVirtualList(object param)
		{
		}

		private void __scrolled(EventContext context)
		{
		}

		private int GetIndexOnPos1(ref float pos, bool forceUpdate)
		{
			return 0;
		}

		private int GetIndexOnPos2(ref float pos, bool forceUpdate)
		{
			return 0;
		}

		private int GetIndexOnPos3(ref float pos, bool forceUpdate)
		{
			return 0;
		}

		private void HandleScroll(bool forceUpdate)
		{
		}

		private bool HandleScroll1(bool forceUpdate)
		{
			return false;
		}

		private bool HandleScroll2(bool forceUpdate)
		{
			return false;
		}

		private void HandleScroll3(bool forceUpdate)
		{
		}

		private void HandleArchOrder1()
		{
		}

		private void HandleArchOrder2()
		{
		}

		protected internal override void GetSnappingPosition(ref float xValue, ref float yValue)
		{
		}

		private void HandleAlign(float contentWidth, float contentHeight)
		{
		}

		protected override void UpdateBounds()
		{
		}

		public override void Setup_BeforeAdd(ByteBuffer buffer, int beginPos)
		{
		}

		protected virtual void ReadItems(ByteBuffer buffer)
		{
		}

		protected void SetupItem(ByteBuffer buffer, GObject obj)
		{
		}

		public override void Setup_AfterAdd(ByteBuffer buffer, int beginPos)
		{
		}
	}
}
