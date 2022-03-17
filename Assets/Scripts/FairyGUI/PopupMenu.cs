using System;

namespace FairyGUI
{
	public class PopupMenu : EventDispatcher
	{
		protected GComponent _contentPane;

		protected GList _list;

		protected GObject _expandingItem;

		private PopupMenu _parentMenu;

		private TimerCallback _showSubMenu;

		private TimerCallback _closeSubMenu;

		private EventListener _onPopup;

		private EventListener _onClose;

		public int visibleItemCount;

		public bool hideOnClickItem;

		public bool autoSize;

		private const string EVENT_TYPE = "PopupMenuItemClick";

		public EventListener onPopup => null;

		public EventListener onClose => null;

		public int itemCount => 0;

		public GComponent contentPane => null;

		public GList list => null;

		public PopupMenu()
		{
		}

		public PopupMenu(string resourceURL)
		{
		}

		private void Create(string resourceURL)
		{
		}

		public GButton AddItem(string caption, EventCallback0 callback)
		{
			return null;
		}

		public GButton AddItem(string caption, EventCallback1 callback)
		{
			return null;
		}

		public GButton AddItemAt(string caption, int index, EventCallback1 callback)
		{
			return null;
		}

		public GButton AddItemAt(string caption, int index, EventCallback0 callback)
		{
			return null;
		}

		private GButton CreateItem(string caption, Delegate callback)
		{
			return null;
		}

		public void AddSeperator()
		{
		}

		public void AddSeperator(int index)
		{
		}

		public string GetItemName(int index)
		{
			return "";
		}

		public void SetItemText(string name, string caption)
		{
		}

		public void SetItemVisible(string name, bool visible)
		{
		}

		public void SetItemGrayed(string name, bool grayed)
		{
		}

		public void SetItemCheckable(string name, bool checkable)
		{
		}

		public void SetItemChecked(string name, bool check)
		{
		}

		public bool isItemChecked(string name)
		{
			return false;
		}

		public bool IsItemChecked(string name)
		{
			return false;
		}

		public void RemoveItem(string name)
		{
		}

		public void ClearItems()
		{
		}

		public void Dispose()
		{
		}

		public void Show()
		{
		}

		public void Show(GObject target)
		{
		}

		public void Show(GObject target, object downward)
		{
		}

		public void Show(GObject target, PopupDirection dir)
		{
		}

		public void Show(GObject target, PopupDirection dir, PopupMenu parentMenu)
		{
		}

		public void Hide()
		{
		}

		private void ShowSubMenu(GObject item)
		{
		}

		private void CloseSubMenu(object param)
		{
		}

		private void __clickItem(EventContext context)
		{
		}

		private void __addedToStage()
		{
		}

		private void __removeFromStage()
		{
		}

		private void __rollOver(EventContext context)
		{
		}

		private void __showSubMenu(object param)
		{
		}

		private void __rollOut(EventContext context)
		{
		}
	}
}
