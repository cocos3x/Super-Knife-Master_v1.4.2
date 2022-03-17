using FairyGUI.Utils;
using System.Collections.Generic;

namespace FairyGUI
{
	public class Controller : EventDispatcher
	{
		public string name;

		internal GComponent parent;

		internal bool autoRadioGroupDepth;

		internal bool changing;

		private int _selectedIndex;

		private int _previousIndex;

		private List<string> _pageIds;

		private List<string> _pageNames;

		private List<ControllerAction> _actions;

		private EventListener _onChanged;

		private static uint _nextPageId;

		public EventListener onChanged => null;

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

		public string selectedPage
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		public int previsousIndex => 0;

		public string previousPage => "";

		public int pageCount => 0;

		internal string selectedPageId
		{
			get
			{
				return "";
			}
			set
			{
			}
		}

		internal string oppositePageId
		{
			set
			{
			}
		}

		internal string previousPageId => "";

		public void Dispose()
		{
		}

		public void SetSelectedIndex(int value)
		{
		}

		public void SetSelectedPage(string value)
		{
		}

		public string GetPageName(int index)
		{
			return "";
		}

		public string GetPageId(int index)
		{
			return "";
		}

		public string GetPageIdByName(string aName)
		{
			return "";
		}

		public void AddPage(string name)
		{
		}

		public void AddPageAt(string name, int index)
		{
		}

		public void RemovePage(string name)
		{
		}

		public void RemovePageAt(int index)
		{
		}

		public void ClearPages()
		{
		}

		public bool HasPage(string aName)
		{
			return false;
		}

		internal int GetPageIndexById(string aId)
		{
			return 0;
		}

		internal string GetPageNameById(string aId)
		{
			return "";
		}

		public void RunActions()
		{
		}

		public void Setup(ByteBuffer buffer)
		{
		}
	}
}
